using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class ItensCompraIngredientesMAP : ClassMap<ItensCompraIngredientes>
    {
        public ItensCompraIngredientesMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();
                    
            Map(x => x.Quantidade);

            References(x => x.Compra);

            References(x => x.Ingrediente);

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
