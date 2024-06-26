using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace projetoCadastro
{
    public static class ApplicationConfig
    {
        // Impressão e Relatório
        public static Font PrintFont = new Font("Courier New", 10);
        public static Brush PrintColor = Brushes.Black;
        public static PointF PrintMargin = new PointF(50, 50);
        public static int PageWidth = 84; // unidade em largura do caractere
        public static int PageHeight = 68; // unidade em largura do caractere 
        public static bool SinglePage = false;

        // Geração de dados
        public static bool GERAR_USUARIOS_AUTOMATICAMENTE = false;
        public static int QUANTIDADE_USUARIOS_GERADOS_AUTOMATICAMENTE = 100;
    }
}
