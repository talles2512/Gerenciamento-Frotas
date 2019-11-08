namespace CamadaDesktop
{
    partial class Viagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viagens));
            this.tbControlViagens = new System.Windows.Forms.TabControl();
            this.tbPageCadastroViagem = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDadosViagens = new System.Windows.Forms.GroupBox();
            this.pbpermissao = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.cbCPF = new System.Windows.Forms.ComboBox();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.rdsemOcupante = new System.Windows.Forms.RadioButton();
            this.rdOcupante = new System.Windows.Forms.RadioButton();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lbldtSaida = new System.Windows.Forms.Label();
            this.dtDataSaida = new System.Windows.Forms.DateTimePicker();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnExcluirViagens = new System.Windows.Forms.Button();
            this.btnAlterarViagens = new System.Windows.Forms.Button();
            this.btnCadastrarViagens = new System.Windows.Forms.Button();
            this.gbOcupante = new System.Windows.Forms.GroupBox();
            this.btnRemoverOcupante = new System.Windows.Forms.Button();
            this.btnAddOcupante = new System.Windows.Forms.Button();
            this.listboxOcupantes = new System.Windows.Forms.ListBox();
            this.lblCPFOcupante = new System.Windows.Forms.Label();
            this.txtNomeOcupante = new System.Windows.Forms.TextBox();
            this.txtCPFOcupante = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbPageConsultaViagens = new System.Windows.Forms.TabPage();
            this.gbConsultaViagens = new System.Windows.Forms.GroupBox();
            this.textPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.panelConsultarPorData = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnConsultarPorData = new System.Windows.Forms.Button();
            this.lblFimConsulta = new System.Windows.Forms.Label();
            this.lblInicioConsulta = new System.Windows.Forms.Label();
            this.dtFimConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.btnTrasferirViagens = new System.Windows.Forms.Button();
            this.dgViagensConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodasViagens = new System.Windows.Forms.Button();
            this.btnConsultarViagens = new System.Windows.Forms.Button();
            this.txtRequisicaoConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblreqConsulta = new System.Windows.Forms.Label();
            this.tbPageControlOcupantes = new System.Windows.Forms.TabPage();
            this.gbConsultaOcupante = new System.Windows.Forms.GroupBox();
            this.lblCPFOcupanteConsulta = new System.Windows.Forms.Label();
            this.txtCPFOcupanteConsulta = new System.Windows.Forms.MaskedTextBox();
            this.txtReqOcupanteConsulta = new System.Windows.Forms.MaskedTextBox();
            this.panelConsultarPorDataOcupantes = new System.Windows.Forms.Panel();
            this.gbConsultarPorDataOcupantes = new System.Windows.Forms.GroupBox();
            this.btnConsultarPorDataOcupantes = new System.Windows.Forms.Button();
            this.lblFimConsultarPorDataOcupantes = new System.Windows.Forms.Label();
            this.lblInicioConsultarPorDataOcupantes = new System.Windows.Forms.Label();
            this.dtFimConsultarPorDataOcupantes = new System.Windows.Forms.DateTimePicker();
            this.dtInicioConsultarPorDataOcupantes = new System.Windows.Forms.DateTimePicker();
            this.lblReqOcupantesConsulta = new System.Windows.Forms.Label();
            this.dgOcupanteConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsultaTodosOcupante = new System.Windows.Forms.Button();
            this.btnConsultaOcupante = new System.Windows.Forms.Button();
            this.toolTipTransfere = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipPesquisar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPermissao = new System.Windows.Forms.ToolTip(this.components);
            this.tbControlViagens.SuspendLayout();
            this.tbPageCadastroViagem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDadosViagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).BeginInit();
            this.gbOcupante.SuspendLayout();
            this.tbPageConsultaViagens.SuspendLayout();
            this.gbConsultaViagens.SuspendLayout();
            this.panelConsultarPorData.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViagensConsulta)).BeginInit();
            this.tbPageControlOcupantes.SuspendLayout();
            this.gbConsultaOcupante.SuspendLayout();
            this.panelConsultarPorDataOcupantes.SuspendLayout();
            this.gbConsultarPorDataOcupantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOcupanteConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlViagens
            // 
            this.tbControlViagens.Controls.Add(this.tbPageCadastroViagem);
            this.tbControlViagens.Controls.Add(this.tbPageConsultaViagens);
            this.tbControlViagens.Controls.Add(this.tbPageControlOcupantes);
            this.tbControlViagens.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlViagens.Location = new System.Drawing.Point(1, 24);
            this.tbControlViagens.Name = "tbControlViagens";
            this.tbControlViagens.SelectedIndex = 0;
            this.tbControlViagens.Size = new System.Drawing.Size(644, 564);
            this.tbControlViagens.TabIndex = 35;
            // 
            // tbPageCadastroViagem
            // 
            this.tbPageCadastroViagem.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroViagem.Controls.Add(this.panel1);
            this.tbPageCadastroViagem.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroViagem.Name = "tbPageCadastroViagem";
            this.tbPageCadastroViagem.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroViagem.Size = new System.Drawing.Size(636, 523);
            this.tbPageCadastroViagem.TabIndex = 0;
            this.tbPageCadastroViagem.Text = "Cadastrar";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.gbDadosViagens);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 514);
            this.panel1.TabIndex = 0;
            // 
            // gbDadosViagens
            // 
            this.gbDadosViagens.Controls.Add(this.pbpermissao);
            this.gbDadosViagens.Controls.Add(this.lblCancelar);
            this.gbDadosViagens.Controls.Add(this.cbCPF);
            this.gbDadosViagens.Controls.Add(this.cbPlaca);
            this.gbDadosViagens.Controls.Add(this.rdsemOcupante);
            this.gbDadosViagens.Controls.Add(this.rdOcupante);
            this.gbDadosViagens.Controls.Add(this.lblCPF);
            this.gbDadosViagens.Controls.Add(this.lblPlaca);
            this.gbDadosViagens.Controls.Add(this.lbldtSaida);
            this.gbDadosViagens.Controls.Add(this.dtDataSaida);
            this.gbDadosViagens.Controls.Add(this.txtDestino);
            this.gbDadosViagens.Controls.Add(this.lblDestino);
            this.gbDadosViagens.Controls.Add(this.btnExcluirViagens);
            this.gbDadosViagens.Controls.Add(this.btnAlterarViagens);
            this.gbDadosViagens.Controls.Add(this.btnCadastrarViagens);
            this.gbDadosViagens.Controls.Add(this.gbOcupante);
            this.gbDadosViagens.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosViagens.Location = new System.Drawing.Point(4, 6);
            this.gbDadosViagens.Name = "gbDadosViagens";
            this.gbDadosViagens.Size = new System.Drawing.Size(604, 551);
            this.gbDadosViagens.TabIndex = 3;
            this.gbDadosViagens.TabStop = false;
            this.gbDadosViagens.Text = "Dados";
            // 
            // pbpermissao
            // 
            this.pbpermissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbpermissao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbpermissao.Image = ((System.Drawing.Image)(resources.GetObject("pbpermissao.Image")));
            this.pbpermissao.Location = new System.Drawing.Point(396, 505);
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
            this.lblCancelar.Location = new System.Drawing.Point(271, 417);
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
            this.cbCPF.Location = new System.Drawing.Point(255, 118);
            this.cbCPF.Name = "cbCPF";
            this.cbCPF.Size = new System.Drawing.Size(281, 33);
            this.cbCPF.TabIndex = 17;
            // 
            // cbPlaca
            // 
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(11, 118);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(239, 33);
            this.cbPlaca.TabIndex = 16;
            // 
            // rdsemOcupante
            // 
            this.rdsemOcupante.AutoSize = true;
            this.rdsemOcupante.Checked = true;
            this.rdsemOcupante.Location = new System.Drawing.Point(134, 157);
            this.rdsemOcupante.Name = "rdsemOcupante";
            this.rdsemOcupante.Size = new System.Drawing.Size(116, 29);
            this.rdsemOcupante.TabIndex = 19;
            this.rdsemOcupante.TabStop = true;
            this.rdsemOcupante.Text = "Sem Ocupante";
            this.rdsemOcupante.UseVisualStyleBackColor = true;
            this.rdsemOcupante.CheckedChanged += new System.EventHandler(this.rdsemOcupante_CheckedChanged_1);
            // 
            // rdOcupante
            // 
            this.rdOcupante.AutoSize = true;
            this.rdOcupante.Location = new System.Drawing.Point(12, 157);
            this.rdOcupante.Name = "rdOcupante";
            this.rdOcupante.Size = new System.Drawing.Size(116, 29);
            this.rdOcupante.TabIndex = 18;
            this.rdOcupante.Text = "Com Ocupante";
            this.rdOcupante.UseVisualStyleBackColor = true;
            this.rdOcupante.CheckedChanged += new System.EventHandler(this.rdOcupante_CheckedChanged_1);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(250, 91);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(110, 25);
            this.lblCPF.TabIndex = 30;
            this.lblCPF.Text = "Motorista - CPF:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(6, 91);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(104, 25);
            this.lblPlaca.TabIndex = 27;
            this.lblPlaca.Text = "Veículo - Placa:";
            // 
            // lbldtSaida
            // 
            this.lbldtSaida.AutoSize = true;
            this.lbldtSaida.Location = new System.Drawing.Point(391, 27);
            this.lbldtSaida.Name = "lbldtSaida";
            this.lbldtSaida.Size = new System.Drawing.Size(79, 25);
            this.lbldtSaida.TabIndex = 26;
            this.lbldtSaida.Text = "Data Saída:";
            // 
            // dtDataSaida
            // 
            this.dtDataSaida.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dtDataSaida.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataSaida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtDataSaida.Location = new System.Drawing.Point(396, 55);
            this.dtDataSaida.Name = "dtDataSaida";
            this.dtDataSaida.Size = new System.Drawing.Size(199, 31);
            this.dtDataSaida.TabIndex = 15;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(11, 56);
            this.txtDestino.MaxLength = 150;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(379, 32);
            this.txtDestino.TabIndex = 14;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 28);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(59, 25);
            this.lblDestino.TabIndex = 22;
            this.lblDestino.Text = "Destino:";
            // 
            // btnExcluirViagens
            // 
            this.btnExcluirViagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirViagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirViagens.Enabled = false;
            this.btnExcluirViagens.FlatAppearance.BorderSize = 0;
            this.btnExcluirViagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirViagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirViagens.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirViagens.ForeColor = System.Drawing.Color.White;
            this.btnExcluirViagens.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirViagens.Image")));
            this.btnExcluirViagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirViagens.Location = new System.Drawing.Point(244, 505);
            this.btnExcluirViagens.Name = "btnExcluirViagens";
            this.btnExcluirViagens.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirViagens.TabIndex = 27;
            this.btnExcluirViagens.Text = "Excluir";
            this.btnExcluirViagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirViagens.UseVisualStyleBackColor = false;
            this.btnExcluirViagens.Click += new System.EventHandler(this.btnExcluirViagens_Click);
            // 
            // btnAlterarViagens
            // 
            this.btnAlterarViagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarViagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarViagens.Enabled = false;
            this.btnAlterarViagens.FlatAppearance.BorderSize = 0;
            this.btnAlterarViagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarViagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarViagens.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarViagens.ForeColor = System.Drawing.Color.White;
            this.btnAlterarViagens.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarViagens.Image")));
            this.btnAlterarViagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarViagens.Location = new System.Drawing.Point(244, 459);
            this.btnAlterarViagens.Name = "btnAlterarViagens";
            this.btnAlterarViagens.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarViagens.TabIndex = 26;
            this.btnAlterarViagens.Text = "Alterar";
            this.btnAlterarViagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarViagens.UseVisualStyleBackColor = false;
            this.btnAlterarViagens.Click += new System.EventHandler(this.BtnAlterarViagens_Click);
            // 
            // btnCadastrarViagens
            // 
            this.btnCadastrarViagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarViagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarViagens.FlatAppearance.BorderSize = 0;
            this.btnCadastrarViagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarViagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarViagens.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarViagens.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarViagens.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarViagens.Image")));
            this.btnCadastrarViagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarViagens.Location = new System.Drawing.Point(119, 413);
            this.btnCadastrarViagens.Name = "btnCadastrarViagens";
            this.btnCadastrarViagens.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarViagens.TabIndex = 25;
            this.btnCadastrarViagens.Text = "Cadastrar";
            this.btnCadastrarViagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarViagens.UseVisualStyleBackColor = false;
            this.btnCadastrarViagens.Click += new System.EventHandler(this.btnCadastrarViagens_Click_1);
            // 
            // gbOcupante
            // 
            this.gbOcupante.Controls.Add(this.btnRemoverOcupante);
            this.gbOcupante.Controls.Add(this.btnAddOcupante);
            this.gbOcupante.Controls.Add(this.listboxOcupantes);
            this.gbOcupante.Controls.Add(this.lblCPFOcupante);
            this.gbOcupante.Controls.Add(this.txtNomeOcupante);
            this.gbOcupante.Controls.Add(this.txtCPFOcupante);
            this.gbOcupante.Controls.Add(this.lblNome);
            this.gbOcupante.Enabled = false;
            this.gbOcupante.Location = new System.Drawing.Point(6, 189);
            this.gbOcupante.Name = "gbOcupante";
            this.gbOcupante.Size = new System.Drawing.Size(589, 218);
            this.gbOcupante.TabIndex = 33;
            this.gbOcupante.TabStop = false;
            this.gbOcupante.Text = "Ocupante";
            // 
            // btnRemoverOcupante
            // 
            this.btnRemoverOcupante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoverOcupante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverOcupante.Enabled = false;
            this.btnRemoverOcupante.FlatAppearance.BorderSize = 0;
            this.btnRemoverOcupante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoverOcupante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverOcupante.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverOcupante.ForeColor = System.Drawing.Color.White;
            this.btnRemoverOcupante.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverOcupante.Image")));
            this.btnRemoverOcupante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverOcupante.Location = new System.Drawing.Point(395, 140);
            this.btnRemoverOcupante.Name = "btnRemoverOcupante";
            this.btnRemoverOcupante.Size = new System.Drawing.Size(188, 40);
            this.btnRemoverOcupante.TabIndex = 23;
            this.btnRemoverOcupante.Text = "Remover";
            this.btnRemoverOcupante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoverOcupante.UseVisualStyleBackColor = false;
            this.btnRemoverOcupante.Click += new System.EventHandler(this.BtnRemoverOcupante_Click);
            // 
            // btnAddOcupante
            // 
            this.btnAddOcupante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddOcupante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOcupante.FlatAppearance.BorderSize = 0;
            this.btnAddOcupante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddOcupante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOcupante.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOcupante.ForeColor = System.Drawing.Color.White;
            this.btnAddOcupante.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOcupante.Image")));
            this.btnAddOcupante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOcupante.Location = new System.Drawing.Point(395, 94);
            this.btnAddOcupante.Name = "btnAddOcupante";
            this.btnAddOcupante.Size = new System.Drawing.Size(188, 40);
            this.btnAddOcupante.TabIndex = 22;
            this.btnAddOcupante.Text = "Adicionar";
            this.btnAddOcupante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddOcupante.UseVisualStyleBackColor = false;
            this.btnAddOcupante.Click += new System.EventHandler(this.BtnAddOcupante_Click);
            // 
            // listboxOcupantes
            // 
            this.listboxOcupantes.FormattingEnabled = true;
            this.listboxOcupantes.ItemHeight = 25;
            this.listboxOcupantes.Location = new System.Drawing.Point(11, 94);
            this.listboxOcupantes.Name = "listboxOcupantes";
            this.listboxOcupantes.Size = new System.Drawing.Size(378, 104);
            this.listboxOcupantes.TabIndex = 24;
            this.listboxOcupantes.SelectedIndexChanged += new System.EventHandler(this.ListboxOcupantes_SelectedIndexChanged);
            // 
            // lblCPFOcupante
            // 
            this.lblCPFOcupante.AutoSize = true;
            this.lblCPFOcupante.Location = new System.Drawing.Point(390, 28);
            this.lblCPFOcupante.Name = "lblCPFOcupante";
            this.lblCPFOcupante.Size = new System.Drawing.Size(41, 25);
            this.lblCPFOcupante.TabIndex = 35;
            this.lblCPFOcupante.Text = "CPF:";
            // 
            // txtNomeOcupante
            // 
            this.txtNomeOcupante.Location = new System.Drawing.Point(11, 56);
            this.txtNomeOcupante.Name = "txtNomeOcupante";
            this.txtNomeOcupante.Size = new System.Drawing.Size(378, 32);
            this.txtNomeOcupante.TabIndex = 20;
            // 
            // txtCPFOcupante
            // 
            this.txtCPFOcupante.Location = new System.Drawing.Point(395, 56);
            this.txtCPFOcupante.Mask = "000.000.000-00";
            this.txtCPFOcupante.Name = "txtCPFOcupante";
            this.txtCPFOcupante.Size = new System.Drawing.Size(188, 32);
            this.txtCPFOcupante.TabIndex = 21;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 25);
            this.lblNome.TabIndex = 32;
            this.lblNome.Text = "Nome:";
            // 
            // tbPageConsultaViagens
            // 
            this.tbPageConsultaViagens.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaViagens.Controls.Add(this.gbConsultaViagens);
            this.tbPageConsultaViagens.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaViagens.Name = "tbPageConsultaViagens";
            this.tbPageConsultaViagens.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaViagens.Size = new System.Drawing.Size(636, 523);
            this.tbPageConsultaViagens.TabIndex = 1;
            this.tbPageConsultaViagens.Text = "Consultar";
            // 
            // gbConsultaViagens
            // 
            this.gbConsultaViagens.Controls.Add(this.textPesquisar);
            this.gbConsultaViagens.Controls.Add(this.lbPesquisar);
            this.gbConsultaViagens.Controls.Add(this.panelConsultarPorData);
            this.gbConsultaViagens.Controls.Add(this.btnTrasferirViagens);
            this.gbConsultaViagens.Controls.Add(this.dgViagensConsulta);
            this.gbConsultaViagens.Controls.Add(this.btnTodasViagens);
            this.gbConsultaViagens.Controls.Add(this.btnConsultarViagens);
            this.gbConsultaViagens.Controls.Add(this.txtRequisicaoConsulta);
            this.gbConsultaViagens.Controls.Add(this.lblreqConsulta);
            this.gbConsultaViagens.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaViagens.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaViagens.Name = "gbConsultaViagens";
            this.gbConsultaViagens.Size = new System.Drawing.Size(621, 507);
            this.gbConsultaViagens.TabIndex = 2;
            this.gbConsultaViagens.TabStop = false;
            this.gbConsultaViagens.Text = "Consulta";
            // 
            // textPesquisar
            // 
            this.textPesquisar.Location = new System.Drawing.Point(86, 72);
            this.textPesquisar.Name = "textPesquisar";
            this.textPesquisar.Size = new System.Drawing.Size(193, 32);
            this.textPesquisar.TabIndex = 43;
            this.textPesquisar.TextChanged += new System.EventHandler(this.TextPesquisar_TextChanged);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(5, 75);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(75, 25);
            this.lbPesquisar.TabIndex = 42;
            this.lbPesquisar.Text = "Pesquisar:";
            // 
            // panelConsultarPorData
            // 
            this.panelConsultarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelConsultarPorData.Controls.Add(this.gbData);
            this.panelConsultarPorData.Location = new System.Drawing.Point(397, 24);
            this.panelConsultarPorData.Name = "panelConsultarPorData";
            this.panelConsultarPorData.Size = new System.Drawing.Size(177, 213);
            this.panelConsultarPorData.TabIndex = 41;
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
            // btnTrasferirViagens
            // 
            this.btnTrasferirViagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirViagens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirViagens.BackgroundImage")));
            this.btnTrasferirViagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirViagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrasferirViagens.FlatAppearance.BorderSize = 0;
            this.btnTrasferirViagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirViagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirViagens.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirViagens.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirViagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirViagens.Location = new System.Drawing.Point(580, 24);
            this.btnTrasferirViagens.Name = "btnTrasferirViagens";
            this.btnTrasferirViagens.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirViagens.TabIndex = 17;
            this.btnTrasferirViagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirViagens.UseVisualStyleBackColor = false;
            this.btnTrasferirViagens.Click += new System.EventHandler(this.BtnTrasferirViagens_Click);
            // 
            // dgViagensConsulta
            // 
            this.dgViagensConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgViagensConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViagensConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgViagensConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgViagensConsulta.Location = new System.Drawing.Point(7, 110);
            this.dgViagensConsulta.Name = "dgViagensConsulta";
            this.dgViagensConsulta.ReadOnly = true;
            this.dgViagensConsulta.Size = new System.Drawing.Size(608, 391);
            this.dgViagensConsulta.TabIndex = 18;
            this.dgViagensConsulta.DoubleClick += new System.EventHandler(this.dgViagensConsulta_DoubleClick);
            // 
            // btnTodasViagens
            // 
            this.btnTodasViagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodasViagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodasViagens.FlatAppearance.BorderSize = 0;
            this.btnTodasViagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodasViagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodasViagens.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodasViagens.ForeColor = System.Drawing.Color.White;
            this.btnTodasViagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodasViagens.Location = new System.Drawing.Point(397, 25);
            this.btnTodasViagens.Name = "btnTodasViagens";
            this.btnTodasViagens.Size = new System.Drawing.Size(177, 40);
            this.btnTodasViagens.TabIndex = 16;
            this.btnTodasViagens.Text = "Consultar p/ Data";
            this.btnTodasViagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodasViagens.UseVisualStyleBackColor = false;
            this.btnTodasViagens.Click += new System.EventHandler(this.BtnTodasViagens_Click);
            // 
            // btnConsultarViagens
            // 
            this.btnConsultarViagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarViagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarViagens.FlatAppearance.BorderSize = 0;
            this.btnConsultarViagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarViagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarViagens.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarViagens.ForeColor = System.Drawing.Color.White;
            this.btnConsultarViagens.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarViagens.Image")));
            this.btnConsultarViagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarViagens.Location = new System.Drawing.Point(245, 25);
            this.btnConsultarViagens.Name = "btnConsultarViagens";
            this.btnConsultarViagens.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarViagens.TabIndex = 15;
            this.btnConsultarViagens.Text = "    Consultar";
            this.btnConsultarViagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarViagens.UseVisualStyleBackColor = false;
            this.btnConsultarViagens.Click += new System.EventHandler(this.BtnConsultarViagens_Click);
            // 
            // txtRequisicaoConsulta
            // 
            this.txtRequisicaoConsulta.Location = new System.Drawing.Point(86, 31);
            this.txtRequisicaoConsulta.Mask = "999999999";
            this.txtRequisicaoConsulta.Name = "txtRequisicaoConsulta";
            this.txtRequisicaoConsulta.Size = new System.Drawing.Size(153, 32);
            this.txtRequisicaoConsulta.TabIndex = 14;
            // 
            // lblreqConsulta
            // 
            this.lblreqConsulta.AutoSize = true;
            this.lblreqConsulta.Location = new System.Drawing.Point(6, 35);
            this.lblreqConsulta.Name = "lblreqConsulta";
            this.lblreqConsulta.Size = new System.Drawing.Size(79, 25);
            this.lblreqConsulta.TabIndex = 17;
            this.lblreqConsulta.Text = "Requisição:";
            // 
            // tbPageControlOcupantes
            // 
            this.tbPageControlOcupantes.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageControlOcupantes.Controls.Add(this.gbConsultaOcupante);
            this.tbPageControlOcupantes.Location = new System.Drawing.Point(4, 37);
            this.tbPageControlOcupantes.Name = "tbPageControlOcupantes";
            this.tbPageControlOcupantes.Size = new System.Drawing.Size(636, 523);
            this.tbPageControlOcupantes.TabIndex = 2;
            this.tbPageControlOcupantes.Text = "Ocupantes";
            // 
            // gbConsultaOcupante
            // 
            this.gbConsultaOcupante.Controls.Add(this.lblCPFOcupanteConsulta);
            this.gbConsultaOcupante.Controls.Add(this.txtCPFOcupanteConsulta);
            this.gbConsultaOcupante.Controls.Add(this.txtReqOcupanteConsulta);
            this.gbConsultaOcupante.Controls.Add(this.panelConsultarPorDataOcupantes);
            this.gbConsultaOcupante.Controls.Add(this.lblReqOcupantesConsulta);
            this.gbConsultaOcupante.Controls.Add(this.dgOcupanteConsulta);
            this.gbConsultaOcupante.Controls.Add(this.btnConsultaTodosOcupante);
            this.gbConsultaOcupante.Controls.Add(this.btnConsultaOcupante);
            this.gbConsultaOcupante.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaOcupante.Location = new System.Drawing.Point(6, 6);
            this.gbConsultaOcupante.Name = "gbConsultaOcupante";
            this.gbConsultaOcupante.Size = new System.Drawing.Size(621, 514);
            this.gbConsultaOcupante.TabIndex = 26;
            this.gbConsultaOcupante.TabStop = false;
            this.gbConsultaOcupante.Text = "Consulta";
            // 
            // lblCPFOcupanteConsulta
            // 
            this.lblCPFOcupanteConsulta.AutoSize = true;
            this.lblCPFOcupanteConsulta.Location = new System.Drawing.Point(273, 35);
            this.lblCPFOcupanteConsulta.Name = "lblCPFOcupanteConsulta";
            this.lblCPFOcupanteConsulta.Size = new System.Drawing.Size(41, 25);
            this.lblCPFOcupanteConsulta.TabIndex = 44;
            this.lblCPFOcupanteConsulta.Text = "CPF:";
            // 
            // txtCPFOcupanteConsulta
            // 
            this.txtCPFOcupanteConsulta.Location = new System.Drawing.Point(320, 31);
            this.txtCPFOcupanteConsulta.Mask = "000.000.000-00";
            this.txtCPFOcupanteConsulta.Name = "txtCPFOcupanteConsulta";
            this.txtCPFOcupanteConsulta.Size = new System.Drawing.Size(188, 32);
            this.txtCPFOcupanteConsulta.TabIndex = 43;
            // 
            // txtReqOcupanteConsulta
            // 
            this.txtReqOcupanteConsulta.Location = new System.Drawing.Point(91, 32);
            this.txtReqOcupanteConsulta.Mask = "999999999";
            this.txtReqOcupanteConsulta.Name = "txtReqOcupanteConsulta";
            this.txtReqOcupanteConsulta.Size = new System.Drawing.Size(176, 32);
            this.txtReqOcupanteConsulta.TabIndex = 15;
            // 
            // panelConsultarPorDataOcupantes
            // 
            this.panelConsultarPorDataOcupantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelConsultarPorDataOcupantes.Controls.Add(this.gbConsultarPorDataOcupantes);
            this.panelConsultarPorDataOcupantes.Location = new System.Drawing.Point(438, 70);
            this.panelConsultarPorDataOcupantes.Name = "panelConsultarPorDataOcupantes";
            this.panelConsultarPorDataOcupantes.Size = new System.Drawing.Size(177, 213);
            this.panelConsultarPorDataOcupantes.TabIndex = 42;
            this.panelConsultarPorDataOcupantes.Visible = false;
            this.panelConsultarPorDataOcupantes.MouseLeave += new System.EventHandler(this.panelConsultarPorDataOcupantes_MouseLeave);
            // 
            // gbConsultarPorDataOcupantes
            // 
            this.gbConsultarPorDataOcupantes.BackColor = System.Drawing.SystemColors.Control;
            this.gbConsultarPorDataOcupantes.Controls.Add(this.btnConsultarPorDataOcupantes);
            this.gbConsultarPorDataOcupantes.Controls.Add(this.lblFimConsultarPorDataOcupantes);
            this.gbConsultarPorDataOcupantes.Controls.Add(this.lblInicioConsultarPorDataOcupantes);
            this.gbConsultarPorDataOcupantes.Controls.Add(this.dtFimConsultarPorDataOcupantes);
            this.gbConsultarPorDataOcupantes.Controls.Add(this.dtInicioConsultarPorDataOcupantes);
            this.gbConsultarPorDataOcupantes.Location = new System.Drawing.Point(3, 7);
            this.gbConsultarPorDataOcupantes.Name = "gbConsultarPorDataOcupantes";
            this.gbConsultarPorDataOcupantes.Size = new System.Drawing.Size(171, 201);
            this.gbConsultarPorDataOcupantes.TabIndex = 0;
            this.gbConsultarPorDataOcupantes.TabStop = false;
            this.gbConsultarPorDataOcupantes.Text = "Data de Registro";
            // 
            // btnConsultarPorDataOcupantes
            // 
            this.btnConsultarPorDataOcupantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarPorDataOcupantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarPorDataOcupantes.FlatAppearance.BorderSize = 0;
            this.btnConsultarPorDataOcupantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarPorDataOcupantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPorDataOcupantes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPorDataOcupantes.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPorDataOcupantes.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarPorDataOcupantes.Image")));
            this.btnConsultarPorDataOcupantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPorDataOcupantes.Location = new System.Drawing.Point(6, 155);
            this.btnConsultarPorDataOcupantes.Name = "btnConsultarPorDataOcupantes";
            this.btnConsultarPorDataOcupantes.Size = new System.Drawing.Size(159, 40);
            this.btnConsultarPorDataOcupantes.TabIndex = 21;
            this.btnConsultarPorDataOcupantes.Text = "    Consultar";
            this.btnConsultarPorDataOcupantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarPorDataOcupantes.UseVisualStyleBackColor = false;
            this.btnConsultarPorDataOcupantes.Click += new System.EventHandler(this.btnConsultarPorDataOcupantes_Click);
            // 
            // lblFimConsultarPorDataOcupantes
            // 
            this.lblFimConsultarPorDataOcupantes.AutoSize = true;
            this.lblFimConsultarPorDataOcupantes.Location = new System.Drawing.Point(0, 90);
            this.lblFimConsultarPorDataOcupantes.Name = "lblFimConsultarPorDataOcupantes";
            this.lblFimConsultarPorDataOcupantes.Size = new System.Drawing.Size(37, 25);
            this.lblFimConsultarPorDataOcupantes.TabIndex = 34;
            this.lblFimConsultarPorDataOcupantes.Text = "Fim:";
            // 
            // lblInicioConsultarPorDataOcupantes
            // 
            this.lblInicioConsultarPorDataOcupantes.AutoSize = true;
            this.lblInicioConsultarPorDataOcupantes.Location = new System.Drawing.Point(1, 28);
            this.lblInicioConsultarPorDataOcupantes.Name = "lblInicioConsultarPorDataOcupantes";
            this.lblInicioConsultarPorDataOcupantes.Size = new System.Drawing.Size(46, 25);
            this.lblInicioConsultarPorDataOcupantes.TabIndex = 33;
            this.lblInicioConsultarPorDataOcupantes.Text = "Inicio:";
            // 
            // dtFimConsultarPorDataOcupantes
            // 
            this.dtFimConsultarPorDataOcupantes.CustomFormat = "MM/yyyy";
            this.dtFimConsultarPorDataOcupantes.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtFimConsultarPorDataOcupantes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFimConsultarPorDataOcupantes.Location = new System.Drawing.Point(6, 118);
            this.dtFimConsultarPorDataOcupantes.Name = "dtFimConsultarPorDataOcupantes";
            this.dtFimConsultarPorDataOcupantes.Size = new System.Drawing.Size(159, 31);
            this.dtFimConsultarPorDataOcupantes.TabIndex = 20;
            this.dtFimConsultarPorDataOcupantes.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            // 
            // dtInicioConsultarPorDataOcupantes
            // 
            this.dtInicioConsultarPorDataOcupantes.CustomFormat = "MM/yyyy";
            this.dtInicioConsultarPorDataOcupantes.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtInicioConsultarPorDataOcupantes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicioConsultarPorDataOcupantes.Location = new System.Drawing.Point(6, 56);
            this.dtInicioConsultarPorDataOcupantes.Name = "dtInicioConsultarPorDataOcupantes";
            this.dtInicioConsultarPorDataOcupantes.Size = new System.Drawing.Size(159, 31);
            this.dtInicioConsultarPorDataOcupantes.TabIndex = 19;
            this.dtInicioConsultarPorDataOcupantes.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            // 
            // lblReqOcupantesConsulta
            // 
            this.lblReqOcupantesConsulta.AutoSize = true;
            this.lblReqOcupantesConsulta.Location = new System.Drawing.Point(6, 36);
            this.lblReqOcupantesConsulta.Name = "lblReqOcupantesConsulta";
            this.lblReqOcupantesConsulta.Size = new System.Drawing.Size(79, 25);
            this.lblReqOcupantesConsulta.TabIndex = 26;
            this.lblReqOcupantesConsulta.Text = "Requisição:";
            // 
            // dgOcupanteConsulta
            // 
            this.dgOcupanteConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgOcupanteConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOcupanteConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgOcupanteConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgOcupanteConsulta.Location = new System.Drawing.Point(7, 116);
            this.dgOcupanteConsulta.Name = "dgOcupanteConsulta";
            this.dgOcupanteConsulta.ReadOnly = true;
            this.dgOcupanteConsulta.Size = new System.Drawing.Size(608, 392);
            this.dgOcupanteConsulta.TabIndex = 23;
            // 
            // btnConsultaTodosOcupante
            // 
            this.btnConsultaTodosOcupante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultaTodosOcupante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaTodosOcupante.FlatAppearance.BorderSize = 0;
            this.btnConsultaTodosOcupante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaTodosOcupante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaTodosOcupante.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaTodosOcupante.ForeColor = System.Drawing.Color.White;
            this.btnConsultaTodosOcupante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaTodosOcupante.Location = new System.Drawing.Point(438, 70);
            this.btnConsultaTodosOcupante.Name = "btnConsultaTodosOcupante";
            this.btnConsultaTodosOcupante.Size = new System.Drawing.Size(177, 40);
            this.btnConsultaTodosOcupante.TabIndex = 21;
            this.btnConsultaTodosOcupante.Text = "Consultar p/ Data";
            this.btnConsultaTodosOcupante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultaTodosOcupante.UseVisualStyleBackColor = false;
            this.btnConsultaTodosOcupante.Click += new System.EventHandler(this.btnConsultaTodosOcupante_Click);
            // 
            // btnConsultaOcupante
            // 
            this.btnConsultaOcupante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultaOcupante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaOcupante.FlatAppearance.BorderSize = 0;
            this.btnConsultaOcupante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaOcupante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaOcupante.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaOcupante.ForeColor = System.Drawing.Color.White;
            this.btnConsultaOcupante.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaOcupante.Image")));
            this.btnConsultaOcupante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaOcupante.Location = new System.Drawing.Point(273, 70);
            this.btnConsultaOcupante.Name = "btnConsultaOcupante";
            this.btnConsultaOcupante.Size = new System.Drawing.Size(159, 40);
            this.btnConsultaOcupante.TabIndex = 20;
            this.btnConsultaOcupante.Text = "    Consultar";
            this.btnConsultaOcupante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultaOcupante.UseVisualStyleBackColor = false;
            this.btnConsultaOcupante.Click += new System.EventHandler(this.btnConsultaOcupante_Click);
            // 
            // Viagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 593);
            this.Controls.Add(this.tbControlViagens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Viagens";
            this.Text = "Viagens";
            this.Load += new System.EventHandler(this.Viagens_Load);
            this.tbControlViagens.ResumeLayout(false);
            this.tbPageCadastroViagem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbDadosViagens.ResumeLayout(false);
            this.gbDadosViagens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).EndInit();
            this.gbOcupante.ResumeLayout(false);
            this.gbOcupante.PerformLayout();
            this.tbPageConsultaViagens.ResumeLayout(false);
            this.gbConsultaViagens.ResumeLayout(false);
            this.gbConsultaViagens.PerformLayout();
            this.panelConsultarPorData.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViagensConsulta)).EndInit();
            this.tbPageControlOcupantes.ResumeLayout(false);
            this.gbConsultaOcupante.ResumeLayout(false);
            this.gbConsultaOcupante.PerformLayout();
            this.panelConsultarPorDataOcupantes.ResumeLayout(false);
            this.gbConsultarPorDataOcupantes.ResumeLayout(false);
            this.gbConsultarPorDataOcupantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOcupanteConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlViagens;
        private System.Windows.Forms.TabPage tbPageCadastroViagem;
        private System.Windows.Forms.TabPage tbPageConsultaViagens;
        private System.Windows.Forms.GroupBox gbConsultaViagens;
        private System.Windows.Forms.Button btnTrasferirViagens;
        private System.Windows.Forms.DataGridView dgViagensConsulta;
        private System.Windows.Forms.Button btnTodasViagens;
        private System.Windows.Forms.Button btnConsultarViagens;
        private System.Windows.Forms.MaskedTextBox txtRequisicaoConsulta;
        private System.Windows.Forms.Label lblreqConsulta;
        private System.Windows.Forms.TabPage tbPageControlOcupantes;
        private System.Windows.Forms.GroupBox gbConsultaOcupante;
        private System.Windows.Forms.Label lblReqOcupantesConsulta;
        private System.Windows.Forms.DataGridView dgOcupanteConsulta;
        private System.Windows.Forms.Button btnConsultaTodosOcupante;
        private System.Windows.Forms.Button btnConsultaOcupante;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDadosViagens;
        private System.Windows.Forms.ComboBox cbCPF;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.RadioButton rdsemOcupante;
        private System.Windows.Forms.RadioButton rdOcupante;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lbldtSaida;
        private System.Windows.Forms.DateTimePicker dtDataSaida;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnExcluirViagens;
        private System.Windows.Forms.Button btnAlterarViagens;
        private System.Windows.Forms.Button btnCadastrarViagens;
        private System.Windows.Forms.GroupBox gbOcupante;
        private System.Windows.Forms.ListBox listboxOcupantes;
        private System.Windows.Forms.Label lblCPFOcupante;
        private System.Windows.Forms.TextBox txtNomeOcupante;
        private System.Windows.Forms.MaskedTextBox txtCPFOcupante;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnRemoverOcupante;
        private System.Windows.Forms.Button btnAddOcupante;
        private System.Windows.Forms.Panel panelConsultarPorData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnConsultarPorData;
        private System.Windows.Forms.Label lblFimConsulta;
        private System.Windows.Forms.Label lblInicioConsulta;
        private System.Windows.Forms.DateTimePicker dtFimConsulta;
        private System.Windows.Forms.DateTimePicker dtInicioConsulta;
        private System.Windows.Forms.Panel panelConsultarPorDataOcupantes;
        private System.Windows.Forms.GroupBox gbConsultarPorDataOcupantes;
        private System.Windows.Forms.Button btnConsultarPorDataOcupantes;
        private System.Windows.Forms.Label lblFimConsultarPorDataOcupantes;
        private System.Windows.Forms.Label lblInicioConsultarPorDataOcupantes;
        private System.Windows.Forms.DateTimePicker dtFimConsultarPorDataOcupantes;
        private System.Windows.Forms.DateTimePicker dtInicioConsultarPorDataOcupantes;
        private System.Windows.Forms.MaskedTextBox txtReqOcupanteConsulta;
        private System.Windows.Forms.Label lblCPFOcupanteConsulta;
        private System.Windows.Forms.MaskedTextBox txtCPFOcupanteConsulta;
        private System.Windows.Forms.ToolTip toolTipTransfere;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.TextBox textPesquisar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.ToolTip tooltipPesquisar;
        private System.Windows.Forms.PictureBox pbpermissao;
        private System.Windows.Forms.ToolTip toolTipPermissao;
    }
}