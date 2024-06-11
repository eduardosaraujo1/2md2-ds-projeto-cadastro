using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCadastro
{
    public partial class frmCliente : Form, IFormCadastro
    {
        // grande parte dos comentários de cada funcionalidade está em frmUser, veja a implementação lá para detalhes
        public IEntidade[] cadastros { get; set; } = Storage.clientes;

        private LogicaCadastro logica;

        public frmCliente()
        {
            InitializeComponent();
        }
        private void frmCliente_Load(object sender, EventArgs e)
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
            Cliente cliente = new Cliente
            {
                codigo = logica.pointerEntidade + 1,
                nome = inputNome.Text,
                endereco = inputEndereco.Text,
                bairro = inputBairro.Text,
                cidade = inputCidade.Text,
                estado = inputEstado.Text,
                cep = inputCEP.Text,
                telefone = inputTelefone.Text,
                email = inputEmail.Text,
                cpf = inputCPF.Text,
                rg = inputRG.Text
            };
            return cliente;
        }

        public void RenderizarDados()
        {
            int pointer = logica.pointerEntidade;
            Cliente cliente = cadastros[pointer] as Cliente;
            inputCodigo.Text = (pointer + 1).ToString();
            inputNome.Text = cliente.nome ?? "";
            inputEndereco.Text = cliente.endereco ?? "";
            inputBairro.Text = cliente.bairro ?? "";
            inputCidade.Text = cliente.cidade ?? "";
            inputEstado.Text = cliente.estado ?? "";
            inputCEP.Text = cliente.cep ?? "";
            inputTelefone.Text = cliente.telefone ?? "";
            inputEmail.Text = cliente.email ?? "";
            inputCPF.Text = cliente.cpf ?? "";
            inputRG.Text = cliente.rg ?? "";
        }

        // necessário inicializar para implementação da interface
        public Button btnProximoGet { get { return btnProximo; } }
        public TextBox inputCodigoGet { get { return inputCodigo; } }
        public Button btnAnteriorGet { get {return btnAnterior;}  }
        public Button btnSalvarGet {get {return btnSalvar;} }
        public Button btnCancelarGet {get {return btnCancelar;} }
        public Button btnNovoGet {get {return btnNovo;} }
        public Button btnPesquisarGet {get {return btnPesquisar;} }
        public Button btnAlterarGet {get {return btnAlterar;} }
        public Button btnImprimirGet {get {return btnImprimir;} }
        public Button btnExcluirGet {get {return btnExcluir;} }
        public Button btnSairGet {get {return btnSair;} }
        public Panel panelCamposGet { get {return panelCampos;} }
    }
}
