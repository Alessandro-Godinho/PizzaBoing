using HelpDesk.Repositorio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HelpDesk.Dominio.ObjetosValor;
using HelpDesk.Dominio.Entidades;

namespace PizzaBoingViews
{
    public partial class frmFechamentoCaixa : Form
    {
        private RepositorioFechamentoCaixa _repositorio;
        public RepositorioFechamentoCaixa Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioFechamentoCaixa(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        RepositorioCompras RepCompras = new RepositorioCompras(NHibernateHelper.GetSession());
        RepositorioParcelas RepParcelas = new RepositorioParcelas(NHibernateHelper.GetSession());
        RepositorioPedidosBalcao RepPedidoBalcao = new RepositorioPedidosBalcao(NHibernateHelper.GetSession());
        RepositorioPedidosEntregas RepPedidoEntrega = new RepositorioPedidosEntregas(NHibernateHelper.GetSession());
        RepositorioServicosPago RepServicoPagos = new RepositorioServicosPago(NHibernateHelper.GetSession());

        public frmFechamentoCaixa()
        {
            InitializeComponent();
            dtgFechamentoCaixa.AutoGenerateColumns = false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var compraAvista = RepCompras.ObterTodasCompras().Where(x => x.FormaPagamento == HelpDesk.Dominio.ObjetosValor.FormaPagamento.Avista && x.DataCompra <= DateTime.Now && x.DataCompra >= DateTime.Now.Date).Sum(x => x.ValorTotal);
            var ParcelaPaga = RepParcelas.ObterTodos().Where(x => x.SituacaoPagamento == HelpDesk.Dominio.ObjetosValor.SituacaoPagamento.Pago && x.DataPagamento <= DateTime.Now && x.DataPagamento >= DateTime.Now.Date).Sum(x => x.ValorParcela);
            var servicosPagos = RepServicoPagos.ObterTodos().Where(x => x.DataPagamento <= DateTime.Now && x.DataPagamento >= DateTime.Now.Date).Sum(x => x.Valor);
            var PedidosBalcaoCartao = RepPedidoBalcao.ObterTodos().Where(x => x.TipoPagamento == HelpDesk.Dominio.ObjetosValor.TipoPagamento.Cartao && x.DataVenda <= DateTime.Now && x.DataVenda >= DateTime.Now.Date).Sum(x => x.ValorTotal);
            var PedidosBalcaoDinheiro = RepPedidoBalcao.ObterTodos().Where(x => x.TipoPagamento == HelpDesk.Dominio.ObjetosValor.TipoPagamento.Dinheiro && x.DataVenda <= DateTime.Now && x.DataVenda >= DateTime.Now.Date).Sum(x => x.ValorTotal);
            var PedidosEntregaCartao = RepPedidoEntrega.ObterTodos().Where(x => x.TipoPagamento == HelpDesk.Dominio.ObjetosValor.TipoPagamento.Cartao && x.DataVenda <= DateTime.Now && x.DataVenda >= DateTime.Now.Date).Sum(x => x.ValorTotal);
            var PedidosEntregaDinheiro = RepPedidoEntrega.ObterTodos().Where(x => x.TipoPagamento == HelpDesk.Dominio.ObjetosValor.TipoPagamento.Dinheiro && x.DataVenda <= DateTime.Now && x.DataVenda >= DateTime.Now.Date).Sum(x => x.ValorTotal);
            double despesas = servicosPagos + ParcelaPaga + compraAvista;
            double receitas = PedidosBalcaoCartao + PedidosBalcaoDinheiro + PedidosEntregaCartao + PedidosEntregaDinheiro; 
            FechamentoCaixa fechamentoCaixa = new FechamentoCaixa();
            fechamentoCaixa.DataFechamento = DateTime.Now;
            fechamentoCaixa.Despesas = despesas;
            fechamentoCaixa.Receitas = receitas;
            fechamentoCaixa.PagamentosAvista = compraAvista;
            fechamentoCaixa.PagamentosParcelas = ParcelaPaga;
            fechamentoCaixa.PagamentosServicos = servicosPagos;
            fechamentoCaixa.TotalCartao = PedidosEntregaCartao + PedidosBalcaoCartao;
            fechamentoCaixa.TotalDinheiro = PedidosBalcaoDinheiro + PedidosEntregaDinheiro;
            Repositorio.Salvar(fechamentoCaixa);

            dtgFechamentoCaixa.DataSource = Repositorio.ObterTodos().Where(x => x.DataFechamento <= DateTime.Now && x.DataFechamento >= DateTime.Now.Date).ToList();

        }
     
    }   
}
