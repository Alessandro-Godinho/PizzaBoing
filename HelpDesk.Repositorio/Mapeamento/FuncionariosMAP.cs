using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class FuncionariosMAP : ClassMap<Funcionarios>
    {
        public FuncionariosMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.Nome)
                .Length(50);

            Map(x => x.Endereço)
              .Length(50);

            Map(x => x.Numero);

            References(x => x.Bairro);

            Map(x => x.Telefone)
                .Length(50);

            Map(x => x.Comissao);
       
            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
