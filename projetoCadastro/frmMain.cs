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

        private void SetarMensagemSistema(string mensagem)
        {
            displayMessage.Text = mensagem;
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitNewCadastroForm<T>(string inicioMensagem, string finalMensagem) where T : Form, new()
        {
            SetarMensagemSistema(inicioMensagem);
            T frm = new T();
            frm.ShowDialog();
            UpdateTabelaForms();
            SetarMensagemSistema(finalMensagem);
        }

        private void UsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitNewCadastroForm<frmUser>("Iniciado cadastro de usuários", "Finalizado cadastro de usuários");
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitNewCadastroForm<frmCliente>("Iniciado cadastro de clientes", "Finalizado cadastro de clientes");
        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitNewCadastroForm<frmFornecedor>("Iniciado cadastro de fornecedores", "Finalizado cadastro de fornecedores");
        }

        private void TimerSegundo_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            var now = DateTime.Now;
            displayHora.Text = now.ToString("HH:mm:ss");
            displayData.Text = now.ToString("yyy-MM-dd");
        }

        private int ContarEntidadesArray(IEntidade[] array)
        {
            int count = 0;
            foreach (IEntidade entidade in array)
            {
                if (entidade != null)
                {
                    count++;
                }
            }
            return count;
        }

        private IEntidade ObterEntidadeRecemCadastrada(IEntidade[] array)
        {
            // if isNullOrEmpty
            if (array == null || array.Length == 0)
            {
                return null;
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] != null)
                {
                    return array[i];
                }
            }
            return null;
        }

        private void UpdateTabelaForms()
        {
            // Quantidade
            qtClientes.Text = ContarEntidadesArray(Storage.clientes).ToString();
            qtFornecedores.Text = ContarEntidadesArray(Storage.fornecedores).ToString();
            qtUsuarios.Text = ContarEntidadesArray(Storage.usuarios).ToString();

            // Mais recente
            Cliente recenteCliente = ObterEntidadeRecemCadastrada(Storage.clientes) as Cliente;
            clienteRecente.Text = recenteCliente?.nome ?? "N/A";
            Fornecedor recenteFornecedor = ObterEntidadeRecemCadastrada(Storage.fornecedores) as Fornecedor;
            fornecedorRecente.Text = recenteFornecedor?.nome ?? "N/A";
            Usuario recenteUsuario = ObterEntidadeRecemCadastrada(Storage.usuarios) as Usuario;
            userRecente.Text = recenteUsuario?.nome ?? "N/A";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateDateTime();
            UpdateTabelaForms();
        }
    }
}
