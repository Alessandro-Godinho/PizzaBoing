using HelpDesk.Dominio.Entidades;
using HelpDesk.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoingViews
{
    public class ComprasService : Verificacao<Compras>
    {
        public override IList<Compras> VerificarLocalAlteracao(RepositorioAlteracao repositorioAlteracao)
        {
            RepositorioCompras RepCompras = new RepositorioCompras(NHibernateHelper.GetSession());
            return RepCompras.ObterTodasCompras();
        }
    }
}
