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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lnkFuncionarioLogado = new System.Windows.Forms.LinkLabel();
            this.lnkReservas = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkVendas = new System.Windows.Forms.LinkLabel();
            this.lnkHistórico = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.Location = new System.Drawing.Point(301, 442);
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
            this.lblGerenciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamento.ForeColor = System.Drawing.Color.Black;
            this.lblGerenciamento.Location = new System.Drawing.Point(135, 62);
            this.lblGerenciamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGerenciamento.Name = "lblGerenciamento";
            this.lblGerenciamento.Size = new System.Drawing.Size(158, 25);
            this.lblGerenciamento.TabIndex = 0;
            this.lblGerenciamento.Text = "Gerenciamento";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(5, 469);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 20);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "label1";
            // 
            // lnkFuncionarios
            // 
            this.lnkFuncionarios.AutoSize = true;
            this.lnkFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFuncionarios.LinkColor = System.Drawing.Color.Crimson;
            this.lnkFuncionarios.Location = new System.Drawing.Point(157, 394);
            this.lnkFuncionarios.Name = "lnkFuncionarios";
            this.lnkFuncionarios.Size = new System.Drawing.Size(133, 20);
            this.lnkFuncionarios.TabIndex = 5;
            this.lnkFuncionarios.TabStop = true;
            this.lnkFuncionarios.Text = "Funcionários (F7)";
            this.lnkFuncionarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFuncionarios_LinkClicked);
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(265, 9);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(11, 16);
            this.lblNomeFuncionario.TabIndex = 9;
            this.lblNomeFuncionario.Text = "l";
            // 
            // lnkQuartos
            // 
            this.lnkQuartos.AutoSize = true;
            this.lnkQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkQuartos.LinkColor = System.Drawing.Color.Crimson;
            this.lnkQuartos.Location = new System.Drawing.Point(158, 256);
            this.lnkQuartos.Name = "lnkQuartos";
            this.lnkQuartos.Size = new System.Drawing.Size(99, 20);
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
            this.lnkFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFornecedores.LinkColor = System.Drawing.Color.Crimson;
            this.lnkFornecedores.Location = new System.Drawing.Point(158, 214);
            this.lnkFornecedores.Name = "lnkFornecedores";
            this.lnkFornecedores.Size = new System.Drawing.Size(141, 20);
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
            this.lnkClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClientes.LinkColor = System.Drawing.Color.Crimson;
            this.lnkClientes.Location = new System.Drawing.Point(158, 170);
            this.lnkClientes.Name = "lnkClientes";
            this.lnkClientes.Size = new System.Drawing.Size(99, 20);
            this.lnkClientes.TabIndex = 2;
            this.lnkClientes.TabStop = true;
            this.lnkClientes.Text = "Clientes (F2)";
            this.lnkClientes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClientes_LinkClicked);
            // 
            // lnkProdutos
            // 
            this.lnkProdutos.AutoSize = true;
            this.lnkProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkProdutos.LinkColor = System.Drawing.Color.Crimson;
            this.lnkProdutos.Location = new System.Drawing.Point(157, 128);
            this.lnkProdutos.Name = "lnkProdutos";
            this.lnkProdutos.Size = new System.Drawing.Size(106, 20);
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
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(139, 129);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(15, 20);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "*";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(140, 171);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(15, 20);
            this.lbl2.TabIndex = 20;
            this.lbl2.Text = "*";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(140, 215);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(15, 20);
            this.lbl3.TabIndex = 21;
            this.lbl3.Text = "*";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(140, 257);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(15, 20);
            this.lbl4.TabIndex = 22;
            this.lbl4.Text = "*";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(139, 395);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(15, 20);
            this.lbl5.TabIndex = 23;
            this.lbl5.Text = "*";
            // 
            // lnkFuncionarioLogado
            // 
            this.lnkFuncionarioLogado.AutoSize = true;
            this.lnkFuncionarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFuncionarioLogado.LinkColor = System.Drawing.Color.Blue;
            this.lnkFuncionarioLogado.Location = new System.Drawing.Point(340, 8);
            this.lnkFuncionarioLogado.Name = "lnkFuncionarioLogado";
            this.lnkFuncionarioLogado.Size = new System.Drawing.Size(11, 16);
            this.lnkFuncionarioLogado.TabIndex = 24;
            this.lnkFuncionarioLogado.TabStop = true;
            this.lnkFuncionarioLogado.Text = ".";
            this.lnkFuncionarioLogado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFuncionarioLogado_LinkClicked);
            // 
            // lnkReservas
            // 
            this.lnkReservas.AutoSize = true;
            this.lnkReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReservas.LinkColor = System.Drawing.Color.Crimson;
            this.lnkReservas.Location = new System.Drawing.Point(158, 302);
            this.lnkReservas.Name = "lnkReservas";
            this.lnkReservas.Size = new System.Drawing.Size(109, 20);
            this.lnkReservas.TabIndex = 25;
            this.lnkReservas.TabStop = true;
            this.lnkReservas.Text = "Reservas (F5)";
            this.lnkReservas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReservas_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "*";
            // 
            // lnkVendas
            // 
            this.lnkVendas.AutoSize = true;
            this.lnkVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkVendas.LinkColor = System.Drawing.Color.Crimson;
            this.lnkVendas.Location = new System.Drawing.Point(158, 348);
            this.lnkVendas.Name = "lnkVendas";
            this.lnkVendas.Size = new System.Drawing.Size(97, 20);
            this.lnkVendas.TabIndex = 27;
            this.lnkVendas.TabStop = true;
            this.lnkVendas.Text = "Vendas (F6)";
            this.lnkVendas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVendas_LinkClicked);
            // 
            // lnkHistórico
            // 
            this.lnkHistórico.AutoSize = true;
            this.lnkHistórico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHistórico.LinkColor = System.Drawing.Color.Crimson;
            this.lnkHistórico.Location = new System.Drawing.Point(279, 128);
            this.lnkHistórico.Name = "lnkHistórico";
            this.lnkHistórico.Size = new System.Drawing.Size(79, 20);
            this.lnkHistórico.TabIndex = 29;
            this.lnkHistórico.TabStop = true;
            this.lnkHistórico.Text = "[Histórico]";
            this.lnkHistórico.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHistórico_LinkClicked);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(452, 504);
            this.ControlBox = false;
            this.Controls.Add(this.lnkHistórico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkVendas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkReservas);
            this.Controls.Add(this.lnkFuncionarioLogado);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(962, 504);
            this.Name = "FormMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
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
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.LinkLabel lnkFuncionarioLogado;
        private System.Windows.Forms.LinkLabel lnkReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkVendas;
        private System.Windows.Forms.LinkLabel lnkHistórico;
    }
}