using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCadastro
{
    public partial class frmUser : Form, IFormCadastro
    {
        public IEntidade[] cadastros { get; set; } = Storage.usuarios;
        private LogicaCadastro logica;

        public frmUser()
        {
            InitializeComponent();
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            logica = new LogicaCadastro(this);
            logica.OnFormLoad();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            logica.NavegarCadastros(-1);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            logica.NavegarCadastros(1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            logica.CancelarCadastroAlteracao();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            logica.AlteracaoCadastro();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            logica.NovoCadastro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            logica.ExcluirCadastro();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            logica.SalvarCadastro();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            logica.PesquisarUsuarioClick();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            // No futuro, mover essa implementação para LogicaCadastro
            if (string.IsNullOrEmpty(inputCodigo.Text) || string.IsNullOrEmpty(inputNome.Text))
            {
                MessageBox.Show(
                    "Erro: nenhum cadastro está selecionado",
                    "Cadastro nulo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            printPreviewDialog.ShowDialog();
        }

        // getters
        public LogicaCadastro.BotoesForm GetBotoesForm()
        {
            return new LogicaCadastro.BotoesForm
            {
                btnAnterior = btnAnterior,
                btnProximo = btnProximo,
                btnSalvar = btnSalvar,
                btnCancelar = btnCancelar,
                btnNovo = btnNovo,
                btnPesquisar = btnPesquisar,
                btnAlterar = btnAlterar,
                btnImprimir = btnImprimir,
                btnExcluir = btnExcluir,
                btnSair = btnSair
            };
        }

        public Panel GetPanelCampos()
        {
            return panelCampos;
        }

        public TextBox GetInputCodigo()
        {
            return inputCodigo;
        }

        // unique logic
        public IEntidade FormGerarEntidade()
        {
            Usuario usuario = new Usuario
            {
                codigo = logica.pointerEntidade + 1,
                nome = inputNome.Text,
                login = inputLogin.Text,
                senha = inputSenha.Text
            };
            return usuario;
        }

        public void RenderizarDados()
        {
            int pointer = logica.pointerEntidade;
            Usuario usuario = cadastros[pointer] as Usuario;
            inputCodigo.Text = (pointer + 1).ToString();
            inputNome.Text = usuario.nome ?? "";
            inputLogin.Text = usuario.login ?? "";
            inputSenha.Text = usuario.senha ?? "";
        }

        // TODO: Ver se não é possivel passar esse método para a interface IEntidade
        public bool ValidarCamposEntidade(IEntidade entidade)
        {
            Usuario usuario = entidade as Usuario;
            if (IsNullOrEmpty(usuario.codigo.ToString())) return false;
            if (IsNullOrEmpty(usuario.nome)) return false;
            return true;

            bool IsNullOrEmpty(string s) => string.IsNullOrEmpty(s.Trim());
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Verifique se é possível mover essa implementação para LogicaCadastro (requer melhorias mencionadas em README.md)
            // "implementar uma forma de localizar determinado elemento a partir de seu Name como uma string"
            string conteudoPrint = 
$@"FICHA DE USUÁRIO

Código: {inputCodigo.Text}
Nome: {inputNome.Text}
Login: {inputLogin.Text}
";

            logica.GerarDocumentoPrint(conteudoPrint, e);
        }
    }
}
