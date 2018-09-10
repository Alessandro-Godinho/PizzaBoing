namespace PizzaBoingViews
{
    partial class frmPedidosBalcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosBalcao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDataCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMsgEstoque = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblfracionaria = new System.Windows.Forms.Label();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgDetalhePedidos = new System.Windows.Forms.DataGridView();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnGravarPedido = new System.Windows.Forms.Button();
            this.lblTroco = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrocoPara = new System.Windows.Forms.TextBox();
            this.cmbModoPagamento = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalhePedidos)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(157, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(345, 30);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome/Observação:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOperador);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 119);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observação";
            // 
            // txtOperador
            // 
            this.txtOperador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtOperador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOperador.Enabled = false;
            this.txtOperador.Location = new System.Drawing.Point(157, 74);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(215, 30);
            this.txtOperador.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(78, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Operador:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDataCompra);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCodigoPedido);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 71);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informação do Pedido";
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDataCompra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDataCompra.Enabled = false;
            this.txtDataCompra.Location = new System.Drawing.Point(291, 32);
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(293, 30);
            this.txtDataCompra.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(196, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Data e Hora:";
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoPedido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoPedido.Enabled = false;
            this.txtCodigoPedido.Location = new System.Drawing.Point(71, 32);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(102, 30);
            this.txtCodigoPedido.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Pedido:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMsgEstoque);
            this.groupBox4.Controls.Add(this.btnConsulta);
            this.groupBox4.Controls.Add(this.lblfracionaria);
            this.groupBox4.Controls.Add(this.btnAdicionarProduto);
            this.groupBox4.Controls.Add(this.txtQuantidade);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtValorProduto);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtNomeProduto);
            this.groupBox4.Controls.Add(this.txtCodigoProduto);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox4.Location = new System.Drawing.Point(3, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(671, 141);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Itens do Pedido";
            // 
            // lblMsgEstoque
            // 
            this.lblMsgEstoque.AutoSize = true;
            this.lblMsgEstoque.Font = new System.Drawing.Font("Bodoni MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMsgEstoque.Location = new System.Drawing.Point(424, 75);
            this.lblMsgEstoque.Name = "lblMsgEstoque";
            this.lblMsgEstoque.Size = new System.Drawing.Size(192, 56);
            this.lblMsgEstoque.TabIndex = 50;
            this.lblMsgEstoque.Text = "Atenção!! Produto sem estoque, \r\nverifique se o produto está marcado\r\npara aceita" +
    "r estoque negativo,\r\ncaso contrario, a venda não será efetuada\r\n";
            this.lblMsgEstoque.Visible = false;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.Location = new System.Drawing.Point(136, 32);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(57, 31);
            this.btnConsulta.TabIndex = 49;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblfracionaria
            // 
            this.lblfracionaria.AutoSize = true;
            this.lblfracionaria.Font = new System.Drawing.Font("Bodoni MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfracionaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblfracionaria.Location = new System.Drawing.Point(9, 65);
            this.lblfracionaria.Name = "lblfracionaria";
            this.lblfracionaria.Size = new System.Drawing.Size(168, 14);
            this.lblfracionaria.TabIndex = 48;
            this.lblfracionaria.Text = "Aperte \"/\" para inserir fracionárias";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProduto.Image")));
            this.btnAdicionarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(273, 75);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(129, 54);
            this.btnAdicionarProduto.TabIndex = 5;
            this.btnAdicionarProduto.Text = "Adicionar:";
            this.btnAdicionarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQuantidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtQuantidade.Location = new System.Drawing.Point(182, 87);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(64, 30);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(141, 94);
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
            this.txtValorProduto.Location = new System.Drawing.Point(66, 87);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(64, 30);
            this.txtValorProduto.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(19, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "Valor:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(273, 33);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(392, 30);
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
            this.txtCodigoProduto.TextChanged += new System.EventHandler(this.txtCodigoProduto_TextChanged);
            this.txtCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProduto_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(205, 40);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgDetalhePedidos);
            this.groupBox5.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox5.Location = new System.Drawing.Point(3, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(671, 397);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detalhes dos Itens";
            // 
            // dtgDetalhePedidos
            // 
            this.dtgDetalhePedidos.AllowUserToAddRows = false;
            this.dtgDetalhePedidos.AllowUserToDeleteRows = false;
            this.dtgDetalhePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalhePedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.colProduto,
            this.colQuantidades,
            this.colValor,
            this.Fracao,
            this.IdFracao,
            this.colExcluir});
            this.dtgDetalhePedidos.Location = new System.Drawing.Point(0, 29);
            this.dtgDetalhePedidos.Name = "dtgDetalhePedidos";
            this.dtgDetalhePedidos.ReadOnly = true;
            this.dtgDetalhePedidos.Size = new System.Drawing.Size(671, 399);
            this.dtgDetalhePedidos.TabIndex = 6;
            this.dtgDetalhePedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalhePedidos_CellContentClick);
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
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.colValor.DefaultCellStyle = dataGridViewCellStyle1;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // Fracao
            // 
            this.Fracao.HeaderText = "Fracionada";
            this.Fracao.Name = "Fracao";
            this.Fracao.ReadOnly = true;
            this.Fracao.Visible = false;
            // 
            // IdFracao
            // 
            this.IdFracao.HeaderText = "IdFracao";
            this.IdFracao.Name = "IdFracao";
            this.IdFracao.ReadOnly = true;
            this.IdFracao.Visible = false;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Excluir";
            this.colExcluir.Image = ((System.Drawing.Image)(resources.GetObject("colExcluir.Image")));
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtDesconto);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.btnGravarPedido);
            this.groupBox6.Controls.Add(this.lblTroco);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.lblValorTotal);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtTrocoPara);
            this.groupBox6.Controls.Add(this.cmbModoPagamento);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox6.Location = new System.Drawing.Point(3, 753);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(671, 102);
            this.groupBox6.TabIndex = 45;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Informação de Pagamento";
            // 
            // txtDesconto
            // 
            this.txtDesconto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDesconto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDesconto.Location = new System.Drawing.Point(267, 68);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(64, 30);
            this.txtDesconto.TabIndex = 9;
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(189, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 17);
            this.label22.TabIndex = 55;
            this.label22.Text = "Desconto:";
            // 
            // btnGravarPedido
            // 
            this.btnGravarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarPedido.ForeColor = System.Drawing.Color.Black;
            this.btnGravarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnGravarPedido.Image")));
            this.btnGravarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarPedido.Location = new System.Drawing.Point(522, 35);
            this.btnGravarPedido.Name = "btnGravarPedido";
            this.btnGravarPedido.Size = new System.Drawing.Size(129, 54);
            this.btnGravarPedido.TabIndex = 10;
            this.btnGravarPedido.Text = "Gravar:";
            this.btnGravarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravarPedido.UseVisualStyleBackColor = true;
            this.btnGravarPedido.Click += new System.EventHandler(this.btnGravarPedido_Click);
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.Blue;
            this.lblTroco.Location = new System.Drawing.Point(423, 72);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(19, 20);
            this.lblTroco.TabIndex = 54;
            this.lblTroco.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(376, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 17);
            this.label21.TabIndex = 52;
            this.label21.Text = "Troco:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.Red;
            this.lblValorTotal.Location = new System.Drawing.Point(423, 39);
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
            this.label3.Location = new System.Drawing.Point(344, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Valor Total:";
            // 
            // txtTrocoPara
            // 
            this.txtTrocoPara.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTrocoPara.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTrocoPara.Location = new System.Drawing.Point(267, 33);
            this.txtTrocoPara.Name = "txtTrocoPara";
            this.txtTrocoPara.Size = new System.Drawing.Size(64, 30);
            this.txtTrocoPara.TabIndex = 8;
            this.txtTrocoPara.Validated += new System.EventHandler(this.txtTrocoPara_Validated);
            // 
            // cmbModoPagamento
            // 
            this.cmbModoPagamento.FormattingEnabled = true;
            this.cmbModoPagamento.Location = new System.Drawing.Point(60, 47);
            this.cmbModoPagamento.Name = "cmbModoPagamento";
            this.cmbModoPagamento.Size = new System.Drawing.Size(113, 31);
            this.cmbModoPagamento.TabIndex = 7;
            this.cmbModoPagamento.SelectedIndexChanged += new System.EventHandler(this.cmbModoPagamento_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(179, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 17);
            this.label18.TabIndex = 41;
            this.label18.Text = "Troco para:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(9, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "Modo:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmPedidosBalcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 856);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPedidosBalcao";
            this.Text = "Pedidos no Balcão";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalhePedidos)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDataCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgDetalhePedidos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnGravarPedido;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrocoPara;
        private System.Windows.Forms.ComboBox cmbModoPagamento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblfracionaria;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblMsgEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFracao;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

