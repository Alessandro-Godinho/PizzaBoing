using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class IngredientesProdutosMAP : ClassMap<IngredientesProdutos>
    {
        public IngredientesProdutosMAP()
        {
            Id(x => x.ID).GeneratedBy.Increment();

            References(x => x.Ingrediente);

            References(x => x.Produto);

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
