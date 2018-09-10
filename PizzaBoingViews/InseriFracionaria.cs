using HelpDesk.Dominio.Entidades;
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
    public partial class txtPesquisa : Form
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
        
        HelpDesk.Dominio.Entidades.Ingredientes ingredientes;
        HelpDesk.Dominio.Entidades.Derivacoes derivacao;
        HelpDesk.Dominio.Entidades.IngredientesProdutos ingredientesProdutos;
        List<HelpDesk.Dominio.Entidades.Ingredientes> ListaIngredientes = new List<HelpDesk.Dominio.Entidades.Ingredientes>();
        RepositorioProdutos RepProdutos = new RepositorioProdutos(NHibernateHelper.GetSession());
        public string PassarQtd { get; set; }
        public string PassarTamanho { get; set; }
        public List<Derivacoes> parametros { get; set; }

        public txtPesquisa()
        {
            InitializeComponent();
            txtQtd.Focus();
            dtgComposicao.AutoGenerateColumns = false;
            CarregarGrid();

        }
        private void CarregarGrid()
        {
            var tamanho = Repositorio.ObterTodos().Where(x => x.Produto.Categoria.ID == 1).Select(x => x.Descricao).OrderBy(x => x).Distinct().ToList();
            cmbTamanho.DataSource = tamanho;
          
        }
      
        private void btnInserirComposicao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQtd.Text))
            {
                MessageBox.Show("Informe a quantidade do produto");
                return;
            }
            else
            {
                PassarQtd = txtQtd.Text;
                ingredientesProdutos = new HelpDesk.Dominio.Entidades.IngredientesProdutos();
                ingredientes = new HelpDesk.Dominio.Entidades.Ingredientes();
                derivacao = new HelpDesk.Dominio.Entidades.Derivacoes();
                parametros = new List<Derivacoes>();

                foreach (int item in ListaIdss)
                {
                    RepositorioDerivacoes RepIngredientesProdutos = new RepositorioDerivacoes(NHibernateHelper.GetSession());
                    derivacao = Repositorio.ObterPorId(item);
                    PassarTamanho = derivacao.Descricao;
                    parametros.Add(derivacao);
                }
            }

            this.Close();
        }
      
        List<int> ListaIdss= new List<int>();

        private void dtgComposicao_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarProdutos();
        }

        private void SelecionarProdutos()
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
                SelecionarProdutos();
            }
        }

        private void cmbTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarGridPorTamanho(cmbTamanho.SelectedValue.ToString());
        }

        private void FiltrarGridPorTamanho(string text)
        {
            dtgComposicao.DataSource = Repositorio.ObterTodos().Where(x => x.Descricao == text).ToList();
            txtPesquisar.Text = string.Empty;
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < dtgComposicao.Rows.Count; i++)
            {

                if (string.IsNullOrEmpty(txtPesquisar.Text))
                {
                    dtgComposicao.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {

                    if (CaseInsensitiveContains(dtgComposicao.Rows[i].Cells[1].Value.ToString(), txtPesquisar.Text))
                    {
                        dtgComposicao.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
                    }
                    else
                    {
                        dtgComposicao.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
           
            
        }
    }
}
