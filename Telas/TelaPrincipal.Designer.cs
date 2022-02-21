
namespace GestorDeEstoque.Telas
{
    partial class TelaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridUnidadeMedida = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIGLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.PainelCadastroUnidadeMedida = new System.Windows.Forms.Panel();
            this.panelCadastroProduto = new System.Windows.Forms.Panel();
            this.dataGridProduto = new System.Windows.Forms.DataGridView();
            this.CODIGOPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAOPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADEMEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.comboUnd = new System.Windows.Forms.ComboBox();
            this.modeloUnidadeMedidaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.modeloUnidadeMedidaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtvalor = new System.Windows.Forms.NumericUpDown();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PainelBotoes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.modeloUnidadeMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadeMedidaBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnidadeMedida)).BeginInit();
            this.PainelCadastroUnidadeMedida.SuspendLayout();
            this.panelCadastroProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloUnidadeMedidaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloUnidadeMedidaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalor)).BeginInit();
            this.PainelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeloUnidadeMedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeMedidaBLLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unidadeDeMedidaToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // unidadeDeMedidaToolStripMenuItem
            // 
            this.unidadeDeMedidaToolStripMenuItem.Name = "unidadeDeMedidaToolStripMenuItem";
            this.unidadeDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.unidadeDeMedidaToolStripMenuItem.Text = "Unidade de Medida";
            this.unidadeDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadeDeMedidaToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // dataGridUnidadeMedida
            // 
            this.dataGridUnidadeMedida.AllowUserToAddRows = false;
            this.dataGridUnidadeMedida.AllowUserToDeleteRows = false;
            this.dataGridUnidadeMedida.AllowUserToOrderColumns = true;
            this.dataGridUnidadeMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUnidadeMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.SIGLA,
            this.DESCRICAO});
            this.dataGridUnidadeMedida.Location = new System.Drawing.Point(12, 65);
            this.dataGridUnidadeMedida.MultiSelect = false;
            this.dataGridUnidadeMedida.Name = "dataGridUnidadeMedida";
            this.dataGridUnidadeMedida.ReadOnly = true;
            this.dataGridUnidadeMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUnidadeMedida.Size = new System.Drawing.Size(757, 327);
            this.dataGridUnidadeMedida.TabIndex = 8;
            this.dataGridUnidadeMedida.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridUnidadeMedida_MouseDoubleClick);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "IdUnidadeMedida";
            this.CODIGO.HeaderText = "Código";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // SIGLA
            // 
            this.SIGLA.DataPropertyName = "SiglaUnidadeMedida";
            this.SIGLA.HeaderText = "Sigla";
            this.SIGLA.Name = "SIGLA";
            this.SIGLA.ReadOnly = true;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DescricaoUnidadeMedida";
            this.DESCRICAO.HeaderText = "Descrição";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 500;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(10, 17);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(33, 13);
            this.lblSigla.TabIndex = 3;
            this.lblSigla.Text = "Sigla:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(116, 17);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(13, 33);
            this.txtSigla.MaxLength = 3;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 20);
            this.txtSigla.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(119, 33);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(545, 20);
            this.txtDescricao.TabIndex = 7;
            // 
            // PainelCadastroUnidadeMedida
            // 
            this.PainelCadastroUnidadeMedida.Controls.Add(this.txtDescricao);
            this.PainelCadastroUnidadeMedida.Controls.Add(this.txtSigla);
            this.PainelCadastroUnidadeMedida.Controls.Add(this.lblDescricao);
            this.PainelCadastroUnidadeMedida.Controls.Add(this.lblSigla);
            this.PainelCadastroUnidadeMedida.Controls.Add(this.dataGridUnidadeMedida);
            this.PainelCadastroUnidadeMedida.Location = new System.Drawing.Point(12, 43);
            this.PainelCadastroUnidadeMedida.Name = "PainelCadastroUnidadeMedida";
            this.PainelCadastroUnidadeMedida.Size = new System.Drawing.Size(776, 395);
            this.PainelCadastroUnidadeMedida.TabIndex = 2;
            this.PainelCadastroUnidadeMedida.Visible = false;
            // 
            // panelCadastroProduto
            // 
            this.panelCadastroProduto.Controls.Add(this.dataGridProduto);
            this.panelCadastroProduto.Controls.Add(this.txtQuantidade);
            this.panelCadastroProduto.Controls.Add(this.comboUnd);
            this.panelCadastroProduto.Controls.Add(this.txtvalor);
            this.panelCadastroProduto.Controls.Add(this.txtDescricaoProduto);
            this.panelCadastroProduto.Controls.Add(this.label6);
            this.panelCadastroProduto.Controls.Add(this.label5);
            this.panelCadastroProduto.Controls.Add(this.label4);
            this.panelCadastroProduto.Controls.Add(this.label3);
            this.panelCadastroProduto.Location = new System.Drawing.Point(12, 43);
            this.panelCadastroProduto.Name = "panelCadastroProduto";
            this.panelCadastroProduto.Size = new System.Drawing.Size(776, 395);
            this.panelCadastroProduto.TabIndex = 3;
            this.panelCadastroProduto.Visible = false;
            // 
            // dataGridProduto
            // 
            this.dataGridProduto.AllowUserToAddRows = false;
            this.dataGridProduto.AllowUserToOrderColumns = true;
            this.dataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGOPRODUTO,
            this.DESCRICAOPRODUTO,
            this.UNIDADEMEDIDA,
            this.VALOR,
            this.QUANTIDADE});
            this.dataGridProduto.Location = new System.Drawing.Point(12, 104);
            this.dataGridProduto.MultiSelect = false;
            this.dataGridProduto.Name = "dataGridProduto";
            this.dataGridProduto.ReadOnly = true;
            this.dataGridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduto.Size = new System.Drawing.Size(757, 288);
            this.dataGridProduto.TabIndex = 10;
            this.dataGridProduto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridProduto_MouseDoubleClick);
            // 
            // CODIGOPRODUTO
            // 
            this.CODIGOPRODUTO.DataPropertyName = "IdProduto";
            this.CODIGOPRODUTO.HeaderText = "Código";
            this.CODIGOPRODUTO.Name = "CODIGOPRODUTO";
            this.CODIGOPRODUTO.ReadOnly = true;
            // 
            // DESCRICAOPRODUTO
            // 
            this.DESCRICAOPRODUTO.DataPropertyName = "DescricaoProduto";
            this.DESCRICAOPRODUTO.HeaderText = "Descrição";
            this.DESCRICAOPRODUTO.Name = "DESCRICAOPRODUTO";
            this.DESCRICAOPRODUTO.ReadOnly = true;
            this.DESCRICAOPRODUTO.Width = 300;
            // 
            // UNIDADEMEDIDA
            // 
            this.UNIDADEMEDIDA.DataPropertyName = "UND";
            this.UNIDADEMEDIDA.HeaderText = "UND";
            this.UNIDADEMEDIDA.Name = "UNIDADEMEDIDA";
            this.UNIDADEMEDIDA.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "Valor";
            this.VALOR.HeaderText = "Valor";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QuantidadeEstoque";
            this.QUANTIDADE.HeaderText = "Qtd Estoque";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DecimalPlaces = 5;
            this.txtQuantidade.Location = new System.Drawing.Point(250, 78);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 9;
            // 
            // comboUnd
            // 
            this.comboUnd.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modeloUnidadeMedidaBindingSource2, "SiglaUnidadeMedida", true));
            this.comboUnd.DataSource = this.modeloUnidadeMedidaBindingSource1;
            this.comboUnd.FormattingEnabled = true;
            this.comboUnd.Location = new System.Drawing.Point(118, 77);
            this.comboUnd.Name = "comboUnd";
            this.comboUnd.Size = new System.Drawing.Size(121, 21);
            this.comboUnd.TabIndex = 8;
            this.comboUnd.SelectedIndexChanged += new System.EventHandler(this.comboUnd_SelectedIndexChanged);
            // 
            // modeloUnidadeMedidaBindingSource2
            // 
            this.modeloUnidadeMedidaBindingSource2.DataSource = typeof(Modelo.ModeloUnidadeMedida);
            // 
            // modeloUnidadeMedidaBindingSource1
            // 
            this.modeloUnidadeMedidaBindingSource1.DataSource = typeof(Modelo.ModeloUnidadeMedida);
            // 
            // txtvalor
            // 
            this.txtvalor.DecimalPlaces = 5;
            this.txtvalor.Location = new System.Drawing.Point(12, 78);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 7;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(13, 33);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(756, 20);
            this.txtDescricaoProduto.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Und:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Qtd Inicial:";
            // 
            // PainelBotoes
            // 
            this.PainelBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PainelBotoes.Controls.Add(this.btnSalvar);
            this.PainelBotoes.Controls.Add(this.btnExcluir);
            this.PainelBotoes.Controls.Add(this.btnBuscar);
            this.PainelBotoes.Controls.Add(this.btnVoltar);
            this.PainelBotoes.Location = new System.Drawing.Point(463, 27);
            this.PainelBotoes.Name = "PainelBotoes";
            this.PainelBotoes.Size = new System.Drawing.Size(325, 27);
            this.PainelBotoes.TabIndex = 5;
            this.PainelBotoes.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvar.Location = new System.Drawing.Point(3, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(84, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(165, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(246, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // modeloUnidadeMedidaBindingSource
            // 
            this.modeloUnidadeMedidaBindingSource.DataSource = typeof(Modelo.ModeloUnidadeMedida);
            // 
            // unidadeMedidaBLLBindingSource
            // 
            this.unidadeMedidaBLLBindingSource.DataSource = typeof(BLL.UnidadeMedidaBLL);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PainelBotoes);
            this.Controls.Add(this.PainelCadastroUnidadeMedida);
            this.Controls.Add(this.panelCadastroProduto);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUnidadeMedida)).EndInit();
            this.PainelCadastroUnidadeMedida.ResumeLayout(false);
            this.PainelCadastroUnidadeMedida.PerformLayout();
            this.panelCadastroProduto.ResumeLayout(false);
            this.panelCadastroProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloUnidadeMedidaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloUnidadeMedidaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalor)).EndInit();
            this.PainelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modeloUnidadeMedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeMedidaBLLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadeDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridUnidadeMedida;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Panel PainelCadastroUnidadeMedida;
        private System.Windows.Forms.Panel panelCadastroProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.ComboBox comboUnd;
        private System.Windows.Forms.NumericUpDown txtvalor;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.FlowLayoutPanel PainelBotoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIGLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.BindingSource modeloUnidadeMedidaBindingSource;
        private System.Windows.Forms.BindingSource unidadeMedidaBLLBindingSource;
        private System.Windows.Forms.BindingSource modeloUnidadeMedidaBindingSource2;
        private System.Windows.Forms.BindingSource modeloUnidadeMedidaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAOPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADEMEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.Button btnBuscar;
    }
}