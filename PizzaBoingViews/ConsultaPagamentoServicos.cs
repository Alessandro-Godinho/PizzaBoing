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
    public partial class frmConsultaPagamentoServicos : Form
    {
        private RepositorioServicosPago _repositorio;
        public RepositorioServicosPago Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioServicosPago(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }
        public static int IdservicosPagos { get; set; }
        IDictionary<String, Object> parametros = new Dictionary<String, Object>();
        ServicosPago servicosPagos;
        bool resultado;
        List<bool> TodosResultados = new List<bool>();

        public frmConsultaPagamentoServicos()
        {
            InitializeComponent();
            dtgConsultaServicosPagos.AutoGenerateColumns = false;
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            dtgConsultaServicosPagos.DataSource = Repositorio.ObterTodos();
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in Repositorio.ObterTodos() where
                             CaseInsensitiveContains(c.Servico.Descricao, txtPesquisar.Text) ||
                             CaseInsensitiveContains(c.Valor.ToString(), txtPesquisar.Text) ||
                             CaseInsensitiveContains(c.DataPagamento.ToString(), txtPesquisar.Text) ||
                             CaseInsensitiveContains(c.Vencimento.ToString(), txtPesquisar.Text)
                             select c).ToList();

            dtgConsultaServicosPagos.DataSource = resultado;
            
           
        }

        private void dtgConsultaBairros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaIndex = dtgConsultaServicosPagos.CurrentRow.Index;
            int codigo = int.Parse(dtgConsultaServicosPagos.Rows[linhaIndex].Cells[1].Value.ToString());

            if (e.ColumnIndex == 0)
            { 
                IdservicosPagos = codigo;
                this.Close();
            }
         
        }

        private void dtgConsultaBairros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                e.Value = Convert.ToDouble(e.Value.ToString()).ToString("C");
            }
        }

       
    }
}
