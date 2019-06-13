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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerProdutos
            // 
            this.btnGerProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerProdutos.Location = new System.Drawing.Point(54, 82);
            this.btnGerProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerProdutos.Name = "btnGerProdutos";
            this.btnGerProdutos.Size = new System.Drawing.Size(184, 85);
            this.btnGerProdutos.TabIndex = 0;
            this.btnGerProdutos.Text = "Produtos";
            this.btnGerProdutos.UseVisualStyleBackColor = true;
            this.btnGerProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnGerClientes
            // 
            this.btnGerClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerClientes.Location = new System.Drawing.Point(266, 82);
            this.btnGerClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerClientes.Name = "btnGerClientes";
            this.btnGerClientes.Size = new System.Drawing.Size(184, 85);
            this.btnGerClientes.TabIndex = 1;
            this.btnGerClientes.Text = "Clientes";
            this.btnGerClientes.UseVisualStyleBackColor = true;
            this.btnGerClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnGerFornecedores
            // 
            this.btnGerFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerFornecedores.Location = new System.Drawing.Point(478, 82);
            this.btnGerFornecedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerFornecedores.Name = "btnGerFornecedores";
            this.btnGerFornecedores.Size = new System.Drawing.Size(184, 85);
            this.btnGerFornecedores.TabIndex = 2;
            this.btnGerFornecedores.Text = "Fornecedores";
            this.btnGerFornecedores.UseVisualStyleBackColor = true;
            this.btnGerFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnGerQuartos
            // 
            this.btnGerQuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerQuartos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerQuartos.Location = new System.Drawing.Point(688, 82);
            this.btnGerQuartos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerQuartos.Name = "btnGerQuartos";
            this.btnGerQuartos.Size = new System.Drawing.Size(184, 85);
            this.btnGerQuartos.TabIndex = 3;
            this.btnGerQuartos.Text = "Quartos";
            this.btnGerQuartos.UseVisualStyleBackColor = true;
            this.btnGerQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.Location = new System.Drawing.Point(802, 8);
            this.btnLogoff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(138, 48);
            this.btnLogoff.TabIndex = 8;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = false;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnRegQuartos
            // 
            this.btnRegQuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegQuartos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegQuartos.Location = new System.Drawing.Point(688, 292);
            this.btnRegQuartos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegQuartos.Name = "btnRegQuartos";
            this.btnRegQuartos.Size = new System.Drawing.Size(184, 85);
            this.btnRegQuartos.TabIndex = 7;
            this.btnRegQuartos.Text = "Quartos";
            this.btnRegQuartos.UseVisualStyleBackColor = true;
            this.btnRegQuartos.Click += new System.EventHandler(this.btnRegQuartos_Click);
            // 
            // btnRegFornecedores
            // 
            this.btnRegFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegFornecedores.Location = new System.Drawing.Point(478, 292);
            this.btnRegFornecedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegFornecedores.Name = "btnRegFornecedores";
            this.btnRegFornecedores.Size = new System.Drawing.Size(184, 85);
            this.btnRegFornecedores.TabIndex = 6;
            this.btnRegFornecedores.Text = "Fornecedores";
            this.btnRegFornecedores.UseVisualStyleBackColor = true;
            this.btnRegFornecedores.Click += new System.EventHandler(this.btnRegFornecedores_Click);
            // 
            // btnRegClientes
            // 
            this.btnRegClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegClientes.Location = new System.Drawing.Point(266, 292);
            this.btnRegClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegClientes.Name = "btnRegClientes";
            this.btnRegClientes.Size = new System.Drawing.Size(184, 85);
            this.btnRegClientes.TabIndex = 5;
            this.btnRegClientes.Text = "Clientes";
            this.btnRegClientes.UseVisualStyleBackColor = true;
            this.btnRegClientes.Click += new System.EventHandler(this.btnRegClientes_Click);
            // 
            // btnRegProdutos
            // 
            this.btnRegProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegProdutos.Location = new System.Drawing.Point(54, 292);
            this.btnRegProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegProdutos.Name = "btnRegProdutos";
            this.btnRegProdutos.Size = new System.Drawing.Size(184, 85);
            this.btnRegProdutos.TabIndex = 4;
            this.btnRegProdutos.Text = "Produtos";
            this.btnRegProdutos.UseVisualStyleBackColor = true;
            this.btnRegProdutos.Click += new System.EventHandler(this.btnRegProdutos_Click);
            // 
            // lblGerenciamento
            // 
            this.lblGerenciamento.AutoSize = true;
            this.lblGerenciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGerenciamento.Location = new System.Drawing.Point(423, 19);
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
            this.lblRegistro.Location = new System.Drawing.Point(446, 18);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(79, 24);
            this.lblRegistro.TabIndex = 10;
            this.lblRegistro.Text = "Registro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblGerenciamento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 63);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnLogoff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 63);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblRegistro);
            this.panel3.Location = new System.Drawing.Point(0, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(963, 63);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(979, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - - - - - - - - - - - - - - - - - - - - - - - - - - ";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 465);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegQuartos);
            this.Controls.Add(this.btnRegFornecedores);
            this.Controls.Add(this.btnRegClientes);
            this.Controls.Add(this.btnRegProdutos);
            this.Controls.Add(this.btnGerQuartos);
            this.Controls.Add(this.btnGerFornecedores);
            this.Controls.Add(this.btnGerClientes);
            this.Controls.Add(this.btnGerProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(979, 504);
            this.MinimumSize = new System.Drawing.Size(979, 504);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}