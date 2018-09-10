namespace PizzaBoingViews
{
    partial class frmPagamentoServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamentoServico));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsultarServico = new System.Windows.Forms.Button();
            this.btnAdicionarServico = new System.Windows.Forms.Button();
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.txtCodigoServico = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dtpDataVencimento);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.btnConsultarServico);
            this.groupBox9.Controls.Add(this.btnAdicionarServico);
            this.groupBox9.Controls.Add(this.txtValorServico);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.txtNomeServico);
            this.groupBox9.Controls.Add(this.txtCodigoServico);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox9.Location = new System.Drawing.Point(2, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(660, 131);
            this.groupBox9.TabIndex = 50;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Pagamentos de Serviços";
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(327, 83);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(87, 30);
            this.dtpDataVencimento.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(201, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Data Vencimento:";
            // 
            // btnConsultarServico
            // 
            this.btnConsultarServico.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarServico.Image")));
            this.btnConsultarServico.Location = new System.Drawing.Point(123, 32);
            this.btnConsultarServico.Name = "btnConsultarServico";
            this.btnConsultarServico.Size = new System.Drawing.Size(57, 31);
            this.btnConsultarServico.TabIndex = 49;
            this.btnConsultarServico.UseVisualStyleBackColor = true;
            this.btnConsultarServico.Click += new System.EventHandler(this.btnConsultarServico_Click);
            // 
            // btnAdicionarServico
            // 
            this.btnAdicionarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarServico.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarServico.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarServico.Image")));
            this.btnAdicionarServico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarServico.Location = new System.Drawing.Point(445, 69);
            this.btnAdicionarServico.Name = "btnAdicionarServico";
            this.btnAdicionarServico.Size = new System.Drawing.Size(103, 54);
            this.btnAdicionarServico.TabIndex = 5;
            this.btnAdicionarServico.Text = "Pagar:";
            this.btnAdicionarServico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarServico.UseVisualStyleBackColor = true;
            this.btnAdicionarServico.Click += new System.EventHandler(this.btnAdicionarServico_Click);
            // 
            // txtValorServico
            // 
            this.txtValorServico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtValorServico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtValorServico.Location = new System.Drawing.Point(116, 83);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Size = new System.Drawing.Size(64, 30);
            this.txtValorServico.TabIndex = 44;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(9, 90);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 17);
            this.label24.TabIndex = 43;
            this.label24.Text = "Valor Serviço:";
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeServico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeServico.Enabled = false;
            this.txtNomeServico.Location = new System.Drawing.Point(250, 33);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(391, 30);
            this.txtNomeServico.TabIndex = 42;
            // 
            // txtCodigoServico
            // 
            this.txtCodigoServico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodigoServico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodigoServico.Location = new System.Drawing.Point(66, 32);
            this.txtCodigoServico.Name = "txtCodigoServico";
            this.txtCodigoServico.Size = new System.Drawing.Size(51, 30);
            this.txtCodigoServico.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(185, 39);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 17);
            this.label25.TabIndex = 41;
            this.label25.Text = "Serviço:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label26.Location = new System.Drawing.Point(9, 39);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 17);
            this.label26.TabIndex = 39;
            this.label26.Text = "Codigo:";
            // 
            // frmPagamentoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 137);
            this.Controls.Add(this.groupBox9);
            this.Name = "frmPagamentoServico";
            this.Text = "Pagamento de serviços";
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultarServico;
        private System.Windows.Forms.Button btnAdicionarServico;
        private System.Windows.Forms.TextBox txtValorServico;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.TextBox txtCodigoServico;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
    }
}