namespace projetoCadastro
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.panelCamposContainer = new System.Windows.Forms.Panel();
            this.panelCampos = new System.Windows.Forms.TableLayoutPanel();
            this.inputCodigo = new System.Windows.Forms.TextBox();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.panelCamposContainer.SuspendLayout();
            this.panelCampos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCamposContainer
            // 
            this.panelCamposContainer.Controls.Add(this.panelCampos);
            this.panelCamposContainer.Controls.Add(this.label14);
            this.panelCamposContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamposContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCamposContainer.Location = new System.Drawing.Point(0, 0);
            this.panelCamposContainer.Name = "panelCamposContainer";
            this.panelCamposContainer.Size = new System.Drawing.Size(604, 376);
            this.panelCamposContainer.TabIndex = 3;
            // 
            // panelCampos
            // 
            this.panelCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCampos.ColumnCount = 2;
            this.panelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelCampos.Controls.Add(this.inputCodigo, 1, 0);
            this.panelCampos.Controls.Add(this.inputSenha, 1, 3);
            this.panelCampos.Controls.Add(this.lblCodigo, 0, 0);
            this.panelCampos.Controls.Add(this.inputLogin, 1, 2);
            this.panelCampos.Controls.Add(this.lblSenha, 0, 3);
            this.panelCampos.Controls.Add(this.lblNome, 0, 1);
            this.panelCampos.Controls.Add(this.inputNome, 1, 1);
            this.panelCampos.Controls.Add(this.lblLogin, 0, 2);
            this.panelCampos.Location = new System.Drawing.Point(7, 36);
            this.panelCampos.MinimumSize = new System.Drawing.Size(314, 106);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.RowCount = 4;
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelCampos.Size = new System.Drawing.Size(594, 106);
            this.panelCampos.TabIndex = 9;
            // 
            // inputCodigo
            // 
            this.inputCodigo.Enabled = false;
            this.inputCodigo.Location = new System.Drawing.Point(61, 3);
            this.inputCodigo.Name = "inputCodigo";
            this.inputCodigo.Size = new System.Drawing.Size(90, 23);
            this.inputCodigo.TabIndex = 1;
            // 
            // inputSenha
            // 
            this.inputSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSenha.Location = new System.Drawing.Point(61, 81);
            this.inputSenha.Margin = new System.Windows.Forms.Padding(3, 3, 120, 3);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(413, 23);
            this.inputSenha.TabIndex = 4;
            this.inputSenha.UseSystemPasswordChar = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // inputLogin
            // 
            this.inputLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputLogin.Location = new System.Drawing.Point(61, 55);
            this.inputLogin.Margin = new System.Windows.Forms.Padding(3, 3, 160, 3);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(373, 23);
            this.inputLogin.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(6, 83);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 17);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // inputNome
            // 
            this.inputNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNome.Location = new System.Drawing.Point(61, 29);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(530, 23);
            this.inputNome.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 56);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Login";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 26);
            this.label14.TabIndex = 8;
            this.label14.Text = "Cadastro Usuário";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnterior.Location = new System.Drawing.Point(33, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(102, 44);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvar.Location = new System.Drawing.Point(141, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 44);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProximo.Location = new System.Drawing.Point(33, 53);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(102, 44);
            this.btnProximo.TabIndex = 6;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(141, 53);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 44);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.Location = new System.Drawing.Point(465, 53);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 44);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(357, 53);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 44);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.Location = new System.Drawing.Point(249, 53);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 44);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Location = new System.Drawing.Point(465, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(106, 44);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlterar.Location = new System.Drawing.Point(357, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(102, 44);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovo.Location = new System.Drawing.Point(249, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 44);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnAnterior, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnImprimir, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnProximo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPesquisar, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSair, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalvar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNovo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAlterar, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 276);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 100);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelCamposContainer);
            this.MinimumSize = new System.Drawing.Size(473, 304);
            this.Name = "frmUser";
            this.Text = "Cadastro Usuário";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.panelCamposContainer.ResumeLayout(false);
            this.panelCamposContainer.PerformLayout();
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCamposContainer;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox inputCodigo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel panelCampos;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}