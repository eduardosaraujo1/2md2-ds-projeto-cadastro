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
        private GenericCadastro logica;

        public frmCliente()
        {
            InitializeComponent();
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            logica = new GenericCadastro(this);
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

        private void btnImprimir_Click(object sender, EventArgs e)
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

        // TODO: Ver se é possível relacionar as TextBoxes aos cadastros e assim não precisar colocar codigo na classe frm
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

        // TODO: Ver se não é possivel passar esse método para a interface IEntidade
        public bool ValidarCamposEntidade(IEntidade entidade)
        {
            Cliente cliente = entidade as Cliente;
            if (IsNullOrEmpty(cliente.codigo.ToString())) return false;
            if (IsNullOrEmpty(cliente.nome)) return false;
            return true;

            bool IsNullOrEmpty(string s) => string.IsNullOrEmpty(s.Trim());
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Verifique se é possível mover essa implementação para LogicaCadastro (requer melhorias mencionadas em README.md)
            // "implementar uma forma de localizar determinado elemento a partir de seu Name como uma string"
            string conteudoPrint = 
$@"FICHA DE FORNECEDOR

Código: {inputCodigo.Text}
Nome: {inputNome.Text}
Endereco: {inputEndereco.Text}
Bairro: {inputBairro.Text}
Cidade: {inputCidade.Text}
Estado: {inputEstado.Text}
CEP: {inputCEP.Text}
Telefone: {inputTelefone.Text}
E-mail: {inputEmail.Text}
CPF: {inputCPF.Text}
RG: {inputRG.Text}
";

            logica.GerarDocumentoPrint(conteudoPrint, e);
        }
    }
}
