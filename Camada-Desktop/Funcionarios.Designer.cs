namespace CamadaDesktop
{
    partial class Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            this.tbControlFuncionario = new System.Windows.Forms.TabControl();
            this.tbPageCadastroFuncionario = new System.Windows.Forms.TabPage();
            this.gbDadosFuncionario = new System.Windows.Forms.GroupBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblPerfilAcesso = new System.Windows.Forms.Label();
            this.cbPerfilAcesso = new System.Windows.Forms.ComboBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnAlterarFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.tbPageConsultaFuncionario = new System.Windows.Forms.TabPage();
            this.gbConsultaFuncionario = new System.Windows.Forms.GroupBox();
            this.textPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.panelConsultarPorData = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnConsultarPorData = new System.Windows.Forms.Button();
            this.lblFimConsulta = new System.Windows.Forms.Label();
            this.lblInicioConsulta = new System.Windows.Forms.Label();
            this.dtFimConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtLoginFuncionarioConsulta = new System.Windows.Forms.TextBox();
            this.lblLoginFuncionarioConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirFuncionario = new System.Windows.Forms.Button();
            this.dgFuncionarioConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosFuncionario = new System.Windows.Forms.Button();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.toolTipTransfere = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipPesquisar = new System.Windows.Forms.ToolTip(this.components);
            this.tbControlFuncionario.SuspendLayout();
            this.tbPageCadastroFuncionario.SuspendLayout();
            this.gbDadosFuncionario.SuspendLayout();
            this.tbPageConsultaFuncionario.SuspendLayout();
            this.gbConsultaFuncionario.SuspendLayout();
            this.panelConsultarPorData.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarioConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlFuncionario
            // 
            this.tbControlFuncionario.Controls.Add(this.tbPageCadastroFuncionario);
            this.tbControlFuncionario.Controls.Add(this.tbPageConsultaFuncionario);
            this.tbControlFuncionario.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlFuncionario.Location = new System.Drawing.Point(1, 18);
            this.tbControlFuncionario.Name = "tbControlFuncionario";
            this.tbControlFuncionario.SelectedIndex = 0;
            this.tbControlFuncionario.Size = new System.Drawing.Size(644, 498);
            this.tbControlFuncionario.TabIndex = 22;
            // 
            // tbPageCadastroFuncionario
            // 
            this.tbPageCadastroFuncionario.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroFuncionario.Controls.Add(this.gbDadosFuncionario);
            this.tbPageCadastroFuncionario.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroFuncionario.Name = "tbPageCadastroFuncionario";
            this.tbPageCadastroFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroFuncionario.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroFuncionario.TabIndex = 0;
            this.tbPageCadastroFuncionario.Text = "Cadastrar";
            // 
            // gbDadosFuncionario
            // 
            this.gbDadosFuncionario.Controls.Add(this.lblCancelar);
            this.gbDadosFuncionario.Controls.Add(this.lblPerfilAcesso);
            this.gbDadosFuncionario.Controls.Add(this.cbPerfilAcesso);
            this.gbDadosFuncionario.Controls.Add(this.txtSenha);
            this.gbDadosFuncionario.Controls.Add(this.lblSenha);
            this.gbDadosFuncionario.Controls.Add(this.txtLogin);
            this.gbDadosFuncionario.Controls.Add(this.lblLogin);
            this.gbDadosFuncionario.Controls.Add(this.txtnome);
            this.gbDadosFuncionario.Controls.Add(this.lblNome);
            this.gbDadosFuncionario.Controls.Add(this.btnExcluirFuncionario);
            this.gbDadosFuncionario.Controls.Add(this.btnAlterarFuncionario);
            this.gbDadosFuncionario.Controls.Add(this.btnCadastrarFuncionario);
            this.gbDadosFuncionario.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosFuncionario.Location = new System.Drawing.Point(6, 6);
            this.gbDadosFuncionario.Name = "gbDadosFuncionario";
            this.gbDadosFuncionario.Size = new System.Drawing.Size(621, 391);
            this.gbDadosFuncionario.TabIndex = 1;
            this.gbDadosFuncionario.TabStop = false;
            this.gbDadosFuncionario.Text = "Dados";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCancelar.Font = new System.Drawing.Font("Agency FB", 20.25F);
            this.lblCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCancelar.Location = new System.Drawing.Point(267, 253);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(89, 32);
            this.lblCancelar.TabIndex = 49;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Visible = false;
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // lblPerfilAcesso
            // 
            this.lblPerfilAcesso.AutoSize = true;
            this.lblPerfilAcesso.Location = new System.Drawing.Point(10, 154);
            this.lblPerfilAcesso.Name = "lblPerfilAcesso";
            this.lblPerfilAcesso.Size = new System.Drawing.Size(93, 25);
            this.lblPerfilAcesso.TabIndex = 48;
            this.lblPerfilAcesso.Text = "Perfil Acesso:";
            // 
            // cbPerfilAcesso
            // 
            this.cbPerfilAcesso.FormattingEnabled = true;
            this.cbPerfilAcesso.Location = new System.Drawing.Point(11, 182);
            this.cbPerfilAcesso.Name = "cbPerfilAcesso";
            this.cbPerfilAcesso.Size = new System.Drawing.Size(197, 33);
            this.cbPerfilAcesso.TabIndex = 17;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(214, 119);
            this.txtSenha.MaxLength = 25;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(197, 32);
            this.txtSenha.TabIndex = 16;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(209, 91);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 25);
            this.lblSenha.TabIndex = 45;
            this.lblSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(11, 119);
            this.txtLogin.MaxLength = 25;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(197, 32);
            this.txtLogin.TabIndex = 15;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(6, 91);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(45, 25);
            this.lblLogin.TabIndex = 39;
            this.lblLogin.Text = "Login:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(11, 56);
            this.txtnome.MaxLength = 150;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(487, 32);
            this.txtnome.TabIndex = 14;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 25);
            this.lblNome.TabIndex = 37;
            this.lblNome.Text = "Nome:";
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirFuncionario.Enabled = false;
            this.btnExcluirFuncionario.FlatAppearance.BorderSize = 0;
            this.btnExcluirFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFuncionario.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnExcluirFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirFuncionario.Image")));
            this.btnExcluirFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(244, 341);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirFuncionario.TabIndex = 20;
            this.btnExcluirFuncionario.Text = "Excluir";
            this.btnExcluirFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirFuncionario.UseVisualStyleBackColor = false;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluirFuncionario_Click);
            // 
            // btnAlterarFuncionario
            // 
            this.btnAlterarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarFuncionario.Enabled = false;
            this.btnAlterarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnAlterarFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarFuncionario.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnAlterarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarFuncionario.Image")));
            this.btnAlterarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarFuncionario.Location = new System.Drawing.Point(244, 295);
            this.btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            this.btnAlterarFuncionario.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarFuncionario.TabIndex = 19;
            this.btnAlterarFuncionario.Text = "Alterar";
            this.btnAlterarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarFuncionario.UseVisualStyleBackColor = false;
            this.btnAlterarFuncionario.Click += new System.EventHandler(this.btnAlterarFuncionario_Click);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarFuncionario.Image")));
            this.btnCadastrarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(119, 249);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarFuncionario.TabIndex = 18;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // tbPageConsultaFuncionario
            // 
            this.tbPageConsultaFuncionario.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaFuncionario.Controls.Add(this.gbConsultaFuncionario);
            this.tbPageConsultaFuncionario.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaFuncionario.Name = "tbPageConsultaFuncionario";
            this.tbPageConsultaFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaFuncionario.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaFuncionario.TabIndex = 1;
            this.tbPageConsultaFuncionario.Text = "Consultar";
            // 
            // gbConsultaFuncionario
            // 
            this.gbConsultaFuncionario.Controls.Add(this.textPesquisar);
            this.gbConsultaFuncionario.Controls.Add(this.lbPesquisar);
            this.gbConsultaFuncionario.Controls.Add(this.panelConsultarPorData);
            this.gbConsultaFuncionario.Controls.Add(this.txtLoginFuncionarioConsulta);
            this.gbConsultaFuncionario.Controls.Add(this.lblLoginFuncionarioConsulta);
            this.gbConsultaFuncionario.Controls.Add(this.btnTrasferirFuncionario);
            this.gbConsultaFuncionario.Controls.Add(this.dgFuncionarioConsulta);
            this.gbConsultaFuncionario.Controls.Add(this.btnTodosFuncionario);
            this.gbConsultaFuncionario.Controls.Add(this.btnConsultarFuncionario);
            this.gbConsultaFuncionario.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaFuncionario.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaFuncionario.Name = "gbConsultaFuncionario";
            this.gbConsultaFuncionario.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaFuncionario.TabIndex = 2;
            this.gbConsultaFuncionario.TabStop = false;
            this.gbConsultaFuncionario.Text = "Consulta";
            // 
            // textPesquisar
            // 
            this.textPesquisar.Location = new System.Drawing.Point(87, 69);
            this.textPesquisar.Name = "textPesquisar";
            this.textPesquisar.Size = new System.Drawing.Size(193, 32);
            this.textPesquisar.TabIndex = 44;
            this.textPesquisar.TextChanged += new System.EventHandler(this.TextPesquisar_TextChanged);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(6, 72);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(75, 25);
            this.lbPesquisar.TabIndex = 43;
            this.lbPesquisar.Text = "Pesquisar:";
            // 
            // panelConsultarPorData
            // 
            this.panelConsultarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelConsultarPorData.Controls.Add(this.gbData);
            this.panelConsultarPorData.Location = new System.Drawing.Point(394, 21);
            this.panelConsultarPorData.Name = "panelConsultarPorData";
            this.panelConsultarPorData.Size = new System.Drawing.Size(177, 213);
            this.panelConsultarPorData.TabIndex = 42;
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
            // txtLoginFuncionarioConsulta
            // 
            this.txtLoginFuncionarioConsulta.Location = new System.Drawing.Point(57, 27);
            this.txtLoginFuncionarioConsulta.Name = "txtLoginFuncionarioConsulta";
            this.txtLoginFuncionarioConsulta.Size = new System.Drawing.Size(179, 32);
            this.txtLoginFuncionarioConsulta.TabIndex = 14;
            // 
            // lblLoginFuncionarioConsulta
            // 
            this.lblLoginFuncionarioConsulta.AutoSize = true;
            this.lblLoginFuncionarioConsulta.Location = new System.Drawing.Point(6, 30);
            this.lblLoginFuncionarioConsulta.Name = "lblLoginFuncionarioConsulta";
            this.lblLoginFuncionarioConsulta.Size = new System.Drawing.Size(45, 25);
            this.lblLoginFuncionarioConsulta.TabIndex = 41;
            this.lblLoginFuncionarioConsulta.Text = "Login:";
            // 
            // btnTrasferirFuncionario
            // 
            this.btnTrasferirFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirFuncionario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirFuncionario.BackgroundImage")));
            this.btnTrasferirFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrasferirFuncionario.FlatAppearance.BorderSize = 0;
            this.btnTrasferirFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirFuncionario.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirFuncionario.Location = new System.Drawing.Point(577, 21);
            this.btnTrasferirFuncionario.Name = "btnTrasferirFuncionario";
            this.btnTrasferirFuncionario.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirFuncionario.TabIndex = 17;
            this.btnTrasferirFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirFuncionario.UseVisualStyleBackColor = false;
            this.btnTrasferirFuncionario.Click += new System.EventHandler(this.btnTrasferirFuncionario_Click);
            // 
            // dgFuncionarioConsulta
            // 
            this.dgFuncionarioConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgFuncionarioConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionarioConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgFuncionarioConsulta.Location = new System.Drawing.Point(7, 107);
            this.dgFuncionarioConsulta.Name = "dgFuncionarioConsulta";
            this.dgFuncionarioConsulta.Size = new System.Drawing.Size(608, 332);
            this.dgFuncionarioConsulta.TabIndex = 18;
            this.dgFuncionarioConsulta.DoubleClick += new System.EventHandler(this.dgFuncionarioConsulta_DoubleClick);
            // 
            // btnTodosFuncionario
            // 
            this.btnTodosFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosFuncionario.FlatAppearance.BorderSize = 0;
            this.btnTodosFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosFuncionario.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnTodosFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosFuncionario.Location = new System.Drawing.Point(394, 21);
            this.btnTodosFuncionario.Name = "btnTodosFuncionario";
            this.btnTodosFuncionario.Size = new System.Drawing.Size(177, 40);
            this.btnTodosFuncionario.TabIndex = 16;
            this.btnTodosFuncionario.Text = "Consultar p/ Data";
            this.btnTodosFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosFuncionario.UseVisualStyleBackColor = false;
            this.btnTodosFuncionario.Click += new System.EventHandler(this.btnTodosFuncionario_Click);
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnConsultarFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFuncionario.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarFuncionario.Image")));
            this.btnConsultarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(242, 21);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarFuncionario.TabIndex = 15;
            this.btnConsultarFuncionario.Text = "    Consultar";
            this.btnConsultarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarFuncionario.UseVisualStyleBackColor = false;
            this.btnConsultarFuncionario.Click += new System.EventHandler(this.btnConsultarFuncionario_Click);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionarios";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            this.tbControlFuncionario.ResumeLayout(false);
            this.tbPageCadastroFuncionario.ResumeLayout(false);
            this.gbDadosFuncionario.ResumeLayout(false);
            this.gbDadosFuncionario.PerformLayout();
            this.tbPageConsultaFuncionario.ResumeLayout(false);
            this.gbConsultaFuncionario.ResumeLayout(false);
            this.gbConsultaFuncionario.PerformLayout();
            this.panelConsultarPorData.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarioConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlFuncionario;
        private System.Windows.Forms.TabPage tbPageCadastroFuncionario;
        private System.Windows.Forms.GroupBox gbDadosFuncionario;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnAlterarFuncionario;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.TabPage tbPageConsultaFuncionario;
        private System.Windows.Forms.GroupBox gbConsultaFuncionario;
        private System.Windows.Forms.TextBox txtLoginFuncionarioConsulta;
        private System.Windows.Forms.Label lblLoginFuncionarioConsulta;
        private System.Windows.Forms.Button btnTrasferirFuncionario;
        private System.Windows.Forms.DataGridView dgFuncionarioConsulta;
        private System.Windows.Forms.Button btnTodosFuncionario;
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPerfilAcesso;
        private System.Windows.Forms.ComboBox cbPerfilAcesso;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Panel panelConsultarPorData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnConsultarPorData;
        private System.Windows.Forms.Label lblFimConsulta;
        private System.Windows.Forms.Label lblInicioConsulta;
        private System.Windows.Forms.DateTimePicker dtFimConsulta;
        private System.Windows.Forms.DateTimePicker dtInicioConsulta;
        private System.Windows.Forms.ToolTip toolTipTransfere;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.TextBox textPesquisar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.ToolTip tooltipPesquisar;
    }
}