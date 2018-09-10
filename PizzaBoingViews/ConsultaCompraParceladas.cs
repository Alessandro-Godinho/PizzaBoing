using HelpDesk.Dominio.Entidades;
using HelpDesk.Dominio.ObjetosValor;
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
    public partial class frmConsultaCompraProdutos : Form
    {
        private RepositorioCompras _repositorio;
        public RepositorioCompras Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioCompras(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        RepositorioParcelas RepParcelas = new RepositorioParcelas(NHibernateHelper.GetSession());
        IDictionary<String, Object> parametros = new Dictionary<String, Object>();
        IDictionary<String, String> ordenacao = new Dictionary<String, String>();

        public frmConsultaCompraProdutos()
        {
            InitializeComponent();
            dtgConsultaCompras.AutoGenerateColumns = false;
           
        }

        
        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in PreencherPorFornecedor(IdFornecedor)
                             where CaseInsensitiveContains(c.DataCompra.ToString(), txtPesquisar.Text) ||
                                    CaseInsensitiveContains(c.ValorTotal.ToString(), txtPesquisar.Text) ||
                                    CaseInsensitiveContains(c.NF_Recibo.ToString(), txtPesquisar.Text) ||
                                    CaseInsensitiveContains(c.Fornecedor.NomeEmpresa, txtPesquisar.Text) ||
                                    CaseInsensitiveContains(c.TipoPagamento.ToString(), txtPesquisar.Text)
                             select c).ToList();

            dtgConsultaCompras.DataSource = resultado;
            try
            {
                foreach (var item in dtgConsultaCompras.Columns)
                {
                    StatusParcela(long.Parse(dtgConsultaCompras.Rows[i].Cells[1].Value.ToString()), i);
                    i++;
                }
            }
            catch
            {

            }
            i = 0;
        }

        private void dtgConsultaCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaIndex = dtgConsultaCompras.CurrentRow.Index;
            Int64 codigo = int.Parse(dtgConsultaCompras.Rows[linhaIndex].Cells[1].Value.ToString());

            if (e.ColumnIndex.Equals(7))
            {
                parametros.Add("Compra.NF_Recibo", codigo);
                ordenacao.Add("Desc", "Quantidade");

                List<object> Itens = new List<object>();
                RepositorioItensCompraProdutos RepItensCompraProdutos = new RepositorioItensCompraProdutos(NHibernateHelper.GetSession());
                var compraProdutos = RepItensCompraProdutos.ObterPorParametros(parametros, ordenacao);
                RepositorioItensCompraIngredientes RepItensComprasIngredientes = new RepositorioItensCompraIngredientes(NHibernateHelper.GetSession());
                var compraIngredientes = RepItensComprasIngredientes.ObterPorParametros(parametros, ordenacao);
                foreach (var item in compraProdutos)
                {
                    Itens.Add(item);
                }
                foreach (var item in compraIngredientes)
                {
                    Itens.Add(item);
                }
                dtgdetalhesitens.DataSource = Itens.ToList();
                tabControl1.SelectTab(1);

                parametros.Clear(); ordenacao.Clear();
            }
            if(e.ColumnIndex == 0)
            {
                Compras compra = new Compras();
                compra = Repositorio.ObterPorId(codigo);
                frmPagamentoParcelas p = new frmPagamentoParcelas(compra);
                p.ShowDialog();
                p.Close();
            }
        }
        int IdFornecedor;
        private void btnConsultaFornecedor_Click(object sender, EventArgs e)
        {

            frmConsultaFornecedores f = new frmConsultaFornecedores();
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
            IdFornecedor = frmConsultaFornecedores.passarCodigoFornecedor;
            Fornecedores fornecedores = new Fornecedores();
            RepositorioFornecedores RepFornecedores = new RepositorioFornecedores(NHibernateHelper.GetSession());
            fornecedores = RepFornecedores.ObterPorId(IdFornecedor);
            txtCodigoFornecedor.Text = IdFornecedor.ToString();
            txtNomeFornecedor.Text = fornecedores.NomeEmpresa;
            dtgConsultaCompras.DataSource = PreencherPorFornecedor(IdFornecedor);
            if(dtgConsultaCompras.Rows.Count > 0)
            foreach (var item in dtgConsultaCompras.Columns)
            {
                StatusParcela(long.Parse(dtgConsultaCompras.Rows[i].Cells[1].Value.ToString()),i);
                i++;
            }
            i = 0;
        }
        int i = 0;
        private List<Compras> PreencherPorFornecedor(int idFornecedor)
        {
            tabControl1.Enabled = true;

            var filtro = Repositorio.ObterTodasCompras().Where(x => x.Fornecedor.ID == idFornecedor &&
                          x.DataCompra >= dtpPeriodoInicial.Value && x.DataCompra <= dtpDataFinal.Value &&
                          x.FormaPagamento == FormaPagamento.Parcelado);
            
            return filtro.ToList();
        }
        Image image;
        private void StatusParcela(long item,int i)
        {
            Compras compras = new Compras();
            List<bool> statuspagamentosparcelas = new List<bool>();
            RepParcelas = new RepositorioParcelas(NHibernateHelper.GetSession());
            parametros.Add("Compras.NF_Recibo", item);
            var status = RepParcelas.ObterPorParametros(parametros);
            foreach (var p in status)
            {
                if(p.Situacao == Situacao.Ativo)
                {
                    statuspagamentosparcelas.Add(true);
                }
                else
                {
                    statuspagamentosparcelas.Add(false);
                }
            }

            if(!statuspagamentosparcelas.Contains(false))
            {
                image = Image.FromFile(@"C:\Users\win7\Pictures\shadow\bullet_ball_green.png");
                dtgConsultaCompras.Rows[i].Cells[0].Value = image;
                compras = Repositorio.ObterPorId(int.Parse(dtgConsultaCompras.Rows[i].Cells[1].Value.ToString()));
                compras.Situacao = Situacao.Ativo;

            }
            if (!statuspagamentosparcelas.Contains(true))
            {
                image = Image.FromFile(@"C:\Users\win7\Pictures\shadow\bullet_ball_red.png");
                dtgConsultaCompras.Rows[i].Cells[0].Value = image;
                compras = Repositorio.ObterPorId(int.Parse(dtgConsultaCompras.Rows[i].Cells[1].Value.ToString()));
                compras.Situacao = Situacao.Inativo;
            }
            if(statuspagamentosparcelas.Contains(true) && statuspagamentosparcelas.Contains(false))
            {
                image = Image.FromFile(@"C:\Users\win7\Pictures\shadow\bullet_ball_yellow.png");
                dtgConsultaCompras.Rows[i].Cells[0].Value = image;
                compras = Repositorio.ObterPorId(int.Parse(dtgConsultaCompras.Rows[i].Cells[1].Value.ToString()));
                compras.Situacao = Situacao.Inativo;
            }
            Repositorio.Alterar(compras);
            parametros.Clear();
            statuspagamentosparcelas.Clear();
        }

       

        private void dtpPeriodoInicial_ValueChanged(object sender, EventArgs e)
        {
            dtgConsultaCompras.DataSource = PreencherPorFornecedor(IdFornecedor);
            foreach (var item in dtgConsultaCompras.Rows)
            {
                StatusParcela(long.Parse(dtgConsultaCompras.Rows[i].Cells[1].Value.ToString()), i);
                i++;
            }
            i = 0;
        }

        private void dtpDataFinal_ValueChanged(object sender, EventArgs e)
        {
            dtgConsultaCompras.DataSource = PreencherPorFornecedor(IdFornecedor);
            foreach (var item in dtgConsultaCompras.Rows)
            {
                StatusParcela(long.Parse(dtgConsultaCompras.Rows[i].Cells[1].Value.ToString()), i);
                i++;
            }
            i = 0;
        }

        private void dtgConsultaCompras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = Convert.ToDouble(e.Value.ToString()).ToString("C");
            }
        }
    }
}
