using HelpDesk.Dominio.Entidades;
using HelpDesk.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace PizzaBoingViews
{
    public partial class frmCadastroProdutos : Form
    {
        private RepositorioProdutos _repositorio;
        public RepositorioProdutos Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioProdutos(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        private Int64 ID;
        private Int64 IdProduto;
        HelpDesk.Dominio.Entidades.Produtos produtos; 
        RepositorioCategorias RepCategorias = new RepositorioCategorias(NHibernateHelper.GetSession());
        RepositorioIngredientesProdutos RepIngredientesProdutos = new RepositorioIngredientesProdutos(NHibernateHelper.GetSession());
        RepositorioDerivacoes RepDerivados = new RepositorioDerivacoes(NHibernateHelper.GetSession());
        Derivacoes Derivado = new Derivacoes();
        public static int formularioProduto { get; set; }
        public string ValorSemFormatacao { get; private set; }
        List<bool> TodosResultados = new List<bool>();
        bool resultado;

        public frmCadastroProdutos()
        {
            InitializeComponent();
            dtgDerivados.AutoGenerateColumns = false;
            AtivarDesativarGroupBoxes(false,false);
            LimparControles();
            //txtCodigoProduto.Text = RotinaPadrao<Produtos>.GerarId(Repositorio);
            cmbCategoria.DataSource = RepCategorias.ObterTodos();
        }

        private void AtivarDesativarGroupBoxes(bool groupbox,bool groupProdutos)
        {
            grbComposicao.Enabled = groupbox;
            grbDerivados.Enabled = groupbox;
            grbProdutos.Enabled = groupProdutos;
        }

        public frmCadastroProdutos(Produtos preencherProdutos)
        {
            InitializeComponent();
            PreencherCampos(preencherProdutos);
            PreencherGridComposicao();
        }

        private void PreencherCampos(Produtos preencherProdutos)
        {
            ID = preencherProdutos.ID;
            IdProduto = ID;
            txtCodigoProduto.Text = ID.ToString();
            cmbCategoria.DataSource = RepCategorias.ObterTodos();
            txtCodigoProduto.Text = preencherProdutos.ID.ToString();
            txtDescricao.Text = preencherProdutos.Descricao;
            cmbCategoria.SelectedValue = preencherProdutos.Categoria.ID;
            cmbCategoria.Refresh();
            PreencherGridComposicao();
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
            produtos.Descricao = txtDescricao.Text;
            produtos.Categoria = RepCategorias.ObterPorId(Int64.Parse(cmbCategoria.SelectedValue.ToString()));
            produtos.Situacao = HelpDesk.Dominio.ObjetosValor.Situacao.Ativo;

            if (ID == 0)
                Repositorio.Salvar(produtos);
            else
            {
                bool resultado = true;
                produtos.ID = ID;
                var dados = RepDerivados.ObterTodos().Select(x => x.Produto.ID);
                foreach (var item in dados)
                {
                    if(produtos.ID == item)
                    {
                        resultado = false;
                    }
                }
                if (resultado)
                {
                   // MessageBox.Show("Alterado com sucesso, reinicie essa tela para atualizar as informações!", "Alterado Com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Repositorio.Alterar(produtos);
                }
                else
                {
                    MessageBox.Show("Não é possível alterar o nome nem a categoria do produto, pois já foi realizada uma movimentação com ele!", "Não foi Possivel Alterar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    LimparControles();
                }
            }
            //LimparControles();
            //txtCodigoProduto.Text = RotinaPadrao<Produtos>.GerarId(Repositorio);
            AtivarDesativarGroupBoxes(true, true);
            tabProdutos.SelectTab(1);
        }

        private void LimparControles()
        {
            RotinaPadrao<Produtos>.limparProdutos(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ID = 0;
            LimparControles();
            txtCodigoProduto.Text = RotinaPadrao<Produtos>.GerarId(Repositorio);
            AtivarDesativarGroupBoxes(false,false);
            btnNovo.Focus();
        }

        IDictionary<String, Object> parametros = new Dictionary<String, Object>();
        IDictionary<String, String> ordenacao = new Dictionary<String, String>();

        private void btnInserirComposicao_Click(object sender, EventArgs e)
        {
                frmInserirComposicao frminserirComposicao = new frmInserirComposicao(int.Parse(txtCodigoProduto.Text));
                frminserirComposicao.ShowDialog();
                PreencherGridComposicao();
        }

        private void PreencherGridComposicao()
        {
            LimparListaParametrosOrdenacao();
            dtgComposicao.AutoGenerateColumns = false;
            Int64 IdProdutos = long.Parse(txtCodigoProduto.Text);
            parametros.Add("Produto.ID", IdProdutos);
            ordenacao.Add("Asc", "Ingrediente");
            dtgComposicao.DataSource = RepIngredientesProdutos.ObterPorParametros(parametros, ordenacao);
        }

        private void LimparListaParametrosOrdenacao()
        {
            parametros.Clear();
            ordenacao.Clear();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            
            frmConsultaProdutos f = new frmConsultaProdutos();
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
            formularioProduto = 1;
            produtos = Repositorio.ObterPorId(f.PassarCodigo);
            try
            {
                PreencherCampos(produtos);
                dtgDerivados.DataSource = PreencherDerivacoes().ToList();
                AtivarDesativarGroupBoxes(true, true);
            }
            catch
            {
                MessageBox.Show("Nenhum Produto Selecionado");
            }
        }

        private IEnumerable<Derivacoes> PreencherDerivacoes()
        {
            RepDerivados = new RepositorioDerivacoes(NHibernateHelper.GetSession());
            LimparListaParametrosOrdenacao();
            parametros.Add("Produto.ID", IdProduto);
            ordenacao.Add("Asc", "Descricao");
            return RepDerivados.ObterPorParametros(parametros, ordenacao);

        }

        private void dtgComposicao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex.Equals(2))
            {
                int linhaIndex = dtgComposicao.CurrentRow.Index;
                int codigo = int.Parse(dtgComposicao.Rows[linhaIndex].Cells[0].Value.ToString());
                IngredientesProdutos IngridProd = new IngredientesProdutos();

                IngridProd = RepIngredientesProdutos.ObterPorId(codigo);
                RepIngredientesProdutos.Excluir(IngridProd);
                PreencherGridComposicao();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = string.Empty;
            LimparControles();
            dtgComposicao.DataSource = null;
            dtgDerivados.DataSource = null;
            ID = 0;
            produtos = new Produtos();
            AtivarDesativarGroupBoxes(false,true);
            txtCodigoProduto.Text = RotinaPadrao<Produtos>.GerarId(Repositorio);
            txtDescricao.Focus();
        }

        private string RemoverFormatacaoValor(string valor)
        {
            ValorSemFormatacao = valor;
            ValorSemFormatacao = RotinaPadrao<Compras>.TirarFormatacao(ValorSemFormatacao);
            return ValorSemFormatacao;
        }

        private void btnAdicionarDerivados_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCodigoProduto.Text))
            IdProduto = Repositorio.ObterTodos().Select(x=>x.ID).Last();
            else
            {
                IdProduto = Repositorio.ObterTodos().Where(x=>x.ID == int.Parse(txtCodigoProduto.Text)).Select(x => x.ID).Last(); 
            }
            RepositorioDerivacoes RepDerivados = new RepositorioDerivacoes(NHibernateHelper.GetSession());
            Derivacoes Derivado = new Derivacoes();
            Derivado.Descricao = txtDescricaoDerivados.Text;
            Derivado.Valor = RotinaPadrao<Derivacoes>.Converter(RemoverFormatacaoValor(txtValor.Text));
            Derivado.DescricaoAbreviada = txtDescricaoAbreviada.Text;
            Derivado.Estoque = int.Parse(txtEstoque.Text);
            Derivado.PermiteEstoqueNegativo = chkPermiteEstoqueNegativo.Checked == true
            ? HelpDesk.Dominio.ObjetosValor.EstoqueNegativo.Sim : 
            HelpDesk.Dominio.ObjetosValor.EstoqueNegativo.Nao;
            Derivado.Produto = Repositorio.ObterPorId(IdProduto);

            if (idDerivacao == 0)
            {
                RepDerivados.Salvar(Derivado);
            }
            else
            {
                Derivado.ID = idDerivacao;
                AdicionarTodosParametros();

                if (!TodosResultados.Contains(false))
                {
                    RepDerivados.Alterar(Derivado);
                    MessageBox.Show("Produto alterado com sucesso", "Alterado Com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O produto não pode ser alterado, pois existe movimentações com esse produto", "Não foi Possivel Alterar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    LimparControles();
                    idDerivacao = 0;
                }
            }

            dtgDerivados.DataSource = PreencherDerivacoes();
            TodosResultados.Clear();
        }

        private void btnCancelarDerivados_Click(object sender, EventArgs e)
        {
            LimparControles();
        }
      
        private void btnCancelarPromocao_Click(object sender, EventArgs e)
        {
            LimparControles();
        }

      
        int idDerivacao = 0;
        private void dtgDerivados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idDerivacao = int.Parse(dtgDerivados.Rows[e.RowIndex].Cells[1].Value.ToString());
            Derivado = RepDerivados.ObterPorId(idDerivacao);

            if (e.ColumnIndex == 0)
            {
                txtDescricaoAbreviada.Text = Derivado.DescricaoAbreviada;
                txtDescricaoDerivados.Text = Derivado.Descricao;
                txtEstoque.Text = Derivado.Estoque.ToString();
                txtValor.Text = Derivado.Valor.ToString();
                chkPermiteEstoqueNegativo.Checked = Derivado.PermiteEstoqueNegativo == HelpDesk.Dominio.ObjetosValor.EstoqueNegativo.Sim ? true : false;
            }
            if(e.ColumnIndex == 8)
            {
                frmAtualizarEstoque frmAtualizar = new frmAtualizarEstoque(idDerivacao);
                frmAtualizar.ShowDialog();
            }
            if (e.ColumnIndex == 9)
            {
                Derivado.ID = idDerivacao;
                AdicionarTodosParametros();

                if (!TodosResultados.Contains(false))
                {
                    if (MessageBox.Show(string.Format("Confirma a exclusão do produto {0} {1}?", Derivado.Produto,Derivado.Descricao), "Excluir Produto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        RepDerivados.Excluir(Derivado);
                        dtgComposicao.DataSource = PreencherDerivacoes();
                    }
                }
                else
                {
                    RepDerivados = new RepositorioDerivacoes(NHibernateHelper.GetSession());
                    MessageBox.Show("O Produto não pode ser excluido, pois existem movimentação com esse bairro", "Não foi Possivel Excluir", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    idDerivacao = 0;
                }
                
            }

            dtgDerivados.DataSource = PreencherDerivacoes();
            TodosResultados.Clear();
        }

        private void AdicionarTodosParametros()
        {
            LimparListaParametrosOrdenacao();
            RepositorioItensCompraProdutos RepCompras = new RepositorioItensCompraProdutos(NHibernateHelper.GetSession());
            RepositorioItensPedido ItensPedido = new RepositorioItensPedido(NHibernateHelper.GetSession());
            
            parametros.Add("Derivacao.ID", Derivado.ID);
            TodosResultados.Add(resultado = RotinaPadrao<ItensPedidos>.VerificarAcaoTabelasIndiretamenteRelacionadas(ItensPedido, parametros));
            parametros.Clear();
            parametros.Add("Derivacao.ID", Derivado.ID);
            TodosResultados.Add(resultado = RotinaPadrao<ItensCompraProdutos>.VerificarAcaoTabelasIndiretamenteRelacionadas(RepCompras, parametros));
            parametros.Clear();
           
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
            (e.KeyChar != ',' && e.KeyChar != '.' &&
             e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValor.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("C");
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtValor.Text.Length - 1; i++)
            {
                if ((txtValor.Text[i] >= '0' &&
                    txtValor.Text[i] <= '9') ||
                    txtValor.Text[i] == ',')
                {
                    x += txtValor.Text[i];
                }
            }
            txtValor.Text = x;
            txtValor.SelectAll();
        }

        private void dtgDerivados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 5)
            e.Value = Convert.ToDouble(e.Value.ToString()).ToString("C");
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    produtos = Repositorio.ObterPorId(int.Parse(txtCodigoProduto.Text));
                    PreencherCampos(produtos);
                    dtgDerivados.DataSource = PreencherDerivacoes().ToList();
                    AtivarDesativarGroupBoxes(true, true);
                }
                catch (Exception erro)
                {
                    erro.HelpLink = "Produto não encontrado";
                    LimparControles();
                    MessageBox.Show(erro.HelpLink);
                }
            }
        }

        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
    
}
