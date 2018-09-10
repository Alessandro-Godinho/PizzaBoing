using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using NHibernate;

namespace HelpDesk.Repositorio
{
    public class RepositorioEntregas : RepositorioBase<Entregas>
    {
        public RepositorioEntregas(ISession session)
            : base(session)
        {
        }
    }
}
