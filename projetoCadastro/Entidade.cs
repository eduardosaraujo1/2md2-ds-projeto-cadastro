using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCadastro
{
    public interface IEntidade
    {
        int? codigo { get; set; }
        void LimparDados(bool removerCodigo);
    }

    public class Usuario : IEntidade
    {
        public int? codigo { get; set; }
        public string nome;
        public string login;
        public string senha;

        public void LimparDados(bool removerCodigo)
        {
            nome = String.Empty;
            login = String.Empty;
            senha = String.Empty;

            if (removerCodigo)
            {
                codigo = null;
            }
        }
    }

    public class Cliente : IEntidade
    {
        public int? codigo { get; set; }
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
        public void LimparDados(bool removerCodigo)
        {
            nome = String.Empty;
            endereco = String.Empty;
            bairro = String.Empty;
            cidade = String.Empty;
            estado = String.Empty;
            cep = String.Empty;
            telefone = String.Empty;
            email = String.Empty;
            cpf = String.Empty;
            rg = String.Empty;

            if (removerCodigo)
            {
                codigo = null;
            }
        }
    }

    public class Fornecedor : IEntidade
    {
        public int? codigo { get; set; }
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
        public void LimparDados(bool removerCodigo)
        {
            nomeFantasia = String.Empty;
            razaoSocial = String.Empty;
            contato = String.Empty;
            email = String.Empty;
            cnpj = String.Empty;
            inscrEstadual = String.Empty;
            endereco = String.Empty;
            cidade = String.Empty;
            bairro = String.Empty;
            estado = String.Empty;
            cep = String.Empty;
            telefone = String.Empty;

            if (removerCodigo)
            {
                codigo = null;
            }
        }
    }
}
