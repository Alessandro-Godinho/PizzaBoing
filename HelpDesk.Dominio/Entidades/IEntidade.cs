using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public interface IEntidade
    {
        long ID { get; set; }

        String Validar();
        
    }
}
