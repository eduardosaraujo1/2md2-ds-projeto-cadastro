using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCadastro
{
    public interface IFormCadastro
    {
        IEntidade[] cadastros { get; set; }

        IEntidade FormGerarEntidade();
        void RenderizarDados();
        Panel GetPanelCampos();
        LogicaCadastro.BotoesForm GetBotoesForm();
        TextBox GetInputCodigo();
        bool ValidarCamposEntidade(IEntidade entidade);
        
    }
    public class LogicaCadastro
    {
        // note: "pointer" significa o index da posição descrita no nome
        // exemplo: pointerUsuario é o index da posição do usuário sendo visualizado atualmente
        // exemplo: pointerPosicaoVaziaArray é o index da posição onde se encontra o primeiro espaço vazio no array
        // o termo vem da ideia de apontar (point) para a posição do array desejada
        // o termo é usado em C para apontar uma posição na memória
        private readonly IFormCadastro formulario;
        public ModoForm modoForm { get; set; }
        public int pointerEntidade = -1;
        public int pointerPosicaoVaziaArray = -1;
        
        public LogicaCadastro(IFormCadastro formulario) 
        {
            this.formulario = formulario;
        }

        private int EncontrarPosicaoVaziaArray(IEntidade[] array)
        {
            int arrayLength = array.Length;
            for (int pos = 0; pos < arrayLength; pos++)
            {
                if (array[pos]?.codigo is null)
                {
                    return pos;
                }
            }
            return arrayLength; // Se o array está cheio, a posição "vazia" está fora do array
        }

        private bool PointerDentroArray(int pointer)
        {
            // método determina se o valor do pointer é um index valido para o array
            IEntidade[] array = formulario.cadastros;
            return pointer >= 0 && pointer < array.Length;
        }

        private bool PointerApontaClienteCadastrado(int pointer)
        {
            // método determina se o cliente apontado pelo pointer está cadastrado
            IEntidade[] array = formulario.cadastros;
            return PointerDentroArray(pointer) && !(array[pointer] is null);
        }
        
        public void LimparForm()
        {
            // Limpa todas as textboxes do form
            foreach(Control control in formulario.GetPanelCampos().Controls) {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        public void DefinirModoTextBoxes(bool enabled)
        {
            foreach(Control control in formulario.GetPanelCampos().Controls) {
                if (control is TextBox)
                {
                    control.Enabled = enabled;
                }
            }
        }
        private void BloquearDigitacao() {
            DefinirModoTextBoxes(false);
            formulario.GetInputCodigo().Enabled = false;

            BotoesForm botoes = formulario.GetBotoesForm();
            botoes.btnAnterior.Enabled = true;
            botoes.btnProximo.Enabled = true;
            botoes.btnSalvar.Enabled = false;
            botoes.btnCancelar.Enabled = false;
            botoes.btnNovo.Enabled = true;
            botoes.btnAlterar.Enabled = true;
            botoes.btnExcluir.Enabled = true;
            botoes.btnSair.Enabled = true;
        }

        private void PermitirDigitacao() {
            DefinirModoTextBoxes(true);
            formulario.GetInputCodigo().Enabled = false;

            BotoesForm botoes = formulario.GetBotoesForm();
            botoes.btnAnterior.Enabled = false;
            botoes.btnProximo.Enabled = false;
            botoes.btnSalvar.Enabled = true;
            botoes.btnCancelar.Enabled = true;
            botoes.btnNovo.Enabled = false;
            botoes.btnAlterar.Enabled = false;
            botoes.btnExcluir.Enabled = false;
            botoes.btnSair.Enabled = false;
        }

        public void DefinirModoForm(ModoForm modo)
        {
            modoForm = modo;
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
        }
        private void ExibirDados()
        {
            if (PointerDentroArray(pointerEntidade))
            {
                formulario.RenderizarDados();
            } else
            {
                LimparForm();
            }
        }

        public void OnFormLoad()
        {
            pointerPosicaoVaziaArray = EncontrarPosicaoVaziaArray(formulario.cadastros); 
            pointerEntidade = pointerPosicaoVaziaArray - 1;
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        public void NavegarCadastros(int indexDiff)
        {
            // para funcionalidade btnAnterior, indexDiff = -1
            // para funcionalidade btnProximo, indexDiff = 1
            int novoPointer = pointerEntidade + indexDiff;
            if (PointerApontaClienteCadastrado(novoPointer))
            {
                pointerEntidade = novoPointer;
            }
            ExibirDados();
        }

       public void CancelarCadastroAlteracao()
        {
            if (modoForm == ModoForm.Cadastro)
            {
                pointerEntidade--;
            }
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        public void NovoCadastro()
        {
            if (pointerPosicaoVaziaArray >= formulario.cadastros.Length) 
            {
                MessageBox.Show(
                    "Não há espaço suficiente para um novo cliente.\nContate o administrador do sistema",
                    "Sem espaço",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            LimparForm();
            TextBox inputCodigo = formulario.GetInputCodigo();
            inputCodigo.Text = (pointerPosicaoVaziaArray + 1).ToString();

            pointerEntidade = pointerPosicaoVaziaArray;
            DefinirModoForm(ModoForm.Cadastro);
        }

        public void AlteracaoCadastro()
        {
            if (PointerApontaClienteCadastrado(pointerEntidade))
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

            formulario.cadastros[pointerEntidade] = cadastro;
            pointerPosicaoVaziaArray = EncontrarPosicaoVaziaArray(formulario.cadastros);

            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        public void ExcluirCadastro()
        {
            // nao pode excluir o que nao existe
            if (!PointerApontaClienteCadastrado(pointerEntidade))
            {
                return;
            }

            IEntidade cadastro = formulario.cadastros[pointerEntidade];
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
        public enum ModoForm
        {
            Cadastro = 0,
            Alteracao = 1,
            Visualizacao = 2,
            Pesquisa = 3
        }

        public enum DirecaoNavegacao
        {
            Anterior = -1,
            Proximo = 1
        }

        public struct BotoesForm
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
}
