using HelpDesk.Repositorio;
using System;
using System.Windows.Forms;
using HelpDesk.Dominio.Entidades;

namespace PizzaBoingViews
{
    public partial class frmAtualizarEstoque : Form
    {
        private RepositorioDerivacoes _repositorio;
        public RepositorioDerivacoes Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioDerivacoes(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        private Int64 ID;
        HelpDesk.Dominio.Entidades.Derivacoes derivacao = new Derivacoes();

        public frmAtualizarEstoque(int codigo)
        {
            InitializeComponent();
            PreencherCampos(codigo);
        }
        string descricao;
        private void PreencherCampos(int Id_derivacao)
        {
            ID = Id_derivacao;
            derivacao = Repositorio.ObterPorId(Id_derivacao);
            txtEstoque.Text = derivacao.Estoque.ToString();
            chkPermiteEstoqueNegativo.Checked = derivacao.PermiteEstoqueNegativo == HelpDesk.Dominio.ObjetosValor.EstoqueNegativo.Sim
                                                ? true : false;
            descricao = derivacao.Descricao;
        }
     
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            derivacao.ID = ID;
            derivacao.Estoque = int.Parse(txtEstoque.Text);
            derivacao.PermiteEstoqueNegativo = chkPermiteEstoqueNegativo.Checked == true
                                               ? HelpDesk.Dominio.ObjetosValor.EstoqueNegativo.Sim :
                                               HelpDesk.Dominio.ObjetosValor.EstoqueNegativo.Nao;
            derivacao.Descricao = descricao;
            Repositorio.Alterar(derivacao);
            this.Close();
        }

       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
