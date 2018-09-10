using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using NHibernate;

namespace HelpDesk.Repositorio
{
    public class RepositorioItensCompraIngredientes : RepositorioBase<ItensCompraIngredientes>
    {
        public RepositorioItensCompraIngredientes(ISession session)
            : base(session)
        {
        }
    }
}
