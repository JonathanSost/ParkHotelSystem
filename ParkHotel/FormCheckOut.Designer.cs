namespace ParkHotel
{
    partial class FormCheckOut
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
            this.dgvClientesExpirados = new System.Windows.Forms.DataGridView();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnAdiar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIDQuarto = new System.Windows.Forms.TextBox();
            this.txtTipoQuarto = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataPrevistaEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataPrevistaSaida = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesExpirados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientesExpirados
            // 
            this.dgvClientesExpirados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientesExpirados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesExpirados.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvClientesExpirados.Location = new System.Drawing.Point(0, 0);
            this.dgvClientesExpirados.Name = "dgvClientesExpirados";
            this.dgvClientesExpirados.RowHeadersVisible = false;
            this.dgvClientesExpirados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesExpirados.Size = new System.Drawing.Size(684, 160);
            this.dgvClientesExpirados.TabIndex = 0;
            this.dgvClientesExpirados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesExpirados_CellDoubleClick);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(147, 571);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(191, 40);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Realizar Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnAdiar
            // 
            this.btnAdiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdiar.Location = new System.Drawing.Point(349, 571);
            this.btnAdiar.Name = "btnAdiar";
            this.btnAdiar.Size = new System.Drawing.Size(191, 40);
            this.btnAdiar.TabIndex = 2;
            this.btnAdiar.Text = "Adiar Check-Out";
            this.btnAdiar.UseVisualStyleBackColor = true;
            this.btnAdiar.Click += new System.EventHandler(this.btnAdiar_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(43, 229);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 29);
            this.txtID.TabIndex = 3;
            // 
            // txtIDQuarto
            // 
            this.txtIDQuarto.Enabled = false;
            this.txtIDQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDQuarto.Location = new System.Drawing.Point(43, 296);
            this.txtIDQuarto.Name = "txtIDQuarto";
            this.txtIDQuarto.Size = new System.Drawing.Size(191, 29);
            this.txtIDQuarto.TabIndex = 4;
            // 
            // txtTipoQuarto
            // 
            this.txtTipoQuarto.Enabled = false;
            this.txtTipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoQuarto.Location = new System.Drawing.Point(43, 363);
            this.txtTipoQuarto.Name = "txtTipoQuarto";
            this.txtTipoQuarto.Size = new System.Drawing.Size(191, 29);
            this.txtTipoQuarto.TabIndex = 5;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(43, 429);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(191, 29);
            this.txtIDCliente.TabIndex = 6;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(421, 229);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(191, 29);
            this.txtNomeCliente.TabIndex = 7;
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.Enabled = false;
            this.txtIDFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDFuncionario.Location = new System.Drawing.Point(421, 296);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.Size = new System.Drawing.Size(191, 29);
            this.txtIDFuncionario.TabIndex = 8;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Enabled = false;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(421, 363);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(191, 29);
            this.txtNomeFuncionario.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID do Quarto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo do Quarto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID do Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome do Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID do Funcionário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome do Funcionário:";
            // 
            // dtpDataPrevistaEntrada
            // 
            this.dtpDataPrevistaEntrada.Enabled = false;
            this.dtpDataPrevistaEntrada.Location = new System.Drawing.Point(422, 435);
            this.dtpDataPrevistaEntrada.Name = "dtpDataPrevistaEntrada";
            this.dtpDataPrevistaEntrada.Size = new System.Drawing.Size(200, 20);
            this.dtpDataPrevistaEntrada.TabIndex = 17;
            // 
            // dtpDataPrevistaSaida
            // 
            this.dtpDataPrevistaSaida.Enabled = false;
            this.dtpDataPrevistaSaida.Location = new System.Drawing.Point(422, 496);
            this.dtpDataPrevistaSaida.Name = "dtpDataPrevistaSaida";
            this.dtpDataPrevistaSaida.Size = new System.Drawing.Size(200, 20);
            this.dtpDataPrevistaSaida.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(417, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Data Prevista Entrada:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Data Prevista Saída:";
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 647);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDataPrevistaSaida);
            this.Controls.Add(this.dtpDataPrevistaEntrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.txtIDFuncionario);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.txtTipoQuarto);
            this.Controls.Add(this.txtIDQuarto);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAdiar);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.dgvClientesExpirados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormCheckOut";
            this.Text = "FormCheckOutAutomatico";
            this.Load += new System.EventHandler(this.FormCheckOutAutomatico_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCheckOut_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesExpirados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClientesExpirados;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnAdiar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIDQuarto;
        private System.Windows.Forms.TextBox txtTipoQuarto;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataPrevistaEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataPrevistaSaida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}