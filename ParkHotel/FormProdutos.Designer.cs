namespace ParkHotel
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDFornecedor = new System.Windows.Forms.TextBox();
            this.btnPesquisarFornecedores = new System.Windows.Forms.Button();
            this.picbClear = new System.Windows.Forms.PictureBox();
            this.picbRefresh = new System.Windows.Forms.PictureBox();
            this.btnPesquisarPorNomeProduto = new System.Windows.Forms.Button();
            this.btnPesquisarPorDescricao = new System.Windows.Forms.Button();
            this.btnPesquisarPorPreçosMenores = new System.Windows.Forms.Button();
            this.btnPesquisarPorPreçosIguais = new System.Windows.Forms.Button();
            this.btnPesquisarPorPreçosMaiores = new System.Windows.Forms.Button();
            this.btnPesquisarPorEstoquesMaiores = new System.Windows.Forms.Button();
            this.btnPesquisarPorEstoquesIguais = new System.Windows.Forms.Button();
            this.btnPesquisarPorEstoquesMenores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 227);
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
            this.txtID.Location = new System.Drawing.Point(34, 246);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 26);
            this.txtID.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(683, 132);
            this.dgvProdutos.TabIndex = 25;
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome do Produto";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(32, 351);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(161, 26);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(32, 299);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(161, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(127, 136);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 52);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(250, 136);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 52);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Preço (Und)";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(32, 401);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(161, 26);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 435);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Estoque";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Location = new System.Drawing.Point(32, 452);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(161, 26);
            this.txtEstoque.TabIndex = 4;
            this.txtEstoque.TextChanged += new System.EventHandler(this.txtEstoque_TextChanged);
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Matura MT Script Capitals", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.Color.Gold;
            this.lblNome2.Location = new System.Drawing.Point(338, 349);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(341, 107);
            this.lblNome2.TabIndex = 101;
            this.lblNome2.Text = "Soninho";
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Matura MT Script Capitals", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(390, 246);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(263, 107);
            this.lblNome1.TabIndex = 100;
            this.lblNome1.Text = "Santo";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(546, 539);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 39);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 489);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 125;
            this.label6.Text = "ID do Fornecedor";
            // 
            // txtIDFornecedor
            // 
            this.txtIDFornecedor.Enabled = false;
            this.txtIDFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDFornecedor.Location = new System.Drawing.Point(32, 508);
            this.txtIDFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDFornecedor.Name = "txtIDFornecedor";
            this.txtIDFornecedor.Size = new System.Drawing.Size(161, 26);
            this.txtIDFornecedor.TabIndex = 5;
            // 
            // btnPesquisarFornecedores
            // 
            this.btnPesquisarFornecedores.Location = new System.Drawing.Point(197, 508);
            this.btnPesquisarFornecedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarFornecedores.Name = "btnPesquisarFornecedores";
            this.btnPesquisarFornecedores.Size = new System.Drawing.Size(29, 26);
            this.btnPesquisarFornecedores.TabIndex = 126;
            this.btnPesquisarFornecedores.Text = "...";
            this.btnPesquisarFornecedores.UseVisualStyleBackColor = true;
            this.btnPesquisarFornecedores.Click += new System.EventHandler(this.btnPesquisarFornecedores_Click);
            // 
            // picbClear
            // 
            this.picbClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbClear.Image = global::ParkHotel.Properties.Resources.lvasivdnlkvndbçslnzbihçbp_gspi;
            this.picbClear.Location = new System.Drawing.Point(641, 173);
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
            this.picbRefresh.Location = new System.Drawing.Point(641, 137);
            this.picbRefresh.Name = "picbRefresh";
            this.picbRefresh.Size = new System.Drawing.Size(30, 30);
            this.picbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbRefresh.TabIndex = 122;
            this.picbRefresh.TabStop = false;
            this.picbRefresh.Click += new System.EventHandler(this.picbRefresh_Click);
            // 
            // btnPesquisarPorNomeProduto
            // 
            this.btnPesquisarPorNomeProduto.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorNomeProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorNomeProduto.Location = new System.Drawing.Point(198, 300);
            this.btnPesquisarPorNomeProduto.Name = "btnPesquisarPorNomeProduto";
            this.btnPesquisarPorNomeProduto.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorNomeProduto.TabIndex = 127;
            this.btnPesquisarPorNomeProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarPorNomeProduto.Click += new System.EventHandler(this.btnPesquisarPorNomeProduto_Click);
            // 
            // btnPesquisarPorDescricao
            // 
            this.btnPesquisarPorDescricao.BackgroundImage = global::ParkHotel.Properties.Resources.lupahiafugfiasf;
            this.btnPesquisarPorDescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarPorDescricao.Location = new System.Drawing.Point(198, 352);
            this.btnPesquisarPorDescricao.Name = "btnPesquisarPorDescricao";
            this.btnPesquisarPorDescricao.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisarPorDescricao.TabIndex = 128;
            this.btnPesquisarPorDescricao.UseVisualStyleBackColor = true;
            this.btnPesquisarPorDescricao.Click += new System.EventHandler(this.btnPesquisarPorDescricao_Click);
            // 
            // btnPesquisarPorPreçosMenores
            // 
            this.btnPesquisarPorPreçosMenores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPorPreçosMenores.Location = new System.Drawing.Point(198, 401);
            this.btnPesquisarPorPreçosMenores.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarPorPreçosMenores.Name = "btnPesquisarPorPreçosMenores";
            this.btnPesquisarPorPreçosMenores.Size = new System.Drawing.Size(29, 26);
            this.btnPesquisarPorPreçosMenores.TabIndex = 129;
            this.btnPesquisarPorPreçosMenores.Text = "<";
            this.btnPesquisarPorPreçosMenores.UseVisualStyleBackColor = true;
            this.btnPesquisarPorPreçosMenores.Click += new System.EventHandler(this.btnPesquisarPorPreçosMenores_Click);
            // 
            // btnPesquisarPorPreçosIguais
            // 
            this.btnPesquisarPorPreçosIguais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPorPreçosIguais.Location = new System.Drawing.Point(231, 401);
            this.btnPesquisarPorPreçosIguais.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarPorPreçosIguais.Name = "btnPesquisarPorPreçosIguais";
            this.btnPesquisarPorPreçosIguais.Size = new System.Drawing.Size(29, 26);
            this.btnPesquisarPorPreçosIguais.TabIndex = 130;
            this.btnPesquisarPorPreçosIguais.Text = "=";
            this.btnPesquisarPorPreçosIguais.UseVisualStyleBackColor = true;
            this.btnPesquisarPorPreçosIguais.Click += new System.EventHandler(this.btnPesquisarPorPreçosIguais_Click);
            // 
            // btnPesquisarPorPreçosMaiores
            // 
            this.btnPesquisarPorPreçosMaiores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPorPreçosMaiores.Location = new System.Drawing.Point(264, 401);
            this.btnPesquisarPorPreçosMaiores.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarPorPreçosMaiores.Name = "btnPesquisarPorPreçosMaiores";
            this.btnPesquisarPorPreçosMaiores.Size = new System.Drawing.Size(29, 26);
            this.btnPesquisarPorPreçosMaiores.TabIndex = 131;
            this.btnPesquisarPorPreçosMaiores.Text = ">";
            this.btnPesquisarPorPreçosMaiores.UseVisualStyleBackColor = true;
            this.btnPesquisarPorPreçosMaiores.Click += new System.EventHandler(this.btnPesquisarPorPreçosMaiores_Click);
            // 
            // btnPesquisarPorEstoquesMaiores
            // 
            this.btnPesquisarPorEstoquesMaiores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPorEstoquesMaiores.Location = new System.Drawing.Point(264, 451);
            this.btnPesquisarPorEstoquesMaiores.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarPorEstoquesMaiores.Name = "btnPesquisarPorEstoquesMaiores";
            this.btnPesquisarPorEstoquesMaiores.Size = new System.Drawing.Size(29, 26);
            this.btnPesquisarPorEstoquesMaiores.TabIndex = 134;
            this.btnPesquisarPorEstoquesMaiores.Text = ">";
            this.btnPesquisarPorEstoquesMaiores.UseVisualStyleBackColor = true;
            this.btnPesquisarPorEstoquesMaiores.Click += new System.EventHandler(this.btnPesquisarPorEstoquesMaiores_Click);
            // 
            // btnPesquisarPorEstoquesIguais
            // 
            this.btnPesquisarPorEstoquesIguais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPorEstoquesIguais.Location = new System.Drawing.Point(231, 452);
            this.btnPesquisarPorEstoquesIguais.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarPorEstoquesIguais.Name = "btnPesquisarPorEstoquesIguais";
            this.btnPesquisarPorEstoquesIguais.Size = new System.Drawing.Size(29, 26);
            this.btnPesquisarPorEstoquesIguais.TabIndex = 133;
            this.btnPesquisarPorEstoquesIguais.Text = "=";
            this.btnPesquisarPorEstoquesIguais.UseVisualStyleBackColor = true;
            this.btnPesquisarPorEstoquesIguais.Click += new System.EventHandler(this.btnPesquisarPorEstoquesIguais_Click);
            // 
            // btnPesquisarPorEstoquesMenores
            // 
            this.btnPesquisarPorEstoquesMenores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPorEstoquesMenores.Location = new System.Drawing.Point(198, 451);
            this.btnPesquisarPorEstoquesMenores.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisarPorEstoquesMenores.Name = "btnPesquisarPorEstoquesMenores";
            this.btnPesquisarPorEstoquesMenores.Size = new System.Drawing.Size(29, 26);
            this.btnPesquisarPorEstoquesMenores.TabIndex = 132;
            this.btnPesquisarPorEstoquesMenores.Text = "<";
            this.btnPesquisarPorEstoquesMenores.UseVisualStyleBackColor = true;
            this.btnPesquisarPorEstoquesMenores.Click += new System.EventHandler(this.btnPesquisarPorEstoquesMenores_Click);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 587);
            this.ControlBox = false;
            this.Controls.Add(this.btnPesquisarPorEstoquesMaiores);
            this.Controls.Add(this.btnPesquisarPorEstoquesIguais);
            this.Controls.Add(this.btnPesquisarPorEstoquesMenores);
            this.Controls.Add(this.btnPesquisarPorPreçosMaiores);
            this.Controls.Add(this.btnPesquisarPorPreçosIguais);
            this.Controls.Add(this.btnPesquisarPorPreçosMenores);
            this.Controls.Add(this.btnPesquisarPorDescricao);
            this.Controls.Add(this.btnPesquisarPorNomeProduto);
            this.Controls.Add(this.btnPesquisarFornecedores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDFornecedor);
            this.Controls.Add(this.picbClear);
            this.Controls.Add(this.picbRefresh);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormProdutos_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox picbRefresh;
        private System.Windows.Forms.PictureBox picbClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDFornecedor;
        private System.Windows.Forms.Button btnPesquisarFornecedores;
        private System.Windows.Forms.Button btnPesquisarPorNomeProduto;
        private System.Windows.Forms.Button btnPesquisarPorDescricao;
        private System.Windows.Forms.Button btnPesquisarPorPreçosMenores;
        private System.Windows.Forms.Button btnPesquisarPorPreçosIguais;
        private System.Windows.Forms.Button btnPesquisarPorPreçosMaiores;
        private System.Windows.Forms.Button btnPesquisarPorEstoquesMaiores;
        private System.Windows.Forms.Button btnPesquisarPorEstoquesIguais;
        private System.Windows.Forms.Button btnPesquisarPorEstoquesMenores;
    }
}