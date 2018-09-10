namespace PizzaBoingViews
{
    partial class frmCadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProdutos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInserirComposicao = new System.Windows.Forms.Button();
            this.dtgComposicao = new System.Windows.Forms.DataGridView();
            this.Ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.grbComposicao = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabpageCadProdutos = new System.Windows.Forms.TabPage();
            this.tabpageDerivados = new System.Windows.Forms.TabPage();
            this.grbDerivados = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgDerivados = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.chkPermiteEstoqueNegativo = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricaoDerivados = new System.Windows.Forms.TextBox();
            this.txtDescricaoAbreviada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelarDerivados = new System.Windows.Forms.Button();
            this.btnAdicionarDerivados = new System.Windows.Forms.Button();
            this.tabpageComposicao = new System.Windows.Forms.TabPage();
            this.Alterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdDeriva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescAbreviada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueNegativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddEstoque = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgComposicao)).BeginInit();
            this.grbProdutos.SuspendLayout();
            this.grbComposicao.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabProdutos.SuspendLayout();
            this.tabpageCadProdutos.SuspendLayout();
            this.tabpageDerivados.SuspendLayout();
            this.grbDerivados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDerivados)).BeginInit();
            this.tabpageComposicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(90, 55);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(370, 30);
            this.txtDescricao.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DisplayMember = "Nome";
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(90, 100);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(270, 31);
            this.cmbCategoria.TabIndex = 11;
            this.cmbCategoria.ValueMember = "ID";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(91, 165);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 60);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(227, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 60);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Adicionar nova composição:";
            // 
            // btnInserirComposicao
            // 
            this.btnInserirComposicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirComposicao.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirComposicao.Image")));
            this.btnInserirComposicao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirComposicao.Location = new System.Drawing.Point(440, 29);
            this.btnInserirComposicao.Name = "btnInserirComposicao";
            this.btnInserirComposicao.Size = new System.Drawing.Size(118, 60);
            this.btnInserirComposicao.TabIndex = 32;
            this.btnInserirComposicao.Text = "Inserir";
            this.btnInserirComposicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirComposicao.UseVisualStyleBackColor = true;
            this.btnInserirComposicao.Click += new System.EventHandler(this.btnInserirComposicao_Click);
            // 
            // dtgComposicao
            // 
            this.dtgComposicao.AllowUserToAddRows = false;
            this.dtgComposicao.AllowUserToDeleteRows = false;
            this.dtgComposicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgComposicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ids,
            this.Ingredientes,
            this.Deletar});
            this.dtgComposicao.Location = new System.Drawing.Point(6, 96);
            this.dtgComposicao.Name = "dtgComposicao";
            this.dtgComposicao.ReadOnly = true;
            this.dtgComposicao.Size = new System.Drawing.Size(561, 249);
            this.dtgComposicao.TabIndex = 33;
            this.dtgComposicao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgComposicao_CellContentClick);
            // 
            // Ids
            // 
            this.Ids.DataPropertyName = "ID";
            this.Ids.HeaderText = "ID";
            this.Ids.Name = "Ids";
            this.Ids.ReadOnly = true;
            this.Ids.Visible = false;
            // 
            // Ingredientes
            // 
            this.Ingredientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ingredientes.DataPropertyName = "Ingrediente";
            this.Ingredientes.HeaderText = "Ingredientes";
            this.Ingredientes.Name = "Ingredientes";
            this.Ingredientes.ReadOnly = true;
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Image = ((System.Drawing.Image)(resources.GetObject("Deletar.Image")));
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            // 
            // grbProdutos
            // 
            this.grbProdutos.Controls.Add(this.label1);
            this.grbProdutos.Controls.Add(this.txtDescricao);
            this.grbProdutos.Controls.Add(this.btnCancelar);
            this.grbProdutos.Controls.Add(this.btnSalvar);
            this.grbProdutos.Controls.Add(this.label5);
            this.grbProdutos.Controls.Add(this.cmbCategoria);
            this.grbProdutos.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold);
            this.grbProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbProdutos.Location = new System.Drawing.Point(0, 3);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Size = new System.Drawing.Size(573, 460);
            this.grbProdutos.TabIndex = 34;
            this.grbProdutos.TabStop = false;
            this.grbProdutos.Text = "Cadastro de produtos";
            // 
            // grbComposicao
            // 
            this.grbComposicao.Controls.Add(this.label7);
            this.grbComposicao.Controls.Add(this.btnInserirComposicao);
            this.grbComposicao.Controls.Add(this.dtgComposicao);
            this.grbComposicao.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold);
            this.grbComposicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbComposicao.Location = new System.Drawing.Point(3, 3);
            this.grbComposicao.Name = "grbComposicao";
            this.grbComposicao.Size = new System.Drawing.Size(881, 449);
            this.grbComposicao.TabIndex = 35;
            this.grbComposicao.TabStop = false;
            this.grbComposicao.Text = "Inserir composição";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConsulta);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCodigoProduto);
            this.groupBox3.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(254)))));
            this.groupBox3.Location = new System.Drawing.Point(2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(896, 90);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produtos";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.Location = new System.Drawing.Point(135, 39);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(57, 30);
            this.btnConsulta.TabIndex = 39;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.Location = new System.Drawing.Point(198, 32);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(86, 43);
            this.btnNovo.TabIndex = 37;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Código:";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(72, 39);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(62, 30);
            this.txtCodigoProduto.TabIndex = 38;
            this.txtCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProduto_KeyDown);
            this.txtCodigoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProduto_KeyPress);
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabpageCadProdutos);
            this.tabProdutos.Controls.Add(this.tabpageDerivados);
            this.tabProdutos.Controls.Add(this.tabpageComposicao);
            this.tabProdutos.Location = new System.Drawing.Point(2, 99);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(581, 492);
            this.tabProdutos.TabIndex = 37;
            // 
            // tabpageCadProdutos
            // 
            this.tabpageCadProdutos.Controls.Add(this.grbProdutos);
            this.tabpageCadProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabpageCadProdutos.Name = "tabpageCadProdutos";
            this.tabpageCadProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageCadProdutos.Size = new System.Drawing.Size(573, 466);
            this.tabpageCadProdutos.TabIndex = 0;
            this.tabpageCadProdutos.Text = "Cadastro de Produtos";
            this.tabpageCadProdutos.UseVisualStyleBackColor = true;
            // 
            // tabpageDerivados
            // 
            this.tabpageDerivados.Controls.Add(this.grbDerivados);
            this.tabpageDerivados.Location = new System.Drawing.Point(4, 22);
            this.tabpageDerivados.Name = "tabpageDerivados";
            this.tabpageDerivados.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageDerivados.Size = new System.Drawing.Size(573, 466);
            this.tabpageDerivados.TabIndex = 1;
            this.tabpageDerivados.Text = "Derivados";
            this.tabpageDerivados.UseVisualStyleBackColor = true;
            // 
            // grbDerivados
            // 
            this.grbDerivados.Controls.Add(this.txtValor);
            this.grbDerivados.Controls.Add(this.label2);
            this.grbDerivados.Controls.Add(this.dtgDerivados);
            this.grbDerivados.Controls.Add(this.label10);
            this.grbDerivados.Controls.Add(this.txtEstoque);
            this.grbDerivados.Controls.Add(this.chkPermiteEstoqueNegativo);
            this.grbDerivados.Controls.Add(this.label8);
            this.grbDerivados.Controls.Add(this.txtDescricaoDerivados);
            this.grbDerivados.Controls.Add(this.txtDescricaoAbreviada);
            this.grbDerivados.Controls.Add(this.label9);
            this.grbDerivados.Controls.Add(this.btnCancelarDerivados);
            this.grbDerivados.Controls.Add(this.btnAdicionarDerivados);
            this.grbDerivados.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold);
            this.grbDerivados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbDerivados.Location = new System.Drawing.Point(0, 0);
            this.grbDerivados.Name = "grbDerivados";
            this.grbDerivados.Size = new System.Drawing.Size(571, 476);
            this.grbDerivados.TabIndex = 36;
            this.grbDerivados.TabStop = false;
            this.grbDerivados.Text = "Cadastro de derivados";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(494, 55);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(73, 30);
            this.txtValor.TabIndex = 2;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Valor:";
            // 
            // dtgDerivados
            // 
            this.dtgDerivados.AllowUserToAddRows = false;
            this.dtgDerivados.AllowUserToDeleteRows = false;
            this.dtgDerivados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgDerivados.ColumnHeadersHeight = 30;
            this.dtgDerivados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alterar,
            this.IdDeriva,
            this.Produto,
            this.Descricao,
            this.DescAbreviada,
            this.Valor,
            this.Estoque,
            this.EstoqueNegativo,
            this.AddEstoque,
            this.Excluir});
            this.dtgDerivados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgDerivados.Location = new System.Drawing.Point(-4, 172);
            this.dtgDerivados.Name = "dtgDerivados";
            this.dtgDerivados.ReadOnly = true;
            this.dtgDerivados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgDerivados.Size = new System.Drawing.Size(575, 291);
            this.dtgDerivados.TabIndex = 31;
            this.dtgDerivados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDerivados_CellContentClick);
            this.dtgDerivados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgDerivados_CellFormatting);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(90, 111);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(50, 30);
            this.txtEstoque.TabIndex = 3;
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoque_KeyPress);
            // 
            // chkPermiteEstoqueNegativo
            // 
            this.chkPermiteEstoqueNegativo.AutoSize = true;
            this.chkPermiteEstoqueNegativo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPermiteEstoqueNegativo.Location = new System.Drawing.Point(149, 112);
            this.chkPermiteEstoqueNegativo.Name = "chkPermiteEstoqueNegativo";
            this.chkPermiteEstoqueNegativo.Size = new System.Drawing.Size(146, 29);
            this.chkPermiteEstoqueNegativo.TabIndex = 4;
            this.chkPermiteEstoqueNegativo.Text = "estoque negativo";
            this.chkPermiteEstoqueNegativo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Descrição:";
            // 
            // txtDescricaoDerivados
            // 
            this.txtDescricaoDerivados.Location = new System.Drawing.Point(90, 55);
            this.txtDescricaoDerivados.Name = "txtDescricaoDerivados";
            this.txtDescricaoDerivados.Size = new System.Drawing.Size(167, 30);
            this.txtDescricaoDerivados.TabIndex = 0;
            // 
            // txtDescricaoAbreviada
            // 
            this.txtDescricaoAbreviada.Location = new System.Drawing.Point(355, 55);
            this.txtDescricaoAbreviada.Name = "txtDescricaoAbreviada";
            this.txtDescricaoAbreviada.Size = new System.Drawing.Size(77, 30);
            this.txtDescricaoAbreviada.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Desc Abrev:";
            // 
            // btnCancelarDerivados
            // 
            this.btnCancelarDerivados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDerivados.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarDerivados.Image")));
            this.btnCancelarDerivados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarDerivados.Location = new System.Drawing.Point(440, 101);
            this.btnCancelarDerivados.Name = "btnCancelarDerivados";
            this.btnCancelarDerivados.Size = new System.Drawing.Size(99, 50);
            this.btnCancelarDerivados.TabIndex = 6;
            this.btnCancelarDerivados.Text = "Cancelar";
            this.btnCancelarDerivados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarDerivados.UseVisualStyleBackColor = true;
            this.btnCancelarDerivados.Click += new System.EventHandler(this.btnCancelarDerivados_Click);
            // 
            // btnAdicionarDerivados
            // 
            this.btnAdicionarDerivados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarDerivados.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarDerivados.Image")));
            this.btnAdicionarDerivados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarDerivados.Location = new System.Drawing.Point(340, 101);
            this.btnAdicionarDerivados.Name = "btnAdicionarDerivados";
            this.btnAdicionarDerivados.Size = new System.Drawing.Size(83, 50);
            this.btnAdicionarDerivados.TabIndex = 5;
            this.btnAdicionarDerivados.Text = "Add";
            this.btnAdicionarDerivados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarDerivados.UseVisualStyleBackColor = true;
            this.btnAdicionarDerivados.Click += new System.EventHandler(this.btnAdicionarDerivados_Click);
            // 
            // tabpageComposicao
            // 
            this.tabpageComposicao.Controls.Add(this.grbComposicao);
            this.tabpageComposicao.Location = new System.Drawing.Point(4, 22);
            this.tabpageComposicao.Name = "tabpageComposicao";
            this.tabpageComposicao.Size = new System.Drawing.Size(573, 466);
            this.tabpageComposicao.TabIndex = 3;
            this.tabpageComposicao.Text = "Composição";
            this.tabpageComposicao.UseVisualStyleBackColor = true;
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "Editar";
            this.Alterar.Image = ((System.Drawing.Image)(resources.GetObject("Alterar.Image")));
            this.Alterar.Name = "Alterar";
            this.Alterar.ReadOnly = true;
            // 
            // IdDeriva
            // 
            this.IdDeriva.DataPropertyName = "ID";
            this.IdDeriva.HeaderText = "IdDeriva";
            this.IdDeriva.Name = "IdDeriva";
            this.IdDeriva.ReadOnly = true;
            this.IdDeriva.Visible = false;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // DescAbreviada
            // 
            this.DescAbreviada.DataPropertyName = "DescricaoAbreviada";
            this.DescAbreviada.HeaderText = "Desc.Abreviada";
            this.DescAbreviada.Name = "DescAbreviada";
            this.DescAbreviada.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.DataPropertyName = "Estoque";
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            // 
            // EstoqueNegativo
            // 
            this.EstoqueNegativo.DataPropertyName = "PermiteEstoqueNegativo";
            this.EstoqueNegativo.HeaderText = "Est. Negativo";
            this.EstoqueNegativo.Name = "EstoqueNegativo";
            this.EstoqueNegativo.ReadOnly = true;
            // 
            // AddEstoque
            // 
            this.AddEstoque.HeaderText = "Add Estoque";
            this.AddEstoque.Image = ((System.Drawing.Image)(resources.GetObject("AddEstoque.Image")));
            this.AddEstoque.Name = "AddEstoque";
            this.AddEstoque.ReadOnly = true;
            this.AddEstoque.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddEstoque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            // 
            // frmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(581, 592);
            this.Controls.Add(this.tabProdutos);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgComposicao)).EndInit();
            this.grbProdutos.ResumeLayout(false);
            this.grbProdutos.PerformLayout();
            this.grbComposicao.ResumeLayout(false);
            this.grbComposicao.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabProdutos.ResumeLayout(false);
            this.tabpageCadProdutos.ResumeLayout(false);
            this.tabpageDerivados.ResumeLayout(false);
            this.grbDerivados.ResumeLayout(false);
            this.grbDerivados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDerivados)).EndInit();
            this.tabpageComposicao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInserirComposicao;
        private System.Windows.Forms.DataGridView dtgComposicao;
        private System.Windows.Forms.GroupBox grbProdutos;
        private System.Windows.Forms.GroupBox grbComposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredientes;
        private System.Windows.Forms.DataGridViewImageColumn Deletar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.TabControl tabProdutos;
        private System.Windows.Forms.TabPage tabpageCadProdutos;
        private System.Windows.Forms.TabPage tabpageDerivados;
        private System.Windows.Forms.GroupBox grbDerivados;
        private System.Windows.Forms.DataGridView dtgDerivados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.CheckBox chkPermiteEstoqueNegativo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescricaoDerivados;
        private System.Windows.Forms.TextBox txtDescricaoAbreviada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelarDerivados;
        private System.Windows.Forms.Button btnAdicionarDerivados;
        private System.Windows.Forms.TabPage tabpageComposicao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn Alterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDeriva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescAbreviada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueNegativo;
        private System.Windows.Forms.DataGridViewImageColumn AddEstoque;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
    }
}