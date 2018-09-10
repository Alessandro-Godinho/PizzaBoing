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
    public partial class frmConsultaFornecedores : Form
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

        HelpDesk.Dominio.Entidades.Fornecedores fornecedores;
        public static bool formCadastroFornecedor { get; set; }
        public static int passarCodigoFornecedor { get; set; }
        public frmConsultaFornecedores()
        {
            InitializeComponent();
            dtgConsultaFornecedores.AutoGenerateColumns = false;
            formCadastroFornecedor = true;
            CarregarGrid();
        }

        public frmConsultaFornecedores(List<Clientes> buscaCliente)
        {
            InitializeComponent();
            dtgConsultaFornecedores.DataSource = buscaCliente.ToList();
            formCadastroFornecedor = false;
        }

        private void CarregarGrid()
        {
            dtgConsultaFornecedores.DataSource = Repositorio.ObterTodos();
          
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in Repositorio.ObterTodos() where CaseInsensitiveContains(c.NomeEmpresa,txtPesquisar.Text) ||
                             CaseInsensitiveContains(c.Telefone,txtPesquisar.Text.Trim()) ||
                             CaseInsensitiveContains(c.Telefone2, txtPesquisar.Text)||
                             CaseInsensitiveContains(c.Endereco, txtPesquisar.Text)||
                             CaseInsensitiveContains(c.Email, txtPesquisar.Text)
                             select c).ToList();

            dtgConsultaFornecedores.DataSource = resultado;
            
           
        }
        
        private void dtgConsultaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaIndex = dtgConsultaFornecedores.CurrentRow.Index;
            int codigo = int.Parse(dtgConsultaFornecedores.Rows[linhaIndex].Cells["ID"].Value.ToString());
            fornecedores = Repositorio.ObterPorId(codigo);
            passarCodigoFornecedor = codigo;

            if (e.ColumnIndex == 0)
            {
                this.Close();      
            }

            if (e.ColumnIndex == 8)
            {
                bool resultado = RotinaPadrao<Fornecedores>.ExecutarAlteracao(fornecedores, RepositorioAlteracao.Vendas);
                if (resultado)
                {
                    if (MessageBox.Show(string.Format("Confirma a exclusão do fornecedor {0}?", fornecedores.NomeEmpresa), "Excluir Fornecedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        passarCodigoFornecedor = 0;
                        Repositorio.Excluir(fornecedores);
                        CarregarGrid();
                    }
                }
                else
                {
                    MessageBox.Show("O fornecedor não pode ser excluido, pois já realizou algum pedido de venda", "Não foi Possivel Excluir", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

    }
}
