using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class ClientesMAP : ClassMap<Clientes>
    {
        public ClientesMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.Nome)
                .Length(50);

            Map(x => x.DataUltimaCompra);

            Map(x => x.Email)
               .Length(50);

            Map(x => x.Referencia)
               .Length(50);

            Map(x => x.Telefone)
               .Length(50);

            Map(x => x.Telefone2)
              .Length(50);

            Map(x => x.Endereço)
               .Length(50);

            Map(x => x.Numero)
              .Length(10);

            References(x => x.Bairro);

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
