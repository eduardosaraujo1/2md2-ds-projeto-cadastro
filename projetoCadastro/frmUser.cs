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
        public IEntidade PassarDadosParaIEntidade()
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

        public void BloquearDigitacao() {
            logica.DefinirModoTextBoxes(false);
            inputCodigo.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnAlterar.Enabled = true;
            btnImprimir.Enabled = true;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;
        }
        public void PermitirDigitacao() {
            logica.DefinirModoTextBoxes(true);
            inputCodigo.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnAlterar.Enabled = false;
            btnImprimir.Enabled = false;
            btnExcluir.Enabled = false;
            btnSair.Enabled = false;
        }

        public Panel getPanelCampos { get { return panelCampos; } } // obter acesso ao panel de inputs a partir da classe LogicaCadastro
    }
}
