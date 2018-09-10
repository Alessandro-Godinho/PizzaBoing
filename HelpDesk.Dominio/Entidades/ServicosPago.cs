using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public class ServicosPago : IEntidade
    {
        public virtual Int64 ID { get; set; }
        public virtual Servicos Servico { get; set; }
        public virtual DateTime Vencimento { get; set; }
        public virtual DateTime DataPagamento { get; set; }
        public virtual Double Valor { get; set; }
        public virtual Situacao Situacao { get; set; }

        long IEntidade.ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public virtual String Validar()
        {
            String erro = String.Empty;
            if (String.IsNullOrEmpty(Valor.ToString()))
                erro = "Campo NOME deve ser preenchido!";

            return erro;
        }

        public override string ToString()
        {
            return String.Format("{0}", Valor.ToString());
        }

    }
}
