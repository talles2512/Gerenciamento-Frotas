namespace CamadaDesktop
{
    partial class Manutencoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manutencoes));
            this.tbControlManunt = new System.Windows.Forms.TabControl();
            this.tbPageCadastroManunt = new System.Windows.Forms.TabPage();
            this.gbDadosManunt = new System.Windows.Forms.GroupBox();
            this.pbpermissao = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.cbServicoExterno = new System.Windows.Forms.ComboBox();
            this.lblServicoExterno = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtDataManunt = new System.Windows.Forms.DateTimePicker();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnExcluirManunt = new System.Windows.Forms.Button();
            this.btnAlterarManunt = new System.Windows.Forms.Button();
            this.btnCadastrarManunt = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.tbPageConsultaManunt = new System.Windows.Forms.TabPage();
            this.gbConsultaManunt = new System.Windows.Forms.GroupBox();
            this.panelConsultarPorData = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnConsultarPorData = new System.Windows.Forms.Button();
            this.lblFimConsulta = new System.Windows.Forms.Label();
            this.lblInicioConsulta = new System.Windows.Forms.Label();
            this.dtFimConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.cbPlacaConsulta = new System.Windows.Forms.ComboBox();
            this.lblDataManuntConsulta = new System.Windows.Forms.Label();
            this.dtDataManuntConsulta = new System.Windows.Forms.DateTimePicker();
            this.cbTipoManuntConsulta = new System.Windows.Forms.ComboBox();
            this.lblTipoManuntConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirManunt = new System.Windows.Forms.Button();
            this.dgVeiculoManunt = new System.Windows.Forms.DataGridView();
            this.btnTodosManunt = new System.Windows.Forms.Button();
            this.btnConsultarManunt = new System.Windows.Forms.Button();
            this.lblPlacaConsulta = new System.Windows.Forms.Label();
            this.toolTipTransfere = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPermissao = new System.Windows.Forms.ToolTip(this.components);
            this.tbControlManunt.SuspendLayout();
            this.tbPageCadastroManunt.SuspendLayout();
            this.gbDadosManunt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).BeginInit();
            this.tbPageConsultaManunt.SuspendLayout();
            this.gbConsultaManunt.SuspendLayout();
            this.panelConsultarPorData.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculoManunt)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlManunt
            // 
            this.tbControlManunt.Controls.Add(this.tbPageCadastroManunt);
            this.tbControlManunt.Controls.Add(this.tbPageConsultaManunt);
            this.tbControlManunt.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlManunt.Location = new System.Drawing.Point(1, 24);
            this.tbControlManunt.Name = "tbControlManunt";
            this.tbControlManunt.SelectedIndex = 0;
            this.tbControlManunt.Size = new System.Drawing.Size(644, 498);
            this.tbControlManunt.TabIndex = 23;
            // 
            // tbPageCadastroManunt
            // 
            this.tbPageCadastroManunt.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroManunt.Controls.Add(this.gbDadosManunt);
            this.tbPageCadastroManunt.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroManunt.Name = "tbPageCadastroManunt";
            this.tbPageCadastroManunt.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroManunt.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroManunt.TabIndex = 0;
            this.tbPageCadastroManunt.Text = "Cadastrar";
            // 
            // gbDadosManunt
            // 
            this.gbDadosManunt.Controls.Add(this.pbpermissao);
            this.gbDadosManunt.Controls.Add(this.lblCancelar);
            this.gbDadosManunt.Controls.Add(this.cbSituacao);
            this.gbDadosManunt.Controls.Add(this.lblSituacao);
            this.gbDadosManunt.Controls.Add(this.txtDescricao);
            this.gbDadosManunt.Controls.Add(this.lblDesc);
            this.gbDadosManunt.Controls.Add(this.cbPlaca);
            this.gbDadosManunt.Controls.Add(this.cbServicoExterno);
            this.gbDadosManunt.Controls.Add(this.lblServicoExterno);
            this.gbDadosManunt.Controls.Add(this.txtValor);
            this.gbDadosManunt.Controls.Add(this.lblValor);
            this.gbDadosManunt.Controls.Add(this.lblData);
            this.gbDadosManunt.Controls.Add(this.dtDataManunt);
            this.gbDadosManunt.Controls.Add(this.cbTipo);
            this.gbDadosManunt.Controls.Add(this.lblTipo);
            this.gbDadosManunt.Controls.Add(this.btnExcluirManunt);
            this.gbDadosManunt.Controls.Add(this.btnAlterarManunt);
            this.gbDadosManunt.Controls.Add(this.btnCadastrarManunt);
            this.gbDadosManunt.Controls.Add(this.lblPlaca);
            this.gbDadosManunt.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosManunt.Location = new System.Drawing.Point(6, 6);
            this.gbDadosManunt.Name = "gbDadosManunt";
            this.gbDadosManunt.Size = new System.Drawing.Size(621, 448);
            this.gbDadosManunt.TabIndex = 1;
            this.gbDadosManunt.TabStop = false;
            this.gbDadosManunt.Text = "Dados";
            // 
            // pbpermissao
            // 
            this.pbpermissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbpermissao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbpermissao.Image = ((System.Drawing.Image)(resources.GetObject("pbpermissao.Image")));
            this.pbpermissao.Location = new System.Drawing.Point(396, 401);
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
            this.lblCancelar.Location = new System.Drawing.Point(267, 313);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(89, 32);
            this.lblCancelar.TabIndex = 47;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Visible = false;
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // cbSituacao
            // 
            this.cbSituacao.Location = new System.Drawing.Point(387, 245);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(121, 33);
            this.cbSituacao.TabIndex = 20;
            // 
            // lblSituacao
            // 
            this.lblSituacao.Location = new System.Drawing.Point(382, 219);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(100, 23);
            this.lblSituacao.TabIndex = 1;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(11, 245);
            this.txtDescricao.MaxLength = 250;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(370, 58);
            this.txtDescricao.TabIndex = 19;
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(6, 219);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(100, 23);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Descrição:";
            // 
            // cbPlaca
            // 
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(214, 119);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(197, 33);
            this.cbPlaca.TabIndex = 17;
            // 
            // cbServicoExterno
            // 
            this.cbServicoExterno.FormattingEnabled = true;
            this.cbServicoExterno.Location = new System.Drawing.Point(11, 183);
            this.cbServicoExterno.Name = "cbServicoExterno";
            this.cbServicoExterno.Size = new System.Drawing.Size(400, 33);
            this.cbServicoExterno.TabIndex = 18;
            // 
            // lblServicoExterno
            // 
            this.lblServicoExterno.AutoSize = true;
            this.lblServicoExterno.Location = new System.Drawing.Point(6, 155);
            this.lblServicoExterno.Name = "lblServicoExterno";
            this.lblServicoExterno.Size = new System.Drawing.Size(54, 25);
            this.lblServicoExterno.TabIndex = 28;
            this.lblServicoExterno.Text = "Oficina:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(11, 120);
            this.txtValor.Mask = "000000000";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(197, 32);
            this.txtValor.TabIndex = 16;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 92);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 25);
            this.lblValor.TabIndex = 26;
            this.lblValor.Text = "Valor:";
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
            this.dtDataManunt.TabIndex = 15;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(11, 56);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(197, 33);
            this.cbTipo.TabIndex = 14;
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
            // btnExcluirManunt
            // 
            this.btnExcluirManunt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirManunt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirManunt.Enabled = false;
            this.btnExcluirManunt.FlatAppearance.BorderSize = 0;
            this.btnExcluirManunt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirManunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirManunt.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirManunt.ForeColor = System.Drawing.Color.White;
            this.btnExcluirManunt.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirManunt.Image")));
            this.btnExcluirManunt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirManunt.Location = new System.Drawing.Point(244, 401);
            this.btnExcluirManunt.Name = "btnExcluirManunt";
            this.btnExcluirManunt.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirManunt.TabIndex = 23;
            this.btnExcluirManunt.Text = "Excluir";
            this.btnExcluirManunt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirManunt.UseVisualStyleBackColor = false;
            this.btnExcluirManunt.Click += new System.EventHandler(this.BtnExcluirManunt_Click);
            // 
            // btnAlterarManunt
            // 
            this.btnAlterarManunt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarManunt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarManunt.Enabled = false;
            this.btnAlterarManunt.FlatAppearance.BorderSize = 0;
            this.btnAlterarManunt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarManunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarManunt.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarManunt.ForeColor = System.Drawing.Color.White;
            this.btnAlterarManunt.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarManunt.Image")));
            this.btnAlterarManunt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarManunt.Location = new System.Drawing.Point(244, 355);
            this.btnAlterarManunt.Name = "btnAlterarManunt";
            this.btnAlterarManunt.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarManunt.TabIndex = 22;
            this.btnAlterarManunt.Text = "Alterar";
            this.btnAlterarManunt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarManunt.UseVisualStyleBackColor = false;
            this.btnAlterarManunt.Click += new System.EventHandler(this.BtnAlterarManunt_Click);
            // 
            // btnCadastrarManunt
            // 
            this.btnCadastrarManunt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarManunt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarManunt.FlatAppearance.BorderSize = 0;
            this.btnCadastrarManunt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarManunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarManunt.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarManunt.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarManunt.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarManunt.Image")));
            this.btnCadastrarManunt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarManunt.Location = new System.Drawing.Point(119, 309);
            this.btnCadastrarManunt.Name = "btnCadastrarManunt";
            this.btnCadastrarManunt.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarManunt.TabIndex = 21;
            this.btnCadastrarManunt.Text = "Cadastrar";
            this.btnCadastrarManunt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarManunt.UseVisualStyleBackColor = false;
            this.btnCadastrarManunt.Click += new System.EventHandler(this.BtnCadastrarManunt_Click);
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
            // tbPageConsultaManunt
            // 
            this.tbPageConsultaManunt.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaManunt.Controls.Add(this.gbConsultaManunt);
            this.tbPageConsultaManunt.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaManunt.Name = "tbPageConsultaManunt";
            this.tbPageConsultaManunt.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaManunt.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaManunt.TabIndex = 1;
            this.tbPageConsultaManunt.Text = "Consultar";
            // 
            // gbConsultaManunt
            // 
            this.gbConsultaManunt.Controls.Add(this.panelConsultarPorData);
            this.gbConsultaManunt.Controls.Add(this.cbPlacaConsulta);
            this.gbConsultaManunt.Controls.Add(this.lblDataManuntConsulta);
            this.gbConsultaManunt.Controls.Add(this.dtDataManuntConsulta);
            this.gbConsultaManunt.Controls.Add(this.cbTipoManuntConsulta);
            this.gbConsultaManunt.Controls.Add(this.lblTipoManuntConsulta);
            this.gbConsultaManunt.Controls.Add(this.btnTrasferirManunt);
            this.gbConsultaManunt.Controls.Add(this.dgVeiculoManunt);
            this.gbConsultaManunt.Controls.Add(this.btnTodosManunt);
            this.gbConsultaManunt.Controls.Add(this.btnConsultarManunt);
            this.gbConsultaManunt.Controls.Add(this.lblPlacaConsulta);
            this.gbConsultaManunt.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaManunt.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaManunt.Name = "gbConsultaManunt";
            this.gbConsultaManunt.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaManunt.TabIndex = 2;
            this.gbConsultaManunt.TabStop = false;
            this.gbConsultaManunt.Text = "Consulta";
            // 
            // panelConsultarPorData
            // 
            this.panelConsultarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelConsultarPorData.Controls.Add(this.gbData);
            this.panelConsultarPorData.Location = new System.Drawing.Point(394, 70);
            this.panelConsultarPorData.Name = "panelConsultarPorData";
            this.panelConsultarPorData.Size = new System.Drawing.Size(177, 213);
            this.panelConsultarPorData.TabIndex = 43;
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
            // cbPlacaConsulta
            // 
            this.cbPlacaConsulta.FormattingEnabled = true;
            this.cbPlacaConsulta.Location = new System.Drawing.Point(328, 30);
            this.cbPlacaConsulta.Name = "cbPlacaConsulta";
            this.cbPlacaConsulta.Size = new System.Drawing.Size(197, 33);
            this.cbPlacaConsulta.TabIndex = 15;
            // 
            // lblDataManuntConsulta
            // 
            this.lblDataManuntConsulta.AutoSize = true;
            this.lblDataManuntConsulta.Location = new System.Drawing.Point(6, 73);
            this.lblDataManuntConsulta.Name = "lblDataManuntConsulta";
            this.lblDataManuntConsulta.Size = new System.Drawing.Size(42, 25);
            this.lblDataManuntConsulta.TabIndex = 29;
            this.lblDataManuntConsulta.Text = "Data:";
            // 
            // dtDataManuntConsulta
            // 
            this.dtDataManuntConsulta.CustomFormat = "dd/mm/yyyy";
            this.dtDataManuntConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataManuntConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataManuntConsulta.Location = new System.Drawing.Point(50, 70);
            this.dtDataManuntConsulta.Name = "dtDataManuntConsulta";
            this.dtDataManuntConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataManuntConsulta.Size = new System.Drawing.Size(162, 31);
            this.dtDataManuntConsulta.TabIndex = 16;
            // 
            // cbTipoManuntConsulta
            // 
            this.cbTipoManuntConsulta.FormattingEnabled = true;
            this.cbTipoManuntConsulta.Location = new System.Drawing.Point(50, 31);
            this.cbTipoManuntConsulta.Name = "cbTipoManuntConsulta";
            this.cbTipoManuntConsulta.Size = new System.Drawing.Size(162, 33);
            this.cbTipoManuntConsulta.TabIndex = 14;
            // 
            // lblTipoManuntConsulta
            // 
            this.lblTipoManuntConsulta.AutoSize = true;
            this.lblTipoManuntConsulta.Location = new System.Drawing.Point(6, 34);
            this.lblTipoManuntConsulta.Name = "lblTipoManuntConsulta";
            this.lblTipoManuntConsulta.Size = new System.Drawing.Size(38, 25);
            this.lblTipoManuntConsulta.TabIndex = 26;
            this.lblTipoManuntConsulta.Text = "Tipo:";
            // 
            // btnTrasferirManunt
            // 
            this.btnTrasferirManunt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirManunt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirManunt.BackgroundImage")));
            this.btnTrasferirManunt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirManunt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrasferirManunt.FlatAppearance.BorderSize = 0;
            this.btnTrasferirManunt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirManunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirManunt.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirManunt.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirManunt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirManunt.Location = new System.Drawing.Point(577, 70);
            this.btnTrasferirManunt.Name = "btnTrasferirManunt";
            this.btnTrasferirManunt.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirManunt.TabIndex = 19;
            this.btnTrasferirManunt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirManunt.UseVisualStyleBackColor = false;
            this.btnTrasferirManunt.Click += new System.EventHandler(this.BtnTrasferirManunt_Click);
            // 
            // dgVeiculoManunt
            // 
            this.dgVeiculoManunt.BackgroundColor = System.Drawing.Color.White;
            this.dgVeiculoManunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeiculoManunt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgVeiculoManunt.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgVeiculoManunt.Location = new System.Drawing.Point(7, 116);
            this.dgVeiculoManunt.Name = "dgVeiculoManunt";
            this.dgVeiculoManunt.ReadOnly = true;
            this.dgVeiculoManunt.Size = new System.Drawing.Size(608, 323);
            this.dgVeiculoManunt.TabIndex = 20;
            this.dgVeiculoManunt.DoubleClick += new System.EventHandler(this.dgVeiculoManunt_DoubleClick);
            // 
            // btnTodosManunt
            // 
            this.btnTodosManunt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosManunt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosManunt.FlatAppearance.BorderSize = 0;
            this.btnTodosManunt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosManunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosManunt.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosManunt.ForeColor = System.Drawing.Color.White;
            this.btnTodosManunt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosManunt.Location = new System.Drawing.Point(394, 69);
            this.btnTodosManunt.Name = "btnTodosManunt";
            this.btnTodosManunt.Size = new System.Drawing.Size(177, 40);
            this.btnTodosManunt.TabIndex = 18;
            this.btnTodosManunt.Text = "Consultar p/ Data";
            this.btnTodosManunt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosManunt.UseVisualStyleBackColor = false;
            this.btnTodosManunt.Click += new System.EventHandler(this.BtnTodosManunt_Click);
            // 
            // btnConsultarManunt
            // 
            this.btnConsultarManunt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarManunt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarManunt.FlatAppearance.BorderSize = 0;
            this.btnConsultarManunt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarManunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarManunt.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarManunt.ForeColor = System.Drawing.Color.White;
            this.btnConsultarManunt.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarManunt.Image")));
            this.btnConsultarManunt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarManunt.Location = new System.Drawing.Point(242, 69);
            this.btnConsultarManunt.Name = "btnConsultarManunt";
            this.btnConsultarManunt.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarManunt.TabIndex = 17;
            this.btnConsultarManunt.Text = "    Consultar";
            this.btnConsultarManunt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarManunt.UseVisualStyleBackColor = false;
            this.btnConsultarManunt.Click += new System.EventHandler(this.BtnConsultarManunt_Click);
            // 
            // lblPlacaConsulta
            // 
            this.lblPlacaConsulta.AutoSize = true;
            this.lblPlacaConsulta.Location = new System.Drawing.Point(218, 34);
            this.lblPlacaConsulta.Name = "lblPlacaConsulta";
            this.lblPlacaConsulta.Size = new System.Drawing.Size(104, 25);
            this.lblPlacaConsulta.TabIndex = 17;
            this.lblPlacaConsulta.Text = "Veículo - Placa:";
            // 
            // Manutencoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlManunt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manutencoes";
            this.Text = "Manutencao";
            this.Load += new System.EventHandler(this.Manutencoes_Load);
            this.tbControlManunt.ResumeLayout(false);
            this.tbPageCadastroManunt.ResumeLayout(false);
            this.gbDadosManunt.ResumeLayout(false);
            this.gbDadosManunt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).EndInit();
            this.tbPageConsultaManunt.ResumeLayout(false);
            this.gbConsultaManunt.ResumeLayout(false);
            this.gbConsultaManunt.PerformLayout();
            this.panelConsultarPorData.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculoManunt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlManunt;
        private System.Windows.Forms.TabPage tbPageCadastroManunt;
        private System.Windows.Forms.GroupBox gbDadosManunt;
        private System.Windows.Forms.Button btnExcluirManunt;
        private System.Windows.Forms.Button btnAlterarManunt;
        private System.Windows.Forms.Button btnCadastrarManunt;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TabPage tbPageConsultaManunt;
        private System.Windows.Forms.GroupBox gbConsultaManunt;
        private System.Windows.Forms.Button btnTrasferirManunt;
        private System.Windows.Forms.DataGridView dgVeiculoManunt;
        private System.Windows.Forms.Button btnTodosManunt;
        private System.Windows.Forms.Button btnConsultarManunt;
        private System.Windows.Forms.Label lblPlacaConsulta;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbServicoExterno;
        private System.Windows.Forms.Label lblServicoExterno;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtDataManunt;
        private System.Windows.Forms.Label lblDataManuntConsulta;
        private System.Windows.Forms.DateTimePicker dtDataManuntConsulta;
        private System.Windows.Forms.ComboBox cbTipoManuntConsulta;
        private System.Windows.Forms.Label lblTipoManuntConsulta;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.ComboBox cbPlacaConsulta;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Panel panelConsultarPorData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnConsultarPorData;
        private System.Windows.Forms.Label lblFimConsulta;
        private System.Windows.Forms.Label lblInicioConsulta;
        private System.Windows.Forms.DateTimePicker dtFimConsulta;
        private System.Windows.Forms.DateTimePicker dtInicioConsulta;
        private System.Windows.Forms.ToolTip toolTipTransfere;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.PictureBox pbpermissao;
        private System.Windows.Forms.ToolTip toolTipPermissao;
    }
}