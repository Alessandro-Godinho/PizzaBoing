using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpDesk.Dominio.ObjetosValor;

namespace HelpDesk.Dominio.Entidades
{
    public class Fornecedores : IEntidade
    {
        public virtual Int64 ID { get; set; }
        public virtual String NomeEmpresa { get; set; }
        public virtual String Telefone { get; set; }
        public virtual String Telefone2 { get; set; }
        public virtual String Endereco { get; set; }
        public virtual String Cidade { get; set; }
        public virtual String Numero { get; set; }
        public virtual String Email { get; set; }
        public virtual Situacao Situacao { get; set; }

        long IEntidade.ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public virtual String Validar()
        {
            String erro = String.Empty;
            if (String.IsNullOrEmpty(NomeEmpresa))
                erro = "Campo NOME deve ser preenchido!";

            return erro;
        }

        public override string ToString()
        {
            return String.Format("{0}", NomeEmpresa);
        }

    }
}
