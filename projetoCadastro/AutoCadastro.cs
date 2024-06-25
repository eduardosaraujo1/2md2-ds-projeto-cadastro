using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCadastro
{
    internal class AutoCadastro
    {
        Random random { get; set; }
        public AutoCadastro()
        {
            random = new Random();
        }
        public void CadastrarTudo()
        {
            GerarCadastrosAleatorios<Usuario>(100);
            GerarCadastrosAleatorios<Cliente>(100);
            GerarCadastrosAleatorios<Fornecedor>(100);
        }
        private void GerarCadastrosAleatorios<T>(int quantidade) where T : IEntidade, new()
        {
            quantidade = Math.Max(quantidade, 1);
            quantidade = Math.Min(quantidade, 100);
            for (int i = 0; i < quantidade; i++)
            {
                CadastrarNovo<T>(i);
            }

        }
        void CadastrarNovo<T>(int i) where T : IEntidade, new()
        {
            if (typeof(T) == typeof(Cliente))
            {
                Storage.clientes[i] = new Cliente
                {
                    codigo = i + 1,
                    nome = GerarStringAleatoria(random),
                    endereco = GerarStringAleatoria(random),
                    bairro = GerarStringAleatoria(random),
                    cidade = GerarStringAleatoria(random),
                    estado = GerarStringAleatoria(random),
                    cep = GerarStringAleatoria(random),
                    telefone = GerarStringAleatoria(random),
                    email = GerarStringAleatoria(random),
                    cpf = GerarStringAleatoria(random),
                    rg = GerarStringAleatoria(random)
                };
            }
            else if (typeof(T) == typeof(Fornecedor))
            {
                Storage.fornecedores[i] = new Fornecedor
                {
                    codigo = i + 1,
                    nome = GerarStringAleatoria(random),
                    razaoSocial = GerarStringAleatoria(random),
                    contato = GerarStringAleatoria(random),
                    email = GerarStringAleatoria(random),
                    cnpj = GerarStringAleatoria(random),
                    inscrEstadual = GerarStringAleatoria(random),
                    endereco = GerarStringAleatoria(random),
                    cidade = GerarStringAleatoria(random),
                    bairro = GerarStringAleatoria(random),
                    estado = GerarStringAleatoria(random),
                    cep = GerarStringAleatoria(random),
                    telefone = GerarStringAleatoria(random),
                };
            }
            else if (typeof(T) == typeof(Usuario))
            {
                Storage.usuarios[i] = new Usuario
                {
                    codigo = i + 1,
                    nome = GerarStringAleatoria(random),
                    login = GerarStringAleatoria(random),
                    senha = GerarStringAleatoria(random)
                };
            }
        }
        
        private string GerarStringAleatoria(Random random)
        {
            const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int tamanho = random.Next(4, 24);
            StringBuilder resultado = new StringBuilder(tamanho);

            for (int i = 0; i < tamanho; i++)
            {
                int indice = random.Next(caracteresPermitidos.Length);
                resultado.Append(caracteresPermitidos[indice]);
            }

            return resultado.ToString();
        }
    }
}
