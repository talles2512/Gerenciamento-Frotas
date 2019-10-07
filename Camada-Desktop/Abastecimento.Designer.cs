namespace CamadaDesktop
{
    partial class Abastecimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abastecimento));
            this.tbControlAbast = new System.Windows.Forms.TabControl();
            this.tbPageCadastroAbast = new System.Windows.Forms.TabPage();
            this.gbDadosAbast = new System.Windows.Forms.GroupBox();
            this.cbServicoExterno = new System.Windows.Forms.ComboBox();
            this.lblServicoExterno = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.lblValorLitro = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtDataManunt = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnExcluirAbast = new System.Windows.Forms.Button();
            this.btnAlterarAbast = new System.Windows.Forms.Button();
            this.btnCadastrarAbast = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.tbPageConsultaAbast = new System.Windows.Forms.TabPage();
            this.gbConsultaAbast = new System.Windows.Forms.GroupBox();
            this.lblDataAbastConsulta = new System.Windows.Forms.Label();
            this.dtDataAbastConsulta = new System.Windows.Forms.DateTimePicker();
            this.cbTipoAbastConsulta = new System.Windows.Forms.ComboBox();
            this.lblTipoAbastConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirAbast = new System.Windows.Forms.Button();
            this.dgVeiculoAbast = new System.Windows.Forms.DataGridView();
            this.btnTodosAbast = new System.Windows.Forms.Button();
            this.btnConsultarAbast = new System.Windows.Forms.Button();
            this.txtPlacaConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblPlacaConsulta = new System.Windows.Forms.Label();
            this.tbControlAbast.SuspendLayout();
            this.tbPageCadastroAbast.SuspendLayout();
            this.gbDadosAbast.SuspendLayout();
            this.tbPageConsultaAbast.SuspendLayout();
            this.gbConsultaAbast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculoAbast)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlAbast
            // 
            this.tbControlAbast.Controls.Add(this.tbPageCadastroAbast);
            this.tbControlAbast.Controls.Add(this.tbPageConsultaAbast);
            this.tbControlAbast.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlAbast.Location = new System.Drawing.Point(1, 24);
            this.tbControlAbast.Name = "tbControlAbast";
            this.tbControlAbast.SelectedIndex = 0;
            this.tbControlAbast.Size = new System.Drawing.Size(644, 498);
            this.tbControlAbast.TabIndex = 24;
            // 
            // tbPageCadastroAbast
            // 
            this.tbPageCadastroAbast.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroAbast.Controls.Add(this.gbDadosAbast);
            this.tbPageCadastroAbast.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroAbast.Name = "tbPageCadastroAbast";
            this.tbPageCadastroAbast.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroAbast.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroAbast.TabIndex = 0;
            this.tbPageCadastroAbast.Text = "Cadastrar";
            // 
            // gbDadosAbast
            // 
            this.gbDadosAbast.Controls.Add(this.cbServicoExterno);
            this.gbDadosAbast.Controls.Add(this.lblServicoExterno);
            this.gbDadosAbast.Controls.Add(this.txtValor);
            this.gbDadosAbast.Controls.Add(this.lblValorLitro);
            this.gbDadosAbast.Controls.Add(this.lblData);
            this.gbDadosAbast.Controls.Add(this.dtDataManunt);
            this.gbDadosAbast.Controls.Add(this.comboBox1);
            this.gbDadosAbast.Controls.Add(this.lblTipo);
            this.gbDadosAbast.Controls.Add(this.btnExcluirAbast);
            this.gbDadosAbast.Controls.Add(this.btnAlterarAbast);
            this.gbDadosAbast.Controls.Add(this.btnCadastrarAbast);
            this.gbDadosAbast.Controls.Add(this.txtPlaca);
            this.gbDadosAbast.Controls.Add(this.lblPlaca);
            this.gbDadosAbast.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosAbast.Location = new System.Drawing.Point(6, 6);
            this.gbDadosAbast.Name = "gbDadosAbast";
            this.gbDadosAbast.Size = new System.Drawing.Size(621, 395);
            this.gbDadosAbast.TabIndex = 1;
            this.gbDadosAbast.TabStop = false;
            this.gbDadosAbast.Text = "Dados";
            // 
            // cbServicoExterno
            // 
            this.cbServicoExterno.FormattingEnabled = true;
            this.cbServicoExterno.Location = new System.Drawing.Point(11, 183);
            this.cbServicoExterno.Name = "cbServicoExterno";
            this.cbServicoExterno.Size = new System.Drawing.Size(400, 33);
            this.cbServicoExterno.TabIndex = 29;
            // 
            // lblServicoExterno
            // 
            this.lblServicoExterno.AutoSize = true;
            this.lblServicoExterno.Location = new System.Drawing.Point(6, 155);
            this.lblServicoExterno.Name = "lblServicoExterno";
            this.lblServicoExterno.Size = new System.Drawing.Size(108, 25);
            this.lblServicoExterno.TabIndex = 28;
            this.lblServicoExterno.Text = "Serviço Externo:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(11, 120);
            this.txtValor.Mask = "000000000";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(197, 32);
            this.txtValor.TabIndex = 27;
            // 
            // lblValorLitro
            // 
            this.lblValorLitro.AutoSize = true;
            this.lblValorLitro.Location = new System.Drawing.Point(6, 92);
            this.lblValorLitro.Name = "lblValorLitro";
            this.lblValorLitro.Size = new System.Drawing.Size(46, 25);
            this.lblValorLitro.TabIndex = 26;
            this.lblValorLitro.Text = "Valor:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(209, 28);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 25);
            this.lblData.TabIndex = 25;
            this.lblData.Text = "Data:";
            // 
            // dtDataManunt
            // 
            this.dtDataManunt.CustomFormat = "dd/mm/yyyy";
            this.dtDataManunt.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataManunt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataManunt.Location = new System.Drawing.Point(214, 56);
            this.dtDataManunt.Name = "dtDataManunt";
            this.dtDataManunt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataManunt.Size = new System.Drawing.Size(284, 31);
            this.dtDataManunt.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 33);
            this.comboBox1.TabIndex = 23;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 28);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 25);
            this.lblTipo.TabIndex = 22;
            this.lblTipo.Text = "Tipo:";
            // 
            // btnExcluirAbast
            // 
            this.btnExcluirAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirAbast.FlatAppearance.BorderSize = 0;
            this.btnExcluirAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAbast.ForeColor = System.Drawing.Color.White;
            this.btnExcluirAbast.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirAbast.Image")));
            this.btnExcluirAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirAbast.Location = new System.Drawing.Point(244, 349);
            this.btnExcluirAbast.Name = "btnExcluirAbast";
            this.btnExcluirAbast.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirAbast.TabIndex = 21;
            this.btnExcluirAbast.Text = "Excluir";
            this.btnExcluirAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirAbast.UseVisualStyleBackColor = false;
            // 
            // btnAlterarAbast
            // 
            this.btnAlterarAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarAbast.FlatAppearance.BorderSize = 0;
            this.btnAlterarAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarAbast.ForeColor = System.Drawing.Color.White;
            this.btnAlterarAbast.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarAbast.Image")));
            this.btnAlterarAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarAbast.Location = new System.Drawing.Point(244, 303);
            this.btnAlterarAbast.Name = "btnAlterarAbast";
            this.btnAlterarAbast.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarAbast.TabIndex = 20;
            this.btnAlterarAbast.Text = "Alterar";
            this.btnAlterarAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarAbast.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarAbast
            // 
            this.btnCadastrarAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarAbast.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAbast.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarAbast.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarAbast.Image")));
            this.btnCadastrarAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarAbast.Location = new System.Drawing.Point(119, 257);
            this.btnCadastrarAbast.Name = "btnCadastrarAbast";
            this.btnCadastrarAbast.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarAbast.TabIndex = 19;
            this.btnCadastrarAbast.Text = "Cadastrar";
            this.btnCadastrarAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarAbast.UseVisualStyleBackColor = false;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(214, 120);
            this.txtPlaca.Mask = ">L>L>L-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(197, 32);
            this.txtPlaca.TabIndex = 12;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(209, 92);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(104, 25);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Veículo - Placa:";
            // 
            // tbPageConsultaAbast
            // 
            this.tbPageConsultaAbast.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaAbast.Controls.Add(this.gbConsultaAbast);
            this.tbPageConsultaAbast.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaAbast.Name = "tbPageConsultaAbast";
            this.tbPageConsultaAbast.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaAbast.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaAbast.TabIndex = 1;
            this.tbPageConsultaAbast.Text = "Consultar";
            // 
            // gbConsultaAbast
            // 
            this.gbConsultaAbast.Controls.Add(this.lblDataAbastConsulta);
            this.gbConsultaAbast.Controls.Add(this.dtDataAbastConsulta);
            this.gbConsultaAbast.Controls.Add(this.cbTipoAbastConsulta);
            this.gbConsultaAbast.Controls.Add(this.lblTipoAbastConsulta);
            this.gbConsultaAbast.Controls.Add(this.btnTrasferirAbast);
            this.gbConsultaAbast.Controls.Add(this.dgVeiculoAbast);
            this.gbConsultaAbast.Controls.Add(this.btnTodosAbast);
            this.gbConsultaAbast.Controls.Add(this.btnConsultarAbast);
            this.gbConsultaAbast.Controls.Add(this.txtPlacaConsulta);
            this.gbConsultaAbast.Controls.Add(this.lblPlacaConsulta);
            this.gbConsultaAbast.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaAbast.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaAbast.Name = "gbConsultaAbast";
            this.gbConsultaAbast.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaAbast.TabIndex = 2;
            this.gbConsultaAbast.TabStop = false;
            this.gbConsultaAbast.Text = "Consulta";
            // 
            // lblDataAbastConsulta
            // 
            this.lblDataAbastConsulta.AutoSize = true;
            this.lblDataAbastConsulta.Location = new System.Drawing.Point(198, 88);
            this.lblDataAbastConsulta.Name = "lblDataAbastConsulta";
            this.lblDataAbastConsulta.Size = new System.Drawing.Size(42, 25);
            this.lblDataAbastConsulta.TabIndex = 29;
            this.lblDataAbastConsulta.Text = "Data:";
            // 
            // dtDataAbastConsulta
            // 
            this.dtDataAbastConsulta.CustomFormat = "dd/mm/yyyy";
            this.dtDataAbastConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataAbastConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataAbastConsulta.Location = new System.Drawing.Point(203, 116);
            this.dtDataAbastConsulta.Name = "dtDataAbastConsulta";
            this.dtDataAbastConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataAbastConsulta.Size = new System.Drawing.Size(146, 31);
            this.dtDataAbastConsulta.TabIndex = 28;
            // 
            // cbTipoAbastConsulta
            // 
            this.cbTipoAbastConsulta.FormattingEnabled = true;
            this.cbTipoAbastConsulta.Location = new System.Drawing.Point(11, 56);
            this.cbTipoAbastConsulta.Name = "cbTipoAbastConsulta";
            this.cbTipoAbastConsulta.Size = new System.Drawing.Size(186, 33);
            this.cbTipoAbastConsulta.TabIndex = 27;
            // 
            // lblTipoAbastConsulta
            // 
            this.lblTipoAbastConsulta.AutoSize = true;
            this.lblTipoAbastConsulta.Location = new System.Drawing.Point(6, 28);
            this.lblTipoAbastConsulta.Name = "lblTipoAbastConsulta";
            this.lblTipoAbastConsulta.Size = new System.Drawing.Size(38, 25);
            this.lblTipoAbastConsulta.TabIndex = 26;
            this.lblTipoAbastConsulta.Text = "Tipo:";
            // 
            // btnTrasferirAbast
            // 
            this.btnTrasferirAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirAbast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirAbast.BackgroundImage")));
            this.btnTrasferirAbast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirAbast.FlatAppearance.BorderSize = 0;
            this.btnTrasferirAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirAbast.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirAbast.Location = new System.Drawing.Point(577, 49);
            this.btnTrasferirAbast.Name = "btnTrasferirAbast";
            this.btnTrasferirAbast.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirAbast.TabIndex = 21;
            this.btnTrasferirAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirAbast.UseVisualStyleBackColor = false;
            // 
            // dgVeiculoAbast
            // 
            this.dgVeiculoAbast.BackgroundColor = System.Drawing.Color.White;
            this.dgVeiculoAbast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeiculoAbast.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgVeiculoAbast.Location = new System.Drawing.Point(7, 154);
            this.dgVeiculoAbast.Name = "dgVeiculoAbast";
            this.dgVeiculoAbast.Size = new System.Drawing.Size(608, 285);
            this.dgVeiculoAbast.TabIndex = 25;
            // 
            // btnTodosAbast
            // 
            this.btnTodosAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosAbast.FlatAppearance.BorderSize = 0;
            this.btnTodosAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosAbast.ForeColor = System.Drawing.Color.White;
            this.btnTodosAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosAbast.Location = new System.Drawing.Point(412, 49);
            this.btnTodosAbast.Name = "btnTodosAbast";
            this.btnTodosAbast.Size = new System.Drawing.Size(159, 40);
            this.btnTodosAbast.TabIndex = 24;
            this.btnTodosAbast.Text = "Consultar Todos";
            this.btnTodosAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosAbast.UseVisualStyleBackColor = false;
            // 
            // btnConsultarAbast
            // 
            this.btnConsultarAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarAbast.FlatAppearance.BorderSize = 0;
            this.btnConsultarAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAbast.ForeColor = System.Drawing.Color.White;
            this.btnConsultarAbast.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarAbast.Image")));
            this.btnConsultarAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAbast.Location = new System.Drawing.Point(260, 50);
            this.btnConsultarAbast.Name = "btnConsultarAbast";
            this.btnConsultarAbast.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarAbast.TabIndex = 23;
            this.btnConsultarAbast.Text = "    Consultar";
            this.btnConsultarAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarAbast.UseVisualStyleBackColor = false;
            // 
            // txtPlacaConsulta
            // 
            this.txtPlacaConsulta.Location = new System.Drawing.Point(11, 116);
            this.txtPlacaConsulta.Mask = ">L>L>L-0000";
            this.txtPlacaConsulta.Name = "txtPlacaConsulta";
            this.txtPlacaConsulta.Size = new System.Drawing.Size(186, 32);
            this.txtPlacaConsulta.TabIndex = 22;
            // 
            // lblPlacaConsulta
            // 
            this.lblPlacaConsulta.AutoSize = true;
            this.lblPlacaConsulta.Location = new System.Drawing.Point(6, 92);
            this.lblPlacaConsulta.Name = "lblPlacaConsulta";
            this.lblPlacaConsulta.Size = new System.Drawing.Size(48, 25);
            this.lblPlacaConsulta.TabIndex = 17;
            this.lblPlacaConsulta.Text = "Placa:";
            // 
            // Abastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlAbast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Abastecimento";
            this.Text = "Abastecimento";
            this.tbControlAbast.ResumeLayout(false);
            this.tbPageCadastroAbast.ResumeLayout(false);
            this.gbDadosAbast.ResumeLayout(false);
            this.gbDadosAbast.PerformLayout();
            this.tbPageConsultaAbast.ResumeLayout(false);
            this.gbConsultaAbast.ResumeLayout(false);
            this.gbConsultaAbast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculoAbast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlAbast;
        private System.Windows.Forms.TabPage tbPageCadastroAbast;
        private System.Windows.Forms.GroupBox gbDadosAbast;
        private System.Windows.Forms.ComboBox cbServicoExterno;
        private System.Windows.Forms.Label lblServicoExterno;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label lblValorLitro;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtDataManunt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnExcluirAbast;
        private System.Windows.Forms.Button btnAlterarAbast;
        private System.Windows.Forms.Button btnCadastrarAbast;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TabPage tbPageConsultaAbast;
        private System.Windows.Forms.GroupBox gbConsultaAbast;
        private System.Windows.Forms.Label lblDataAbastConsulta;
        private System.Windows.Forms.DateTimePicker dtDataAbastConsulta;
        private System.Windows.Forms.ComboBox cbTipoAbastConsulta;
        private System.Windows.Forms.Label lblTipoAbastConsulta;
        private System.Windows.Forms.Button btnTrasferirAbast;
        private System.Windows.Forms.DataGridView dgVeiculoAbast;
        private System.Windows.Forms.Button btnTodosAbast;
        private System.Windows.Forms.Button btnConsultarAbast;
        private System.Windows.Forms.MaskedTextBox txtPlacaConsulta;
        private System.Windows.Forms.Label lblPlacaConsulta;
    }
}