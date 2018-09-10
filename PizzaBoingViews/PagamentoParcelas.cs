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
    public partial class frmPagamentoParcelas : Form
    {
        private RepositorioParcelas _repositorio;
        public RepositorioParcelas Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioParcelas(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }
        IDictionary<String, Object> parametros = new Dictionary<String, Object>();
        Int64 Id_Compra;
        public frmPagamentoParcelas(Compras compra)
        {
            InitializeComponent();
            dtgParcelas.AutoGenerateColumns = false;
            Id_Compra = compra.NF_Recibo;
            CarregarParcelas(Id_Compra);
        }

        private void CarregarParcelas(long codigo)
        {

            parametros.Add("Compras.NF_Recibo", codigo);
            var parcelas = Repositorio.ObterPorParametros(parametros);
            dtgParcelas.DataSource = parcelas.ToList();
            parametros.Clear();
        }

        private void dtgParcelas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                Parcelas parcelas = new Parcelas();
                int linhaIndex = dtgParcelas.CurrentRow.Index;
                int codigo = int.Parse(dtgParcelas.Rows[linhaIndex].Cells[0].Value.ToString());
                parcelas = Repositorio.ObterPorId(codigo);
                if (MessageBox.Show("Confirma o pagamento/estorno da parcela?", "Pagar/Estornar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(parcelas.SituacaoPagamento == HelpDesk.Dominio.ObjetosValor.SituacaoPagamento.Pendente)
                    {
                        parcelas.SituacaoPagamento = HelpDesk.Dominio.ObjetosValor.SituacaoPagamento.Pago;
                        parcelas.DataPagamento = DateTime.Now;
                    }
                    else
                    {
                        parcelas.SituacaoPagamento = HelpDesk.Dominio.ObjetosValor.SituacaoPagamento.Pendente;
                        parcelas.DataPagamento = null;
                    }
                    Repositorio.Alterar(parcelas);
                }
                    CarregarParcelas(Id_Compra);
            }
        }

        private void dtgParcelas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           
                if (dtgParcelas.Rows[e.RowIndex].Cells[4].Value.ToString() == "Pago")
                {
                    dtgParcelas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.YellowGreen;
                }
                else
                {
                    dtgParcelas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;

                }
            
        }

        private void dtgParcelas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Parcelas p = dtgParcelas.Rows[e.RowIndex].DataBoundItem as Parcelas;

            dtgParcelas.Rows[e.RowIndex].Cells["Compra"].Value = p.Compras.NF_Recibo;
        }
    }
}
