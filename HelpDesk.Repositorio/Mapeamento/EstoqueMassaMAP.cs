﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using FluentNHibernate.Mapping;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Repositorio.Mapeamento
{
    public class EstoqueMassaMAP : ClassMap<EstoqueMassa>
    {
        public EstoqueMassaMAP()
        {
            Id(x => x.ID)
                .GeneratedBy.Increment();

            Map(x => x.Quantidade);

            Map(x => x.Situacao)
                .CustomType<Situacao>();

            References(x => x.Tamanho);
        }

    }
}
