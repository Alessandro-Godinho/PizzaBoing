using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public class Compras : IEntidade
    {
        public virtual Int64 NF_Recibo { get; set; }
        public virtual Fornecedores Fornecedor { get; set; }
        public virtual Funcionarios Funcionario { get; set; }
        public virtual DateTime DataCompra { get; set; }
        public virtual Double ValorTotal { get; set; }
        public virtual Situacao Situacao { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual TipoPagamento TipoPagamento { get; set; }

        long IEntidade.ID
        {
            get { return NF_Recibo; }
            set { NF_Recibo = value; }
        }

        public virtual String Validar()
        {
            String erro = String.Empty;
            if (String.IsNullOrEmpty(Fornecedor.NomeEmpresa))
                erro = "Campo NOME deve ser preenchido!";

            return erro;
        }

        public override string ToString()
        {
            return String.Format("{0}", Fornecedor.NomeEmpresa);
        }

    }
}
