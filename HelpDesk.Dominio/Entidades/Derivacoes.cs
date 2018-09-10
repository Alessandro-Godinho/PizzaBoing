using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public class Derivacoes : IEntidade
    {
        public virtual Int64 ID { get; set; }
        public virtual Int64 Estoque { get; set; }
        public virtual Double Valor { get; set; }
        public virtual EstoqueNegativo PermiteEstoqueNegativo { get; set; }
        public virtual String Descricao { get; set; }
        public virtual String DescricaoAbreviada { get; set; }
        public virtual Produtos Produto { get; set; }
        public virtual Tamanhos Tamanho { get; set; }
        public virtual Situacao Situacao { get; set; }

        long IEntidade.ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public virtual String Validar()
        {
            String erro = String.Empty;
            if (String.IsNullOrEmpty(Descricao))
                erro = "Campo NOME deve ser preenchido!";

            return erro;
        }

        public override string ToString()
        {
            return String.Format("{0}", Descricao);
        }

    }
}
