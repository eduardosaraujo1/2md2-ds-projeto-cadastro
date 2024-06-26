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
        private string TipoParentForm { get; set; }
        public GenericCadastro caller;
        public frmPesquisa(GenericCadastro caller, string TipoParentForm)
        {
            this.caller = caller;
            InitializeComponent();
            this.TipoParentForm = TipoParentForm;
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

            caller.PointEntidadePorNomeParcial(searchQuery);
            this.Close();
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            header.Text = $"Pesquisa {TipoParentForm}";
            this.Text = $"Pesquisa {TipoParentForm}";
        }
    }
}
