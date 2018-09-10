using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class AutenticacoesMAP : ClassMap<Autenticacoes>
    {
        public AutenticacoesMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.Login)
                .Length(50);

            Map(x => x.Senha)
                .Length(50);

            References(x => x.Funcionario);

            Map(x => x.Situacao)
                .CustomType<Situacao>();
        }

    }
}
