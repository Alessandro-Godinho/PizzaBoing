using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public class Parcelas : IEntidade
    {
        public virtual Int64 ID { get; set; }
        public virtual DateTime DataVencimento { get; set; }
        public virtual Nullable<DateTime> DataPagamento { get; set; }
        public virtual Compras Compras { get; set; }
        public virtual Double ValorParcela {get;set;}
        public virtual Situacao Situacao { get; set; }
        public virtual SituacaoPagamento SituacaoPagamento { get; set; }

        long IEntidade.ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public virtual String Validar()
        {
            String erro = String.Empty;
            if (String.IsNullOrEmpty(Compras.Fornecedor.NomeEmpresa))
                erro = "Campo NOME deve ser preenchido!";

            return erro;
        }

        public override string ToString()
        {
            return String.Format("{0}", Compras.Fornecedor.NomeEmpresa);
        }

    }
}
