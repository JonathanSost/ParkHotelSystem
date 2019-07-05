namespace ParkHotel
{
    partial class FormPesquisarFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisarFornecedores));
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msktxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.btnPesquisarPorNomeContato = new System.Windows.Forms.Button();
            this.PesquisarPorCNPJ = new System.Windows.Forms.Button();
            this.btnPesquisarPorNomeEmpresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToOrderColumns = true;
            this.dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvFornecedores.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFornecedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFornecedores.Location = new System.Drawing.Point(0, 0);
            this.dgvFornecedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFornecedores.Name = "dgvFornecedores";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFornecedores.RowHeadersVisible = false;
            this.dgvFornecedores.RowTemplate.Height = 24;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(483, 200);
            this.dgvFornecedores.TabIndex = 26;
            this.dgvFornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedores_CellDoubleClick);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(12, 234);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(460, 37);
            this.lblPesquisar.TabIndex = 178;
            this.lblPesquisar.Text = "Pesquisar Fornecedores Por:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 344);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 184;
            this.label7.Text = "CNPJ";
            // 
            // msktxtCNPJ
            // 
            this.msktxtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCNPJ.Location = new System.Drawing.Point(152, 363);
            this.msktxtCNPJ.Mask = "99,999,999/9999-99";
            this.msktxtCNPJ.Name = "msktxtCNPJ";
            this.msktxtCNPJ.Size = new System.Drawing.Size(151, 26);
            this.msktxtCNPJ.TabIndex = 1;
            this.msktxtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 183;
            this.label4.Text = "Nome para Contato";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(152, 415);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(152, 26);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 182;
            this.label1.Text = "Nome da Empresa";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(152, 308);
            this.txtNomeEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(151, 26);
            this.txtNomeEmpresa.TabIndex = 0;
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(7, 454);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(48, 16);
            this.lblNome1.TabIndex = 188;
            this.lblNome1.Text = "Santo";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.Color.Gold;
            this.lblNome2.Location = new System.Drawing.Point(52, 454);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(64, 16);
            this.lblNome2.TabIndex = 189;
            this.lblNome2.Text = "Soninho";
            // 
            // btnPesquisarPorNomeContato
            // 
            this.btnPesquisarPorNomeContato.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorNomeContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorNomeContato.Location = new System.Drawing.Point(309, 416);
            this.btnPesquisarPorNomeContato.Name = "btnPesquisarPorNomeContato";
            this.btnPesquisarPorNomeContato.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorNomeContato.TabIndex = 187;
            this.btnPesquisarPorNomeContato.UseVisualStyleBackColor = true;
            this.btnPesquisarPorNomeContato.Click += new System.EventHandler(this.btnPesquisarPorNomeContato_Click);
            // 
            // PesquisarPorCNPJ
            // 
            this.PesquisarPorCNPJ.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.PesquisarPorCNPJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisarPorCNPJ.Location = new System.Drawing.Point(309, 363);
            this.PesquisarPorCNPJ.Name = "PesquisarPorCNPJ";
            this.PesquisarPorCNPJ.Size = new System.Drawing.Size(26, 26);
            this.PesquisarPorCNPJ.TabIndex = 186;
            this.PesquisarPorCNPJ.UseVisualStyleBackColor = true;
            this.PesquisarPorCNPJ.Click += new System.EventHandler(this.PesquisarPorCNPJ_Click);
            // 
            // btnPesquisarPorNomeEmpresa
            // 
            this.btnPesquisarPorNomeEmpresa.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorNomeEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorNomeEmpresa.Location = new System.Drawing.Point(308, 309);
            this.btnPesquisarPorNomeEmpresa.Name = "btnPesquisarPorNomeEmpresa";
            this.btnPesquisarPorNomeEmpresa.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorNomeEmpresa.TabIndex = 185;
            this.btnPesquisarPorNomeEmpresa.UseVisualStyleBackColor = true;
            this.btnPesquisarPorNomeEmpresa.Click += new System.EventHandler(this.btnPesquisarPorNomeEmpresa_Click);
            // 
            // FormPesquisarFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(482, 480);
            this.ControlBox = false;
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.btnPesquisarPorNomeContato);
            this.Controls.Add(this.PesquisarPorCNPJ);
            this.Controls.Add(this.btnPesquisarPorNomeEmpresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msktxtCNPJ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.dgvFornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormPesquisarFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormPesquisarFornecedores_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnPesquisarPorNomeContato;
        private System.Windows.Forms.Button PesquisarPorCNPJ;
        private System.Windows.Forms.Button btnPesquisarPorNomeEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msktxtCNPJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.DataGridView dgvFornecedores;
    }
}