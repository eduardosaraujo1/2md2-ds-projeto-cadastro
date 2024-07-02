using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace projetoCadastro
{
    public interface IFormCadastro
    {
        IEntidade[] cadastros { get; set; }

        IEntidade FormGerarEntidade();
        void RenderizarDados();
        bool ValidarCamposEntidade(IEntidade entidade);

        BotoesForm GetBotoesForm();
        TextBox InputCodigo { get; }
        TextBox InputNome { get; }
        Panel PanelCampos { get; }
        PrintPreviewDialog PrintPreviewDialog { get; }
    }

    public partial class frmUsuario : Form
    {
        private void btnSair_Click(object sender, EventArgs e) => this.Close();
        private void btnAnterior_Click(object sender, EventArgs e) => logica.NavBtn_Click(-1);
        private void btnProximo_Click(object sender, EventArgs e) => logica.NavBtn_Click(1);
        private void btnCancelar_Click(object sender, EventArgs e) => logica.CancelarCadastroAlteracao();
        private void btnAlterar_Click(object sender, EventArgs e) => logica.AlteracaoCadastro();
        private void btnNovo_Click(object sender, EventArgs e) => logica.NovoCadastro();
        private void btnExcluir_Click(object sender, EventArgs e) => logica.ExcluirCadastro();
        private void btnSalvar_Click(object sender, EventArgs e) => logica.SalvarCadastro();
        private void BtnPesquisar_Click(object sender, EventArgs e) => logica.Pesquisar_Click();
        private void BtnImprimir_Click(object sender, EventArgs e) => logica.Imprimir_Click();

        // getters
        public Panel PanelCampos { get => panelCampos; }
        public TextBox InputCodigo { get => inputCodigo; }
        public TextBox InputNome { get => inputNome; }
        public PrintPreviewDialog PrintPreviewDialog { get => printPreviewDialog; }
        public BotoesForm GetBotoesForm()
        {
            return new BotoesForm
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
    }

    public partial class frmCliente : Form
    {
        private void btnSair_Click(object sender, EventArgs e) => Close();
        private void btnAnterior_Click(object sender, EventArgs e) => logica.NavBtn_Click(-1);
        private void btnProximo_Click(object sender, EventArgs e) => logica.NavBtn_Click(1);
        private void btnCancelar_Click(object sender, EventArgs e) => logica.CancelarCadastroAlteracao();
        private void btnAlterar_Click(object sender, EventArgs e) => logica.AlteracaoCadastro();
        private void btnNovo_Click(object sender, EventArgs e) => logica.NovoCadastro();
        private void btnExcluir_Click(object sender, EventArgs e) => logica.ExcluirCadastro();
        private void btnSalvar_Click(object sender, EventArgs e) => logica.SalvarCadastro();
        private void BtnPesquisar_Click(object sender, EventArgs e) => logica.Pesquisar_Click();
        private void btnImprimir_Click(object sender, EventArgs e) => logica.Imprimir_Click();

        // getters
        public Panel PanelCampos { get => panelCampos; }
        public TextBox InputCodigo { get => inputCodigo; }
        public TextBox InputNome { get => inputNome; }
        public PrintPreviewDialog PrintPreviewDialog { get => printPreviewDialog; }
        public BotoesForm GetBotoesForm()
        {
            return new BotoesForm
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
    }

    public partial class frmFornecedor : Form
    {
        private void btnSair_Click(object sender, EventArgs e) => this.Close();
        private void btnAnterior_Click(object sender, EventArgs e) => logica.NavBtn_Click(-1);
        private void btnProximo_Click(object sender, EventArgs e) => logica.NavBtn_Click(1);
        private void btnCancelar_Click(object sender, EventArgs e) => logica.CancelarCadastroAlteracao();
        private void btnAlterar_Click(object sender, EventArgs e) => logica.AlteracaoCadastro();
        private void btnNovo_Click(object sender, EventArgs e) => logica.NovoCadastro();
        private void btnExcluir_Click(object sender, EventArgs e) => logica.ExcluirCadastro();
        private void btnSalvar_Click(object sender, EventArgs e) => logica.SalvarCadastro();
        private void BtnPesquisar_Click(object sender, EventArgs e) => logica.Pesquisar_Click();
        private void BtnImprimir_Click(object sender, EventArgs e) => logica.Imprimir_Click();

        // getters
        public Panel PanelCampos { get => panelCampos; }
        public TextBox InputCodigo { get => inputCodigo; }
        public TextBox InputNome { get => inputNomeFantasia; }
        public PrintPreviewDialog PrintPreviewDialog { get => printPreviewDialog; }
        public BotoesForm GetBotoesForm()
        {
            return new BotoesForm
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
    }

    public class GenericCadastro
    {
        private readonly IFormCadastro formulario;
        public ModoForm modoForm { get; set; }
        public int indexCadAtual = -1;
        public int indexPosicaoVaziaArray = -1;
        
        public GenericCadastro(IFormCadastro formulario) 
        {
            this.formulario = formulario;
        }

        private int EncontrarPosicaoVaziaArray(IEntidade[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    return i;
                }
            }
            return array.Length;
        }

        private bool IsPointerDentroArray(int pointer)
        {
            // determina se o valor do pointer é um index valido para o array
            IEntidade[] array = formulario.cadastros;
            return pointer >= 0 && pointer < array.Length;
        }

        private bool PointerApontaClienteCadastrado(int pointer)
        {
            // método determina se o cliente apontado pelo pointer está cadastrado
            IEntidade[] array = formulario.cadastros;
            return IsPointerDentroArray(pointer) && !(array[pointer] is null);
        }
        
        public void LimparTextboxesForm()
        {
            // Define as textboxes do form para vazias, sem que o cadastro seja alterado
            foreach(Control control in formulario.PanelCampos.Controls) {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        public void DefinirModoTextBoxes(bool enabled)
        {
            foreach(Control control in formulario.PanelCampos.Controls) {
                if (control is TextBox)
                {
                    control.Enabled = enabled;
                }
            }
        }
        private void BloquearDigitacao() {
            DefinirModoTextBoxes(false);
            formulario.InputCodigo.Enabled = false;

            BotoesForm botoes = formulario.GetBotoesForm();
            botoes.btnAnterior.Enabled = true;
            botoes.btnProximo.Enabled = true;
            botoes.btnSalvar.Enabled = false;
            botoes.btnCancelar.Enabled = false;
            botoes.btnNovo.Enabled = true;
            botoes.btnAlterar.Enabled = true;
            botoes.btnExcluir.Enabled = true;
            botoes.btnPesquisar.Enabled = true;
            botoes.btnSair.Enabled = true;
            botoes.btnImprimir.Enabled = true;
        }

        private void PermitirDigitacao() {
            DefinirModoTextBoxes(true);
            formulario.InputCodigo.Enabled = false;

            BotoesForm botoes = formulario.GetBotoesForm();
            botoes.btnAnterior.Enabled = false;
            botoes.btnProximo.Enabled = false;
            botoes.btnSalvar.Enabled = true;
            botoes.btnCancelar.Enabled = true;
            botoes.btnNovo.Enabled = false;
            botoes.btnAlterar.Enabled = false;
            botoes.btnExcluir.Enabled = false;
            botoes.btnSair.Enabled = false;
            botoes.btnPesquisar.Enabled = false;
            botoes.btnImprimir.Enabled = false;
        }

        public void DefinirModoForm(ModoForm modo)
        {
            switch (modo)
            {
                case ModoForm.Visualizacao:
                    // modo visualização
                    BloquearDigitacao();
                    break;
                case ModoForm.Alteracao:
                case ModoForm.Cadastro:
                    // modo alteração (ou cadastro)
                    PermitirDigitacao();
                    break;
            }
            this.modoForm = modo;
        }
        private void ExibirDados()
        {
            if (IsPointerDentroArray(indexCadAtual))
            {
                formulario.RenderizarDados();
            }
            else
            {
                LimparTextboxesForm();
            }
        }

        public int? EncontrarEntidadePorNomeParcial(string nomePesquisa)
        {
            int arrayLength = formulario.cadastros.Length;
            for (int pointer = 0; pointer < arrayLength; pointer++)
            {
                //if (formulario.VerificarNomeMatchEntidade(nome, formulario.cadastros[pointer]))
                string nmEntidade = formulario.cadastros[pointer]?.nome.ToLower();
                bool match = !(string.IsNullOrEmpty(nmEntidade)) && nmEntidade.Contains(nomePesquisa);
                if (match) return pointer;
            }
            return null;
        }
        public void PointEntidadePorNomeParcial(string nomeParcial)
        {
            int? entidadeEncontrada = EncontrarEntidadePorNomeParcial(nomeParcial);
            if (entidadeEncontrada is null)
            {
                MessageBox.Show(
                    "Cadastro não encontrado.",
                    "Cadastro nao encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            } 
            else
            {
                indexCadAtual = (int)entidadeEncontrada;
                ExibirDados();
            }
        }

        public void GerarDocumentoPrint(string content, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fonte = new Font("Courier New", 12, FontStyle.Bold);
            Brush color = Brushes.Black;
            PointF posicao = new PointF(50, 50);
            g.DrawString(content, fonte, color, posicao);
        }

        // form generic methods
        public void Form_Load()
        {
            indexPosicaoVaziaArray = EncontrarPosicaoVaziaArray(formulario.cadastros);
            indexCadAtual = indexPosicaoVaziaArray - 1;
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        public void NavBtn_Click(int navIncrement)
        {
            // para funcionalidade btnAnterior, indexDiff = -1
            // para funcionalidade btnProximo, indexDiff = 1
            int novoPointer = indexCadAtual + navIncrement;
            if (PointerApontaClienteCadastrado(novoPointer))
            {
                indexCadAtual = novoPointer;
            }
            ExibirDados();
        }

        public void CancelarCadastroAlteracao()
        {
            if (modoForm == ModoForm.Cadastro)
            {
                indexCadAtual--;
            }
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        public void NovoCadastro()
        {
            if (indexPosicaoVaziaArray >= formulario.cadastros.Length) 
            {
                MessageBox.Show(
                    "Não há espaço suficiente para um novo cliente.\nContate o administrador do sistema",
                    "Sem espaço",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            LimparTextboxesForm();
            TextBox inputCodigo = formulario.InputCodigo;
            inputCodigo.Text = (indexPosicaoVaziaArray + 1).ToString();

            indexCadAtual = indexPosicaoVaziaArray;
            DefinirModoForm(ModoForm.Cadastro);
        }

        public void AlteracaoCadastro()
        {
            if (PointerApontaClienteCadastrado(indexCadAtual))
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

        public void SalvarCadastro()
        {
            IEntidade cadastro = formulario.FormGerarEntidade();
            if (!formulario.ValidarCamposEntidade(cadastro))
            {
                MessageBox.Show(
                    "Um ou mais campos obrigatórios estão nulos",
                    "Erro campo nulo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            formulario.cadastros[indexCadAtual] = cadastro;
            indexPosicaoVaziaArray = EncontrarPosicaoVaziaArray(formulario.cadastros);

            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        public void ExcluirCadastro()
        {
            // nao pode excluir o que nao existe
            if (!PointerApontaClienteCadastrado(indexCadAtual))
            {
                return;
            }

            IEntidade cadastro = formulario.cadastros[indexCadAtual];
            DialogResult confirm = MessageBox.Show(
                $"Tem certeza de que deseja apagar o cadastro de código {cadastro.codigo}? Essa ação não pode ser desfeita.'",
                "Confirmar exclusão",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            cadastro.LimparDados(removerCodigo: false);
            ExibirDados();
        }

        public void Pesquisar_Click()
        {
            frmPesquisa searchBox = new frmPesquisa(this, formulario);
            searchBox.ShowDialog();
        }

        public void Imprimir_Click()
        {
            if (string.IsNullOrEmpty(formulario.InputCodigo.Text) || string.IsNullOrEmpty(formulario.InputNome.Text))
            {
                MessageBox.Show(
                    "Erro: nenhum cadastro está selecionado",
                    "Cadastro nulo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            formulario.PrintPreviewDialog.ShowDialog();
        }

        public enum ModoForm
        {
            Cadastro = 0,
            Alteracao = 1,
            Visualizacao = 2,
            Pesquisa = 3
        }

    }
    public class BotoesForm
    {
        public Button btnAnterior;
        public Button btnProximo;
        public Button btnSalvar;
        public Button btnCancelar;
        public Button btnNovo;
        public Button btnPesquisar;
        public Button btnAlterar;
        public Button btnImprimir;
        public Button btnExcluir;
        public Button btnSair;
    }
}
