using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using NHibernate;

namespace HelpDesk.Repositorio
{
    public class RepositorioCompras : RepositorioBase<Compras>
    {
        public RepositorioCompras(ISession session)
            : base(session)
        {
        }
    }
}
