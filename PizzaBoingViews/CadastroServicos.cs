using HelpDesk.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelpDesk.Dominio.Entidades;

namespace PizzaBoingViews
{
    public partial class frmCadastroServicos : Form
    {
        private RepositorioServicos _repositorio;
        public RepositorioServicos Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioServicos(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        private Int64 ID;
        Servicos Servico;

        public frmCadastroServicos()
        {
            InitializeComponent();
            GerarCodigoId();
        }

        private void PreencherCampos(int Preencherservico)
        {
            ID = Preencherservico;
            Servico = Repositorio.ObterPorId(Preencherservico);
            txtCodigo.Text = Preencherservico.ToString() ;
            txtDescricao.Text = Servico.Descricao; 
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F4)
            {
                this.Close();
                return true;    // Indica que o pressionar desta tecla 
                                // foi gerenciado aqui.
            }

            // Propaga o evento para o método da classe base
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Servico.Descricao = txtDescricao.Text;

            if (ID == 0)
                Repositorio.Salvar(Servico);
            else
            {
                Servico.ID = ID;
                bool resultado = RotinaPadrao<Servicos>.ExecutarAlteracao(Servico, RepositorioAlteracao.Servicos);
                if (resultado)
                {
                    MessageBox.Show("Serviço alterado com sucesso", "Alterado Com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Repositorio.Alterar(Servico);
                }
                else
                {
                    MessageBox.Show("O serviço não pode ser alterado, pois já existe algum pagamento com ele", "Não foi Possivel Alterar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    LimparControles();
                }
            }
            LimparControles();
            GerarCodigoId();
            SituacaoGrupoBox(false);
        }

        private void LimparControles()
        {
            RotinaPadrao<Bairros>.limparTextBoxes(this); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SituacaoGrupoBox(false);
            ID = 0;
            LimparControles();
            GerarCodigoId();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            SituacaoGrupoBox(true);
            frmConsultaServicos f = new frmConsultaServicos();
            f.ShowDialog();
            try
            {
                PreencherCampos(frmConsultaServicos.CodigoServico);
            }
            catch (Exception erro)
            {
                SituacaoGrupoBox(false);
                erro.HelpLink = "Nenhum Serviço Selecionado";
                MessageBox.Show(erro.HelpLink);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Servico = new Servicos();
            SituacaoGrupoBox(true);
            LimparControles();
            ID = 0;
            GerarCodigoId();
            txtDescricao.Focus();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    _repositorio = null;
                    PreencherCampos(int.Parse(txtCodigo.Text));
                    SituacaoGrupoBox(true);
                }
                catch (Exception erro)
                {
                    erro.HelpLink = "Bairro não encontrado";
                    SituacaoGrupoBox(false);
                    GerarCodigoId();
                    LimparControles();
                    MessageBox.Show(erro.HelpLink);
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void SituacaoGrupoBox(bool situacao)
        {
            grbCadastroServico.Enabled = situacao;
        }
        private void GerarCodigoId()
        {
            txtCodigo.Text = RotinaPadrao<Servicos>.GerarId(Repositorio);
        }
    }
}
