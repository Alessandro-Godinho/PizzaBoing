using HelpDesk.Dominio.Entidades;
using HelpDesk.Repositorio;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PizzaBoingViews
{
    public  class RotinaPadrao<T> where T : IEntidade
    {
        public ISession _session { get;set; }
        public static RepositorioAutenticacao Repautenticacao { get; private set; }
        public static RepositorioFuncionarios RepFuncionarios { get; private set; }

        public static void limparTextBoxes(Control controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            for (int i = 0; i < controles.Controls.Count; i++)
            {
                foreach (Control ctrl in controles.Controls[i].Controls)
                {
                    //Se o contorle for um TextBox...
                    if (ctrl is TextBox)
                    {
                        ((TextBox)(ctrl)).Text = String.Empty;
                    }
                    if (ctrl is Label)
                    {
                        ((Label)(ctrl)).ForeColor = System.Drawing.Color.Black;
                    }
                }

            }
        }

        public static void limparProdutos(Control controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            for (int i = 0; i < controles.Controls.Count-1; i++)
            {
                foreach (Control ctrl in controles.Controls[0].Controls[1].Controls[i].Controls)
                {
                    //Se o contorle for um TextBox...
                    if (ctrl is TextBox)
                    {
                        ((TextBox)(ctrl)).Text = String.Empty;
                    }
                    if (ctrl is Label)
                    {
                        ((Label)(ctrl)).ForeColor = System.Drawing.Color.Black;
                    }
                }

            }
        }

        public RotinaPadrao(ISession session)
        {
            if (session == null)
                throw new ArgumentException("A session deve existir.", "session");
            _session = session;
        }

        public static string GerarId(RepositorioBase<T> repositorio)
        {
            string texto = null;
            var VerificaExisteDadosCadastrados = repositorio.ObterTodos();
            if (VerificaExisteDadosCadastrados.Count != 0)
            {
                var codigo = repositorio.ObterTodos().Select(x => x.ID).Last();
                texto = (codigo + 1).ToString();
            }
            return texto;
        }

        public static double Calcular(DataGridView grid,double desconto)
        {
            double total = 0;
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                total =  total + Convert.ToDouble(RotinaPadrao<T>.TirarFormatacao(grid.Rows[i].Cells[3].Value.ToString()));
            }
            return total = total + desconto;
        }
      
        public static TextBox []ReiniciarVariaveis(TextBox []campo)
        {
            foreach (TextBox item in campo)
            {
                item.Text = string.Empty;
                item.Enabled = false;
            }
          
            return campo;

        }

        public static Funcionarios CarregarOperador(Autenticacoes autenticacao)
        {
            RepFuncionarios = new RepositorioFuncionarios(NHibernateHelper.GetSession());
            Repautenticacao = new RepositorioAutenticacao(NHibernateHelper.GetSession());
            Funcionarios funcionario = new Funcionarios();
            autenticacao = new Autenticacoes();
            Repautenticacao = new RepositorioAutenticacao(NHibernateHelper.GetSession());
            autenticacao = Repautenticacao.ObterPorId(frmLogin.operador);
            funcionario = RepFuncionarios.ObterPorId(autenticacao.Funcionario.ID);
            return funcionario ;
        }
       
        public static Double Converter(string valor)
        {
            double resultado = 0;
            double numero = 0;
            bool tryparse = double.TryParse(valor, out numero );
            if(tryparse)
            {
                resultado = double.Parse(valor);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }
        
        public static void DiminuirEstoque(int produto,double estoque)
        {
            Derivacoes derivacao = new Derivacoes();
            RepositorioDerivacoes RepDerivacao = new RepositorioDerivacoes(NHibernateHelper.GetSession());
            derivacao = RepDerivacao.ObterPorId(produto);
            derivacao.Estoque = derivacao.Estoque - (Int64)estoque;
            RepDerivacao.Alterar(derivacao);
        }
        public static void AdiconarEstoque(int produto, double estoque)
        {
            Derivacoes derivacao = new Derivacoes();
            RepositorioDerivacoes RepDerivacao = new RepositorioDerivacoes(NHibernateHelper.GetSession());
            derivacao = RepDerivacao.ObterPorId(produto);
            derivacao.Estoque = derivacao.Estoque - (Int64)estoque;
            RepDerivacao.Alterar(derivacao);
        }
        public static bool ExecutarAlteracao(T entidade, RepositorioAlteracao localAlteracao)
        {
            bool resultado = false;
            switch(localAlteracao)
            {
                case RepositorioAlteracao.Vendas:
                    VendasService vendas = new VendasService();
                    var dadosVenda = vendas.VerificarLocalAlteracao(localAlteracao);
                    resultado = VerificarAlteracao(dadosVenda, entidade);
                    break;
                case RepositorioAlteracao.ItensVendas:
                    ItensVendasService itensvenda = new ItensVendasService();
                    var dadosItens = itensvenda.VerificarLocalAlteracao(localAlteracao);
                    resultado = VerificarAlteracao(dadosItens, entidade);
                    break;
                case RepositorioAlteracao.Compras:
                    ComprasService compras = new ComprasService();
                    var dadoscompras = compras.VerificarLocalAlteracao(localAlteracao);
                    resultado = VerificarAlteracao(dadoscompras, entidade);
                    break;
                case RepositorioAlteracao.Servicos:
                    ServicosService servicos = new ServicosService();
                    var dadoservicos = servicos.VerificarLocalAlteracao(localAlteracao);
                    resultado = VerificarAlteracao(dadoservicos, entidade);
                    break;
            }
            return resultado;
        }

        private static bool VerificarAlteracao(IList<ServicosPago> dadoservicos, T entidade)
        {
            bool PodeSerAlterado = true;

            foreach (var item in dadoservicos)
            {
                if (item.Servico.ID == entidade.ID)
                {
                    PodeSerAlterado = false;
                }
            }
            return PodeSerAlterado;
        }

        private static bool VerificarAlteracao(IList<Compras> dadoscompras, T entidade)
        {
            bool PodeSerAlterado = true;

            foreach (var item in dadoscompras)
            {
                if (item.Fornecedor.ID == entidade.ID)
                {
                    PodeSerAlterado = false;
                }
            }
            return PodeSerAlterado;
        }

        private static bool VerificarAlteracao(IList<ItensPedidos> dadosItens, T entidade)
        {
            bool PodeSerAlterado = true;

            foreach (var item in dadosItens)
            {
                if (item.ID == entidade.ID)
                {
                    PodeSerAlterado = false;
                }
            }
            return PodeSerAlterado;
        }

        private static bool VerificarAlteracao(IList<PedidosEntrega> dados, T entidade)
        {
            bool PodeSerAlterado = true;

            foreach (var item in dados)
            {
                if (entidade is Clientes)
                {
                    if (item.Cliente.ID == entidade.ID)
                    {
                        PodeSerAlterado = false;
                    }
                }
                else
                {
                    if (item.Funcionario.ID == entidade.ID)
                    {
                        PodeSerAlterado = false;
                    }
                }
            }
          
            return PodeSerAlterado;
        }

        public static string TirarFormatacao(string texto)
        {
            if(texto.Contains("R"))
            {
                texto = texto.Replace("R$", "");
            }
            return texto;
        }
        public static bool VerificarAcaoTabelasIndiretamenteRelacionadas(RepositorioBase<T>Repositorio,IDictionary<string,object> parametros)
        {
            bool resultado = true;
            var dados = Repositorio.ObterPorParametros(parametros);
            if (dados.Count > 0)
                resultado = false;
            return resultado;
        }

    }

}
