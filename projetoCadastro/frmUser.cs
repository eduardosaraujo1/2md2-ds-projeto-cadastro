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
            logica.NavegarCadastros((int)LogicaCadastro.DirecaoNavegacao.Anterior);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            logica.NavegarCadastros((int)LogicaCadastro.DirecaoNavegacao.Proximo);
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

        // métodos especificos de form
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

        public bool ValidarCamposEntidade(IEntidade entidade)
        {
            Usuario usuario = entidade as Usuario;
            if (IsNullOrEmpty(usuario.login)) return false;
            if (IsNullOrEmpty(usuario.nome)) return false;
            if (IsNullOrEmpty(usuario.senha)) return false;
            return true;

            bool IsNullOrEmpty(string s) => String.IsNullOrEmpty(s.Trim());
        }
    }
}
