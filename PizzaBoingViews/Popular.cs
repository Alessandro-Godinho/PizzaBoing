using HelpDesk.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDesk.Repositorio;

namespace PizzaBoingViews
{
    public class Popular 
    {
        public string GetResultado(object campo)
        {
            string campos = campo.ToString();
            return campos;
        }
    }

}
