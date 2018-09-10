using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HelpDesk.Dominio.ObjetosValor
{
    [Serializable()]
    public enum TipoPagamento
    {
        [Description("ID Dinheiro")]
        Dinheiro,
        [Description("ID Cartao")]
        Cartao
    }

}
