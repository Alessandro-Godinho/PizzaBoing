using HelpDesk.Dominio.Entidades;
using HelpDesk.Dominio.ObjetosValor;
using HelpDesk.Repositorio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PizzaBoingViews
{
    public partial class frmPedidosEntrega : Form
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

        RepositorioPedidosEntregas RepPedidosEntregas;
        RepositorioClientes RepClientes;
        RepositorioFuncionarios RepFuncionarios;
        RepositorioItensPedido RepIntensPedido;
        PedidosEntrega pedidosEntrega;
        Derivacoes derivacao;
        ItensPedidos itensPedido;
        Funcionarios funcionario;
        Clientes cliente;
        Autenticacoes autenticacao;
        public frmPedidosEntrega()
        {
            InitializeComponent();
            txtOperador.Text = Operador().Nome;
            txtDataCompra.Text = DateTime.Now.ToString();
            cmbModoPagamento.DataSource = Enum.GetNames(typeof(HelpDesk.Dominio.ObjetosValor.TipoPagamento));
            CarregarFuncionarios();


            var VerificaExisteDadosCadastrados = Repositorio.ObterTodos();
            if (VerificaExisteDadosCadastrados.Count != 0)
            {
                GerarCodigo();
            }

        }

        private void CarregarFuncionarios()
        {
            RepFuncionarios = new RepositorioFuncionarios(NHibernateHelper.GetSession());
            cmbEntregador.DataSource = RepFuncionarios.ObterTodos();
        }

        private Funcionarios Operador()
        {

            return funcionario = RotinaPadrao<Funcionarios>.CarregarOperador(autenticacao); ;
        }

        private void GerarCodigo()
        {
            var codigo = Repositorio.ObterTodos().Select(x => x.ID).Last();
            txtCodigoPedido.Text = (codigo + 1).ToString();
        }

        private void txtCodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    derivacao = Repositorio.ObterPorId(int.Parse(txtCodigoProduto.Text));
                    txtNomeProduto.Text = derivacao.Descricao;
                    txtValorProduto.Text = derivacao.Valor.ToString();
                    txtQuantidade.Focus();
                    lblMsgEstoque.Visible = derivacao.Estoque <= 0 ? true : false;
                }
                catch
                {
                    MessageBox.Show("Codigo do produto Inexistente");
                }
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            txtTrocoPara.Text = string.Empty;
            txtDesconto.Text = string.Empty;
            ReiniciarValores();

            if (string.IsNullOrEmpty(txtQuantidade.Text) || string.IsNullOrEmpty(txtNomeProduto.Text)
                || string.IsNullOrEmpty(txtValorProduto.Text) || string.IsNullOrEmpty(txtCodigoProduto.Text))
            {
                MessageBox.Show("Informe o produto e a quantidade primeiro");
            }
            else
            {
                string preco = RemoverFormatacao(txtValorProduto.Text);
                double ValorPorQuantidade = RotinaPadrao<PedidosEntrega>.Converter(preco) * RotinaPadrao<PedidosEntrega>.Converter(txtQuantidade.Text);


                dtgDetalhePedidos.Rows.Add(txtCodigoProduto.Text, txtNomeProduto.Text,
                txtQuantidade.Text, ValorPorQuantidade, Fracionada.Nao, IdentificadorFracao.Nao);
                indexColor = dtgDetalhePedidos.Rows.Count;
                dtgDetalhePedidos.Rows[indexColor - 1].DefaultCellStyle.BackColor = Color.YellowGreen;

                Calcular(true);
                LimparCamposItensPedido();
            }
        }

        private void LimparCamposItensPedido()
        {
            txtCodigoProduto.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtValorProduto.Text = string.Empty;

        }

        private void dtgDetalhePedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(6))
            {

                double total = 0;
                total = RotinaPadrao<PedidosEntrega>.Converter(RemoverFormatacao(lblValorTotal.Text));
                total = total - Convert.ToDouble(dtgDetalhePedidos.Rows[e.RowIndex].Cells[3].Value);
                lblValorTotal.Text = (total + desconto).ToString("C");
                dtgDetalhePedidos.Rows.RemoveAt(e.RowIndex);
                lblTroco.Text = "0";
                txtTrocoPara.Text = string.Empty;
                txtDesconto.Text = string.Empty;
                desconto = 0;
                trocopara = 0;
                valorAntigo = 0;
                if (RotinaPadrao<PedidosEntrega>.Converter(lblValorTotal.Text) < 0)
                {
                    lblValorTotal.Text = "0";
                }

            }
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

        private void PreencheCampos(int produto_Id)
        {
            derivacao = Repositorio.ObterPorId(produto_Id);
            txtCodigoProduto.Text = produto_Id.ToString();
            txtNomeProduto.Text = derivacao.Produto.Descricao + " " + derivacao.Descricao;
            txtValorProduto.Text = derivacao.Valor.ToString("C");
            txtQuantidade.Focus();
            lblMsgEstoque.Visible = derivacao.Estoque <= 0 ? true : false;
        }

        private string RemoverFormatacao(string valor)
        {
            valor = RotinaPadrao<Bairros>.TirarFormatacao(valor);
            return valor;
        }

        int indexColor;
        private void txtCodigoProduto_TextChanged(object sender, EventArgs e)
        {

            long IdProdutoDeMaiorValor = 0;
            if (txtCodigoProduto.Text.StartsWith("/"))
            {
                txtPesquisa frmFracionaria = new txtPesquisa();
                frmFracionaria.ShowDialog();

                //descobrindo o valor por quantidade e aplicar regra do valor da pizza fracionaria

                double maiorValor = 0;

                if (frmFracionaria.parametros != null)
                {
                    foreach (var item in frmFracionaria.parametros)
                    {
                        if (maiorValor < item.Valor)
                        {
                            IdProdutoDeMaiorValor = item.ID;
                            maiorValor = item.Valor;
                        }

                    }

                    maiorValor = maiorValor * double.Parse(frmFracionaria.PassarQtd);
                    dtgDetalhePedidos.Rows.Add(IdProdutoDeMaiorValor, "Pizza " + frmFracionaria.PassarTamanho, frmFracionaria.PassarQtd, maiorValor.ToString("C"), Fracionada.Sim, IdentificadorFracao.Sim);
                    indexColor = dtgDetalhePedidos.Rows.Count;
                    foreach (var item in frmFracionaria.parametros)
                    {

                        dtgDetalhePedidos.Rows.Add(item.ID, item.Produto, 0, 0, Fracionada.Sim, IdentificadorFracao.Nao);
                        dtgDetalhePedidos.Rows[dtgDetalhePedidos.Rows.GetNextRow(indexColor - 2, DataGridViewElementStates.Displayed)].DefaultCellStyle.BackColor = Color.Yellow;

                    }

                    Calcular(true);
                    LimparCamposItensPedido();
                }
                else
                {
                    this.Close();
                }
                txtCodigoProduto.Clear();
            }
        }

        private void btnGravarPedido_Click(object sender, EventArgs e)
        {
            pedidosEntrega = new PedidosEntrega();
            RepPedidosEntregas = new RepositorioPedidosEntregas(NHibernateHelper.GetSession());
            List<ItensPedidos> itens = new List<ItensPedidos>();
            pedidosEntrega.DataVenda = DateTime.Now;
            pedidosEntrega.Desconto = RotinaPadrao<PedidosEntrega>.Converter(txtDesconto.Text);
            pedidosEntrega.TipoPagamento = (TipoPagamento)cmbModoPagamento.SelectedIndex;
            pedidosEntrega.TrocoPara = RotinaPadrao<PedidosEntrega>.Converter(txtTrocoPara.Text);
            pedidosEntrega.Troco = RotinaPadrao<PedidosEntrega>.Converter(RemoverFormatacao(lblTroco.Text));
            pedidosEntrega.ValorTotal = RotinaPadrao<PedidosEntrega>.Converter(RemoverFormatacao(lblValorTotal.Text));
            pedidosEntrega.Funcionario = Operador();
            pedidosEntrega.Entrega = GravarEntregador();
            pedidosEntrega.Cliente = cliente;
            if(pedidosEntrega.Cliente == null)
            {
                MessageBox.Show("Informe um cliente para a entrega");
                return;
            }
            pedidosEntrega.SituacaoPedido = SituacaoPedido.Aprovado;

            for (int i = 0; i < dtgDetalhePedidos.Rows.Count; i++)
            {
                int IdProduto = 0;

                itensPedido = new ItensPedidos();
                RepIntensPedido = new RepositorioItensPedido(NHibernateHelper.GetSession());
                IdProduto = int.Parse(dtgDetalhePedidos.Rows[i].Cells[0].Value.ToString());
                derivacao = Repositorio.ObterPorId(IdProduto);
                itensPedido.PedidoEntrega = pedidosEntrega;
                itensPedido.Fracionada = (Fracionada)dtgDetalhePedidos.Rows[i].Cells[4].Value == Fracionada.Sim ? Fracionada.Sim : Fracionada.Nao;
                itensPedido.IdentificadorFracao = (IdentificadorFracao)dtgDetalhePedidos.Rows[i].Cells[5].Value == IdentificadorFracao.Sim ? IdentificadorFracao.Sim : IdentificadorFracao.Nao;
                itensPedido.Derivacao = derivacao;
                itensPedido.Quantidade = RotinaPadrao<PedidosBalcao>.Converter(dtgDetalhePedidos.Rows[i].Cells[2].Value.ToString());
                itens.Add(itensPedido);
                double EstoqueStatus = derivacao.Estoque - itensPedido.Quantidade;

                if (EstoqueStatus < 0 && derivacao.PermiteEstoqueNegativo == EstoqueNegativo.Nao)
                {
                    MessageBox.Show(string.Format("O Produto: {0} {1} Não tem estoque Suficiente, restam apenas {2}", derivacao.Produto,derivacao.Descricao,derivacao.Estoque));
                    return;
                }

            }

            RepPedidosEntregas.Salvar(pedidosEntrega);

            foreach (var pedidos in itens)
            {
                RepIntensPedido.Salvar(pedidos);
                RotinaPadrao<PedidosBalcao>.DiminuirEstoque((int)pedidos.Derivacao.ID, pedidos.Quantidade);
            }

            itens.Clear();
            LimparControles();
        }

        private void LimparControles()
        {
            dtgDetalhePedidos.Rows.Clear();
            RotinaPadrao<PedidosEntrega>.limparTextBoxes(this);
            txtNome.Focus();
            GerarCodigo();
            lblValorTotal.Text = "0";
            ReiniciarValores();
            lblTroco.ForeColor = Color.Blue;
            lblValorTotal.ForeColor = Color.Red;
            lblMsgEstoque.ForeColor = Color.Red;
            lblfracionaria.ForeColor = Color.Red;
            txtDataCompra.Text = DateTime.Now.ToString();
        }

        private Entregas GravarEntregador()
        {
            Entregas entrega = new Entregas();
            RepositorioEntregas RepEntregas = new RepositorioEntregas(NHibernateHelper.GetSession());
            entrega.Funcionario = (Funcionarios)cmbEntregador.SelectedValue;
            entrega.DataHoraEntrega = null;

            RepEntregas.Salvar(entrega);

            return entrega;
        }

        private void cmbModoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox[] text = new TextBox[2] { txtDesconto, txtTrocoPara };
            if (cmbModoPagamento.SelectedIndex == 1)
            {
                text = RotinaPadrao<PedidosBalcao>.ReiniciarVariaveis(text);

                desconto = 0;
                trocopara = 0;
                valorAntigo = 0;
                lblTroco.Text = "0";
                Calcular(true);
            }
            else
            {
                txtTrocoPara.Enabled = true;
                txtDesconto.Enabled = true;
            }
        }

        private void ReiniciarValores()
        {
            desconto = 0;
            trocopara = 0;
            valorAntigo = 0;
            lblTroco.Text = "0";
            Calcular(true);
        }

        double desconto;
        double trocopara;
        double valorAntigo;

        private void txtTrocoPara_Validated(object sender, EventArgs e)
        {
            if (trocopara != RotinaPadrao<PedidosEntrega>.Converter(txtTrocoPara.Text))
            {
                trocopara = RotinaPadrao<PedidosEntrega>.Converter(txtTrocoPara.Text);
                lblTroco.Text = (trocopara - RotinaPadrao<PedidosEntrega>.Converter(RemoverFormatacao(lblValorTotal.Text))).ToString("c");

            }
            if (string.IsNullOrEmpty(txtTrocoPara.Text))
            {
                lblTroco.Text = "0";
            }
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (txtDesconto.Text != desconto.ToString())
            {
                desconto = RotinaPadrao<PedidosBalcao>.Converter(txtDesconto.Text);
                valorAntigo = desconto - valorAntigo;
                lblValorTotal.Text = (RotinaPadrao<PedidosEntrega>.Converter(RemoverFormatacao(lblValorTotal.Text)) - valorAntigo).ToString("c");
                lblTroco.Text = (RotinaPadrao<PedidosEntrega>.Converter(RemoverFormatacao(lblTroco.Text)) + valorAntigo).ToString("c");
                valorAntigo = desconto;
            }

        }

        private void Calcular(bool operacao)
        {
            lblValorTotal.Text = (RotinaPadrao<PedidosBalcao>.Calcular(dtgDetalhePedidos, desconto).ToString("C"));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RepClientes = new RepositorioClientes(NHibernateHelper.GetSession());

            var buscaCliente = RepClientes.ObterTodos().Where(x => x.Telefone.ToString() == txtTelefone.Text.Trim() ||
                                x.Telefone2.ToString() == txtTelefone.Text).ToList();


            if (buscaCliente.Count > 1)
            {
                frmConsultaClientes frmconsultaCliente = new frmConsultaClientes(buscaCliente);
                frmconsultaCliente.ShowDialog();
                buscaCliente = RepClientes.ObterTodos().Where(x => x.ID == frmConsultaClientes.passarCodCli).ToList();
                buscaCliente = PreencherInformacaoClientes(buscaCliente).ToList();
            }
            else if (buscaCliente.Count == 1)
            {
                buscaCliente = PreencherInformacaoClientes(buscaCliente).ToList();
            }
            else
            {
                MessageBox.Show("Não existe nenhum cliente com esse telefone");
            }
        }

        private IList<Clientes> PreencherInformacaoClientes(IList<Clientes> buscaCliente)
        {
            cliente = new Clientes();
            foreach (var item in buscaCliente)
            {
                txtNome.Text = item.Nome;
                txtEndereco.Text = item.Endereço;
                txtNumero.Text = item.Numero;
                txtReferencia.Text = item.Referencia;
                txtBairro.Text = item.Bairro.Nome;
                cliente = item;
            }
           
            return buscaCliente;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultaDerivacoes frmconsultaProdutos = new frmConsultaDerivacoes();
            frmconsultaProdutos.WindowState = FormWindowState.Normal;
            frmconsultaProdutos.ShowDialog();
            int IdProduto = frmConsultaDerivacoes.PassarCodigo;
            PreencheCampos(IdProduto);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
