using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCadastro
{
    public partial class frmPesquisa : Form
    {
        private GenericCadastro caller;
        private IFormCadastro formulario;
        public frmPesquisa(GenericCadastro caller, IFormCadastro formulario)
        {
            this.caller = caller;
            this.formulario = formulario;
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

            caller.PointEntidadePorNomeParcial(searchQuery);
            this.Close();
        }

        private string DeterminarTipoFormulario()
        {
            if (formulario is frmUsuario)
            {
                return "Usuario";
            }
            else if (formulario is frmCliente)
            {
                return "Cliente";
            }
            else if (formulario is frmFornecedor)
            {
                return "Fornecedor";
            }
            else
            {
                return "Cadastro";
            }
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            string tipoFormulario = DeterminarTipoFormulario();
            header.Text = $"Pesquisa {tipoFormulario}";
            this.Text = $"Pesquisa {tipoFormulario}";
        }
    }
}
