namespace CamadaDesktop
{
    partial class ServicoExterno_Conveniados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicoExterno_Conveniados));
            this.tbControlConveniados = new System.Windows.Forms.TabControl();
            this.tbPageCadastroConveniados = new System.Windows.Forms.TabPage();
            this.gbDadosConveniados = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.rdNaoConveniado = new System.Windows.Forms.RadioButton();
            this.rdConveniado = new System.Windows.Forms.RadioButton();
            this.lbldatavencimento = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnExcluirEntradaSaida = new System.Windows.Forms.Button();
            this.btnAlterarEntradaSaida = new System.Windows.Forms.Button();
            this.btnCadastrarEntradaSaida = new System.Windows.Forms.Button();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.tbPageConsultaConveniados = new System.Windows.Forms.TabPage();
            this.gbConsultaConveniados = new System.Windows.Forms.GroupBox();
            this.txtCNPJConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirConveniado = new System.Windows.Forms.Button();
            this.dgConveniadoConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosConveniado = new System.Windows.Forms.Button();
            this.btnConsultarConveniado = new System.Windows.Forms.Button();
            this.tbControlConveniados.SuspendLayout();
            this.tbPageCadastroConveniados.SuspendLayout();
            this.gbDadosConveniados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbPageConsultaConveniados.SuspendLayout();
            this.gbConsultaConveniados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConveniadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlConveniados
            // 
            this.tbControlConveniados.Controls.Add(this.tbPageCadastroConveniados);
            this.tbControlConveniados.Controls.Add(this.tbPageConsultaConveniados);
            this.tbControlConveniados.Font = new System.Drawing.Font("Agency FB", 18F);
            this.tbControlConveniados.Location = new System.Drawing.Point(1, 24);
            this.tbControlConveniados.Name = "tbControlConveniados";
            this.tbControlConveniados.SelectedIndex = 0;
            this.tbControlConveniados.Size = new System.Drawing.Size(644, 498);
            this.tbControlConveniados.TabIndex = 26;
            // 
            // tbPageCadastroConveniados
            // 
            this.tbPageCadastroConveniados.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroConveniados.Controls.Add(this.gbDadosConveniados);
            this.tbPageCadastroConveniados.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroConveniados.Name = "tbPageCadastroConveniados";
            this.tbPageCadastroConveniados.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroConveniados.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroConveniados.TabIndex = 0;
            this.tbPageCadastroConveniados.Text = "Cadastrar";
            // 
            // gbDadosConveniados
            // 
            this.gbDadosConveniados.Controls.Add(this.panel1);
            this.gbDadosConveniados.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosConveniados.Location = new System.Drawing.Point(6, 6);
            this.gbDadosConveniados.Name = "gbDadosConveniados";
            this.gbDadosConveniados.Size = new System.Drawing.Size(621, 445);
            this.gbDadosConveniados.TabIndex = 1;
            this.gbDadosConveniados.TabStop = false;
            this.gbDadosConveniados.Text = "Dados";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dtVencimento);
            this.panel1.Controls.Add(this.dtInicio);
            this.panel1.Controls.Add(this.rdNaoConveniado);
            this.panel1.Controls.Add(this.rdConveniado);
            this.panel1.Controls.Add(this.lbldatavencimento);
            this.panel1.Controls.Add(this.lblDataInicio);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.txtNomeServico);
            this.panel1.Controls.Add(this.txtCNPJ);
            this.panel1.Controls.Add(this.lblCNPJ);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.btnExcluirEntradaSaida);
            this.panel1.Controls.Add(this.btnAlterarEntradaSaida);
            this.panel1.Controls.Add(this.btnCadastrarEntradaSaida);
            this.panel1.Controls.Add(this.lblTipoServico);
            this.panel1.Location = new System.Drawing.Point(6, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 408);
            this.panel1.TabIndex = 0;
            // 
            // dtVencimento
            // 
            this.dtVencimento.CustomFormat = "dd/mm/yyyy";
            this.dtVencimento.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(14, 379);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtVencimento.Size = new System.Drawing.Size(284, 31);
            this.dtVencimento.TabIndex = 70;
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/mm/yyyy";
            this.dtInicio.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(203, 317);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtInicio.Size = new System.Drawing.Size(284, 31);
            this.dtInicio.TabIndex = 69;
            // 
            // rdNaoConveniado
            // 
            this.rdNaoConveniado.AutoSize = true;
            this.rdNaoConveniado.Location = new System.Drawing.Point(113, 256);
            this.rdNaoConveniado.Name = "rdNaoConveniado";
            this.rdNaoConveniado.Size = new System.Drawing.Size(123, 29);
            this.rdNaoConveniado.TabIndex = 68;
            this.rdNaoConveniado.TabStop = true;
            this.rdNaoConveniado.Text = "Não Conveniado";
            this.rdNaoConveniado.UseVisualStyleBackColor = true;
            this.rdNaoConveniado.CheckedChanged += new System.EventHandler(this.rdNaoConveniado_CheckedChanged);
            // 
            // rdConveniado
            // 
            this.rdConveniado.AutoSize = true;
            this.rdConveniado.Location = new System.Drawing.Point(11, 256);
            this.rdConveniado.Name = "rdConveniado";
            this.rdConveniado.Size = new System.Drawing.Size(96, 29);
            this.rdConveniado.TabIndex = 67;
            this.rdConveniado.TabStop = true;
            this.rdConveniado.Text = "Conveniado";
            this.rdConveniado.UseVisualStyleBackColor = true;
            this.rdConveniado.CheckedChanged += new System.EventHandler(this.rdConveniado_CheckedChanged);
            // 
            // lbldatavencimento
            // 
            this.lbldatavencimento.AutoSize = true;
            this.lbldatavencimento.Location = new System.Drawing.Point(9, 351);
            this.lbldatavencimento.Name = "lbldatavencimento";
            this.lbldatavencimento.Size = new System.Drawing.Size(111, 25);
            this.lbldatavencimento.TabIndex = 65;
            this.lbldatavencimento.Text = "Data Vencimento";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(198, 288);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(77, 25);
            this.lblDataInicio.TabIndex = 64;
            this.lblDataInicio.Text = "Data Inicio:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(14, 316);
            this.txtValor.Mask = "0000000000";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(183, 32);
            this.txtValor.TabIndex = 62;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(7, 288);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 25);
            this.lblValor.TabIndex = 61;
            this.lblValor.Text = "Valor:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(11, 218);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(377, 32);
            this.txtEndereco.TabIndex = 59;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(6, 190);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(71, 25);
            this.lblEndereco.TabIndex = 58;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(11, 155);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(377, 32);
            this.txtemail.TabIndex = 57;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(6, 127);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 25);
            this.lblemail.TabIndex = 56;
            this.lblemail.Text = "e-mail:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(200, 91);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(185, 32);
            this.txtTelefone.TabIndex = 55;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(195, 63);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(62, 25);
            this.lblTelefone.TabIndex = 54;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.Location = new System.Drawing.Point(200, 28);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(265, 32);
            this.txtNomeServico.TabIndex = 53;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(8, 28);
            this.txtCNPJ.Mask = "00.000.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(186, 32);
            this.txtCNPJ.TabIndex = 52;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(3, 0);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(50, 25);
            this.lblCNPJ.TabIndex = 51;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(195, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 25);
            this.lblNome.TabIndex = 50;
            this.lblNome.Text = "Nome:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(11, 91);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(186, 33);
            this.cbTipo.TabIndex = 49;
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
            this.btnExcluirEntradaSaida.Location = new System.Drawing.Point(225, 545);
            this.btnExcluirEntradaSaida.Name = "btnExcluirEntradaSaida";
            this.btnExcluirEntradaSaida.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirEntradaSaida.TabIndex = 48;
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
            this.btnAlterarEntradaSaida.Location = new System.Drawing.Point(225, 499);
            this.btnAlterarEntradaSaida.Name = "btnAlterarEntradaSaida";
            this.btnAlterarEntradaSaida.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarEntradaSaida.TabIndex = 47;
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
            this.btnCadastrarEntradaSaida.Location = new System.Drawing.Point(110, 453);
            this.btnCadastrarEntradaSaida.Name = "btnCadastrarEntradaSaida";
            this.btnCadastrarEntradaSaida.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarEntradaSaida.TabIndex = 46;
            this.btnCadastrarEntradaSaida.Text = "Cadastrar";
            this.btnCadastrarEntradaSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarEntradaSaida.UseVisualStyleBackColor = false;
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Location = new System.Drawing.Point(6, 63);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(86, 25);
            this.lblTipoServico.TabIndex = 45;
            this.lblTipoServico.Text = "Tipo Serviço:";
            // 
            // tbPageConsultaConveniados
            // 
            this.tbPageConsultaConveniados.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaConveniados.Controls.Add(this.gbConsultaConveniados);
            this.tbPageConsultaConveniados.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaConveniados.Name = "tbPageConsultaConveniados";
            this.tbPageConsultaConveniados.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaConveniados.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaConveniados.TabIndex = 1;
            this.tbPageConsultaConveniados.Text = "Consultar";
            // 
            // gbConsultaConveniados
            // 
            this.gbConsultaConveniados.Controls.Add(this.txtCNPJConsulta);
            this.gbConsultaConveniados.Controls.Add(this.lblCNPJConsulta);
            this.gbConsultaConveniados.Controls.Add(this.btnTrasferirConveniado);
            this.gbConsultaConveniados.Controls.Add(this.dgConveniadoConsulta);
            this.gbConsultaConveniados.Controls.Add(this.btnTodosConveniado);
            this.gbConsultaConveniados.Controls.Add(this.btnConsultarConveniado);
            this.gbConsultaConveniados.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaConveniados.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaConveniados.Name = "gbConsultaConveniados";
            this.gbConsultaConveniados.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaConveniados.TabIndex = 2;
            this.gbConsultaConveniados.TabStop = false;
            this.gbConsultaConveniados.Text = "Consulta";
            // 
            // txtCNPJConsulta
            // 
            this.txtCNPJConsulta.Location = new System.Drawing.Point(68, 37);
            this.txtCNPJConsulta.Mask = "00.000.000/0000-00";
            this.txtCNPJConsulta.Name = "txtCNPJConsulta";
            this.txtCNPJConsulta.Size = new System.Drawing.Size(186, 32);
            this.txtCNPJConsulta.TabIndex = 34;
            // 
            // lblCNPJConsulta
            // 
            this.lblCNPJConsulta.AutoSize = true;
            this.lblCNPJConsulta.Location = new System.Drawing.Point(12, 44);
            this.lblCNPJConsulta.Name = "lblCNPJConsulta";
            this.lblCNPJConsulta.Size = new System.Drawing.Size(50, 25);
            this.lblCNPJConsulta.TabIndex = 33;
            this.lblCNPJConsulta.Text = "CNPJ:";
            // 
            // btnTrasferirConveniado
            // 
            this.btnTrasferirConveniado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirConveniado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirConveniado.BackgroundImage")));
            this.btnTrasferirConveniado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirConveniado.FlatAppearance.BorderSize = 0;
            this.btnTrasferirConveniado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirConveniado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirConveniado.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirConveniado.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirConveniado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirConveniado.Location = new System.Drawing.Point(577, 29);
            this.btnTrasferirConveniado.Name = "btnTrasferirConveniado";
            this.btnTrasferirConveniado.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirConveniado.TabIndex = 21;
            this.btnTrasferirConveniado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirConveniado.UseVisualStyleBackColor = false;
            // 
            // dgConveniadoConsulta
            // 
            this.dgConveniadoConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgConveniadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConveniadoConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgConveniadoConsulta.Location = new System.Drawing.Point(7, 75);
            this.dgConveniadoConsulta.Name = "dgConveniadoConsulta";
            this.dgConveniadoConsulta.Size = new System.Drawing.Size(608, 364);
            this.dgConveniadoConsulta.TabIndex = 25;
            // 
            // btnTodosConveniado
            // 
            this.btnTodosConveniado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosConveniado.FlatAppearance.BorderSize = 0;
            this.btnTodosConveniado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosConveniado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosConveniado.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosConveniado.ForeColor = System.Drawing.Color.White;
            this.btnTodosConveniado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosConveniado.Location = new System.Drawing.Point(412, 29);
            this.btnTodosConveniado.Name = "btnTodosConveniado";
            this.btnTodosConveniado.Size = new System.Drawing.Size(159, 40);
            this.btnTodosConveniado.TabIndex = 24;
            this.btnTodosConveniado.Text = "Consultar Todos";
            this.btnTodosConveniado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosConveniado.UseVisualStyleBackColor = false;
            // 
            // btnConsultarConveniado
            // 
            this.btnConsultarConveniado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarConveniado.FlatAppearance.BorderSize = 0;
            this.btnConsultarConveniado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarConveniado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarConveniado.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarConveniado.ForeColor = System.Drawing.Color.White;
            this.btnConsultarConveniado.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarConveniado.Image")));
            this.btnConsultarConveniado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarConveniado.Location = new System.Drawing.Point(260, 29);
            this.btnConsultarConveniado.Name = "btnConsultarConveniado";
            this.btnConsultarConveniado.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarConveniado.TabIndex = 23;
            this.btnConsultarConveniado.Text = "    Consultar";
            this.btnConsultarConveniado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarConveniado.UseVisualStyleBackColor = false;
            // 
            // ServicoExterno_Conveniados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlConveniados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServicoExterno_Conveniados";
            this.Text = "ServicoExterno_Conveniados";
            this.tbControlConveniados.ResumeLayout(false);
            this.tbPageCadastroConveniados.ResumeLayout(false);
            this.gbDadosConveniados.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbPageConsultaConveniados.ResumeLayout(false);
            this.gbConsultaConveniados.ResumeLayout(false);
            this.gbConsultaConveniados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConveniadoConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlConveniados;
        private System.Windows.Forms.TabPage tbPageCadastroConveniados;
        private System.Windows.Forms.GroupBox gbDadosConveniados;
        private System.Windows.Forms.TabPage tbPageConsultaConveniados;
        private System.Windows.Forms.GroupBox gbConsultaConveniados;
        private System.Windows.Forms.Button btnTrasferirConveniado;
        private System.Windows.Forms.DataGridView dgConveniadoConsulta;
        private System.Windows.Forms.Button btnTodosConveniado;
        private System.Windows.Forms.Button btnConsultarConveniado;
        private System.Windows.Forms.MaskedTextBox txtCNPJConsulta;
        private System.Windows.Forms.Label lblCNPJConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnExcluirEntradaSaida;
        private System.Windows.Forms.Button btnAlterarEntradaSaida;
        private System.Windows.Forms.Button btnCadastrarEntradaSaida;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.Label lbldatavencimento;
        private System.Windows.Forms.RadioButton rdConveniado;
        private System.Windows.Forms.RadioButton rdNaoConveniado;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.DateTimePicker dtInicio;
    }
}