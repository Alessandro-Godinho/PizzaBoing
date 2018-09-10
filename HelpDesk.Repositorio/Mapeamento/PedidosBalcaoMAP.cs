using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class PedidosBalcaoMAP : ClassMap<PedidosBalcao>
    {
        public PedidosBalcaoMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.ValorTotal);

            Map(x => x.Nome).Length(50);

            Map(x => x.DataVenda);


            Map(x => x.Desconto);

            Map(x => x.Troco);

            Map(x => x.TrocoPara);

            References(x => x.Funcionario);

            Map(x => x.TipoPagamento)
               .CustomType<TipoPagamento>();

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
