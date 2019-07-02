namespace ParkHotel
{
    partial class FormInfoFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoFuncionario));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCPFEditar = new System.Windows.Forms.Label();
            this.lblRGEditar = new System.Windows.Forms.Label();
            this.lblCEPEditar = new System.Windows.Forms.Label();
            this.lblTelefoneEditar = new System.Windows.Forms.Label();
            this.lblEstadoEditar = new System.Windows.Forms.Label();
            this.lblCidadeEditar = new System.Windows.Forms.Label();
            this.lblRuaEditar = new System.Windows.Forms.Label();
            this.lblBairroEditar = new System.Windows.Forms.Label();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.lblNumeroEditar = new System.Windows.Forms.Label();
            this.msktxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.msktxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.msktxtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(524, 315);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 46);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(32, 98);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(33, 150);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 3;
            this.lblRG.Text = "RG:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(33, 246);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(33, 198);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 5;
            this.lblCEP.Text = "CEP:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(225, 198);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 6;
            this.lblRua.Text = "Rua:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(225, 246);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 7;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(428, 198);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 8;
            this.lblNumero.Text = "Número:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(428, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(428, 150);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha:";
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(28, 315);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 46);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(28, 315);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(96, 46);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(26, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(72, 25);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(28, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(474, 29);
            this.txtNome.TabIndex = 39;
            this.txtNome.Visible = false;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(521, 9);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(48, 17);
            this.lblNome1.TabIndex = 70;
            this.lblNome1.Text = "Santo";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.Color.Gold;
            this.lblNome2.Location = new System.Drawing.Point(564, 9);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(63, 17);
            this.lblNome2.TabIndex = 71;
            this.lblNome2.Text = "Soninho";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(144, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 46);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCPFEditar
            // 
            this.lblCPFEditar.AutoSize = true;
            this.lblCPFEditar.Location = new System.Drawing.Point(32, 74);
            this.lblCPFEditar.Name = "lblCPFEditar";
            this.lblCPFEditar.Size = new System.Drawing.Size(30, 13);
            this.lblCPFEditar.TabIndex = 73;
            this.lblCPFEditar.Text = "CPF:";
            this.lblCPFEditar.Visible = false;
            // 
            // lblRGEditar
            // 
            this.lblRGEditar.AutoSize = true;
            this.lblRGEditar.Location = new System.Drawing.Point(33, 129);
            this.lblRGEditar.Name = "lblRGEditar";
            this.lblRGEditar.Size = new System.Drawing.Size(26, 13);
            this.lblRGEditar.TabIndex = 74;
            this.lblRGEditar.Text = "RG:";
            this.lblRGEditar.Visible = false;
            // 
            // lblCEPEditar
            // 
            this.lblCEPEditar.AutoSize = true;
            this.lblCEPEditar.Location = new System.Drawing.Point(31, 177);
            this.lblCEPEditar.Name = "lblCEPEditar";
            this.lblCEPEditar.Size = new System.Drawing.Size(31, 13);
            this.lblCEPEditar.TabIndex = 75;
            this.lblCEPEditar.Text = "CEP:";
            this.lblCEPEditar.Visible = false;
            // 
            // lblTelefoneEditar
            // 
            this.lblTelefoneEditar.AutoSize = true;
            this.lblTelefoneEditar.Location = new System.Drawing.Point(32, 222);
            this.lblTelefoneEditar.Name = "lblTelefoneEditar";
            this.lblTelefoneEditar.Size = new System.Drawing.Size(95, 13);
            this.lblTelefoneEditar.TabIndex = 76;
            this.lblTelefoneEditar.Text = "Telefone / Celular:";
            this.lblTelefoneEditar.Visible = false;
            // 
            // lblEstadoEditar
            // 
            this.lblEstadoEditar.AutoSize = true;
            this.lblEstadoEditar.Location = new System.Drawing.Point(225, 74);
            this.lblEstadoEditar.Name = "lblEstadoEditar";
            this.lblEstadoEditar.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoEditar.TabIndex = 77;
            this.lblEstadoEditar.Text = "Estado:";
            // 
            // lblCidadeEditar
            // 
            this.lblCidadeEditar.AutoSize = true;
            this.lblCidadeEditar.Location = new System.Drawing.Point(225, 129);
            this.lblCidadeEditar.Name = "lblCidadeEditar";
            this.lblCidadeEditar.Size = new System.Drawing.Size(43, 13);
            this.lblCidadeEditar.TabIndex = 78;
            this.lblCidadeEditar.Text = "Cidade:";
            // 
            // lblRuaEditar
            // 
            this.lblRuaEditar.AutoSize = true;
            this.lblRuaEditar.Location = new System.Drawing.Point(225, 173);
            this.lblRuaEditar.Name = "lblRuaEditar";
            this.lblRuaEditar.Size = new System.Drawing.Size(30, 13);
            this.lblRuaEditar.TabIndex = 79;
            this.lblRuaEditar.Text = "Rua:";
            this.lblRuaEditar.Visible = false;
            // 
            // lblBairroEditar
            // 
            this.lblBairroEditar.AutoSize = true;
            this.lblBairroEditar.Location = new System.Drawing.Point(225, 222);
            this.lblBairroEditar.Name = "lblBairroEditar";
            this.lblBairroEditar.Size = new System.Drawing.Size(37, 13);
            this.lblBairroEditar.TabIndex = 80;
            this.lblBairroEditar.Text = "Bairro:";
            this.lblBairroEditar.Visible = false;
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Location = new System.Drawing.Point(428, 74);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(38, 13);
            this.lblEmailEditar.TabIndex = 81;
            this.lblEmailEditar.Text = "E-mail:";
            this.lblEmailEditar.Visible = false;
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Location = new System.Drawing.Point(428, 129);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaEditar.TabIndex = 82;
            this.lblSenhaEditar.Text = "Senha:";
            this.lblSenhaEditar.Visible = false;
            // 
            // lblNumeroEditar
            // 
            this.lblNumeroEditar.AutoSize = true;
            this.lblNumeroEditar.Location = new System.Drawing.Point(428, 177);
            this.lblNumeroEditar.Name = "lblNumeroEditar";
            this.lblNumeroEditar.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroEditar.TabIndex = 83;
            this.lblNumeroEditar.Text = "Número:";
            this.lblNumeroEditar.Visible = false;
            // 
            // msktxtCEP
            // 
            this.msktxtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCEP.Location = new System.Drawing.Point(31, 190);
            this.msktxtCEP.Mask = "00000-000";
            this.msktxtCEP.Name = "msktxtCEP";
            this.msktxtCEP.Size = new System.Drawing.Size(92, 26);
            this.msktxtCEP.TabIndex = 94;
            this.msktxtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtCEP.Visible = false;
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtTelefone.Location = new System.Drawing.Point(31, 238);
            this.msktxtTelefone.Mask = "(00)00000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(126, 26);
            this.msktxtTelefone.TabIndex = 93;
            this.msktxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtTelefone.Visible = false;
            // 
            // msktxtCPF
            // 
            this.msktxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCPF.Location = new System.Drawing.Point(31, 90);
            this.msktxtCPF.Mask = "000,000,000-00";
            this.msktxtCPF.Name = "msktxtCPF";
            this.msktxtCPF.Size = new System.Drawing.Size(126, 26);
            this.msktxtCPF.TabIndex = 91;
            this.msktxtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtCPF.Visible = false;
            // 
            // msktxtRG
            // 
            this.msktxtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtRG.Location = new System.Drawing.Point(31, 142);
            this.msktxtRG.Mask = "0,000,000";
            this.msktxtRG.Name = "msktxtRG";
            this.msktxtRG.Size = new System.Drawing.Size(87, 26);
            this.msktxtRG.TabIndex = 92;
            this.msktxtRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtRG.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(428, 142);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(121, 26);
            this.txtSenha.TabIndex = 90;
            this.txtSenha.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(428, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 26);
            this.txtEmail.TabIndex = 89;
            this.txtEmail.Visible = false;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(225, 238);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(137, 26);
            this.txtBairro.TabIndex = 88;
            this.txtBairro.Visible = false;
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(225, 190);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(137, 26);
            this.txtRua.TabIndex = 87;
            this.txtRua.Visible = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(428, 190);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 26);
            this.txtNumero.TabIndex = 86;
            this.txtNumero.Visible = false;
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.Enabled = false;
            this.cmbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(225, 142);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(137, 28);
            this.cmbCidade.TabIndex = 85;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(225, 90);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(137, 28);
            this.cmbEstado.TabIndex = 84;
            // 
            // FormInfoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(639, 375);
            this.ControlBox = false;
            this.Controls.Add(this.msktxtCEP);
            this.Controls.Add(this.msktxtTelefone);
            this.Controls.Add(this.msktxtCPF);
            this.Controls.Add(this.msktxtRG);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblNumeroEditar);
            this.Controls.Add(this.lblSenhaEditar);
            this.Controls.Add(this.lblEmailEditar);
            this.Controls.Add(this.lblBairroEditar);
            this.Controls.Add(this.lblRuaEditar);
            this.Controls.Add(this.lblCidadeEditar);
            this.Controls.Add(this.lblEstadoEditar);
            this.Controls.Add(this.lblTelefoneEditar);
            this.Controls.Add(this.lblCEPEditar);
            this.Controls.Add(this.lblRGEditar);
            this.Controls.Add(this.lblCPFEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.btnVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormInfoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormInfoFuncionario_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCPFEditar;
        private System.Windows.Forms.Label lblRGEditar;
        private System.Windows.Forms.Label lblCEPEditar;
        private System.Windows.Forms.Label lblTelefoneEditar;
        private System.Windows.Forms.Label lblEstadoEditar;
        private System.Windows.Forms.Label lblCidadeEditar;
        private System.Windows.Forms.Label lblRuaEditar;
        private System.Windows.Forms.Label lblBairroEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
        private System.Windows.Forms.Label lblNumeroEditar;
        private System.Windows.Forms.MaskedTextBox msktxtCEP;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.MaskedTextBox msktxtCPF;
        private System.Windows.Forms.MaskedTextBox msktxtRG;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}