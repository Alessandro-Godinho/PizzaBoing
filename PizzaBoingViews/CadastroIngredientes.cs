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
    public partial class frmCadastroIngredientes : Form
    {
        private RepositorioIngredientes _repositorio;
        public RepositorioIngredientes Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioIngredientes(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        private Int64 ID;
        HelpDesk.Dominio.Entidades.Ingredientes ingredientes;

        public frmCadastroIngredientes()
        {
            InitializeComponent();
            LimparControles();
            GerarCodigoId();            
        }

        private void PreencherCampos(int IdIgrediente)
        {
            ID = IdIgrediente;
            ingredientes = Repositorio.ObterPorId(ID);
            txtCodigo.Text = ingredientes.ID.ToString();
            txtUnidade.Text = ingredientes.Unidade.ToString();
            txtDescricao.Text = ingredientes.Descricao;
            txtValor.Text = ingredientes.Valor.ToString();
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
            RemoverFormatacao();
            ingredientes.Descricao = txtDescricao.Text;
            ingredientes.Unidade = txtUnidade.Text;
            ingredientes.Valor = double.Parse(txtValor.Text);
            ingredientes.Situacao = HelpDesk.Dominio.ObjetosValor.Situacao.Ativo;

            if (ID == 0)
                Repositorio.Salvar(ingredientes);
            else
            {
                ingredientes.ID = ID;
                Repositorio.Alterar(ingredientes);
                ID = 0;
            }

            LimparControles();
            GerarCodigoId();
            SituacaoGrupoBox(false);
        }

        private void LimparControles()
        {
            RotinaPadrao<Ingredientes>.limparTextBoxes(this);
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
            frmConsultaIngredientes f = new frmConsultaIngredientes();
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
            try
            {
                PreencherCampos(frmConsultaIngredientes.CodigoIngrediente);
            }
            catch (Exception erro)
            {
                SituacaoGrupoBox(false);
                erro.HelpLink = "Nenhum Ingrediente Selecionado";
                MessageBox.Show(erro.HelpLink);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ingredientes = new Ingredientes();
            SituacaoGrupoBox(true);
            LimparControles();
            ID = 0;
            GerarCodigoId();
            txtDescricao.Focus();
        }
        private void SituacaoGrupoBox(bool situacao)
        {
            grbCadastroIngrediente.Enabled = situacao;
        }

        private void GerarCodigoId()
        {
            txtCodigo.Text = RotinaPadrao<Ingredientes>.GerarId(Repositorio);
        }

        private void RemoverFormatacao()
        {
            txtValor.Text = RotinaPadrao<Ingredientes>.TirarFormatacao(txtValor.Text);
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
                    erro.HelpLink = "Ingrediente não encontrado";
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

        private void txtValor_Leave(object sender, EventArgs e)
        {
            txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("C");
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
           (e.KeyChar != ',' && e.KeyChar != '.' &&
            e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValor.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }
    }
}

