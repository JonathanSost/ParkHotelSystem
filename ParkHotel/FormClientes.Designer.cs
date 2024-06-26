﻿namespace ParkHotel
{
    partial class FormClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.msktxtRG = new System.Windows.Forms.MaskedTextBox();
            this.msktxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.msktxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.msktxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picbClear = new System.Windows.Forms.PictureBox();
            this.picbRefresh = new System.Windows.Forms.PictureBox();
            this.btnPesquisarPorCPF = new System.Windows.Forms.Button();
            this.btnPesquisarPorRG = new System.Windows.Forms.Button();
            this.btnPesquisarPorCidade = new System.Windows.Forms.Button();
            this.btnPesquisarPorRua = new System.Windows.Forms.Button();
            this.btnPesquisarPorBairro = new System.Windows.Forms.Button();
            this.btnPesquisarPorCEP = new System.Windows.Forms.Button();
            this.btnPesquisarPorEstado = new System.Windows.Forms.Button();
            this.btnPesquisarPorNome = new System.Windows.Forms.Button();
            this.lnkOrderByName = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkOrderByNameDesc = new System.Windows.Forms.LinkLabel();
            this.lnkOrderByIDDesc = new System.Windows.Forms.LinkLabel();
            this.lnkOrderByID = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(767, 551);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 39);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(22, 228);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(168, 26);
            this.txtID.TabIndex = 0;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(924, 132);
            this.dgvClientes.TabIndex = 25;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(22, 277);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(127, 136);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 52);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(250, 136);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 52);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(3, 135);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 52);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 555);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(22, 570);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 26);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // msktxtRG
            // 
            this.msktxtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtRG.Location = new System.Drawing.Point(22, 388);
            this.msktxtRG.Mask = "0,000,000";
            this.msktxtRG.Name = "msktxtRG";
            this.msktxtRG.Size = new System.Drawing.Size(91, 26);
            this.msktxtRG.TabIndex = 3;
            this.msktxtRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtRG.Click += new System.EventHandler(this.msktxtRG_Click);
            this.msktxtRG.TextChanged += new System.EventHandler(this.msktxtRG_TextChanged);
            // 
            // msktxtCPF
            // 
            this.msktxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCPF.Location = new System.Drawing.Point(22, 330);
            this.msktxtCPF.Mask = "000,000,000-00";
            this.msktxtCPF.Name = "msktxtCPF";
            this.msktxtCPF.Size = new System.Drawing.Size(120, 26);
            this.msktxtCPF.TabIndex = 2;
            this.msktxtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtCPF.Click += new System.EventHandler(this.msktxtCPF_Click);
            this.msktxtCPF.TextChanged += new System.EventHandler(this.msktxtCPF_TextChanged);
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtTelefone.Location = new System.Drawing.Point(22, 454);
            this.msktxtTelefone.Mask = "(99)00000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(130, 26);
            this.msktxtTelefone.TabIndex = 4;
            this.msktxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtTelefone.TextChanged += new System.EventHandler(this.msktxtTelefone_TextChanged);
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownHeight = 90;
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.IntegralHeight = false;
            this.cmbCidade.Items.AddRange(new object[] {
            "Afonso Cláudio"});
            this.cmbCidade.Location = new System.Drawing.Point(234, 277);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(204, 28);
            this.cmbCidade.TabIndex = 8;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownHeight = 90;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.Items.AddRange(new object[] {
            "SC",
            "RS",
            "SP",
            "AC"});
            this.cmbEstado.Location = new System.Drawing.Point(234, 228);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(204, 28);
            this.cmbEstado.TabIndex = 7;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // msktxtCEP
            // 
            this.msktxtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCEP.Location = new System.Drawing.Point(234, 330);
            this.msktxtCEP.Mask = "00000-000";
            this.msktxtCEP.Name = "msktxtCEP";
            this.msktxtCEP.Size = new System.Drawing.Size(90, 26);
            this.msktxtCEP.TabIndex = 9;
            this.msktxtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtCEP.TextChanged += new System.EventHandler(this.msktxtCEP_TextChanged);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(234, 570);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(204, 26);
            this.txtComplemento.TabIndex = 13;
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(234, 514);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(204, 26);
            this.txtNumero.TabIndex = 12;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(239, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 86;
            this.label10.Text = "Rua";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(239, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 85;
            this.label11.Text = "Bairro";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(234, 454);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(204, 26);
            this.txtRua.TabIndex = 11;
            this.txtRua.TextChanged += new System.EventHandler(this.txtRua_TextChanged);
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(234, 388);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(204, 26);
            this.txtBairro.TabIndex = 10;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Matura MT Script Capitals", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(542, 249);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(316, 127);
            this.lblNome1.TabIndex = 94;
            this.lblNome1.Text = "Santo";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Matura MT Script Capitals", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.Color.Gold;
            this.lblNome2.Location = new System.Drawing.Point(488, 356);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(409, 127);
            this.lblNome2.TabIndex = 95;
            this.lblNome2.Text = "Soninho";
            // 
            // msktxtCelular
            // 
            this.msktxtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCelular.Location = new System.Drawing.Point(25, 514);
            this.msktxtCelular.Mask = "(99)00000-0000";
            this.msktxtCelular.Name = "msktxtCelular";
            this.msktxtCelular.Size = new System.Drawing.Size(127, 26);
            this.msktxtCelular.TabIndex = 5;
            this.msktxtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtCelular.TextChanged += new System.EventHandler(this.msktxtCelular_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(239, 498);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 97;
            this.label14.Text = "Número";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 555);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 20);
            this.label9.TabIndex = 98;
            this.label9.Text = "Complemento (Opcional)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 371);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 20);
            this.label15.TabIndex = 101;
            this.label15.Text = "RG";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 313);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 20);
            this.label16.TabIndex = 99;
            this.label16.Text = "CPF";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 437);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 20);
            this.label17.TabIndex = 102;
            this.label17.Text = "Telefone";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(24, 261);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 20);
            this.label18.TabIndex = 100;
            this.label18.Text = "Nome";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 497);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 20);
            this.label19.TabIndex = 103;
            this.label19.Text = "Celular (Opcional)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 106;
            this.label1.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 104;
            this.label4.Text = "CEP";
            // 
            // picbClear
            // 
            this.picbClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbClear.Image = global::ParkHotel.Properties.Resources.lvasivdnlkvndbçslnzbihçbp_gspi;
            this.picbClear.Location = new System.Drawing.Point(882, 173);
            this.picbClear.Name = "picbClear";
            this.picbClear.Size = new System.Drawing.Size(30, 35);
            this.picbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbClear.TabIndex = 122;
            this.picbClear.TabStop = false;
            this.picbClear.Click += new System.EventHandler(this.picbClear_Click);
            // 
            // picbRefresh
            // 
            this.picbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbRefresh.Image = global::ParkHotel.Properties.Resources.a;
            this.picbRefresh.Location = new System.Drawing.Point(882, 137);
            this.picbRefresh.Name = "picbRefresh";
            this.picbRefresh.Size = new System.Drawing.Size(30, 30);
            this.picbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbRefresh.TabIndex = 121;
            this.picbRefresh.TabStop = false;
            this.picbRefresh.Click += new System.EventHandler(this.picbRefresh_Click);
            // 
            // btnPesquisarPorCPF
            // 
            this.btnPesquisarPorCPF.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorCPF.Location = new System.Drawing.Point(148, 328);
            this.btnPesquisarPorCPF.Name = "btnPesquisarPorCPF";
            this.btnPesquisarPorCPF.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorCPF.TabIndex = 120;
            this.btnPesquisarPorCPF.UseVisualStyleBackColor = true;
            this.btnPesquisarPorCPF.Click += new System.EventHandler(this.btnPesquisarPorCPF_Click);
            // 
            // btnPesquisarPorRG
            // 
            this.btnPesquisarPorRG.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorRG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorRG.Location = new System.Drawing.Point(119, 388);
            this.btnPesquisarPorRG.Name = "btnPesquisarPorRG";
            this.btnPesquisarPorRG.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorRG.TabIndex = 119;
            this.btnPesquisarPorRG.UseVisualStyleBackColor = true;
            this.btnPesquisarPorRG.Click += new System.EventHandler(this.btnPesquisarPorRG_Click);
            // 
            // btnPesquisarPorCidade
            // 
            this.btnPesquisarPorCidade.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorCidade.Location = new System.Drawing.Point(444, 279);
            this.btnPesquisarPorCidade.Name = "btnPesquisarPorCidade";
            this.btnPesquisarPorCidade.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorCidade.TabIndex = 116;
            this.btnPesquisarPorCidade.UseVisualStyleBackColor = true;
            this.btnPesquisarPorCidade.Click += new System.EventHandler(this.btnPesquisarPorCidade_Click);
            // 
            // btnPesquisarPorRua
            // 
            this.btnPesquisarPorRua.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorRua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorRua.Location = new System.Drawing.Point(444, 454);
            this.btnPesquisarPorRua.Name = "btnPesquisarPorRua";
            this.btnPesquisarPorRua.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorRua.TabIndex = 115;
            this.btnPesquisarPorRua.UseVisualStyleBackColor = true;
            this.btnPesquisarPorRua.Click += new System.EventHandler(this.btnPesquisarPorRua_Click);
            // 
            // btnPesquisarPorBairro
            // 
            this.btnPesquisarPorBairro.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorBairro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPesquisarPorBairro.Location = new System.Drawing.Point(444, 388);
            this.btnPesquisarPorBairro.Name = "btnPesquisarPorBairro";
            this.btnPesquisarPorBairro.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorBairro.TabIndex = 110;
            this.btnPesquisarPorBairro.UseVisualStyleBackColor = true;
            this.btnPesquisarPorBairro.Click += new System.EventHandler(this.btnPesquisarPorBairro_Click);
            // 
            // btnPesquisarPorCEP
            // 
            this.btnPesquisarPorCEP.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorCEP.Location = new System.Drawing.Point(330, 330);
            this.btnPesquisarPorCEP.Name = "btnPesquisarPorCEP";
            this.btnPesquisarPorCEP.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorCEP.TabIndex = 109;
            this.btnPesquisarPorCEP.UseVisualStyleBackColor = true;
            this.btnPesquisarPorCEP.Click += new System.EventHandler(this.btnPesquisarPorCEP_Click);
            // 
            // btnPesquisarPorEstado
            // 
            this.btnPesquisarPorEstado.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorEstado.Location = new System.Drawing.Point(444, 230);
            this.btnPesquisarPorEstado.Name = "btnPesquisarPorEstado";
            this.btnPesquisarPorEstado.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorEstado.TabIndex = 108;
            this.btnPesquisarPorEstado.UseVisualStyleBackColor = true;
            this.btnPesquisarPorEstado.Click += new System.EventHandler(this.btnPesquisarPorEstado_Click);
            // 
            // btnPesquisarPorNome
            // 
            this.btnPesquisarPorNome.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorNome.Location = new System.Drawing.Point(195, 277);
            this.btnPesquisarPorNome.Name = "btnPesquisarPorNome";
            this.btnPesquisarPorNome.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorNome.TabIndex = 107;
            this.btnPesquisarPorNome.UseVisualStyleBackColor = true;
            this.btnPesquisarPorNome.Click += new System.EventHandler(this.btnPesquisarPorNome_Click);
            // 
            // lnkOrderByName
            // 
            this.lnkOrderByName.AutoSize = true;
            this.lnkOrderByName.Location = new System.Drawing.Point(596, 148);
            this.lnkOrderByName.Name = "lnkOrderByName";
            this.lnkOrderByName.Size = new System.Drawing.Size(35, 13);
            this.lnkOrderByName.TabIndex = 123;
            this.lnkOrderByName.TabStop = true;
            this.lnkOrderByName.Text = "Nome";
            this.lnkOrderByName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOrderByName_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 124;
            this.label5.Text = "Ordenar Por:";
            // 
            // lnkOrderByNameDesc
            // 
            this.lnkOrderByNameDesc.AutoSize = true;
            this.lnkOrderByNameDesc.Location = new System.Drawing.Point(596, 173);
            this.lnkOrderByNameDesc.Name = "lnkOrderByNameDesc";
            this.lnkOrderByNameDesc.Size = new System.Drawing.Size(63, 13);
            this.lnkOrderByNameDesc.TabIndex = 125;
            this.lnkOrderByNameDesc.TabStop = true;
            this.lnkOrderByNameDesc.Text = "Nome Desc";
            this.lnkOrderByNameDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOrderByNameDesc_LinkClicked);
            // 
            // lnkOrderByIDDesc
            // 
            this.lnkOrderByIDDesc.AutoSize = true;
            this.lnkOrderByIDDesc.Location = new System.Drawing.Point(524, 173);
            this.lnkOrderByIDDesc.Name = "lnkOrderByIDDesc";
            this.lnkOrderByIDDesc.Size = new System.Drawing.Size(46, 13);
            this.lnkOrderByIDDesc.TabIndex = 127;
            this.lnkOrderByIDDesc.TabStop = true;
            this.lnkOrderByIDDesc.Text = "ID Desc";
            this.lnkOrderByIDDesc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOrderByIDDesc_LinkClicked);
            // 
            // lnkOrderByID
            // 
            this.lnkOrderByID.AutoSize = true;
            this.lnkOrderByID.Location = new System.Drawing.Point(524, 148);
            this.lnkOrderByID.Name = "lnkOrderByID";
            this.lnkOrderByID.Size = new System.Drawing.Size(18, 13);
            this.lnkOrderByID.TabIndex = 126;
            this.lnkOrderByID.TabStop = true;
            this.lnkOrderByID.Text = "ID";
            this.lnkOrderByID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOrderByID_LinkClicked);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 602);
            this.ControlBox = false;
            this.Controls.Add(this.lnkOrderByIDDesc);
            this.Controls.Add(this.lnkOrderByID);
            this.Controls.Add(this.lnkOrderByNameDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnkOrderByName);
            this.Controls.Add(this.picbClear);
            this.Controls.Add(this.picbRefresh);
            this.Controls.Add(this.btnPesquisarPorCPF);
            this.Controls.Add(this.btnPesquisarPorRG);
            this.Controls.Add(this.btnPesquisarPorCidade);
            this.Controls.Add(this.btnPesquisarPorRua);
            this.Controls.Add(this.btnPesquisarPorBairro);
            this.Controls.Add(this.btnPesquisarPorCEP);
            this.Controls.Add(this.btnPesquisarPorEstado);
            this.Controls.Add(this.btnPesquisarPorNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.msktxtCelular);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.msktxtCEP);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msktxtTelefone);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.msktxtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.msktxtRG);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dgvClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox msktxtRG;
        private System.Windows.Forms.MaskedTextBox msktxtCPF;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.MaskedTextBox msktxtCEP;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.MaskedTextBox msktxtCelular;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisarPorNome;
        private System.Windows.Forms.Button btnPesquisarPorEstado;
        private System.Windows.Forms.Button btnPesquisarPorCEP;
        private System.Windows.Forms.Button btnPesquisarPorBairro;
        private System.Windows.Forms.Button btnPesquisarPorRua;
        private System.Windows.Forms.Button btnPesquisarPorCidade;
        private System.Windows.Forms.Button btnPesquisarPorRG;
        private System.Windows.Forms.Button btnPesquisarPorCPF;
        private System.Windows.Forms.PictureBox picbRefresh;
        private System.Windows.Forms.PictureBox picbClear;
        private System.Windows.Forms.LinkLabel lnkOrderByName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkOrderByNameDesc;
        private System.Windows.Forms.LinkLabel lnkOrderByIDDesc;
        private System.Windows.Forms.LinkLabel lnkOrderByID;
    }
}