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
    public partial class frmConsultaBairros : Form
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
        public static int IdBairro { get; set; }
        IDictionary<String, Object> parametros = new Dictionary<String, Object>();
        Bairros bairros;
        bool resultado;
        List<bool> TodosResultados = new List<bool>();

        public frmConsultaBairros()
        {
            InitializeComponent();
            dtgConsultaBairros.AutoGenerateColumns = false;
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            dtgConsultaBairros.DataSource = Repositorio.ObterTodos();
          
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in Repositorio.ObterTodos() where CaseInsensitiveContains(c.Nome,txtPesquisar.Text) ||
                             CaseInsensitiveContains(c.Nome,txtPesquisar.Text)||
                             CaseInsensitiveContains(c.TaxaEntrega.ToString(), txtPesquisar.Text)
                             select c).ToList();

            dtgConsultaBairros.DataSource = resultado;
            
           
        }

        private void dtgConsultaBairros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaIndex = dtgConsultaBairros.CurrentRow.Index;
            int codigo = int.Parse(dtgConsultaBairros.Rows[linhaIndex].Cells[1].Value.ToString());
            bairros = new Bairros();
            bairros = Repositorio.ObterPorId(codigo);
            if (e.ColumnIndex == 0)
            { 
                IdBairro = codigo;
                this.Close();
            }
            if(e.ColumnIndex == 4)
            {
                AdicionarTodosParametros();

                if (!TodosResultados.Contains(false))
                {
                    if (MessageBox.Show(string.Format("Confirma a exclusão do bairro {0}?",bairros.Nome), "Excluir Bairro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        IdBairro = 0;
                        Repositorio.Excluir(bairros);
                        CarregarGrid();
                    }
                }
                else
                {
                    Repositorio = new RepositorioBairros(NHibernateHelper.GetSession());
                    MessageBox.Show("O bairro não pode ser excluido, pois existem movimentação com esse bairro", "Não foi Possivel Excluir", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            TodosResultados.Clear();
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

        private void dtgConsultaBairros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                e.Value = Convert.ToDouble(e.Value.ToString()).ToString("C");
            }
        }

       
    }
}
