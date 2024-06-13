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
    public partial class frmFornecedor : Form, IFormCadastro
    {
        public IEntidade[] cadastros { get; set; } = Storage.fornecedores;
        private LogicaCadastro logica;

        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            logica = new LogicaCadastro(this);
            logica.OnFormLoad();
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
            Fornecedor fornecedor = new Fornecedor
            {
                codigo = logica.pointerEntidade + 1,
                nomeFantasia = inputNomeFantasia.Text,
                razaoSocial = inputRazaoSocial.Text,
                contato = inputContato.Text,
                email = inputEmail.Text,
                cnpj = inputCNPJ.Text,
                inscrEstadual = inputInscrEstadual.Text,
                endereco = inputEndereco.Text,
                cidade = inputCidade.Text,
                bairro = inputBairro.Text,
                estado = inputEstado.Text,
                cep = inputCEP.Text,
                telefone = inputTelefone.Text,
            };
            return fornecedor;
        }

        public void RenderizarDados()
        {
            int pointer = logica.pointerEntidade;
            Fornecedor fornecedor = cadastros[pointer] as Fornecedor;
            inputCodigo.Text = (pointer + 1).ToString();
            inputNomeFantasia.Text = fornecedor.nomeFantasia ?? "";
            inputRazaoSocial.Text = fornecedor.razaoSocial ?? "";
            inputContato.Text = fornecedor.contato ?? "";
            inputEmail.Text = fornecedor.email ?? "";
            inputCNPJ.Text = fornecedor.cnpj ?? "";
            inputInscrEstadual.Text = fornecedor.inscrEstadual ?? "";
            inputEndereco.Text = fornecedor.endereco ?? "";
            inputCidade.Text = fornecedor.cidade ?? "";
            inputBairro.Text = fornecedor.bairro ?? "";
            inputEstado.Text = fornecedor.estado ?? "";
            inputCEP.Text = fornecedor.cep ?? "";
            inputTelefone.Text = fornecedor.telefone ?? "";
        }

        public bool ValidarCamposEntidade(IEntidade entidade)
        {
            Fornecedor fornecedor = entidade as Fornecedor;
            if (IsNullOrEmpty(fornecedor.codigo.ToString())) return false;
            if (IsNullOrEmpty(fornecedor.nomeFantasia)) return false;
            return true;

            bool IsNullOrEmpty(string s) => string.IsNullOrEmpty(s.Trim());
        }

        public bool VerificarNomeMatchEntidade(string searchQuery, IEntidade entidade)
        {
            Fornecedor usuario = entidade as Fornecedor;
            string nmUsuario = usuario.nomeFantasia.ToLower();
            return nmUsuario.Contains(searchQuery);
        }
    }
}
