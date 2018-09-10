using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public class Promocoes : IEntidade
    {
        public virtual Int64 ID { get; set; }
        public virtual Double ValorPromocao { get; set; }
        public virtual Produtos Produtos { get; set; }
        public virtual Derivacoes Derivacao { get; set; }
        public virtual Situacao Situacao { get; set; }

        long IEntidade.ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public virtual String Validar()
        {
            String erro = String.Empty;
            if (String.IsNullOrEmpty(ValorPromocao.ToString()))
                erro = "Campo NOME deve ser preenchido!";

            return erro;
        }

        public override string ToString()
        {
            return String.Format("{0}", ValorPromocao.ToString());
        }

    }
}
