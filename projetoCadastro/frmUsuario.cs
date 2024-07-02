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
    public partial class frmUsuario : Form, IFormCadastro
    {
        public IEntidade[] cadastros { get; set; } = Storage.usuarios;
        private GenericCadastro logica;

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            logica = new GenericCadastro(this);
            logica.Form_Load();
        }

        // unique logic
        public IEntidade FormGerarEntidade()
        {
            Usuario usuario = new Usuario
            {
                codigo = logica.indexCadAtual + 1,
                nome = inputNome.Text,
                login = inputLogin.Text,
                senha = inputSenha.Text
            };
            return usuario;
        }

        public void RenderizarDados()
        {
            int pointer = logica.indexCadAtual;
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
