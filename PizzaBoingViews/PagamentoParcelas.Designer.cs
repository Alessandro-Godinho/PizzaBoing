namespace PizzaBoingViews
{
    partial class frmPagamentoParcelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamentoParcelas));
            this.dtgParcelas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagar_Estornar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgParcelas
            // 
            this.dtgParcelas.AllowUserToAddRows = false;
            this.dtgParcelas.AllowUserToDeleteRows = false;
            this.dtgParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Compra,
            this.Vencimento,
            this.Valor,
            this.Situacao,
            this.Pagar_Estornar});
            this.dtgParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgParcelas.Location = new System.Drawing.Point(0, 0);
            this.dtgParcelas.Name = "dtgParcelas";
            this.dtgParcelas.ReadOnly = true;
            this.dtgParcelas.Size = new System.Drawing.Size(545, 307);
            this.dtgParcelas.TabIndex = 0;
            this.dtgParcelas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgParcelas_CellContentClick);
            this.dtgParcelas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgParcelas_CellFormatting);
            this.dtgParcelas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgParcelas_RowPostPaint);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Compra
            // 
            this.Compra.HeaderText = "Compra";
            this.Compra.Name = "Compra";
            this.Compra.ReadOnly = true;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "DataVencimento";
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "ValorParcela";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "SituacaoPagamento";
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // Pagar_Estornar
            // 
            this.Pagar_Estornar.HeaderText = "Pagar/Estornar";
            this.Pagar_Estornar.Image = ((System.Drawing.Image)(resources.GetObject("Pagar_Estornar.Image")));
            this.Pagar_Estornar.Name = "Pagar_Estornar";
            this.Pagar_Estornar.ReadOnly = true;
            // 
            // frmPagamentoParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 307);
            this.Controls.Add(this.dtgParcelas);
            this.Name = "frmPagamentoParcelas";
            this.Text = "Pagamento de Parcelas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewImageColumn Pagar_Estornar;
    }
}