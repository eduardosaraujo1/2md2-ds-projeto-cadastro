using System;
using System.Collections.Generic;
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
        public char modoForm;
        public frmUser()
        {
            InitializeComponent();
        }

        private int GetCodigo()
        {
            return (pointerUsuario + 1);
        }

        private void DefinirModoForm(char modo)
        {
            this.modoForm = modo;
            if (modo == 'V')
            {
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
            } 
            else if (modo == 'A' || modo == 'C')
            {
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
            }
            else if (modo == 'P')
            {
                // modo pesquisa (wip)
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
            DefinirModoForm('V');
            // verificar se o usuário de código 1 (pointer 0) já foi cadastrado, se sim apontar para ele
            if (PointerValido(0))
            {
                pointerUsuario = 0;
                ExibirDados();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            /*
            CADASTRO DE USUÁRIO NOVO
            Verificar se tem espaço para um usuário novo
            Apontar para o novo slot onde o usuário será cadastrado (pointerUsuario++)
            Limpar form de quaisquer outros dados que estavam lá previamente
            Exibir código do usuário novo
            Liberar usuário para digitar informações do usuário
            */
            if (pointerUsuario >= usuarios.Length) 
            {
                MessageBox.Show(
                    "Não há espaço suficiente para um novo usuário.\nContate o administrador do sistema",
                    "Sem espaço",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            pointerUsuario++;
            LimparForm();
            inputCodigo.Text = GetCodigo().ToString();
            DefinirModoForm('C');
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*
            SALVAR DADOS USUÁRIO (após alteração ou cadastro)
            Pegar os valores dos campos e salvar no vetor
            Remover permissão do usuário para alterar os campos
            Exibir os dados do usuário atual (recém-cadastrado)
            */
            usuarios[pointerUsuario].codigo = GetCodigo();
            usuarios[pointerUsuario].nome = inputNome.Text;
            usuarios[pointerUsuario].login = inputLogin.Text;
            usuarios[pointerUsuario].senha = inputSenha.Text;
            
            DefinirModoForm('V');
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
            if (modoForm == 'C')
            {
                pointerUsuario--;
            }
            DefinirModoForm('V');
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
                DefinirModoForm('A');
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
    }
}
