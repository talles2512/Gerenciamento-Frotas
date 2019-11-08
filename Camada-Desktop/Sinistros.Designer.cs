namespace CamadaDesktop
{
    partial class Sinistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sinistros));
            this.tbControlSinistros = new System.Windows.Forms.TabControl();
            this.tbPageCadastroSinistros = new System.Windows.Forms.TabPage();
            this.gbDadosSinistros = new System.Windows.Forms.GroupBox();
            this.pbpermissao = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.cbSeguro = new System.Windows.Forms.ComboBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.cbItemSegurado = new System.Windows.Forms.ComboBox();
            this.lblItemSegurado = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtDataSinistro = new System.Windows.Forms.DateTimePicker();
            this.btnExcluirSinistros = new System.Windows.Forms.Button();
            this.btnAlterarSinistros = new System.Windows.Forms.Button();
            this.btnCadastrarSinistros = new System.Windows.Forms.Button();
            this.tbPageConsultaSinistros = new System.Windows.Forms.TabPage();
            this.gbConsultaSinistros = new System.Windows.Forms.GroupBox();
            this.panelConsultarPorData = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnConsultarPorData = new System.Windows.Forms.Button();
            this.lblFimConsulta = new System.Windows.Forms.Label();
            this.lblInicioConsulta = new System.Windows.Forms.Label();
            this.dtFimConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtDataSinistroConsulta = new System.Windows.Forms.DateTimePicker();
            this.cbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.lblTipoConsulta = new System.Windows.Forms.Label();
            this.txtIDSinistrosConsulta = new System.Windows.Forms.TextBox();
            this.lblIDSinistrosConsulta = new System.Windows.Forms.Label();
            this.lblDataSinistrosConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirSinistros = new System.Windows.Forms.Button();
            this.dgSinistrosConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosSinistros = new System.Windows.Forms.Button();
            this.btnConsultarSinistros = new System.Windows.Forms.Button();
            this.toolTipTransfere = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPermissao = new System.Windows.Forms.ToolTip(this.components);
            this.tbControlSinistros.SuspendLayout();
            this.tbPageCadastroSinistros.SuspendLayout();
            this.gbDadosSinistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).BeginInit();
            this.tbPageConsultaSinistros.SuspendLayout();
            this.gbConsultaSinistros.SuspendLayout();
            this.panelConsultarPorData.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSinistrosConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlSinistros
            // 
            this.tbControlSinistros.Controls.Add(this.tbPageCadastroSinistros);
            this.tbControlSinistros.Controls.Add(this.tbPageConsultaSinistros);
            this.tbControlSinistros.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlSinistros.Location = new System.Drawing.Point(1, 24);
            this.tbControlSinistros.Name = "tbControlSinistros";
            this.tbControlSinistros.SelectedIndex = 0;
            this.tbControlSinistros.Size = new System.Drawing.Size(644, 498);
            this.tbControlSinistros.TabIndex = 23;
            // 
            // tbPageCadastroSinistros
            // 
            this.tbPageCadastroSinistros.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroSinistros.Controls.Add(this.gbDadosSinistros);
            this.tbPageCadastroSinistros.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroSinistros.Name = "tbPageCadastroSinistros";
            this.tbPageCadastroSinistros.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroSinistros.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroSinistros.TabIndex = 0;
            this.tbPageCadastroSinistros.Text = "Cadastrar";
            // 
            // gbDadosSinistros
            // 
            this.gbDadosSinistros.Controls.Add(this.pbpermissao);
            this.gbDadosSinistros.Controls.Add(this.lblCancelar);
            this.gbDadosSinistros.Controls.Add(this.cbTipo);
            this.gbDadosSinistros.Controls.Add(this.lblTipo);
            this.gbDadosSinistros.Controls.Add(this.txtid);
            this.gbDadosSinistros.Controls.Add(this.lblIdentificador);
            this.gbDadosSinistros.Controls.Add(this.cbSeguro);
            this.gbDadosSinistros.Controls.Add(this.lblSeguro);
            this.gbDadosSinistros.Controls.Add(this.cbItemSegurado);
            this.gbDadosSinistros.Controls.Add(this.lblItemSegurado);
            this.gbDadosSinistros.Controls.Add(this.txtDesc);
            this.gbDadosSinistros.Controls.Add(this.lblDesc);
            this.gbDadosSinistros.Controls.Add(this.lblData);
            this.gbDadosSinistros.Controls.Add(this.dtDataSinistro);
            this.gbDadosSinistros.Controls.Add(this.btnExcluirSinistros);
            this.gbDadosSinistros.Controls.Add(this.btnAlterarSinistros);
            this.gbDadosSinistros.Controls.Add(this.btnCadastrarSinistros);
            this.gbDadosSinistros.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosSinistros.Location = new System.Drawing.Point(6, 6);
            this.gbDadosSinistros.Name = "gbDadosSinistros";
            this.gbDadosSinistros.Size = new System.Drawing.Size(621, 445);
            this.gbDadosSinistros.TabIndex = 1;
            this.gbDadosSinistros.TabStop = false;
            this.gbDadosSinistros.Text = "Dados";
            // 
            // pbpermissao
            // 
            this.pbpermissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbpermissao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbpermissao.Image = ((System.Drawing.Image)(resources.GetObject("pbpermissao.Image")));
            this.pbpermissao.Location = new System.Drawing.Point(396, 399);
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
            this.lblCancelar.Location = new System.Drawing.Point(272, 311);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(89, 32);
            this.lblCancelar.TabIndex = 64;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Visible = false;
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(157, 56);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(197, 33);
            this.cbTipo.TabIndex = 15;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(152, 28);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 25);
            this.lblTipo.TabIndex = 63;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(11, 56);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(140, 32);
            this.txtid.TabIndex = 14;
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(6, 28);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(87, 25);
            this.lblIdentificador.TabIndex = 37;
            this.lblIdentificador.Text = "Identificador:";
            // 
            // cbSeguro
            // 
            this.cbSeguro.FormattingEnabled = true;
            this.cbSeguro.Location = new System.Drawing.Point(11, 117);
            this.cbSeguro.Name = "cbSeguro";
            this.cbSeguro.Size = new System.Drawing.Size(255, 33);
            this.cbSeguro.TabIndex = 17;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Location = new System.Drawing.Point(6, 89);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(58, 25);
            this.lblSeguro.TabIndex = 35;
            this.lblSeguro.Text = "Seguro:";
            // 
            // cbItemSegurado
            // 
            this.cbItemSegurado.FormattingEnabled = true;
            this.cbItemSegurado.Location = new System.Drawing.Point(360, 56);
            this.cbItemSegurado.Name = "cbItemSegurado";
            this.cbItemSegurado.Size = new System.Drawing.Size(255, 33);
            this.cbItemSegurado.TabIndex = 16;
            this.cbItemSegurado.SelectedIndexChanged += new System.EventHandler(this.cbItemSegurado_SelectedIndexChanged);
            // 
            // lblItemSegurado
            // 
            this.lblItemSegurado.AutoSize = true;
            this.lblItemSegurado.Location = new System.Drawing.Point(355, 28);
            this.lblItemSegurado.Name = "lblItemSegurado";
            this.lblItemSegurado.Size = new System.Drawing.Size(102, 25);
            this.lblItemSegurado.TabIndex = 33;
            this.lblItemSegurado.Text = "Item Segurado:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(11, 181);
            this.txtDesc.MaxLength = 250;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(487, 85);
            this.txtDesc.TabIndex = 19;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 153);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 25);
            this.lblDesc.TabIndex = 31;
            this.lblDesc.Text = "Descrição:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(267, 89);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 25);
            this.lblData.TabIndex = 27;
            this.lblData.Text = "Data:";
            // 
            // dtDataSinistro
            // 
            this.dtDataSinistro.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtDataSinistro.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataSinistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataSinistro.Location = new System.Drawing.Point(272, 117);
            this.dtDataSinistro.Name = "dtDataSinistro";
            this.dtDataSinistro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataSinistro.Size = new System.Drawing.Size(226, 31);
            this.dtDataSinistro.TabIndex = 18;
            // 
            // btnExcluirSinistros
            // 
            this.btnExcluirSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirSinistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirSinistros.Enabled = false;
            this.btnExcluirSinistros.FlatAppearance.BorderSize = 0;
            this.btnExcluirSinistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirSinistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirSinistros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirSinistros.ForeColor = System.Drawing.Color.White;
            this.btnExcluirSinistros.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirSinistros.Image")));
            this.btnExcluirSinistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirSinistros.Location = new System.Drawing.Point(244, 399);
            this.btnExcluirSinistros.Name = "btnExcluirSinistros";
            this.btnExcluirSinistros.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirSinistros.TabIndex = 22;
            this.btnExcluirSinistros.Text = "Excluir";
            this.btnExcluirSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirSinistros.UseVisualStyleBackColor = false;
            this.btnExcluirSinistros.Click += new System.EventHandler(this.btnExcluirSinistros_Click);
            // 
            // btnAlterarSinistros
            // 
            this.btnAlterarSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarSinistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarSinistros.Enabled = false;
            this.btnAlterarSinistros.FlatAppearance.BorderSize = 0;
            this.btnAlterarSinistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarSinistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSinistros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSinistros.ForeColor = System.Drawing.Color.White;
            this.btnAlterarSinistros.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarSinistros.Image")));
            this.btnAlterarSinistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarSinistros.Location = new System.Drawing.Point(244, 353);
            this.btnAlterarSinistros.Name = "btnAlterarSinistros";
            this.btnAlterarSinistros.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarSinistros.TabIndex = 21;
            this.btnAlterarSinistros.Text = "Alterar";
            this.btnAlterarSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarSinistros.UseVisualStyleBackColor = false;
            this.btnAlterarSinistros.Click += new System.EventHandler(this.btnAlterarSinistros_Click);
            // 
            // btnCadastrarSinistros
            // 
            this.btnCadastrarSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarSinistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarSinistros.FlatAppearance.BorderSize = 0;
            this.btnCadastrarSinistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarSinistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSinistros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSinistros.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarSinistros.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarSinistros.Image")));
            this.btnCadastrarSinistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarSinistros.Location = new System.Drawing.Point(120, 307);
            this.btnCadastrarSinistros.Name = "btnCadastrarSinistros";
            this.btnCadastrarSinistros.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarSinistros.TabIndex = 20;
            this.btnCadastrarSinistros.Text = "Cadastrar";
            this.btnCadastrarSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarSinistros.UseVisualStyleBackColor = false;
            this.btnCadastrarSinistros.Click += new System.EventHandler(this.btnCadastrarSinistros_Click);
            // 
            // tbPageConsultaSinistros
            // 
            this.tbPageConsultaSinistros.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaSinistros.Controls.Add(this.gbConsultaSinistros);
            this.tbPageConsultaSinistros.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaSinistros.Name = "tbPageConsultaSinistros";
            this.tbPageConsultaSinistros.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaSinistros.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaSinistros.TabIndex = 1;
            this.tbPageConsultaSinistros.Text = "Consultar";
            // 
            // gbConsultaSinistros
            // 
            this.gbConsultaSinistros.Controls.Add(this.panelConsultarPorData);
            this.gbConsultaSinistros.Controls.Add(this.dtDataSinistroConsulta);
            this.gbConsultaSinistros.Controls.Add(this.cbTipoConsulta);
            this.gbConsultaSinistros.Controls.Add(this.lblTipoConsulta);
            this.gbConsultaSinistros.Controls.Add(this.txtIDSinistrosConsulta);
            this.gbConsultaSinistros.Controls.Add(this.lblIDSinistrosConsulta);
            this.gbConsultaSinistros.Controls.Add(this.lblDataSinistrosConsulta);
            this.gbConsultaSinistros.Controls.Add(this.btnTrasferirSinistros);
            this.gbConsultaSinistros.Controls.Add(this.dgSinistrosConsulta);
            this.gbConsultaSinistros.Controls.Add(this.btnTodosSinistros);
            this.gbConsultaSinistros.Controls.Add(this.btnConsultarSinistros);
            this.gbConsultaSinistros.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaSinistros.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaSinistros.Name = "gbConsultaSinistros";
            this.gbConsultaSinistros.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaSinistros.TabIndex = 2;
            this.gbConsultaSinistros.TabStop = false;
            this.gbConsultaSinistros.Text = "Consulta";
            // 
            // panelConsultarPorData
            // 
            this.panelConsultarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelConsultarPorData.Controls.Add(this.gbData);
            this.panelConsultarPorData.Location = new System.Drawing.Point(394, 64);
            this.panelConsultarPorData.Name = "panelConsultarPorData";
            this.panelConsultarPorData.Size = new System.Drawing.Size(177, 213);
            this.panelConsultarPorData.TabIndex = 39;
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
            this.btnConsultarPorData.TabIndex = 23;
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
            this.dtFimConsulta.TabIndex = 22;
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
            this.dtInicioConsulta.TabIndex = 21;
            this.dtInicioConsulta.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            // 
            // dtDataSinistroConsulta
            // 
            this.dtDataSinistroConsulta.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtDataSinistroConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataSinistroConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataSinistroConsulta.Location = new System.Drawing.Point(303, 24);
            this.dtDataSinistroConsulta.Name = "dtDataSinistroConsulta";
            this.dtDataSinistroConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataSinistroConsulta.Size = new System.Drawing.Size(267, 31);
            this.dtDataSinistroConsulta.TabIndex = 15;
            // 
            // cbTipoConsulta
            // 
            this.cbTipoConsulta.FormattingEnabled = true;
            this.cbTipoConsulta.Location = new System.Drawing.Point(53, 24);
            this.cbTipoConsulta.Name = "cbTipoConsulta";
            this.cbTipoConsulta.Size = new System.Drawing.Size(197, 33);
            this.cbTipoConsulta.TabIndex = 14;
            // 
            // lblTipoConsulta
            // 
            this.lblTipoConsulta.AutoSize = true;
            this.lblTipoConsulta.Location = new System.Drawing.Point(9, 28);
            this.lblTipoConsulta.Name = "lblTipoConsulta";
            this.lblTipoConsulta.Size = new System.Drawing.Size(38, 25);
            this.lblTipoConsulta.TabIndex = 65;
            this.lblTipoConsulta.Text = "Tipo:";
            // 
            // txtIDSinistrosConsulta
            // 
            this.txtIDSinistrosConsulta.Location = new System.Drawing.Point(95, 66);
            this.txtIDSinistrosConsulta.Name = "txtIDSinistrosConsulta";
            this.txtIDSinistrosConsulta.Size = new System.Drawing.Size(141, 32);
            this.txtIDSinistrosConsulta.TabIndex = 16;
            // 
            // lblIDSinistrosConsulta
            // 
            this.lblIDSinistrosConsulta.AutoSize = true;
            this.lblIDSinistrosConsulta.Location = new System.Drawing.Point(2, 69);
            this.lblIDSinistrosConsulta.Name = "lblIDSinistrosConsulta";
            this.lblIDSinistrosConsulta.Size = new System.Drawing.Size(87, 25);
            this.lblIDSinistrosConsulta.TabIndex = 41;
            this.lblIDSinistrosConsulta.Text = "Identificador:";
            // 
            // lblDataSinistrosConsulta
            // 
            this.lblDataSinistrosConsulta.AutoSize = true;
            this.lblDataSinistrosConsulta.Location = new System.Drawing.Point(255, 27);
            this.lblDataSinistrosConsulta.Name = "lblDataSinistrosConsulta";
            this.lblDataSinistrosConsulta.Size = new System.Drawing.Size(42, 25);
            this.lblDataSinistrosConsulta.TabIndex = 40;
            this.lblDataSinistrosConsulta.Text = "Data:";
            // 
            // btnTrasferirSinistros
            // 
            this.btnTrasferirSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirSinistros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirSinistros.BackgroundImage")));
            this.btnTrasferirSinistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirSinistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrasferirSinistros.FlatAppearance.BorderSize = 0;
            this.btnTrasferirSinistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirSinistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirSinistros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirSinistros.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirSinistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirSinistros.Location = new System.Drawing.Point(577, 64);
            this.btnTrasferirSinistros.Name = "btnTrasferirSinistros";
            this.btnTrasferirSinistros.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirSinistros.TabIndex = 19;
            this.btnTrasferirSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirSinistros.UseVisualStyleBackColor = false;
            this.btnTrasferirSinistros.Click += new System.EventHandler(this.btnTrasferirSinistros_Click);
            // 
            // dgSinistrosConsulta
            // 
            this.dgSinistrosConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgSinistrosConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSinistrosConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgSinistrosConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgSinistrosConsulta.Location = new System.Drawing.Point(7, 110);
            this.dgSinistrosConsulta.Name = "dgSinistrosConsulta";
            this.dgSinistrosConsulta.ReadOnly = true;
            this.dgSinistrosConsulta.Size = new System.Drawing.Size(608, 329);
            this.dgSinistrosConsulta.TabIndex = 20;
            this.dgSinistrosConsulta.DoubleClick += new System.EventHandler(this.DgSinistrosConsulta_DoubleClick);
            // 
            // btnTodosSinistros
            // 
            this.btnTodosSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosSinistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosSinistros.FlatAppearance.BorderSize = 0;
            this.btnTodosSinistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosSinistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosSinistros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosSinistros.ForeColor = System.Drawing.Color.White;
            this.btnTodosSinistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosSinistros.Location = new System.Drawing.Point(394, 64);
            this.btnTodosSinistros.Name = "btnTodosSinistros";
            this.btnTodosSinistros.Size = new System.Drawing.Size(177, 40);
            this.btnTodosSinistros.TabIndex = 18;
            this.btnTodosSinistros.Text = "Consultar p/ Data";
            this.btnTodosSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosSinistros.UseVisualStyleBackColor = false;
            this.btnTodosSinistros.Click += new System.EventHandler(this.btnTodosSinistros_Click);
            // 
            // btnConsultarSinistros
            // 
            this.btnConsultarSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarSinistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarSinistros.FlatAppearance.BorderSize = 0;
            this.btnConsultarSinistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarSinistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarSinistros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarSinistros.ForeColor = System.Drawing.Color.White;
            this.btnConsultarSinistros.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarSinistros.Image")));
            this.btnConsultarSinistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarSinistros.Location = new System.Drawing.Point(242, 63);
            this.btnConsultarSinistros.Name = "btnConsultarSinistros";
            this.btnConsultarSinistros.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarSinistros.TabIndex = 17;
            this.btnConsultarSinistros.Text = "    Consultar";
            this.btnConsultarSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarSinistros.UseVisualStyleBackColor = false;
            this.btnConsultarSinistros.Click += new System.EventHandler(this.btnConsultarSinistros_Click);
            // 
            // Sinistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlSinistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sinistros";
            this.Text = "Sinistros";
            this.Load += new System.EventHandler(this.Sinistros_Load);
            this.tbControlSinistros.ResumeLayout(false);
            this.tbPageCadastroSinistros.ResumeLayout(false);
            this.gbDadosSinistros.ResumeLayout(false);
            this.gbDadosSinistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).EndInit();
            this.tbPageConsultaSinistros.ResumeLayout(false);
            this.gbConsultaSinistros.ResumeLayout(false);
            this.gbConsultaSinistros.PerformLayout();
            this.panelConsultarPorData.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSinistrosConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlSinistros;
        private System.Windows.Forms.TabPage tbPageCadastroSinistros;
        private System.Windows.Forms.GroupBox gbDadosSinistros;
        private System.Windows.Forms.ComboBox cbSeguro;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.ComboBox cbItemSegurado;
        private System.Windows.Forms.Label lblItemSegurado;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtDataSinistro;
        private System.Windows.Forms.Button btnExcluirSinistros;
        private System.Windows.Forms.Button btnAlterarSinistros;
        private System.Windows.Forms.Button btnCadastrarSinistros;
        private System.Windows.Forms.TabPage tbPageConsultaSinistros;
        private System.Windows.Forms.GroupBox gbConsultaSinistros;
        private System.Windows.Forms.Button btnTrasferirSinistros;
        private System.Windows.Forms.DataGridView dgSinistrosConsulta;
        private System.Windows.Forms.Button btnTodosSinistros;
        private System.Windows.Forms.Button btnConsultarSinistros;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtIDSinistrosConsulta;
        private System.Windows.Forms.Label lblIDSinistrosConsulta;
        private System.Windows.Forms.Label lblDataSinistrosConsulta;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipoConsulta;
        private System.Windows.Forms.Label lblTipoConsulta;
        private System.Windows.Forms.DateTimePicker dtDataSinistroConsulta;
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