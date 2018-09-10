using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class DerivacoesMAP : ClassMap<Derivacoes>
    {
        public DerivacoesMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.Descricao)
                .Length(50);

            Map(x => x.DescricaoAbreviada)
                .Length(50);

            Map(x => x.Estoque);

            Map(x => x.Valor);

            Map(x => x.PermiteEstoqueNegativo)
                .CustomType<EstoqueNegativo>();

            Map(x => x.Situacao)
                .CustomType<Situacao>();

            References(x => x.Produto);
            References(x => x.Tamanho);
        }

    }
}
