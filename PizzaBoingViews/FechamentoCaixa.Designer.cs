namespace PizzaBoingViews
{
    partial class frmFechamentoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFechamentoCaixa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtgFechamentoCaixa = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDinheiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagamentosAvista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagamentosParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagamentosServicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Despesas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFechamentoCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(294, 22);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(146, 60);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Fechar Dia";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtgFechamentoCaixa
            // 
            this.dtgFechamentoCaixa.AllowUserToAddRows = false;
            this.dtgFechamentoCaixa.AllowUserToDeleteRows = false;
            this.dtgFechamentoCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgFechamentoCaixa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgFechamentoCaixa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgFechamentoCaixa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgFechamentoCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TotalDinheiro,
            this.TotalCartao,
            this.Receitas,
            this.PagamentosAvista,
            this.PagamentosParcelas,
            this.PagamentosServicos,
            this.Despesas});
            this.dtgFechamentoCaixa.GridColor = System.Drawing.Color.Black;
            this.dtgFechamentoCaixa.Location = new System.Drawing.Point(1, 99);
            this.dtgFechamentoCaixa.MultiSelect = false;
            this.dtgFechamentoCaixa.Name = "dtgFechamentoCaixa";
            this.dtgFechamentoCaixa.ReadOnly = true;
            this.dtgFechamentoCaixa.Size = new System.Drawing.Size(765, 75);
            this.dtgFechamentoCaixa.TabIndex = 6;
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
            // TotalDinheiro
            // 
            this.TotalDinheiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalDinheiro.DataPropertyName = "TotalDinheiro";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            this.TotalDinheiro.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalDinheiro.HeaderText = "Rec. Dinheiro";
            this.TotalDinheiro.Name = "TotalDinheiro";
            this.TotalDinheiro.ReadOnly = true;
            this.TotalDinheiro.Width = 97;
            // 
            // TotalCartao
            // 
            this.TotalCartao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalCartao.DataPropertyName = "TotalCartao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            this.TotalCartao.DefaultCellStyle = dataGridViewCellStyle2;
            this.TotalCartao.HeaderText = "Rec. Cartão";
            this.TotalCartao.Name = "TotalCartao";
            this.TotalCartao.ReadOnly = true;
            this.TotalCartao.Width = 89;
            // 
            // Receitas
            // 
            this.Receitas.DataPropertyName = "Receitas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            this.Receitas.DefaultCellStyle = dataGridViewCellStyle3;
            this.Receitas.HeaderText = "Total Receitas";
            this.Receitas.Name = "Receitas";
            this.Receitas.ReadOnly = true;
            this.Receitas.Width = 101;
            // 
            // PagamentosAvista
            // 
            this.PagamentosAvista.DataPropertyName = "PagamentosAvista";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            this.PagamentosAvista.DefaultCellStyle = dataGridViewCellStyle4;
            this.PagamentosAvista.HeaderText = "Desp.  Àvista";
            this.PagamentosAvista.Name = "PagamentosAvista";
            this.PagamentosAvista.ReadOnly = true;
            this.PagamentosAvista.Width = 95;
            // 
            // PagamentosParcelas
            // 
            this.PagamentosParcelas.DataPropertyName = "PagamentosParcelas";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            this.PagamentosParcelas.DefaultCellStyle = dataGridViewCellStyle5;
            this.PagamentosParcelas.HeaderText = "Desp.  Parcelas";
            this.PagamentosParcelas.Name = "PagamentosParcelas";
            this.PagamentosParcelas.ReadOnly = true;
            this.PagamentosParcelas.Width = 107;
            // 
            // PagamentosServicos
            // 
            this.PagamentosServicos.DataPropertyName = "PagamentosServicos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            this.PagamentosServicos.DefaultCellStyle = dataGridViewCellStyle6;
            this.PagamentosServicos.HeaderText = "Desp. Servicos";
            this.PagamentosServicos.Name = "PagamentosServicos";
            this.PagamentosServicos.ReadOnly = true;
            this.PagamentosServicos.Width = 104;
            // 
            // Despesas
            // 
            this.Despesas.DataPropertyName = "Despesas";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            this.Despesas.DefaultCellStyle = dataGridViewCellStyle7;
            this.Despesas.HeaderText = "Total Despesas";
            this.Despesas.Name = "Despesas";
            this.Despesas.ReadOnly = true;
            this.Despesas.Width = 106;
            // 
            // frmFechamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 172);
            this.Controls.Add(this.dtgFechamentoCaixa);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmFechamentoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fechar Caixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgFechamentoCaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtgFechamentoCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagamentosAvista;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagamentosParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagamentosServicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Despesas;
    }
}