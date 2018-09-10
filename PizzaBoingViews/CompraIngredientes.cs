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
    public partial class frmCompraIngredientes : Form
    {
        private RepositorioIngredientes _repositorio;
        public RepositorioIngredientes Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioIngredientes(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        RepositorioCompras RepCompras = new RepositorioCompras(NHibernateHelper.GetSession());
        RepositorioItensCompraIngredientes RepIntensComprasIngredientes;
        RepositorioParcelas RepParcelas;
        Compras compras;
        Ingredientes ingredientes;
        ItensCompraIngredientes itensCompraIngredientes;
        Funcionarios funcionario;
        Parcelas parcelas;
        Autenticacoes autenticacao;
        String ValorSemFormatacao;
        public frmCompraIngredientes()
        {
            InitializeComponent();
            txtOperador.Text = Operador().ToString();
            cmbModoPagamento.DataSource = Enum.GetNames(typeof(HelpDesk.Dominio.ObjetosValor.TipoPagamento));
            cmbFormaPagamento.DataSource = Enum.GetNames(typeof(HelpDesk.Dominio.ObjetosValor.FormaPagamento));
        }

        private Funcionarios Operador()
        {

            return funcionario = RotinaPadrao<Funcionarios>.CarregarOperador(autenticacao); ;
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

        int indexColor;
        int AdicionarDias = 30;
        private void btnGravarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                compras = new Compras();
                RepCompras = new RepositorioCompras(NHibernateHelper.GetSession());

                compras.NF_Recibo = int.Parse(txtNF_Recibo.Text);
                compras.DataCompra = dtpDataCompra.Value;
                compras.Funcionario = Operador();
                Fornecedores fornecedores = new Fornecedores();
                RepositorioFornecedores RepFornecedores = new RepositorioFornecedores(NHibernateHelper.GetSession());
                fornecedores = RepFornecedores.ObterPorId(int.Parse(txtCodigoFornecedor.Text));
                compras.Fornecedor = fornecedores;
                compras.Situacao = cmbFormaPagamento.SelectedIndex.Equals(1) ? Situacao.Ativo : Situacao.Inativo;
                compras.TipoPagamento = (TipoPagamento)cmbModoPagamento.SelectedIndex;
                compras.FormaPagamento = (FormaPagamento)cmbFormaPagamento.SelectedIndex;
                compras.ValorTotal = RotinaPadrao<Compras>.Converter(RemoverFormatacaoValor(lblValorTotal.Text));
                RepCompras.Salvar(compras);

                if (cmbParcelas.SelectedIndex >= 0)
                {
                    for (int i = 0; i < int.Parse(cmbParcelas.SelectedItem.ToString()); i++)
                    {
                        parcelas = new Parcelas();
                        RepParcelas = new RepositorioParcelas(NHibernateHelper.GetSession());
                        parcelas.Compras = compras;
                        parcelas.DataPagamento = null;
                        parcelas.ValorParcela = System.Math.Round(compras.ValorTotal / int.Parse((cmbParcelas.SelectedIndex + 1).ToString()), 2);
                        parcelas.DataVencimento = dtpDataCompra.Value;
                        RepParcelas.Salvar(parcelas);
                        dtpDataCompra.Value = DateTime.Now.AddDays(AdicionarDias);
                        AdicionarDias = AdicionarDias + 30;
                    }

                }

                try
                {
                    for (int i = 0; i < dtgDetalhesIngredientes.RowCount; i++)
                    {
                    
                        itensCompraIngredientes = new ItensCompraIngredientes();
                        RepIntensComprasIngredientes = new RepositorioItensCompraIngredientes(NHibernateHelper.GetSession());

                        int IdIngrediente = int.Parse(dtgDetalhesIngredientes.Rows[i].Cells[0].Value.ToString());
                        Ingredientes ingrediente = new Ingredientes();
                        RepositorioIngredientes RepIngredientes = new RepositorioIngredientes(NHibernateHelper.GetSession());
                        ingrediente = RepIngredientes.ObterPorId(IdIngrediente);

                        itensCompraIngredientes.Compra = compras;
                        itensCompraIngredientes.Ingrediente = ingrediente;
                        itensCompraIngredientes.Quantidade = int.Parse(dtgDetalhesIngredientes.Rows[i].Cells[2].Value.ToString());
                        RepIntensComprasIngredientes.Salvar(itensCompraIngredientes); 
                     }
                }
                catch
                {
                    MessageBox.Show("Verifique se adicionou algum produto para compra");
                }

                LimparControles();
            }
            catch
            {
                MessageBox.Show("Verifique se preencheu as informações de compra e se adicionou algum produto para compra");
            }

           
        }

        private void LimparControles()
        {
            RotinaPadrao<Compras>.limparTextBoxes(this);
            dtgDetalhesIngredientes.Rows.Clear();
            lblValorTotal.ForeColor = Color.Red;
            txtNF_Recibo.Focus();

        }

        private void Calcular(bool operacao, DataGridView grid)
        {
            lblValorTotal.Text = (RotinaPadrao<PedidosBalcao>.Calcular(dtgDetalhesIngredientes, 0).ToString("C"));
        }


        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPagamento.SelectedIndex == 1)
            {
                cmbParcelas.Enabled = false;
                cmbParcelas.SelectedIndex = -1;
            }
            else
            {
                cmbParcelas.Enabled = true;
                cmbParcelas.SelectedIndex = 0;

            }
        }

        private void btnConsultaIngrediente_Click(object sender, EventArgs e)
        {
            frmConsultaIngredientes f = new frmConsultaIngredientes();
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
            int IdIngrediente = frmConsultaIngredientes.CodigoIngrediente;
          
            try
            {
                PreencherIngrediente(IdIngrediente);
            }
            catch 
            {
                MessageBox.Show("Nenhum Ingrediente Selecionado");
            }
          
        }

        private void PreencherIngrediente(int id)
        {
            Ingredientes ingrediente = new Ingredientes();
            RepositorioIngredientes RepIngredientes = new RepositorioIngredientes(NHibernateHelper.GetSession());
            ingrediente = RepIngredientes.ObterPorId(id);
            txtCodigoIngrediente.Text = id.ToString();
            txtNomeIngrediente.Text = ingrediente.Descricao;
            txtValorIngrediente.Text = ingrediente.Valor.ToString("C");
        }

        private void btnConsultarFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedores f = new frmConsultaFornecedores();
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
            int IdFornecedor = frmConsultaFornecedores.passarCodigoFornecedor;

            try
            {
                PreencherFornecedor(IdFornecedor);
            }
            catch
            {
                MessageBox.Show("Nenhum Fornecedor Selecionado");
            }
           
        }

        private void PreencherFornecedor(int IdFornecedor)
        {
            RepositorioFornecedores RepFornecedores = new RepositorioFornecedores(NHibernateHelper.GetSession());
            Fornecedores fornecedores = new Fornecedores();
            fornecedores = RepFornecedores.ObterPorId(IdFornecedor);
            txtCodigoFornecedor.Text = IdFornecedor.ToString();
            txtNomeFornecedor.Text = fornecedores.NomeEmpresa;
        }

        private void btnAdicionarIngrediente_Click(object sender, EventArgs e)
        {
            double ValorPorQuantidade = RotinaPadrao<PedidosEntrega>.Converter(RemoverFormatacaoValor(txtValorIngrediente.Text)) * RotinaPadrao<PedidosEntrega>.Converter(txtQuantidadeIngrediente.Text);
            PopularGridViews(dtgDetalhesIngredientes, txtCodigoIngrediente.Text, txtNomeIngrediente.Text, txtQuantidadeIngrediente.Text, ValorPorQuantidade);
        }


        private void PopularGridViews(DataGridView gridiview,string id,string nome, string qtd, double valor)
        {

            if (string.IsNullOrEmpty(qtd) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Informe o produto e a quantidade primeiro");
            }

            else
            {
                gridiview.Rows.Add(id, nome, qtd, valor);
                indexColor = gridiview.Rows.Count;
                gridiview.Rows[indexColor - 1].DefaultCellStyle.BackColor = Color.YellowGreen;
            }

            Calcular(true,gridiview);
        }

        private string RemoverFormatacaoValor(string valor)
        {
            ValorSemFormatacao = valor;
            ValorSemFormatacao = RotinaPadrao<Compras>.TirarFormatacao(ValorSemFormatacao);
            return ValorSemFormatacao;
        }

        private void RemoverItem(DataGridView grid, DataGridViewCellEventArgs linha)
        {
            double total = 0;
            total = RotinaPadrao<Compras>.Converter(RemoverFormatacaoValor(lblValorTotal.Text));
            total = total - Convert.ToDouble(grid.Rows[linha.RowIndex].Cells[3].Value);
            lblValorTotal.Text = (total).ToString("C");
            grid.Rows.RemoveAt(linha.RowIndex);

            if (RotinaPadrao<Compras>.Converter(lblValorTotal.Text) < 0)
            {
                lblValorTotal.Text = "0";
            }
        }

        private void dtgDetalhesIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(4))
            {
                RemoverItem(dtgDetalhesIngredientes, e);
            }
        }
        private void txtCodigoIngrediente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
                try
                {
                    PreencherIngrediente(int.Parse(txtCodigoIngrediente.Text));
                }
                catch
                {
                    MessageBox.Show("Codigo do Ingrediente Inexistente");
                    string.IsNullOrEmpty(txtNomeIngrediente.Text);
                    string.IsNullOrEmpty(txtCodigoIngrediente.Text);
                    string.IsNullOrEmpty(txtValorIngrediente.Text);
                }
            }
        }

        private void cmbModoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModoPagamento.SelectedIndex == 1)
            {
                var formapagamento = from f in Enum.GetNames(typeof(HelpDesk.Dominio.ObjetosValor.FormaPagamento))
                                     where f.Contains(FormaPagamento.Parcelado.ToString())
                                     select f;
                cmbFormaPagamento.DataSource = formapagamento.ToList();
            }
            else
            {
                cmbFormaPagamento.DataSource = Enum.GetNames(typeof(HelpDesk.Dominio.ObjetosValor.FormaPagamento));
            }
        }

        private void txtCodigoFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    PreencherFornecedor(int.Parse(txtCodigoFornecedor.Text));
                }
                catch (Exception erro)
                {
                    erro.HelpLink = "Fornecedor não encontrado";
                    MessageBox.Show(erro.HelpLink);
                    string.IsNullOrEmpty(txtNomeFornecedor.Text);
                    string.IsNullOrEmpty(txtCodigoFornecedor.Text);
                }
            }
        }

        private void txtCodigoFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodigoIngrediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void dtgDetalhesIngredientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = Convert.ToDouble(e.Value.ToString()).ToString("C");
            }
        }

        private void txtQuantidadeIngrediente_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtQuantidadeIngrediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
