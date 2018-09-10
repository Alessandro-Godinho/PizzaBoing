using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class ParcelasMAP : ClassMap<Parcelas>
    {
        public ParcelasMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.DataVencimento);

            References(x => x.Compras);

            Map(x => x.ValorParcela);

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
