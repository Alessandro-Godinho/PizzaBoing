using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class TamanhosMAP : ClassMap<Tamanhos>
    {
        public TamanhosMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.Nome)
                .Length(50);

            Map(x => x.TamAbreviado);

            Map(x => x.Situacao)
                .CustomType<Situacao>();

            References(x => x.Categoria);
        }

    }
}
