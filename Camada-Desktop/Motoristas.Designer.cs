﻿namespace CamadaDesktop
{
    partial class Motoristas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Motoristas));
            this.tbControlMotorista = new System.Windows.Forms.TabControl();
            this.tbPageCadastroMotorista = new System.Windows.Forms.TabPage();
            this.gbDadosVeiculos = new System.Windows.Forms.GroupBox();
            this.panelConteudoMotorista = new System.Windows.Forms.Panel();
            this.gbExameMedico = new System.Windows.Forms.GroupBox();
            this.btnAddExameMedico = new System.Windows.Forms.Button();
            this.gbCNH = new System.Windows.Forms.GroupBox();
            this.dtDataVencimentoCNH = new System.Windows.Forms.DateTimePicker();
            this.dtDataEmissaoCNH = new System.Windows.Forms.DateTimePicker();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.cbOrgaoEmissor = new System.Windows.Forms.ComboBox();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.lblOrgaoEmissor = new System.Windows.Forms.Label();
            this.cbCategoriaCNH = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblncnh = new System.Windows.Forms.Label();
            this.txtTelefoneContato = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneContato = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.btnExcluirMotorista = new System.Windows.Forms.Button();
            this.btnAlterarMotorista = new System.Windows.Forms.Button();
            this.btnCadastrarMotorista = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.dtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbPageConsultaMotorista = new System.Windows.Forms.TabPage();
            this.gbConsultaVeiculo = new System.Windows.Forms.GroupBox();
            this.btnTrasferirMotorista = new System.Windows.Forms.Button();
            this.btnConsultarMotorista = new System.Windows.Forms.Button();
            this.lblCPFConsulta = new System.Windows.Forms.Label();
            this.txtCPFConsulta = new System.Windows.Forms.MaskedTextBox();
            this.dgVeiculoConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosMotorista = new System.Windows.Forms.Button();
            this.tbPageExames = new System.Windows.Forms.TabPage();
            this.gbConsultaExame = new System.Windows.Forms.GroupBox();
            this.dtDataExameConsulta = new System.Windows.Forms.DateTimePicker();
            this.btnTransfereExame = new System.Windows.Forms.Button();
            this.lblDataExameConsulta = new System.Windows.Forms.Label();
            this.txtCPFExameConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFExameConsulta = new System.Windows.Forms.Label();
            this.dgExameConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsultaTodosExame = new System.Windows.Forms.Button();
            this.btnConsultaExame = new System.Windows.Forms.Button();
            this.gbDadosExames = new System.Windows.Forms.GroupBox();
            this.dtDataExame = new System.Windows.Forms.DateTimePicker();
            this.txtExameDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricaoExame = new System.Windows.Forms.Label();
            this.btnExcluirExame = new System.Windows.Forms.Button();
            this.btnAlterarExame = new System.Windows.Forms.Button();
            this.btnCadastrarExame = new System.Windows.Forms.Button();
            this.txtCPFExames = new System.Windows.Forms.MaskedTextBox();
            this.lblDataExame = new System.Windows.Forms.Label();
            this.lblCPFExames = new System.Windows.Forms.Label();
            this.tbControlMotorista.SuspendLayout();
            this.tbPageCadastroMotorista.SuspendLayout();
            this.gbDadosVeiculos.SuspendLayout();
            this.panelConteudoMotorista.SuspendLayout();
            this.gbExameMedico.SuspendLayout();
            this.gbCNH.SuspendLayout();
            this.tbPageConsultaMotorista.SuspendLayout();
            this.gbConsultaVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculoConsulta)).BeginInit();
            this.tbPageExames.SuspendLayout();
            this.gbConsultaExame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExameConsulta)).BeginInit();
            this.gbDadosExames.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlMotorista
            // 
            this.tbControlMotorista.Controls.Add(this.tbPageCadastroMotorista);
            this.tbControlMotorista.Controls.Add(this.tbPageConsultaMotorista);
            this.tbControlMotorista.Controls.Add(this.tbPageExames);
            this.tbControlMotorista.Font = new System.Drawing.Font("Agency FB", 18F);
            this.tbControlMotorista.Location = new System.Drawing.Point(1, 24);
            this.tbControlMotorista.Name = "tbControlMotorista";
            this.tbControlMotorista.SelectedIndex = 0;
            this.tbControlMotorista.Size = new System.Drawing.Size(644, 498);
            this.tbControlMotorista.TabIndex = 24;
            // 
            // tbPageCadastroMotorista
            // 
            this.tbPageCadastroMotorista.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroMotorista.Controls.Add(this.gbDadosVeiculos);
            this.tbPageCadastroMotorista.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroMotorista.Name = "tbPageCadastroMotorista";
            this.tbPageCadastroMotorista.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroMotorista.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroMotorista.TabIndex = 0;
            this.tbPageCadastroMotorista.Text = "Cadastrar";
            // 
            // gbDadosVeiculos
            // 
            this.gbDadosVeiculos.Controls.Add(this.panelConteudoMotorista);
            this.gbDadosVeiculos.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosVeiculos.Location = new System.Drawing.Point(6, 6);
            this.gbDadosVeiculos.Name = "gbDadosVeiculos";
            this.gbDadosVeiculos.Size = new System.Drawing.Size(621, 449);
            this.gbDadosVeiculos.TabIndex = 22;
            this.gbDadosVeiculos.TabStop = false;
            this.gbDadosVeiculos.Text = "Dados";
            // 
            // panelConteudoMotorista
            // 
            this.panelConteudoMotorista.AutoScroll = true;
            this.panelConteudoMotorista.Controls.Add(this.gbExameMedico);
            this.panelConteudoMotorista.Controls.Add(this.gbCNH);
            this.panelConteudoMotorista.Controls.Add(this.txtTelefoneContato);
            this.panelConteudoMotorista.Controls.Add(this.txtTelefone);
            this.panelConteudoMotorista.Controls.Add(this.lblTelefoneContato);
            this.panelConteudoMotorista.Controls.Add(this.lblTelefone);
            this.panelConteudoMotorista.Controls.Add(this.txtEndereco);
            this.panelConteudoMotorista.Controls.Add(this.lblEndereco);
            this.panelConteudoMotorista.Controls.Add(this.btnExcluirMotorista);
            this.panelConteudoMotorista.Controls.Add(this.btnAlterarMotorista);
            this.panelConteudoMotorista.Controls.Add(this.btnCadastrarMotorista);
            this.panelConteudoMotorista.Controls.Add(this.txtNome);
            this.panelConteudoMotorista.Controls.Add(this.lblCPF);
            this.panelConteudoMotorista.Controls.Add(this.lblNome);
            this.panelConteudoMotorista.Controls.Add(this.lblRG);
            this.panelConteudoMotorista.Controls.Add(this.dtDataNascimento);
            this.panelConteudoMotorista.Controls.Add(this.lblDataNascimento);
            this.panelConteudoMotorista.Controls.Add(this.txtRG);
            this.panelConteudoMotorista.Controls.Add(this.txtCPF);
            this.panelConteudoMotorista.Location = new System.Drawing.Point(6, 24);
            this.panelConteudoMotorista.Name = "panelConteudoMotorista";
            this.panelConteudoMotorista.Size = new System.Drawing.Size(612, 419);
            this.panelConteudoMotorista.TabIndex = 26;
            // 
            // gbExameMedico
            // 
            this.gbExameMedico.Controls.Add(this.btnAddExameMedico);
            this.gbExameMedico.Location = new System.Drawing.Point(412, 286);
            this.gbExameMedico.Name = "gbExameMedico";
            this.gbExameMedico.Size = new System.Drawing.Size(170, 140);
            this.gbExameMedico.TabIndex = 36;
            this.gbExameMedico.TabStop = false;
            this.gbExameMedico.Text = "Exames Médicos";
            // 
            // btnAddExameMedico
            // 
            this.btnAddExameMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddExameMedico.FlatAppearance.BorderSize = 0;
            this.btnAddExameMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddExameMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExameMedico.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExameMedico.ForeColor = System.Drawing.Color.White;
            this.btnAddExameMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExameMedico.Image")));
            this.btnAddExameMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExameMedico.Location = new System.Drawing.Point(13, 60);
            this.btnAddExameMedico.Name = "btnAddExameMedico";
            this.btnAddExameMedico.Size = new System.Drawing.Size(146, 40);
            this.btnAddExameMedico.TabIndex = 25;
            this.btnAddExameMedico.Text = "     Registrar";
            this.btnAddExameMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddExameMedico.UseVisualStyleBackColor = false;
            this.btnAddExameMedico.Click += new System.EventHandler(this.btnAddExameMedico_Click_1);
            // 
            // gbCNH
            // 
            this.gbCNH.Controls.Add(this.dtDataVencimentoCNH);
            this.gbCNH.Controls.Add(this.dtDataEmissaoCNH);
            this.gbCNH.Controls.Add(this.lblDataVencimento);
            this.gbCNH.Controls.Add(this.cbOrgaoEmissor);
            this.gbCNH.Controls.Add(this.lblDataEmissao);
            this.gbCNH.Controls.Add(this.lblOrgaoEmissor);
            this.gbCNH.Controls.Add(this.cbCategoriaCNH);
            this.gbCNH.Controls.Add(this.lblCategoria);
            this.gbCNH.Controls.Add(this.maskedTextBox1);
            this.gbCNH.Controls.Add(this.lblncnh);
            this.gbCNH.Location = new System.Drawing.Point(12, 286);
            this.gbCNH.Name = "gbCNH";
            this.gbCNH.Size = new System.Drawing.Size(394, 240);
            this.gbCNH.TabIndex = 35;
            this.gbCNH.TabStop = false;
            this.gbCNH.Text = "CNH";
            // 
            // dtDataVencimentoCNH
            // 
            this.dtDataVencimentoCNH.CustomFormat = "dd/mm/yyyy";
            this.dtDataVencimentoCNH.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataVencimentoCNH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataVencimentoCNH.Location = new System.Drawing.Point(14, 191);
            this.dtDataVencimentoCNH.Name = "dtDataVencimentoCNH";
            this.dtDataVencimentoCNH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataVencimentoCNH.Size = new System.Drawing.Size(364, 31);
            this.dtDataVencimentoCNH.TabIndex = 43;
            // 
            // dtDataEmissaoCNH
            // 
            this.dtDataEmissaoCNH.CustomFormat = "dd/mm/yyyy";
            this.dtDataEmissaoCNH.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataEmissaoCNH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataEmissaoCNH.Location = new System.Drawing.Point(14, 128);
            this.dtDataEmissaoCNH.Name = "dtDataEmissaoCNH";
            this.dtDataEmissaoCNH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataEmissaoCNH.Size = new System.Drawing.Size(364, 31);
            this.dtDataEmissaoCNH.TabIndex = 42;
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(9, 163);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(114, 25);
            this.lblDataVencimento.TabIndex = 41;
            this.lblDataVencimento.Text = "Data Vencimento:";
            // 
            // cbOrgaoEmissor
            // 
            this.cbOrgaoEmissor.FormattingEnabled = true;
            this.cbOrgaoEmissor.ItemHeight = 25;
            this.cbOrgaoEmissor.Location = new System.Drawing.Point(279, 64);
            this.cbOrgaoEmissor.Name = "cbOrgaoEmissor";
            this.cbOrgaoEmissor.Size = new System.Drawing.Size(99, 33);
            this.cbOrgaoEmissor.TabIndex = 40;
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(9, 100);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(96, 25);
            this.lblDataEmissao.TabIndex = 36;
            this.lblDataEmissao.Text = "Data Emissão:";
            // 
            // lblOrgaoEmissor
            // 
            this.lblOrgaoEmissor.AutoSize = true;
            this.lblOrgaoEmissor.Location = new System.Drawing.Point(279, 37);
            this.lblOrgaoEmissor.Name = "lblOrgaoEmissor";
            this.lblOrgaoEmissor.Size = new System.Drawing.Size(104, 25);
            this.lblOrgaoEmissor.TabIndex = 39;
            this.lblOrgaoEmissor.Text = "Orgão Emissor:";
            // 
            // cbCategoriaCNH
            // 
            this.cbCategoriaCNH.FormattingEnabled = true;
            this.cbCategoriaCNH.ItemHeight = 25;
            this.cbCategoriaCNH.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "ACC"});
            this.cbCategoriaCNH.Location = new System.Drawing.Point(206, 64);
            this.cbCategoriaCNH.Name = "cbCategoriaCNH";
            this.cbCategoriaCNH.Size = new System.Drawing.Size(67, 33);
            this.cbCategoriaCNH.TabIndex = 38;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(201, 36);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 25);
            this.lblCategoria.TabIndex = 37;
            this.lblCategoria.Text = "Categoria:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(14, 65);
            this.maskedTextBox1.Mask = "000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(186, 32);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // lblncnh
            // 
            this.lblncnh.AutoSize = true;
            this.lblncnh.Location = new System.Drawing.Point(9, 37);
            this.lblncnh.Name = "lblncnh";
            this.lblncnh.Size = new System.Drawing.Size(62, 25);
            this.lblncnh.TabIndex = 32;
            this.lblncnh.Text = "Número:";
            // 
            // txtTelefoneContato
            // 
            this.txtTelefoneContato.Location = new System.Drawing.Point(204, 248);
            this.txtTelefoneContato.Mask = "(99) 0000-0000";
            this.txtTelefoneContato.Name = "txtTelefoneContato";
            this.txtTelefoneContato.Size = new System.Drawing.Size(186, 32);
            this.txtTelefoneContato.TabIndex = 19;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 248);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(186, 32);
            this.txtTelefone.TabIndex = 18;
            // 
            // lblTelefoneContato
            // 
            this.lblTelefoneContato.AutoSize = true;
            this.lblTelefoneContato.Location = new System.Drawing.Point(199, 220);
            this.lblTelefoneContato.Name = "lblTelefoneContato";
            this.lblTelefoneContato.Size = new System.Drawing.Size(127, 25);
            this.lblTelefoneContato.TabIndex = 32;
            this.lblTelefoneContato.Text = "Telefone p/Contato:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(7, 220);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(62, 25);
            this.lblTelefone.TabIndex = 31;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 185);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(571, 32);
            this.txtEndereco.TabIndex = 17;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(7, 157);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(71, 25);
            this.lblEndereco.TabIndex = 29;
            this.lblEndereco.Text = "Endereço:";
            // 
            // btnExcluirMotorista
            // 
            this.btnExcluirMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirMotorista.FlatAppearance.BorderSize = 0;
            this.btnExcluirMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirMotorista.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirMotorista.ForeColor = System.Drawing.Color.White;
            this.btnExcluirMotorista.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirMotorista.Image")));
            this.btnExcluirMotorista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirMotorista.Location = new System.Drawing.Point(249, 666);
            this.btnExcluirMotorista.Name = "btnExcluirMotorista";
            this.btnExcluirMotorista.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirMotorista.TabIndex = 28;
            this.btnExcluirMotorista.Text = "Excluir";
            this.btnExcluirMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirMotorista.UseVisualStyleBackColor = false;
            // 
            // btnAlterarMotorista
            // 
            this.btnAlterarMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarMotorista.FlatAppearance.BorderSize = 0;
            this.btnAlterarMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarMotorista.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarMotorista.ForeColor = System.Drawing.Color.White;
            this.btnAlterarMotorista.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarMotorista.Image")));
            this.btnAlterarMotorista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarMotorista.Location = new System.Drawing.Point(249, 620);
            this.btnAlterarMotorista.Name = "btnAlterarMotorista";
            this.btnAlterarMotorista.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarMotorista.TabIndex = 27;
            this.btnAlterarMotorista.Text = "Alterar";
            this.btnAlterarMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarMotorista.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarMotorista
            // 
            this.btnCadastrarMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarMotorista.FlatAppearance.BorderSize = 0;
            this.btnCadastrarMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarMotorista.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMotorista.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarMotorista.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarMotorista.Image")));
            this.btnCadastrarMotorista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarMotorista.Location = new System.Drawing.Point(126, 574);
            this.btnCadastrarMotorista.Name = "btnCadastrarMotorista";
            this.btnCadastrarMotorista.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarMotorista.TabIndex = 26;
            this.btnCadastrarMotorista.Text = "Cadastrar";
            this.btnCadastrarMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarMotorista.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(204, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(379, 32);
            this.txtNome.TabIndex = 14;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(7, 31);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 25);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(199, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 25);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(7, 94);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(33, 25);
            this.lblRG.TabIndex = 2;
            this.lblRG.Text = "RG:";
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.CustomFormat = "dd/mm/yyyy";
            this.dtDataNascimento.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNascimento.Location = new System.Drawing.Point(204, 122);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataNascimento.Size = new System.Drawing.Size(284, 31);
            this.dtDataNascimento.TabIndex = 16;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(199, 94);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(115, 25);
            this.lblDataNascimento.TabIndex = 3;
            this.lblDataNascimento.Text = "Data Nascimento:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(12, 122);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(186, 32);
            this.txtRG.TabIndex = 15;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(12, 59);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(186, 32);
            this.txtCPF.TabIndex = 13;
            // 
            // tbPageConsultaMotorista
            // 
            this.tbPageConsultaMotorista.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaMotorista.Controls.Add(this.gbConsultaVeiculo);
            this.tbPageConsultaMotorista.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaMotorista.Name = "tbPageConsultaMotorista";
            this.tbPageConsultaMotorista.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaMotorista.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaMotorista.TabIndex = 1;
            this.tbPageConsultaMotorista.Text = "Consultar";
            // 
            // gbConsultaVeiculo
            // 
            this.gbConsultaVeiculo.Controls.Add(this.btnTrasferirMotorista);
            this.gbConsultaVeiculo.Controls.Add(this.btnConsultarMotorista);
            this.gbConsultaVeiculo.Controls.Add(this.lblCPFConsulta);
            this.gbConsultaVeiculo.Controls.Add(this.txtCPFConsulta);
            this.gbConsultaVeiculo.Controls.Add(this.dgVeiculoConsulta);
            this.gbConsultaVeiculo.Controls.Add(this.btnTodosMotorista);
            this.gbConsultaVeiculo.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaVeiculo.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaVeiculo.Name = "gbConsultaVeiculo";
            this.gbConsultaVeiculo.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaVeiculo.TabIndex = 23;
            this.gbConsultaVeiculo.TabStop = false;
            this.gbConsultaVeiculo.Text = "Consulta";
            // 
            // btnTrasferirMotorista
            // 
            this.btnTrasferirMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirMotorista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirMotorista.BackgroundImage")));
            this.btnTrasferirMotorista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirMotorista.FlatAppearance.BorderSize = 0;
            this.btnTrasferirMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirMotorista.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirMotorista.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirMotorista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirMotorista.Location = new System.Drawing.Point(580, 24);
            this.btnTrasferirMotorista.Name = "btnTrasferirMotorista";
            this.btnTrasferirMotorista.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirMotorista.TabIndex = 32;
            this.btnTrasferirMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirMotorista.UseVisualStyleBackColor = false;
            // 
            // btnConsultarMotorista
            // 
            this.btnConsultarMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarMotorista.FlatAppearance.BorderSize = 0;
            this.btnConsultarMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarMotorista.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarMotorista.ForeColor = System.Drawing.Color.White;
            this.btnConsultarMotorista.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarMotorista.Image")));
            this.btnConsultarMotorista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarMotorista.Location = new System.Drawing.Point(266, 24);
            this.btnConsultarMotorista.Name = "btnConsultarMotorista";
            this.btnConsultarMotorista.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarMotorista.TabIndex = 30;
            this.btnConsultarMotorista.Text = "    Consultar";
            this.btnConsultarMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarMotorista.UseVisualStyleBackColor = false;
            // 
            // lblCPFConsulta
            // 
            this.lblCPFConsulta.AutoSize = true;
            this.lblCPFConsulta.Location = new System.Drawing.Point(27, 35);
            this.lblCPFConsulta.Name = "lblCPFConsulta";
            this.lblCPFConsulta.Size = new System.Drawing.Size(41, 25);
            this.lblCPFConsulta.TabIndex = 23;
            this.lblCPFConsulta.Text = "CPF:";
            // 
            // txtCPFConsulta
            // 
            this.txtCPFConsulta.Location = new System.Drawing.Point(74, 32);
            this.txtCPFConsulta.Mask = "000.000.000-00";
            this.txtCPFConsulta.Name = "txtCPFConsulta";
            this.txtCPFConsulta.Size = new System.Drawing.Size(186, 32);
            this.txtCPFConsulta.TabIndex = 29;
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
            // btnTodosMotorista
            // 
            this.btnTodosMotorista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosMotorista.FlatAppearance.BorderSize = 0;
            this.btnTodosMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosMotorista.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosMotorista.ForeColor = System.Drawing.Color.White;
            this.btnTodosMotorista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosMotorista.Location = new System.Drawing.Point(418, 24);
            this.btnTodosMotorista.Name = "btnTodosMotorista";
            this.btnTodosMotorista.Size = new System.Drawing.Size(159, 40);
            this.btnTodosMotorista.TabIndex = 31;
            this.btnTodosMotorista.Text = "Consultar Todos";
            this.btnTodosMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosMotorista.UseVisualStyleBackColor = false;
            // 
            // tbPageExames
            // 
            this.tbPageExames.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageExames.Controls.Add(this.gbConsultaExame);
            this.tbPageExames.Controls.Add(this.gbDadosExames);
            this.tbPageExames.Location = new System.Drawing.Point(4, 37);
            this.tbPageExames.Name = "tbPageExames";
            this.tbPageExames.Size = new System.Drawing.Size(636, 457);
            this.tbPageExames.TabIndex = 2;
            this.tbPageExames.Text = "Exames Médicos";
            // 
            // gbConsultaExame
            // 
            this.gbConsultaExame.Controls.Add(this.dtDataExameConsulta);
            this.gbConsultaExame.Controls.Add(this.btnTransfereExame);
            this.gbConsultaExame.Controls.Add(this.lblDataExameConsulta);
            this.gbConsultaExame.Controls.Add(this.txtCPFExameConsulta);
            this.gbConsultaExame.Controls.Add(this.lblCPFExameConsulta);
            this.gbConsultaExame.Controls.Add(this.dgExameConsulta);
            this.gbConsultaExame.Controls.Add(this.btnConsultaTodosExame);
            this.gbConsultaExame.Controls.Add(this.btnConsultaExame);
            this.gbConsultaExame.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaExame.Location = new System.Drawing.Point(6, 249);
            this.gbConsultaExame.Name = "gbConsultaExame";
            this.gbConsultaExame.Size = new System.Drawing.Size(621, 209);
            this.gbConsultaExame.TabIndex = 25;
            this.gbConsultaExame.TabStop = false;
            this.gbConsultaExame.Text = "Consulta";
            // 
            // dtDataExameConsulta
            // 
            this.dtDataExameConsulta.CustomFormat = "dd/mm/yyyy";
            this.dtDataExameConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataExameConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataExameConsulta.Location = new System.Drawing.Point(235, 34);
            this.dtDataExameConsulta.Name = "dtDataExameConsulta";
            this.dtDataExameConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataExameConsulta.Size = new System.Drawing.Size(284, 31);
            this.dtDataExameConsulta.TabIndex = 34;
            // 
            // btnTransfereExame
            // 
            this.btnTransfereExame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTransfereExame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransfereExame.BackgroundImage")));
            this.btnTransfereExame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransfereExame.FlatAppearance.BorderSize = 0;
            this.btnTransfereExame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTransfereExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfereExame.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfereExame.ForeColor = System.Drawing.Color.White;
            this.btnTransfereExame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfereExame.Location = new System.Drawing.Point(571, 34);
            this.btnTransfereExame.Name = "btnTransfereExame";
            this.btnTransfereExame.Size = new System.Drawing.Size(38, 40);
            this.btnTransfereExame.TabIndex = 33;
            this.btnTransfereExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransfereExame.UseVisualStyleBackColor = false;
            // 
            // lblDataExameConsulta
            // 
            this.lblDataExameConsulta.AutoSize = true;
            this.lblDataExameConsulta.Location = new System.Drawing.Point(187, 36);
            this.lblDataExameConsulta.Name = "lblDataExameConsulta";
            this.lblDataExameConsulta.Size = new System.Drawing.Size(42, 25);
            this.lblDataExameConsulta.TabIndex = 28;
            this.lblDataExameConsulta.Text = "Data:";
            // 
            // txtCPFExameConsulta
            // 
            this.txtCPFExameConsulta.Location = new System.Drawing.Point(53, 33);
            this.txtCPFExameConsulta.Mask = "000.000.000-00";
            this.txtCPFExameConsulta.Name = "txtCPFExameConsulta";
            this.txtCPFExameConsulta.Size = new System.Drawing.Size(128, 32);
            this.txtCPFExameConsulta.TabIndex = 27;
            // 
            // lblCPFExameConsulta
            // 
            this.lblCPFExameConsulta.AutoSize = true;
            this.lblCPFExameConsulta.Location = new System.Drawing.Point(6, 36);
            this.lblCPFExameConsulta.Name = "lblCPFExameConsulta";
            this.lblCPFExameConsulta.Size = new System.Drawing.Size(41, 25);
            this.lblCPFExameConsulta.TabIndex = 26;
            this.lblCPFExameConsulta.Text = "CPF:";
            // 
            // dgExameConsulta
            // 
            this.dgExameConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgExameConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExameConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgExameConsulta.Location = new System.Drawing.Point(7, 71);
            this.dgExameConsulta.Name = "dgExameConsulta";
            this.dgExameConsulta.Size = new System.Drawing.Size(437, 132);
            this.dgExameConsulta.TabIndex = 25;
            // 
            // btnConsultaTodosExame
            // 
            this.btnConsultaTodosExame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultaTodosExame.FlatAppearance.BorderSize = 0;
            this.btnConsultaTodosExame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaTodosExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaTodosExame.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaTodosExame.ForeColor = System.Drawing.Color.White;
            this.btnConsultaTodosExame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaTodosExame.Location = new System.Drawing.Point(450, 131);
            this.btnConsultaTodosExame.Name = "btnConsultaTodosExame";
            this.btnConsultaTodosExame.Size = new System.Drawing.Size(159, 40);
            this.btnConsultaTodosExame.TabIndex = 24;
            this.btnConsultaTodosExame.Text = "Consultar Todos";
            this.btnConsultaTodosExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultaTodosExame.UseVisualStyleBackColor = false;
            // 
            // btnConsultaExame
            // 
            this.btnConsultaExame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultaExame.FlatAppearance.BorderSize = 0;
            this.btnConsultaExame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaExame.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaExame.ForeColor = System.Drawing.Color.White;
            this.btnConsultaExame.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaExame.Image")));
            this.btnConsultaExame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaExame.Location = new System.Drawing.Point(450, 79);
            this.btnConsultaExame.Name = "btnConsultaExame";
            this.btnConsultaExame.Size = new System.Drawing.Size(159, 40);
            this.btnConsultaExame.TabIndex = 23;
            this.btnConsultaExame.Text = "    Consultar";
            this.btnConsultaExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultaExame.UseVisualStyleBackColor = false;
            // 
            // gbDadosExames
            // 
            this.gbDadosExames.Controls.Add(this.dtDataExame);
            this.gbDadosExames.Controls.Add(this.txtExameDescricao);
            this.gbDadosExames.Controls.Add(this.lblDescricaoExame);
            this.gbDadosExames.Controls.Add(this.btnExcluirExame);
            this.gbDadosExames.Controls.Add(this.btnAlterarExame);
            this.gbDadosExames.Controls.Add(this.btnCadastrarExame);
            this.gbDadosExames.Controls.Add(this.txtCPFExames);
            this.gbDadosExames.Controls.Add(this.lblDataExame);
            this.gbDadosExames.Controls.Add(this.lblCPFExames);
            this.gbDadosExames.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosExames.Location = new System.Drawing.Point(6, 6);
            this.gbDadosExames.Name = "gbDadosExames";
            this.gbDadosExames.Size = new System.Drawing.Size(621, 237);
            this.gbDadosExames.TabIndex = 23;
            this.gbDadosExames.TabStop = false;
            this.gbDadosExames.Text = "Dados";
            // 
            // dtDataExame
            // 
            this.dtDataExame.CustomFormat = "dd/mm/yyyy";
            this.dtDataExame.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataExame.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataExame.Location = new System.Drawing.Point(144, 57);
            this.dtDataExame.Name = "dtDataExame";
            this.dtDataExame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataExame.Size = new System.Drawing.Size(284, 31);
            this.dtDataExame.TabIndex = 25;
            // 
            // txtExameDescricao
            // 
            this.txtExameDescricao.Location = new System.Drawing.Point(7, 119);
            this.txtExameDescricao.Multiline = true;
            this.txtExameDescricao.Name = "txtExameDescricao";
            this.txtExameDescricao.Size = new System.Drawing.Size(421, 76);
            this.txtExameDescricao.TabIndex = 24;
            // 
            // lblDescricaoExame
            // 
            this.lblDescricaoExame.AutoSize = true;
            this.lblDescricaoExame.Location = new System.Drawing.Point(6, 91);
            this.lblDescricaoExame.Name = "lblDescricaoExame";
            this.lblDescricaoExame.Size = new System.Drawing.Size(75, 25);
            this.lblDescricaoExame.TabIndex = 23;
            this.lblDescricaoExame.Text = "Descrição:";
            // 
            // btnExcluirExame
            // 
            this.btnExcluirExame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirExame.FlatAppearance.BorderSize = 0;
            this.btnExcluirExame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirExame.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirExame.ForeColor = System.Drawing.Color.White;
            this.btnExcluirExame.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirExame.Image")));
            this.btnExcluirExame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirExame.Location = new System.Drawing.Point(463, 186);
            this.btnExcluirExame.Name = "btnExcluirExame";
            this.btnExcluirExame.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirExame.TabIndex = 21;
            this.btnExcluirExame.Text = "Excluir";
            this.btnExcluirExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirExame.UseVisualStyleBackColor = false;
            // 
            // btnAlterarExame
            // 
            this.btnAlterarExame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarExame.FlatAppearance.BorderSize = 0;
            this.btnAlterarExame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarExame.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarExame.ForeColor = System.Drawing.Color.White;
            this.btnAlterarExame.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarExame.Image")));
            this.btnAlterarExame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarExame.Location = new System.Drawing.Point(463, 140);
            this.btnAlterarExame.Name = "btnAlterarExame";
            this.btnAlterarExame.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarExame.TabIndex = 20;
            this.btnAlterarExame.Text = "Alterar";
            this.btnAlterarExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarExame.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarExame
            // 
            this.btnCadastrarExame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarExame.FlatAppearance.BorderSize = 0;
            this.btnCadastrarExame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarExame.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarExame.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarExame.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarExame.Image")));
            this.btnCadastrarExame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarExame.Location = new System.Drawing.Point(463, 94);
            this.btnCadastrarExame.Name = "btnCadastrarExame";
            this.btnCadastrarExame.Size = new System.Drawing.Size(146, 40);
            this.btnCadastrarExame.TabIndex = 19;
            this.btnCadastrarExame.Text = "     Cadastrar";
            this.btnCadastrarExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarExame.UseVisualStyleBackColor = false;
            // 
            // txtCPFExames
            // 
            this.txtCPFExames.Location = new System.Drawing.Point(7, 56);
            this.txtCPFExames.Mask = "000.000.000-00";
            this.txtCPFExames.Name = "txtCPFExames";
            this.txtCPFExames.Size = new System.Drawing.Size(128, 32);
            this.txtCPFExames.TabIndex = 12;
            // 
            // lblDataExame
            // 
            this.lblDataExame.AutoSize = true;
            this.lblDataExame.Location = new System.Drawing.Point(139, 28);
            this.lblDataExame.Name = "lblDataExame";
            this.lblDataExame.Size = new System.Drawing.Size(42, 25);
            this.lblDataExame.TabIndex = 1;
            this.lblDataExame.Text = "Data:";
            // 
            // lblCPFExames
            // 
            this.lblCPFExames.AutoSize = true;
            this.lblCPFExames.Location = new System.Drawing.Point(6, 28);
            this.lblCPFExames.Name = "lblCPFExames";
            this.lblCPFExames.Size = new System.Drawing.Size(41, 25);
            this.lblCPFExames.TabIndex = 0;
            this.lblCPFExames.Text = "CPF:";
            // 
            // Motoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlMotorista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Motoristas";
            this.Text = "Motoristas";
            this.tbControlMotorista.ResumeLayout(false);
            this.tbPageCadastroMotorista.ResumeLayout(false);
            this.gbDadosVeiculos.ResumeLayout(false);
            this.panelConteudoMotorista.ResumeLayout(false);
            this.panelConteudoMotorista.PerformLayout();
            this.gbExameMedico.ResumeLayout(false);
            this.gbCNH.ResumeLayout(false);
            this.gbCNH.PerformLayout();
            this.tbPageConsultaMotorista.ResumeLayout(false);
            this.gbConsultaVeiculo.ResumeLayout(false);
            this.gbConsultaVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculoConsulta)).EndInit();
            this.tbPageExames.ResumeLayout(false);
            this.gbConsultaExame.ResumeLayout(false);
            this.gbConsultaExame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExameConsulta)).EndInit();
            this.gbDadosExames.ResumeLayout(false);
            this.gbDadosExames.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbControlMotorista;
        private System.Windows.Forms.TabPage tbPageCadastroMotorista;
        private System.Windows.Forms.GroupBox gbDadosVeiculos;
        private System.Windows.Forms.Panel panelConteudoMotorista;
        private System.Windows.Forms.GroupBox gbExameMedico;
        private System.Windows.Forms.Button btnAddExameMedico;
        private System.Windows.Forms.GroupBox gbCNH;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.ComboBox cbOrgaoEmissor;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.Label lblOrgaoEmissor;
        private System.Windows.Forms.ComboBox cbCategoriaCNH;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblncnh;
        private System.Windows.Forms.MaskedTextBox txtTelefoneContato;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefoneContato;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Button btnExcluirMotorista;
        private System.Windows.Forms.Button btnAlterarMotorista;
        private System.Windows.Forms.Button btnCadastrarMotorista;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.DateTimePicker dtDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TabPage tbPageConsultaMotorista;
        private System.Windows.Forms.GroupBox gbConsultaVeiculo;
        private System.Windows.Forms.Button btnConsultarMotorista;
        private System.Windows.Forms.Label lblCPFConsulta;
        private System.Windows.Forms.MaskedTextBox txtCPFConsulta;
        private System.Windows.Forms.DataGridView dgVeiculoConsulta;
        private System.Windows.Forms.Button btnTodosMotorista;
        private System.Windows.Forms.Button btnTrasferirMotorista;
        private System.Windows.Forms.TabPage tbPageExames;
        private System.Windows.Forms.GroupBox gbDadosExames;
        private System.Windows.Forms.TextBox txtExameDescricao;
        private System.Windows.Forms.Label lblDescricaoExame;
        private System.Windows.Forms.Button btnExcluirExame;
        private System.Windows.Forms.Button btnAlterarExame;
        private System.Windows.Forms.Button btnCadastrarExame;
        private System.Windows.Forms.MaskedTextBox txtCPFExames;
        private System.Windows.Forms.Label lblDataExame;
        private System.Windows.Forms.Label lblCPFExames;
        private System.Windows.Forms.GroupBox gbConsultaExame;
        private System.Windows.Forms.Button btnTransfereExame;
        private System.Windows.Forms.Label lblDataExameConsulta;
        private System.Windows.Forms.MaskedTextBox txtCPFExameConsulta;
        private System.Windows.Forms.Label lblCPFExameConsulta;
        private System.Windows.Forms.DataGridView dgExameConsulta;
        private System.Windows.Forms.Button btnConsultaTodosExame;
        private System.Windows.Forms.Button btnConsultaExame;
        private System.Windows.Forms.DateTimePicker dtDataVencimentoCNH;
        private System.Windows.Forms.DateTimePicker dtDataEmissaoCNH;
        private System.Windows.Forms.DateTimePicker dtDataExameConsulta;
        private System.Windows.Forms.DateTimePicker dtDataExame;
    }
}