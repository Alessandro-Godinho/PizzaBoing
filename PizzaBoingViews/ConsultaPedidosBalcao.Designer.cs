namespace PizzaBoingViews
{
    partial class frmConsultaPedidosBalcao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPedidosBalcao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgConsultaPedidos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpagePedidos = new System.Windows.Forms.TabPage();
            this.tabpageItens = new System.Windows.Forms.TabPage();
            this.dtgItensPedidos = new System.Windows.Forms.DataGridView();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaPedidos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabpagePedidos.SuspendLayout();
            this.tabpageItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConsultaPedidos
            // 
            this.dtgConsultaPedidos.AllowUserToAddRows = false;
            this.dtgConsultaPedidos.AllowUserToDeleteRows = false;
            this.dtgConsultaPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConsultaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgConsultaPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgConsultaPedidos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgConsultaPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgConsultaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Details,
            this.ID,
            this.Data,
            this.Cliente,
            this.Desconto,
            this.ValorTotal,
            this.TipoPagamento,
            this.Operador});
            this.dtgConsultaPedidos.GridColor = System.Drawing.Color.Black;
            this.dtgConsultaPedidos.Location = new System.Drawing.Point(-1, 65);
            this.dtgConsultaPedidos.MultiSelect = false;
            this.dtgConsultaPedidos.Name = "dtgConsultaPedidos";
            this.dtgConsultaPedidos.ReadOnly = true;
            this.dtgConsultaPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgConsultaPedidos.Size = new System.Drawing.Size(713, 421);
            this.dtgConsultaPedidos.TabIndex = 0;
            this.dtgConsultaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultaPedidos_CellContentClick);
            this.dtgConsultaPedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgConsultaPedidos_CellFormatting);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(98, 28);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(399, 20);
            this.txtPesquisar.TabIndex = 14;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpagePedidos);
            this.tabControl1.Controls.Add(this.tabpageItens);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 518);
            this.tabControl1.TabIndex = 15;
            // 
            // tabpagePedidos
            // 
            this.tabpagePedidos.Controls.Add(this.dtgConsultaPedidos);
            this.tabpagePedidos.Controls.Add(this.txtPesquisar);
            this.tabpagePedidos.Controls.Add(this.label6);
            this.tabpagePedidos.Location = new System.Drawing.Point(4, 22);
            this.tabpagePedidos.Name = "tabpagePedidos";
            this.tabpagePedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagePedidos.Size = new System.Drawing.Size(712, 492);
            this.tabpagePedidos.TabIndex = 0;
            this.tabpagePedidos.Text = "Pedidos";
            this.tabpagePedidos.UseVisualStyleBackColor = true;
            // 
            // tabpageItens
            // 
            this.tabpageItens.Controls.Add(this.dtgItensPedidos);
            this.tabpageItens.Location = new System.Drawing.Point(4, 22);
            this.tabpageItens.Name = "tabpageItens";
            this.tabpageItens.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageItens.Size = new System.Drawing.Size(712, 492);
            this.tabpageItens.TabIndex = 1;
            this.tabpageItens.Text = "Detalhes do pedido";
            this.tabpageItens.UseVisualStyleBackColor = true;
            // 
            // dtgItensPedidos
            // 
            this.dtgItensPedidos.AllowUserToAddRows = false;
            this.dtgItensPedidos.AllowUserToDeleteRows = false;
            this.dtgItensPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgItensPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgItensPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgItensPedidos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgItensPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgItensPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pedido,
            this.Produto,
            this.Valor,
            this.Quantidade,
            this.Total});
            this.dtgItensPedidos.GridColor = System.Drawing.Color.Black;
            this.dtgItensPedidos.Location = new System.Drawing.Point(-4, 6);
            this.dtgItensPedidos.MultiSelect = false;
            this.dtgItensPedidos.Name = "dtgItensPedidos";
            this.dtgItensPedidos.ReadOnly = true;
            this.dtgItensPedidos.Size = new System.Drawing.Size(713, 480);
            this.dtgItensPedidos.TabIndex = 1;
            this.dtgItensPedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgItensPedidos_CellFormatting);
            // 
            // Pedido
            // 
            this.Pedido.DataPropertyName = "ID";
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
            this.Pedido.Width = 65;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto + Derivacao";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 69;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 56;
            // 
            // Quantidade
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 87;
            // 
            // Total
            // 
            this.Total.HeaderText = "Valor Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 83;
            // 
            // Details
            // 
            this.Details.HeaderText = "Detalhes";
            this.Details.Image = ((System.Drawing.Image)(resources.GetObject("Details.Image")));
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 55;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DataVenda";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 55;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cliente.DataPropertyName = "Nome";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 64;
            // 
            // Desconto
            // 
            this.Desconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Desconto.DataPropertyName = "Desconto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.Desconto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            this.Desconto.Width = 78;
            // 
            // ValorTotal
            // 
            this.ValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 80;
            // 
            // TipoPagamento
            // 
            this.TipoPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipoPagamento.DataPropertyName = "TipoPagamento";
            this.TipoPagamento.HeaderText = "TipoPagamento";
            this.TipoPagamento.Name = "TipoPagamento";
            this.TipoPagamento.ReadOnly = true;
            this.TipoPagamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoPagamento.Width = 107;
            // 
            // Operador
            // 
            this.Operador.DataPropertyName = "Funcionario";
            this.Operador.HeaderText = "Operador";
            this.Operador.Name = "Operador";
            this.Operador.ReadOnly = true;
            this.Operador.Width = 76;
            // 
            // frmConsultaPedidosBalcao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(714, 512);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "frmConsultaPedidosBalcao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Pedidos Entregas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaPedidos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabpagePedidos.ResumeLayout(false);
            this.tabpagePedidos.PerformLayout();
            this.tabpageItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dtgConsultaPedidos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpagePedidos;
        private System.Windows.Forms.TabPage tabpageItens;
        private System.Windows.Forms.DataGridView dtgItensPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
    }
}