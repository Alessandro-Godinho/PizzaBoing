namespace PizzaBoingViews
{
    partial class frmConsultaCompraProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCompraProdutos));
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodoInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.btnConsultaFornecedor = new System.Windows.Forms.Button();
            this.txtCodigoFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgConsultaCompras = new System.Windows.Forms.DataGridView();
            this.ImagemParcelas = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpageConsulta = new System.Windows.Forms.TabPage();
            this.tabpageItensCompra = new System.Windows.Forms.TabPage();
            this.dtgdetalhesitens = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaCompras)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabpageConsulta.SuspendLayout();
            this.tabpageItensCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdetalhesitens)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(104, 45);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(221, 30);
            this.txtPesquisar.TabIndex = 14;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDataFinal);
            this.groupBox2.Controls.Add(this.dtpPeriodoInicial);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNomeFornecedor);
            this.groupBox2.Controls.Add(this.btnConsultaFornecedor);
            this.groupBox2.Controls.Add(this.txtCodigoFornecedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 70);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informação da compra";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CustomFormat = "";
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFinal.Location = new System.Drawing.Point(728, 35);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(101, 30);
            this.dtpDataFinal.TabIndex = 53;
            this.dtpDataFinal.ValueChanged += new System.EventHandler(this.dtpDataFinal_ValueChanged);
            // 
            // dtpPeriodoInicial
            // 
            this.dtpPeriodoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodoInicial.Location = new System.Drawing.Point(559, 32);
            this.dtpPeriodoInicial.Name = "dtpPeriodoInicial";
            this.dtpPeriodoInicial.Size = new System.Drawing.Size(106, 30);
            this.dtpPeriodoInicial.TabIndex = 42;
            this.dtpPeriodoInicial.ValueChanged += new System.EventHandler(this.dtpPeriodoInicial_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(686, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "à:";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeFornecedor.Enabled = false;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(204, 32);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(282, 30);
            this.txtNomeFornecedor.TabIndex = 51;
            // 
            // btnConsultaFornecedor
            // 
            this.btnConsultaFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaFornecedor.Image")));
            this.btnConsultaFornecedor.Location = new System.Drawing.Point(141, 32);
            this.btnConsultaFornecedor.Name = "btnConsultaFornecedor";
            this.btnConsultaFornecedor.Size = new System.Drawing.Size(57, 30);
            this.btnConsultaFornecedor.TabIndex = 50;
            this.btnConsultaFornecedor.UseVisualStyleBackColor = true;
            this.btnConsultaFornecedor.Click += new System.EventHandler(this.btnConsultaFornecedor_Click);
            // 
            // txtCodigoFornecedor
            // 
            this.txtCodigoFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoFornecedor.Enabled = false;
            this.txtCodigoFornecedor.Location = new System.Drawing.Point(88, 32);
            this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
            this.txtCodigoFornecedor.Size = new System.Drawing.Size(51, 30);
            this.txtCodigoFornecedor.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fornecedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(492, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Periodo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgConsultaCompras);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(-4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 369);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens da compra";
            // 
            // dtgConsultaCompras
            // 
            this.dtgConsultaCompras.AllowUserToAddRows = false;
            this.dtgConsultaCompras.AllowUserToDeleteRows = false;
            this.dtgConsultaCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConsultaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgConsultaCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgConsultaCompras.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgConsultaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConsultaCompras.ColumnHeadersHeight = 33;
            this.dtgConsultaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImagemParcelas,
            this.ID,
            this.Data,
            this.ValorTotal,
            this.TipoPagamento,
            this.Fornecedor,
            this.Operador,
            this.Details});
            this.dtgConsultaCompras.GridColor = System.Drawing.Color.Black;
            this.dtgConsultaCompras.Location = new System.Drawing.Point(0, 94);
            this.dtgConsultaCompras.MultiSelect = false;
            this.dtgConsultaCompras.Name = "dtgConsultaCompras";
            this.dtgConsultaCompras.ReadOnly = true;
            this.dtgConsultaCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgConsultaCompras.Size = new System.Drawing.Size(971, 290);
            this.dtgConsultaCompras.TabIndex = 15;
            this.dtgConsultaCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultaCompras_CellContentClick);
            this.dtgConsultaCompras.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgConsultaCompras_CellFormatting);
            // 
            // ImagemParcelas
            // 
            this.ImagemParcelas.HeaderText = "Parcelas";
            this.ImagemParcelas.Name = "ImagemParcelas";
            this.ImagemParcelas.ReadOnly = true;
            this.ImagemParcelas.Width = 77;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "NF_Recibo";
            this.ID.HeaderText = "NF/Recibo";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 108;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DataCompra";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 68;
            // 
            // ValorTotal
            // 
            this.ValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 105;
            // 
            // TipoPagamento
            // 
            this.TipoPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipoPagamento.DataPropertyName = "TipoPagamento";
            this.TipoPagamento.HeaderText = "TipoPagamento";
            this.TipoPagamento.Name = "TipoPagamento";
            this.TipoPagamento.ReadOnly = true;
            this.TipoPagamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoPagamento.Width = 140;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "Fornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.Width = 112;
            // 
            // Operador
            // 
            this.Operador.DataPropertyName = "Funcionario";
            this.Operador.HeaderText = "Operador";
            this.Operador.Name = "Operador";
            this.Operador.ReadOnly = true;
            this.Operador.Width = 99;
            // 
            // Details
            // 
            this.Details.HeaderText = "Detalhes";
            this.Details.Image = ((System.Drawing.Image)(resources.GetObject("Details.Image")));
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 77;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpageConsulta);
            this.tabControl1.Controls.Add(this.tabpageItensCompra);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(1, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 391);
            this.tabControl1.TabIndex = 55;
            // 
            // tabpageConsulta
            // 
            this.tabpageConsulta.Controls.Add(this.groupBox1);
            this.tabpageConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabpageConsulta.Name = "tabpageConsulta";
            this.tabpageConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageConsulta.Size = new System.Drawing.Size(975, 365);
            this.tabpageConsulta.TabIndex = 0;
            this.tabpageConsulta.Text = "Consulta";
            this.tabpageConsulta.UseVisualStyleBackColor = true;
            // 
            // tabpageItensCompra
            // 
            this.tabpageItensCompra.Controls.Add(this.dtgdetalhesitens);
            this.tabpageItensCompra.Location = new System.Drawing.Point(4, 22);
            this.tabpageItensCompra.Name = "tabpageItensCompra";
            this.tabpageItensCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageItensCompra.Size = new System.Drawing.Size(975, 365);
            this.tabpageItensCompra.TabIndex = 1;
            this.tabpageItensCompra.Text = "Itens da compra";
            this.tabpageItensCompra.UseVisualStyleBackColor = true;
            // 
            // dtgdetalhesitens
            // 
            this.dtgdetalhesitens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgdetalhesitens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgdetalhesitens.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgdetalhesitens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgdetalhesitens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdetalhesitens.GridColor = System.Drawing.Color.Black;
            this.dtgdetalhesitens.Location = new System.Drawing.Point(0, 3);
            this.dtgdetalhesitens.MultiSelect = false;
            this.dtgdetalhesitens.Name = "dtgdetalhesitens";
            this.dtgdetalhesitens.ReadOnly = true;
            this.dtgdetalhesitens.Size = new System.Drawing.Size(969, 362);
            this.dtgdetalhesitens.TabIndex = 0;
            // 
            // frmConsultaCompraProdutos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(974, 470);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmConsultaCompraProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Compra de Produtos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaCompras)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabpageConsulta.ResumeLayout(false);
            this.tabpageItensCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdetalhesitens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Button btnConsultaFornecedor;
        private System.Windows.Forms.TextBox txtCodigoFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpPeriodoInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpageConsulta;
        private System.Windows.Forms.TabPage tabpageItensCompra;
        private System.Windows.Forms.DataGridView dtgdetalhesitens;
        private System.Windows.Forms.DataGridView dtgConsultaCompras;
        private System.Windows.Forms.DataGridViewImageColumn ImagemParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
        private System.Windows.Forms.DataGridViewImageColumn Details;
    }
}