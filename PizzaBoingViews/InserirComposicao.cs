using HelpDesk.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaBoingViews
{
    public partial class frmInserirComposicao : Form
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
        HelpDesk.Dominio.Entidades.Produtos produtos;
        HelpDesk.Dominio.Entidades.IngredientesProdutos ingredientesProdutos;
        List<HelpDesk.Dominio.Entidades.Ingredientes> ListaIngredientes = new List<HelpDesk.Dominio.Entidades.Ingredientes>();
        List<HelpDesk.Dominio.Entidades.IngredientesProdutos> ListaIngredientesProdutos = new List<HelpDesk.Dominio.Entidades.IngredientesProdutos>();
        Int64 idProduto;
        RepositorioProdutos RepProdutos = new RepositorioProdutos(NHibernateHelper.GetSession());

        public frmInserirComposicao(int ID)
        {
            idProduto = ID;
            InitializeComponent();
            dtgComposicao.AutoGenerateColumns = false;
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            dtgComposicao.DataSource = Repositorio.ObterTodos();
            ListaIngredientesProdutos.Clear();

        }
      
        private void btnInserirComposicao_Click(object sender, EventArgs e)
        {
            ingredientesProdutos = new HelpDesk.Dominio.Entidades.IngredientesProdutos();
            ingredientes = new HelpDesk.Dominio.Entidades.Ingredientes();
            produtos = new HelpDesk.Dominio.Entidades.Produtos();
           
            foreach (int item in ListaIdss)
            {
                RepositorioIngredientesProdutos RepIngredientesProdutos = new RepositorioIngredientesProdutos(NHibernateHelper.GetSession());
                produtos = RepProdutos.ObterPorId(idProduto);
                ingredientes = Repositorio.ObterPorId(item);
                ingredientesProdutos.Ingrediente = ingredientes;
                ingredientesProdutos.Produto = produtos;
                //ListaIngredientesProdutos.Add(ingredientesProdutos);
                RepIngredientesProdutos.Salvar(ingredientesProdutos);
               
            }

           // RepIngredientesProdutos.SalvarLista(ListaIngredientesProdutos);
            ListaIngredientesProdutos.Clear();
            this.Close();
        }

      
        List<int> ListaIdss= new List<int>();
        private void dtgComposicao_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarIngredientes();
        }

        private void SelecionarIngredientes()
        {
            int linhaIndex = dtgComposicao.CurrentRow.Index;
            int codigo = int.Parse(dtgComposicao.Rows[linhaIndex].Cells[0].Value.ToString());
            DataGridViewCheckBoxCell chk;
            var teste = dtgComposicao.CurrentRow.Cells[4];
            chk = (DataGridViewCheckBoxCell)teste;
            chk.Value = !(chk.Value == null ? false : (bool)chk.Value); //por que chk.Value é nulo inicialmente
            if ((bool)chk.Value == true)
            {
                ListaIdss.Add(codigo);
            }
            else if ((bool)chk.Value == false)
            {
                ListaIdss.Remove(codigo);
            }
        }
        private void dtgComposicao_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                SelecionarIngredientes();
            }
        }
    }
}
