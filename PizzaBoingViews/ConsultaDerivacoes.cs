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
    public partial class frmConsultaDerivacoes : Form
    {
        private RepositorioDerivacoes _repositorio;
        public RepositorioDerivacoes Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioDerivacoes(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        public static int PassarCodigo { get;  set; }

        HelpDesk.Dominio.Entidades.Derivacoes derivacoes;

        public frmConsultaDerivacoes()
        {
            InitializeComponent();
            dtgConsultaDerivacoes.AutoGenerateColumns = false;
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            dtgConsultaDerivacoes.DataSource = Repositorio.ObterTodos();
          
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in Repositorio.ObterTodos() where CaseInsensitiveContains(c.Descricao,txtPesquisar.Text)
                             select c).ToList();

            dtgConsultaDerivacoes.DataSource = resultado;
            
        }

        private void dtgConsultaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgConsultaDerivacoes.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex != -1)
            {

                int linhaIndex = dtgConsultaDerivacoes.CurrentRow.Index;
                int codigo = int.Parse(dtgConsultaDerivacoes.Rows[linhaIndex].Cells[1].Value.ToString());
                PassarCodigo = codigo;
                this.Close();
            }
        }
    }
}
