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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veiculos));
            this.tbControlVeiculos = new System.Windows.Forms.TabControl();
            this.tbPageCadastroVeiculo = new System.Windows.Forms.TabPage();
            this.gbDadosVeiculos = new System.Windows.Forms.GroupBox();
            this.pbpermissao = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.txtChassi = new System.Windows.Forms.MaskedTextBox();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.rdNaoAlugado = new System.Windows.Forms.RadioButton();
            this.rdAlugado = new System.Windows.Forms.RadioButton();
            this.btnExcluirVeiculo = new System.Windows.Forms.Button();
            this.btnAlterarVeiculo = new System.Windows.Forms.Button();
            this.btnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.cbCombustivel = new System.Windows.Forms.ComboBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
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
            this.panelConsultarPorData = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnConsultarPorData = new System.Windows.Forms.Button();
            this.lblFimConsulta = new System.Windows.Forms.Label();
            this.lblInicioConsulta = new System.Windows.Forms.Label();
            this.dtFimConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.textPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.btnTrasferirVeiculo = new System.Windows.Forms.Button();
            this.dgVeiculoConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosVeiculo = new System.Windows.Forms.Button();
            this.btnConsultarVeiculo = new System.Windows.Forms.Button();
            this.txtPlacaConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblPlacaConsulta = new System.Windows.Forms.Label();
            this.tooltipPesquisar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTransfere = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPermissao = new System.Windows.Forms.ToolTip(this.components);
            this.btnAtivarVeiculo = new System.Windows.Forms.Button();
            this.tbControlVeiculos.SuspendLayout();
            this.tbPageCadastroVeiculo.SuspendLayout();
            this.gbDadosVeiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).BeginInit();
            this.tbPageConsultaVeiculo.SuspendLayout();
            this.gbConsultaVeiculo.SuspendLayout();
            this.panelConsultarPorData.SuspendLayout();
            this.gbData.SuspendLayout();
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
            this.tbControlVeiculos.TabIndex = 30;
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
            this.gbDadosVeiculos.Controls.Add(this.pbpermissao);
            this.gbDadosVeiculos.Controls.Add(this.lblCancelar);
            this.gbDadosVeiculos.Controls.Add(this.txtChassi);
            this.gbDadosVeiculos.Controls.Add(this.lblDataVencimento);
            this.gbDadosVeiculos.Controls.Add(this.lblDataInicio);
            this.gbDadosVeiculos.Controls.Add(this.dtVencimento);
            this.gbDadosVeiculos.Controls.Add(this.dtInicio);
            this.gbDadosVeiculos.Controls.Add(this.txtValor);
            this.gbDadosVeiculos.Controls.Add(this.lblValor);
            this.gbDadosVeiculos.Controls.Add(this.rdNaoAlugado);
            this.gbDadosVeiculos.Controls.Add(this.rdAlugado);
            this.gbDadosVeiculos.Controls.Add(this.btnExcluirVeiculo);
            this.gbDadosVeiculos.Controls.Add(this.btnAlterarVeiculo);
            this.gbDadosVeiculos.Controls.Add(this.btnCadastrarVeiculo);
            this.gbDadosVeiculos.Controls.Add(this.cbCombustivel);
            this.gbDadosVeiculos.Controls.Add(this.cbCor);
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
            this.gbDadosVeiculos.Controls.Add(this.btnAtivarVeiculo);
            this.gbDadosVeiculos.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosVeiculos.Location = new System.Drawing.Point(6, 6);
            this.gbDadosVeiculos.Name = "gbDadosVeiculos";
            this.gbDadosVeiculos.Size = new System.Drawing.Size(621, 445);
            this.gbDadosVeiculos.TabIndex = 1;
            this.gbDadosVeiculos.TabStop = false;
            this.gbDadosVeiculos.Text = "Dados";
            // 
            // pbpermissao
            // 
            this.pbpermissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbpermissao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbpermissao.Image = ((System.Drawing.Image)(resources.GetObject("pbpermissao.Image")));
            this.pbpermissao.Location = new System.Drawing.Point(398, 399);
            this.pbpermissao.Name = "pbpermissao";
            this.pbpermissao.Size = new System.Drawing.Size(53, 40);
            this.pbpermissao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbpermissao.TabIndex = 74;
            this.pbpermissao.TabStop = false;
            this.pbpermissao.Visible = false;
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCancelar.Font = new System.Drawing.Font("Agency FB", 20.25F);
            this.lblCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCancelar.Location = new System.Drawing.Point(273, 311);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(89, 32);
            this.lblCancelar.TabIndex = 47;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Visible = false;
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(215, 119);
            this.txtChassi.Mask = ">A>A>A>A>A>A>A>A>A>A>A>A>A>A>A>A>A";
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(186, 32);
            this.txtChassi.TabIndex = 18;
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(308, 217);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(114, 25);
            this.lblDataVencimento.TabIndex = 73;
            this.lblDataVencimento.Text = "Data Vencimento:";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(18, 218);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(77, 25);
            this.lblDataInicio.TabIndex = 72;
            this.lblDataInicio.Text = "Data Inicio:";
            // 
            // dtVencimento
            // 
            this.dtVencimento.CustomFormat = "dd/mm/yyyy";
            this.dtVencimento.Enabled = false;
            this.dtVencimento.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(313, 246);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtVencimento.Size = new System.Drawing.Size(284, 31);
            this.dtVencimento.TabIndex = 25;
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/mm/yyyy";
            this.dtInicio.Enabled = false;
            this.dtInicio.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(23, 246);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtInicio.Size = new System.Drawing.Size(284, 31);
            this.dtInicio.TabIndex = 24;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(313, 183);
            this.txtValor.Mask = "0000000000";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(186, 32);
            this.txtValor.TabIndex = 23;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(308, 154);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 25);
            this.lblValor.TabIndex = 24;
            this.lblValor.Text = "Valor:";
            // 
            // rdNaoAlugado
            // 
            this.rdNaoAlugado.AutoSize = true;
            this.rdNaoAlugado.Location = new System.Drawing.Point(215, 192);
            this.rdNaoAlugado.Name = "rdNaoAlugado";
            this.rdNaoAlugado.Size = new System.Drawing.Size(103, 29);
            this.rdNaoAlugado.TabIndex = 22;
            this.rdNaoAlugado.Text = "Não Alugado";
            this.rdNaoAlugado.UseVisualStyleBackColor = true;
            this.rdNaoAlugado.CheckedChanged += new System.EventHandler(this.rdNaoAlugado_CheckedChanged);
            // 
            // rdAlugado
            // 
            this.rdAlugado.AutoSize = true;
            this.rdAlugado.Location = new System.Drawing.Point(215, 157);
            this.rdAlugado.Name = "rdAlugado";
            this.rdAlugado.Size = new System.Drawing.Size(76, 29);
            this.rdAlugado.TabIndex = 21;
            this.rdAlugado.Text = "Alugado";
            this.rdAlugado.UseVisualStyleBackColor = true;
            this.rdAlugado.CheckedChanged += new System.EventHandler(this.rdAlugado_CheckedChanged);
            // 
            // btnExcluirVeiculo
            // 
            this.btnExcluirVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirVeiculo.Enabled = false;
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
            this.btnExcluirVeiculo.TabIndex = 28;
            this.btnExcluirVeiculo.Text = " Inativar";
            this.btnExcluirVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirVeiculo.UseVisualStyleBackColor = false;
            this.btnExcluirVeiculo.Click += new System.EventHandler(this.BtnExcluirVeiculo_Click);
            // 
            // btnAlterarVeiculo
            // 
            this.btnAlterarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarVeiculo.Enabled = false;
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
            this.btnAlterarVeiculo.TabIndex = 27;
            this.btnAlterarVeiculo.Text = "Alterar";
            this.btnAlterarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarVeiculo.UseVisualStyleBackColor = false;
            this.btnAlterarVeiculo.Click += new System.EventHandler(this.BtnAlterarVeiculo_Click);
            // 
            // btnCadastrarVeiculo
            // 
            this.btnCadastrarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnCadastrarVeiculo.TabIndex = 26;
            this.btnCadastrarVeiculo.Text = "Cadastrar";
            this.btnCadastrarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarVeiculo.UseVisualStyleBackColor = false;
            this.btnCadastrarVeiculo.Click += new System.EventHandler(this.BtnCadastrarVeiculo_Click);
            // 
            // cbCombustivel
            // 
            this.cbCombustivel.FormattingEnabled = true;
            this.cbCombustivel.Location = new System.Drawing.Point(23, 182);
            this.cbCombustivel.Name = "cbCombustivel";
            this.cbCombustivel.Size = new System.Drawing.Size(186, 33);
            this.cbCombustivel.TabIndex = 20;
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(407, 118);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(186, 33);
            this.cbCor.TabIndex = 19;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(23, 119);
            this.txtModelo.MaxLength = 25;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(186, 32);
            this.txtModelo.TabIndex = 17;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(215, 56);
            this.txtMarca.MaxLength = 25;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(186, 32);
            this.txtMarca.TabIndex = 15;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(23, 56);
            this.txtPlaca.Mask = ">L>L>L-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(186, 32);
            this.txtPlaca.TabIndex = 14;
            // 
            // dtAno
            // 
            this.dtAno.CustomFormat = "yyyy";
            this.dtAno.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAno.Location = new System.Drawing.Point(407, 56);
            this.dtAno.Name = "dtAno";
            this.dtAno.ShowUpDown = true;
            this.dtAno.Size = new System.Drawing.Size(105, 31);
            this.dtAno.TabIndex = 16;
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Location = new System.Drawing.Point(18, 154);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(85, 25);
            this.lblCombustivel.TabIndex = 6;
            this.lblCombustivel.Text = "Combustivel:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(402, 90);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(37, 25);
            this.lblCor.TabIndex = 5;
            this.lblCor.Text = "Cor:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(402, 28);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(37, 25);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano:";
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Location = new System.Drawing.Point(210, 91);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(55, 25);
            this.lblChassi.TabIndex = 3;
            this.lblChassi.Text = "Chassi:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(18, 91);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(56, 25);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(210, 28);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 25);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(18, 28);
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
            this.gbConsultaVeiculo.Controls.Add(this.panelConsultarPorData);
            this.gbConsultaVeiculo.Controls.Add(this.textPesquisar);
            this.gbConsultaVeiculo.Controls.Add(this.lbPesquisar);
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
            // panelConsultarPorData
            // 
            this.panelConsultarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelConsultarPorData.Controls.Add(this.gbData);
            this.panelConsultarPorData.Location = new System.Drawing.Point(438, 68);
            this.panelConsultarPorData.Name = "panelConsultarPorData";
            this.panelConsultarPorData.Size = new System.Drawing.Size(177, 213);
            this.panelConsultarPorData.TabIndex = 40;
            this.panelConsultarPorData.Visible = false;
            this.panelConsultarPorData.MouseLeave += new System.EventHandler(this.panelConsultarPorData_MouseLeave);
            // 
            // gbData
            // 
            this.gbData.BackColor = System.Drawing.SystemColors.Control;
            this.gbData.Controls.Add(this.btnConsultarPorData);
            this.gbData.Controls.Add(this.lblFimConsulta);
            this.gbData.Controls.Add(this.lblInicioConsulta);
            this.gbData.Controls.Add(this.dtFimConsulta);
            this.gbData.Controls.Add(this.dtInicioConsulta);
            this.gbData.Location = new System.Drawing.Point(3, 7);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(171, 201);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data de Registro";
            // 
            // btnConsultarPorData
            // 
            this.btnConsultarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarPorData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarPorData.FlatAppearance.BorderSize = 0;
            this.btnConsultarPorData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarPorData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPorData.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPorData.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPorData.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarPorData.Image")));
            this.btnConsultarPorData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPorData.Location = new System.Drawing.Point(6, 155);
            this.btnConsultarPorData.Name = "btnConsultarPorData";
            this.btnConsultarPorData.Size = new System.Drawing.Size(159, 40);
            this.btnConsultarPorData.TabIndex = 21;
            this.btnConsultarPorData.Text = "    Consultar";
            this.btnConsultarPorData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarPorData.UseVisualStyleBackColor = false;
            this.btnConsultarPorData.Click += new System.EventHandler(this.btnConsultarPorData_Click);
            // 
            // lblFimConsulta
            // 
            this.lblFimConsulta.AutoSize = true;
            this.lblFimConsulta.Location = new System.Drawing.Point(0, 90);
            this.lblFimConsulta.Name = "lblFimConsulta";
            this.lblFimConsulta.Size = new System.Drawing.Size(37, 25);
            this.lblFimConsulta.TabIndex = 34;
            this.lblFimConsulta.Text = "Fim:";
            // 
            // lblInicioConsulta
            // 
            this.lblInicioConsulta.AutoSize = true;
            this.lblInicioConsulta.Location = new System.Drawing.Point(1, 28);
            this.lblInicioConsulta.Name = "lblInicioConsulta";
            this.lblInicioConsulta.Size = new System.Drawing.Size(46, 25);
            this.lblInicioConsulta.TabIndex = 33;
            this.lblInicioConsulta.Text = "Inicio:";
            // 
            // dtFimConsulta
            // 
            this.dtFimConsulta.CustomFormat = "MM/yyyy";
            this.dtFimConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtFimConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFimConsulta.Location = new System.Drawing.Point(6, 118);
            this.dtFimConsulta.Name = "dtFimConsulta";
            this.dtFimConsulta.Size = new System.Drawing.Size(159, 31);
            this.dtFimConsulta.TabIndex = 20;
            this.dtFimConsulta.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            // 
            // dtInicioConsulta
            // 
            this.dtInicioConsulta.CustomFormat = "MM/yyyy";
            this.dtInicioConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtInicioConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicioConsulta.Location = new System.Drawing.Point(6, 56);
            this.dtInicioConsulta.Name = "dtInicioConsulta";
            this.dtInicioConsulta.Size = new System.Drawing.Size(159, 31);
            this.dtInicioConsulta.TabIndex = 19;
            this.dtInicioConsulta.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            // 
            // textPesquisar
            // 
            this.textPesquisar.Location = new System.Drawing.Point(252, 30);
            this.textPesquisar.Name = "textPesquisar";
            this.textPesquisar.Size = new System.Drawing.Size(159, 32);
            this.textPesquisar.TabIndex = 20;
            this.textPesquisar.TextChanged += new System.EventHandler(this.TextPesquisar_TextChanged);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(171, 33);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(75, 25);
            this.lbPesquisar.TabIndex = 19;
            this.lbPesquisar.Text = "Pesquisar:";
            // 
            // btnTrasferirVeiculo
            // 
            this.btnTrasferirVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirVeiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirVeiculo.BackgroundImage")));
            this.btnTrasferirVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrasferirVeiculo.FlatAppearance.BorderSize = 0;
            this.btnTrasferirVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirVeiculo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirVeiculo.Location = new System.Drawing.Point(577, 24);
            this.btnTrasferirVeiculo.Name = "btnTrasferirVeiculo";
            this.btnTrasferirVeiculo.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirVeiculo.TabIndex = 17;
            this.btnTrasferirVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirVeiculo.UseVisualStyleBackColor = false;
            this.btnTrasferirVeiculo.Click += new System.EventHandler(this.BtnTrasferirVeiculo_Click);
            // 
            // dgVeiculoConsulta
            // 
            this.dgVeiculoConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgVeiculoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeiculoConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgVeiculoConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgVeiculoConsulta.Location = new System.Drawing.Point(7, 68);
            this.dgVeiculoConsulta.Name = "dgVeiculoConsulta";
            this.dgVeiculoConsulta.ReadOnly = true;
            this.dgVeiculoConsulta.Size = new System.Drawing.Size(608, 371);
            this.dgVeiculoConsulta.TabIndex = 18;
            this.dgVeiculoConsulta.DoubleClick += new System.EventHandler(this.DgVeiculoConsulta_DoubleClick);
            // 
            // btnTodosVeiculo
            // 
            this.btnTodosVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosVeiculo.FlatAppearance.BorderSize = 0;
            this.btnTodosVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosVeiculo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnTodosVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosVeiculo.Location = new System.Drawing.Point(438, 68);
            this.btnTodosVeiculo.Name = "btnTodosVeiculo";
            this.btnTodosVeiculo.Size = new System.Drawing.Size(177, 40);
            this.btnTodosVeiculo.TabIndex = 16;
            this.btnTodosVeiculo.Text = "Consultar p/ Data";
            this.btnTodosVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosVeiculo.UseVisualStyleBackColor = false;
            this.btnTodosVeiculo.Click += new System.EventHandler(this.BtnTodosVeiculo_Click);
            // 
            // btnConsultarVeiculo
            // 
            this.btnConsultarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarVeiculo.FlatAppearance.BorderSize = 0;
            this.btnConsultarVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVeiculo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnConsultarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarVeiculo.Image")));
            this.btnConsultarVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarVeiculo.Location = new System.Drawing.Point(425, 24);
            this.btnConsultarVeiculo.Name = "btnConsultarVeiculo";
            this.btnConsultarVeiculo.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarVeiculo.TabIndex = 15;
            this.btnConsultarVeiculo.Text = "    Consultar";
            this.btnConsultarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarVeiculo.UseVisualStyleBackColor = false;
            this.btnConsultarVeiculo.Click += new System.EventHandler(this.BtnConsultarVeiculo_Click);
            // 
            // txtPlacaConsulta
            // 
            this.txtPlacaConsulta.Location = new System.Drawing.Point(60, 30);
            this.txtPlacaConsulta.Mask = ">L>L>L-0000";
            this.txtPlacaConsulta.Name = "txtPlacaConsulta";
            this.txtPlacaConsulta.Size = new System.Drawing.Size(105, 32);
            this.txtPlacaConsulta.TabIndex = 14;
            // 
            // lblPlacaConsulta
            // 
            this.lblPlacaConsulta.AutoSize = true;
            this.lblPlacaConsulta.Location = new System.Drawing.Point(6, 33);
            this.lblPlacaConsulta.Name = "lblPlacaConsulta";
            this.lblPlacaConsulta.Size = new System.Drawing.Size(48, 25);
            this.lblPlacaConsulta.TabIndex = 17;
            this.lblPlacaConsulta.Text = "Placa:";
            // 
            // btnAtivarVeiculo
            // 
            this.btnAtivarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtivarVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtivarVeiculo.Enabled = false;
            this.btnAtivarVeiculo.FlatAppearance.BorderSize = 0;
            this.btnAtivarVeiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAtivarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivarVeiculo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivarVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnAtivarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnAtivarVeiculo.Image")));
            this.btnAtivarVeiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtivarVeiculo.Location = new System.Drawing.Point(246, 399);
            this.btnAtivarVeiculo.Name = "btnAtivarVeiculo";
            this.btnAtivarVeiculo.Size = new System.Drawing.Size(146, 40);
            this.btnAtivarVeiculo.TabIndex = 75;
            this.btnAtivarVeiculo.Text = " Ativar";
            this.btnAtivarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtivarVeiculo.UseVisualStyleBackColor = false;
            this.btnAtivarVeiculo.Visible = false;
            this.btnAtivarVeiculo.Click += new System.EventHandler(this.btnAtivarVeiculo_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).EndInit();
            this.tbPageConsultaVeiculo.ResumeLayout(false);
            this.gbConsultaVeiculo.ResumeLayout(false);
            this.gbConsultaVeiculo.PerformLayout();
            this.panelConsultarPorData.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.RadioButton rdNaoAlugado;
        private System.Windows.Forms.RadioButton rdAlugado;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.MaskedTextBox txtChassi;
        private System.Windows.Forms.TextBox textPesquisar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.ToolTip tooltipPesquisar;
        private System.Windows.Forms.Panel panelConsultarPorData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnConsultarPorData;
        private System.Windows.Forms.Label lblFimConsulta;
        private System.Windows.Forms.Label lblInicioConsulta;
        private System.Windows.Forms.DateTimePicker dtFimConsulta;
        private System.Windows.Forms.DateTimePicker dtInicioConsulta;
        private System.Windows.Forms.ToolTip toolTipTransfere;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.ToolTip toolTipPermissao;
        private System.Windows.Forms.PictureBox pbpermissao;
        private System.Windows.Forms.Button btnAtivarVeiculo;
    }
}