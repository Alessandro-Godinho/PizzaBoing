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

    public partial class frmCadastroTamanhos : Form
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
        private Int64 ID;
        RepositorioCategorias RepCategorias = new RepositorioCategorias(NHibernateHelper.GetSession());
        Tamanhos Tamanho = new Tamanhos();
        RepositorioEstoqueMassas RepEstoquesMassas = new RepositorioEstoqueMassas(NHibernateHelper.GetSession());
        public frmCadastroTamanhos()
        {
            InitializeComponent();
            cmbCategoria.DataSource = RepCategorias.ObterTodos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Tamanho.Nome = txtDescricao.Text;
            Tamanho.TamAbreviado = txtTamAbreviado.Text;
            Tamanho.Categoria = RepCategorias.ObterPorId(Int64.Parse(cmbCategoria.SelectedValue.ToString()));
            SalvarTamanho(ID);
            
            txtCodigoTamanho.Text = RotinaPadrao<Tamanhos>.GerarId(Repositorio);

            if (txtEstoqueMassa.Enabled == true)
            {
                EstoqueMassa estoque = new EstoqueMassa();
                estoque.Quantidade = RotinaPadrao<EstoqueMassa>.Converter(txtEstoqueMassa.Text);
                estoque.Tamanho = Repositorio.ObterPorId(int.Parse(txtCodigoTamanho.Text) - 1);
                if (ID == 0)
                    RepEstoquesMassas.Salvar(estoque);
                else
                {
                    estoque.ID = ID;
                    RepEstoquesMassas.Alterar(estoque);
                }
            }
            LimparControles();
        }

        private void SalvarTamanho(long iD)
        {

            if (ID == 0)
                Repositorio.Salvar(Tamanho);
            else
            {
                Tamanho.ID = ID;
                Repositorio.Alterar(Tamanho);
            }
        }


        private void LimparControles()
        {
            RotinaPadrao<Produtos>.limparTextBoxes(this);
        }
        IDictionary<String, Object> parametros = new Dictionary<String, Object>();
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.Text == "Pizzas")
            {
                txtEstoqueMassa.Enabled = true;
                if (ID != 0)
                {
                    //parametros.Add("Tamanhos.ID", ID);
                    Tamanho = Repositorio.ObterPorId(ID);
                    var estoque = RepEstoquesMassas.ObterTodos().Where(x => x.Tamanho.ID == Tamanho.ID).Select(x=>x.Quantidade);
                    txtTamAbreviado.Text = estoque.ToString();
                }

            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultaTamanhos f = new frmConsultaTamanhos();
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
            Tamanho = Repositorio.ObterPorId(f.PassarCodigo);
            PreencherCampos(Tamanho);


        }
        private void PreencherCampos(Tamanhos preencherProdutos)
        {
            ID = preencherProdutos.ID;
            txtCodigoTamanho.Text = ID.ToString();
            cmbCategoria.DataSource = RepCategorias.ObterTodos();
            txtCodigoTamanho.Text = preencherProdutos.ID.ToString();
            txtDescricao.Text = preencherProdutos.Nome;
            txtTamAbreviado.Text = preencherProdutos.TamAbreviado;
            cmbCategoria.SelectedValue = preencherProdutos.Categoria.ID;
            cmbCategoria.Refresh();
            
        }
    }
}
