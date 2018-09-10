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
    public partial class frmRel_VendasBalcaoPorProdutos : Form
    {
        
        public frmRel_VendasBalcaoPorProdutos()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
            this.vendasbalcaoporprodutos.Fill(this.PizzaBoingDataSet.vendasbalcaoporprodutos,dtpPeriodoInicial.Value,dtpDataFinal.Value);
        }

        private void frmRel_VendasEntregasPorProdutos_Load(object sender, EventArgs e)
        {
          
        }
    }
}
