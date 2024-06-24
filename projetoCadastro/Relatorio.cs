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
        private protected int PageWidth = RelatorioConfig.PageWidth;
        private protected int PageHeight = RelatorioConfig.PageHeight;

        private protected int pageCount = 1;
        private protected int linhaAtual = 1;
        private protected int pointerCadastro = 0;
        private protected int cadastrosLength { get; set; }
        private protected int alturaCabecario { get; set; }

        private protected int GetNumeroCadastros<T>(T[] array)
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
        private protected string NormalizarTamanhoColuna(string coluna, int tamanho)
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

        public string ObterRelatorioString()
        {
            string relatorio = "";
            //enquanto não chegar no ultimo cadastro para impressão, gerar novas páginas
            while (pointerCadastro < cadastrosLength)
            {
                relatorio += GerarPaginaRelatorio();
            }
            return relatorio;
        }

        private protected string GerarPaginaRelatorio()
        {
            string pagina = "";
            pagina += GerarCabecalho();
            while (linhaAtual <= PageHeight)
            {
                pagina += GerarLinhaRelatorio(pointerCadastro);
                pointerCadastro++;

                if (pointerCadastro >= cadastrosLength)
                {
                    break;
                }

                pagina += '\n';
                linhaAtual++;
            }
            pagina += '\f';
            linhaAtual = 1;
            pageCount++;
            return pagina;
        }

        private protected string GerarCabecalho()
        {
            string cabecalho = "ETEC ADOLPHO BEREZIN\n";
            //título
            cabecalho += "Relatório de Usuários".PadRight(PageWidth - "PAG: 00".Length); // Pad colocado para o conteúdo das páginas ser alinhado à direita
            cabecalho += "Pág: " + pageCount.ToString("00") + '\n';
            //table header
            cabecalho += GerarHeaderTabela();
            linhaAtual = 6; // após o cabeçalho, definimos em que linha do documento estamos

            return cabecalho.ToString();
        }
        protected abstract string GerarLinhaRelatorio(int pointer);
        protected abstract string GerarHeaderTabela();
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
            alturaCabecario = 5;
            widthColCodigo = 6;
            widthColNome = 50;
            widthColLogin = PageWidth - (widthColCodigo + widthColNome + 3); // esse 3 leva em consideração o separador entre as colunas, que é 1 espaço extra (incluido no método AdicionarCampoTabelaHeader)

            //
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

    public class RelatorioPrinter
    {
        //parametros para impressao
        private readonly Font PrintFont = RelatorioConfig.PrintFont;
        private readonly Brush PrintColor = RelatorioConfig.PrintColor;
        private readonly PointF PrintMargin = RelatorioConfig.PrintMargin;

        private readonly string printString;

        public RelatorioPrinter(string printString)
        {
            this.printString = printString;
        }

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

        public void Print(Graphics g)
        {
            g.DrawString(printString, PrintFont, PrintColor, PrintMargin);
        }

        /*
        DETALHES DE IMPRESSÃO
        Margem de 50 pixels {PointF(50, 50)}
        Fonte Courier New 10pt Regular, pois é Monospace
        */
    }
}
