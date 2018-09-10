namespace PizzaBoingViews
{
    partial class frmCompraProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraProdutos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbParcelas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbModoPagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.btnConsultarFornecedor = new System.Windows.Forms.Button();
            this.txtCodigoFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNF_Recibo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGravarPedido = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgDetalheProdutos = new System.Windows.Forms.DataGridView();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnConsultaProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalheProdutos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbParcelas);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbFormaPagamento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbModoPagamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 90);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observação";
            // 
            // cmbParcelas
            // 
            this.cmbParcelas.FormattingEnabled = true;
            this.cmbParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbParcelas.Location = new System.Drawing.Point(475, 40);
            this.cmbParcelas.Name = "cmbParcelas";
            this.cmbParcelas.Size = new System.Drawing.Size(113, 31);
            this.cmbParcelas.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(402, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Parcelas:";
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(279, 40);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(113, 31);
            this.cmbFormaPagamento.TabIndex = 42;
            this.cmbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPagamento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(189, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Forma pgto:";
            // 
            // cmbModoPagamento
            // 
            this.cmbModoPagamento.FormattingEnabled = true;
            this.cmbModoPagamento.Location = new System.Drawing.Point(60, 40);
            this.cmbModoPagamento.Name = "cmbModoPagamento";
            this.cmbModoPagamento.Size = new System.Drawing.Size(113, 31);
            this.cmbModoPagamento.TabIndex = 40;
            this.cmbModoPagamento.SelectedIndexChanged += new System.EventHandler(this.cmbModoPagamento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Modo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDataCompra);
            this.groupBox2.Controls.Add(this.txtNomeFornecedor);
            this.groupBox2.Controls.Add(this.btnConsultarFornecedor);
            this.groupBox2.Controls.Add(this.txtCodigoFornecedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNF_Recibo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 71);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informação da compra";
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(580, 35);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(87, 30);
            this.dtpDataCompra.TabIndex = 52;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeFornecedor.Enabled = false;
            this.txtNomeFornecedor.Location = new System.Drawing.Point(359, 32);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(175, 30);
            this.txtNomeFornecedor.TabIndex = 51;
            // 
            // btnConsultarFornecedor
            // 
            this.btnConsultarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarFornecedor.Image")));
            this.btnConsultarFornecedor.Location = new System.Drawing.Point(296, 32);
            this.btnConsultarFornecedor.Name = "btnConsultarFornecedor";
            this.btnConsultarFornecedor.Size = new System.Drawing.Size(57, 30);
            this.btnConsultarFornecedor.TabIndex = 50;
            this.btnConsultarFornecedor.UseVisualStyleBackColor = true;
            this.btnConsultarFornecedor.Click += new System.EventHandler(this.btnConsultarFornecedor_Click);
            // 
            // txtCodigoFornecedor
            // 
            this.txtCodigoFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoFornecedor.Location = new System.Drawing.Point(243, 32);
            this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
            this.txtCodigoFornecedor.Size = new System.Drawing.Size(51, 30);
            this.txtCodigoFornecedor.TabIndex = 42;
            this.txtCodigoFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoFornecedor_KeyDown);
            this.txtCodigoFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoFornecedor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(161, 39);
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
            this.label7.Location = new System.Drawing.Point(536, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Data:";
            // 
            // txtNF_Recibo
            // 
            this.txtNF_Recibo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNF_Recibo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNF_Recibo.Location = new System.Drawing.Point(81, 32);
            this.txtNF_Recibo.Name = "txtNF_Recibo";
            this.txtNF_Recibo.Size = new System.Drawing.Size(74, 30);
            this.txtNF_Recibo.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "NF/Recibo:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtOperador);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.btnGravarPedido);
            this.groupBox6.Controls.Add(this.lblValorTotal);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox6.Location = new System.Drawing.Point(3, 631);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(671, 70);
            this.groupBox6.TabIndex = 45;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Finalizar Compra";
            // 
            // txtOperador
            // 
            this.txtOperador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtOperador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOperador.Enabled = false;
            this.txtOperador.Location = new System.Drawing.Point(81, 30);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(218, 30);
            this.txtOperador.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(6, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "Operador:";
            // 
            // btnGravarPedido
            // 
            this.btnGravarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarPedido.ForeColor = System.Drawing.Color.Black;
            this.btnGravarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnGravarPedido.Image")));
            this.btnGravarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarPedido.Location = new System.Drawing.Point(532, 10);
            this.btnGravarPedido.Name = "btnGravarPedido";
            this.btnGravarPedido.Size = new System.Drawing.Size(129, 54);
            this.btnGravarPedido.TabIndex = 10;
            this.btnGravarPedido.Text = "Gravar:";
            this.btnGravarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravarPedido.UseVisualStyleBackColor = true;
            this.btnGravarPedido.Click += new System.EventHandler(this.btnGravarPedido_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.Red;
            this.lblValorTotal.Location = new System.Drawing.Point(373, 34);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(19, 20);
            this.lblValorTotal.TabIndex = 51;
            this.lblValorTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(213, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Valor Total:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgDetalheProdutos);
            this.groupBox5.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox5.Location = new System.Drawing.Point(3, 328);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(667, 297);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detalhes dos Itens";
            // 
            // dtgDetalheProdutos
            // 
            this.dtgDetalheProdutos.AllowUserToAddRows = false;
            this.dtgDetalheProdutos.AllowUserToDeleteRows = false;
            this.dtgDetalheProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalheProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.colProduto,
            this.colQuantidades,
            this.colValor,
            this.colExcluir});
            this.dtgDetalheProdutos.Location = new System.Drawing.Point(0, 29);
            this.dtgDetalheProdutos.Name = "dtgDetalheProdutos";
            this.dtgDetalheProdutos.ReadOnly = true;
            this.dtgDetalheProdutos.Size = new System.Drawing.Size(667, 264);
            this.dtgDetalheProdutos.TabIndex = 6;
            this.dtgDetalheProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalheProdutos_CellContentClick);
            this.dtgDetalheProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgDetalheProdutos_CellFormatting);
            // 
            // col_Id
            // 
            this.col_Id.DataPropertyName = "ID";
            this.col_Id.HeaderText = "ID";
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            this.col_Id.Visible = false;
            // 
            // colProduto
            // 
            this.colProduto.HeaderText = "Produtos";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            // 
            // colQuantidades
            // 
            this.colQuantidades.HeaderText = "Qtd";
            this.colQuantidades.Name = "colQuantidades";
            this.colQuantidades.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Excluir";
            this.colExcluir.Image = ((System.Drawing.Image)(resources.GetObject("colExcluir.Image")));
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnConsultaProduto);
            this.groupBox4.Controls.Add(this.btnAdicionarProduto);
            this.groupBox4.Controls.Add(this.txtQuantidadeProduto);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtValorProduto);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtNomeProduto);
            this.groupBox4.Controls.Add(this.txtCodigoProduto);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox4.Location = new System.Drawing.Point(3, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(667, 141);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compra de produtos";
            // 
            // btnConsultaProduto
            // 
            this.btnConsultaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaProduto.Image")));
            this.btnConsultaProduto.Location = new System.Drawing.Point(136, 32);
            this.btnConsultaProduto.Name = "btnConsultaProduto";
            this.btnConsultaProduto.Size = new System.Drawing.Size(57, 31);
            this.btnConsultaProduto.TabIndex = 49;
            this.btnConsultaProduto.UseVisualStyleBackColor = true;
            this.btnConsultaProduto.Click += new System.EventHandler(this.btnConsultaProduto_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProduto.Image")));
            this.btnAdicionarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(160, 75);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(129, 54);
            this.btnAdicionarProduto.TabIndex = 5;
            this.btnAdicionarProduto.Text = "Adicionar:";
            this.btnAdicionarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQuantidadeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(66, 87);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(64, 30);
            this.txtQuantidadeProduto.TabIndex = 3;
            this.txtQuantidadeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeProduto_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(25, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 17);
            this.label16.TabIndex = 45;
            this.label16.Text = "Qtd:";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtValorProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtValorProduto.Enabled = false;
            this.txtValorProduto.Location = new System.Drawing.Point(567, 29);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(64, 30);
            this.txtValorProduto.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(489, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "Valor unit:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(267, 29);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(212, 30);
            this.txtNomeProduto.TabIndex = 42;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoProduto.Location = new System.Drawing.Point(66, 32);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(64, 30);
            this.txtCodigoProduto.TabIndex = 2;
            this.txtCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProduto_KeyDown);
            this.txtCodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProduto_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(205, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 41;
            this.label13.Text = "Produto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(9, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "Codigo:";
            // 
            // frmCompraProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 703);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCompraProdutos";
            this.Text = "Compra de produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalheProdutos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNF_Recibo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnGravarPedido;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultarFornecedor;
        private System.Windows.Forms.ComboBox cmbParcelas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbModoPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgDetalheProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnConsultaProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.Label label12;
    }
}

