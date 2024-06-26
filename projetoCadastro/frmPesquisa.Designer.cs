namespace projetoCadastro
{
    partial class frmPesquisa
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
            this.header = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelSearchContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFieldName = new System.Windows.Forms.Label();
            this.txtCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.panelBtnsContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSearchContainer.SuspendLayout();
            this.panelBtnsContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(200, 6);
            this.header.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(195, 25);
            this.header.TabIndex = 0;
            this.header.Text = "Pesquisa Cadastro";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSearchContainer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelBtnsContainer, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 290);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelSearchContainer
            // 
            this.panelSearchContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSearchContainer.AutoSize = true;
            this.panelSearchContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSearchContainer.Controls.Add(this.labelFieldName);
            this.panelSearchContainer.Controls.Add(this.txtCaixaPesquisa);
            this.panelSearchContainer.Location = new System.Drawing.Point(81, 41);
            this.panelSearchContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSearchContainer.Name = "panelSearchContainer";
            this.panelSearchContainer.Size = new System.Drawing.Size(433, 30);
            this.panelSearchContainer.TabIndex = 1;
            // 
            // labelFieldName
            // 
            this.labelFieldName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFieldName.AutoSize = true;
            this.labelFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFieldName.Location = new System.Drawing.Point(4, 5);
            this.labelFieldName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFieldName.Name = "labelFieldName";
            this.labelFieldName.Size = new System.Drawing.Size(53, 20);
            this.labelFieldName.TabIndex = 0;
            this.labelFieldName.Text = "Nome";
            // 
            // txtCaixaPesquisa
            // 
            this.txtCaixaPesquisa.Location = new System.Drawing.Point(65, 4);
            this.txtCaixaPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCaixaPesquisa.Name = "txtCaixaPesquisa";
            this.txtCaixaPesquisa.Size = new System.Drawing.Size(364, 22);
            this.txtCaixaPesquisa.TabIndex = 1;
            // 
            // panelBtnsContainer
            // 
            this.panelBtnsContainer.Controls.Add(this.tableLayoutPanel2);
            this.panelBtnsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtnsContainer.Location = new System.Drawing.Point(4, 245);
            this.panelBtnsContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBtnsContainer.Name = "panelBtnsContainer";
            this.panelBtnsContainer.Size = new System.Drawing.Size(587, 41);
            this.panelBtnsContainer.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnPesquisar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSair, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(263, 41);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisar.Location = new System.Drawing.Point(4, 4);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(123, 33);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.Location = new System.Drawing.Point(135, 4);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(124, 33);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 290);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPesquisa";
            this.Text = "frmPesquisa";
            this.Load += new System.EventHandler(this.frmPesquisa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelSearchContainer.ResumeLayout(false);
            this.panelSearchContainer.PerformLayout();
            this.panelBtnsContainer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel panelSearchContainer;
        private System.Windows.Forms.Label labelFieldName;
        private System.Windows.Forms.TextBox txtCaixaPesquisa;
        private System.Windows.Forms.Panel panelBtnsContainer;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}