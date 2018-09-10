using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class ItensCompraProdutosMAP : ClassMap<ItensCompraProdutos>
    {
        public ItensCompraProdutosMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();
                    
            Map(x => x.Quantidade);
           
         
            References(x => x.Derivacao);

            References(x => x.Compra);

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
