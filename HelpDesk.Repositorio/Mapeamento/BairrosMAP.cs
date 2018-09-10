using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class BairrosMAP : ClassMap<Bairros>
    {
        public BairrosMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.Nome)
                .Length(50);

            Map(x => x.TaxaEntrega);

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
