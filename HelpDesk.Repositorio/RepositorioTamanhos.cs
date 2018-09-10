using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.Entidades;
using NHibernate;

namespace HelpDesk.Repositorio
{
    public class RepositorioTamanhos : RepositorioBase<Tamanhos>
    {
        public RepositorioTamanhos(ISession session)
            : base(session)
        {
        }
    }
}
