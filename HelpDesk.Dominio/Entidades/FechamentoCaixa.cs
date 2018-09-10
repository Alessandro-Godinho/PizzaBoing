using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public class FechamentoCaixa : IEntidade
    {
        public virtual Int64 ID { get; set; }
        public virtual Compras Compras { get; set; }
        public virtual Parcelas Parcelas { get; set; }
        public virtual ServicosPago ServicosPago { get; set; }
        public virtual PedidosBalcao PedidosBalcao { get; set; }
        public virtual PedidosEntrega PedidosEntrega { get; set; }
        public virtual double Receitas { get; set; }
        public virtual double Despesas { get; set; }
        public virtual DateTime DataFechamento { get; set; }
        public virtual double TotalCartao { get; set; }
        public virtual double TotalDinheiro { get; set; }
        public virtual double PagamentosAvista { get; set; }
        public virtual double PagamentosServicos { get; set; }
        public virtual double PagamentosParcelas { get; set; }

        long IEntidade.ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public virtual String Validar()
        {
            String erro = String.Empty;
            if (String.IsNullOrEmpty(DataFechamento.ToString()))
                erro = "Campo NOME deve ser preenchido!";

            return erro;
        }

        public override string ToString()
        {
            return String.Format("{0}", DataFechamento.ToString());
        }

    }
}
