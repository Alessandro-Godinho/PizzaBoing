using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using NHibernate;

namespace HelpDesk.Repositorio
{
    public class RepositorioClientes : RepositorioBase<Clientes>
    {
        public RepositorioClientes(ISession session)
            : base(session)
        {
        }
    }
}
