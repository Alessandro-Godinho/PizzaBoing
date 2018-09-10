using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public class Funcionarios :  IEntidade
    {
        public virtual Int64 ID { get; set; }
        public virtual String Nome { get; set; }
        public virtual String Endereço { get; set; }
        public virtual String Numero { get; set; }
        public virtual Bairros Bairro { get; set; }
        public virtual String Telefone { get; set; }
        public virtual Double Comissao { get; set; }
        public virtual Situacao Situacao { get; set; }

        long IEntidade.ID
        {
            get { return ID; }
            set { ID = value; }
        }


        public virtual String Validar()
        {
            String erro = String.Empty;
            if (String.IsNullOrEmpty(Nome))
                erro = "Campo NOME deve ser preenchido!";

            return erro;
        }

        public override string ToString()
        {
            return String.Format("{0}", Nome);
        }

    }
}
