namespace ParkHotel
{
    partial class FormPesquisarQuartos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisarQuartos));
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.dgvQuartos = new System.Windows.Forms.DataGridView();
            this.btnPesquisarPorQuartosDisponíveis = new System.Windows.Forms.Button();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.btnPesquisarPorPreçosMaiores = new System.Windows.Forms.Button();
            this.btnPesquisarPorPreçosIguais = new System.Windows.Forms.Button();
            this.btnPesquisarPorPreçosMenores = new System.Windows.Forms.Button();
            this.PesquisarPorTipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(6, 454);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(48, 17);
            this.lblNome1.TabIndex = 201;
            this.lblNome1.Text = "Santo";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.Color.Gold;
            this.lblNome2.Location = new System.Drawing.Point(51, 454);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(63, 17);
            this.lblNome2.TabIndex = 202;
            this.lblNome2.Text = "Soninho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 330);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 197;
            this.label7.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 195;
            this.label1.Text = "Preço";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(139, 297);
            this.txtNomeEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(151, 26);
            this.txtNomeEmpresa.TabIndex = 192;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(117, 226);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(241, 37);
            this.lblPesquisar.TabIndex = 191;
            this.lblPesquisar.Text = "Pesquisar Por:";
            // 
            // dgvQuartos
            // 
            this.dgvQuartos.AllowUserToOrderColumns = true;
            this.dgvQuartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvQuartos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuartos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuartos.Location = new System.Drawing.Point(-1, 0);
            this.dgvQuartos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuartos.Name = "dgvQuartos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuartos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuartos.RowHeadersVisible = false;
            this.dgvQuartos.RowTemplate.Height = 24;
            this.dgvQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuartos.Size = new System.Drawing.Size(483, 200);
            this.dgvQuartos.TabIndex = 190;
            this.dgvQuartos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuartos_CellDoubleClick);
            // 
            // btnPesquisarPorQuartosDisponíveis
            // 
            this.btnPesquisarPorQuartosDisponíveis.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorQuartosDisponíveis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorQuartosDisponíveis.Location = new System.Drawing.Point(245, 394);
            this.btnPesquisarPorQuartosDisponíveis.Name = "btnPesquisarPorQuartosDisponíveis";
            this.btnPesquisarPorQuartosDisponíveis.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorQuartosDisponíveis.TabIndex = 200;
            this.btnPesquisarPorQuartosDisponíveis.UseVisualStyleBackColor = true;
            this.btnPesquisarPorQuartosDisponíveis.Click += new System.EventHandler(this.btnPesquisarPorQuartosDisponíveis_Click);
            // 
            // cmbTipos
            // 
            this.cmbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(139, 351);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(152, 28);
            this.cmbTipos.TabIndex = 203;
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisponivel.Location = new System.Drawing.Point(139, 396);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(100, 24);
            this.chkDisponivel.TabIndex = 204;
            this.chkDisponivel.Text = "Disponível";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarPorPreçosMaiores
            // 
            this.btnPesquisarPorPreçosMaiores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPorPreçosMaiores.Location = new System.Drawing.Point(362, 297);
            this.btnPesquisarPorPreçosMaiores.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarPorPreçosMaiores.Name = "btnPesquisarPorPreçosMaiores";
            this.btnPesquisarPorPreçosMaiores.Size = new System.Drawing.Size(29, 26);
            this.btnPesquisarPorPreçosMaiores.TabIndex = 207;
            this.btnPesquisarPorPreçosMaiores.Text = ">";
            this.btnPesquisarPorPreçosMaiores.UseVisualStyleBackColor = true;
            this.btnPesquisarPorPreçosMaiores.Click += new System.EventHandler(this.btnPesquisarPorPreçosMaiores_Click);
            // 
            // btnPesquisarPorPreçosIguais
            // 
            this.btnPesquisarPorPreçosIguais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPorPreçosIguais.Location = new System.Drawing.Point(329, 297);
            this.btnPesquisarPorPreçosIguais.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarPorPreçosIguais.Name = "btnPesquisarPorPreçosIguais";
            this.btnPesquisarPorPreçosIguais.Size = new System.Drawing.Size(29, 26);
            this.btnPesquisarPorPreçosIguais.TabIndex = 206;
            this.btnPesquisarPorPreçosIguais.Text = "=";
            this.btnPesquisarPorPreçosIguais.UseVisualStyleBackColor = true;
            this.btnPesquisarPorPreçosIguais.Click += new System.EventHandler(this.btnPesquisarPorPreçosIguais_Click);
            // 
            // btnPesquisarPorPreçosMenores
            // 
            this.btnPesquisarPorPreçosMenores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPorPreçosMenores.Location = new System.Drawing.Point(296, 297);
            this.btnPesquisarPorPreçosMenores.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarPorPreçosMenores.Name = "btnPesquisarPorPreçosMenores";
            this.btnPesquisarPorPreçosMenores.Size = new System.Drawing.Size(29, 26);
            this.btnPesquisarPorPreçosMenores.TabIndex = 205;
            this.btnPesquisarPorPreçosMenores.Text = "<";
            this.btnPesquisarPorPreçosMenores.UseVisualStyleBackColor = true;
            this.btnPesquisarPorPreçosMenores.Click += new System.EventHandler(this.btnPesquisarPorPreçosMenores_Click);
            // 
            // PesquisarPorTipo
            // 
            this.PesquisarPorTipo.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.PesquisarPorTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PesquisarPorTipo.Location = new System.Drawing.Point(296, 352);
            this.PesquisarPorTipo.Name = "PesquisarPorTipo";
            this.PesquisarPorTipo.Size = new System.Drawing.Size(26, 26);
            this.PesquisarPorTipo.TabIndex = 199;
            this.PesquisarPorTipo.UseVisualStyleBackColor = true;
            this.PesquisarPorTipo.Click += new System.EventHandler(this.PesquisarPorTipo_Click);
            // 
            // FormPesquisarQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(482, 480);
            this.ControlBox = false;
            this.Controls.Add(this.btnPesquisarPorPreçosMaiores);
            this.Controls.Add(this.btnPesquisarPorPreçosIguais);
            this.Controls.Add(this.btnPesquisarPorPreçosMenores);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.cmbTipos);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.btnPesquisarPorQuartosDisponíveis);
            this.Controls.Add(this.PesquisarPorTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.dgvQuartos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormPesquisarQuartos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPesquisarQuartos";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormPesquisarQuartos_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Button btnPesquisarPorQuartosDisponíveis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DataGridView dgvQuartos;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Button btnPesquisarPorPreçosMaiores;
        private System.Windows.Forms.Button btnPesquisarPorPreçosIguais;
        private System.Windows.Forms.Button btnPesquisarPorPreçosMenores;
        private System.Windows.Forms.Button PesquisarPorTipo;
    }
}