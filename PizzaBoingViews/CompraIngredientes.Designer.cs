namespace PizzaBoingViews
{
    partial class frmCompraIngredientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraIngredientes));
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdicionarIngrediente = new System.Windows.Forms.Button();
            this.txtQuantidadeIngrediente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorIngrediente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeIngrediente = new System.Windows.Forms.TextBox();
            this.txtCodigoIngrediente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtgDetalhesIngredientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalhesIngredientes)).BeginInit();
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
            this.txtOperador.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(9, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 50;
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
            this.lblValorTotal.Location = new System.Drawing.Point(425, 37);
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
            this.label3.Location = new System.Drawing.Point(338, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Valor Total:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnAdicionarIngrediente);
            this.groupBox3.Controls.Add(this.txtQuantidadeIngrediente);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtValorIngrediente);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtNomeIngrediente);
            this.groupBox3.Controls.Add(this.txtCodigoIngrediente);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(3, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 141);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compra de Ingredientes";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(136, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 31);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConsultaIngrediente_Click);
            // 
            // btnAdicionarIngrediente
            // 
            this.btnAdicionarIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarIngrediente.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarIngrediente.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarIngrediente.Image")));
            this.btnAdicionarIngrediente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarIngrediente.Location = new System.Drawing.Point(159, 75);
            this.btnAdicionarIngrediente.Name = "btnAdicionarIngrediente";
            this.btnAdicionarIngrediente.Size = new System.Drawing.Size(129, 54);
            this.btnAdicionarIngrediente.TabIndex = 5;
            this.btnAdicionarIngrediente.Text = "Adicionar:";
            this.btnAdicionarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarIngrediente.UseVisualStyleBackColor = true;
            this.btnAdicionarIngrediente.Click += new System.EventHandler(this.btnAdicionarIngrediente_Click);
            // 
            // txtQuantidadeIngrediente
            // 
            this.txtQuantidadeIngrediente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQuantidadeIngrediente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtQuantidadeIngrediente.Location = new System.Drawing.Point(66, 87);
            this.txtQuantidadeIngrediente.Name = "txtQuantidadeIngrediente";
            this.txtQuantidadeIngrediente.Size = new System.Drawing.Size(64, 30);
            this.txtQuantidadeIngrediente.TabIndex = 3;
            this.txtQuantidadeIngrediente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidadeIngrediente_KeyDown);
            this.txtQuantidadeIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeIngrediente_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(25, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Qtd:";
            // 
            // txtValorIngrediente
            // 
            this.txtValorIngrediente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtValorIngrediente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtValorIngrediente.Enabled = false;
            this.txtValorIngrediente.Location = new System.Drawing.Point(583, 29);
            this.txtValorIngrediente.Name = "txtValorIngrediente";
            this.txtValorIngrediente.Size = new System.Drawing.Size(64, 30);
            this.txtValorIngrediente.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(510, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Valor unit:";
            // 
            // txtNomeIngrediente
            // 
            this.txtNomeIngrediente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeIngrediente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeIngrediente.Enabled = false;
            this.txtNomeIngrediente.Location = new System.Drawing.Point(292, 29);
            this.txtNomeIngrediente.Name = "txtNomeIngrediente";
            this.txtNomeIngrediente.Size = new System.Drawing.Size(212, 30);
            this.txtNomeIngrediente.TabIndex = 42;
            // 
            // txtCodigoIngrediente
            // 
            this.txtCodigoIngrediente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoIngrediente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoIngrediente.Location = new System.Drawing.Point(66, 32);
            this.txtCodigoIngrediente.Name = "txtCodigoIngrediente";
            this.txtCodigoIngrediente.Size = new System.Drawing.Size(64, 30);
            this.txtCodigoIngrediente.TabIndex = 2;
            this.txtCodigoIngrediente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoIngrediente_KeyDown);
            this.txtCodigoIngrediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoIngrediente_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(205, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Ingrediente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(9, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Codigo:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtgDetalhesIngredientes);
            this.groupBox7.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox7.Location = new System.Drawing.Point(3, 328);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(671, 297);
            this.groupBox7.TabIndex = 51;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Detalhes dos Itens";
            // 
            // dtgDetalhesIngredientes
            // 
            this.dtgDetalhesIngredientes.AllowUserToAddRows = false;
            this.dtgDetalhesIngredientes.AllowUserToDeleteRows = false;
            this.dtgDetalhesIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalhesIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1});
            this.dtgDetalhesIngredientes.Location = new System.Drawing.Point(0, 29);
            this.dtgDetalhesIngredientes.Name = "dtgDetalhesIngredientes";
            this.dtgDetalhesIngredientes.ReadOnly = true;
            this.dtgDetalhesIngredientes.Size = new System.Drawing.Size(667, 260);
            this.dtgDetalhesIngredientes.TabIndex = 6;
            this.dtgDetalhesIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalhesIngredientes_CellContentClick);
            this.dtgDetalhesIngredientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgDetalhesIngredientes_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ingredientes";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Qtd";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Excluir";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // frmCompraIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 703);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCompraIngredientes";
            this.Text = "Compra de Ingredientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalhesIngredientes)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdicionarIngrediente;
        private System.Windows.Forms.TextBox txtQuantidadeIngrediente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorIngrediente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeIngrediente;
        private System.Windows.Forms.TextBox txtCodigoIngrediente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dtgDetalhesIngredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.Label label12;
    }
}

