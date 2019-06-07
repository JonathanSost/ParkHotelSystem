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
            this.SuspendLayout();
            // 
            // btnGerProdutos
            // 
            this.btnGerProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerProdutos.Location = new System.Drawing.Point(36, 64);
            this.btnGerProdutos.Name = "btnGerProdutos";
            this.btnGerProdutos.Size = new System.Drawing.Size(123, 55);
            this.btnGerProdutos.TabIndex = 0;
            this.btnGerProdutos.Text = "Produtos";
            this.btnGerProdutos.UseVisualStyleBackColor = true;
            this.btnGerProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnGerClientes
            // 
            this.btnGerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerClientes.Location = new System.Drawing.Point(177, 64);
            this.btnGerClientes.Name = "btnGerClientes";
            this.btnGerClientes.Size = new System.Drawing.Size(123, 55);
            this.btnGerClientes.TabIndex = 1;
            this.btnGerClientes.Text = "Clientes";
            this.btnGerClientes.UseVisualStyleBackColor = true;
            this.btnGerClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnGerFornecedores
            // 
            this.btnGerFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerFornecedores.Location = new System.Drawing.Point(319, 64);
            this.btnGerFornecedores.Name = "btnGerFornecedores";
            this.btnGerFornecedores.Size = new System.Drawing.Size(123, 55);
            this.btnGerFornecedores.TabIndex = 2;
            this.btnGerFornecedores.Text = "Fornecedores";
            this.btnGerFornecedores.UseVisualStyleBackColor = true;
            this.btnGerFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnGerQuartos
            // 
            this.btnGerQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerQuartos.Location = new System.Drawing.Point(459, 64);
            this.btnGerQuartos.Name = "btnGerQuartos";
            this.btnGerQuartos.Size = new System.Drawing.Size(123, 55);
            this.btnGerQuartos.TabIndex = 3;
            this.btnGerQuartos.Text = "Quartos";
            this.btnGerQuartos.UseVisualStyleBackColor = true;
            this.btnGerQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(559, 262);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(92, 31);
            this.btnLogoff.TabIndex = 4;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnRegQuartos
            // 
            this.btnRegQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegQuartos.Location = new System.Drawing.Point(459, 184);
            this.btnRegQuartos.Name = "btnRegQuartos";
            this.btnRegQuartos.Size = new System.Drawing.Size(123, 55);
            this.btnRegQuartos.TabIndex = 8;
            this.btnRegQuartos.Text = "Quartos";
            this.btnRegQuartos.UseVisualStyleBackColor = true;
            this.btnRegQuartos.Click += new System.EventHandler(this.btnRegQuartos_Click);
            // 
            // btnRegFornecedores
            // 
            this.btnRegFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegFornecedores.Location = new System.Drawing.Point(319, 184);
            this.btnRegFornecedores.Name = "btnRegFornecedores";
            this.btnRegFornecedores.Size = new System.Drawing.Size(123, 55);
            this.btnRegFornecedores.TabIndex = 7;
            this.btnRegFornecedores.Text = "Fornecedores";
            this.btnRegFornecedores.UseVisualStyleBackColor = true;
            this.btnRegFornecedores.Click += new System.EventHandler(this.btnRegFornecedores_Click);
            // 
            // btnRegClientes
            // 
            this.btnRegClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegClientes.Location = new System.Drawing.Point(177, 184);
            this.btnRegClientes.Name = "btnRegClientes";
            this.btnRegClientes.Size = new System.Drawing.Size(123, 55);
            this.btnRegClientes.TabIndex = 6;
            this.btnRegClientes.Text = "Clientes";
            this.btnRegClientes.UseVisualStyleBackColor = true;
            this.btnRegClientes.Click += new System.EventHandler(this.btnRegClientes_Click);
            // 
            // btnRegProdutos
            // 
            this.btnRegProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegProdutos.Location = new System.Drawing.Point(36, 184);
            this.btnRegProdutos.Name = "btnRegProdutos";
            this.btnRegProdutos.Size = new System.Drawing.Size(123, 55);
            this.btnRegProdutos.TabIndex = 5;
            this.btnRegProdutos.Text = "Produtos";
            this.btnRegProdutos.UseVisualStyleBackColor = true;
            this.btnRegProdutos.Click += new System.EventHandler(this.btnRegProdutos_Click);
            // 
            // lblGerenciamento
            // 
            this.lblGerenciamento.AutoSize = true;
            this.lblGerenciamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamento.Location = new System.Drawing.Point(244, 30);
            this.lblGerenciamento.Name = "lblGerenciamento";
            this.lblGerenciamento.Size = new System.Drawing.Size(119, 20);
            this.lblGerenciamento.TabIndex = 9;
            this.lblGerenciamento.Text = "Gerenciamento";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(263, 147);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(79, 24);
            this.lblRegistro.TabIndex = 10;
            this.lblRegistro.Text = "Registro";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 305);
            this.ControlBox = false;
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblGerenciamento);
            this.Controls.Add(this.btnRegQuartos);
            this.Controls.Add(this.btnRegFornecedores);
            this.Controls.Add(this.btnRegClientes);
            this.Controls.Add(this.btnRegProdutos);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnGerQuartos);
            this.Controls.Add(this.btnGerFornecedores);
            this.Controls.Add(this.btnGerClientes);
            this.Controls.Add(this.btnGerProdutos);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
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
    }
}