using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public class ItensPedidos : IEntidade
    {
        public virtual Int64 ID { get; set; }
        public virtual PedidosEntrega PedidoEntrega { get; set; }
        public virtual PedidosBalcao PedidoBalcao { get; set; }
        public virtual Derivacoes Derivacao { get; set; }
        public virtual Double Quantidade { get; set; }
        public virtual Situacao Situacao { get; set; }
        public virtual Fracionada Fracionada { get; set; }
        public virtual IdentificadorFracao IdentificadorFracao { get; set; }

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
            if (String.IsNullOrEmpty(Derivacao.Descricao))
                erro = "Campo NOME deve ser preenchido!";

            return erro;
        }

        public override string ToString()
        {
            return String.Format("{0}", Derivacao.Descricao);
        }

    }
}
