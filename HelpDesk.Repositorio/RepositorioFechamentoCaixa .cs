using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using NHibernate;

namespace HelpDesk.Repositorio
{
    public class RepositorioFechamentoCaixa : RepositorioBase<FechamentoCaixa>
    {
        public RepositorioFechamentoCaixa(ISession session)
            : base(session)
        {
        }
    }
}
