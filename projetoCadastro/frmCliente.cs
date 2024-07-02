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
        public IEntidade[] cadastros { get; set; } = Storage.clientes;
        private GenericCadastro logica;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            logica = new GenericCadastro(this);
            logica.Form_Load();
        }

        // unique logic
        public IEntidade FormGerarEntidade()
        {
            Cliente cliente = new Cliente
            {
                codigo = logica.indexCadAtual + 1,
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
            int pointer = logica.indexCadAtual;
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
            string conteudoPrint = 
$@"FICHA DE CLIENTE

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
