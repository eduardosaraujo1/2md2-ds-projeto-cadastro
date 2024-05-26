using System; using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCadastro
{
    public partial class frmUser : Form
    {
        // note: "pointer" significa o index do array de usuários, pois ele aponta (point) qual é o usuário atual
        // o termo Pointer é usado em C, mas para apontar uma posição na memória
        private Storage.Usuario[] usuarios = Storage.usuarios;
        private int pointerUsuario = -1; // pointer inicial é -1 pois não temos nenhum usuário para "apontar" ainda
        private int posicaoCadastroUsuario = 0;
        public ModoForm modoForm;
        public frmUser()
        {
            InitializeComponent();
        }

        private void CalcularPosicaoCadastroUsuario()
        {
            int usuariosLength = usuarios.Length;
            int pos;
            for (pos = 0; pos < usuariosLength; pos++)
            {
                if (usuarios[pos].codigo is null)
                {
                    posicaoCadastroUsuario = pos;
                    break;
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
                    inputCodigo.Enabled = false;
                    inputNome.Enabled = false;
                    inputLogin.Enabled = false;
                    inputSenha.Enabled = false;
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
                    inputCodigo.Enabled = false;
                    inputNome.Enabled = true;
                    inputLogin.Enabled = true;
                    inputSenha.Enabled = true;
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

        private bool PointerDentroDoArray(int pointer)
        {
            // método determina se o valor do pointer é um index valido para o array
            return pointer >= 0 && pointer < usuarios.Length;
        }

        private bool PointerUsuarioNulo(int pointer) {
            // método determina se o usuário apontado pelo pointer está cadastrado
            return usuarios[pointer].codigo is null;
        }

        private bool PointerValido(int pointer)
        {
            return PointerDentroDoArray(pointer) && !PointerUsuarioNulo(pointer);
        }

        private void ExibirDados()
        {
            // não é possivel exibir dados se eles forem nulos, por isso o vetor não pode apontar para nulo
            if (PointerValido(pointerUsuario))
            {
                Storage.Usuario usuario = usuarios[pointerUsuario];
                inputCodigo.Text = (pointerUsuario + 1).ToString();
                inputNome.Text = usuario.nome ?? "";
                inputLogin.Text = usuario.login ?? "";
                inputSenha.Text = usuario.senha ?? "";
            } else
            {
                // se o vetor aponta para nulo, não exiba nada
                LimparForm();
            }
        }

        private void LimparForm()
        {
            inputCodigo.Text = "";
            inputNome.Text = "";
            inputLogin.Text = "";
            inputSenha.Text = "";
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            // verificar se o usuário de código 1 (pointer 0) já foi cadastrado, se sim apontar para ele
            if (PointerValido(0))
            {
                pointerUsuario = 0;
                ExibirDados();
            }
            CalcularPosicaoCadastroUsuario();
            DefinirModoForm(ModoForm.Visualizacao);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            /*
            CADASTRO DE USUÁRIO
            Verificar se tem espaço para um usuário novo
            Apontar para o novo slot onde o usuário será cadastrado (pointerUsuario++)
            Limpar form de quaisquer outros dados que estavam lá previamente
            Exibir código do usuário novo
            Liberar usuário para digitar informações do usuário
            */
            if (posicaoCadastroUsuario >= usuarios.Length) 
            {
                MessageBox.Show(
                    "Não há espaço suficiente para um novo usuário.\nContate o administrador do sistema",
                    "Erro Sem espaço",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            pointerUsuario = posicaoCadastroUsuario;
            LimparForm();
            inputCodigo.Text = (posicaoCadastroUsuario + 1).ToString();
            DefinirModoForm(ModoForm.Cadastro);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*
            SALVAR DADOS USUÁRIO (após alteração ou cadastro)
            Pegar os valores dos campos e salvar no vetor
            Remover permissão do usuário para alterar os campos
            Exibir os dados do usuário atual (recém-cadastrado)
            */

            usuarios[pointerUsuario].codigo = pointerUsuario + 1;
            usuarios[pointerUsuario].nome = inputNome.Text;
            usuarios[pointerUsuario].login = inputLogin.Text;
            usuarios[pointerUsuario].senha = inputSenha.Text;

            // seria melhor executar o método para calcular a posicaoCadastroUsuario novamente
            // isso é uma pequena vulnerabilidade, e é um exemplo perfeito do porquê cada parte do código deve funcionar da forma mais independente possível
            // estou prestes a implementar mecanica de deletar usuários, e se eu quisesse que espaços vazios fossem preenchidos por novos cadastros, essa linha geraria erros
            // o calculo inicial indicaria o ponto no meio do array e quando essa variavel incrementasse começaria a sobreescrever usuários
            // por isso, é recomendado que cada parte do código funcione de forma mais independente possível
            posicaoCadastroUsuario++;
            
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            /*
            CANCELAR CADASTRO OU ALTERAÇÃO
            Se o modo for Cadastro, reduza o pointer em 1 para voltar ao usuário anterior
            Remover permissão do usuário para alterar os campos
            Exibir os dados do usuário atual (anterior)
            */
            if (modoForm == ModoForm.Cadastro)
            {
                pointerUsuario--;
            }
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            /*
            ALTERAR USUÁRIO
            Se o pointer for válido:
            Exiba todos os dados do usuário atual na tela
            Libere para o usuário editar, esperando opção Salvar ou Cancelar
            Se não, avisar usuário que ele não selecionou nenhum usuário
            */
            if (PointerValido(pointerUsuario))
            {
                ExibirDados();
                DefinirModoForm(ModoForm.Alteracao);
            } else
            {
                MessageBox.Show(
                    "Você não selecionou nenhum usuário para alterar.",
                    "Erro usuário não encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            /*
            IR PARA PROXIMO REGISTRO
            Calcular pointer novo, somando 1
            Se o pointer for valido, faça o novo pointer ser igual ao pointer principal
            Exibir dados do novo usuário
            */

            int novoPointer = pointerUsuario + 1;
            if (PointerValido(novoPointer))
            {
                pointerUsuario = novoPointer;
            }
            ExibirDados();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            /*
            IR PARA REGISTRO ANTERIOR
            Calcular pointer novo, subtraindo 1
            Se o pointer for valido, faça o novo pointer ser igual ao pointer principal
            Exibir dados do novo usuário
            */
            int novoPointer = pointerUsuario - 1;
            if (PointerValido(novoPointer))
            {
                pointerUsuario = novoPointer;
            }
            ExibirDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Console.Write("Entrando em modo debugger");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            /*
            EXCLUIR USUÁRIO 
            Exibir prompt de confirmação para deletar o usuário de código n
            Se usuário confirma, remover os dados do usuário do array

            Note que apagar um usuário vai gerar espaços vazios.
            Espaços vazios no meio do array não serão encontrados, mas serão editaveis por meio do botão Alterar
            Isso é comportamento intencional
            */
            string usuario = usuarios[pointerUsuario].login;
            DialogResult confirm = MessageBox.Show(
                $"Tem certeza de que deseja apagar o usuário '{usuario}'? Essa ação não pode ser desfeita.'",
                "Confirmar exclusão",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );

            if (confirm != DialogResult.Yes) {
                return;
            }

            usuarios[pointerUsuario].nome = "";
            usuarios[pointerUsuario].login = "";
            usuarios[pointerUsuario].senha = "";
            ExibirDados();
        }

        public enum ModoForm
        {
            Cadastro = 0,
            Alteracao = 1,
            Visualizacao = 2,
            Pesquisa = 3
        }
    }
}
