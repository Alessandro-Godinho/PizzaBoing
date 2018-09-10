using HelpDesk.Dominio.Entidades;
using HelpDesk.Dominio.ObjetosValor;
using HelpDesk.Repositorio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PizzaBoingViews
{
    public partial class frmPedidosBalcao : Form
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

        RepositorioPedidosBalcao RepPedidosBalcao = new RepositorioPedidosBalcao(NHibernateHelper.GetSession());
        RepositorioItensPedido RepIntensPedido;
        PedidosBalcao pedidosBalcao;
        Derivacoes derivacao = new Derivacoes();
        ItensPedidos itensPedido;
        Funcionarios funcionario;
        Autenticacoes autenticacao;
       
        public frmPedidosBalcao()
        {
            InitializeComponent();
            txtOperador.Text = Operador().Nome;
            txtDataCompra.Text = DateTime.Now.ToString();
            cmbModoPagamento.DataSource = Enum.GetNames(typeof(HelpDesk.Dominio.ObjetosValor.TipoPagamento));
            var VerificaExisteDadosCadastrados = Repositorio.ObterTodos();
            if (VerificaExisteDadosCadastrados.Count != 0)
            {
                GerarCodigo();
            }

        }

        private Funcionarios Operador()
        {

            return funcionario = RotinaPadrao<Funcionarios>.CarregarOperador(autenticacao); ;
        }

        private void GerarCodigo()
        {
            long codigo = 0;
            if(RepPedidosBalcao.ObterTodos().Count != 0)
            codigo = RepPedidosBalcao.ObterTodos().Select(x => x.ID).Last();

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
                txtQuantidade.Text, ValorPorQuantidade,Fracionada.Nao,IdentificadorFracao.Nao);
                indexColor = dtgDetalhePedidos.Rows.Count;
                dtgDetalhePedidos.Rows[indexColor-1].DefaultCellStyle.BackColor = Color.YellowGreen;

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
                if(RotinaPadrao<PedidosEntrega>.Converter(lblValorTotal.Text) < 0)
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

        int indexColor;

        private string RemoverFormatacao(string valor)
        {
            valor = RotinaPadrao<Bairros>.TirarFormatacao(valor);
            return valor;
        }

        private void txtCodigoProduto_TextChanged(object sender, EventArgs e)
        {

            long IdProdutoDeMaiorValor = 0;
            if(txtCodigoProduto.Text.StartsWith("/"))
            {
                txtPesquisa frmFracionaria = new txtPesquisa();
                frmFracionaria.ShowDialog();

                //descobrindo o valor por quantidade e aplicar regra do valor da pizza fracionaria

                double maiorValor =0;

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
                    dtgDetalhePedidos.Rows.Add(IdProdutoDeMaiorValor, "Pizza "+frmFracionaria.PassarTamanho, frmFracionaria.PassarQtd, maiorValor.ToString("C"),Fracionada.Sim,IdentificadorFracao.Sim);
                    indexColor = dtgDetalhePedidos.Rows.Count;
                    foreach (var item in frmFracionaria.parametros)
                    {

                        dtgDetalhePedidos.Rows.Add(item.ID, item.Produto, 0, 0,Fracionada.Sim,IdentificadorFracao.Nao);
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
            List<ItensPedidos> itens = new List<ItensPedidos>();
            pedidosBalcao = new PedidosBalcao();
            RepPedidosBalcao = new RepositorioPedidosBalcao(NHibernateHelper.GetSession());
            pedidosBalcao.DataVenda = DateTime.Now;
            pedidosBalcao.Nome = txtNome.Text;
            pedidosBalcao.Desconto = RotinaPadrao<PedidosEntrega>.Converter(txtDesconto.Text);
            pedidosBalcao.TipoPagamento = (TipoPagamento)cmbModoPagamento.SelectedIndex;
            pedidosBalcao.TrocoPara = RotinaPadrao<PedidosEntrega>.Converter(txtTrocoPara.Text);
            pedidosBalcao.Troco = RotinaPadrao<PedidosEntrega>.Converter(RemoverFormatacao(lblTroco.Text));
            pedidosBalcao.ValorTotal = RotinaPadrao<PedidosEntrega>.Converter(RemoverFormatacao(lblValorTotal.Text));
            pedidosBalcao.Funcionario = Operador();
           
            
            for (int i = 0; i < dtgDetalhePedidos.Rows.Count; i++)
            {
                int IdProduto = 0;
                
                itensPedido = new ItensPedidos();
                RepIntensPedido = new RepositorioItensPedido(NHibernateHelper.GetSession());
                IdProduto = int.Parse(dtgDetalhePedidos.Rows[i].Cells[0].Value.ToString());
                derivacao = Repositorio.ObterPorId(IdProduto);
                itensPedido.PedidoBalcao = pedidosBalcao;
                itensPedido.Fracionada =(Fracionada)dtgDetalhePedidos.Rows[i].Cells[4].Value == Fracionada.Sim ? Fracionada.Sim : Fracionada.Nao;
                itensPedido.IdentificadorFracao = (IdentificadorFracao)dtgDetalhePedidos.Rows[i].Cells[5].Value == IdentificadorFracao.Sim ? IdentificadorFracao.Sim : IdentificadorFracao.Nao;
                itensPedido.Derivacao = derivacao;
                itensPedido.Quantidade = RotinaPadrao<PedidosBalcao>.Converter(dtgDetalhePedidos.Rows[i].Cells[2].Value.ToString());
                itens.Add(itensPedido);
                double EstoqueStatus = derivacao.Estoque - itensPedido.Quantidade;

                if (EstoqueStatus < 0 && derivacao.PermiteEstoqueNegativo == EstoqueNegativo.Nao)
                {
                    MessageBox.Show(string.Format("O Produto: {0} {1} Não tem estoque Suficiente, restam apenas {2}", derivacao.Produto, derivacao.Descricao, derivacao.Estoque));
                    return;
                }

            }

            RepPedidosBalcao.Salvar(pedidosBalcao);

            foreach (var pedidos in itens)
            {
                RepIntensPedido.Salvar(pedidos);
                RotinaPadrao<PedidosBalcao>.DiminuirEstoque((int)pedidos.Derivacao.ID, pedidos.Quantidade);
            }
           
            if (MessageBox.Show(string.Format("Deseja imprimir a comanda"), "Imprimir Comanda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Imprimir(itens);
            }
            itens.Clear();
            LimparControles();
        }
        public List<string> CategoriaImpressao { get; set; }
        public string NomeCliente { get; set; }
     
        public double ValorTotal { get; set; }

        public List<object> DadosImpressao { get; set; }
        private void Imprimir(List<ItensPedidos> itens)
        {
            bool PizzaFracionada = false;
            CategoriaImpressao = new List<string>();
            DadosImpressao = new List<object>();
            PrintDocument printDoc = new PrintDocument();
            
          
            foreach (var item in itens)
            {
                if(string.IsNullOrEmpty(NomeCliente))
                {
                    NomeCliente = item.PedidoBalcao.Nome;
                }

                PizzaFracionada = item.Quantidade == 0 ? true : false;

                if(PizzaFracionada)
                {
                    DadosImpressao.Add(string.Format("{0}", item.Derivacao.Produto.Descricao));
                    CategoriaImpressao.Add(string.Empty);
                    DadosImpressao.Add(0.5);
                    CategoriaImpressao.Add("Quantidade" );

                }
                else
                {
                    DadosImpressao.Add(string.Format("{0} {1}", item.Derivacao.Produto.Descricao, item.Derivacao.Descricao));
                    CategoriaImpressao.Add(item.Derivacao.Produto.Categoria.Descricao +" ");
                    CategoriaImpressao.Add("Valor: ");
                    DadosImpressao.Add(item.Quantidade * item.Derivacao.Valor);
                }
                
                ValorTotal += item.Quantidade * item.Derivacao.Valor;
               
                printDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

                
            }

            printDoc.Print();
            //printDoc.Dispose();
        }

        private void LimparControles()
        {
            dtgDetalhePedidos.Rows.Clear();
            RotinaPadrao<PedidosBalcao>.limparTextBoxes(this);
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

        private void cmbModoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbModoPagamento.SelectedIndex ==1)
            {
                TextBox[] text = new TextBox[2] { txtDesconto, txtTrocoPara };
                text = RotinaPadrao<PedidosBalcao>.ReiniciarVariaveis(text);

                ReiniciarValores();
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

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultaDerivacoes frmconsultaProdutos = new frmConsultaDerivacoes();
            frmconsultaProdutos.WindowState = FormWindowState.Normal;
            frmconsultaProdutos.ShowDialog();
            int IdProduto = frmConsultaDerivacoes.PassarCodigo;
            try
            {
                PreencheCampos(IdProduto);
            }
            catch
            {
                LimparCamposItensPedido();
                MessageBox.Show("Nenhum Produto Selecionado");
            }
        }

        private void txtTrocoPara_Validated(object sender, EventArgs e)
        {
            if (trocopara != RotinaPadrao<PedidosEntrega>.Converter(txtTrocoPara.Text))
            {
                trocopara = RotinaPadrao<PedidosEntrega>.Converter(txtTrocoPara.Text);
                lblTroco.Text = (trocopara - RotinaPadrao<PedidosEntrega>.Converter(RemoverFormatacao(lblValorTotal.Text))).ToString("c");

            }
            if(string.IsNullOrEmpty(txtTrocoPara.Text))
            {
                lblTroco.Text = "0";
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Arial Black", 15f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Arial", 10f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Arial", 10f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            ev.Graphics.DrawString("Cliente : " + NomeCliente, titleFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = ev.Graphics.MeasureString("Cliente : " + NomeCliente, pdvFont);
            currentUsedHeight += size.Height;

            for (int i = 0; i < DadosImpressao.Count(); i++)
            {
                ev.Graphics.DrawString(CategoriaImpressao[i] + DadosImpressao[i], pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                size = ev.Graphics.MeasureString(CategoriaImpressao[i] + DadosImpressao[i], pdvFont);
                currentUsedHeight += size.Height;

               /* ev.Graphics.DrawString("Qtd : " + Quantidade[i], pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                size = ev.Graphics.MeasureString("Qtd : " + Quantidade[i], pdvFont);
                currentUsedHeight += size.Height;

                ev.Graphics.DrawString("Preço : " + Valor[i].ToString("C"), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
                size = ev.Graphics.MeasureString("Preço : " + Valor[i].ToString("C"), pdvFont);
                currentUsedHeight += size.Height;*/
            }

            ev.Graphics.DrawString("Valor Total : " + ValorTotal.ToString("C"), pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = ev.Graphics.MeasureString("Valor Total : " + ValorTotal, pdvFont);
            currentUsedHeight += size.Height;
        }
    }
}
