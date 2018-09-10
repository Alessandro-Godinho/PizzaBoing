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
    public partial class frmConsultaIngredientes : Form
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

        HelpDesk.Dominio.Entidades.Ingredientes ingredientes;
        public static int CodigoIngrediente;

        public frmConsultaIngredientes()
        {
            InitializeComponent();
            dtgConsultaIngredientes.AutoGenerateColumns = false;
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            dtgConsultaIngredientes.DataSource = Repositorio.ObterTodos();
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in Repositorio.ObterTodos() where CaseInsensitiveContains(c.Descricao,txtPesquisar.Text) ||
                             CaseInsensitiveContains(c.Valor.ToString(), txtPesquisar.Text)||
                             CaseInsensitiveContains(c.Unidade.ToString(), txtPesquisar.Text)
                             select c).ToList();

            dtgConsultaIngredientes.DataSource = resultado;
            
           
        }

        private void dtgConsultaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaIndex = dtgConsultaIngredientes.CurrentRow.Index;
            int codigo = int.Parse(dtgConsultaIngredientes.Rows[linhaIndex].Cells[1].Value.ToString());
            ingredientes = Repositorio.ObterPorId(codigo);
            CodigoIngrediente = codigo;

            if (e.ColumnIndex == 0)
            {
                this.Close();
            }
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show(string.Format("Confirma a exclusão do ingrediente {0}?", ingredientes.Descricao), "Excluir Ingrediente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CodigoIngrediente = 0;
                    Repositorio.Excluir(ingredientes);
                    CarregarGrid();
                }
            }
        }

        private void dtgConsultaIngredientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = Convert.ToDouble(e.Value.ToString()).ToString("C");
            }
        }
    }
}
