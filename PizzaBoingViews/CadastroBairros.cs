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
    public partial class frmCadastroBairros : Form
    {
        private RepositorioBairros _repositorio;
        public RepositorioBairros Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioBairros(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        private Int64 ID;
        HelpDesk.Dominio.Entidades.Bairros bairros;
        IDictionary<String, Object> parametros = new Dictionary<String, Object>();
        bool resultado;
        List<bool> TodosResultados = new List<bool>();

        public frmCadastroBairros()
        {
            InitializeComponent();
            GerarCodigoId();
          
        }

        private void GerarCodigoId()
        {
            txtCodigo.Text = RotinaPadrao<Bairros>.GerarId(Repositorio);
        }

        private void PreencherCampos(int IdBairro)
        {
            ID = IdBairro;
            bairros = Repositorio.ObterPorId(ID);
            txtCodigo.Text = bairros.ID.ToString() ;
            txtTaxaEntrega.Text = bairros.TaxaEntrega.ToString(); ;
            txtNome.Text = bairros.Nome; 
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
            RemoverFormatacao();
            bairros.Nome = txtNome.Text;
            bairros.TaxaEntrega = double.Parse(txtTaxaEntrega.Text);
            bairros.Situacao = HelpDesk.Dominio.ObjetosValor.Situacao.Ativo;

            if (ID == 0)
                Repositorio.Salvar(bairros);
            else
            {
                AdicionarTodosParametros();

                if (!TodosResultados.Contains(false))
                {
                    Repositorio.Alterar(bairros);
                    MessageBox.Show("Bairro alterado com sucesso", "Alterado Com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Repositorio = new RepositorioBairros(NHibernateHelper.GetSession());
                    MessageBox.Show("O bairro não pode ser alterado, pois existem movimentações com esse bairro", "Não foi Possivel Alterar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            RepositorioCompras RepCompras = new RepositorioCompras(NHibernateHelper.GetSession());
            RepositorioPedidosBalcao RepPedBalcao = new RepositorioPedidosBalcao(NHibernateHelper.GetSession());
            RepositorioPedidosEntregas RepPedidos = new RepositorioPedidosEntregas(NHibernateHelper.GetSession());
            parametros.Add("Cliente.Bairro.ID", bairros.ID);
            TodosResultados.Add(resultado = RotinaPadrao<PedidosEntrega>.VerificarAcaoTabelasIndiretamenteRelacionadas(RepPedidos, parametros));
            parametros.Clear();
            parametros.Add("Funcionario.Bairro.ID", bairros.ID);
            TodosResultados.Add(resultado = RotinaPadrao<PedidosEntrega>.VerificarAcaoTabelasIndiretamenteRelacionadas(RepPedidos, parametros));
            parametros.Clear();
            parametros.Add("Funcionario.Bairro.ID", bairros.ID);
            TodosResultados.Add(resultado = RotinaPadrao<PedidosBalcao>.VerificarAcaoTabelasIndiretamenteRelacionadas(RepPedBalcao, parametros));
            parametros.Clear();
            parametros.Add("Funcionario.Bairro.ID", bairros.ID);
            TodosResultados.Add(resultado = RotinaPadrao<Compras>.VerificarAcaoTabelasIndiretamenteRelacionadas(RepCompras, parametros));
            parametros.Clear();
        }

        private void RemoverFormatacao()
        {
            txtTaxaEntrega.Text = RotinaPadrao<Bairros>.TirarFormatacao(txtTaxaEntrega.Text);
        }

        private void SituacaoGrupoBox(bool situacao)
        {
            grbCadastroBairro.Enabled = situacao;
        }

        private void LimparControles()
        {
            RotinaPadrao<Bairros>.limparTextBoxes(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SituacaoGrupoBox(false);
            ID = 0;
            LimparControles();
            GerarCodigoId();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            SituacaoGrupoBox(true);
            frmConsultaBairros f = new frmConsultaBairros();
            f.ShowDialog();
            try
            {
                PreencherCampos(frmConsultaBairros.IdBairro);
            }
            catch(Exception erro)
            {
                SituacaoGrupoBox(false);
                erro.HelpLink = "Nenhum Bairro Selecionado";
                MessageBox.Show(erro.HelpLink);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            SituacaoGrupoBox(true);
            LimparControles();
            ID = 0;
            bairros = new Bairros();
            GerarCodigoId();
            txtNome.Focus();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    PreencherCampos(int.Parse(txtCodigo.Text));
                    SituacaoGrupoBox(true);
                }
                catch (Exception erro)
                {
                    erro.HelpLink = "Bairro não encontrado";
                    SituacaoGrupoBox(false);
                    GerarCodigoId();
                    LimparControles();
                    MessageBox.Show(erro.HelpLink);
                }
            }
        }

        private void txtTaxaEntrega_Leave(object sender, EventArgs e)
        {
            txtTaxaEntrega.Text = Convert.ToDouble(txtTaxaEntrega.Text).ToString("C");
        }

        private void txtTaxaEntrega_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (!txtTaxaEntrega.Text.Contains(','))
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

        private void txtTaxaEntrega_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtTaxaEntrega.Text.Length - 1; i++)
            {
                if ((txtTaxaEntrega.Text[i] >= '0' &&
                    txtTaxaEntrega.Text[i] <= '9') ||
                    txtTaxaEntrega.Text[i] == ',')
                {
                    x += txtTaxaEntrega.Text[i];
                }
            }
            txtTaxaEntrega.Text = x;
            txtTaxaEntrega.SelectAll();
        }
    }
}
