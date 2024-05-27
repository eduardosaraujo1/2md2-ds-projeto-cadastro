using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCadastro
{
    public static class Storage
    {
        public struct Usuario
        {
            public int? codigo;
            public string nome;
            public string login;
            public string senha;
        }

        public struct Cliente
        {
            public int? codigo;
            public string nome;
            public string endereco;
            public string bairro;
            public string cidade;
            public string estado;
            public string cep;
            public string telefone;
            public string email;
            public string cpf;
            public string rg;
        }

        public struct Fornecedor
        {
            public int? codigo;
            public string nomeFantasia;
            public string razaoSocial;
            public string contato;
            public string email;
            public string cnpj;
            public string inscrEstadual;
            public string endereco;
            public string cidade;
            public string bairro;
            public string estado;
            public string cep;
            public string telefone;
        }

        public static Usuario[] usuarios = new Usuario[100];
        public static Cliente[] clientes = new Cliente[100];
        public static Fornecedor[] fornecedores = new Fornecedor[100];
    }
}
