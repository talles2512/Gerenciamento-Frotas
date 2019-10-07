namespace CamadaDesktop
{
    partial class Veiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veiculos));
            this.tbControlVeiculos = new System.Windows.Forms.TabControl();
            this.tbPageCadastroVeiculo = new System.Windows.Forms.TabPage();
            this.gbDadosVeiculos = new System.Windows.Forms.GroupBox();
            this.btnExcluirVeiculo = new System.Windows.Forms.Button();
            this.btnAlterarVeiculo = new System.Windows.Forms.Button();
            this.btnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.cbCombustivel = new System.Windows.Forms.ComboBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.dtAno = new System.Windows.Forms.DateTimePicker();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblChassi = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.tbPageConsultaVeiculo = new System.Windows.Forms.TabPage();
            this.gbConsultaVeiculo = new System.Windows.Forms.GroupBox();
            this.btnTrasferirVeiculo = new System.Windows.Forms.Button();
            this.dgVeiculoConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosVeiculo = new System.Windows.Forms.Button();
            this.btnConsultarVeiculo = new System.Windows.Forms.Button();
            this.txtPlacaConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblPlacaConsulta = new System.Windows.Forms.Label();
            this.tbControlVeiculos.SuspendLayout();
            this.tbPageCadastroVeiculo.SuspendLayout();
            this.gbDadosVeiculos.SuspendLayout();
            this.tbPageConsultaVeiculo.SuspendLayout();
            this.gbConsultaVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlVeiculos
            // 
            this.tbControlVeiculos.Controls.Add(this.tbPageCadastroVeiculo);
            this.tbControlVeiculos.Controls.Add(this.tbPageConsultaVeiculo);
            this.tbControlVeiculos.Font = new System.Drawing.Font("Agency FB", 18F);
            this.tbControlVeiculos.Location = new System.Drawing.Point(1, 24);
            this.tbControlVeiculos.Name = "tbControlVeiculos";
            this.tbControlVeiculos.SelectedIndex = 0;
            this.tbControlVeiculos.Size = new System.Drawing.Size(644, 498);
            this.tbControlVeiculos.TabIndex = 22;
            // 
            // tbPageCadastroVeiculo
            // 
            this.tbPageCadastroVeiculo.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroVeiculo.Controls.Add(this.gbDadosVeiculos);
            this.tbPageCadastroVeiculo.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroVeiculo.Name = "tbPageCadastroVeiculo";
            this.tbPageCadastroVeiculo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroVeiculo.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroVeiculo.TabIndex = 0;
            this.tbPageCadastroVeiculo.Text = "Cadastrar";
            // 
            // gbDadosVeiculos
            // 
            this.gbDadosVeiculos.Controls.Add(this.btnExcluirVeiculo);
            this.gbDadosVeiculos.Controls.Add(this.btnAlterarVeiculo);
            this.gbDadosVeiculos.Controls.Add(this.btnCadastrarVeiculo);
            this.gbDadosVeiculos.Controls.Add(this.cbCombustivel);
            this.gbDadosVeiculos.Controls.Add(this.cbCor);
            this.gbDadosVeiculos.Controls.Add(this.txtChassi);
            this.gbDadosVeiculos.Controls.Add(this.txtModelo);
            this.gbDadosVeiculos.Controls.Add(this.txtMarca);
            this.gbDadosVeiculos.Controls.Add(this.txtPlaca);
            this.gbDadosVeiculos.Controls.Add(this.dtAno);
            this.gbDadosVeiculos.Controls.Add(this.lblCombustivel);
            this.gbDadosVeiculos.Controls.Add(this.lblCor);
            this.gbDadosVeiculos.Controls.Add(this.lblAno);
            this.gbDadosVeiculos.Controls.Add(this.lblChassi);
            this.gbDadosVeiculos.Controls.Add(this.lblModelo);
            this.gbDadosVeiculos.Controls.Add(this.lblMarca);
            this.gbDadosVeiculos.Controls.Add(this.lblPlaca);
            this.gbDadosVeiculos.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosVeiculos.Location = new System.Drawing.Point(6, 6);
            this.gbDadosVeiculos.Name = "gbDadosVeiculos";
            this.gbDadosVeiculos.Size = new System.Drawing.Size(621, 445);
            this.gbDadosVeiculos.TabIndex = 1;
            this.gbDadosVeiculos.TabStop = false;
            this.gbDadosVeiculos.Text = "Dados";
            // 
            // btnExcluirVeiculo
            // 
            this.btnExcluirVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirVeiculo.FlatAppearance.BorderSize = 0;
            this.btnExcluirVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirVeiculo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnExcluirVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirVeiculo.Image")));
            this.btnExcluirVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirVeiculo.Location = new System.Drawing.Point(246, 399);
            this.btnExcluirVeiculo.Name = "btnExcluirVeiculo";
            this.btnExcluirVeiculo.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirVeiculo.TabIndex = 21;
            this.btnExcluirVeiculo.Text = "Excluir";
            this.btnExcluirVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirVeiculo.UseVisualStyleBackColor = false;
            // 
            // btnAlterarVeiculo
            // 
            this.btnAlterarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarVeiculo.FlatAppearance.BorderSize = 0;
            this.btnAlterarVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarVeiculo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnAlterarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarVeiculo.Image")));
            this.btnAlterarVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarVeiculo.Location = new System.Drawing.Point(246, 353);
            this.btnAlterarVeiculo.Name = "btnAlterarVeiculo";
            this.btnAlterarVeiculo.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarVeiculo.TabIndex = 20;
            this.btnAlterarVeiculo.Text = "Alterar";
            this.btnAlterarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarVeiculo.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarVeiculo
            // 
            this.btnCadastrarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarVeiculo.FlatAppearance.BorderSize = 0;
            this.btnCadastrarVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarVeiculo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarVeiculo.Image")));
            this.btnCadastrarVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarVeiculo.Location = new System.Drawing.Point(123, 307);
            this.btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            this.btnCadastrarVeiculo.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarVeiculo.TabIndex = 19;
            this.btnCadastrarVeiculo.Text = "Cadastrar";
            this.btnCadastrarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarVeiculo.UseVisualStyleBackColor = false;
            this.btnCadastrarVeiculo.Click += new System.EventHandler(this.BtnCadastrarVeiculo_Click);
            // 
            // cbCombustivel
            // 
            this.cbCombustivel.FormattingEnabled = true;
            this.cbCombustivel.Location = new System.Drawing.Point(226, 201);
            this.cbCombustivel.Name = "cbCombustivel";
            this.cbCombustivel.Size = new System.Drawing.Size(186, 33);
            this.cbCombustivel.TabIndex = 18;
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(23, 201);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(186, 33);
            this.cbCor.TabIndex = 17;
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(226, 135);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(186, 32);
            this.txtChassi.TabIndex = 16;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(23, 135);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(186, 32);
            this.txtModelo.TabIndex = 15;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(226, 72);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(186, 32);
            this.txtMarca.TabIndex = 13;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(23, 72);
            this.txtPlaca.Mask = ">L>L>L-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(186, 32);
            this.txtPlaca.TabIndex = 12;
            // 
            // dtAno
            // 
            this.dtAno.CustomFormat = "yyyy";
            this.dtAno.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAno.Location = new System.Drawing.Point(423, 72);
            this.dtAno.Name = "dtAno";
            this.dtAno.ShowUpDown = true;
            this.dtAno.Size = new System.Drawing.Size(105, 31);
            this.dtAno.TabIndex = 14;
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Location = new System.Drawing.Point(221, 173);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(85, 25);
            this.lblCombustivel.TabIndex = 6;
            this.lblCombustivel.Text = "Combustivel;";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(18, 173);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(37, 25);
            this.lblCor.TabIndex = 5;
            this.lblCor.Text = "Cor:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(418, 44);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(37, 25);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano:";
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Location = new System.Drawing.Point(221, 107);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(55, 25);
            this.lblChassi.TabIndex = 3;
            this.lblChassi.Text = "Chassi:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(18, 107);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(56, 25);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(221, 44);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 25);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(18, 44);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 25);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            // 
            // tbPageConsultaVeiculo
            // 
            this.tbPageConsultaVeiculo.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaVeiculo.Controls.Add(this.gbConsultaVeiculo);
            this.tbPageConsultaVeiculo.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaVeiculo.Name = "tbPageConsultaVeiculo";
            this.tbPageConsultaVeiculo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaVeiculo.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaVeiculo.TabIndex = 1;
            this.tbPageConsultaVeiculo.Text = "Consultar";
            // 
            // gbConsultaVeiculo
            // 
            this.gbConsultaVeiculo.Controls.Add(this.btnTrasferirVeiculo);
            this.gbConsultaVeiculo.Controls.Add(this.dgVeiculoConsulta);
            this.gbConsultaVeiculo.Controls.Add(this.btnTodosVeiculo);
            this.gbConsultaVeiculo.Controls.Add(this.btnConsultarVeiculo);
            this.gbConsultaVeiculo.Controls.Add(this.txtPlacaConsulta);
            this.gbConsultaVeiculo.Controls.Add(this.lblPlacaConsulta);
            this.gbConsultaVeiculo.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaVeiculo.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaVeiculo.Name = "gbConsultaVeiculo";
            this.gbConsultaVeiculo.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaVeiculo.TabIndex = 2;
            this.gbConsultaVeiculo.TabStop = false;
            this.gbConsultaVeiculo.Text = "Consulta";
            // 
            // btnTrasferirVeiculo
            // 
            this.btnTrasferirVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirVeiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirVeiculo.BackgroundImage")));
            this.btnTrasferirVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirVeiculo.FlatAppearance.BorderSize = 0;
            this.btnTrasferirVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirVeiculo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirVeiculo.Location = new System.Drawing.Point(580, 24);
            this.btnTrasferirVeiculo.Name = "btnTrasferirVeiculo";
            this.btnTrasferirVeiculo.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirVeiculo.TabIndex = 21;
            this.btnTrasferirVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirVeiculo.UseVisualStyleBackColor = false;
            // 
            // dgVeiculoConsulta
            // 
            this.dgVeiculoConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgVeiculoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeiculoConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgVeiculoConsulta.Location = new System.Drawing.Point(7, 68);
            this.dgVeiculoConsulta.Name = "dgVeiculoConsulta";
            this.dgVeiculoConsulta.Size = new System.Drawing.Size(608, 371);
            this.dgVeiculoConsulta.TabIndex = 25;
            // 
            // btnTodosVeiculo
            // 
            this.btnTodosVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosVeiculo.FlatAppearance.BorderSize = 0;
            this.btnTodosVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosVeiculo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnTodosVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosVeiculo.Location = new System.Drawing.Point(418, 24);
            this.btnTodosVeiculo.Name = "btnTodosVeiculo";
            this.btnTodosVeiculo.Size = new System.Drawing.Size(159, 40);
            this.btnTodosVeiculo.TabIndex = 24;
            this.btnTodosVeiculo.Text = "Consultar Todos";
            this.btnTodosVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosVeiculo.UseVisualStyleBackColor = false;
            // 
            // btnConsultarVeiculo
            // 
            this.btnConsultarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarVeiculo.FlatAppearance.BorderSize = 0;
            this.btnConsultarVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVeiculo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnConsultarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarVeiculo.Image")));
            this.btnConsultarVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarVeiculo.Location = new System.Drawing.Point(266, 24);
            this.btnConsultarVeiculo.Name = "btnConsultarVeiculo";
            this.btnConsultarVeiculo.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarVeiculo.TabIndex = 23;
            this.btnConsultarVeiculo.Text = "    Consultar";
            this.btnConsultarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarVeiculo.UseVisualStyleBackColor = false;
            // 
            // txtPlacaConsulta
            // 
            this.txtPlacaConsulta.Location = new System.Drawing.Point(72, 32);
            this.txtPlacaConsulta.Mask = ">L>L>L-0000";
            this.txtPlacaConsulta.Name = "txtPlacaConsulta";
            this.txtPlacaConsulta.Size = new System.Drawing.Size(186, 32);
            this.txtPlacaConsulta.TabIndex = 22;
            // 
            // lblPlacaConsulta
            // 
            this.lblPlacaConsulta.AutoSize = true;
            this.lblPlacaConsulta.Location = new System.Drawing.Point(18, 39);
            this.lblPlacaConsulta.Name = "lblPlacaConsulta";
            this.lblPlacaConsulta.Size = new System.Drawing.Size(48, 25);
            this.lblPlacaConsulta.TabIndex = 17;
            this.lblPlacaConsulta.Text = "Placa:";
            // 
            // Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.ControlBox = false;
            this.Controls.Add(this.tbControlVeiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculos";
            this.Load += new System.EventHandler(this.Veiculos_Load);
            this.tbControlVeiculos.ResumeLayout(false);
            this.tbPageCadastroVeiculo.ResumeLayout(false);
            this.gbDadosVeiculos.ResumeLayout(false);
            this.gbDadosVeiculos.PerformLayout();
            this.tbPageConsultaVeiculo.ResumeLayout(false);
            this.gbConsultaVeiculo.ResumeLayout(false);
            this.gbConsultaVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculoConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbControlVeiculos;
        private System.Windows.Forms.TabPage tbPageCadastroVeiculo;
        private System.Windows.Forms.TabPage tbPageConsultaVeiculo;
        private System.Windows.Forms.GroupBox gbDadosVeiculos;
        private System.Windows.Forms.Button btnExcluirVeiculo;
        private System.Windows.Forms.Button btnAlterarVeiculo;
        private System.Windows.Forms.Button btnCadastrarVeiculo;
        private System.Windows.Forms.ComboBox cbCombustivel;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.DateTimePicker dtAno;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.GroupBox gbConsultaVeiculo;
        private System.Windows.Forms.Button btnTrasferirVeiculo;
        private System.Windows.Forms.DataGridView dgVeiculoConsulta;
        private System.Windows.Forms.Button btnTodosVeiculo;
        private System.Windows.Forms.Button btnConsultarVeiculo;
        private System.Windows.Forms.MaskedTextBox txtPlacaConsulta;
        private System.Windows.Forms.Label lblPlacaConsulta;
    }
}