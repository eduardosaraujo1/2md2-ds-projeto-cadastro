namespace projetoCadastro
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.inputCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.inputRG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputTelefone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputCPF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputEstado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputCEP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBairro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputEndereco = new System.Windows.Forms.TextBox();
            this.panelCampos = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBtns = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.panelCampos.SuspendLayout();
            this.tableLayoutPanelBtns.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.Location = new System.Drawing.Point(465, 53);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 44);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimir.Location = new System.Drawing.Point(357, 53);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 44);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisar.Location = new System.Drawing.Point(249, 53);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 44);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(141, 53);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 44);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvar.Location = new System.Drawing.Point(141, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 44);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Location = new System.Drawing.Point(465, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(106, 44);
            this.btnExcluir.TabIndex = 20;
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
            this.btnAlterar.TabIndex = 18;
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
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProximo.Location = new System.Drawing.Point(33, 53);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(102, 44);
            this.btnProximo.TabIndex = 14;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnterior.Location = new System.Drawing.Point(33, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(102, 44);
            this.btnAnterior.TabIndex = 12;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // inputCodigo
            // 
            this.inputCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCodigo.Enabled = false;
            this.inputCodigo.Location = new System.Drawing.Point(78, 4);
            this.inputCodigo.Name = "inputCodigo";
            this.inputCodigo.Size = new System.Drawing.Size(127, 23);
            this.inputCodigo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputNome
            // 
            this.inputNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCampos.SetColumnSpan(this.inputNome, 3);
            this.inputNome.Location = new System.Drawing.Point(78, 36);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(330, 23);
            this.inputNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "RG";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputRG
            // 
            this.inputRG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputRG.Location = new System.Drawing.Point(281, 198);
            this.inputRG.Name = "inputRG";
            this.inputRG.Size = new System.Drawing.Size(127, 23);
            this.inputRG.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Telefone";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputTelefone
            // 
            this.inputTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCampos.SetColumnSpan(this.inputTelefone, 2);
            this.inputTelefone.Location = new System.Drawing.Point(281, 132);
            this.inputTelefone.Name = "inputTelefone";
            this.inputTelefone.Size = new System.Drawing.Size(185, 23);
            this.inputTelefone.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "CPF";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputCPF
            // 
            this.inputCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCPF.Location = new System.Drawing.Point(78, 198);
            this.inputCPF.Name = "inputCPF";
            this.inputCPF.Size = new System.Drawing.Size(127, 23);
            this.inputCPF.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputEmail
            // 
            this.inputEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCampos.SetColumnSpan(this.inputEmail, 3);
            this.inputEmail.Location = new System.Drawing.Point(78, 164);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(330, 23);
            this.inputEmail.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputEstado
            // 
            this.inputEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inputEstado.Location = new System.Drawing.Point(472, 100);
            this.inputEstado.Name = "inputEstado";
            this.inputEstado.Size = new System.Drawing.Size(129, 23);
            this.inputEstado.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "CEP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputCEP
            // 
            this.inputCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCEP.Location = new System.Drawing.Point(78, 132);
            this.inputCEP.Name = "inputCEP";
            this.inputCEP.Size = new System.Drawing.Size(127, 23);
            this.inputCEP.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cidade";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputCidade
            // 
            this.inputCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCidade.Location = new System.Drawing.Point(281, 100);
            this.inputCidade.Name = "inputCidade";
            this.inputCidade.Size = new System.Drawing.Size(127, 23);
            this.inputCidade.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bairro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputBairro
            // 
            this.inputBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBairro.Location = new System.Drawing.Point(78, 100);
            this.inputBairro.Name = "inputBairro";
            this.inputBairro.Size = new System.Drawing.Size(127, 23);
            this.inputBairro.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Endereço";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputEndereco
            // 
            this.inputEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCampos.SetColumnSpan(this.inputEndereco, 5);
            this.inputEndereco.Location = new System.Drawing.Point(78, 68);
            this.inputEndereco.Name = "inputEndereco";
            this.inputEndereco.Size = new System.Drawing.Size(523, 23);
            this.inputEndereco.TabIndex = 3;
            // 
            // panelCampos
            // 
            this.panelCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCampos.ColumnCount = 6;
            this.panelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelCampos.Controls.Add(this.label4, 0, 0);
            this.panelCampos.Controls.Add(this.label3, 0, 1);
            this.panelCampos.Controls.Add(this.label1, 0, 2);
            this.panelCampos.Controls.Add(this.inputTelefone, 3, 4);
            this.panelCampos.Controls.Add(this.label10, 2, 4);
            this.panelCampos.Controls.Add(this.inputCodigo, 1, 0);
            this.panelCampos.Controls.Add(this.inputNome, 1, 1);
            this.panelCampos.Controls.Add(this.inputCPF, 1, 6);
            this.panelCampos.Controls.Add(this.label9, 0, 6);
            this.panelCampos.Controls.Add(this.inputEmail, 1, 5);
            this.panelCampos.Controls.Add(this.inputEndereco, 1, 2);
            this.panelCampos.Controls.Add(this.inputCEP, 1, 4);
            this.panelCampos.Controls.Add(this.label2, 0, 3);
            this.panelCampos.Controls.Add(this.label8, 0, 5);
            this.panelCampos.Controls.Add(this.inputBairro, 1, 3);
            this.panelCampos.Controls.Add(this.label5, 2, 3);
            this.panelCampos.Controls.Add(this.inputEstado, 5, 3);
            this.panelCampos.Controls.Add(this.label7, 4, 3);
            this.panelCampos.Controls.Add(this.label11, 2, 6);
            this.panelCampos.Controls.Add(this.inputRG, 3, 6);
            this.panelCampos.Controls.Add(this.inputCidade, 3, 3);
            this.panelCampos.Controls.Add(this.label6, 0, 4);
            this.panelCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCampos.Location = new System.Drawing.Point(0, 39);
            this.panelCampos.Margin = new System.Windows.Forms.Padding(2);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.RowCount = 7;
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelCampos.Size = new System.Drawing.Size(604, 228);
            this.panelCampos.TabIndex = 23;
            // 
            // tableLayoutPanelBtns
            // 
            this.tableLayoutPanelBtns.ColumnCount = 5;
            this.tableLayoutPanelBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBtns.Controls.Add(this.btnAnterior, 0, 0);
            this.tableLayoutPanelBtns.Controls.Add(this.btnSair, 4, 1);
            this.tableLayoutPanelBtns.Controls.Add(this.btnExcluir, 4, 0);
            this.tableLayoutPanelBtns.Controls.Add(this.btnImprimir, 3, 1);
            this.tableLayoutPanelBtns.Controls.Add(this.btnPesquisar, 2, 1);
            this.tableLayoutPanelBtns.Controls.Add(this.btnProximo, 0, 1);
            this.tableLayoutPanelBtns.Controls.Add(this.btnAlterar, 3, 0);
            this.tableLayoutPanelBtns.Controls.Add(this.btnCancelar, 1, 1);
            this.tableLayoutPanelBtns.Controls.Add(this.btnNovo, 2, 0);
            this.tableLayoutPanelBtns.Controls.Add(this.btnSalvar, 1, 0);
            this.tableLayoutPanelBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelBtns.Location = new System.Drawing.Point(0, 276);
            this.tableLayoutPanelBtns.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelBtns.Name = "tableLayoutPanelBtns";
            this.tableLayoutPanelBtns.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.tableLayoutPanelBtns.RowCount = 2;
            this.tableLayoutPanelBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBtns.Size = new System.Drawing.Size(604, 100);
            this.tableLayoutPanelBtns.TabIndex = 24;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label14);
            this.panelMain.Controls.Add(this.panelCampos);
            this.panelMain.Controls.Add(this.tableLayoutPanelBtns);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(604, 376);
            this.panelMain.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 26);
            this.label14.TabIndex = 25;
            this.label14.Text = "Cadastro Cliente";
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
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 376);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(620, 415);
            this.Name = "frmCliente";
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.tableLayoutPanelBtns.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.TextBox inputCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox inputRG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputTelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputCPF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputCEP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBairro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputEndereco;
        private System.Windows.Forms.TableLayoutPanel panelCampos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBtns;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}