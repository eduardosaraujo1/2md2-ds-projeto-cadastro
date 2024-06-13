using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCadastro
{
    public partial class frmPesquisa : Form
    {
        public LogicaCadastro caller;
        public frmPesquisa(LogicaCadastro caller)
        {
            this.caller = caller;
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string searchQuery = txtCaixaPesquisa.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchQuery))
            {
                return;
            }
            caller.PesquisarEntidadeEExibir(searchQuery);
            this.Close();
        }
    }
}
