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
            this.lblHora = new System.Windows.Forms.Label();
            this.lnkFuncionarios = new System.Windows.Forms.LinkLabel();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lnkQuartos = new System.Windows.Forms.LinkLabel();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lnkFornecedores = new System.Windows.Forms.LinkLabel();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lnkClientes = new System.Windows.Forms.LinkLabel();
            this.lnkProdutos = new System.Windows.Forms.LinkLabel();
            this.Relogio = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkFuncionarioLogado = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.Location = new System.Drawing.Point(301, 390);
            this.btnLogoff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(138, 48);
            this.btnLogoff.TabIndex = 7;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // lblGerenciamento
            // 
            this.lblGerenciamento.AutoSize = true;
            this.lblGerenciamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamento.ForeColor = System.Drawing.Color.Black;
            this.lblGerenciamento.Location = new System.Drawing.Point(54, 61);
            this.lblGerenciamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGerenciamento.Name = "lblGerenciamento";
            this.lblGerenciamento.Size = new System.Drawing.Size(135, 21);
            this.lblGerenciamento.TabIndex = 0;
            this.lblGerenciamento.Text = "Gerenciamento";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(5, 404);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(65, 22);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "label1";
            // 
            // lnkFuncionarios
            // 
            this.lnkFuncionarios.AutoSize = true;
            this.lnkFuncionarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFuncionarios.LinkColor = System.Drawing.Color.Blue;
            this.lnkFuncionarios.Location = new System.Drawing.Point(54, 296);
            this.lnkFuncionarios.Name = "lnkFuncionarios";
            this.lnkFuncionarios.Size = new System.Drawing.Size(139, 21);
            this.lnkFuncionarios.TabIndex = 5;
            this.lnkFuncionarios.TabStop = true;
            this.lnkFuncionarios.Text = "Funcionários (F5)";
            this.lnkFuncionarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFuncionarios_LinkClicked);
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(265, 9);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(11, 17);
            this.lblNomeFuncionario.TabIndex = 9;
            this.lblNomeFuncionario.Text = "l";
            // 
            // lnkQuartos
            // 
            this.lnkQuartos.AutoSize = true;
            this.lnkQuartos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkQuartos.LinkColor = System.Drawing.Color.Blue;
            this.lnkQuartos.Location = new System.Drawing.Point(55, 255);
            this.lnkQuartos.Name = "lnkQuartos";
            this.lnkQuartos.Size = new System.Drawing.Size(106, 21);
            this.lnkQuartos.TabIndex = 4;
            this.lnkQuartos.TabStop = true;
            this.lnkQuartos.Text = "Quartos (F4)";
            this.lnkQuartos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkQuartos_LinkClicked);
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.Color.Gold;
            this.lblNome2.Location = new System.Drawing.Point(55, 9);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(63, 17);
            this.lblNome2.TabIndex = 11;
            this.lblNome2.Text = "Soninho";
            // 
            // lnkFornecedores
            // 
            this.lnkFornecedores.AutoSize = true;
            this.lnkFornecedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFornecedores.LinkColor = System.Drawing.Color.Blue;
            this.lnkFornecedores.Location = new System.Drawing.Point(55, 213);
            this.lnkFornecedores.Name = "lnkFornecedores";
            this.lnkFornecedores.Size = new System.Drawing.Size(148, 21);
            this.lnkFornecedores.TabIndex = 3;
            this.lnkFornecedores.TabStop = true;
            this.lnkFornecedores.Text = "Fornecedores (F3)";
            this.lnkFornecedores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFornecedores_LinkClicked);
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(12, 9);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(48, 17);
            this.lblNome1.TabIndex = 10;
            this.lblNome1.Text = "Santo";
            // 
            // lnkClientes
            // 
            this.lnkClientes.AutoSize = true;
            this.lnkClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClientes.LinkColor = System.Drawing.Color.Blue;
            this.lnkClientes.Location = new System.Drawing.Point(55, 169);
            this.lnkClientes.Name = "lnkClientes";
            this.lnkClientes.Size = new System.Drawing.Size(105, 21);
            this.lnkClientes.TabIndex = 2;
            this.lnkClientes.TabStop = true;
            this.lnkClientes.Text = "Clientes (F2)";
            this.lnkClientes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClientes_LinkClicked);
            // 
            // lnkProdutos
            // 
            this.lnkProdutos.AutoSize = true;
            this.lnkProdutos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkProdutos.LinkColor = System.Drawing.Color.Blue;
            this.lnkProdutos.Location = new System.Drawing.Point(54, 127);
            this.lnkProdutos.Name = "lnkProdutos";
            this.lnkProdutos.Size = new System.Drawing.Size(111, 21);
            this.lnkProdutos.TabIndex = 1;
            this.lnkProdutos.TabStop = true;
            this.lnkProdutos.Text = "Produtos (F1)";
            this.lnkProdutos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProdutos_LinkClicked);
            // 
            // Relogio
            // 
            this.Relogio.Enabled = true;
            this.Relogio.Interval = 1000;
            this.Relogio.Tick += new System.EventHandler(this.Relogio_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "*";
            // 
            // lnkFuncionarioLogado
            // 
            this.lnkFuncionarioLogado.AutoSize = true;
            this.lnkFuncionarioLogado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFuncionarioLogado.LinkColor = System.Drawing.Color.Blue;
            this.lnkFuncionarioLogado.Location = new System.Drawing.Point(345, 7);
            this.lnkFuncionarioLogado.Name = "lnkFuncionarioLogado";
            this.lnkFuncionarioLogado.Size = new System.Drawing.Size(12, 17);
            this.lnkFuncionarioLogado.TabIndex = 24;
            this.lnkFuncionarioLogado.TabStop = true;
            this.lnkFuncionarioLogado.Text = ".";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(452, 454);
            this.ControlBox = false;
            this.Controls.Add(this.lnkFuncionarioLogado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.lnkProdutos);
            this.Controls.Add(this.lnkFuncionarios);
            this.Controls.Add(this.lblGerenciamento);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.lnkClientes);
            this.Controls.Add(this.lnkQuartos);
            this.Controls.Add(this.lnkFornecedores);
            this.Controls.Add(this.lblNome2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Label lblGerenciamento;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer Relogio;
        private System.Windows.Forms.LinkLabel lnkProdutos;
        private System.Windows.Forms.LinkLabel lnkClientes;
        private System.Windows.Forms.LinkLabel lnkFornecedores;
        private System.Windows.Forms.LinkLabel lnkQuartos;
        private System.Windows.Forms.LinkLabel lnkFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkFuncionarioLogado;
    }
}