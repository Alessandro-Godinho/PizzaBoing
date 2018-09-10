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
using System.Text.RegularExpressions;

namespace PizzaBoingViews
{
    public partial class frmCadastroClientes : Form
    {
        private RepositorioClientes _repositorio;
        public RepositorioClientes Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioClientes(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        private Int64 ID;
        Bairros bairros = new Bairros();
        Clientes clientes;
        RepositorioBairros RepBairros = new RepositorioBairros(NHibernateHelper.GetSession());

        public frmCadastroClientes()
        {
            InitializeComponent();
            LimparControles();
            GerarCodigoId();
            cmbBairro.DataSource = RepBairros.ObterTodos();
        }

        private void PreencherCampos(int Id_cliente)
        {
            ID = Id_cliente;
            clientes = Repositorio.ObterPorId(ID);
            cmbBairro.DataSource = RepBairros.ObterTodos();
            txtCodigo.Text = clientes.ID.ToString();
            txtDataUltimaCompra.Text = null;
            txtEmail.Text = clientes.Email;
            txtEndereco.Text = clientes.Endereço;
            txtNumero.Text = clientes.Numero;
            txtNome.Text = clientes.Nome;
            txtReferencia.Text = clientes.Referencia;
            txtTelefone1.Text = clientes.Telefone.ToString();
            txtTelefone2.Text = clientes.Telefone2.ToString(); 
            cmbBairro.SelectedValue = clientes.Bairro.ID;
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
            if (Validacoes.ValidarEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("E-mail Inválido, ex: meuemail@gmail.com", "E-mail Inválido");
            }
            else
            {
                clientes.Nome = txtNome.Text;
                clientes.Telefone = txtTelefone1.Text;
                clientes.Telefone2 = txtTelefone2.Text;
                clientes.Referencia = txtReferencia.Text;
                clientes.DataUltimaCompra = null;
                clientes.Endereço = txtEndereco.Text;
                clientes.Email = txtEmail.Text;
                clientes.Numero = txtNumero.Text;
                clientes.Bairro = RepBairros.ObterPorId(Int64.Parse(cmbBairro.SelectedValue.ToString()));
                clientes.Situacao = HelpDesk.Dominio.ObjetosValor.Situacao.Ativo;

                if (ID == 0)
                    Repositorio.Salvar(clientes);
                else
                {
                    clientes.ID = ID;
                    bool resultado = RotinaPadrao<Clientes>.ExecutarAlteracao(clientes, RepositorioAlteracao.Vendas);
                    if (resultado)
                    {
                        MessageBox.Show("Cliente alterado com sucesso", "Alterado Com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Repositorio.Alterar(clientes);
                    }
                    else
                    {
                        MessageBox.Show("O cliente não pode ser alterado, pois já realizou algum pedido de venda", "Não foi Possivel Alterar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void GerarCodigoId()
        {
            txtCodigo.Text = RotinaPadrao<Clientes>.GerarId(Repositorio);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            SituacaoGrupoBox(true);
            frmConsultaClientes f = new frmConsultaClientes();
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();

            try
            {
                PreencherCampos(frmConsultaClientes.passarCodCli);
            }
            catch (Exception erro)
            {
                SituacaoGrupoBox(false);
                erro.HelpLink = "Nenhum Cliente Selecionado";
                MessageBox.Show(erro.HelpLink);
            }
        }

        private void SituacaoGrupoBox(bool situacao)
        {
            grbCadastroClientes.Enabled = situacao;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            clientes = new Clientes();
            SituacaoGrupoBox(true);
            LimparControles();
            ID = 0;
            GerarCodigoId();
            txtNome.Focus();

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
                    erro.HelpLink = "Cliente não encontrado";
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
