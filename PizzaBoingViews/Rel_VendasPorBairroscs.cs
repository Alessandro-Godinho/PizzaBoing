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
    public partial class frmRel_VendasPorBairroscs : Form
    {
        
        public frmRel_VendasPorBairroscs()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
            this.vendasporbairroTableAdapter.Fill(this.PizzaBoingDataSet.vendasporbairro,dtpPeriodoInicial.Value,dtpDataFinal.Value);
        }

        private void frmRel_VendasPorBairroscs_Load(object sender, EventArgs e)
        {
            


        }
    }
}
