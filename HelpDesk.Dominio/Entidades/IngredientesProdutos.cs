using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public class IngredientesProdutos : IEntidade
    {
        public virtual Int64 ID { get; set; }
        public virtual Ingredientes Ingrediente { get; set; }
        public virtual Produtos Produto { get; set; }
        public virtual Situacao Situacao { get; set; }

        long IEntidade.ID
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual String Validar()
        {
            String erro = String.Empty;
            if (String.IsNullOrEmpty(Produto.Descricao))
                erro = "Campo NOME deve ser preenchido!";

            return erro;
        }

        public override string ToString()
        {
            return String.Format("{0}", Produto.Descricao);
        }

    }
}
