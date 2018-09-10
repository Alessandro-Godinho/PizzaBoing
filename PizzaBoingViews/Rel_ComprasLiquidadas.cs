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
    public partial class Rel_ComprasLiquidadas : Form
    {
        
        public Rel_ComprasLiquidadas()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
            this.ta_comprasliquidadas.Fill(this.PizzaBoingDataSet.comprasliquidadas, dtpPeriodoInicial.Value,dtpDataFinal.Value);
        }

        private void frmRel_VendasPorBairroscs_Load(object sender, EventArgs e)
        {
           
        }
    }
}
