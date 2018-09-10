using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class ServicosPagoMAP : ClassMap<ServicosPago>
    {
        public ServicosPagoMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.Vencimento);

            Map(x => x.DataPagamento);

            Map(x => x.Valor);

            References(x => x.Servico);

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
