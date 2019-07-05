namespace ParkHotel
{
    partial class FormQuartos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuartos));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvQuartos = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCriarTipo = new System.Windows.Forms.Button();
            this.picbClear = new System.Windows.Forms.PictureBox();
            this.picbRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(127, 136);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 52);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 216);
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
            this.txtID.Location = new System.Drawing.Point(36, 235);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 26);
            this.txtID.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(250, 136);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 52);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvQuartos
            // 
            this.dgvQuartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuartos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvQuartos.Location = new System.Drawing.Point(0, 0);
            this.dgvQuartos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuartos.Name = "dgvQuartos";
            this.dgvQuartos.RowHeadersVisible = false;
            this.dgvQuartos.RowTemplate.Height = 24;
            this.dgvQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuartos.Size = new System.Drawing.Size(637, 132);
            this.dgvQuartos.TabIndex = 25;
            this.dgvQuartos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuartos_CellDoubleClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(3, 135);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 52);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Preço (Diária)";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(34, 288);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(152, 26);
            this.txtPreco.TabIndex = 1;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisponivel.Location = new System.Drawing.Point(34, 382);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(100, 24);
            this.chkDisponivel.TabIndex = 3;
            this.chkDisponivel.Text = "Disponível";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            this.chkDisponivel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chkDisponivel_KeyUp);
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Matura MT Script Capitals", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.Color.Gold;
            this.lblNome2.Location = new System.Drawing.Point(221, 314);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(409, 127);
            this.lblNome2.TabIndex = 98;
            this.lblNome2.Text = "Soninho";
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Matura MT Script Capitals", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(275, 207);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(316, 127);
            this.lblNome1.TabIndex = 97;
            this.lblNome1.Text = "Santo";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(501, 464);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 39);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(34, 336);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(152, 28);
            this.cmbTipo.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 125;
            this.label4.Text = "Tipo";
            // 
            // btnCriarTipo
            // 
            this.btnCriarTipo.Location = new System.Drawing.Point(463, 135);
            this.btnCriarTipo.Name = "btnCriarTipo";
            this.btnCriarTipo.Size = new System.Drawing.Size(93, 37);
            this.btnCriarTipo.TabIndex = 126;
            this.btnCriarTipo.Text = "Criar Novo Tipo de Quarto";
            this.btnCriarTipo.UseVisualStyleBackColor = true;
            this.btnCriarTipo.Click += new System.EventHandler(this.btnCriarTipo_Click);
            // 
            // picbClear
            // 
            this.picbClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbClear.Image = global::ParkHotel.Properties.Resources.lvasivdnlkvndbçslnzbihçbp_gspi;
            this.picbClear.Location = new System.Drawing.Point(595, 173);
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
            this.picbRefresh.Location = new System.Drawing.Point(595, 137);
            this.picbRefresh.Name = "picbRefresh";
            this.picbRefresh.Size = new System.Drawing.Size(30, 30);
            this.picbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbRefresh.TabIndex = 122;
            this.picbRefresh.TabStop = false;
            this.picbRefresh.Click += new System.EventHandler(this.picbRefresh_Click);
            // 
            // FormQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 518);
            this.ControlBox = false;
            this.Controls.Add(this.btnCriarTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.picbClear);
            this.Controls.Add(this.picbRefresh);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvQuartos);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormQuartos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Quartos";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormQuartos_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvQuartos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox picbRefresh;
        private System.Windows.Forms.PictureBox picbClear;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCriarTipo;
    }
}