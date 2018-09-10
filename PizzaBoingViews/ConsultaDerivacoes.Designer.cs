namespace PizzaBoingViews
{
    partial class frmConsultaDerivacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaDerivacoes));
            this.dtgConsultaDerivacoes = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoAbreviada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaDerivacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConsultaDerivacoes
            // 
            this.dtgConsultaDerivacoes.AllowUserToAddRows = false;
            this.dtgConsultaDerivacoes.AllowUserToDeleteRows = false;
            this.dtgConsultaDerivacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConsultaDerivacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgConsultaDerivacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgConsultaDerivacoes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgConsultaDerivacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgConsultaDerivacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.ID,
            this.Produto,
            this.Descricao,
            this.DescricaoAbreviada,
            this.Valor,
            this.Estoque});
            this.dtgConsultaDerivacoes.GridColor = System.Drawing.Color.Black;
            this.dtgConsultaDerivacoes.Location = new System.Drawing.Point(3, 38);
            this.dtgConsultaDerivacoes.MultiSelect = false;
            this.dtgConsultaDerivacoes.Name = "dtgConsultaDerivacoes";
            this.dtgConsultaDerivacoes.ReadOnly = true;
            this.dtgConsultaDerivacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgConsultaDerivacoes.Size = new System.Drawing.Size(442, 430);
            this.dtgConsultaDerivacoes.TabIndex = 0;
            this.dtgConsultaDerivacoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultaClientes_CellContentClick);
            // 
            // Selecionar
            // 
            this.Selecionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Image = ((System.Drawing.Image)(resources.GetObject("Selecionar.Image")));
            this.Selecionar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selecionar.Width = 63;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 69;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricão";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 80;
            // 
            // DescricaoAbreviada
            // 
            this.DescricaoAbreviada.DataPropertyName = "DescricaoAbreviada";
            this.DescricaoAbreviada.HeaderText = "Abrev";
            this.DescricaoAbreviada.Name = "DescricaoAbreviada";
            this.DescricaoAbreviada.ReadOnly = true;
            this.DescricaoAbreviada.Width = 60;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 56;
            // 
            // Estoque
            // 
            this.Estoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Estoque.DataPropertyName = "Estoque";
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            this.Estoque.Width = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(91, 12);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(339, 20);
            this.txtPesquisar.TabIndex = 14;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // frmConsultaDerivacoes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(442, 466);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgConsultaDerivacoes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "frmConsultaDerivacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaDerivacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dtgConsultaDerivacoes;
        private System.Windows.Forms.DataGridViewImageColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoAbreviada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
    }
}