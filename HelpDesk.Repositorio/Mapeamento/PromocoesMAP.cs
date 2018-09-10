using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class PromocoesMAP : ClassMap<Promocoes>
    {
        public PromocoesMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.ValorPromocao);

            References(x => x.Produtos);

            References(x => x.Derivacao);

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
