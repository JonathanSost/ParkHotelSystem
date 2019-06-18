namespace ParkHotel
{
    partial class FormMenu
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
            this.btnLogoff = new System.Windows.Forms.Button();
            this.lblGerenciamento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.Relogio = new System.Windows.Forms.Timer(this.components);
            this.lnkProdutos = new System.Windows.Forms.LinkLabel();
            this.lnkClientes = new System.Windows.Forms.LinkLabel();
            this.lnkFornecedores = new System.Windows.Forms.LinkLabel();
            this.lnkQuartos = new System.Windows.Forms.LinkLabel();
            this.lnkFuncionarios = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.Location = new System.Drawing.Point(134, 409);
            this.btnLogoff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(138, 48);
            this.btnLogoff.TabIndex = 6;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // lblGerenciamento
            // 
            this.lblGerenciamento.AutoSize = true;
            this.lblGerenciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGerenciamento.Location = new System.Drawing.Point(52, 65);
            this.lblGerenciamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGerenciamento.Name = "lblGerenciamento";
            this.lblGerenciamento.Size = new System.Drawing.Size(119, 20);
            this.lblGerenciamento.TabIndex = 9;
            this.lblGerenciamento.Text = "Gerenciamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnLogoff);
            this.panel1.Controls.Add(this.lnkFuncionarios);
            this.panel1.Controls.Add(this.lblNomeFuncionario);
            this.panel1.Controls.Add(this.lnkQuartos);
            this.panel1.Controls.Add(this.lblNome2);
            this.panel1.Controls.Add(this.lnkFornecedores);
            this.panel1.Controls.Add(this.lblNome1);
            this.panel1.Controls.Add(this.lnkClientes);
            this.panel1.Controls.Add(this.lblGerenciamento);
            this.panel1.Controls.Add(this.lnkProdutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 468);
            this.panel1.TabIndex = 11;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(10, 437);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(12, 20);
            this.lblNomeFuncionario.TabIndex = 9;
            this.lblNomeFuncionario.Text = "l";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.Color.Gold;
            this.lblNome2.Location = new System.Drawing.Point(53, 13);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(63, 17);
            this.lblNome2.TabIndex = 11;
            this.lblNome2.Text = "Soninho";
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(10, 13);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(48, 17);
            this.lblNome1.TabIndex = 10;
            this.lblNome1.Text = "Santo";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(65, 384);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 20);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "label1";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(115, -2);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(157, 58);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "Minhas Informações";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Relogio
            // 
            this.Relogio.Enabled = true;
            this.Relogio.Interval = 1000;
            this.Relogio.Tick += new System.EventHandler(this.Relogio_Tick);
            // 
            // lnkProdutos
            // 
            this.lnkProdutos.AutoSize = true;
            this.lnkProdutos.Location = new System.Drawing.Point(78, 143);
            this.lnkProdutos.Name = "lnkProdutos";
            this.lnkProdutos.Size = new System.Drawing.Size(73, 20);
            this.lnkProdutos.TabIndex = 14;
            this.lnkProdutos.TabStop = true;
            this.lnkProdutos.Text = "Produtos";
            this.lnkProdutos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProdutos_LinkClicked);
            // 
            // lnkClientes
            // 
            this.lnkClientes.AutoSize = true;
            this.lnkClientes.Location = new System.Drawing.Point(78, 190);
            this.lnkClientes.Name = "lnkClientes";
            this.lnkClientes.Size = new System.Drawing.Size(66, 20);
            this.lnkClientes.TabIndex = 15;
            this.lnkClientes.TabStop = true;
            this.lnkClientes.Text = "Clientes";
            this.lnkClientes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClientes_LinkClicked);
            // 
            // lnkFornecedores
            // 
            this.lnkFornecedores.AutoSize = true;
            this.lnkFornecedores.Location = new System.Drawing.Point(78, 230);
            this.lnkFornecedores.Name = "lnkFornecedores";
            this.lnkFornecedores.Size = new System.Drawing.Size(108, 20);
            this.lnkFornecedores.TabIndex = 16;
            this.lnkFornecedores.TabStop = true;
            this.lnkFornecedores.Text = "Fornecedores";
            this.lnkFornecedores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFornecedores_LinkClicked);
            // 
            // lnkQuartos
            // 
            this.lnkQuartos.AutoSize = true;
            this.lnkQuartos.Location = new System.Drawing.Point(78, 276);
            this.lnkQuartos.Name = "lnkQuartos";
            this.lnkQuartos.Size = new System.Drawing.Size(66, 20);
            this.lnkQuartos.TabIndex = 17;
            this.lnkQuartos.TabStop = true;
            this.lnkQuartos.Text = "Quartos";
            this.lnkQuartos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkQuartos_LinkClicked);
            // 
            // lnkFuncionarios
            // 
            this.lnkFuncionarios.AutoSize = true;
            this.lnkFuncionarios.Location = new System.Drawing.Point(78, 322);
            this.lnkFuncionarios.Name = "lnkFuncionarios";
            this.lnkFuncionarios.Size = new System.Drawing.Size(100, 20);
            this.lnkFuncionarios.TabIndex = 18;
            this.lnkFuncionarios.TabStop = true;
            this.lnkFuncionarios.Text = "Funcionários";
            this.lnkFuncionarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFuncionarios_LinkClicked);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 468);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(962, 504);
            this.Name = "FormMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Menu";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Label lblGerenciamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer Relogio;
        private System.Windows.Forms.LinkLabel lnkProdutos;
        private System.Windows.Forms.LinkLabel lnkClientes;
        private System.Windows.Forms.LinkLabel lnkFornecedores;
        private System.Windows.Forms.LinkLabel lnkQuartos;
        private System.Windows.Forms.LinkLabel lnkFuncionarios;
    }
}