using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class FornecedoresMAP : ClassMap<Fornecedores>
    {
        public FornecedoresMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.Cidade)
                .Length(50);

            Map(x => x.Email).CustomSqlType("Varchar(50)")
               .Length(50);

            Map(x => x.Numero);

            Map(x => x.NomeEmpresa)
               .Length(50);

            Map(x => x.Telefone)
               .Length(50);

            Map(x => x.Telefone2)
              .Length(50);

            Map(x => x.Endereco)
               .Length(50);

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
