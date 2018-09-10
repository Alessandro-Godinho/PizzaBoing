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
    public partial class frmConsultaServicos : Form
    {
        private RepositorioServicos _repositorio;
        public RepositorioServicos Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioServicos(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        public static int CodigoServico;
        
        public frmConsultaServicos()
        {
            InitializeComponent();
            dtgConsultaServico.AutoGenerateColumns = false;
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            dtgConsultaServico.DataSource = Repositorio.ObterTodos();
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in Repositorio.ObterTodos() where CaseInsensitiveContains(c.Descricao,txtPesquisar.Text) ||
                             CaseInsensitiveContains(c.Descricao,txtPesquisar.Text)
                             select c).ToList();

            dtgConsultaServico.DataSource = resultado;
            
        }

        private void dtgConsultaBairros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaIndex = dtgConsultaServico.CurrentRow.Index;
            int codigo = int.Parse(dtgConsultaServico.Rows[linhaIndex].Cells[1].Value.ToString());
            CodigoServico = codigo;
            Servicos servico = new Servicos();
            servico = Repositorio.ObterPorId(codigo);

            if (e.ColumnIndex == 0)
            {
                this.Close();
            }
            if (e.ColumnIndex == 3)
            {

                bool resultado = RotinaPadrao<Servicos>.ExecutarAlteracao(servico, RepositorioAlteracao.Servicos);
                if (resultado)
                {
                    if (MessageBox.Show(string.Format("Confirma a exclusão do serviço {0}?", servico.Descricao), "Excluir Serviço", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CodigoServico = 0;
                        Repositorio.Excluir(servico);
                        CarregarGrid();
                    }
                }
                else
                {
                    MessageBox.Show("O serviço não pode ser excluido, pois já existe(m) pagamento(s) com ele", "Não foi Possivel Excluir", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
