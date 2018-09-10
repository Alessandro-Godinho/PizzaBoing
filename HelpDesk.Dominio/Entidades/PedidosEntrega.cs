using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public class PedidosEntrega : IEntidade
    {
        public virtual Int64 ID { get; set; }
        public virtual Double ValorTotal { get; set; }
        public virtual DateTime DataVenda { get; set; }
        public virtual Double Desconto { get; set; }
        public virtual Double TrocoPara { get; set; }
        public virtual Double Troco { get; set; }
        public virtual Entregas Entrega { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual Funcionarios Funcionario { get; set; }
        public virtual Situacao Situacao { get; set; }
        public virtual SituacaoPedido SituacaoPedido { get; set; }
        public virtual TipoPagamento TipoPagamento { get; set; }

        long IEntidade.ID
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual String Validar()
        {
            String erro = String.Empty;
            if (String.IsNullOrEmpty(ValorTotal.ToString()))
                erro = "Campo NOME deve ser preenchido!";

            return erro;
        }

        public override string ToString()
        {
            return String.Format("{0}", ValorTotal);
        }

    }
}
