namespace CamadaDesktop
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.tbControlClientes = new System.Windows.Forms.TabControl();
            this.tbPageCadastroClientes = new System.Windows.Forms.TabPage();
            this.gbDadosClientes = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbpermissao = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.btnExcluirClientes = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.dtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.btnAlterarClientes = new System.Windows.Forms.Button();
            this.btnCadastrarClientes = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.tbPageConsultaClientes = new System.Windows.Forms.TabPage();
            this.gbConsultaClientes = new System.Windows.Forms.GroupBox();
            this.textPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.panelConsultarPorData = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnConsultarPorData = new System.Windows.Forms.Button();
            this.lblFimConsulta = new System.Windows.Forms.Label();
            this.lblInicioConsulta = new System.Windows.Forms.Label();
            this.dtFimConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.lblrecebedata = new System.Windows.Forms.Label();
            this.txtCPFClientesConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFConsultaClientes = new System.Windows.Forms.Label();
            this.btnTrasferirClientes = new System.Windows.Forms.Button();
            this.dgClientesConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosClientes = new System.Windows.Forms.Button();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.toolTipTransfere = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipPesquisar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPermissao = new System.Windows.Forms.ToolTip(this.components);
            this.tbControlClientes.SuspendLayout();
            this.tbPageCadastroClientes.SuspendLayout();
            this.gbDadosClientes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).BeginInit();
            this.tbPageConsultaClientes.SuspendLayout();
            this.gbConsultaClientes.SuspendLayout();
            this.panelConsultarPorData.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientesConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlClientes
            // 
            this.tbControlClientes.Controls.Add(this.tbPageCadastroClientes);
            this.tbControlClientes.Controls.Add(this.tbPageConsultaClientes);
            this.tbControlClientes.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlClientes.Location = new System.Drawing.Point(1, 24);
            this.tbControlClientes.Name = "tbControlClientes";
            this.tbControlClientes.SelectedIndex = 0;
            this.tbControlClientes.Size = new System.Drawing.Size(644, 557);
            this.tbControlClientes.TabIndex = 25;
            // 
            // tbPageCadastroClientes
            // 
            this.tbPageCadastroClientes.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroClientes.Controls.Add(this.gbDadosClientes);
            this.tbPageCadastroClientes.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroClientes.Name = "tbPageCadastroClientes";
            this.tbPageCadastroClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroClientes.Size = new System.Drawing.Size(636, 516);
            this.tbPageCadastroClientes.TabIndex = 0;
            this.tbPageCadastroClientes.Text = "Cadastrar";
            // 
            // gbDadosClientes
            // 
            this.gbDadosClientes.Controls.Add(this.panel1);
            this.gbDadosClientes.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosClientes.Location = new System.Drawing.Point(6, 6);
            this.gbDadosClientes.Name = "gbDadosClientes";
            this.gbDadosClientes.Size = new System.Drawing.Size(621, 504);
            this.gbDadosClientes.TabIndex = 1;
            this.gbDadosClientes.TabStop = false;
            this.gbDadosClientes.Text = "Dados";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pbpermissao);
            this.panel1.Controls.Add(this.lblCancelar);
            this.panel1.Controls.Add(this.lblDataNascimento);
            this.panel1.Controls.Add(this.btnExcluirClientes);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.dtDataNascimento);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.txtEndereço);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Controls.Add(this.txtRG);
            this.panel1.Controls.Add(this.lblRG);
            this.panel1.Controls.Add(this.btnAlterarClientes);
            this.panel1.Controls.Add(this.btnCadastrarClientes);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblCPF);
            this.panel1.Location = new System.Drawing.Point(6, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 467);
            this.panel1.TabIndex = 0;
            // 
            // pbpermissao
            // 
            this.pbpermissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbpermissao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbpermissao.Image = ((System.Drawing.Image)(resources.GetObject("pbpermissao.Image")));
            this.pbpermissao.Location = new System.Drawing.Point(381, 421);
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
            this.lblCancelar.Location = new System.Drawing.Point(255, 333);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(89, 32);
            this.lblCancelar.TabIndex = 46;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Visible = false;
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(3, 126);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(115, 25);
            this.lblDataNascimento.TabIndex = 45;
            this.lblDataNascimento.Text = "Data Nascimento:";
            // 
            // btnExcluirClientes
            // 
            this.btnExcluirClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirClientes.Enabled = false;
            this.btnExcluirClientes.FlatAppearance.BorderSize = 0;
            this.btnExcluirClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirClientes.ForeColor = System.Drawing.Color.White;
            this.btnExcluirClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirClientes.Image")));
            this.btnExcluirClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirClientes.Location = new System.Drawing.Point(229, 421);
            this.btnExcluirClientes.Name = "btnExcluirClientes";
            this.btnExcluirClientes.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirClientes.TabIndex = 23;
            this.btnExcluirClientes.Text = "Excluir";
            this.btnExcluirClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirClientes.UseVisualStyleBackColor = false;
            this.btnExcluirClientes.Click += new System.EventHandler(this.btnExcluirClientes_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(8, 280);
            this.txtemail.MaxLength = 150;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(485, 32);
            this.txtemail.TabIndex = 20;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(3, 252);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 25);
            this.lblemail.TabIndex = 43;
            this.lblemail.Text = "e-mail:";
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.CustomFormat = "dd/mm/yyyy";
            this.dtDataNascimento.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNascimento.Location = new System.Drawing.Point(8, 155);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataNascimento.Size = new System.Drawing.Size(284, 31);
            this.dtDataNascimento.TabIndex = 17;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(298, 155);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(197, 32);
            this.txtTelefone.TabIndex = 18;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(293, 126);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(62, 25);
            this.lblTelefone.TabIndex = 40;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtEndereço
            // 
            this.txtEndereço.Location = new System.Drawing.Point(8, 217);
            this.txtEndereço.MaxLength = 150;
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(485, 32);
            this.txtEndereço.TabIndex = 19;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(3, 189);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(71, 25);
            this.lblEndereco.TabIndex = 38;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(211, 91);
            this.txtRG.MaxLength = 15;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(197, 32);
            this.txtRG.TabIndex = 16;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(206, 63);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(33, 25);
            this.lblRG.TabIndex = 36;
            this.lblRG.Text = "RG:";
            // 
            // btnAlterarClientes
            // 
            this.btnAlterarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarClientes.Enabled = false;
            this.btnAlterarClientes.FlatAppearance.BorderSize = 0;
            this.btnAlterarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarClientes.ForeColor = System.Drawing.Color.White;
            this.btnAlterarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarClientes.Image")));
            this.btnAlterarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarClientes.Location = new System.Drawing.Point(229, 375);
            this.btnAlterarClientes.Name = "btnAlterarClientes";
            this.btnAlterarClientes.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarClientes.TabIndex = 22;
            this.btnAlterarClientes.Text = "Alterar";
            this.btnAlterarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarClientes.UseVisualStyleBackColor = false;
            this.btnAlterarClientes.Click += new System.EventHandler(this.btnAlterarClientes_Click);
            // 
            // btnCadastrarClientes
            // 
            this.btnCadastrarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarClientes.FlatAppearance.BorderSize = 0;
            this.btnCadastrarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarClientes.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarClientes.Image")));
            this.btnCadastrarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarClientes.Location = new System.Drawing.Point(106, 329);
            this.btnCadastrarClientes.Name = "btnCadastrarClientes";
            this.btnCadastrarClientes.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarClientes.TabIndex = 21;
            this.btnCadastrarClientes.Text = "Cadastrar";
            this.btnCadastrarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarClientes.UseVisualStyleBackColor = false;
            this.btnCadastrarClientes.Click += new System.EventHandler(this.btnCadastrarClientes_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 28);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(485, 32);
            this.txtNome.TabIndex = 14;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(8, 91);
            this.txtCPF.Mask = "999.999.999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(197, 32);
            this.txtCPF.TabIndex = 15;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 25);
            this.lblNome.TabIndex = 30;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(3, 63);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 25);
            this.lblCPF.TabIndex = 29;
            this.lblCPF.Text = "CPF:";
            // 
            // tbPageConsultaClientes
            // 
            this.tbPageConsultaClientes.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaClientes.Controls.Add(this.gbConsultaClientes);
            this.tbPageConsultaClientes.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaClientes.Name = "tbPageConsultaClientes";
            this.tbPageConsultaClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaClientes.Size = new System.Drawing.Size(636, 516);
            this.tbPageConsultaClientes.TabIndex = 1;
            this.tbPageConsultaClientes.Text = "Consultar";
            // 
            // gbConsultaClientes
            // 
            this.gbConsultaClientes.Controls.Add(this.textPesquisar);
            this.gbConsultaClientes.Controls.Add(this.lbPesquisar);
            this.gbConsultaClientes.Controls.Add(this.panelConsultarPorData);
            this.gbConsultaClientes.Controls.Add(this.lblrecebedata);
            this.gbConsultaClientes.Controls.Add(this.txtCPFClientesConsulta);
            this.gbConsultaClientes.Controls.Add(this.lblCPFConsultaClientes);
            this.gbConsultaClientes.Controls.Add(this.btnTrasferirClientes);
            this.gbConsultaClientes.Controls.Add(this.dgClientesConsulta);
            this.gbConsultaClientes.Controls.Add(this.btnTodosClientes);
            this.gbConsultaClientes.Controls.Add(this.btnConsultarClientes);
            this.gbConsultaClientes.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaClientes.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaClientes.Name = "gbConsultaClientes";
            this.gbConsultaClientes.Size = new System.Drawing.Size(621, 500);
            this.gbConsultaClientes.TabIndex = 2;
            this.gbConsultaClientes.TabStop = false;
            this.gbConsultaClientes.Text = "Consulta";
            // 
            // textPesquisar
            // 
            this.textPesquisar.Location = new System.Drawing.Point(97, 71);
            this.textPesquisar.Name = "textPesquisar";
            this.textPesquisar.Size = new System.Drawing.Size(193, 32);
            this.textPesquisar.TabIndex = 36;
            this.textPesquisar.TextChanged += new System.EventHandler(this.TextPesquisar_TextChanged);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(16, 74);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(75, 25);
            this.lbPesquisar.TabIndex = 35;
            this.lbPesquisar.Text = "Pesquisar:";
            // 
            // panelConsultarPorData
            // 
            this.panelConsultarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelConsultarPorData.Controls.Add(this.gbData);
            this.panelConsultarPorData.Location = new System.Drawing.Point(400, 24);
            this.panelConsultarPorData.Name = "panelConsultarPorData";
            this.panelConsultarPorData.Size = new System.Drawing.Size(177, 213);
            this.panelConsultarPorData.TabIndex = 34;
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
            this.gbData.Text = "Inicio do Contrato";
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
            // lblrecebedata
            // 
            this.lblrecebedata.AutoSize = true;
            this.lblrecebedata.Location = new System.Drawing.Point(543, -4);
            this.lblrecebedata.Name = "lblrecebedata";
            this.lblrecebedata.Size = new System.Drawing.Size(78, 25);
            this.lblrecebedata.TabIndex = 33;
            this.lblrecebedata.Text = "recebedata";
            this.lblrecebedata.Visible = false;
            // 
            // txtCPFClientesConsulta
            // 
            this.txtCPFClientesConsulta.Location = new System.Drawing.Point(63, 30);
            this.txtCPFClientesConsulta.Mask = "999.999.999-99";
            this.txtCPFClientesConsulta.Name = "txtCPFClientesConsulta";
            this.txtCPFClientesConsulta.Size = new System.Drawing.Size(179, 32);
            this.txtCPFClientesConsulta.TabIndex = 14;
            // 
            // lblCPFConsultaClientes
            // 
            this.lblCPFConsultaClientes.AutoSize = true;
            this.lblCPFConsultaClientes.Location = new System.Drawing.Point(16, 33);
            this.lblCPFConsultaClientes.Name = "lblCPFConsultaClientes";
            this.lblCPFConsultaClientes.Size = new System.Drawing.Size(41, 25);
            this.lblCPFConsultaClientes.TabIndex = 32;
            this.lblCPFConsultaClientes.Text = "CPF:";
            // 
            // btnTrasferirClientes
            // 
            this.btnTrasferirClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirClientes.BackgroundImage")));
            this.btnTrasferirClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrasferirClientes.FlatAppearance.BorderSize = 0;
            this.btnTrasferirClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirClientes.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirClientes.Location = new System.Drawing.Point(580, 24);
            this.btnTrasferirClientes.Name = "btnTrasferirClientes";
            this.btnTrasferirClientes.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirClientes.TabIndex = 17;
            this.btnTrasferirClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirClientes.UseVisualStyleBackColor = false;
            this.btnTrasferirClientes.Click += new System.EventHandler(this.btnTrasferirClientes_Click);
            // 
            // dgClientesConsulta
            // 
            this.dgClientesConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgClientesConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientesConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgClientesConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgClientesConsulta.Location = new System.Drawing.Point(7, 109);
            this.dgClientesConsulta.Name = "dgClientesConsulta";
            this.dgClientesConsulta.ReadOnly = true;
            this.dgClientesConsulta.Size = new System.Drawing.Size(608, 385);
            this.dgClientesConsulta.TabIndex = 18;
            this.dgClientesConsulta.DoubleClick += new System.EventHandler(this.dgClientesConsulta_DoubleClick);
            // 
            // btnTodosClientes
            // 
            this.btnTodosClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosClientes.FlatAppearance.BorderSize = 0;
            this.btnTodosClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosClientes.ForeColor = System.Drawing.Color.White;
            this.btnTodosClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosClientes.Location = new System.Drawing.Point(400, 24);
            this.btnTodosClientes.Name = "btnTodosClientes";
            this.btnTodosClientes.Size = new System.Drawing.Size(177, 40);
            this.btnTodosClientes.TabIndex = 16;
            this.btnTodosClientes.Text = "Consultar p/ Data";
            this.btnTodosClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosClientes.UseVisualStyleBackColor = false;
            this.btnTodosClientes.Click += new System.EventHandler(this.btnTodosClientes_Click);
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarClientes.FlatAppearance.BorderSize = 0;
            this.btnConsultarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarClientes.ForeColor = System.Drawing.Color.White;
            this.btnConsultarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarClientes.Image")));
            this.btnConsultarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarClientes.Location = new System.Drawing.Point(248, 24);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarClientes.TabIndex = 15;
            this.btnConsultarClientes.Text = "    Consultar";
            this.btnConsultarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarClientes.UseVisualStyleBackColor = false;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 593);
            this.Controls.Add(this.tbControlClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.tbControlClientes.ResumeLayout(false);
            this.tbPageCadastroClientes.ResumeLayout(false);
            this.gbDadosClientes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).EndInit();
            this.tbPageConsultaClientes.ResumeLayout(false);
            this.gbConsultaClientes.ResumeLayout(false);
            this.gbConsultaClientes.PerformLayout();
            this.panelConsultarPorData.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientesConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlClientes;
        private System.Windows.Forms.TabPage tbPageCadastroClientes;
        private System.Windows.Forms.GroupBox gbDadosClientes;
        private System.Windows.Forms.TabPage tbPageConsultaClientes;
        private System.Windows.Forms.GroupBox gbConsultaClientes;
        private System.Windows.Forms.Button btnTrasferirClientes;
        private System.Windows.Forms.DataGridView dgClientesConsulta;
        private System.Windows.Forms.Button btnTodosClientes;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.DateTimePicker dtDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Button btnAlterarClientes;
        private System.Windows.Forms.Button btnCadastrarClientes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnExcluirClientes;
        private System.Windows.Forms.MaskedTextBox txtCPFClientesConsulta;
        private System.Windows.Forms.Label lblCPFConsultaClientes;
        private System.Windows.Forms.Label lblrecebedata;
        private System.Windows.Forms.Panel panelConsultarPorData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DateTimePicker dtInicioConsulta;
        private System.Windows.Forms.Button btnConsultarPorData;
        private System.Windows.Forms.Label lblFimConsulta;
        private System.Windows.Forms.Label lblInicioConsulta;
        private System.Windows.Forms.DateTimePicker dtFimConsulta;
        private System.Windows.Forms.ToolTip toolTipTransfere;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.TextBox textPesquisar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.ToolTip tooltipPesquisar;
        private System.Windows.Forms.PictureBox pbpermissao;
        private System.Windows.Forms.ToolTip toolTipPermissao;
    }
}