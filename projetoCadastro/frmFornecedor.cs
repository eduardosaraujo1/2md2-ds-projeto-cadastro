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
        public string TIPO_FORM { get; set; } = "Fornecedor";
        public IEntidade[] cadastros { get; set; } = Storage.fornecedores;
        private GenericCadastro logica;

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
            logica = new GenericCadastro(this);
            logica.Form_Load();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            logica.NavBtn_Click(-1);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            logica.NavBtn_Click(1);
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
            logica.Pesquisar_Click();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            // No futuro, mover essa implementação para LogicaCadastro
            if (string.IsNullOrEmpty(inputCodigo.Text) || string.IsNullOrEmpty(inputNomeFantasia.Text))
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
        public GenericCadastro.BotoesForm GetBotoesForm()
        {
            return new GenericCadastro.BotoesForm
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
                nome = inputNomeFantasia.Text,
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
            inputNomeFantasia.Text = fornecedor.nome ?? "";
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

        // TODO: Ver se não é possivel passar esse método para a interface IEntidade
        public bool ValidarCamposEntidade(IEntidade entidade)
        {
            Fornecedor fornecedor = entidade as Fornecedor;
            if (IsNullOrEmpty(fornecedor.codigo.ToString())) return false;
            if (IsNullOrEmpty(fornecedor.nome)) return false;
            return true;

            bool IsNullOrEmpty(string s) => string.IsNullOrEmpty(s.Trim());
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Verifique se é possível mover essa implementação para LogicaCadastro (requer melhorias mencionadas em README.md)
            // "implementar uma forma de localizar determinado elemento a partir de seu Name como uma string"
            string conteudoPrint = 
$@"FICHA DE FORNECEDOR

Código: {inputCodigo.Text}
Nome Fantasia: {inputNomeFantasia.Text}
Razao Social: {inputRazaoSocial.Text}
Contato: {inputContato.Text}
E-mail: {inputEmail.Text}
CNPJ: {inputCNPJ.Text}
Inscrição Estadual: {inputInscrEstadual.Text}
Endereço: {inputEndereco.Text}
Cidade: {inputCidade.Text}
Bairro: {inputBairro.Text}
Estado: {inputEstado.Text}
CEP: {inputCEP.Text}
Telefone: {inputTelefone.Text}
";

            logica.GerarDocumentoPrint(conteudoPrint, e);
        }
    }
}
