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
    public partial class frmCadastroFornecedor : Form
    {
        private RepositorioFornecedores _repositorio;
        public RepositorioFornecedores Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioFornecedores(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        private Int64 ID;
        HelpDesk.Dominio.Entidades.Fornecedores fornecedores;

        public frmCadastroFornecedor()
        {
            InitializeComponent();
            LimparControles();
            GerarCodigoId();
        }

        private void PreencherCampos(int IdFornecedor)
        {
            ID = IdFornecedor;
            fornecedores = Repositorio.ObterPorId(ID);
            txtCidade.Text = fornecedores.Cidade;
            txtCodigo.Text = fornecedores.ID.ToString();
            txtEmail.Text = fornecedores.Email;
            txtEndereco.Text = fornecedores.Endereco;
            txtNumero.Text = fornecedores.Numero;
            txtNomeEmpresa.Text = fornecedores.NomeEmpresa;
            txtTelefone1.Text = fornecedores.Telefone.ToString();
            txtTelefone2.Text = fornecedores.Telefone2.ToString();
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
            if (Validacoes.ValidarEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("E-mail Inválido, ex: meuemail@gmail.com", "E-mail Inválido");
            }
            else
            {
                fornecedores.NomeEmpresa = txtNomeEmpresa.Text;
                fornecedores.Telefone = txtTelefone1.Text;
                fornecedores.Telefone2 = txtTelefone2.Text;
                fornecedores.Endereco = txtEndereco.Text;
                fornecedores.Numero = txtNumero.Text;
                fornecedores.Email = txtEmail.Text;
                fornecedores.Cidade = txtCidade.Text;
                fornecedores.Situacao = HelpDesk.Dominio.ObjetosValor.Situacao.Ativo;

                if (ID == 0)
                    Repositorio.Salvar(fornecedores);
                else
                {
                    fornecedores.ID = ID;
                    bool resultado = RotinaPadrao<Fornecedores>.ExecutarAlteracao(fornecedores, RepositorioAlteracao.Compras);
                    if (resultado)
                    {
                        MessageBox.Show("Fornecedor alterado com sucesso", "Alterado Com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Repositorio.Alterar(fornecedores);
                    }
                    else
                    {
                        MessageBox.Show("O fornecedor não pode ser alterado, pois já foi realizado algum pedido de compra desse fornecedor", "Não foi Possivel Alterar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        LimparControles();
                    }
                }
                LimparControles();
                GerarCodigoId();
                SituacaoGrupoBox(false);
            }
        }

        private void LimparControles()
        {
            RotinaPadrao<Clientes>.limparTextBoxes(this);
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
            frmConsultaFornecedores f = new frmConsultaFornecedores();
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();

            try
            {
                PreencherCampos(frmConsultaFornecedores.passarCodigoFornecedor);
            }
            catch (Exception erro)
            {
                SituacaoGrupoBox(false);
                erro.HelpLink = "Nenhum Fornecedor Selecionado";
                MessageBox.Show(erro.HelpLink);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            fornecedores = new Fornecedores();
            SituacaoGrupoBox(true);
            LimparControles();
            ID = 0;
            GerarCodigoId();
            txtNomeEmpresa.Focus();
        }

        private void SituacaoGrupoBox(bool situacao)
        {
            grbCadastroFornecedores.Enabled = situacao;
        }

        private void GerarCodigoId()
        {
            txtCodigo.Text = RotinaPadrao<Fornecedores>.GerarId(Repositorio);
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
                    erro.HelpLink = "Fornecedor não encontrado";
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
