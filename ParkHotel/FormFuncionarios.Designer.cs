namespace ParkHotel
{
    partial class FormFuncionarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionarios));
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.msktxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.msktxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.msktxtRG = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAdministrador = new System.Windows.Forms.CheckBox();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.picbRefresh = new System.Windows.Forms.PictureBox();
            this.btnPesquisarAdmin = new System.Windows.Forms.Button();
            this.btnPesquisarPorRua = new System.Windows.Forms.Button();
            this.btnPesquisarPorBairro = new System.Windows.Forms.Button();
            this.btnPesquisarPorCEP = new System.Windows.Forms.Button();
            this.btnPesquisarPorCidade = new System.Windows.Forms.Button();
            this.btnPesquisarPorEstado = new System.Windows.Forms.Button();
            this.btnPesquisarPorRG = new System.Windows.Forms.Button();
            this.btnPesquisarPorCPF = new System.Windows.Forms.Button();
            this.btnPesquisarPorNome = new System.Windows.Forms.Button();
            this.picbClear = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClear)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.dgvFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.RowTemplate.Height = 24;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(924, 132);
            this.dgvFuncionarios.TabIndex = 150;
            this.dgvFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellContentClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(127, 136);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 52);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(250, 136);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 52);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(3, 135);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 52);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "Afonso Cláudio"});
            this.cmbCidade.Location = new System.Drawing.Point(220, 262);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(204, 28);
            this.cmbCidade.TabIndex = 8;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "SC",
            "RS",
            "SP",
            "AC"});
            this.cmbEstado.Location = new System.Drawing.Point(220, 213);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(204, 28);
            this.cmbEstado.TabIndex = 7;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // msktxtCEP
            // 
            this.msktxtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCEP.Location = new System.Drawing.Point(220, 315);
            this.msktxtCEP.Mask = "00000-000";
            this.msktxtCEP.Name = "msktxtCEP";
            this.msktxtCEP.Size = new System.Drawing.Size(92, 26);
            this.msktxtCEP.TabIndex = 9;
            this.msktxtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtCEP.TextChanged += new System.EventHandler(this.msktxtCEP_TextChanged);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(220, 555);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(204, 26);
            this.txtComplemento.TabIndex = 13;
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(220, 499);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(204, 26);
            this.txtNumero.TabIndex = 12;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(225, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 116;
            this.label10.Text = "Rua";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(225, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 115;
            this.label11.Text = "Bairro";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(220, 439);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(204, 26);
            this.txtRua.TabIndex = 11;
            this.txtRua.TextChanged += new System.EventHandler(this.txtRua_TextChanged);
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(220, 373);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(204, 26);
            this.txtBairro.TabIndex = 10;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 101;
            this.label3.Text = "ID";
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtTelefone.Location = new System.Drawing.Point(7, 439);
            this.msktxtTelefone.Mask = "(99)00000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(126, 26);
            this.msktxtTelefone.TabIndex = 4;
            this.msktxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtTelefone.TextChanged += new System.EventHandler(this.msktxtTelefone_TextChanged);
            // 
            // msktxtCPF
            // 
            this.msktxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCPF.Location = new System.Drawing.Point(7, 315);
            this.msktxtCPF.Mask = "000,000,000-00";
            this.msktxtCPF.Name = "msktxtCPF";
            this.msktxtCPF.Size = new System.Drawing.Size(126, 26);
            this.msktxtCPF.TabIndex = 2;
            this.msktxtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtCPF.TextChanged += new System.EventHandler(this.msktxtCPF_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(7, 262);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // msktxtRG
            // 
            this.msktxtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtRG.Location = new System.Drawing.Point(7, 373);
            this.msktxtRG.Mask = "0,000,000";
            this.msktxtRG.Name = "msktxtRG";
            this.msktxtRG.Size = new System.Drawing.Size(87, 26);
            this.msktxtRG.TabIndex = 3;
            this.msktxtRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtRG.TextChanged += new System.EventHandler(this.msktxtRG_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 484);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 106;
            this.label7.Text = "E-Mail";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(7, 213);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(168, 26);
            this.txtID.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(7, 499);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(7, 555);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(168, 26);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 540);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 125;
            this.label6.Text = "Senha";
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.AutoSize = true;
            this.chkAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdministrador.Location = new System.Drawing.Point(466, 555);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(130, 24);
            this.chkAdministrador.TabIndex = 14;
            this.chkAdministrador.Text = " Administrador";
            this.chkAdministrador.UseVisualStyleBackColor = true;
            this.chkAdministrador.CheckedChanged += new System.EventHandler(this.chkAdministrador_CheckedChanged);
            this.chkAdministrador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkAdministrador_KeyUp);
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Matura MT Script Capitals", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.Color.Gold;
            this.lblNome2.Location = new System.Drawing.Point(488, 356);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(409, 127);
            this.lblNome2.TabIndex = 131;
            this.lblNome2.Text = "Soninho";
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Matura MT Script Capitals", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(542, 249);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(316, 127);
            this.lblNome1.TabIndex = 130;
            this.lblNome1.Text = "Santo";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(767, 551);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 39);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(225, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 132;
            this.label15.Text = "Estado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(228, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 134;
            this.label12.Text = "Cidade";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(228, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 20);
            this.label16.TabIndex = 133;
            this.label16.Text = "CEP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(228, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 20);
            this.label8.TabIndex = 136;
            this.label8.Text = "Complemento (Opcional)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(228, 484);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 135;
            this.label13.Text = "Número";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 357);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 139;
            this.label9.Text = "RG";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 299);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 20);
            this.label17.TabIndex = 137;
            this.label17.Text = "CPF";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 423);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 20);
            this.label18.TabIndex = 140;
            this.label18.Text = "Telefone";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 247);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 20);
            this.label19.TabIndex = 138;
            this.label19.Text = "Nome";
            // 
            // picbRefresh
            // 
            this.picbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbRefresh.Image = global::ParkHotel.Properties.Resources.a;
            this.picbRefresh.Location = new System.Drawing.Point(882, 137);
            this.picbRefresh.Name = "picbRefresh";
            this.picbRefresh.Size = new System.Drawing.Size(30, 30);
            this.picbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbRefresh.TabIndex = 160;
            this.picbRefresh.TabStop = false;
            this.picbRefresh.Click += new System.EventHandler(this.picbRefresh_Click);
            // 
            // btnPesquisarAdmin
            // 
            this.btnPesquisarAdmin.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarAdmin.Location = new System.Drawing.Point(602, 551);
            this.btnPesquisarAdmin.Name = "btnPesquisarAdmin";
            this.btnPesquisarAdmin.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarAdmin.TabIndex = 159;
            this.btnPesquisarAdmin.UseVisualStyleBackColor = true;
            this.btnPesquisarAdmin.Click += new System.EventHandler(this.btnPesquisarAdmin_Click);
            // 
            // btnPesquisarPorRua
            // 
            this.btnPesquisarPorRua.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorRua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorRua.Location = new System.Drawing.Point(430, 439);
            this.btnPesquisarPorRua.Name = "btnPesquisarPorRua";
            this.btnPesquisarPorRua.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorRua.TabIndex = 158;
            this.btnPesquisarPorRua.UseVisualStyleBackColor = true;
            this.btnPesquisarPorRua.Click += new System.EventHandler(this.btnPesquisarPorRua_Click);
            // 
            // btnPesquisarPorBairro
            // 
            this.btnPesquisarPorBairro.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorBairro.Location = new System.Drawing.Point(430, 374);
            this.btnPesquisarPorBairro.Name = "btnPesquisarPorBairro";
            this.btnPesquisarPorBairro.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorBairro.TabIndex = 157;
            this.btnPesquisarPorBairro.UseVisualStyleBackColor = true;
            this.btnPesquisarPorBairro.Click += new System.EventHandler(this.btnPesquisarPorBairro_Click);
            // 
            // btnPesquisarPorCEP
            // 
            this.btnPesquisarPorCEP.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorCEP.Location = new System.Drawing.Point(318, 316);
            this.btnPesquisarPorCEP.Name = "btnPesquisarPorCEP";
            this.btnPesquisarPorCEP.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorCEP.TabIndex = 156;
            this.btnPesquisarPorCEP.UseVisualStyleBackColor = true;
            this.btnPesquisarPorCEP.Click += new System.EventHandler(this.btnPesquisarPorCEP_Click);
            // 
            // btnPesquisarPorCidade
            // 
            this.btnPesquisarPorCidade.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorCidade.Location = new System.Drawing.Point(430, 262);
            this.btnPesquisarPorCidade.Name = "btnPesquisarPorCidade";
            this.btnPesquisarPorCidade.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorCidade.TabIndex = 155;
            this.btnPesquisarPorCidade.UseVisualStyleBackColor = true;
            this.btnPesquisarPorCidade.Click += new System.EventHandler(this.btnPesquisarPorCidade_Click);
            // 
            // btnPesquisarPorEstado
            // 
            this.btnPesquisarPorEstado.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorEstado.Location = new System.Drawing.Point(430, 213);
            this.btnPesquisarPorEstado.Name = "btnPesquisarPorEstado";
            this.btnPesquisarPorEstado.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorEstado.TabIndex = 154;
            this.btnPesquisarPorEstado.UseVisualStyleBackColor = true;
            this.btnPesquisarPorEstado.Click += new System.EventHandler(this.btnPesquisarPorEstado_Click);
            // 
            // btnPesquisarPorRG
            // 
            this.btnPesquisarPorRG.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorRG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorRG.Location = new System.Drawing.Point(100, 374);
            this.btnPesquisarPorRG.Name = "btnPesquisarPorRG";
            this.btnPesquisarPorRG.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorRG.TabIndex = 153;
            this.btnPesquisarPorRG.UseVisualStyleBackColor = true;
            this.btnPesquisarPorRG.Click += new System.EventHandler(this.btnPesquisarPorRG_Click);
            // 
            // btnPesquisarPorCPF
            // 
            this.btnPesquisarPorCPF.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorCPF.Location = new System.Drawing.Point(139, 316);
            this.btnPesquisarPorCPF.Name = "btnPesquisarPorCPF";
            this.btnPesquisarPorCPF.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorCPF.TabIndex = 152;
            this.btnPesquisarPorCPF.UseVisualStyleBackColor = true;
            this.btnPesquisarPorCPF.Click += new System.EventHandler(this.btnPesquisarPorCPF_Click);
            // 
            // btnPesquisarPorNome
            // 
            this.btnPesquisarPorNome.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorNome.Location = new System.Drawing.Point(180, 263);
            this.btnPesquisarPorNome.Name = "btnPesquisarPorNome";
            this.btnPesquisarPorNome.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorNome.TabIndex = 151;
            this.btnPesquisarPorNome.UseVisualStyleBackColor = true;
            this.btnPesquisarPorNome.Click += new System.EventHandler(this.btnPesquisarPorNome_Click);
            // 
            // picbClear
            // 
            this.picbClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbClear.Image = global::ParkHotel.Properties.Resources.lvasivdnlkvndbçslnzbihçbp_gspi;
            this.picbClear.Location = new System.Drawing.Point(882, 173);
            this.picbClear.Name = "picbClear";
            this.picbClear.Size = new System.Drawing.Size(30, 35);
            this.picbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbClear.TabIndex = 161;
            this.picbClear.TabStop = false;
            this.picbClear.Click += new System.EventHandler(this.picbClear_Click);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 602);
            this.ControlBox = false;
            this.Controls.Add(this.picbClear);
            this.Controls.Add(this.picbRefresh);
            this.Controls.Add(this.btnPesquisarAdmin);
            this.Controls.Add(this.btnPesquisarPorRua);
            this.Controls.Add(this.btnPesquisarPorBairro);
            this.Controls.Add(this.btnPesquisarPorCEP);
            this.Controls.Add(this.btnPesquisarPorCidade);
            this.Controls.Add(this.btnPesquisarPorEstado);
            this.Controls.Add(this.btnPesquisarPorRG);
            this.Controls.Add(this.btnPesquisarPorCPF);
            this.Controls.Add(this.btnPesquisarPorNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.chkAdministrador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSenha);
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
            this.Controls.Add(this.msktxtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.msktxtRG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGerFuncionarios";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormFuncionarios_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.MaskedTextBox msktxtCEP;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.MaskedTextBox msktxtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox msktxtRG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAdministrador;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnPesquisarPorNome;
        private System.Windows.Forms.Button btnPesquisarPorCPF;
        private System.Windows.Forms.Button btnPesquisarPorRG;
        private System.Windows.Forms.Button btnPesquisarPorEstado;
        private System.Windows.Forms.Button btnPesquisarPorCidade;
        private System.Windows.Forms.Button btnPesquisarPorCEP;
        private System.Windows.Forms.Button btnPesquisarPorBairro;
        private System.Windows.Forms.Button btnPesquisarPorRua;
        private System.Windows.Forms.Button btnPesquisarAdmin;
        private System.Windows.Forms.PictureBox picbRefresh;
        private System.Windows.Forms.PictureBox picbClear;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}