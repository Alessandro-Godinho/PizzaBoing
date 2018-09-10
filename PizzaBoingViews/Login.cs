using HelpDesk.Dominio.Entidades;
using HelpDesk.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaBoingViews
{
    public partial class frmLogin : Form
    {
        private RepositorioAutenticacao _repositorio;
        public RepositorioAutenticacao Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioAutenticacao(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        public static Int64 operador { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var verificacao = Repositorio.ObterTodos().Where(x => x.Login == txtUsuario.Text.Trim() && x.Senha == txtSenha.Text.Trim()).ToList();
            if(verificacao.Count == 1)
            {
                foreach (var item in verificacao)
                {
                    operador = item.ID;
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
