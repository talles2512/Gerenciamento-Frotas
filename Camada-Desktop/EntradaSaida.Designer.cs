namespace CamadaDesktop
{
    partial class EntradaSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaSaida));
            this.tbControlEntradaSaida = new System.Windows.Forms.TabControl();
            this.tbPageCadastroEntradaSaida = new System.Windows.Forms.TabPage();
            this.gbDadosEntradaSaida = new System.Windows.Forms.GroupBox();
            this.cbCPF = new System.Windows.Forms.ComboBox();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.cbServicoExterno = new System.Windows.Forms.ComboBox();
            this.lblServicoExterno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.dtDataHora = new System.Windows.Forms.DateTimePicker();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnExcluirEntradaSaida = new System.Windows.Forms.Button();
            this.btnAlterarEntradaSaida = new System.Windows.Forms.Button();
            this.btnCadastrarEntradaSaida = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbPageConsultaEntradaSaida = new System.Windows.Forms.TabPage();
            this.gbConsultaEntradaSaida = new System.Windows.Forms.GroupBox();
            this.cbCPFConsulta = new System.Windows.Forms.ComboBox();
            this.cbPlacaConsulta = new System.Windows.Forms.ComboBox();
            this.dtDataHoraEntradaSaidaConsulta = new System.Windows.Forms.DateTimePicker();
            this.lblDataHoraEntradaSaidaConsulta = new System.Windows.Forms.Label();
            this.cbServicoExternoEntradaSaidaConsulta = new System.Windows.Forms.ComboBox();
            this.lblServicoExternoEntradaSaidaConsulta = new System.Windows.Forms.Label();
            this.lblCPFEntradaSaidaConsulta = new System.Windows.Forms.Label();
            this.lblPlacaEntradaSaidaConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirEntradaSaida = new System.Windows.Forms.Button();
            this.dgEntradaSaidaConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosEntradaSaida = new System.Windows.Forms.Button();
            this.btnConsultarEntradaSaida = new System.Windows.Forms.Button();
            this.tbControlEntradaSaida.SuspendLayout();
            this.tbPageCadastroEntradaSaida.SuspendLayout();
            this.gbDadosEntradaSaida.SuspendLayout();
            this.tbPageConsultaEntradaSaida.SuspendLayout();
            this.gbConsultaEntradaSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradaSaidaConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlEntradaSaida
            // 
            this.tbControlEntradaSaida.Controls.Add(this.tbPageCadastroEntradaSaida);
            this.tbControlEntradaSaida.Controls.Add(this.tbPageConsultaEntradaSaida);
            this.tbControlEntradaSaida.Font = new System.Drawing.Font("Agency FB", 18F);
            this.tbControlEntradaSaida.Location = new System.Drawing.Point(1, 24);
            this.tbControlEntradaSaida.Name = "tbControlEntradaSaida";
            this.tbControlEntradaSaida.SelectedIndex = 0;
            this.tbControlEntradaSaida.Size = new System.Drawing.Size(644, 498);
            this.tbControlEntradaSaida.TabIndex = 24;
            // 
            // tbPageCadastroEntradaSaida
            // 
            this.tbPageCadastroEntradaSaida.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroEntradaSaida.Controls.Add(this.gbDadosEntradaSaida);
            this.tbPageCadastroEntradaSaida.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroEntradaSaida.Name = "tbPageCadastroEntradaSaida";
            this.tbPageCadastroEntradaSaida.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroEntradaSaida.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroEntradaSaida.TabIndex = 0;
            this.tbPageCadastroEntradaSaida.Text = "Cadastrar";
            // 
            // gbDadosEntradaSaida
            // 
            this.gbDadosEntradaSaida.Controls.Add(this.cbCPF);
            this.gbDadosEntradaSaida.Controls.Add(this.cbPlaca);
            this.gbDadosEntradaSaida.Controls.Add(this.cbServicoExterno);
            this.gbDadosEntradaSaida.Controls.Add(this.lblServicoExterno);
            this.gbDadosEntradaSaida.Controls.Add(this.label1);
            this.gbDadosEntradaSaida.Controls.Add(this.lblPlaca);
            this.gbDadosEntradaSaida.Controls.Add(this.dtDataHora);
            this.gbDadosEntradaSaida.Controls.Add(this.lblDataHora);
            this.gbDadosEntradaSaida.Controls.Add(this.cbTipo);
            this.gbDadosEntradaSaida.Controls.Add(this.btnExcluirEntradaSaida);
            this.gbDadosEntradaSaida.Controls.Add(this.btnAlterarEntradaSaida);
            this.gbDadosEntradaSaida.Controls.Add(this.btnCadastrarEntradaSaida);
            this.gbDadosEntradaSaida.Controls.Add(this.lblTipo);
            this.gbDadosEntradaSaida.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosEntradaSaida.Location = new System.Drawing.Point(6, 6);
            this.gbDadosEntradaSaida.Name = "gbDadosEntradaSaida";
            this.gbDadosEntradaSaida.Size = new System.Drawing.Size(621, 383);
            this.gbDadosEntradaSaida.TabIndex = 1;
            this.gbDadosEntradaSaida.TabStop = false;
            this.gbDadosEntradaSaida.Text = "Dados";
            // 
            // cbCPF
            // 
            this.cbCPF.FormattingEnabled = true;
            this.cbCPF.Location = new System.Drawing.Point(23, 183);
            this.cbCPF.Name = "cbCPF";
            this.cbCPF.Size = new System.Drawing.Size(186, 33);
            this.cbCPF.TabIndex = 18;
            // 
            // cbPlaca
            // 
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(23, 120);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(186, 33);
            this.cbPlaca.TabIndex = 16;
            // 
            // cbServicoExterno
            // 
            this.cbServicoExterno.FormattingEnabled = true;
            this.cbServicoExterno.Location = new System.Drawing.Point(215, 120);
            this.cbServicoExterno.Name = "cbServicoExterno";
            this.cbServicoExterno.Size = new System.Drawing.Size(224, 33);
            this.cbServicoExterno.TabIndex = 17;
            // 
            // lblServicoExterno
            // 
            this.lblServicoExterno.AutoSize = true;
            this.lblServicoExterno.Location = new System.Drawing.Point(210, 92);
            this.lblServicoExterno.Name = "lblServicoExterno";
            this.lblServicoExterno.Size = new System.Drawing.Size(108, 25);
            this.lblServicoExterno.TabIndex = 29;
            this.lblServicoExterno.Text = "Serviço Externo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Motorista - CPF";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(18, 92);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(104, 25);
            this.lblPlaca.TabIndex = 25;
            this.lblPlaca.Text = "Veículo - Placa:";
            // 
            // dtDataHora
            // 
            this.dtDataHora.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dtDataHora.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtDataHora.Location = new System.Drawing.Point(215, 56);
            this.dtDataHora.Name = "dtDataHora";
            this.dtDataHora.Size = new System.Drawing.Size(376, 31);
            this.dtDataHora.TabIndex = 15;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(210, 28);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(80, 25);
            this.lblDataHora.TabIndex = 23;
            this.lblDataHora.Text = "Data/Hora:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(23, 56);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(186, 33);
            this.cbTipo.TabIndex = 14;
            // 
            // btnExcluirEntradaSaida
            // 
            this.btnExcluirEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnExcluirEntradaSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirEntradaSaida.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirEntradaSaida.ForeColor = System.Drawing.Color.White;
            this.btnExcluirEntradaSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirEntradaSaida.Image")));
            this.btnExcluirEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirEntradaSaida.Location = new System.Drawing.Point(229, 337);
            this.btnExcluirEntradaSaida.Name = "btnExcluirEntradaSaida";
            this.btnExcluirEntradaSaida.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirEntradaSaida.TabIndex = 21;
            this.btnExcluirEntradaSaida.Text = "Excluir";
            this.btnExcluirEntradaSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirEntradaSaida.UseVisualStyleBackColor = false;
            // 
            // btnAlterarEntradaSaida
            // 
            this.btnAlterarEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnAlterarEntradaSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarEntradaSaida.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarEntradaSaida.ForeColor = System.Drawing.Color.White;
            this.btnAlterarEntradaSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarEntradaSaida.Image")));
            this.btnAlterarEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarEntradaSaida.Location = new System.Drawing.Point(229, 291);
            this.btnAlterarEntradaSaida.Name = "btnAlterarEntradaSaida";
            this.btnAlterarEntradaSaida.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarEntradaSaida.TabIndex = 20;
            this.btnAlterarEntradaSaida.Text = "Alterar";
            this.btnAlterarEntradaSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarEntradaSaida.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarEntradaSaida
            // 
            this.btnCadastrarEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEntradaSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEntradaSaida.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEntradaSaida.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarEntradaSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarEntradaSaida.Image")));
            this.btnCadastrarEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarEntradaSaida.Location = new System.Drawing.Point(108, 245);
            this.btnCadastrarEntradaSaida.Name = "btnCadastrarEntradaSaida";
            this.btnCadastrarEntradaSaida.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarEntradaSaida.TabIndex = 19;
            this.btnCadastrarEntradaSaida.Text = "Cadastrar";
            this.btnCadastrarEntradaSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarEntradaSaida.UseVisualStyleBackColor = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(18, 28);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 25);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            // 
            // tbPageConsultaEntradaSaida
            // 
            this.tbPageConsultaEntradaSaida.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaEntradaSaida.Controls.Add(this.gbConsultaEntradaSaida);
            this.tbPageConsultaEntradaSaida.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaEntradaSaida.Name = "tbPageConsultaEntradaSaida";
            this.tbPageConsultaEntradaSaida.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaEntradaSaida.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaEntradaSaida.TabIndex = 1;
            this.tbPageConsultaEntradaSaida.Text = "Consultar";
            // 
            // gbConsultaEntradaSaida
            // 
            this.gbConsultaEntradaSaida.Controls.Add(this.cbCPFConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.cbPlacaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.dtDataHoraEntradaSaidaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.lblDataHoraEntradaSaidaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.cbServicoExternoEntradaSaidaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.lblServicoExternoEntradaSaidaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.lblCPFEntradaSaidaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.lblPlacaEntradaSaidaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.btnTrasferirEntradaSaida);
            this.gbConsultaEntradaSaida.Controls.Add(this.dgEntradaSaidaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.btnTodosEntradaSaida);
            this.gbConsultaEntradaSaida.Controls.Add(this.btnConsultarEntradaSaida);
            this.gbConsultaEntradaSaida.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaEntradaSaida.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaEntradaSaida.Name = "gbConsultaEntradaSaida";
            this.gbConsultaEntradaSaida.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaEntradaSaida.TabIndex = 2;
            this.gbConsultaEntradaSaida.TabStop = false;
            this.gbConsultaEntradaSaida.Text = "Consulta";
            // 
            // cbCPFConsulta
            // 
            this.cbCPFConsulta.FormattingEnabled = true;
            this.cbCPFConsulta.Location = new System.Drawing.Point(11, 115);
            this.cbCPFConsulta.Name = "cbCPFConsulta";
            this.cbCPFConsulta.Size = new System.Drawing.Size(186, 33);
            this.cbCPFConsulta.TabIndex = 16;
            // 
            // cbPlacaConsulta
            // 
            this.cbPlacaConsulta.FormattingEnabled = true;
            this.cbPlacaConsulta.Location = new System.Drawing.Point(11, 50);
            this.cbPlacaConsulta.Name = "cbPlacaConsulta";
            this.cbPlacaConsulta.Size = new System.Drawing.Size(186, 33);
            this.cbPlacaConsulta.TabIndex = 14;
            // 
            // dtDataHoraEntradaSaidaConsulta
            // 
            this.dtDataHoraEntradaSaidaConsulta.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dtDataHoraEntradaSaidaConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataHoraEntradaSaidaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataHoraEntradaSaidaConsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtDataHoraEntradaSaidaConsulta.Location = new System.Drawing.Point(203, 115);
            this.dtDataHoraEntradaSaidaConsulta.Name = "dtDataHoraEntradaSaidaConsulta";
            this.dtDataHoraEntradaSaidaConsulta.Size = new System.Drawing.Size(216, 31);
            this.dtDataHoraEntradaSaidaConsulta.TabIndex = 17;
            // 
            // lblDataHoraEntradaSaidaConsulta
            // 
            this.lblDataHoraEntradaSaidaConsulta.AutoSize = true;
            this.lblDataHoraEntradaSaidaConsulta.Location = new System.Drawing.Point(203, 87);
            this.lblDataHoraEntradaSaidaConsulta.Name = "lblDataHoraEntradaSaidaConsulta";
            this.lblDataHoraEntradaSaidaConsulta.Size = new System.Drawing.Size(80, 25);
            this.lblDataHoraEntradaSaidaConsulta.TabIndex = 37;
            this.lblDataHoraEntradaSaidaConsulta.Text = "Data/Hora:";
            // 
            // cbServicoExternoEntradaSaidaConsulta
            // 
            this.cbServicoExternoEntradaSaidaConsulta.FormattingEnabled = true;
            this.cbServicoExternoEntradaSaidaConsulta.Location = new System.Drawing.Point(203, 50);
            this.cbServicoExternoEntradaSaidaConsulta.Name = "cbServicoExternoEntradaSaidaConsulta";
            this.cbServicoExternoEntradaSaidaConsulta.Size = new System.Drawing.Size(216, 33);
            this.cbServicoExternoEntradaSaidaConsulta.TabIndex = 15;
            // 
            // lblServicoExternoEntradaSaidaConsulta
            // 
            this.lblServicoExternoEntradaSaidaConsulta.AutoSize = true;
            this.lblServicoExternoEntradaSaidaConsulta.Location = new System.Drawing.Point(198, 23);
            this.lblServicoExternoEntradaSaidaConsulta.Name = "lblServicoExternoEntradaSaidaConsulta";
            this.lblServicoExternoEntradaSaidaConsulta.Size = new System.Drawing.Size(108, 25);
            this.lblServicoExternoEntradaSaidaConsulta.TabIndex = 35;
            this.lblServicoExternoEntradaSaidaConsulta.Text = "Serviço Externo:";
            // 
            // lblCPFEntradaSaidaConsulta
            // 
            this.lblCPFEntradaSaidaConsulta.AutoSize = true;
            this.lblCPFEntradaSaidaConsulta.Location = new System.Drawing.Point(6, 87);
            this.lblCPFEntradaSaidaConsulta.Name = "lblCPFEntradaSaidaConsulta";
            this.lblCPFEntradaSaidaConsulta.Size = new System.Drawing.Size(110, 25);
            this.lblCPFEntradaSaidaConsulta.TabIndex = 33;
            this.lblCPFEntradaSaidaConsulta.Text = "CPF - Motorista:";
            // 
            // lblPlacaEntradaSaidaConsulta
            // 
            this.lblPlacaEntradaSaidaConsulta.AutoSize = true;
            this.lblPlacaEntradaSaidaConsulta.Location = new System.Drawing.Point(6, 24);
            this.lblPlacaEntradaSaidaConsulta.Name = "lblPlacaEntradaSaidaConsulta";
            this.lblPlacaEntradaSaidaConsulta.Size = new System.Drawing.Size(48, 25);
            this.lblPlacaEntradaSaidaConsulta.TabIndex = 31;
            this.lblPlacaEntradaSaidaConsulta.Text = "Placa:";
            // 
            // btnTrasferirEntradaSaida
            // 
            this.btnTrasferirEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirEntradaSaida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirEntradaSaida.BackgroundImage")));
            this.btnTrasferirEntradaSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnTrasferirEntradaSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirEntradaSaida.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirEntradaSaida.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirEntradaSaida.Location = new System.Drawing.Point(577, 44);
            this.btnTrasferirEntradaSaida.Name = "btnTrasferirEntradaSaida";
            this.btnTrasferirEntradaSaida.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirEntradaSaida.TabIndex = 20;
            this.btnTrasferirEntradaSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirEntradaSaida.UseVisualStyleBackColor = false;
            // 
            // dgEntradaSaidaConsulta
            // 
            this.dgEntradaSaidaConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgEntradaSaidaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntradaSaidaConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgEntradaSaidaConsulta.Location = new System.Drawing.Point(7, 153);
            this.dgEntradaSaidaConsulta.Name = "dgEntradaSaidaConsulta";
            this.dgEntradaSaidaConsulta.Size = new System.Drawing.Size(608, 286);
            this.dgEntradaSaidaConsulta.TabIndex = 21;
            // 
            // btnTodosEntradaSaida
            // 
            this.btnTodosEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnTodosEntradaSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosEntradaSaida.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosEntradaSaida.ForeColor = System.Drawing.Color.White;
            this.btnTodosEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosEntradaSaida.Location = new System.Drawing.Point(425, 90);
            this.btnTodosEntradaSaida.Name = "btnTodosEntradaSaida";
            this.btnTodosEntradaSaida.Size = new System.Drawing.Size(159, 40);
            this.btnTodosEntradaSaida.TabIndex = 19;
            this.btnTodosEntradaSaida.Text = "Consultar Todos";
            this.btnTodosEntradaSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosEntradaSaida.UseVisualStyleBackColor = false;
            // 
            // btnConsultarEntradaSaida
            // 
            this.btnConsultarEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnConsultarEntradaSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEntradaSaida.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEntradaSaida.ForeColor = System.Drawing.Color.White;
            this.btnConsultarEntradaSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarEntradaSaida.Image")));
            this.btnConsultarEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarEntradaSaida.Location = new System.Drawing.Point(425, 44);
            this.btnConsultarEntradaSaida.Name = "btnConsultarEntradaSaida";
            this.btnConsultarEntradaSaida.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarEntradaSaida.TabIndex = 18;
            this.btnConsultarEntradaSaida.Text = "    Consultar";
            this.btnConsultarEntradaSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarEntradaSaida.UseVisualStyleBackColor = false;
            // 
            // EntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlEntradaSaida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntradaSaida";
            this.Text = "EntradaSaida";
            this.tbControlEntradaSaida.ResumeLayout(false);
            this.tbPageCadastroEntradaSaida.ResumeLayout(false);
            this.gbDadosEntradaSaida.ResumeLayout(false);
            this.gbDadosEntradaSaida.PerformLayout();
            this.tbPageConsultaEntradaSaida.ResumeLayout(false);
            this.gbConsultaEntradaSaida.ResumeLayout(false);
            this.gbConsultaEntradaSaida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradaSaidaConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlEntradaSaida;
        private System.Windows.Forms.TabPage tbPageCadastroEntradaSaida;
        private System.Windows.Forms.GroupBox gbDadosEntradaSaida;
        private System.Windows.Forms.Button btnExcluirEntradaSaida;
        private System.Windows.Forms.Button btnAlterarEntradaSaida;
        private System.Windows.Forms.Button btnCadastrarEntradaSaida;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TabPage tbPageConsultaEntradaSaida;
        private System.Windows.Forms.GroupBox gbConsultaEntradaSaida;
        private System.Windows.Forms.Button btnTrasferirEntradaSaida;
        private System.Windows.Forms.DataGridView dgEntradaSaidaConsulta;
        private System.Windows.Forms.Button btnTodosEntradaSaida;
        private System.Windows.Forms.Button btnConsultarEntradaSaida;
        private System.Windows.Forms.DateTimePicker dtDataHora;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblServicoExterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbServicoExterno;
        private System.Windows.Forms.ComboBox cbServicoExternoEntradaSaidaConsulta;
        private System.Windows.Forms.Label lblServicoExternoEntradaSaidaConsulta;
        private System.Windows.Forms.Label lblCPFEntradaSaidaConsulta;
        private System.Windows.Forms.Label lblPlacaEntradaSaidaConsulta;
        private System.Windows.Forms.DateTimePicker dtDataHoraEntradaSaidaConsulta;
        private System.Windows.Forms.Label lblDataHoraEntradaSaidaConsulta;
        private System.Windows.Forms.ComboBox cbCPF;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.ComboBox cbCPFConsulta;
        private System.Windows.Forms.ComboBox cbPlacaConsulta;
    }
}