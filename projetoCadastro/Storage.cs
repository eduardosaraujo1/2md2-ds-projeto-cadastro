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

        public static Usuario[] usuarios = new Usuario[100];
    }
}
