using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class ItensPedidoMAP : ClassMap<ItensPedidos>
    {
        public ItensPedidoMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.Quantidade);
           
         
            References(x => x.Derivacao);

            References(x => x.PedidoBalcao);

            References(x => x.PedidoEntrega);

            Map(x => x.Situacao)
                .CustomType<Situacao>();

            Map(x => x.Fracionada)
              .CustomType<Fracionada>();

            Map(x => x.IdentificadorFracao)
              .CustomType<IdentificadorFracao>();
        }

    }
}
