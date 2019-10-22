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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viagens));
            this.tbControlViagens = new System.Windows.Forms.TabControl();
            this.tbPageCadastroViagem = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDadosViagens = new System.Windows.Forms.GroupBox();
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
            this.btnTrasferirViagens = new System.Windows.Forms.Button();
            this.dgViagensConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodasViagens = new System.Windows.Forms.Button();
            this.btnConsultarViagens = new System.Windows.Forms.Button();
            this.txtRequisicaoConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblreqConsulta = new System.Windows.Forms.Label();
            this.tbPageControlOcupantes = new System.Windows.Forms.TabPage();
            this.gbConsultaExame = new System.Windows.Forms.GroupBox();
            this.txtCPFOcupantesConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFOcupantesConsulta = new System.Windows.Forms.Label();
            this.dgExameConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsultaTodosExame = new System.Windows.Forms.Button();
            this.btnConsultaExame = new System.Windows.Forms.Button();
            this.tbControlViagens.SuspendLayout();
            this.tbPageCadastroViagem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDadosViagens.SuspendLayout();
            this.gbOcupante.SuspendLayout();
            this.tbPageConsultaViagens.SuspendLayout();
            this.gbConsultaViagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViagensConsulta)).BeginInit();
            this.tbPageControlOcupantes.SuspendLayout();
            this.gbConsultaExame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExameConsulta)).BeginInit();
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
            // cbCPF
            // 
            this.cbCPF.FormattingEnabled = true;
            this.cbCPF.Location = new System.Drawing.Point(214, 118);
            this.cbCPF.Name = "cbCPF";
            this.cbCPF.Size = new System.Drawing.Size(197, 33);
            this.cbCPF.TabIndex = 17;
            // 
            // cbPlaca
            // 
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(11, 118);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(197, 33);
            this.cbPlaca.TabIndex = 16;
            // 
            // rdsemOcupante
            // 
            this.rdsemOcupante.AutoSize = true;
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
            this.rdOcupante.TabStop = true;
            this.rdOcupante.Text = "Com Ocupante";
            this.rdOcupante.UseVisualStyleBackColor = true;
            this.rdOcupante.CheckedChanged += new System.EventHandler(this.rdOcupante_CheckedChanged_1);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(209, 91);
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
            // 
            // btnAlterarViagens
            // 
            this.btnAlterarViagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
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
            // 
            // btnCadastrarViagens
            // 
            this.btnCadastrarViagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
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
            // btnTrasferirViagens
            // 
            this.btnTrasferirViagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirViagens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirViagens.BackgroundImage")));
            this.btnTrasferirViagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            // 
            // dgViagensConsulta
            // 
            this.dgViagensConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgViagensConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViagensConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgViagensConsulta.Location = new System.Drawing.Point(7, 68);
            this.dgViagensConsulta.Name = "dgViagensConsulta";
            this.dgViagensConsulta.Size = new System.Drawing.Size(608, 433);
            this.dgViagensConsulta.TabIndex = 18;
            // 
            // btnTodasViagens
            // 
            this.btnTodasViagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodasViagens.FlatAppearance.BorderSize = 0;
            this.btnTodasViagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodasViagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodasViagens.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodasViagens.ForeColor = System.Drawing.Color.White;
            this.btnTodasViagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodasViagens.Location = new System.Drawing.Point(415, 25);
            this.btnTodasViagens.Name = "btnTodasViagens";
            this.btnTodasViagens.Size = new System.Drawing.Size(159, 40);
            this.btnTodasViagens.TabIndex = 16;
            this.btnTodasViagens.Text = "Consultar Todos";
            this.btnTodasViagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodasViagens.UseVisualStyleBackColor = false;
            this.btnTodasViagens.Click += new System.EventHandler(this.BtnTodasViagens_Click);
            // 
            // btnConsultarViagens
            // 
            this.btnConsultarViagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarViagens.FlatAppearance.BorderSize = 0;
            this.btnConsultarViagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarViagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarViagens.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarViagens.ForeColor = System.Drawing.Color.White;
            this.btnConsultarViagens.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarViagens.Image")));
            this.btnConsultarViagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarViagens.Location = new System.Drawing.Point(263, 24);
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
            this.txtRequisicaoConsulta.Size = new System.Drawing.Size(171, 32);
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
            this.tbPageControlOcupantes.Controls.Add(this.gbConsultaExame);
            this.tbPageControlOcupantes.Location = new System.Drawing.Point(4, 37);
            this.tbPageControlOcupantes.Name = "tbPageControlOcupantes";
            this.tbPageControlOcupantes.Size = new System.Drawing.Size(636, 523);
            this.tbPageControlOcupantes.TabIndex = 2;
            this.tbPageControlOcupantes.Text = "Ocupantes";
            // 
            // gbConsultaExame
            // 
            this.gbConsultaExame.Controls.Add(this.txtCPFOcupantesConsulta);
            this.gbConsultaExame.Controls.Add(this.lblCPFOcupantesConsulta);
            this.gbConsultaExame.Controls.Add(this.dgExameConsulta);
            this.gbConsultaExame.Controls.Add(this.btnConsultaTodosExame);
            this.gbConsultaExame.Controls.Add(this.btnConsultaExame);
            this.gbConsultaExame.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaExame.Location = new System.Drawing.Point(6, 6);
            this.gbConsultaExame.Name = "gbConsultaExame";
            this.gbConsultaExame.Size = new System.Drawing.Size(621, 514);
            this.gbConsultaExame.TabIndex = 26;
            this.gbConsultaExame.TabStop = false;
            this.gbConsultaExame.Text = "Consulta";
            // 
            // txtCPFOcupantesConsulta
            // 
            this.txtCPFOcupantesConsulta.Location = new System.Drawing.Point(53, 33);
            this.txtCPFOcupantesConsulta.Mask = "000.000.000-00";
            this.txtCPFOcupantesConsulta.Name = "txtCPFOcupantesConsulta";
            this.txtCPFOcupantesConsulta.Size = new System.Drawing.Size(188, 32);
            this.txtCPFOcupantesConsulta.TabIndex = 19;
            // 
            // lblCPFOcupantesConsulta
            // 
            this.lblCPFOcupantesConsulta.AutoSize = true;
            this.lblCPFOcupantesConsulta.Location = new System.Drawing.Point(6, 36);
            this.lblCPFOcupantesConsulta.Name = "lblCPFOcupantesConsulta";
            this.lblCPFOcupantesConsulta.Size = new System.Drawing.Size(41, 25);
            this.lblCPFOcupantesConsulta.TabIndex = 26;
            this.lblCPFOcupantesConsulta.Text = "CPF:";
            // 
            // dgExameConsulta
            // 
            this.dgExameConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgExameConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExameConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgExameConsulta.Location = new System.Drawing.Point(7, 71);
            this.dgExameConsulta.Name = "dgExameConsulta";
            this.dgExameConsulta.Size = new System.Drawing.Size(608, 437);
            this.dgExameConsulta.TabIndex = 23;
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
            this.btnConsultaTodosExame.Location = new System.Drawing.Point(456, 27);
            this.btnConsultaTodosExame.Name = "btnConsultaTodosExame";
            this.btnConsultaTodosExame.Size = new System.Drawing.Size(159, 40);
            this.btnConsultaTodosExame.TabIndex = 21;
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
            this.btnConsultaExame.Location = new System.Drawing.Point(291, 27);
            this.btnConsultaExame.Name = "btnConsultaExame";
            this.btnConsultaExame.Size = new System.Drawing.Size(159, 40);
            this.btnConsultaExame.TabIndex = 20;
            this.btnConsultaExame.Text = "    Consultar";
            this.btnConsultaExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultaExame.UseVisualStyleBackColor = false;
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
            this.gbOcupante.ResumeLayout(false);
            this.gbOcupante.PerformLayout();
            this.tbPageConsultaViagens.ResumeLayout(false);
            this.gbConsultaViagens.ResumeLayout(false);
            this.gbConsultaViagens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViagensConsulta)).EndInit();
            this.tbPageControlOcupantes.ResumeLayout(false);
            this.gbConsultaExame.ResumeLayout(false);
            this.gbConsultaExame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExameConsulta)).EndInit();
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
        private System.Windows.Forms.GroupBox gbConsultaExame;
        private System.Windows.Forms.MaskedTextBox txtCPFOcupantesConsulta;
        private System.Windows.Forms.Label lblCPFOcupantesConsulta;
        private System.Windows.Forms.DataGridView dgExameConsulta;
        private System.Windows.Forms.Button btnConsultaTodosExame;
        private System.Windows.Forms.Button btnConsultaExame;
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
    }
}