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
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
            CarregaOperador();
        }

        private void CarregaOperador()
        {
            RepAutenticacao = new RepositorioAutenticacao(NHibernateHelper.GetSession());
            autenticacao = new Autenticacoes();
            autenticacao = RepAutenticacao.ObterPorId(frmLogin.operador);
            sslOperador.Text = autenticacao.Login;

        }
        Autenticacoes autenticacao;
        RepositorioAutenticacao RepAutenticacao;
        public Form Formulario { get; set; }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmCadastroClientes();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void bairrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmCadastroBairros();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmCadastroProdutos();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmCadastroCategorias();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmCadastroIngredientes();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmCadastroFuncionarios();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void pedidosEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmPedidosEntrega();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void pedidosBalcãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmPedidosBalcao();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void pedidosBalcãoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Formulario = new frmConsultaPedidosBalcao();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void pedidosEntregaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Formulario = new frmConsultaPedidosEntrega();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void novaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmCompraProdutos();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmCadastroFornecedor();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmCadastroServicos();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmConsultaCompraProdutos();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void ingredientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formulario = new frmCompraIngredientes();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmRel_VendasEntregasPorProdutos();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void vendasPorBairrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formulario = new frmRel_VendasPorBairroscs();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void porProdutosVendasBalcãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmRel_VendasBalcaoPorProdutos();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void porClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmRel_VendasPorClientes();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void porEntregadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmRel_Entregadores();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void vendasGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmRel_VendasGeral();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void pendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmRel_ParcelasPagas_Pendentes();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void pagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new Rel_ComprasLiquidadas();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void fecharDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario = new frmFechamentoCaixa();
            Formulario.MdiParent = this;
            Formulario.Show();
        }
    }
}
