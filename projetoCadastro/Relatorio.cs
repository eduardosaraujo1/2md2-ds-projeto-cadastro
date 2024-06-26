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
    public abstract class Relatorio
    {
        // Parametros
        protected bool SinglePage = RelatorioConfig.SinglePage;
        protected int PageWidth = RelatorioConfig.PageWidth;
        protected int PageHeight = RelatorioConfig.PageHeight;
        protected int LengthCadastros { get; set; }
        protected int AlturaCabecalho { get; set; }
        protected int AlturaRegistro { get; set; } // quantidade de linhas que cada "item" no relatório ocupa

        // Valores para a geração do relatório
        protected int PaginaAtual = 1;
        protected int LinhaAtual = 1;
        protected int PointerCadastroAtual = 0;

        protected abstract string GerarLinhaRelatorio(int pointer);
        protected abstract string GerarHeaderTabela();

        protected void BootstrapRelatorio<T>(T[] cadastros) where T : IEntidade
        {
            if (cadastros == null) throw new NullReferenceException();
            if (AlturaRegistro == 0) throw new NullReferenceException();
            LengthCadastros = GetNumeroCadastros(cadastros);
            AlturaCabecalho = AlturaRegistro + 4;
        }

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
        protected string NormalizarTamanhoColuna(string colunaContent, int tamanho)
        {
            if (colunaContent.Length > tamanho)
            {
                return colunaContent.Substring(0, tamanho - 3) + "..." + ' ';// espaço é separador de coluna
            }
            else
            {
                return colunaContent.PadRight(tamanho) + ' '; // espaço é separador de coluna
            }
        }
        protected string GerarCabecalho()
        {
            string tipo = "Cadastros";
            if (this is RelatorioCliente) tipo = "Clientes";
            else if (this is RelatorioUsuario) tipo = "Usuários";
            else if (this is RelatorioFornecedor) tipo = "Fornecedores";

            string cabecalho = "ETEC ADOLPHO BEREZIN\n";

            string paginaDisplay = "Pág: " + PaginaAtual.ToString("D2") + '\n';
            string tituloDisplay = $"Relatório de {tipo}".PadRight(PageWidth - paginaDisplay.Length); // PadRight faz paginaDisplay se alinhar à direita

            cabecalho += tituloDisplay;
            cabecalho += paginaDisplay;
            //table header
            cabecalho += GerarHeaderTabela();
            LinhaAtual = AlturaCabecalho + 1; // + 1 pois não estamos na ultima linha do cabecalho, mas sim uma linha abaixo

            return cabecalho;
        }
        protected string GerarPaginaRelatorio()
        {
            string pagina = GerarCabecalho();
            while (!AlcancouUltimaLinha())
            {
                pagina += GerarLinhaRelatorio(PointerCadastroAtual);
                PointerCadastroAtual++;
                LinhaAtual += AlturaRegistro;

                if (AlcancouUltimoCadastro())
                {
                    break;
                }
            }

            return pagina;
        }
        protected char IrParaProximaPagina()
        {
            LinhaAtual = 1;
            PaginaAtual++;
            return (char)12;
        }
        public string GerarRelatorio()
        {
            string relatorio = "";
            while (!AlcancouUltimoCadastro())
            {
                relatorio += GerarPaginaRelatorio();
                relatorio += IrParaProximaPagina();
                if (SinglePage) break; // Não gerar mais páginas depois de uma, aqui pois o (char)12 não funcionava
            }
            return relatorio;
        }

        bool AlcancouUltimoCadastro() => PointerCadastroAtual >= LengthCadastros;
        bool AlcancouUltimaLinha()
        {
            // lógica: se desenharmos um novo registro, esse desenho vai passar da borda do documento? Se sim, já alcançamos a ultima linha
            int linhaDesenhadaAposRegistro = LinhaAtual + AlturaRegistro - 1;
            return linhaDesenhadaAposRegistro > PageHeight;
        }
    }

    public class RelatorioUsuario : Relatorio
    {
        private Usuario[] cadastros { get; set; }

        // parametros do relatório
        // tabelas
        private int widthColCodigo { get; set; }
        private int widthColNome { get; set; }
        private int widthColLogin { get; set; }

        public RelatorioUsuario()
        {
            // definindo parametros do formulário
            // unidades em caracteres (e.g. 6 caracteres)
            cadastros = Storage.usuarios;
            AlturaRegistro = 1;

            widthColCodigo = 6;
            widthColNome = 50;
            widthColLogin = PageWidth - (widthColCodigo + widthColNome + 3); // esse 3 leva em consideração o separador entre as colunas, que é 1 espaço extra (incluido no método NormalizarTamanhoColuna)

            BootstrapRelatorio(Storage.usuarios);
        }
        protected override string GerarHeaderTabela()
        {
            string cabecalho = "";
            cabecalho += new string('-', PageWidth) + '\n';
            cabecalho += NormalizarTamanhoColuna("Código", widthColCodigo);
            cabecalho += NormalizarTamanhoColuna("Nome", widthColNome);
            cabecalho += NormalizarTamanhoColuna("Login", widthColLogin);
            cabecalho += '\n';
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
            linha += '\n';

            return linha;
        }
    }
    public class RelatorioCliente : Relatorio
    {
        Cliente[] cadastros { get; set; }

        // parametros do relatório
        // tabelas
        private int widthCodigo { get; set; }
        private int widthNome { get; set; }
        private int widthCidade { get; set; }
        private int widthEstado { get; set; }
        private int widthCEP { get; set; }
        private int widthTelefone { get; set; }
        private int widthEmail { get; set; }
        private int widthCpf { get; set; }
        private int widthRg { get; set; }

        public RelatorioCliente()
        {
            // definindo parametros do formulário
            // unidades em caracteres (e.g. 6 caracteres)
            AlturaRegistro = 3;

            widthCodigo = 6;
            widthNome = 50;
            widthCidade = 10;
            widthEstado = PageWidth - (widthCodigo + widthNome + widthCidade + 4);
            // newline
            widthCEP = 12;
            widthCpf = 16;
            widthTelefone = PageWidth - (widthCEP + widthCpf + 3);
            // newline
            widthRg = 14;
            widthEmail = PageWidth - (2 + widthRg);

            cadastros = Storage.clientes;
            BootstrapRelatorio(cadastros);
        }
        protected override string GerarHeaderTabela()
        {
            string cabecalho = "";
            cabecalho += new string('-', PageWidth) + '\n';
            // TODO: IMPLEMENTAR CADA COLUNA AQUI COM TAMANHOS E NOMES CERTOS
            cabecalho += NormalizarTamanhoColuna("Código", widthCodigo);
            cabecalho += NormalizarTamanhoColuna("Nome", widthNome);
            cabecalho += NormalizarTamanhoColuna("Cidade", widthCidade);
            cabecalho += NormalizarTamanhoColuna("Estado", widthEstado);
            cabecalho += '\n';
            cabecalho += NormalizarTamanhoColuna("CEP", widthCEP);
            cabecalho += NormalizarTamanhoColuna("Telefone", widthTelefone);
            cabecalho += NormalizarTamanhoColuna("Cpf", widthCpf);
            cabecalho += '\n';
            cabecalho += NormalizarTamanhoColuna("Rg", widthRg);
            cabecalho += NormalizarTamanhoColuna("Email", widthEmail);
            cabecalho += '\n';
            cabecalho += new string('-', PageWidth) + '\n';
            return cabecalho;
        }

        protected override string GerarLinhaRelatorio(int pointer)
        {
            string atributo;
            string linha = "";

            // TODO: IMPLEMENTAR CADA COLUNA AQUI COM TAMANHOS E NOMES CERTOS
            Cliente c = cadastros[pointer];
            atributo = ((int)c.codigo).ToString("D6");
            linha += NormalizarTamanhoColuna(atributo, widthCodigo);
            atributo = c.nome;
            linha += NormalizarTamanhoColuna(atributo, widthNome);
            atributo = c.cidade;
            linha += NormalizarTamanhoColuna(atributo, widthCidade);
            atributo = c.estado;
            linha += NormalizarTamanhoColuna(atributo, widthEstado);
            linha += '\n';
            atributo = c.cep;
            linha += NormalizarTamanhoColuna(atributo, widthCEP);
            atributo = c.telefone;
            linha += NormalizarTamanhoColuna(atributo, widthTelefone);
            atributo = c.cpf;
            linha += NormalizarTamanhoColuna(atributo, widthCpf);
            linha += '\n';
            atributo = c.rg;
            linha += NormalizarTamanhoColuna(atributo, widthRg);
            atributo = c.email;
            linha += NormalizarTamanhoColuna(atributo, widthEmail);
            linha += '\n';

            return linha;
        }
    }
    public class RelatorioFornecedor : Relatorio
    {
        Fornecedor[] cadastros { get; set; }

        // parametros do relatório
        // tabelas
        // TODO: COLOCAR OS WIDTHS DE CADA COLUNA AQUI
        private int widthCodigo { get; set; }
        private int widthNmFantasia { get; set; }
        private int widthCidade { get; set; }
        private int widthEstado { get; set; }
        private int widthCEP { get; set; }
        private int widthCnpj { get; set; }
        private int widthInscrEstadual { get; set; }
        private int widthTelefone { get; set; }
        private int widthContato { get; set; }
        private int widthEmail { get; set; }

        public RelatorioFornecedor()
        {
            // definindo parametros do formulário
            // unidades em caracteres (e.g. 6 caracteres)
            AlturaRegistro = 3;

            widthCodigo = 6;
            widthNmFantasia = 50;
            widthCidade = 10;
            widthEstado = PageWidth - (widthCodigo + widthNmFantasia + widthCidade + 4);
            // new line
            widthCEP = 12;
            widthCnpj = 22;
            widthInscrEstadual = PageWidth - (widthCEP + widthCnpj + 3);
            // new line
            widthTelefone = 20;
            widthContato = 20;
            widthEmail = PageWidth - (3 + widthTelefone + widthContato);

            cadastros = Storage.fornecedores;
            BootstrapRelatorio(cadastros);
        }
        protected override string GerarHeaderTabela()
        {
            string cabecalho = "";
            cabecalho += new string('-', PageWidth) + '\n';
            // TODO: IMPLEMENTAR CADA COLUNA AQUI COM TAMANHOS E NOMES CERTOS
            cabecalho += NormalizarTamanhoColuna("Código", widthCodigo);
            cabecalho += NormalizarTamanhoColuna("Nm. Fantasia", widthNmFantasia);
            cabecalho += NormalizarTamanhoColuna("Cidade", widthCidade);
            cabecalho += NormalizarTamanhoColuna("Estado", widthEstado);
            cabecalho += '\n';
            cabecalho += NormalizarTamanhoColuna("CEP", widthCEP);
            cabecalho += NormalizarTamanhoColuna("CEP", widthCEP);
            cabecalho += NormalizarTamanhoColuna("Cnpj", widthCnpj);
            cabecalho += NormalizarTamanhoColuna("InscrEstadual", widthInscrEstadual);
            cabecalho += '\n';
            cabecalho += NormalizarTamanhoColuna("Telefone", widthTelefone);
            cabecalho += NormalizarTamanhoColuna("Contato", widthContato);
            cabecalho += NormalizarTamanhoColuna("Email", widthEmail);
            cabecalho += '\n';
            cabecalho += new string('-', PageWidth) + '\n';
            return cabecalho;
        }

        protected override string GerarLinhaRelatorio(int pointer)
        {
            string atributo;
            string linha = "";

            Fornecedor f = cadastros[pointer];
            atributo = ((int)f.codigo).ToString("D6");
            linha += NormalizarTamanhoColuna(atributo, widthCodigo);
            linha += NormalizarTamanhoColuna(f.nome, widthNmFantasia);
            linha += NormalizarTamanhoColuna(f.cidade, widthCidade);
            linha += NormalizarTamanhoColuna(f.estado, widthEstado);
            linha += '\n';
            linha += NormalizarTamanhoColuna(f.cep, widthCEP);
            linha += NormalizarTamanhoColuna(f.cnpj, widthCnpj);
            linha += NormalizarTamanhoColuna(f.inscrEstadual, widthInscrEstadual);
            linha += '\n';
            linha += NormalizarTamanhoColuna(f.telefone, widthTelefone);
            linha += NormalizarTamanhoColuna(f.contato, widthContato);
            linha += NormalizarTamanhoColuna(f.email, widthEmail);
            linha += '\n';

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
