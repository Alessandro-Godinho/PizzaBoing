using HelpDesk.Dominio.Entidades;
using HelpDesk.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoingViews
{
    public abstract class Verificacao<T> where T : IEntidade
    {
        public abstract IList<T> VerificarLocalAlteracao(RepositorioAlteracao repositorioAlteracao);
    }
}
