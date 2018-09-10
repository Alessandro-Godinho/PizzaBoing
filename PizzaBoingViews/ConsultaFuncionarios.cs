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
    public partial class frmConsultaFuncionarios : Form
    {
        private RepositorioFuncionarios _repositorio;
        public RepositorioFuncionarios Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioFuncionarios(NHibernateHelper.GetSession());

                return _repositorio;
            }
            set { _repositorio = value; }
        }

        HelpDesk.Dominio.Entidades.Funcionarios funcionarios;
        RepositorioBairros RepBairros = new RepositorioBairros(NHibernateHelper.GetSession());
        public static int Id_Funcionarios { get; set; }
        public frmConsultaFuncionarios()
        {
            InitializeComponent();
            dtgConsultaFuncionarios.AutoGenerateColumns = false;
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            dtgConsultaFuncionarios.DataSource = Repositorio.ObterTodos();
          
        }

        public bool CaseInsensitiveContains(string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            var resultado = (from c in Repositorio.ObterTodos() where CaseInsensitiveContains(c.Nome,txtPesquisar.Text) ||
                             CaseInsensitiveContains(c.Telefone,txtPesquisar.Text)||
                             CaseInsensitiveContains(c.Endereço, txtPesquisar.Text)||
                             CaseInsensitiveContains(c.Bairro.Nome, txtPesquisar.Text)||
                             CaseInsensitiveContains(c.Comissao.ToString(), txtPesquisar.Text)
                             select c).ToList();

            dtgConsultaFuncionarios.DataSource = resultado;
            
           
        }

        private void dtgConsultaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaIndex = dtgConsultaFuncionarios.CurrentRow.Index;
            int codigo = int.Parse(dtgConsultaFuncionarios.Rows[linhaIndex].Cells[1].Value.ToString());
            Id_Funcionarios = codigo;
            funcionarios = Repositorio.ObterPorId(codigo);

            if (e.ColumnIndex == 0)
            {
                this.Close();
            }
            if (e.ColumnIndex == 8)
            {
                bool resultado = RotinaPadrao<Funcionarios>.ExecutarAlteracao(funcionarios, RepositorioAlteracao.Vendas);
                if (resultado)
                {
                    if (MessageBox.Show(string.Format("Confirma a exclusão do Funcionário {0}?", funcionarios.Nome), "Excluir Funcionários", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Id_Funcionarios = 0;
                        Repositorio.Excluir(funcionarios);
                        CarregarGrid();
                    }
                }
                else
                {
                    MessageBox.Show("O funcionário não pode ser excluido, pois já realizou alguma movimentação", "Não foi Possivel Excluir", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
