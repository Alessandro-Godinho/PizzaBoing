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
    public partial class frmCadastroFuncionarios : Form
    {
        private RepositorioFuncionarios _repositorio;
        public RepositorioFuncionarios Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioFuncionarios(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        private Int64 ID;
        HelpDesk.Dominio.Entidades.Funcionarios funcionarios;
        RepositorioBairros RepBairros = new RepositorioBairros(NHibernateHelper.GetSession());

        public frmCadastroFuncionarios()
        {
            InitializeComponent();
            LimparControles();
            GerarCodigoId();
            cmbBairro.DataSource = RepBairros.ObterTodos();
        }

        private void PreencherCampos(long IdFuncionarios)
        {
            ID = IdFuncionarios;
            funcionarios = Repositorio.ObterPorId(ID);
            cmbBairro.DataSource = RepBairros.ObterTodos();
            txtCodigo.Text = funcionarios.ID.ToString();
            txtValorComissao.Text = funcionarios.Comissao.ToString();
            txtEndereco.Text = funcionarios.Endereço;
            txtNumero.Text = funcionarios.Numero;
            txtNome.Text = funcionarios.Nome;
            txtTelefone.Text = funcionarios.Telefone.ToString();
            cmbBairro.SelectedValue = funcionarios.Bairro.ID;
            cmbBairro.Refresh();
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
            funcionarios.Nome = txtNome.Text;
            funcionarios.Telefone = txtTelefone.Text;
            funcionarios.Comissao = double.Parse(txtValorComissao.Text);
            funcionarios.Endereço = txtEndereco.Text;
            funcionarios.Numero = txtNumero.Text;
            funcionarios.Bairro = RepBairros.ObterPorId(Int64.Parse(cmbBairro.SelectedValue.ToString()));
            funcionarios.Situacao = HelpDesk.Dominio.ObjetosValor.Situacao.Ativo;

            if (ID == 0)
                Repositorio.Salvar(funcionarios);
            else
            {
                funcionarios.ID = ID;
                bool resultado1 = RotinaPadrao<Funcionarios>.ExecutarAlteracao(funcionarios, RepositorioAlteracao.Compras);
                bool resultado2 = RotinaPadrao<Funcionarios>.ExecutarAlteracao(funcionarios, RepositorioAlteracao.Vendas);
                if (resultado1 && resultado2)
                {
                    MessageBox.Show("Funcionario alterado com sucesso", "Alterado Com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Repositorio.Alterar(funcionarios);
                }
                else
                {
                    MessageBox.Show("O funcionário não pode ser alterado, pois ele ja realizou algum pedido de compra ou venda", "Não foi Possivel Alterar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    LimparControles();
                }
            }

            LimparControles();
            GerarCodigoId();
            SituacaoGrupoBox(false);
        }

        private void LimparControles()
        {
            RotinaPadrao<Funcionarios>.limparTextBoxes(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ID = 0;
            LimparControles();
            GerarCodigoId();
            SituacaoGrupoBox(false);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            SituacaoGrupoBox(true);
            frmConsultaFuncionarios f = new frmConsultaFuncionarios();
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
            try
            {
                PreencherCampos(frmConsultaFuncionarios.Id_Funcionarios);
            }
            catch (Exception erro)
            {
                SituacaoGrupoBox(false);
                erro.HelpLink = "Nenhum Funcinário Selecionado";
                MessageBox.Show(erro.HelpLink);
            }
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            funcionarios = new Funcionarios();
            SituacaoGrupoBox(true);
            LimparControles();
            ID = 0;
            GerarCodigoId();
            txtValorComissao.Focus();
        }

        private void SituacaoGrupoBox(bool situacao)
        {
            grbCadastroFuncionarios.Enabled = situacao;
        }

        private void GerarCodigoId()
        {
            txtCodigo.Text = RotinaPadrao<Funcionarios>.GerarId(Repositorio);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    PreencherCampos(int.Parse(txtCodigo.Text));
                    SituacaoGrupoBox(true);
                }
                catch (Exception erro)
                {
                    erro.HelpLink = "Funcionário não encontrado";
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
    }
}

