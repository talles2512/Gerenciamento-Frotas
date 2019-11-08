namespace CamadaDesktop
{
    partial class EntradasSaidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradasSaidas));
            this.tbControlEntradaSaida = new System.Windows.Forms.TabControl();
            this.tbPageCadastroEntradaSaida = new System.Windows.Forms.TabPage();
            this.gbDadosEntradaSaida = new System.Windows.Forms.GroupBox();
            this.pbpermissao = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
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
            this.panelConsultarPorData = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnConsultarPorData = new System.Windows.Forms.Button();
            this.lblFimConsulta = new System.Windows.Forms.Label();
            this.lblInicioConsulta = new System.Windows.Forms.Label();
            this.dtFimConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.cbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPlacaConsulta = new System.Windows.Forms.ComboBox();
            this.dtDataHoraEntradaSaidaConsulta = new System.Windows.Forms.DateTimePicker();
            this.lblDataHoraEntradaSaidaConsulta = new System.Windows.Forms.Label();
            this.cbServicoExternoEntradaSaidaConsulta = new System.Windows.Forms.ComboBox();
            this.lblServicoExternoEntradaSaidaConsulta = new System.Windows.Forms.Label();
            this.lblPlacaEntradaSaidaConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirEntradaSaida = new System.Windows.Forms.Button();
            this.dgEntradaSaidaConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosEntradaSaida = new System.Windows.Forms.Button();
            this.btnConsultarEntradaSaida = new System.Windows.Forms.Button();
            this.toolTipTransfere = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPermissao = new System.Windows.Forms.ToolTip(this.components);
            this.tbControlEntradaSaida.SuspendLayout();
            this.tbPageCadastroEntradaSaida.SuspendLayout();
            this.gbDadosEntradaSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).BeginInit();
            this.tbPageConsultaEntradaSaida.SuspendLayout();
            this.gbConsultaEntradaSaida.SuspendLayout();
            this.panelConsultarPorData.SuspendLayout();
            this.gbData.SuspendLayout();
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
            this.gbDadosEntradaSaida.Controls.Add(this.pbpermissao);
            this.gbDadosEntradaSaida.Controls.Add(this.lblCancelar);
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
            // pbpermissao
            // 
            this.pbpermissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbpermissao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbpermissao.Image = ((System.Drawing.Image)(resources.GetObject("pbpermissao.Image")));
            this.pbpermissao.Location = new System.Drawing.Point(381, 337);
            this.pbpermissao.Name = "pbpermissao";
            this.pbpermissao.Size = new System.Drawing.Size(53, 40);
            this.pbpermissao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbpermissao.TabIndex = 76;
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
            this.lblCancelar.Location = new System.Drawing.Point(257, 249);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(89, 32);
            this.lblCancelar.TabIndex = 47;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Visible = false;
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // cbCPF
            // 
            this.cbCPF.FormattingEnabled = true;
            this.cbCPF.Location = new System.Drawing.Point(23, 183);
            this.cbCPF.Name = "cbCPF";
            this.cbCPF.Size = new System.Drawing.Size(416, 33);
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
            this.lblServicoExterno.Size = new System.Drawing.Size(179, 25);
            this.lblServicoExterno.TabIndex = 29;
            this.lblServicoExterno.Text = "Garagem / Estacionamento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Motorista - CPF:";
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
            this.btnExcluirEntradaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirEntradaSaida.Enabled = false;
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
            this.btnExcluirEntradaSaida.Click += new System.EventHandler(this.BtnExcluirEntradaSaida_Click);
            // 
            // btnAlterarEntradaSaida
            // 
            this.btnAlterarEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarEntradaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarEntradaSaida.Enabled = false;
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
            this.btnAlterarEntradaSaida.Click += new System.EventHandler(this.BtnAlterarEntradaSaida_Click);
            // 
            // btnCadastrarEntradaSaida
            // 
            this.btnCadastrarEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarEntradaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnCadastrarEntradaSaida.Click += new System.EventHandler(this.BtnCadastrarEntradaSaida_Click);
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
            this.gbConsultaEntradaSaida.Controls.Add(this.panelConsultarPorData);
            this.gbConsultaEntradaSaida.Controls.Add(this.cbTipoConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.label2);
            this.gbConsultaEntradaSaida.Controls.Add(this.cbPlacaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.dtDataHoraEntradaSaidaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.lblDataHoraEntradaSaidaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.cbServicoExternoEntradaSaidaConsulta);
            this.gbConsultaEntradaSaida.Controls.Add(this.lblServicoExternoEntradaSaidaConsulta);
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
            // panelConsultarPorData
            // 
            this.panelConsultarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelConsultarPorData.Controls.Add(this.gbData);
            this.panelConsultarPorData.Location = new System.Drawing.Point(438, 107);
            this.panelConsultarPorData.Name = "panelConsultarPorData";
            this.panelConsultarPorData.Size = new System.Drawing.Size(177, 213);
            this.panelConsultarPorData.TabIndex = 35;
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
            this.btnConsultarPorData.TabIndex = 24;
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
            this.dtFimConsulta.TabIndex = 23;
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
            this.dtInicioConsulta.TabIndex = 22;
            this.dtInicioConsulta.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            // 
            // cbTipoConsulta
            // 
            this.cbTipoConsulta.FormattingEnabled = true;
            this.cbTipoConsulta.Location = new System.Drawing.Point(50, 25);
            this.cbTipoConsulta.Name = "cbTipoConsulta";
            this.cbTipoConsulta.Size = new System.Drawing.Size(162, 33);
            this.cbTipoConsulta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tipo:";
            // 
            // cbPlacaConsulta
            // 
            this.cbPlacaConsulta.FormattingEnabled = true;
            this.cbPlacaConsulta.Location = new System.Drawing.Point(191, 104);
            this.cbPlacaConsulta.Name = "cbPlacaConsulta";
            this.cbPlacaConsulta.Size = new System.Drawing.Size(216, 33);
            this.cbPlacaConsulta.TabIndex = 17;
            // 
            // dtDataHoraEntradaSaidaConsulta
            // 
            this.dtDataHoraEntradaSaidaConsulta.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dtDataHoraEntradaSaidaConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataHoraEntradaSaidaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataHoraEntradaSaidaConsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtDataHoraEntradaSaidaConsulta.Location = new System.Drawing.Point(304, 25);
            this.dtDataHoraEntradaSaidaConsulta.Name = "dtDataHoraEntradaSaidaConsulta";
            this.dtDataHoraEntradaSaidaConsulta.Size = new System.Drawing.Size(311, 31);
            this.dtDataHoraEntradaSaidaConsulta.TabIndex = 15;
            // 
            // lblDataHoraEntradaSaidaConsulta
            // 
            this.lblDataHoraEntradaSaidaConsulta.AutoSize = true;
            this.lblDataHoraEntradaSaidaConsulta.Location = new System.Drawing.Point(218, 28);
            this.lblDataHoraEntradaSaidaConsulta.Name = "lblDataHoraEntradaSaidaConsulta";
            this.lblDataHoraEntradaSaidaConsulta.Size = new System.Drawing.Size(80, 25);
            this.lblDataHoraEntradaSaidaConsulta.TabIndex = 37;
            this.lblDataHoraEntradaSaidaConsulta.Text = "Data/Hora:";
            // 
            // cbServicoExternoEntradaSaidaConsulta
            // 
            this.cbServicoExternoEntradaSaidaConsulta.FormattingEnabled = true;
            this.cbServicoExternoEntradaSaidaConsulta.Location = new System.Drawing.Point(191, 64);
            this.cbServicoExternoEntradaSaidaConsulta.Name = "cbServicoExternoEntradaSaidaConsulta";
            this.cbServicoExternoEntradaSaidaConsulta.Size = new System.Drawing.Size(216, 33);
            this.cbServicoExternoEntradaSaidaConsulta.TabIndex = 16;
            // 
            // lblServicoExternoEntradaSaidaConsulta
            // 
            this.lblServicoExternoEntradaSaidaConsulta.AutoSize = true;
            this.lblServicoExternoEntradaSaidaConsulta.Location = new System.Drawing.Point(6, 70);
            this.lblServicoExternoEntradaSaidaConsulta.Name = "lblServicoExternoEntradaSaidaConsulta";
            this.lblServicoExternoEntradaSaidaConsulta.Size = new System.Drawing.Size(179, 25);
            this.lblServicoExternoEntradaSaidaConsulta.TabIndex = 35;
            this.lblServicoExternoEntradaSaidaConsulta.Text = "Garagem / Estacionamento:";
            // 
            // lblPlacaEntradaSaidaConsulta
            // 
            this.lblPlacaEntradaSaidaConsulta.AutoSize = true;
            this.lblPlacaEntradaSaidaConsulta.Location = new System.Drawing.Point(81, 107);
            this.lblPlacaEntradaSaidaConsulta.Name = "lblPlacaEntradaSaidaConsulta";
            this.lblPlacaEntradaSaidaConsulta.Size = new System.Drawing.Size(104, 25);
            this.lblPlacaEntradaSaidaConsulta.TabIndex = 31;
            this.lblPlacaEntradaSaidaConsulta.Text = "Veículo - Placa:";
            // 
            // btnTrasferirEntradaSaida
            // 
            this.btnTrasferirEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirEntradaSaida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirEntradaSaida.BackgroundImage")));
            this.btnTrasferirEntradaSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirEntradaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrasferirEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnTrasferirEntradaSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirEntradaSaida.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirEntradaSaida.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirEntradaSaida.Location = new System.Drawing.Point(577, 64);
            this.btnTrasferirEntradaSaida.Name = "btnTrasferirEntradaSaida";
            this.btnTrasferirEntradaSaida.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirEntradaSaida.TabIndex = 20;
            this.btnTrasferirEntradaSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirEntradaSaida.UseVisualStyleBackColor = false;
            this.btnTrasferirEntradaSaida.Click += new System.EventHandler(this.BtnTrasferirEntradaSaida_Click);
            // 
            // dgEntradaSaidaConsulta
            // 
            this.dgEntradaSaidaConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgEntradaSaidaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntradaSaidaConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgEntradaSaidaConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgEntradaSaidaConsulta.Location = new System.Drawing.Point(7, 153);
            this.dgEntradaSaidaConsulta.Name = "dgEntradaSaidaConsulta";
            this.dgEntradaSaidaConsulta.ReadOnly = true;
            this.dgEntradaSaidaConsulta.Size = new System.Drawing.Size(608, 286);
            this.dgEntradaSaidaConsulta.TabIndex = 21;
            this.dgEntradaSaidaConsulta.DoubleClick += new System.EventHandler(this.dgEntradaSaidaConsulta_DoubleClick);
            // 
            // btnTodosEntradaSaida
            // 
            this.btnTodosEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosEntradaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnTodosEntradaSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosEntradaSaida.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosEntradaSaida.ForeColor = System.Drawing.Color.White;
            this.btnTodosEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosEntradaSaida.Location = new System.Drawing.Point(438, 107);
            this.btnTodosEntradaSaida.Name = "btnTodosEntradaSaida";
            this.btnTodosEntradaSaida.Size = new System.Drawing.Size(177, 40);
            this.btnTodosEntradaSaida.TabIndex = 19;
            this.btnTodosEntradaSaida.Text = "Consultar p/ Data";
            this.btnTodosEntradaSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosEntradaSaida.UseVisualStyleBackColor = false;
            this.btnTodosEntradaSaida.Click += new System.EventHandler(this.BtnTodosEntradaSaida_Click);
            // 
            // btnConsultarEntradaSaida
            // 
            this.btnConsultarEntradaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarEntradaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarEntradaSaida.FlatAppearance.BorderSize = 0;
            this.btnConsultarEntradaSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEntradaSaida.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEntradaSaida.ForeColor = System.Drawing.Color.White;
            this.btnConsultarEntradaSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarEntradaSaida.Image")));
            this.btnConsultarEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarEntradaSaida.Location = new System.Drawing.Point(425, 64);
            this.btnConsultarEntradaSaida.Name = "btnConsultarEntradaSaida";
            this.btnConsultarEntradaSaida.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarEntradaSaida.TabIndex = 18;
            this.btnConsultarEntradaSaida.Text = "    Consultar";
            this.btnConsultarEntradaSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarEntradaSaida.UseVisualStyleBackColor = false;
            this.btnConsultarEntradaSaida.Click += new System.EventHandler(this.BtnConsultarEntradaSaida_Click);
            // 
            // EntradasSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlEntradaSaida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntradasSaidas";
            this.Text = "EntradaSaida";
            this.Load += new System.EventHandler(this.EntradaSaida_Load);
            this.tbControlEntradaSaida.ResumeLayout(false);
            this.tbPageCadastroEntradaSaida.ResumeLayout(false);
            this.gbDadosEntradaSaida.ResumeLayout(false);
            this.gbDadosEntradaSaida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).EndInit();
            this.tbPageConsultaEntradaSaida.ResumeLayout(false);
            this.gbConsultaEntradaSaida.ResumeLayout(false);
            this.gbConsultaEntradaSaida.PerformLayout();
            this.panelConsultarPorData.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
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
        private System.Windows.Forms.Label lblPlacaEntradaSaidaConsulta;
        private System.Windows.Forms.DateTimePicker dtDataHoraEntradaSaidaConsulta;
        private System.Windows.Forms.Label lblDataHoraEntradaSaidaConsulta;
        private System.Windows.Forms.ComboBox cbCPF;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.ComboBox cbPlacaConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoConsulta;
        private System.Windows.Forms.Panel panelConsultarPorData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnConsultarPorData;
        private System.Windows.Forms.Label lblFimConsulta;
        private System.Windows.Forms.Label lblInicioConsulta;
        private System.Windows.Forms.DateTimePicker dtFimConsulta;
        private System.Windows.Forms.DateTimePicker dtInicioConsulta;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.ToolTip toolTipTransfere;
        private System.Windows.Forms.PictureBox pbpermissao;
        private System.Windows.Forms.ToolTip toolTipPermissao;
    }
}