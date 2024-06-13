namespace projetoCadastro
{
    partial class frmRelUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelUsuario));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.panelDataContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panelNavBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelDataContainer.SuspendLayout();
            this.panelNavBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelDataContainer);
            this.panelContainer.Controls.Add(this.panelNavigation);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 450);
            this.panelContainer.TabIndex = 0;
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.panelNavBtns);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigation.Location = new System.Drawing.Point(0, 347);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(800, 103);
            this.panelNavigation.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.AutoSize = true;
            this.panelData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panelData.ColumnCount = 2;
            this.panelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelData.Controls.Add(this.labelCodigo, 1, 1);
            this.panelData.Controls.Add(this.label3, 0, 1);
            this.panelData.Controls.Add(this.label1, 0, 0);
            this.panelData.Controls.Add(this.label6, 0, 4);
            this.panelData.Controls.Add(this.labelSenha, 1, 4);
            this.panelData.Controls.Add(this.labelLogin, 1, 3);
            this.panelData.Controls.Add(this.labelNome, 1, 2);
            this.panelData.Controls.Add(this.label4, 0, 3);
            this.panelData.Controls.Add(this.label2, 0, 2);
            this.panelData.Location = new System.Drawing.Point(3, 3);
            this.panelData.Name = "panelData";
            this.panelData.Padding = new System.Windows.Forms.Padding(16, 0, 15, 0);
            this.panelData.RowCount = 5;
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelData.Size = new System.Drawing.Size(794, 131);
            this.panelData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.panelData.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // labelNome
            // 
            this.labelNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(707, 55);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(68, 20);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Loading";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Login";
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(707, 81);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(68, 20);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Loading";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Senha";
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(707, 107);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(68, 20);
            this.labelSenha.TabIndex = 6;
            this.labelSenha.Text = "Loading";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código";
            // 
            // labelCodigo
            // 
            this.labelCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(707, 29);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(68, 20);
            this.labelCodigo.TabIndex = 3;
            this.labelCodigo.Text = "Loading";
            // 
            // panelDataContainer
            // 
            this.panelDataContainer.ColumnCount = 1;
            this.panelDataContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDataContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelDataContainer.Controls.Add(this.panelData, 0, 0);
            this.panelDataContainer.Location = new System.Drawing.Point(0, 0);
            this.panelDataContainer.Name = "panelDataContainer";
            this.panelDataContainer.RowCount = 1;
            this.panelDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelDataContainer.Size = new System.Drawing.Size(800, 347);
            this.panelDataContainer.TabIndex = 1;
            // 
            // panelNavBtns
            // 
            this.panelNavBtns.ColumnCount = 2;
            this.panelNavBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelNavBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelNavBtns.Controls.Add(this.btnProximo, 1, 0);
            this.panelNavBtns.Controls.Add(this.btnAnterior, 0, 0);
            this.panelNavBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavBtns.Location = new System.Drawing.Point(0, 0);
            this.panelNavBtns.Name = "panelNavBtns";
            this.panelNavBtns.Padding = new System.Windows.Forms.Padding(32, 16, 32, 16);
            this.panelNavBtns.RowCount = 1;
            this.panelNavBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelNavBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelNavBtns.Size = new System.Drawing.Size(800, 103);
            this.panelNavBtns.TabIndex = 1;
            // 
            // btnProximo
            // 
            this.btnProximo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProximo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(404, 20);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(360, 63);
            this.btnProximo.TabIndex = 12;
            this.btnProximo.Text = "→";
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnterior.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(35, 19);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(362, 65);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Tag = "";
            this.btnAnterior.Text = "←";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // frmRelUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelUsuario";
            this.Text = "frmRelUsuario";
            this.panelContainer.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelDataContainer.ResumeLayout(false);
            this.panelDataContainer.PerformLayout();
            this.panelNavBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TableLayoutPanel panelData;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel panelDataContainer;
        private System.Windows.Forms.TableLayoutPanel panelNavBtns;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
    }
}