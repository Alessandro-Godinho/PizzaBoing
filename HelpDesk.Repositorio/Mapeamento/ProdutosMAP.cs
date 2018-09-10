using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class ProdutosMAP : ClassMap<Produtos>
    {
        public ProdutosMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.Descricao)
                .Length(50);

            References(x => x.Categoria);

            Map(x => x.Promocao)
               .CustomType<Promocao>();

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
