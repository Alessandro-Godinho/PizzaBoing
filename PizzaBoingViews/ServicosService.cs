using HelpDesk.Dominio.Entidades;
using HelpDesk.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoingViews
{
    public class ServicosService : Verificacao<ServicosPago>
    {
        public override IList<ServicosPago> VerificarLocalAlteracao(RepositorioAlteracao repositorioAlteracao)
        {
            RepositorioServicosPago RepPedidos = new RepositorioServicosPago(NHibernateHelper.GetSession());
            return RepPedidos.ObterTodos();
        }
    }
}
