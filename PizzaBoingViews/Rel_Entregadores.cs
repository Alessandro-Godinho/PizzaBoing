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
    public partial class frmRel_Entregadores : Form
    {
        
        public frmRel_Entregadores()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
            this.ta_entregas.Fill(this.PizzaBoingDataSet.entregascomissao,dtpPeriodoInicial.Value,dtpDataFinal.Value);
        }

        private void frmRel_VendasPorBairroscs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PizzaBoingDataSet.entregascomissao' table. You can move, or remove it, as needed.
            

        }
    }
}
