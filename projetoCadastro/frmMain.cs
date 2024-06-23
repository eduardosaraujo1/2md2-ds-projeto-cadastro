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

        private void PrintPageGeneric(IEntidade[] cadastros, Graphics g)
        {
            Relatorio r = new Relatorio(cadastros);
            string relatorioString = Relatorio.GetTestPrintString();
            r.DesenharString(relatorioString, g);
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
            PrintPageGeneric(Storage.usuarios, e.Graphics);
        }

        private void pdocFornecedor_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintPageGeneric(Storage.fornecedores, e.Graphics);
        }

        private void ppdocCliente_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintPageGeneric(Storage.clientes, e.Graphics);
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void pdocUsuario_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    string strDados = "";
        //    Graphics objImpressao = e.Graphics;
        //    int pag = 1, pos = 0, linha;
        //    bool cabecalho = true, itens;

        //    while (cabecalho)
        //    {
        //        strDados = "ETEC ADOLPHO BEREZIN" + (char)10;
        //        strDados += ("Relatório de Usuários").PadRight(73) + "Pág: " + pag.ToString("00") + (char)10;
        //        strDados += "--------------------------------------------------------------------------------" + (char)10;
        //        strDados += "Código Nome                                               Login" + (char)10;
        //        strDados += "--------------------------------------------------------------------------------" + (char)10;
        //        linha = 5;
        //        pag++;
        //        itens = true;
        //        while (itens)
        //        {
        //            strDados += new string('0', 80) + (char)10;
        //            pos++;
        //            linha++;
        //            if (linha >= 63)
        //            {
        //                itens = false;
        //                cabecalho = false;
        //            }
        //        }
        //        strDados += (char)12;
        //    }
        //    objImpressao.DrawString(strDados, new Font("Courier New", 10, FontStyle.Regular), Brushes.Black, 50, 50);
        //}
    }
}
