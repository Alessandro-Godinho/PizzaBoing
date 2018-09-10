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
    public partial class frmConsultaClientes : Form
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

        HelpDesk.Dominio.Entidades.Clientes clientes;
        RepositorioBairros RepBairros = new RepositorioBairros(NHibernateHelper.GetSession());
        public static bool formulariocadcli { get; set; }
        public static int passarCodCli { get; set; }
        public frmConsultaClientes()
        {
            InitializeComponent();
            dtgConsultaClientes.AutoGenerateColumns = false;
            formulariocadcli = true;
            CarregarGrid();
        }

        public frmConsultaClientes(List<Clientes> buscaCliente)
        {
            InitializeComponent();
            dtgConsultaClientes.DataSource = buscaCliente.ToList();
            formulariocadcli = false;
        }

        private void CarregarGrid()
        {
            dtgConsultaClientes.DataSource = Repositorio.ObterTodos();
          
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in Repositorio.ObterTodos() where CaseInsensitiveContains(c.Nome,txtPesquisar.Text) ||
                             CaseInsensitiveContains(c.Telefone.ToString(),txtPesquisar.Text)||
                             CaseInsensitiveContains(c.Telefone2.ToString(), txtPesquisar.Text)||
                             CaseInsensitiveContains(c.Endereço, txtPesquisar.Text)||
                             CaseInsensitiveContains(c.Bairro.Nome, txtPesquisar.Text)||
                             CaseInsensitiveContains(c.Email, txtPesquisar.Text)
                             select c).ToList();

            dtgConsultaClientes.DataSource = resultado;
            
           
        }

        private void dtgConsultaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientes = new Clientes();
            int linhaIndex = dtgConsultaClientes.CurrentRow.Index;
            int codigo = int.Parse(dtgConsultaClientes.Rows[linhaIndex].Cells["ID"].Value.ToString());
            clientes = Repositorio.ObterPorId(codigo);
            passarCodCli = codigo;

            if (e.ColumnIndex == 0)
            {
                
                if (formulariocadcli)
                {
                    frmCadastroProdutos.formularioProduto = 0;
                }

                this.Close();
            }
            if (e.ColumnIndex == 11)
            {
                bool resultado = RotinaPadrao<Clientes>.ExecutarAlteracao(clientes, RepositorioAlteracao.Vendas);
                if (resultado)
                {
                    if (MessageBox.Show(string.Format("Confirma a exclusão do cliente {0}?", clientes.Nome), "Excluir Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        passarCodCli = 0;
                        Repositorio.Excluir(clientes);
                        CarregarGrid();
                    }
                }
                else
                {
                    MessageBox.Show("O cliente não pode ser excluido, pois já realizou algum pedido de venda", "Não foi Possivel Excluir", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
