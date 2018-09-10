namespace PizzaBoingViews
{
    partial class Rel_ComprasLiquidadas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rel_ComprasLiquidadas));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vendasporbairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PizzaBoingDataSet = new PizzaBoingViews.PizzaBoingDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodoInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.vendasporbairroTableAdapter = new PizzaBoingViews.PizzaBoingDataSetTableAdapters.vendasporbairroTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comprasliquidadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ta_comprasliquidadas = new PizzaBoingViews.PizzaBoingDataSetTableAdapters.ta_comprasliquidadas();
            ((System.ComponentModel.ISupportInitialize)(this.vendasporbairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaBoingDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasliquidadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendasporbairroBindingSource
            // 
            this.vendasporbairroBindingSource.DataMember = "vendasporbairro";
            this.vendasporbairroBindingSource.DataSource = this.PizzaBoingDataSet;
            // 
            // PizzaBoingDataSet
            // 
            this.PizzaBoingDataSet.DataSetName = "PizzaBoingDataSet";
            this.PizzaBoingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Controls.Add(this.dtpDataFinal);
            this.groupBox1.Controls.Add(this.dtpPeriodoInicial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnGerar);
            this.groupBox1.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 440);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório de vendas por bairros";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CustomFormat = "";
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFinal.Location = new System.Drawing.Point(333, 29);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(101, 30);
            this.dtpDataFinal.TabIndex = 57;
            // 
            // dtpPeriodoInicial
            // 
            this.dtpPeriodoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodoInicial.Location = new System.Drawing.Point(188, 29);
            this.dtpPeriodoInicial.Name = "dtpPeriodoInicial";
            this.dtpPeriodoInicial.Size = new System.Drawing.Size(106, 30);
            this.dtpPeriodoInicial.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(305, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "à:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(121, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Periodo:";
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.Black;
            this.btnGerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerar.Image")));
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerar.Location = new System.Drawing.Point(244, 74);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(118, 60);
            this.btnGerar.TabIndex = 26;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // vendasporbairroTableAdapter
            // 
            this.vendasporbairroTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dscomprasliquidadas";
            reportDataSource1.Value = this.comprasliquidadasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PizzaBoingViews.Relatorios.Rel_ComprasLiquidadas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 151);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(629, 289);
            this.reportViewer1.TabIndex = 58;
            // 
            // comprasliquidadasBindingSource
            // 
            this.comprasliquidadasBindingSource.DataMember = "comprasliquidadas";
            this.comprasliquidadasBindingSource.DataSource = this.PizzaBoingDataSet;
            // 
            // ta_comprasliquidadas
            // 
            this.ta_comprasliquidadas.ClearBeforeFill = true;
            // 
            // frmComprasLiquidadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 442);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmComprasLiquidadas";
            this.Text = "Relatório de vendas por bairros";
            this.Load += new System.EventHandler(this.frmRel_VendasPorBairroscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasporbairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaBoingDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasliquidadasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpPeriodoInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource vendasporbairroBindingSource;
        private PizzaBoingDataSet PizzaBoingDataSet;
        private PizzaBoingDataSetTableAdapters.vendasporbairroTableAdapter vendasporbairroTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource comprasliquidadasBindingSource;
        private PizzaBoingDataSetTableAdapters.ta_comprasliquidadas ta_comprasliquidadas;
    }
}