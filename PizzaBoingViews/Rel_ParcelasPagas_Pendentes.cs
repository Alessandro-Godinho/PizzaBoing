using HelpDesk.Dominio.Entidades;
using HelpDesk.Repositorio;
using Microsoft.Reporting.WinForms;
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
    public partial class frmRel_ParcelasPagas_Pendentes : Form
    {


        public frmRel_ParcelasPagas_Pendentes()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
    
            this.ta_parcelaspagasependentes.Fill(this.PizzaBoingDataSet.Parcelaspagasependentes,dtpPeriodoInicial.Value,dtpDataFinal.Value);
            reportViewer1.RefreshReport();
        }

        private void frmRel_VendasPorBairroscs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PizzaBoingDataSet.Parcelaspagasependentes' table. You can move, or remove it, as needed.
           

        }
    }
}
