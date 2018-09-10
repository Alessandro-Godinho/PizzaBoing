namespace PizzaBoingViews
{
    partial class frmInserirComposicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirComposicao));
            this.dtgComposicao = new System.Windows.Forms.DataGridView();
            this.btnInserirComposicao = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Descricao,
            this.Valor,
            this.Unidade,
            this.Selecionar});
            this.dtgComposicao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgComposicao.Location = new System.Drawing.Point(12, -1);
            this.dtgComposicao.Name = "dtgComposicao";
            this.dtgComposicao.ReadOnly = true;
            this.dtgComposicao.Size = new System.Drawing.Size(443, 417);
            this.dtgComposicao.TabIndex = 17;
            this.dtgComposicao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgComposicao_CellContentClick_1);
            this.dtgComposicao.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dtgComposicao_PreviewKeyDown);
            // 
            // btnInserirComposicao
            // 
            this.btnInserirComposicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirComposicao.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirComposicao.Image")));
            this.btnInserirComposicao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirComposicao.Location = new System.Drawing.Point(158, 435);
            this.btnInserirComposicao.Name = "btnInserirComposicao";
            this.btnInserirComposicao.Size = new System.Drawing.Size(118, 60);
            this.btnInserirComposicao.TabIndex = 33;
            this.btnInserirComposicao.Text = "Inserir";
            this.btnInserirComposicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirComposicao.UseVisualStyleBackColor = true;
            this.btnInserirComposicao.Click += new System.EventHandler(this.btnInserirComposicao_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Unidade
            // 
            this.Unidade.DataPropertyName = "Unidade";
            this.Unidade.HeaderText = "Unidade";
            this.Unidade.Name = "Unidade";
            this.Unidade.ReadOnly = true;
            // 
            // Selecionar
            // 
            this.Selecionar.FalseValue = "0";
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.TrueValue = "1";
            // 
            // frmInserirComposicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 524);
            this.Controls.Add(this.btnInserirComposicao);
            this.Controls.Add(this.dtgComposicao);
            this.Name = "frmInserirComposicao";
            this.Text = "InserirComposicao";
            ((System.ComponentModel.ISupportInitialize)(this.dtgComposicao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgComposicao;
        private System.Windows.Forms.Button btnInserirComposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
    }
}