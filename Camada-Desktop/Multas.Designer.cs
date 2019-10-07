﻿namespace CamadaDesktop
{
    partial class Multas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multas));
            this.tbControlMultas = new System.Windows.Forms.TabControl();
            this.tbPageCadastroMultas = new System.Windows.Forms.TabPage();
            this.gbDadosMulta = new System.Windows.Forms.GroupBox();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.dtMultaPaga = new System.Windows.Forms.DateTimePicker();
            this.rdNaoPaga = new System.Windows.Forms.RadioButton();
            this.rdPaga = new System.Windows.Forms.RadioButton();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.dtDataMulta = new System.Windows.Forms.DateTimePicker();
            this.btnExcluirVeiculo = new System.Windows.Forms.Button();
            this.btnAlterarVeiculo = new System.Windows.Forms.Button();
            this.btnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.tbPageConsultaMultas = new System.Windows.Forms.TabPage();
            this.gbConsultaMultas = new System.Windows.Forms.GroupBox();
            this.txtCPFMultasConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFMultasConsulta = new System.Windows.Forms.Label();
            this.lblDataMultasConsulta = new System.Windows.Forms.Label();
            this.dtDataMultasConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtPlacaMultasConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblPlacaMultasConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirMultas = new System.Windows.Forms.Button();
            this.dgMultasConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosMultas = new System.Windows.Forms.Button();
            this.btnConsultarMultas = new System.Windows.Forms.Button();
            this.tbControlMultas.SuspendLayout();
            this.tbPageCadastroMultas.SuspendLayout();
            this.gbDadosMulta.SuspendLayout();
            this.tbPageConsultaMultas.SuspendLayout();
            this.gbConsultaMultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultasConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlMultas
            // 
            this.tbControlMultas.Controls.Add(this.tbPageCadastroMultas);
            this.tbControlMultas.Controls.Add(this.tbPageConsultaMultas);
            this.tbControlMultas.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlMultas.Location = new System.Drawing.Point(1, 24);
            this.tbControlMultas.Name = "tbControlMultas";
            this.tbControlMultas.SelectedIndex = 0;
            this.tbControlMultas.Size = new System.Drawing.Size(644, 498);
            this.tbControlMultas.TabIndex = 23;
            // 
            // tbPageCadastroMultas
            // 
            this.tbPageCadastroMultas.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroMultas.Controls.Add(this.gbDadosMulta);
            this.tbPageCadastroMultas.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroMultas.Name = "tbPageCadastroMultas";
            this.tbPageCadastroMultas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroMultas.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroMultas.TabIndex = 0;
            this.tbPageCadastroMultas.Text = "Cadastrar";
            // 
            // gbDadosMulta
            // 
            this.gbDadosMulta.Controls.Add(this.lblDataPagamento);
            this.gbDadosMulta.Controls.Add(this.dtMultaPaga);
            this.gbDadosMulta.Controls.Add(this.rdNaoPaga);
            this.gbDadosMulta.Controls.Add(this.rdPaga);
            this.gbDadosMulta.Controls.Add(this.maskedTextBox2);
            this.gbDadosMulta.Controls.Add(this.lblCPF);
            this.gbDadosMulta.Controls.Add(this.txtDesc);
            this.gbDadosMulta.Controls.Add(this.lblDesc);
            this.gbDadosMulta.Controls.Add(this.maskedTextBox1);
            this.gbDadosMulta.Controls.Add(this.lblValor);
            this.gbDadosMulta.Controls.Add(this.txtLocal);
            this.gbDadosMulta.Controls.Add(this.lblData);
            this.gbDadosMulta.Controls.Add(this.lblLocal);
            this.gbDadosMulta.Controls.Add(this.dtDataMulta);
            this.gbDadosMulta.Controls.Add(this.btnExcluirVeiculo);
            this.gbDadosMulta.Controls.Add(this.btnAlterarVeiculo);
            this.gbDadosMulta.Controls.Add(this.btnCadastrarVeiculo);
            this.gbDadosMulta.Controls.Add(this.txtPlaca);
            this.gbDadosMulta.Controls.Add(this.lblPlaca);
            this.gbDadosMulta.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosMulta.Location = new System.Drawing.Point(6, 6);
            this.gbDadosMulta.Name = "gbDadosMulta";
            this.gbDadosMulta.Size = new System.Drawing.Size(621, 445);
            this.gbDadosMulta.TabIndex = 1;
            this.gbDadosMulta.TabStop = false;
            this.gbDadosMulta.Text = "Dados";
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(209, 96);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(112, 25);
            this.lblDataPagamento.TabIndex = 38;
            this.lblDataPagamento.Text = "Data Pagamento:";
            // 
            // dtMultaPaga
            // 
            this.dtMultaPaga.CustomFormat = "dd/mm/yyyy";
            this.dtMultaPaga.Enabled = false;
            this.dtMultaPaga.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtMultaPaga.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMultaPaga.Location = new System.Drawing.Point(214, 127);
            this.dtMultaPaga.Name = "dtMultaPaga";
            this.dtMultaPaga.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtMultaPaga.Size = new System.Drawing.Size(197, 31);
            this.dtMultaPaga.TabIndex = 37;
            // 
            // rdNaoPaga
            // 
            this.rdNaoPaga.AutoSize = true;
            this.rdNaoPaga.Location = new System.Drawing.Point(116, 129);
            this.rdNaoPaga.Name = "rdNaoPaga";
            this.rdNaoPaga.Size = new System.Drawing.Size(87, 29);
            this.rdNaoPaga.TabIndex = 36;
            this.rdNaoPaga.TabStop = true;
            this.rdNaoPaga.Text = "Não Paga";
            this.rdNaoPaga.UseVisualStyleBackColor = true;
            this.rdNaoPaga.CheckedChanged += new System.EventHandler(this.rdNaoPaga_CheckedChanged);
            // 
            // rdPaga
            // 
            this.rdPaga.AutoSize = true;
            this.rdPaga.Location = new System.Drawing.Point(116, 94);
            this.rdPaga.Name = "rdPaga";
            this.rdPaga.Size = new System.Drawing.Size(60, 29);
            this.rdPaga.TabIndex = 35;
            this.rdPaga.TabStop = true;
            this.rdPaga.Text = "Paga";
            this.rdPaga.UseVisualStyleBackColor = true;
            this.rdPaga.CheckedChanged += new System.EventHandler(this.rdPaga_CheckedChanged);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(214, 56);
            this.maskedTextBox2.Mask = ">L>L>L-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(197, 32);
            this.maskedTextBox2.TabIndex = 34;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(209, 28);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(110, 25);
            this.lblCPF.TabIndex = 33;
            this.lblCPF.Text = "CPF - Motorista:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(11, 247);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(487, 54);
            this.txtDesc.TabIndex = 32;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 219);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 25);
            this.lblDesc.TabIndex = 31;
            this.lblDesc.Text = "Descrição:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(11, 121);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(99, 32);
            this.maskedTextBox1.TabIndex = 30;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 91);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 25);
            this.lblValor.TabIndex = 29;
            this.lblValor.Text = "Valor:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(11, 184);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(487, 32);
            this.txtLocal.TabIndex = 28;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(412, 29);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 25);
            this.lblData.TabIndex = 27;
            this.lblData.Text = "Data:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(6, 156);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(45, 25);
            this.lblLocal.TabIndex = 26;
            this.lblLocal.Text = "Local:";
            // 
            // dtDataMulta
            // 
            this.dtDataMulta.CustomFormat = "dd/mm/yyyy";
            this.dtDataMulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataMulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataMulta.Location = new System.Drawing.Point(417, 57);
            this.dtDataMulta.Name = "dtDataMulta";
            this.dtDataMulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataMulta.Size = new System.Drawing.Size(197, 31);
            this.dtDataMulta.TabIndex = 25;
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
            this.btnExcluirVeiculo.Location = new System.Drawing.Point(244, 399);
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
            this.btnAlterarVeiculo.Location = new System.Drawing.Point(244, 353);
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
            this.btnCadastrarVeiculo.Location = new System.Drawing.Point(119, 307);
            this.btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            this.btnCadastrarVeiculo.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarVeiculo.TabIndex = 19;
            this.btnCadastrarVeiculo.Text = "Cadastrar";
            this.btnCadastrarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarVeiculo.UseVisualStyleBackColor = false;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(11, 56);
            this.txtPlaca.Mask = ">L>L>L-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(197, 32);
            this.txtPlaca.TabIndex = 12;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(6, 28);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(104, 25);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Veiculo - Placa:";
            // 
            // tbPageConsultaMultas
            // 
            this.tbPageConsultaMultas.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaMultas.Controls.Add(this.gbConsultaMultas);
            this.tbPageConsultaMultas.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaMultas.Name = "tbPageConsultaMultas";
            this.tbPageConsultaMultas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaMultas.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaMultas.TabIndex = 1;
            this.tbPageConsultaMultas.Text = "Consultar";
            // 
            // gbConsultaMultas
            // 
            this.gbConsultaMultas.Controls.Add(this.txtCPFMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.lblCPFMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.lblDataMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.dtDataMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.txtPlacaMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.lblPlacaMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.btnTrasferirMultas);
            this.gbConsultaMultas.Controls.Add(this.dgMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.btnTodosMultas);
            this.gbConsultaMultas.Controls.Add(this.btnConsultarMultas);
            this.gbConsultaMultas.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaMultas.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaMultas.Name = "gbConsultaMultas";
            this.gbConsultaMultas.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaMultas.TabIndex = 2;
            this.gbConsultaMultas.TabStop = false;
            this.gbConsultaMultas.Text = "Consulta";
            // 
            // txtCPFMultasConsulta
            // 
            this.txtCPFMultasConsulta.Location = new System.Drawing.Point(419, 28);
            this.txtCPFMultasConsulta.Mask = ">L>L>L-0000";
            this.txtCPFMultasConsulta.Name = "txtCPFMultasConsulta";
            this.txtCPFMultasConsulta.Size = new System.Drawing.Size(181, 32);
            this.txtCPFMultasConsulta.TabIndex = 40;
            // 
            // lblCPFMultasConsulta
            // 
            this.lblCPFMultasConsulta.AutoSize = true;
            this.lblCPFMultasConsulta.Location = new System.Drawing.Point(303, 31);
            this.lblCPFMultasConsulta.Name = "lblCPFMultasConsulta";
            this.lblCPFMultasConsulta.Size = new System.Drawing.Size(110, 25);
            this.lblCPFMultasConsulta.TabIndex = 39;
            this.lblCPFMultasConsulta.Text = "CPF - Motorista:";
            // 
            // lblDataMultasConsulta
            // 
            this.lblDataMultasConsulta.AutoSize = true;
            this.lblDataMultasConsulta.Location = new System.Drawing.Point(6, 71);
            this.lblDataMultasConsulta.Name = "lblDataMultasConsulta";
            this.lblDataMultasConsulta.Size = new System.Drawing.Size(42, 25);
            this.lblDataMultasConsulta.TabIndex = 38;
            this.lblDataMultasConsulta.Text = "Data:";
            // 
            // dtDataMultasConsulta
            // 
            this.dtDataMultasConsulta.CustomFormat = "dd/mm/yyyy";
            this.dtDataMultasConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataMultasConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataMultasConsulta.Location = new System.Drawing.Point(54, 66);
            this.dtDataMultasConsulta.Name = "dtDataMultasConsulta";
            this.dtDataMultasConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataMultasConsulta.Size = new System.Drawing.Size(200, 31);
            this.dtDataMultasConsulta.TabIndex = 37;
            // 
            // txtPlacaMultasConsulta
            // 
            this.txtPlacaMultasConsulta.Location = new System.Drawing.Point(116, 28);
            this.txtPlacaMultasConsulta.Mask = ">L>L>L-0000";
            this.txtPlacaMultasConsulta.Name = "txtPlacaMultasConsulta";
            this.txtPlacaMultasConsulta.Size = new System.Drawing.Size(181, 32);
            this.txtPlacaMultasConsulta.TabIndex = 36;
            // 
            // lblPlacaMultasConsulta
            // 
            this.lblPlacaMultasConsulta.AutoSize = true;
            this.lblPlacaMultasConsulta.Location = new System.Drawing.Point(6, 31);
            this.lblPlacaMultasConsulta.Name = "lblPlacaMultasConsulta";
            this.lblPlacaMultasConsulta.Size = new System.Drawing.Size(104, 25);
            this.lblPlacaMultasConsulta.TabIndex = 35;
            this.lblPlacaMultasConsulta.Text = "Veiculo - Placa:";
            // 
            // btnTrasferirMultas
            // 
            this.btnTrasferirMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirMultas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirMultas.BackgroundImage")));
            this.btnTrasferirMultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirMultas.FlatAppearance.BorderSize = 0;
            this.btnTrasferirMultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirMultas.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirMultas.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirMultas.Location = new System.Drawing.Point(577, 66);
            this.btnTrasferirMultas.Name = "btnTrasferirMultas";
            this.btnTrasferirMultas.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirMultas.TabIndex = 21;
            this.btnTrasferirMultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirMultas.UseVisualStyleBackColor = false;
            // 
            // dgMultasConsulta
            // 
            this.dgMultasConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgMultasConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMultasConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgMultasConsulta.Location = new System.Drawing.Point(7, 112);
            this.dgMultasConsulta.Name = "dgMultasConsulta";
            this.dgMultasConsulta.Size = new System.Drawing.Size(608, 327);
            this.dgMultasConsulta.TabIndex = 25;
            // 
            // btnTodosMultas
            // 
            this.btnTodosMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosMultas.FlatAppearance.BorderSize = 0;
            this.btnTodosMultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosMultas.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosMultas.ForeColor = System.Drawing.Color.White;
            this.btnTodosMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosMultas.Location = new System.Drawing.Point(412, 66);
            this.btnTodosMultas.Name = "btnTodosMultas";
            this.btnTodosMultas.Size = new System.Drawing.Size(159, 40);
            this.btnTodosMultas.TabIndex = 24;
            this.btnTodosMultas.Text = "Consultar Todos";
            this.btnTodosMultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosMultas.UseVisualStyleBackColor = false;
            // 
            // btnConsultarMultas
            // 
            this.btnConsultarMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarMultas.FlatAppearance.BorderSize = 0;
            this.btnConsultarMultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarMultas.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarMultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultarMultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarMultas.Image")));
            this.btnConsultarMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarMultas.Location = new System.Drawing.Point(260, 66);
            this.btnConsultarMultas.Name = "btnConsultarMultas";
            this.btnConsultarMultas.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarMultas.TabIndex = 23;
            this.btnConsultarMultas.Text = "    Consultar";
            this.btnConsultarMultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarMultas.UseVisualStyleBackColor = false;
            // 
            // Multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlMultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Multas";
            this.Text = "Multas";
            this.tbControlMultas.ResumeLayout(false);
            this.tbPageCadastroMultas.ResumeLayout(false);
            this.gbDadosMulta.ResumeLayout(false);
            this.gbDadosMulta.PerformLayout();
            this.tbPageConsultaMultas.ResumeLayout(false);
            this.gbConsultaMultas.ResumeLayout(false);
            this.gbConsultaMultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultasConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlMultas;
        private System.Windows.Forms.TabPage tbPageCadastroMultas;
        private System.Windows.Forms.GroupBox gbDadosMulta;
        private System.Windows.Forms.Button btnExcluirVeiculo;
        private System.Windows.Forms.Button btnAlterarVeiculo;
        private System.Windows.Forms.Button btnCadastrarVeiculo;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TabPage tbPageConsultaMultas;
        private System.Windows.Forms.GroupBox gbConsultaMultas;
        private System.Windows.Forms.Button btnTrasferirMultas;
        private System.Windows.Forms.DataGridView dgMultasConsulta;
        private System.Windows.Forms.Button btnTodosMultas;
        private System.Windows.Forms.Button btnConsultarMultas;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.DateTimePicker dtMultaPaga;
        private System.Windows.Forms.RadioButton rdNaoPaga;
        private System.Windows.Forms.RadioButton rdPaga;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.DateTimePicker dtDataMulta;
        private System.Windows.Forms.MaskedTextBox txtCPFMultasConsulta;
        private System.Windows.Forms.Label lblCPFMultasConsulta;
        private System.Windows.Forms.Label lblDataMultasConsulta;
        private System.Windows.Forms.DateTimePicker dtDataMultasConsulta;
        private System.Windows.Forms.MaskedTextBox txtPlacaMultasConsulta;
        private System.Windows.Forms.Label lblPlacaMultasConsulta;
    }
}