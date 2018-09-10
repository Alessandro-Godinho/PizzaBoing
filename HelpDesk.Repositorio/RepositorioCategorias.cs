using System;
using System.Collections.Generic;
using HelpDesk.Dominio.Entidades;
using NHibernate;

namespace HelpDesk.Repositorio
{
    public class RepositorioCategorias : RepositorioBase<Categorias>
    {
        public RepositorioCategorias(ISession session)
            : base(session)
        {
        }

    }
}
