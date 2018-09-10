using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class ComprasMAP : ClassMap<Compras>
    {
        public ComprasMAP()
        {
            Id(x => x.NF_Recibo)
                .GeneratedBy.Assigned();

            Map(x => x.DataCompra);

            Map(x => x.ValorTotal);

            References(x => x.Fornecedor);

            References(x => x.Funcionario);

            Map(x => x.TipoPagamento)
               .CustomType<TipoPagamento>();

            Map(x => x.FormaPagamento)
               .CustomType<FormaPagamento>();

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
