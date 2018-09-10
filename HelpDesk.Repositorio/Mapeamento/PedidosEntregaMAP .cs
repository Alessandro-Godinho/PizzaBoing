using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class PedidosEntregaMAP : ClassMap<PedidosEntrega>
    {
        public PedidosEntregaMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.ValorTotal);

            Map(x => x.DataVenda);

            Map(x => x.Desconto);

            Map(x => x.Troco);

            Map(x => x.TrocoPara);

            References(x => x.Funcionario);

            References(x => x.Entrega);

            References(x => x.Cliente);

            Map(x => x.TipoPagamento)
               .CustomType<TipoPagamento>();

            Map(x => x.Situacao)
                .CustomType<Situacao>();

            Map(x => x.SituacaoPedido)
                .CustomType<SituacaoPedido>();
        }

    }
}
