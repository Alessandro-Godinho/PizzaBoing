using HelpDesk.Dominio.Entidades;
using HelpDesk.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoingViews
{
    public class VendasService : Verificacao<PedidosEntrega>
    {
        public override IList<PedidosEntrega> VerificarLocalAlteracao(RepositorioAlteracao repositorioAlteracao)
        {
            RepositorioPedidosEntregas RepPedidos = new RepositorioPedidosEntregas(NHibernateHelper.GetSession());
            return RepPedidos.ObterTodos();
        }
    }
}
