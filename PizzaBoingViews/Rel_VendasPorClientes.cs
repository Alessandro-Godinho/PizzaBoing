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
    public partial class frmRel_VendasPorClientes : Form
    {
        
        public frmRel_VendasPorClientes()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            this.ta_vendasporbairrocliente.Fill(this.PizzaBoingDataSet.vendasporcliente,dtpPeriodoInicial.Value,dtpDataFinal.Value);

            this.reportViewer1.RefreshReport();
        }

        private void frmRel_VendasPorBairroscs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PizzaBoingDataSet.vendasporcliente' table. You can move, or remove it, as needed.
           
        }
    }
}
