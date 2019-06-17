﻿namespace ParkHotel
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
            this.btnGerProdutos = new System.Windows.Forms.Button();
            this.btnGerClientes = new System.Windows.Forms.Button();
            this.btnGerFornecedores = new System.Windows.Forms.Button();
            this.btnGerQuartos = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnRegQuartos = new System.Windows.Forms.Button();
            this.btnRegFornecedores = new System.Windows.Forms.Button();
            this.btnRegClientes = new System.Windows.Forms.Button();
            this.btnRegProdutos = new System.Windows.Forms.Button();
            this.lblGerenciamento = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.Relogio = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGerFuncionarios = new System.Windows.Forms.Button();
            this.btnRegFuncionarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerProdutos
            // 
            this.btnGerProdutos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGerProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerProdutos.Location = new System.Drawing.Point(100, 104);
            this.btnGerProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerProdutos.Name = "btnGerProdutos";
            this.btnGerProdutos.Size = new System.Drawing.Size(130, 37);
            this.btnGerProdutos.TabIndex = 7;
            this.btnGerProdutos.Text = "Produtos";
            this.btnGerProdutos.UseVisualStyleBackColor = false;
            this.btnGerProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnGerClientes
            // 
            this.btnGerClientes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGerClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerClientes.Location = new System.Drawing.Point(46, 172);
            this.btnGerClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerClientes.Name = "btnGerClientes";
            this.btnGerClientes.Size = new System.Drawing.Size(130, 37);
            this.btnGerClientes.TabIndex = 2;
            this.btnGerClientes.Text = "Clientes";
            this.btnGerClientes.UseVisualStyleBackColor = false;
            this.btnGerClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnGerFornecedores
            // 
            this.btnGerFornecedores.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGerFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerFornecedores.Location = new System.Drawing.Point(46, 241);
            this.btnGerFornecedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerFornecedores.Name = "btnGerFornecedores";
            this.btnGerFornecedores.Size = new System.Drawing.Size(130, 37);
            this.btnGerFornecedores.TabIndex = 3;
            this.btnGerFornecedores.Text = "Fornecedores";
            this.btnGerFornecedores.UseVisualStyleBackColor = false;
            this.btnGerFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnGerQuartos
            // 
            this.btnGerQuartos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGerQuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerQuartos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerQuartos.Location = new System.Drawing.Point(46, 304);
            this.btnGerQuartos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerQuartos.Name = "btnGerQuartos";
            this.btnGerQuartos.Size = new System.Drawing.Size(130, 37);
            this.btnGerQuartos.TabIndex = 4;
            this.btnGerQuartos.Text = "Quartos";
            this.btnGerQuartos.UseVisualStyleBackColor = false;
            this.btnGerQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.Location = new System.Drawing.Point(66, 5);
            this.btnLogoff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(138, 48);
            this.btnLogoff.TabIndex = 6;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnRegQuartos
            // 
            this.btnRegQuartos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegQuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegQuartos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegQuartos.Location = new System.Drawing.Point(100, 304);
            this.btnRegQuartos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegQuartos.Name = "btnRegQuartos";
            this.btnRegQuartos.Size = new System.Drawing.Size(130, 37);
            this.btnRegQuartos.TabIndex = 10;
            this.btnRegQuartos.Text = "Quartos";
            this.btnRegQuartos.UseVisualStyleBackColor = false;
            this.btnRegQuartos.Click += new System.EventHandler(this.btnRegQuartos_Click);
            // 
            // btnRegFornecedores
            // 
            this.btnRegFornecedores.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegFornecedores.Location = new System.Drawing.Point(100, 241);
            this.btnRegFornecedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegFornecedores.Name = "btnRegFornecedores";
            this.btnRegFornecedores.Size = new System.Drawing.Size(130, 37);
            this.btnRegFornecedores.TabIndex = 9;
            this.btnRegFornecedores.Text = "Fornecedores";
            this.btnRegFornecedores.UseVisualStyleBackColor = false;
            this.btnRegFornecedores.Click += new System.EventHandler(this.btnRegFornecedores_Click);
            // 
            // btnRegClientes
            // 
            this.btnRegClientes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegClientes.Location = new System.Drawing.Point(100, 172);
            this.btnRegClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegClientes.Name = "btnRegClientes";
            this.btnRegClientes.Size = new System.Drawing.Size(130, 37);
            this.btnRegClientes.TabIndex = 8;
            this.btnRegClientes.Text = "Clientes";
            this.btnRegClientes.UseVisualStyleBackColor = false;
            this.btnRegClientes.Click += new System.EventHandler(this.btnRegClientes_Click);
            // 
            // btnRegProdutos
            // 
            this.btnRegProdutos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegProdutos.Location = new System.Drawing.Point(46, 104);
            this.btnRegProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegProdutos.Name = "btnRegProdutos";
            this.btnRegProdutos.Size = new System.Drawing.Size(130, 37);
            this.btnRegProdutos.TabIndex = 1;
            this.btnRegProdutos.Text = "Produtos";
            this.btnRegProdutos.UseVisualStyleBackColor = false;
            this.btnRegProdutos.Click += new System.EventHandler(this.btnRegProdutos_Click);
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
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegistro.Location = new System.Drawing.Point(125, 61);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(79, 24);
            this.lblRegistro.TabIndex = 10;
            this.lblRegistro.Text = "Registro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNomeFuncionario);
            this.panel1.Controls.Add(this.btnGerFuncionarios);
            this.panel1.Controls.Add(this.lblNome2);
            this.panel1.Controls.Add(this.lblNome1);
            this.panel1.Controls.Add(this.lblGerenciamento);
            this.panel1.Controls.Add(this.btnRegProdutos);
            this.panel1.Controls.Add(this.btnGerClientes);
            this.panel1.Controls.Add(this.btnGerFornecedores);
            this.panel1.Controls.Add(this.btnGerQuartos);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnLogoff);
            this.panel2.Location = new System.Drawing.Point(354, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 60);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnRegFuncionarios);
            this.panel3.Controls.Add(this.lblHora);
            this.panel3.Controls.Add(this.lblRegistro);
            this.panel3.Controls.Add(this.btnGerProdutos);
            this.panel3.Controls.Add(this.btnRegClientes);
            this.panel3.Controls.Add(this.btnRegQuartos);
            this.panel3.Controls.Add(this.btnRegFornecedores);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(680, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 468);
            this.panel3.TabIndex = 12;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(13, 439);
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
            this.btnInfo.Location = new System.Drawing.Point(131, 19);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btnInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(280, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 100);
            this.panel4.TabIndex = 13;
            // 
            // btnGerFuncionarios
            // 
            this.btnGerFuncionarios.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGerFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerFuncionarios.Location = new System.Drawing.Point(46, 364);
            this.btnGerFuncionarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerFuncionarios.Name = "btnGerFuncionarios";
            this.btnGerFuncionarios.Size = new System.Drawing.Size(130, 37);
            this.btnGerFuncionarios.TabIndex = 14;
            this.btnGerFuncionarios.Text = "Funcionários";
            this.btnGerFuncionarios.UseVisualStyleBackColor = false;
            this.btnGerFuncionarios.Click += new System.EventHandler(this.btnGerFuncionarios_Click);
            // 
            // btnRegFuncionarios
            // 
            this.btnRegFuncionarios.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegFuncionarios.Location = new System.Drawing.Point(100, 364);
            this.btnRegFuncionarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegFuncionarios.Name = "btnRegFuncionarios";
            this.btnRegFuncionarios.Size = new System.Drawing.Size(130, 37);
            this.btnRegFuncionarios.TabIndex = 15;
            this.btnRegFuncionarios.Text = "Funcionários";
            this.btnRegFuncionarios.UseVisualStyleBackColor = false;
            this.btnRegFuncionarios.Click += new System.EventHandler(this.btnRegFuncionarios_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 468);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(962, 504);
            this.Name = "FormMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerProdutos;
        private System.Windows.Forms.Button btnGerClientes;
        private System.Windows.Forms.Button btnGerFornecedores;
        private System.Windows.Forms.Button btnGerQuartos;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnRegQuartos;
        private System.Windows.Forms.Button btnRegFornecedores;
        private System.Windows.Forms.Button btnRegClientes;
        private System.Windows.Forms.Button btnRegProdutos;
        private System.Windows.Forms.Label lblGerenciamento;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer Relogio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGerFuncionarios;
        private System.Windows.Forms.Button btnRegFuncionarios;
    }
}