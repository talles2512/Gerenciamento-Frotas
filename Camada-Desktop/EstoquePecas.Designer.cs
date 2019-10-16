namespace CamadaDesktop
{
    partial class EstoquePecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstoquePecas));
            this.tbControlEstoque = new System.Windows.Forms.TabControl();
            this.tbPageCadastroEstoque = new System.Windows.Forms.TabPage();
            this.gbDadosEstoque = new System.Windows.Forms.GroupBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.lblValorUnit = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnExcluirEstoque = new System.Windows.Forms.Button();
            this.btnAlterarEstoque = new System.Windows.Forms.Button();
            this.btnCadastrarEstoque = new System.Windows.Forms.Button();
            this.tbPageConsultaEstoque = new System.Windows.Forms.TabPage();
            this.gbConsultaEstoque = new System.Windows.Forms.GroupBox();
            this.txtIDEstoqueConsulta = new System.Windows.Forms.TextBox();
            this.lblIDEstoqueConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirEstoque = new System.Windows.Forms.Button();
            this.dgEstoqueConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosEstoque = new System.Windows.Forms.Button();
            this.btnConsultarEstoque = new System.Windows.Forms.Button();
            this.tbControlEstoque.SuspendLayout();
            this.tbPageCadastroEstoque.SuspendLayout();
            this.gbDadosEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.tbPageConsultaEstoque.SuspendLayout();
            this.gbConsultaEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoqueConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlEstoque
            // 
            this.tbControlEstoque.Controls.Add(this.tbPageCadastroEstoque);
            this.tbControlEstoque.Controls.Add(this.tbPageConsultaEstoque);
            this.tbControlEstoque.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlEstoque.Location = new System.Drawing.Point(1, 24);
            this.tbControlEstoque.Name = "tbControlEstoque";
            this.tbControlEstoque.SelectedIndex = 0;
            this.tbControlEstoque.Size = new System.Drawing.Size(644, 498);
            this.tbControlEstoque.TabIndex = 25;
            // 
            // tbPageCadastroEstoque
            // 
            this.tbPageCadastroEstoque.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroEstoque.Controls.Add(this.gbDadosEstoque);
            this.tbPageCadastroEstoque.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroEstoque.Name = "tbPageCadastroEstoque";
            this.tbPageCadastroEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroEstoque.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroEstoque.TabIndex = 0;
            this.tbPageCadastroEstoque.Text = "Cadastrar";
            // 
            // gbDadosEstoque
            // 
            this.gbDadosEstoque.Controls.Add(this.nudQuantidade);
            this.gbDadosEstoque.Controls.Add(this.lblQtd);
            this.gbDadosEstoque.Controls.Add(this.txtValor);
            this.gbDadosEstoque.Controls.Add(this.lblValorUnit);
            this.gbDadosEstoque.Controls.Add(this.txtid);
            this.gbDadosEstoque.Controls.Add(this.lblIdentificador);
            this.gbDadosEstoque.Controls.Add(this.txtDesc);
            this.gbDadosEstoque.Controls.Add(this.lblDesc);
            this.gbDadosEstoque.Controls.Add(this.btnExcluirEstoque);
            this.gbDadosEstoque.Controls.Add(this.btnAlterarEstoque);
            this.gbDadosEstoque.Controls.Add(this.btnCadastrarEstoque);
            this.gbDadosEstoque.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosEstoque.Location = new System.Drawing.Point(6, 6);
            this.gbDadosEstoque.Name = "gbDadosEstoque";
            this.gbDadosEstoque.Size = new System.Drawing.Size(621, 391);
            this.gbDadosEstoque.TabIndex = 1;
            this.gbDadosEstoque.TabStop = false;
            this.gbDadosEstoque.Text = "Dados";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(360, 56);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(197, 32);
            this.nudQuantidade.TabIndex = 16;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(355, 28);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(80, 25);
            this.lblQtd.TabIndex = 43;
            this.lblQtd.Text = "Quantidade:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(157, 56);
            this.txtValor.Mask = "0000000000";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(197, 32);
            this.txtValor.TabIndex = 15;
            // 
            // lblValorUnit
            // 
            this.lblValorUnit.AutoSize = true;
            this.lblValorUnit.Location = new System.Drawing.Point(152, 28);
            this.lblValorUnit.Name = "lblValorUnit";
            this.lblValorUnit.Size = new System.Drawing.Size(97, 25);
            this.lblValorUnit.TabIndex = 41;
            this.lblValorUnit.Text = "Valor Unidade:";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(11, 56);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(140, 32);
            this.txtid.TabIndex = 14;
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(6, 28);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(87, 25);
            this.lblIdentificador.TabIndex = 37;
            this.lblIdentificador.Text = "Identificador:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(11, 119);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(487, 85);
            this.txtDesc.TabIndex = 17;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 91);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 25);
            this.lblDesc.TabIndex = 31;
            this.lblDesc.Text = "Descrição:";
            // 
            // btnExcluirEstoque
            // 
            this.btnExcluirEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirEstoque.FlatAppearance.BorderSize = 0;
            this.btnExcluirEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirEstoque.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirEstoque.ForeColor = System.Drawing.Color.White;
            this.btnExcluirEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirEstoque.Image")));
            this.btnExcluirEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirEstoque.Location = new System.Drawing.Point(244, 341);
            this.btnExcluirEstoque.Name = "btnExcluirEstoque";
            this.btnExcluirEstoque.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirEstoque.TabIndex = 20;
            this.btnExcluirEstoque.Text = "Excluir";
            this.btnExcluirEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirEstoque.UseVisualStyleBackColor = false;
            this.btnExcluirEstoque.Click += new System.EventHandler(this.btnExcluirEstoque_Click);
            // 
            // btnAlterarEstoque
            // 
            this.btnAlterarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarEstoque.FlatAppearance.BorderSize = 0;
            this.btnAlterarEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarEstoque.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarEstoque.ForeColor = System.Drawing.Color.White;
            this.btnAlterarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarEstoque.Image")));
            this.btnAlterarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarEstoque.Location = new System.Drawing.Point(244, 295);
            this.btnAlterarEstoque.Name = "btnAlterarEstoque";
            this.btnAlterarEstoque.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarEstoque.TabIndex = 19;
            this.btnAlterarEstoque.Text = "Alterar";
            this.btnAlterarEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarEstoque.UseVisualStyleBackColor = false;
            this.btnAlterarEstoque.Click += new System.EventHandler(this.btnAlterarEstoque_Click);
            // 
            // btnCadastrarEstoque
            // 
            this.btnCadastrarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarEstoque.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEstoque.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEstoque.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarEstoque.Image")));
            this.btnCadastrarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarEstoque.Location = new System.Drawing.Point(119, 249);
            this.btnCadastrarEstoque.Name = "btnCadastrarEstoque";
            this.btnCadastrarEstoque.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarEstoque.TabIndex = 18;
            this.btnCadastrarEstoque.Text = "Cadastrar";
            this.btnCadastrarEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarEstoque.UseVisualStyleBackColor = false;
            this.btnCadastrarEstoque.Click += new System.EventHandler(this.btnCadastrarEstoque_Click);
            // 
            // tbPageConsultaEstoque
            // 
            this.tbPageConsultaEstoque.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaEstoque.Controls.Add(this.gbConsultaEstoque);
            this.tbPageConsultaEstoque.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaEstoque.Name = "tbPageConsultaEstoque";
            this.tbPageConsultaEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaEstoque.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaEstoque.TabIndex = 1;
            this.tbPageConsultaEstoque.Text = "Consultar";
            // 
            // gbConsultaEstoque
            // 
            this.gbConsultaEstoque.Controls.Add(this.txtIDEstoqueConsulta);
            this.gbConsultaEstoque.Controls.Add(this.lblIDEstoqueConsulta);
            this.gbConsultaEstoque.Controls.Add(this.btnTrasferirEstoque);
            this.gbConsultaEstoque.Controls.Add(this.dgEstoqueConsulta);
            this.gbConsultaEstoque.Controls.Add(this.btnTodosEstoque);
            this.gbConsultaEstoque.Controls.Add(this.btnConsultarEstoque);
            this.gbConsultaEstoque.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaEstoque.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaEstoque.Name = "gbConsultaEstoque";
            this.gbConsultaEstoque.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaEstoque.TabIndex = 2;
            this.gbConsultaEstoque.TabStop = false;
            this.gbConsultaEstoque.Text = "Consulta";
            // 
            // txtIDEstoqueConsulta
            // 
            this.txtIDEstoqueConsulta.Location = new System.Drawing.Point(99, 27);
            this.txtIDEstoqueConsulta.Name = "txtIDEstoqueConsulta";
            this.txtIDEstoqueConsulta.Size = new System.Drawing.Size(155, 32);
            this.txtIDEstoqueConsulta.TabIndex = 14;
            // 
            // lblIDEstoqueConsulta
            // 
            this.lblIDEstoqueConsulta.AutoSize = true;
            this.lblIDEstoqueConsulta.Location = new System.Drawing.Point(6, 30);
            this.lblIDEstoqueConsulta.Name = "lblIDEstoqueConsulta";
            this.lblIDEstoqueConsulta.Size = new System.Drawing.Size(87, 25);
            this.lblIDEstoqueConsulta.TabIndex = 41;
            this.lblIDEstoqueConsulta.Text = "Identificador:";
            // 
            // btnTrasferirEstoque
            // 
            this.btnTrasferirEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirEstoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirEstoque.BackgroundImage")));
            this.btnTrasferirEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirEstoque.FlatAppearance.BorderSize = 0;
            this.btnTrasferirEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirEstoque.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirEstoque.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirEstoque.Location = new System.Drawing.Point(577, 21);
            this.btnTrasferirEstoque.Name = "btnTrasferirEstoque";
            this.btnTrasferirEstoque.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirEstoque.TabIndex = 17;
            this.btnTrasferirEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirEstoque.UseVisualStyleBackColor = false;
            this.btnTrasferirEstoque.Click += new System.EventHandler(this.btnTrasferirEstoque_Click);
            // 
            // dgEstoqueConsulta
            // 
            this.dgEstoqueConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgEstoqueConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstoqueConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgEstoqueConsulta.Location = new System.Drawing.Point(7, 67);
            this.dgEstoqueConsulta.Name = "dgEstoqueConsulta";
            this.dgEstoqueConsulta.Size = new System.Drawing.Size(608, 372);
            this.dgEstoqueConsulta.TabIndex = 18;
            // 
            // btnTodosEstoque
            // 
            this.btnTodosEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosEstoque.FlatAppearance.BorderSize = 0;
            this.btnTodosEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosEstoque.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosEstoque.ForeColor = System.Drawing.Color.White;
            this.btnTodosEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosEstoque.Location = new System.Drawing.Point(412, 21);
            this.btnTodosEstoque.Name = "btnTodosEstoque";
            this.btnTodosEstoque.Size = new System.Drawing.Size(159, 40);
            this.btnTodosEstoque.TabIndex = 16;
            this.btnTodosEstoque.Text = "Consultar Todos";
            this.btnTodosEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosEstoque.UseVisualStyleBackColor = false;
            this.btnTodosEstoque.Click += new System.EventHandler(this.btnTodosEstoque_Click);
            // 
            // btnConsultarEstoque
            // 
            this.btnConsultarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarEstoque.FlatAppearance.BorderSize = 0;
            this.btnConsultarEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEstoque.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEstoque.ForeColor = System.Drawing.Color.White;
            this.btnConsultarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarEstoque.Image")));
            this.btnConsultarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarEstoque.Location = new System.Drawing.Point(260, 21);
            this.btnConsultarEstoque.Name = "btnConsultarEstoque";
            this.btnConsultarEstoque.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarEstoque.TabIndex = 15;
            this.btnConsultarEstoque.Text = "    Consultar";
            this.btnConsultarEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarEstoque.UseVisualStyleBackColor = false;
            this.btnConsultarEstoque.Click += new System.EventHandler(this.btnConsultarEstoque_Click);
            // 
            // EstoquePecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstoquePecas";
            this.Text = "EstoquePecas";
            this.Load += new System.EventHandler(this.EstoquePecas_Load);
            this.tbControlEstoque.ResumeLayout(false);
            this.tbPageCadastroEstoque.ResumeLayout(false);
            this.gbDadosEstoque.ResumeLayout(false);
            this.gbDadosEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.tbPageConsultaEstoque.ResumeLayout(false);
            this.gbConsultaEstoque.ResumeLayout(false);
            this.gbConsultaEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoqueConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlEstoque;
        private System.Windows.Forms.TabPage tbPageCadastroEstoque;
        private System.Windows.Forms.GroupBox gbDadosEstoque;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnExcluirEstoque;
        private System.Windows.Forms.Button btnAlterarEstoque;
        private System.Windows.Forms.Button btnCadastrarEstoque;
        private System.Windows.Forms.TabPage tbPageConsultaEstoque;
        private System.Windows.Forms.GroupBox gbConsultaEstoque;
        private System.Windows.Forms.TextBox txtIDEstoqueConsulta;
        private System.Windows.Forms.Label lblIDEstoqueConsulta;
        private System.Windows.Forms.Button btnTrasferirEstoque;
        private System.Windows.Forms.DataGridView dgEstoqueConsulta;
        private System.Windows.Forms.Button btnTodosEstoque;
        private System.Windows.Forms.Button btnConsultarEstoque;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label lblValorUnit;
    }
}