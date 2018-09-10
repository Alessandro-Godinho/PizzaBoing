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
    public partial class frmConsultaTamanhos : Form
    {
        private RepositorioTamanhos _repositorio;
        public RepositorioTamanhos Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioTamanhos(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        public int PassarCodigo { get;  set; }

        HelpDesk.Dominio.Entidades.Tamanhos tamanhos;

        public frmConsultaTamanhos()
        {
            InitializeComponent();
            dtgConsulta.AutoGenerateColumns = false;
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            dtgConsulta.DataSource = Repositorio.ObterTodos();
          
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in Repositorio.ObterTodos() where CaseInsensitiveContains(c.Nome,txtPesquisar.Text)
                             || CaseInsensitiveContains(c.TamAbreviado, txtPesquisar.Text)
                             || CaseInsensitiveContains(c.Categoria.Descricao, txtPesquisar.Text)
                             select c).ToList();

            dtgConsulta.DataSource = resultado;
            
        }

        private void dtgConsultaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgConsulta.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1)
            {
    
                int linhaIndex = dtgConsulta.CurrentRow.Index;
                int codigo = int.Parse(dtgConsulta.Rows[linhaIndex].Cells[1].Value.ToString());
                PassarCodigo = codigo;
                this.Close();
            }
        }
    }
}
