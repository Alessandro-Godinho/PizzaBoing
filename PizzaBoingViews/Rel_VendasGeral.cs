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
    public partial class frmRel_VendasGeral : Form
    {
        
        public frmRel_VendasGeral()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int cartao = 1, dinheiro = 0;
            if(chkCartao.Checked)
            {
                cartao = 0;
            }
            if(chkdinheiro.Checked)
            {
                dinheiro = 1;
            }

            this.da_vendasgeral.Fill(this.PizzaBoingDataSet.vendasgeral,
                                     dtpPeriodoInicial.Value,dtpDataFinal.Value);
            this.reportViewer1.RefreshReport();
        }

        private void frmRel_VendasPorBairroscs_Load(object sender, EventArgs e)
        {

        }
    }
}
