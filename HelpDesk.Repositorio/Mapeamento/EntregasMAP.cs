using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class EntregasMAP : ClassMap<Entregas>
    {
        public EntregasMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.DataHoraEntrega).Nullable();
       
            References(x => x.Funcionario);

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
