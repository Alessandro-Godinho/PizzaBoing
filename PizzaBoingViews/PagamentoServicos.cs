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
    public partial class frmPagamentoServico : Form
    {
        private RepositorioServicos _repositorio;
        private Servicos servico;

        public RepositorioServicos Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioServicos(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        public frmPagamentoServico()
        {
            InitializeComponent();
        }

        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {
            ServicosPago servicoPago = new ServicosPago();
            RepositorioServicosPago RepServicoPago = new RepositorioServicosPago(NHibernateHelper.GetSession());
            servicoPago.Servico = servico;
            servicoPago.DataPagamento = DateTime.Now;
            servicoPago.Vencimento = dtpDataVencimento.Value;
            servicoPago.Valor = RotinaPadrao<Compras>.Converter(txtValorServico.Text);
            RepServicoPago.Salvar(servicoPago);

        }

        private void btnConsultarServico_Click(object sender, EventArgs e)
        {
            frmConsultaServicos f = new frmConsultaServicos();
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
            int IdServico = frmConsultaServicos.CodigoServico;
            Servicos servico = new Servicos();
            RepositorioServicos RepServico = new RepositorioServicos(NHibernateHelper.GetSession());
            servico = RepServico.ObterPorId(IdServico);
            txtCodigoServico.Text = IdServico.ToString();
            txtNomeServico.Text = servico.Descricao;

        }
    }
}
