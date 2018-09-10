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
    public partial class frmConsultaCategorias : Form
    {
        private RepositorioCategorias _repositorio;
        public RepositorioCategorias Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioCategorias(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        HelpDesk.Dominio.Entidades.Categorias categorias;
        public static int IdCategorias { get; set; }
        bool resultado;
        List<bool> TodosResultados = new List<bool>();
        IDictionary<String, Object> parametros = new Dictionary<String, Object>();

        public frmConsultaCategorias()
        {
            InitializeComponent();
            dtgConsultaCategorias.AutoGenerateColumns = false;
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            dtgConsultaCategorias.DataSource = Repositorio.ObterTodos();
          
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in Repositorio.ObterTodos() where CaseInsensitiveContains(c.Descricao,txtPesquisar.Text) ||
                             CaseInsensitiveContains(c.Descricao,txtPesquisar.Text)
                             select c).ToList();

            dtgConsultaCategorias.DataSource = resultado;
            
           
        }

        private void AdicionarTodosParametros()
        {
            RepositorioProdutos RepProduto = new RepositorioProdutos(NHibernateHelper.GetSession());
            parametros.Add("Categoria.ID", categorias.ID );
            TodosResultados.Add(resultado = RotinaPadrao<Produtos>.VerificarAcaoTabelasIndiretamenteRelacionadas(RepProduto, parametros));
            parametros.Clear();
        }

        private void dtgConsultaCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaIndex = dtgConsultaCategorias.CurrentRow.Index;
            int codigo = int.Parse(dtgConsultaCategorias.Rows[linhaIndex].Cells[1].Value.ToString());
            categorias = new Categorias();
            categorias = Repositorio.ObterPorId(codigo);

            if (e.ColumnIndex == 0)
            {
                IdCategorias = codigo;
                this.Close();
            }
            if (e.ColumnIndex == 3)
            {
                AdicionarTodosParametros();

                if (!TodosResultados.Contains(false))
                {
                    if (MessageBox.Show(string.Format("Confirma a exclusão do bairro {0}?", categorias.Descricao), "Excluir Categoria", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        IdCategorias = 0;
                        Repositorio.Excluir(categorias);
                        CarregarGrid();
                    }
                }
                else
                {
                    Repositorio = new RepositorioCategorias(NHibernateHelper.GetSession());
                    MessageBox.Show("A categoria não pode ser excluida, pois existem movimentações com essa categoria", "Não foi Possivel Excluir", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            TodosResultados.Clear();
        }
    }
}
