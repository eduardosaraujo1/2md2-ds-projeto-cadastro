using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
        // note: "pointer" significa o index da posição descrita no nome
        // exemplo: pointerUsuario é o index da posição do usuário sendo visualizado atualmente
        // exemplo: pointerPosicaoVaziaArray é o index da posição onde se encontra o primeiro espaço vazio no array
        // o termo vem da ideia de apontar (point) para a posição do array desejada
        // o termo é usado em C para apontar uma posição na memória RAM
        private Storage.Usuario[] usuarios = Storage.usuarios;
        private int pointerUsuario = -1; // pointer inicial é -1 pois não temos nenhum usuário para "apontar" ainda
        private int pointerPosicaoVaziaArray = -1; // por padrão é indefinido (-1 pois fazer int? traria complicações); será calculado runtime
        public ModoForm modoForm; // acompanha se estamos visualizando, alterando, cadastrando ou pesquisando
        public frmUser()
        {
            InitializeComponent();
        }

        private void EncontrarPosicaoVaziaArray()
        {
            pointerPosicaoVaziaArray = -1;
            int usuariosLength = usuarios.Length;
            for (int pos = 0; pos < usuariosLength; pos++)
            {
                if (usuarios[pos].codigo is null)
                {
                    pointerPosicaoVaziaArray = pos;
                    return;
                }
            }
            // se essa parte do código for executada, significa que o array está cheio
            // nesse caso, a posicaoCadastroUsuario estará uma unidade fora do array
            pointerPosicaoVaziaArray = usuariosLength;
        }

        private bool PointerDentroArray(int pointer)
        {
            // método determina se o valor do pointer é um index valido para o array
            return pointer >= 0 && pointer < usuarios.Length;
        }

        private bool PointerApontaUsuarioCadastrado(int pointer) {
            // método determina se o usuário apontado pelo pointer está cadastrado
            return PointerDentroArray(pointer) && !(usuarios[pointer].codigo is null);
        }
        
        private void DefinirModoTextBoxes(bool enabled)
        {
            foreach(Control control in panelFrmUser.Controls) {
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

        private void LimparForm()
        {
            foreach(Control control in panelFrmUser.Controls) {
                if (control is TextBox)
                {
                    TextBox tb = control as TextBox;
                    tb.Text = "";
                }
            }
        }

        private void ExibirDados()
        {
            // não é possivel exibir dados se eles forem nulos, por isso o vetor não pode apontar para nulo
            if (PointerApontaUsuarioCadastrado(pointerUsuario))
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

        private void frmUser_Load(object sender, EventArgs e)
        {
            EncontrarPosicaoVaziaArray();
            pointerUsuario = pointerPosicaoVaziaArray - 1; // aponta para posição de ultimo usuário cadastrado
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            /*
            CADASTRO DE USUÁRIO
            Verificar se tem espaço para um usuário novo, mensagem de erros e não tem
            Apontar para o novo slot onde o usuário será cadastrado
            Limpar form de quaisquer outros dados que estavam lá previamente
            Exibir código do usuário novo (note que codigo = pointer + 1)
            Liberar usuário para digitar informações do usuário
            */
            if (pointerPosicaoVaziaArray >= usuarios.Length) 
            {
                MessageBox.Show(
                    "Não há espaço suficiente para um novo usuário.\nContate o administrador do sistema",
                    "Sem espaço",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            pointerUsuario = pointerPosicaoVaziaArray;
            LimparForm();
            inputCodigo.Text = (pointerPosicaoVaziaArray + 1).ToString();
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

            // isso é um exemplo do porque o conceito de "programação funcional" não utiliza estados:
            /*
            "Programação funcional é o processo de construir software através de composição de funções puras, 
            evitando compartilhamento de estados, dados mutáveis e efeitos colaterais."
            https://www.alura.com.br/artigos/programacao-funcional-o-que-e
            */
            // essa função está dependente do estado prévio da variavel pointerPosicaoVaziaArray
            // a funcionalidade excluirUsuario poderia, erroniamente, gerar um espaço nulo no meio do array, colocando a posicao vazia no meio do array
            // o calculo estaria correto, ele faz o trabalho dele, encontrar a primeira posição vazia disponivel
            // se estivessemos recaclulando a posição vazia do array sempre, apesar do custo computacional, não haveria problema
            // agora, cegamente incrementando o valor em 1 com o pointer no meio do array, o "espaço vazio" apontaria para um espaço preenchido
            // isso, por sua vez, causaria efeitos colaterais na função de novo usuário, que colocaria um novo usuário onde ja tinha um usuário
            // dessa forma, sobreescrevemos os dados desse usuário, uh oh... efeito colateral abre espaço para problemas
            // o problema não foi apenas o erro de excluirUsuario, qualquer função poderia cometer o mesmo erro
            // o problema foi permitir que o erro afetasse as outras funções, que se originou daqui
            // por hora, manterei essa implementação, mas caso a função excluirUsuario troque de requisitos implementarei a linha comentada abaixo
            if (modoForm == ModoForm.Cadastro)
            {
                // EncontrarPosicaoVaziaArray();
                pointerPosicaoVaziaArray++;
            }
            
            DefinirModoForm(ModoForm.Visualizacao);
            ExibirDados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            /*
            CANCELAR CADASTRO OU ALTERAÇÃO
            Se o modo for Cadastro, apontar para o usuário anterior, já que estamos apontando pro usuário que estava sendo cadastrado e não será mais
            Remover permissão do usuário para alterar os campos
            Exibir os dados do usuário atual (anterior)
            */
            if (modoForm == ModoForm.Cadastro)
            {
                // não apontar mais para o usuário que não será cadastrado
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
            if (PointerApontaUsuarioCadastrado(pointerUsuario))
            {
                ExibirDados();
                DefinirModoForm(ModoForm.Alteracao);
            } else
            {
                MessageBox.Show(
                    "Você não selecionou nenhum usuário para alterar.",
                    "Usuário não encontrado",
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
            if (PointerApontaUsuarioCadastrado(novoPointer))
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
            if (PointerApontaUsuarioCadastrado(novoPointer))
            {
                pointerUsuario = novoPointer;
            }
            ExibirDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // TODO: Não sei como essa funcionalidade deveria funcionar, tive uma teoria mas prefiro não arriscar estar errado
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            /*
            EXCLUIR USUÁRIO 
            Exibir prompt de confirmação para deletar o usuário de código n
            Se usuário confirma, remover os dados do usuário do array

            Note que apagar um usuário vai gerar espaços vazios.
            Espaços vazios no meio do array não serão encontrados, mas serão editaveis por meio do botão Alterar
            Isso é o comportamento intencional, seguindo o exemplo do professor
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // TODO: Aprender como funciona o Print Dialog para a função de imprimir
            Debugger.Break();
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
