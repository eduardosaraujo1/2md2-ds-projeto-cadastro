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
using ModoForm = projetoCadastro.frmUser.ModoForm;

namespace projetoCadastro
{
    public partial class frmCliente : Form
    {
        // grande parte dos comentários de cada funcionalidade está em frmUser, veja a implementação lá para detalhes
        private Storage.Cliente[] clientes = Storage.clientes;
        private int pointerCliente = -1;
        private int pointerPosicaoVaziaArray = -1;
        public ModoForm modoForm;
        public frmCliente()
        {
            InitializeComponent();
        }
        private void EncontrarPosicaoVaziaArray()
        {
            pointerPosicaoVaziaArray = -1;
            int clientesLength = clientes.Length;
            for (int pos = 0; pos < clientesLength; pos++)
            {
                if (clientes[pos].codigo is null)
                {
                    pointerPosicaoVaziaArray = pos;
                    return;
                }
            }
            pointerPosicaoVaziaArray = clientesLength;
        }

        private bool PointerDentroArray(int pointer)
        {
            // método determina se o valor do pointer é um index valido para o array
            return pointer >= 0 && pointer < clientes.Length;
        }

        private bool PointerApontaClienteCadastrado(int pointer) {
            // método determina se o cliente apontado pelo pointer está cadastrado
            return PointerDentroArray(pointer) && !(clientes[pointer].codigo is null);
        }
        
        private void LimparForm()
        {
            // Limpa todas as textboxes do form
            foreach(Control control in tableLayoutPanelFields.Controls) {
                if (control is TextBox)
                {
                    TextBox tb = control as TextBox;
                    tb.Text = "";
                }
            }
        }

        private void DefinirModoTextBoxes(bool enabled)
        {
            foreach(Control control in tableLayoutPanelFields.Controls) {
                if (control is TextBox)
                {
                    TextBox tb = control as TextBox;
                    tb.Enabled = enabled;
                }
            }
        }

        private void DefinirModoForm(ModoForm modo)
        {
            this.modoForm = modo;
            switch (modo)
            {
                case ModoForm.Visualizacao:
                    // modo visualização
                    DefinirModoTextBoxes(enabled: false);
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
                    break;
                case ModoForm.Alteracao:
                case ModoForm.Cadastro:
                    // modo alteração (ou cadastro)
                    DefinirModoTextBoxes(enabled: true);
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
                    break;
                case ModoForm.Pesquisa:
                    // modo pesquisa (wip)
                    break;
            }
        }
        private void ExibirDados()
        {
            if (PointerApontaClienteCadastrado(pointerCliente))
            {
                Storage.Cliente cliente = clientes[pointerCliente];
                inputCodigo.Text = (pointerCliente + 1).ToString();
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
            } else
            {
                LimparForm();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            EncontrarPosicaoVaziaArray();
            pointerCliente = pointerPosicaoVaziaArray - 1;
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int novoPointer = pointerCliente - 1;
            if (PointerApontaClienteCadastrado(novoPointer))
            {
                pointerCliente = novoPointer;
            }
            ExibirDados();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            int novoPointer = pointerCliente + 1;
            if (PointerApontaClienteCadastrado(novoPointer))
            {
                pointerCliente = novoPointer;
            }
            ExibirDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clientes[pointerCliente].codigo = pointerCliente + 1;
            clientes[pointerCliente].nome = inputNome.Text;
            clientes[pointerCliente].endereco = inputEndereco.Text;
            clientes[pointerCliente].bairro = inputBairro.Text;
            clientes[pointerCliente].cidade = inputCidade.Text;
            clientes[pointerCliente].estado = inputEstado.Text;
            clientes[pointerCliente].cep = inputCEP.Text;
            clientes[pointerCliente].telefone = inputTelefone.Text;
            clientes[pointerCliente].email = inputEmail.Text;
            clientes[pointerCliente].cpf = inputCPF.Text;
            clientes[pointerCliente].rg = inputRG.Text;

            if (modoForm == ModoForm.Cadastro)
            {
                pointerPosicaoVaziaArray++;
            }
            
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (modoForm == ModoForm.Cadastro)
            {
                pointerCliente--;
            }
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (pointerPosicaoVaziaArray >= clientes.Length) 
            {
                MessageBox.Show(
                    "Não há espaço suficiente para um novo cliente.\nContate o administrador do sistema",
                    "Sem espaço",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            pointerCliente = pointerPosicaoVaziaArray;
            LimparForm();
            inputCodigo.Text = (pointerPosicaoVaziaArray + 1).ToString();
            DefinirModoForm(ModoForm.Cadastro);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // TODO
            Debugger.Break();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (PointerApontaClienteCadastrado(pointerCliente))
            {
                ExibirDados();
                DefinirModoForm(ModoForm.Alteracao);
            } else
            {
                MessageBox.Show(
                    "Você não selecionou nenhum cliente para alterar.",
                    "Cliente não encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string cliente = clientes[pointerCliente].nome;
            DialogResult confirm = MessageBox.Show(
                $"Tem certeza de que deseja apagar o cliente '{cliente}'? Essa ação não pode ser desfeita.'",
                "Confirmar exclusão",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );

            if (confirm != DialogResult.Yes) {
                return;
            }

            clientes[pointerCliente].nome = "";
            clientes[pointerCliente].endereco = "";
            clientes[pointerCliente].bairro = "";
            clientes[pointerCliente].cidade = "";
            clientes[pointerCliente].estado = "";
            clientes[pointerCliente].cep = "";
            clientes[pointerCliente].telefone = "";
            clientes[pointerCliente].email = "";
            clientes[pointerCliente].cpf = "";
            clientes[pointerCliente].rg = "";
            ExibirDados();
        }
    }
}
