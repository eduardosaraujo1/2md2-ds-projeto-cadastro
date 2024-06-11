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
        public static Usuario[] usuarios = new Usuario[100];
        public static Cliente[] clientes = new Cliente[100];
        public static Fornecedor[] fornecedores = new Fornecedor[100];
    }
}
