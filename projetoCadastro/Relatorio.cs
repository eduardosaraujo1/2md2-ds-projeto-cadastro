using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;

namespace projetoCadastro
{
    public class Relatorio
    {
        //parametros para impressao
        private Font PrintFont = new Font("Courier New", 10);
        private Brush PrintColor = Brushes.Black;
        private PointF PrintMargin = new PointF(50, 50);
        private const int PageWidth = 84; // unidade em tamanho do caractere '0'
        private const int PageHeight = 68; // unidade em tamanho do caractere '0'

        private IEntidade[] cadastros { get; set; }
        private readonly StringBuilder sbImpressao = new StringBuilder();

        public Relatorio(IEntidade[] cadastros)
        {
            this.cadastros = cadastros;
        }

        // Método utilizado para testar o tamanho das folhas.
        // Mantido pois é possível que esse tamanho mude dependendo do computador
        public static string GetTestPrintString()
        {
            StringBuilder sb = new StringBuilder();
            string linha = new string('0', PageWidth);
            for (int _ = 0; _ < PageHeight; _++)
            {
                sb.Append(linha + '\n');
            }
            return sb.ToString();
        }

        public void DesenharString(string s, Graphics g)
        {
            g.DrawString(s, PrintFont, PrintColor, PrintMargin);
        }

        /*
        RELATÓRIO
        GerarRelatório (return string)
        StringBuilder documentoString = new StringBuilder()
        Valores para acompanhar:
        - Pointer entidade sendo adicionada no StringBuilder
        - Posicao do "cursor", onde coisas estão sendo escritas
        - Numeração da página
        DETALHES DE IMPRESSÃO
        Margem de 50 pixels {PointF(50, 50)}
        Fonte Courier New 10pt Regular, pois é Monospace
        */
    }
}
