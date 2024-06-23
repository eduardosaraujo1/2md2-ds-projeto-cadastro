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
        string nome { get; set; }
        void LimparDados(bool removerCodigo);
    }

    public class Usuario : IEntidade
    {
        public int? codigo { get; set; }
        public string nome { get; set; }
        public string login;
        public string senha;

        public void LimparDados(bool removerCodigo)
        {
            nome = string.Empty;
            login = string.Empty;
            senha = string.Empty;

            if (removerCodigo)
            {
                codigo = null;
            }
        }
    }

    public class Cliente : IEntidade
    {
        public int? codigo { get; set; }
        public string nome { get; set; }
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
            nome = string.Empty;
            endereco = string.Empty;
            bairro = string.Empty;
            cidade = string.Empty;
            estado = string.Empty;
            cep = string.Empty;
            telefone = string.Empty;
            email = string.Empty;
            cpf = string.Empty;
            rg = string.Empty;

            if (removerCodigo)
            {
                codigo = null;
            }
        }
    }

    public class Fornecedor : IEntidade
    {
        public int? codigo { get; set; }
        public string nome { get; set; }
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
            nome = string.Empty;
            razaoSocial = string.Empty;
            contato = string.Empty;
            email = string.Empty;
            cnpj = string.Empty;
            inscrEstadual = string.Empty;
            endereco = string.Empty;
            cidade = string.Empty;
            bairro = string.Empty;
            estado = string.Empty;
            cep = string.Empty;
            telefone = string.Empty;

            if (removerCodigo)
            {
                codigo = null;
            }
        }
    }
}
