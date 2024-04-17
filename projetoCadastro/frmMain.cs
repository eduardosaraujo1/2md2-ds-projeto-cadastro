﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser userFrm = new frmUser();
            userFrm.ShowDialog();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente userFrm = new frmCliente();
            userFrm.ShowDialog();
        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmFornecedor userFrm = new frmFornecedor();
            userFrm.ShowDialog();
        }
    }
}
