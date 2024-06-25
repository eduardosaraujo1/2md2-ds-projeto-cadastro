using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace projetoCadastro
{
    /*
        RELATÓRIO
        GerarRelatorio (return string)
        StringBuilder documentoString = new StringBuilder()
        Valores para acompanhar:
        - Pointer entidade sendo adicionada no StringBuilder
        - Posicao do "cursor", onde coisas estão sendo escritas
        - Numeração da página
    */
    public static class RelatorioConfig
    {
        public static Font PrintFont = new Font("Courier New", 10);
        public static Brush PrintColor = Brushes.Black;
        public static PointF PrintMargin = new PointF(50, 50);
        public static int PageWidth = 84; // unidade em largura do caractere
        public static int PageHeight = 68; // unidade em largura do caractere 
    }
    public abstract class Relatorio
    {
        protected int PageWidth = RelatorioConfig.PageWidth;
        protected int PageHeight = RelatorioConfig.PageHeight;

        protected int pageCount = 1;
        protected int linhaAtual = 1;
        protected int pointerCadastro = 0;
        protected int cadastrosLength { get; set; }
        protected int alturaCabecalho { get; set; }

        protected abstract string GerarLinhaRelatorio(int pointer);
        protected abstract string GerarHeaderTabela();

        protected int GetNumeroCadastros<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    return i;
                }
            }
            return array.Length - 1;
        }
        protected string NormalizarTamanhoColuna(string coluna, int tamanho)
        {
            if (coluna.Length > tamanho)
            {
                return coluna.Substring(0, tamanho - 3) + "..." + ' ';
            }
            else
            {
                return coluna.PadRight(tamanho) + ' ';
            }
        }
        protected string GerarCabecalho()
        {
            string cabecalho = "ETEC ADOLPHO BEREZIN\n";

            string paginaDisplay = "Pág: " + pageCount.ToString("D2") + '\n';
            string tituloDisplay = "Relatório de Usuários".PadRight(PageWidth - paginaDisplay.Length); // PadRight faz paginaDisplay se alinhar à direita

            cabecalho += tituloDisplay;
            cabecalho += paginaDisplay;
            //table header
            cabecalho += GerarHeaderTabela();
            linhaAtual = alturaCabecalho + 1; // + 1 pois não estamos na ultima linha do cabecalho, mas sim uma linha abaixo

            return cabecalho;
        }
        protected string GerarPaginaRelatorio()
        {
            string pagina = GerarCabecalho();
            while (!AlcancouUltimaLinha())
            {
                pagina += GerarLinhaRelatorio(pointerCadastro) + '\n';
                pointerCadastro++;
                linhaAtual++;

                if (AlcancouUltimoCadastro())
                {
                    break;
                }
            }

            return pagina;
        }
        protected char IrParaProximaPagina()
        {
            linhaAtual = 1;
            pageCount++;
            return (char)12;
        }
        public string GerarRelatorio()
        {
            string relatorio = "";
            while (!AlcancouUltimoCadastro())
            {
                relatorio += GerarPaginaRelatorio();
                relatorio += IrParaProximaPagina();
            }
            return relatorio;
        }

        bool AlcancouUltimoCadastro() => pointerCadastro >= cadastrosLength;
        bool AlcancouUltimaLinha() => linhaAtual > PageHeight;
    }

    public class RelatorioUsuario : Relatorio
    {
        Usuario[] cadastros { get; set; }

        // parametros do relatório
        // tabelas
        private int widthColCodigo { get; set; }
        private int widthColNome { get; set; }
        private int widthColLogin { get; set; }

        public RelatorioUsuario()
        {
            // definindo parametros do formulário
            // unidades em caracteres (e.g. 6 caracteres)
            alturaCabecalho = 5;
            widthColCodigo = 6;
            widthColNome = 50;
            widthColLogin = PageWidth - (widthColCodigo + widthColNome + 3); // esse 3 leva em consideração o separador entre as colunas, que é 1 espaço extra (incluido no método AdicionarCampoTabelaHeader)

            cadastros = Storage.usuarios;
            cadastrosLength = GetNumeroCadastros(cadastros);
        }
        protected override string GerarHeaderTabela()
        {
            string cabecalho = "";
            cabecalho += new string('-', PageWidth) + '\n';
            cabecalho += NormalizarTamanhoColuna("Código", widthColCodigo);
            cabecalho += NormalizarTamanhoColuna("Nome", widthColNome);
            cabecalho += NormalizarTamanhoColuna("Login", widthColLogin) + '\n';
            cabecalho += new string('-', PageWidth) + '\n';
            return cabecalho;
        }

        protected override string GerarLinhaRelatorio(int pointer)
        {
            string atributo;
            string linha = "";

            Usuario u = cadastros[pointer];
            atributo = ((int)u.codigo).ToString("D6");
            linha += NormalizarTamanhoColuna(atributo, widthColCodigo);
            atributo = u.nome.ToString();
            linha += NormalizarTamanhoColuna(atributo, widthColNome);
            atributo = u.login.ToString();
            linha += NormalizarTamanhoColuna(atributo, widthColLogin);

            return linha;
        }
    }

    public class RelatorioFornecedor : Relatorio
    {
        Fornecedor[] cadastros { get; set; }

        // parametros do relatório
        // tabelas
        // TODO: COLOCAR OS WIDTHS DE CADA COLUNA AQUI

        public RelatorioFornecedor()
        {
            // definindo parametros do formulário
            // unidades em caracteres (e.g. 6 caracteres)
            alturaCabecalho = 5;
            // TODO: COLOCAR OS WIDTHS DE CADA COLUNA AQUI


            cadastros = Storage.fornecedores;
            cadastrosLength = GetNumeroCadastros(cadastros);
        }
        protected override string GerarHeaderTabela()
        {
            throw new NotImplementedException();
            string cabecalho = "";
            cabecalho += new string('-', PageWidth) + '\n';
            // TODO: IMPLEMENTAR CADA COLUNA AQUI COM TAMANHOS E NOMES CERTOS
            //cabecalho += NormalizarTamanhoColuna("Código", widthColCodigo);
            //cabecalho += NormalizarTamanhoColuna("Nome", widthColNome);
            //cabecalho += NormalizarTamanhoColuna("Login", widthColLogin) + '\n';
            cabecalho += new string('-', PageWidth) + '\n';
            return cabecalho;
        }

        protected override string GerarLinhaRelatorio(int pointer)
        {
            throw new NotImplementedException();
            string atributo;
            string linha = "";

            // TODO: IMPLEMENTAR CADA COLUNA AQUI COM TAMANHOS E NOMES CERTOS
            //Fornecedor f = cadastros[pointer];
            //atributo = ((int)f.codigo).ToString("D6");
            //linha += NormalizarTamanhoColuna(atributo, widthColCodigo);
            //atributo = f.nome.ToString();
            //linha += NormalizarTamanhoColuna(atributo, widthColNome);
            //atributo = f.login.ToString();
            //linha += NormalizarTamanhoColuna(atributo, widthColLogin);

            return linha;
        }
    }
    public class RelatorioCliente : Relatorio
    {
        Cliente[] cadastros { get; set; }

        // parametros do relatório
        // tabelas
        // TODO: COLOCAR OS WIDTHS DE CADA COLUNA AQUI

        public RelatorioCliente()
        {
            // definindo parametros do formulário
            // unidades em caracteres (e.g. 6 caracteres)
            alturaCabecalho = 5;
            // TODO: COLOCAR OS WIDTHS DE CADA COLUNA AQUI


            cadastros = Storage.clientes;
            cadastrosLength = GetNumeroCadastros(cadastros);
        }
        protected override string GerarHeaderTabela()
        {
            throw new NotImplementedException();
            string cabecalho = "";
            cabecalho += new string('-', PageWidth) + '\n';
            // TODO: IMPLEMENTAR CADA COLUNA AQUI COM TAMANHOS E NOMES CERTOS
            //cabecalho += NormalizarTamanhoColuna("Código", widthColCodigo);
            //cabecalho += NormalizarTamanhoColuna("Nome", widthColNome);
            //cabecalho += NormalizarTamanhoColuna("Login", widthColLogin) + '\n';
            cabecalho += new string('-', PageWidth) + '\n';
            return cabecalho;
        }

        protected override string GerarLinhaRelatorio(int pointer)
        {
            throw new NotImplementedException();
            string atributo;
            string linha = "";

            // TODO: IMPLEMENTAR CADA COLUNA AQUI COM TAMANHOS E NOMES CERTOS
            //Fornecedor f = cadastros[pointer];
            //atributo = ((int)f.codigo).ToString("D6");
            //linha += NormalizarTamanhoColuna(atributo, widthColCodigo);
            //atributo = f.nome.ToString();
            //linha += NormalizarTamanhoColuna(atributo, widthColNome);
            //atributo = f.login.ToString();
            //linha += NormalizarTamanhoColuna(atributo, widthColLogin);

            return linha;
        }
    }

    public class RelatorioPrinter
    {
        //parametros para impressao
        private readonly Font PrintFont = RelatorioConfig.PrintFont;
        private readonly Brush PrintColor = RelatorioConfig.PrintColor;
        private readonly PointF PrintMargin = RelatorioConfig.PrintMargin;

        // Método utilizado para testar o tamanho das folhas.
        // Mantido pois é possível que esse tamanho mude dependendo do computador
        public static string GetTestPrintString()
        {
            int PageWidth = RelatorioConfig.PageWidth;
            int PageHeight = RelatorioConfig.PageHeight;
            string s = "";
            string linha = new string('0', PageWidth);
            for (int _ = 0; _ < PageHeight; _++)
            {
                s += linha + '\n';
            }
            return s;
        }

        public void Print(string printString, Graphics g)
        {
            g.DrawString(printString, PrintFont, PrintColor, PrintMargin);
        }

        /*
        DETALHES DE IMPRESSÃO
        Margem de 50 pixels {PointF(50, 50)}
        Fonte Courier New 10pt Regular, pois é Monospace
        Cor preta
        */
    }
}
