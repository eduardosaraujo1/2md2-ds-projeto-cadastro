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
    public partial class frmFornecedor : Form
    {
        private Storage.Fornecedor[] fornecedores = Storage.fornecedores;
        private int pointerFornecedor = -1;
        private int pointerPosicaoVaziaArray = -1;
        public ModoForm modoForm;
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EncontrarPosicaoVaziaArray()
        {
            pointerPosicaoVaziaArray = -1;
            int fornecedoresLength = fornecedores.Length;
            for (int pos = 0; pos < fornecedoresLength; pos++)
            {
                if (fornecedores[pos].codigo is null)
                {
                    pointerPosicaoVaziaArray = pos;
                    return;
                }
            }
            pointerPosicaoVaziaArray = fornecedoresLength;
        }

        private bool PointerDentroArray(int pointer)
        {
            // método determina se o valor do pointer é um index valido para o array
            return pointer >= 0 && pointer < fornecedores.Length;
        }

        private bool PointerApontaFornecedorCadastrado(int pointer) {
            // método determina se o fornecedor apontado pelo pointer está cadastrado
            return PointerDentroArray(pointer) && !(fornecedores[pointer].codigo is null);
        }
        
        private void LimparForm()
        {
            // Limpa todas as textboxes do form
            foreach(Control control in tableLayoutPanelInputs.Controls) {
                if (control is TextBox)
                {
                    TextBox tb = control as TextBox;
                    tb.Text = "";
                }
            }
        }

        private void DefinirModoTextBoxes(bool enabled)
        {
            foreach(Control control in tableLayoutPanelInputs.Controls) {
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
            if (PointerApontaFornecedorCadastrado(pointerFornecedor))
            {
                Storage.Fornecedor fornecedor = fornecedores[pointerFornecedor];
                inputCodigo.Text = (pointerFornecedor + 1).ToString();
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
            } else
            {
                LimparForm();
            }
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            EncontrarPosicaoVaziaArray();
            pointerFornecedor = pointerPosicaoVaziaArray - 1;
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int novoPointer = pointerFornecedor - 1;
            if (PointerApontaFornecedorCadastrado(novoPointer))
            {
                pointerFornecedor = novoPointer;
            }
            ExibirDados();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            int novoPointer = pointerFornecedor + 1;
            if (PointerApontaFornecedorCadastrado(novoPointer))
            {
                pointerFornecedor = novoPointer;
            }
            ExibirDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            fornecedores[pointerFornecedor].codigo = pointerFornecedor + 1;
            fornecedores[pointerFornecedor].nomeFantasia = inputNomeFantasia.Text;
            fornecedores[pointerFornecedor].razaoSocial = inputRazaoSocial.Text;
            fornecedores[pointerFornecedor].contato = inputContato.Text;
            fornecedores[pointerFornecedor].email = inputEmail.Text;
            fornecedores[pointerFornecedor].cnpj = inputCNPJ.Text;
            fornecedores[pointerFornecedor].inscrEstadual = inputInscrEstadual.Text;
            fornecedores[pointerFornecedor].endereco = inputEndereco.Text;
            fornecedores[pointerFornecedor].cidade = inputCidade.Text;
            fornecedores[pointerFornecedor].bairro = inputBairro.Text;
            fornecedores[pointerFornecedor].estado = inputEstado.Text;
            fornecedores[pointerFornecedor].cep = inputCEP.Text;
            fornecedores[pointerFornecedor].telefone = inputTelefone.Text;

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
                pointerFornecedor--;
            }
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (pointerPosicaoVaziaArray >= fornecedores.Length) 
            {
                MessageBox.Show(
                    "Não há espaço suficiente para um novo fornecedor.\nContate o administrador do sistema",
                    "Sem espaço",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            pointerFornecedor = pointerPosicaoVaziaArray;
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
            if (PointerApontaFornecedorCadastrado(pointerFornecedor))
            {
                ExibirDados();
                DefinirModoForm(ModoForm.Alteracao);
            } else
            {
                MessageBox.Show(
                    "Você não selecionou nenhum fornecedor para alterar.",
                    "Fornecedor não encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string fornecedor = fornecedores[pointerFornecedor].razaoSocial;
            DialogResult confirm = MessageBox.Show(
                $"Tem certeza de que deseja apagar o fornecedor '{fornecedor}'? Essa ação não pode ser desfeita.'",
                "Confirmar exclusão",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );

            if (confirm != DialogResult.Yes) {
                return;
            }

            fornecedores[pointerFornecedor].nomeFantasia = "";
            fornecedores[pointerFornecedor].razaoSocial = "";
            fornecedores[pointerFornecedor].contato = "";
            fornecedores[pointerFornecedor].email = "";
            fornecedores[pointerFornecedor].cnpj = "";
            fornecedores[pointerFornecedor].inscrEstadual = "";
            fornecedores[pointerFornecedor].endereco = "";
            fornecedores[pointerFornecedor].cidade = "";
            fornecedores[pointerFornecedor].bairro = "";
            fornecedores[pointerFornecedor].estado = "";
            fornecedores[pointerFornecedor].cep = "";
            fornecedores[pointerFornecedor].telefone = "";
            ExibirDados();
        }
    }
}
