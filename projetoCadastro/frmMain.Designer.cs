namespace projetoCadastro
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.displayMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.displayData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.displayHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerSegundo = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pdocUsuario = new System.Drawing.Printing.PrintDocument();
            this.ppDialogUsuario = new System.Windows.Forms.PrintPreviewDialog();
            this.pdocFornecedor = new System.Drawing.Printing.PrintDocument();
            this.ppDialogFornecedor = new System.Windows.Forms.PrintPreviewDialog();
            this.ppdocCliente = new System.Drawing.Printing.PrintDocument();
            this.ppDialogCliente = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(659, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.UsuárioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.FornecedorToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioTSMenuItem,
            this.clienteTSMenuItem,
            this.fornecedorTSMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // usuarioTSMenuItem
            // 
            this.usuarioTSMenuItem.Name = "usuarioTSMenuItem";
            this.usuarioTSMenuItem.Size = new System.Drawing.Size(167, 26);
            this.usuarioTSMenuItem.Text = "Usuário";
            this.usuarioTSMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem1_Click);
            // 
            // clienteTSMenuItem
            // 
            this.clienteTSMenuItem.Name = "clienteTSMenuItem";
            this.clienteTSMenuItem.Size = new System.Drawing.Size(167, 26);
            this.clienteTSMenuItem.Text = "Cliente";
            this.clienteTSMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // fornecedorTSMenuItem
            // 
            this.fornecedorTSMenuItem.Name = "fornecedorTSMenuItem";
            this.fornecedorTSMenuItem.Size = new System.Drawing.Size(167, 26);
            this.fornecedorTSMenuItem.Text = "Fornecedor";
            this.fornecedorTSMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelMsg,
            this.displayMessage,
            this.labelData,
            this.displayData,
            this.lblHora,
            this.displayHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(659, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelMsg
            // 
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(85, 20);
            this.labelMsg.Text = "Mensagem:";
            // 
            // displayMessage
            // 
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(462, 20);
            this.displayMessage.Spring = true;
            this.displayMessage.Text = "Tela Principal";
            this.displayMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelData
            // 
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(44, 20);
            this.labelData.Text = "Data:";
            // 
            // displayData
            // 
            this.displayData.Name = "displayData";
            this.displayData.Size = new System.Drawing.Size(0, 20);
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(45, 20);
            this.lblHora.Text = "Hora:";
            // 
            // displayHora
            // 
            this.displayHora.Name = "displayHora";
            this.displayHora.Size = new System.Drawing.Size(0, 20);
            // 
            // timerSegundo
            // 
            this.timerSegundo.Enabled = true;
            this.timerSegundo.Interval = 1000;
            this.timerSegundo.Tick += new System.EventHandler(this.UpdateDateTime);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainer.BackgroundImage = global::projetoCadastro.Properties.Resources.cadastro_1_1024x922;
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 30);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(659, 309);
            this.panelContainer.TabIndex = 2;
            // 
            // pdocUsuario
            // 
            this.pdocUsuario.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocUsuario_PrintPage);
            // 
            // ppDialogUsuario
            // 
            this.ppDialogUsuario.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppDialogUsuario.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppDialogUsuario.ClientSize = new System.Drawing.Size(400, 300);
            this.ppDialogUsuario.Document = this.pdocUsuario;
            this.ppDialogUsuario.Enabled = true;
            this.ppDialogUsuario.Icon = ((System.Drawing.Icon)(resources.GetObject("ppDialogUsuario.Icon")));
            this.ppDialogUsuario.Name = "ppDialogUsuario";
            this.ppDialogUsuario.Visible = false;
            // 
            // pdocFornecedor
            // 
            this.pdocFornecedor.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocFornecedor_PrintPage);
            // 
            // ppDialogFornecedor
            // 
            this.ppDialogFornecedor.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppDialogFornecedor.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppDialogFornecedor.ClientSize = new System.Drawing.Size(400, 300);
            this.ppDialogFornecedor.Document = this.pdocFornecedor;
            this.ppDialogFornecedor.Enabled = true;
            this.ppDialogFornecedor.Icon = ((System.Drawing.Icon)(resources.GetObject("ppDialogFornecedor.Icon")));
            this.ppDialogFornecedor.Name = "ppDialogFornecedor";
            this.ppDialogFornecedor.Visible = false;
            // 
            // ppdocCliente
            // 
            this.ppdocCliente.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ppdocCliente_PrintPage);
            // 
            // ppDialogCliente
            // 
            this.ppDialogCliente.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppDialogCliente.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppDialogCliente.ClientSize = new System.Drawing.Size(400, 300);
            this.ppDialogCliente.Document = this.ppdocCliente;
            this.ppDialogCliente.Enabled = true;
            this.ppDialogCliente.Icon = ((System.Drawing.Icon)(resources.GetObject("ppDialogCliente.Icon")));
            this.ppDialogCliente.Name = "ppDialogCliente";
            this.ppDialogCliente.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(659, 365);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(295, 299);
            this.Name = "frmMain";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelMsg;
        private System.Windows.Forms.ToolStripStatusLabel labelData;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripStatusLabel displayMessage;
        private System.Windows.Forms.Timer timerSegundo;
        private System.Windows.Forms.ToolStripStatusLabel displayHora;
        private System.Windows.Forms.ToolStripStatusLabel displayData;
        private System.Windows.Forms.Panel panelContainer;
        private System.Drawing.Printing.PrintDocument pdocUsuario;
        private System.Windows.Forms.PrintPreviewDialog ppDialogUsuario;
        private System.Drawing.Printing.PrintDocument pdocFornecedor;
        private System.Windows.Forms.PrintPreviewDialog ppDialogFornecedor;
        private System.Drawing.Printing.PrintDocument ppdocCliente;
        private System.Windows.Forms.PrintPreviewDialog ppDialogCliente;
    }
}

