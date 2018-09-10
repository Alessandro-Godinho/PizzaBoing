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
    public partial class frmRel_VendasEntregasPorProdutos : Form
    {
        
        public frmRel_VendasEntregasPorProdutos()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
            this.vendasentregas_por_produtoTableAdapter.Fill(this.PizzaBoingDataSet.vendasentregas_por_produto,dtpPeriodoInicial.Value,dtpDataFinal.Value);
        }

        private void frmRel_VendasEntregasPorProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PizzaBoingDataSet.vendasentregas_por_produto' table. You can move, or remove it, as needed.
           // this.vendasentregas_por_produtoTableAdapter.Fill(this.PizzaBoingDataSet.vendasentregas_por_produto);
            // TODO: This line of code loads data into the 'PizzaBoingDataSet.vendasentregas_por_produto' table. You can move, or remove it, as needed.


           // this.reportViewer1.RefreshReport();
        }
    }
}
