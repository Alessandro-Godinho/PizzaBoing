namespace PizzaBoingViews
{
    partial class frmConsultaPedidosEntrega
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPedidosEntrega));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpagePedidos = new System.Windows.Forms.TabPage();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgConsultaPedidos = new System.Windows.Forms.DataGridView();
            this.tabpageItensPedido = new System.Windows.Forms.TabPage();
            this.dtgItensPedidos = new System.Windows.Forms.DataGridView();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalhes = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entregador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SituacaoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabpagePedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaPedidos)).BeginInit();
            this.tabpageItensPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpagePedidos);
            this.tabControl1.Controls.Add(this.tabpageItensPedido);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpagePedidos
            // 
            this.tabpagePedidos.Controls.Add(this.txtPesquisar);
            this.tabpagePedidos.Controls.Add(this.label6);
            this.tabpagePedidos.Controls.Add(this.dtgConsultaPedidos);
            this.tabpagePedidos.Location = new System.Drawing.Point(4, 22);
            this.tabpagePedidos.Name = "tabpagePedidos";
            this.tabpagePedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagePedidos.Size = new System.Drawing.Size(787, 326);
            this.tabpagePedidos.TabIndex = 0;
            this.tabpagePedidos.Text = "Pedidos";
            this.tabpagePedidos.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(101, 8);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(399, 20);
            this.txtPesquisar.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pesquisar:";
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
            this.Detalhes,
            this.ID,
            this.Data,
            this.Cliente,
            this.Desconto,
            this.ValorTotal,
            this.TipoPagamento,
            this.Operador,
            this.Entregador,
            this.SituacaoPedido,
            this.Cancelar});
            this.dtgConsultaPedidos.GridColor = System.Drawing.Color.Black;
            this.dtgConsultaPedidos.Location = new System.Drawing.Point(-5, 43);
            this.dtgConsultaPedidos.MultiSelect = false;
            this.dtgConsultaPedidos.Name = "dtgConsultaPedidos";
            this.dtgConsultaPedidos.ReadOnly = true;
            this.dtgConsultaPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgConsultaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConsultaPedidos.Size = new System.Drawing.Size(796, 283);
            this.dtgConsultaPedidos.TabIndex = 15;
            this.dtgConsultaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultaPedidos_CellContentClick);
            this.dtgConsultaPedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgConsultaPedidos_CellFormatting);
            // 
            // tabpageItensPedido
            // 
            this.tabpageItensPedido.Controls.Add(this.dtgItensPedidos);
            this.tabpageItensPedido.Location = new System.Drawing.Point(4, 22);
            this.tabpageItensPedido.Name = "tabpageItensPedido";
            this.tabpageItensPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageItensPedido.Size = new System.Drawing.Size(787, 326);
            this.tabpageItensPedido.TabIndex = 1;
            this.tabpageItensPedido.Text = "Detalhes do pedido";
            this.tabpageItensPedido.UseVisualStyleBackColor = true;
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
            this.dtgItensPedidos.Location = new System.Drawing.Point(0, 0);
            this.dtgItensPedidos.MultiSelect = false;
            this.dtgItensPedidos.Name = "dtgItensPedidos";
            this.dtgItensPedidos.ReadOnly = true;
            this.dtgItensPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgItensPedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgItensPedidos.Size = new System.Drawing.Size(791, 326);
            this.dtgItensPedidos.TabIndex = 2;
            this.dtgItensPedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgItensPedidos_CellFormatting);
            // 
            // Pedido
            // 
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
            this.Pedido.Width = 65;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 69;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 56;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
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
            // Detalhes
            // 
            this.Detalhes.HeaderText = "Detalhes";
            this.Detalhes.Image = ((System.Drawing.Image)(resources.GetObject("Detalhes.Image")));
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.ReadOnly = true;
            this.Detalhes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalhes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detalhes.Width = 74;
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
            this.Cliente.DataPropertyName = "Cliente";
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
            // Entregador
            // 
            this.Entregador.DataPropertyName = "Entrega";
            this.Entregador.HeaderText = "Entregador";
            this.Entregador.Name = "Entregador";
            this.Entregador.ReadOnly = true;
            this.Entregador.Width = 84;
            // 
            // SituacaoPedido
            // 
            this.SituacaoPedido.DataPropertyName = "SituacaoPedido";
            this.SituacaoPedido.HeaderText = "Situacao Pedido";
            this.SituacaoPedido.Name = "SituacaoPedido";
            this.SituacaoPedido.ReadOnly = true;
            this.SituacaoPedido.Width = 110;
            // 
            // Cancelar
            // 
            this.Cancelar.HeaderText = "Cancelar";
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.ReadOnly = true;
            this.Cancelar.Width = 55;
            // 
            // frmConsultaPedidosEntrega
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(791, 348);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "frmConsultaPedidosEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Pedidos Entregas";
            this.tabControl1.ResumeLayout(false);
            this.tabpagePedidos.ResumeLayout(false);
            this.tabpagePedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaPedidos)).EndInit();
            this.tabpageItensPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpagePedidos;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgConsultaPedidos;
        private System.Windows.Forms.TabPage tabpageItensPedido;
        private System.Windows.Forms.DataGridView dtgItensPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn Detalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entregador;
        private System.Windows.Forms.DataGridViewTextBoxColumn SituacaoPedido;
        private System.Windows.Forms.DataGridViewImageColumn Cancelar;
    }
}