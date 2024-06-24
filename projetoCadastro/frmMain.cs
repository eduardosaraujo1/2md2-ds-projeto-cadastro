using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCadastro
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void DefinirMsgSistema(string mensagem)
        {
            displayMessage.Text = mensagem;
        }

        private void UpdateDateTime(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            displayHora.Text = now.ToString("HH:mm:ss");
            displayData.Text = now.ToString("yyy-MM-dd");
        }

        private void MostrarTelaCadastroGeneric<T>(string inicioMensagem, string finalMensagem) where T : Form, new()
        {
            DefinirMsgSistema(inicioMensagem);
            T frm = new T();
            frm.ShowDialog();
            DefinirMsgSistema(finalMensagem);
        }

        private void PrintPageGeneric<T>(IEntidade[] cadastros, Graphics g) where T : Relatorio, new()
        {
            //string printString = RelatorioPrinter.GetTestPrintString();
            T r = new T();
            string printString = r.ObterRelatorioString();
            RelatorioPrinter rp = new RelatorioPrinter(printString);
            rp.Print(g);
        }

        private void UsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msgAberto = "Iniciado cadastro de usuários";
            string msgFechado = "Finalizado cadastro de usuários";
            MostrarTelaCadastroGeneric<frmUser>(msgAberto, msgFechado);
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msgAberto = "Iniciado cadastro de clientes";
            string msgFechado = "Finalizado cadastro de clientes";
            MostrarTelaCadastroGeneric<frmCliente>(msgAberto, msgFechado);
        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msgAberto = "Iniciado cadastro de fornecedores";
            string msgFechado = "Finalizado cadastro de fornecedores";
            MostrarTelaCadastroGeneric<frmFornecedor>(msgAberto, msgFechado);
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ppDialogUsuario.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ppDialogCliente.ShowDialog();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ppDialogFornecedor.ShowDialog();
        }

        private void pdocUsuario_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintPageGeneric<RelatorioUsuario>(Storage.usuarios, e.Graphics);
        }

        private void pdocFornecedor_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintPageGeneric<RelatorioUsuario>(Storage.fornecedores, e.Graphics); // TODO: Criar classe RelatorioFornecedor
        }

        private void ppdocCliente_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintPageGeneric<RelatorioUsuario>(Storage.clientes, e.Graphics); // TODO: Criar classe RelatorioCliente
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateDateTime(sender, e);
            //GerarCemUsuariosAleatorios();
        }

        private void GerarCemUsuariosAleatorios()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Storage.usuarios[i] = new Usuario
                {
                    codigo = i + 1,
                    nome = GerarStringAleatoria(),
                    login = GerarStringAleatoria()
                };
            }
            string GerarStringAleatoria()
            {
                const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                int tamanho = random.Next(4, 24);
                StringBuilder resultado = new StringBuilder(tamanho);

                for (int i = 0; i < tamanho; i++)
                {
                    int indice = random.Next(caracteresPermitidos.Length);
                    resultado.Append(caracteresPermitidos[indice]);
                }

                return resultado.ToString();
            }
        }
    }
}
