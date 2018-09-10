﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using NHibernate;

namespace HelpDesk.Repositorio
{
    public class RepositorioPromocoes : RepositorioBase<Promocoes>
    {
        public RepositorioPromocoes(ISession session)
            : base(session)
        {
        }
    }
}
