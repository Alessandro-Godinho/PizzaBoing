using HelpDesk.Dominio.Entidades;
using HelpDesk.Repositorio;
using PizzaBoingViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBoingViews
{
    public class ItensVendasService : Verificacao<ItensPedidos>
    {
        public override IList<ItensPedidos> VerificarLocalAlteracao(RepositorioAlteracao repositorioAlteracao)
        {    
                RepositorioItensPedido RepItens = new RepositorioItensPedido(NHibernateHelper.GetSession());
                return RepItens.ObterTodos();  
        }
    }

    
}
