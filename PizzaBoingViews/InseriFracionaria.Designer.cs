namespace PizzaBoingViews
{
    partial class txtPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgComposicao = new System.Windows.Forms.DataGridView();
            this.btnInserirComposicao = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.cmbTamanho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgComposicao)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgComposicao
            // 
            this.dtgComposicao.AllowUserToAddRows = false;
            this.dtgComposicao.AllowUserToDeleteRows = false;
            this.dtgComposicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgComposicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Produto,
            this.Descricao,
            this.Valor,
            this.Selecionar});
            this.dtgComposicao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgComposicao.Location = new System.Drawing.Point(3, 141);
            this.dtgComposicao.Name = "dtgComposicao";
            this.dtgComposicao.ReadOnly = true;
            this.dtgComposicao.Size = new System.Drawing.Size(451, 442);
            this.dtgComposicao.TabIndex = 17;
            this.dtgComposicao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgComposicao_CellContentClick_1);
            this.dtgComposicao.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dtgComposicao_PreviewKeyDown);
            // 
            // btnInserirComposicao
            // 
            this.btnInserirComposicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirComposicao.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirComposicao.Image")));
            this.btnInserirComposicao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirComposicao.Location = new System.Drawing.Point(294, 15);
            this.btnInserirComposicao.Name = "btnInserirComposicao";
            this.btnInserirComposicao.Size = new System.Drawing.Size(118, 60);
            this.btnInserirComposicao.TabIndex = 33;
            this.btnInserirComposicao.Text = "Inserir";
            this.btnInserirComposicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirComposicao.UseVisualStyleBackColor = true;
            this.btnInserirComposicao.Click += new System.EventHandler(this.btnInserirComposicao_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Insira a quantidade:";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(169, 15);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(47, 20);
            this.txtQtd.TabIndex = 35;
            // 
            // cmbTamanho
            // 
            this.cmbTamanho.FormattingEnabled = true;
            this.cmbTamanho.Location = new System.Drawing.Point(96, 57);
            this.cmbTamanho.Name = "cmbTamanho";
            this.cmbTamanho.Size = new System.Drawing.Size(159, 21);
            this.cmbTamanho.TabIndex = 36;
            this.cmbTamanho.SelectedIndexChanged += new System.EventHandler(this.cmbTamanho_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tamanho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Pesquisa:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(96, 103);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(230, 20);
            this.txtPesquisar.TabIndex = 39;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Produto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Selecionar
            // 
            this.Selecionar.FalseValue = "0";
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.TrueValue = "1";
            // 
            // txtPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 583);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTamanho);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInserirComposicao);
            this.Controls.Add(this.dtgComposicao);
            this.Name = "txtPesquisa";
            this.Text = "Selecionar Produtos Fracionários";
            this.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtgComposicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgComposicao;
        private System.Windows.Forms.Button btnInserirComposicao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.ComboBox cmbTamanho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
    }
}