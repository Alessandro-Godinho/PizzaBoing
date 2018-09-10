using HelpDesk.Dominio.Entidades;
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

namespace PizzaBoingViews
{
    public partial class frmConsultaPedidosBalcao : Form
    {
        private RepositorioPedidosBalcao _repositorio;
        public RepositorioPedidosBalcao Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioPedidosBalcao(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        public int PassarCodigo { get;  set; }

        HelpDesk.Dominio.Entidades.Produtos produtos;
        IDictionary<String, Object> parametros = new Dictionary<String, Object>();
        IDictionary<String, String> ordenacao = new Dictionary<String, String>();

        public frmConsultaPedidosBalcao()
        {
            InitializeComponent();
            dtgConsultaPedidos.AutoGenerateColumns = false;
            dtgItensPedidos.AutoGenerateColumns = false;
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dtgConsultaPedidos.DataSource = Repositorio.ObterTodos();
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in Repositorio.ObterTodos() where CaseInsensitiveContains(c.Nome,txtPesquisar.Text) ||
                             CaseInsensitiveContains(c.ValorTotal.ToString(),txtPesquisar.Text)||
                             CaseInsensitiveContains(c.Funcionario.ToString(), txtPesquisar.Text)
                             select c).ToList();

            dtgConsultaPedidos.DataSource = resultado;
            
        }

        private void dtgConsultaPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex.Equals(0))
            {
                int linhaIndex = dtgConsultaPedidos.CurrentRow.Index;
                Int64 codigo = int.Parse(dtgConsultaPedidos.Rows[linhaIndex].Cells[1].Value.ToString());

                parametros.Add("PedidoBalcao.ID", codigo);
                ordenacao.Add("Desc", "Fracionada");
               

                RepositorioItensPedido RepItensPedido = new RepositorioItensPedido(NHibernateHelper.GetSession());
                dtgItensPedidos.DataSource = RepItensPedido.ObterPorParametros(parametros, ordenacao);
                tabControl1.SelectTab(1);

                parametros.Clear(); ordenacao.Clear();
            }
        }

        private void dtgConsultaPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.Value = Convert.ToDouble(e.Value.ToString()).ToString("C");
            }
        }

        private void dtgItensPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ItensPedidos itens = new ItensPedidos();

            itens = dtgItensPedidos.Rows[e.RowIndex].DataBoundItem as ItensPedidos;

            string DescricaoProduto = string.Format("{0} {1}", itens.Derivacao.Produto.Descricao, itens.Derivacao.Descricao);
            double ValorProduto = itens.Derivacao.Valor; 

            if (itens.Fracionada == HelpDesk.Dominio.ObjetosValor.Fracionada.Sim)
            {
                dtgItensPedidos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.YellowGreen;

                if (itens.IdentificadorFracao == HelpDesk.Dominio.ObjetosValor.IdentificadorFracao.Sim)
                {
                    dtgItensPedidos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                    DescricaoProduto = string.Format("{0} {1}","Pizza", itens.Derivacao.Descricao);
                }
                else
                {
                    ValorProduto = 0;
                    DescricaoProduto = itens.Derivacao.Produto.Descricao;
                }
            }
            else
            {

                dtgItensPedidos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            dtgItensPedidos.Rows[e.RowIndex].Cells[0].Value = itens.PedidoBalcao.ID;
            dtgItensPedidos.Rows[e.RowIndex].Cells[1].Value = DescricaoProduto;
            dtgItensPedidos.Rows[e.RowIndex].Cells[2].Value = ValorProduto.ToString("C");
            dtgItensPedidos.Rows[e.RowIndex].Cells[3].Value = itens.Quantidade;
            double valortotal = itens.Derivacao.Valor * int.Parse(dtgItensPedidos.Rows[e.RowIndex].Cells[3].Value.ToString());
            dtgItensPedidos.Rows[e.RowIndex].Cells[4].Value = valortotal.ToString("C");

        }
    }
}
