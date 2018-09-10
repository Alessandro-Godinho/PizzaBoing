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
using HelpDesk.Dominio.Entidades;

namespace PizzaBoingViews
{
    public partial class frmCadastroCategorias : Form
    {
        private RepositorioCategorias _repositorio;
        public RepositorioCategorias Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioCategorias(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        private Int64 ID;
        HelpDesk.Dominio.Entidades.Categorias categorias;
        bool resultado;
        List<bool> TodosResultados = new List<bool>();
        IDictionary<String, Object> parametros = new Dictionary<String, Object>();

        public frmCadastroCategorias()
        {
            InitializeComponent();
            LimparControles();
            txtCodigo.Text = RotinaPadrao<Categorias>.GerarId(Repositorio);
        }

        private void GerarCodigoId()
        {
            txtCodigo.Text = RotinaPadrao<Categorias>.GerarId(Repositorio);
        }

        private void SituacaoGrupoBox(bool situacao)
        {
            grbCadastroCategorias.Enabled = situacao;
        }

        private void PreencherCampos(int IdCategoria)
        {
            ID = IdCategoria;
            categorias = Repositorio.ObterPorId(ID);
            txtCodigo.Text = categorias.ID.ToString();
            txtDescricao.Text = categorias.Descricao.ToString();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F4)
            {
                this.Close();
                return true;    // Indica que o pressionar desta tecla 
                                // foi gerenciado aqui.
            }

            // Propaga o evento para o método da classe base
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            categorias.Descricao = txtDescricao.Text;
            categorias.Situacao = HelpDesk.Dominio.ObjetosValor.Situacao.Ativo;

            if (ID == 0)
                Repositorio.Salvar(categorias);
            else
            {
                AdicionarTodosParametros();

                if (!TodosResultados.Contains(false))
                {
                    Repositorio.Alterar(categorias);
                    MessageBox.Show("Categoria alterado com sucesso", "Alterado Com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Repositorio = new RepositorioCategorias(NHibernateHelper.GetSession());
                    MessageBox.Show("A categoria não pode ser alterado, pois existem movimentações com essa categoria", "Não foi Possivel Alterar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    LimparControles();
                }

            }
            TodosResultados.Clear();
            parametros.Clear();
            LimparControles();
            GerarCodigoId();
            SituacaoGrupoBox(false);
        }

        private void AdicionarTodosParametros()
        {
            RepositorioProdutos RepProduto = new RepositorioProdutos(NHibernateHelper.GetSession());
            parametros.Add("Categoria.ID", categorias.ID);
            TodosResultados.Add(resultado = RotinaPadrao<Produtos>.VerificarAcaoTabelasIndiretamenteRelacionadas(RepProduto, parametros));
            parametros.Clear();
        }

        private void LimparControles()
        {
            RotinaPadrao<Categorias>.limparTextBoxes(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ID = 0;
            LimparControles();
            GerarCodigoId();
            SituacaoGrupoBox(false);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            SituacaoGrupoBox(true);
            frmConsultaCategorias f = new frmConsultaCategorias();
            f.ShowDialog();
            try
            {
                PreencherCampos(frmConsultaCategorias.IdCategorias);
            }
            catch (Exception erro)
            {
                SituacaoGrupoBox(false);
                erro.HelpLink = "Nenhuma Categoria Selecionada";
                MessageBox.Show(erro.HelpLink);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            categorias = new Categorias();
            SituacaoGrupoBox(true);
            LimparControles();
            ID = 0;
            GerarCodigoId();
            txtDescricao.Focus();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    PreencherCampos(int.Parse(txtCodigo.Text));
                    SituacaoGrupoBox(true);
                }
                catch (Exception erro)
                {
                    erro.HelpLink = "Categoria não encontrada";
                    SituacaoGrupoBox(false);
                    GerarCodigoId();
                    LimparControles();
                    MessageBox.Show(erro.HelpLink);
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
