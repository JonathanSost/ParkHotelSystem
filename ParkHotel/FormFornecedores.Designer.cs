namespace ParkHotel
{
    partial class FormFornecedores
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.msktxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picbClear = new System.Windows.Forms.PictureBox();
            this.picbRefresh = new System.Windows.Forms.PictureBox();
            this.btnPesquisarPorNomeEmpresa = new System.Windows.Forms.Button();
            this.PesquisarPorCNPJ = new System.Windows.Forms.Button();
            this.btnPesquisarPorNomeContato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 215);
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
            this.txtID.Location = new System.Drawing.Point(33, 230);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(126, 26);
            this.txtID.TabIndex = 0;
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFornecedores.Location = new System.Drawing.Point(0, 0);
            this.dgvFornecedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.RowHeadersVisible = false;
            this.dgvFornecedores.RowTemplate.Height = 24;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(656, 132);
            this.dgvFornecedores.TabIndex = 25;
            this.dgvFornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedores_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome da Empresa";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(31, 283);
            this.txtNomeEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(151, 26);
            this.txtNomeEmpresa.TabIndex = 1;
            this.txtNomeEmpresa.TextChanged += new System.EventHandler(this.txtNomeEmpresa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(31, 390);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(128, 26);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 478);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(31, 495);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(125, 136);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 52);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(254, 136);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 52);
            this.btnEditar.TabIndex = 8;
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
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(520, 521);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 39);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Matura MT Script Capitals", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.Color.Gold;
            this.lblNome2.Location = new System.Drawing.Point(241, 326);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(409, 127);
            this.lblNome2.TabIndex = 97;
            this.lblNome2.Text = "Soninho";
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Matura MT Script Capitals", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(295, 219);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(316, 127);
            this.lblNome1.TabIndex = 96;
            this.lblNome1.Text = "Santo";
            // 
            // msktxtCNPJ
            // 
            this.msktxtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCNPJ.Location = new System.Drawing.Point(31, 338);
            this.msktxtCNPJ.Mask = "99,999,999/9999-99";
            this.msktxtCNPJ.Name = "msktxtCNPJ";
            this.msktxtCNPJ.Size = new System.Drawing.Size(151, 26);
            this.msktxtCNPJ.TabIndex = 2;
            this.msktxtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtCNPJ.TextChanged += new System.EventHandler(this.msktxtCNPJ_TextChanged);
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtTelefone.Location = new System.Drawing.Point(33, 444);
            this.msktxtTelefone.Mask = "(00)09999-9999";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(126, 26);
            this.msktxtTelefone.TabIndex = 4;
            this.msktxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtTelefone.TextChanged += new System.EventHandler(this.msktxtTelefone_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 100;
            this.label7.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 101;
            this.label2.Text = "Telefone";
            // 
            // picbClear
            // 
            this.picbClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbClear.Image = global::ParkHotel.Properties.Resources.lvasivdnlkvndbçslnzbihçbp_gspi;
            this.picbClear.Location = new System.Drawing.Point(620, 173);
            this.picbClear.Name = "picbClear";
            this.picbClear.Size = new System.Drawing.Size(30, 35);
            this.picbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbClear.TabIndex = 123;
            this.picbClear.TabStop = false;
            this.picbClear.Click += new System.EventHandler(this.picbClear_Click);
            // 
            // picbRefresh
            // 
            this.picbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbRefresh.Image = global::ParkHotel.Properties.Resources.a;
            this.picbRefresh.Location = new System.Drawing.Point(620, 137);
            this.picbRefresh.Name = "picbRefresh";
            this.picbRefresh.Size = new System.Drawing.Size(30, 30);
            this.picbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbRefresh.TabIndex = 122;
            this.picbRefresh.TabStop = false;
            this.picbRefresh.Click += new System.EventHandler(this.picbRefresh_Click);
            // 
            // btnPesquisarPorNomeEmpresa
            // 
            this.btnPesquisarPorNomeEmpresa.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorNomeEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorNomeEmpresa.Location = new System.Drawing.Point(187, 284);
            this.btnPesquisarPorNomeEmpresa.Name = "btnPesquisarPorNomeEmpresa";
            this.btnPesquisarPorNomeEmpresa.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorNomeEmpresa.TabIndex = 152;
            this.btnPesquisarPorNomeEmpresa.UseVisualStyleBackColor = true;
            this.btnPesquisarPorNomeEmpresa.Click += new System.EventHandler(this.btnPesquisarPorNomeEmpresa_Click);
            // 
            // PesquisarPorCNPJ
            // 
            this.PesquisarPorCNPJ.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.PesquisarPorCNPJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisarPorCNPJ.Location = new System.Drawing.Point(188, 338);
            this.PesquisarPorCNPJ.Name = "PesquisarPorCNPJ";
            this.PesquisarPorCNPJ.Size = new System.Drawing.Size(26, 26);
            this.PesquisarPorCNPJ.TabIndex = 153;
            this.PesquisarPorCNPJ.UseVisualStyleBackColor = true;
            this.PesquisarPorCNPJ.Click += new System.EventHandler(this.PesquisarPorCNPJ_Click);
            // 
            // btnPesquisarPorNomeContato
            // 
            this.btnPesquisarPorNomeContato.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorNomeContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorNomeContato.Location = new System.Drawing.Point(164, 391);
            this.btnPesquisarPorNomeContato.Name = "btnPesquisarPorNomeContato";
            this.btnPesquisarPorNomeContato.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorNomeContato.TabIndex = 154;
            this.btnPesquisarPorNomeContato.UseVisualStyleBackColor = true;
            this.btnPesquisarPorNomeContato.Click += new System.EventHandler(this.btnPesquisarPorNomeContato_Click);
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 571);
            this.ControlBox = false;
            this.Controls.Add(this.btnPesquisarPorNomeContato);
            this.Controls.Add(this.PesquisarPorCNPJ);
            this.Controls.Add(this.btnPesquisarPorNomeEmpresa);
            this.Controls.Add(this.picbClear);
            this.Controls.Add(this.picbRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msktxtTelefone);
            this.Controls.Add(this.msktxtCNPJ);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeEmpresa);
            this.KeyPreview = true;
            this.Name = "FormFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Fornecedores";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormFornecedores_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.MaskedTextBox msktxtCNPJ;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picbRefresh;
        private System.Windows.Forms.PictureBox picbClear;
        private System.Windows.Forms.Button btnPesquisarPorNomeEmpresa;
        private System.Windows.Forms.Button PesquisarPorCNPJ;
        private System.Windows.Forms.Button btnPesquisarPorNomeContato;
    }
}