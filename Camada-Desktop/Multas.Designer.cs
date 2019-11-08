namespace CamadaDesktop
{
    partial class Multas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multas));
            this.tbControlMultas = new System.Windows.Forms.TabControl();
            this.tbPageCadastroMultas = new System.Windows.Forms.TabPage();
            this.gbDadosMulta = new System.Windows.Forms.GroupBox();
            this.pbpermissao = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.cbCPF = new System.Windows.Forms.ComboBox();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.dtMultaPaga = new System.Windows.Forms.DateTimePicker();
            this.rdNaoPaga = new System.Windows.Forms.RadioButton();
            this.rdPaga = new System.Windows.Forms.RadioButton();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.dtDataMulta = new System.Windows.Forms.DateTimePicker();
            this.btnExcluirVeiculo = new System.Windows.Forms.Button();
            this.btnAlterarVeiculo = new System.Windows.Forms.Button();
            this.btnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.tbPageConsultaMultas = new System.Windows.Forms.TabPage();
            this.gbConsultaMultas = new System.Windows.Forms.GroupBox();
            this.panelConsultarPorData = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnConsultarPorData = new System.Windows.Forms.Button();
            this.lblFimConsulta = new System.Windows.Forms.Label();
            this.lblInicioConsulta = new System.Windows.Forms.Label();
            this.dtFimConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.cbCPFMultasConsulta = new System.Windows.Forms.ComboBox();
            this.cbPlacaMultasConsulta = new System.Windows.Forms.ComboBox();
            this.lblCPFMultasConsulta = new System.Windows.Forms.Label();
            this.lblDataMultasConsulta = new System.Windows.Forms.Label();
            this.dtDataMultasConsulta = new System.Windows.Forms.DateTimePicker();
            this.lblPlacaMultasConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirMultas = new System.Windows.Forms.Button();
            this.dgMultasConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosMultas = new System.Windows.Forms.Button();
            this.btnConsultarMultas = new System.Windows.Forms.Button();
            this.toolTipTransfere = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPermissao = new System.Windows.Forms.ToolTip(this.components);
            this.tbControlMultas.SuspendLayout();
            this.tbPageCadastroMultas.SuspendLayout();
            this.gbDadosMulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).BeginInit();
            this.tbPageConsultaMultas.SuspendLayout();
            this.gbConsultaMultas.SuspendLayout();
            this.panelConsultarPorData.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultasConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlMultas
            // 
            this.tbControlMultas.Controls.Add(this.tbPageCadastroMultas);
            this.tbControlMultas.Controls.Add(this.tbPageConsultaMultas);
            this.tbControlMultas.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlMultas.Location = new System.Drawing.Point(1, 24);
            this.tbControlMultas.Name = "tbControlMultas";
            this.tbControlMultas.SelectedIndex = 0;
            this.tbControlMultas.Size = new System.Drawing.Size(644, 498);
            this.tbControlMultas.TabIndex = 27;
            // 
            // tbPageCadastroMultas
            // 
            this.tbPageCadastroMultas.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroMultas.Controls.Add(this.gbDadosMulta);
            this.tbPageCadastroMultas.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroMultas.Name = "tbPageCadastroMultas";
            this.tbPageCadastroMultas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroMultas.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroMultas.TabIndex = 0;
            this.tbPageCadastroMultas.Text = "Cadastrar";
            // 
            // gbDadosMulta
            // 
            this.gbDadosMulta.Controls.Add(this.pbpermissao);
            this.gbDadosMulta.Controls.Add(this.lblCancelar);
            this.gbDadosMulta.Controls.Add(this.cbCPF);
            this.gbDadosMulta.Controls.Add(this.cbPlaca);
            this.gbDadosMulta.Controls.Add(this.lblDataPagamento);
            this.gbDadosMulta.Controls.Add(this.dtMultaPaga);
            this.gbDadosMulta.Controls.Add(this.rdNaoPaga);
            this.gbDadosMulta.Controls.Add(this.rdPaga);
            this.gbDadosMulta.Controls.Add(this.lblCPF);
            this.gbDadosMulta.Controls.Add(this.txtDesc);
            this.gbDadosMulta.Controls.Add(this.lblDesc);
            this.gbDadosMulta.Controls.Add(this.txtvalor);
            this.gbDadosMulta.Controls.Add(this.lblValor);
            this.gbDadosMulta.Controls.Add(this.txtLocal);
            this.gbDadosMulta.Controls.Add(this.lblData);
            this.gbDadosMulta.Controls.Add(this.lblLocal);
            this.gbDadosMulta.Controls.Add(this.dtDataMulta);
            this.gbDadosMulta.Controls.Add(this.btnExcluirVeiculo);
            this.gbDadosMulta.Controls.Add(this.btnAlterarVeiculo);
            this.gbDadosMulta.Controls.Add(this.btnCadastrarVeiculo);
            this.gbDadosMulta.Controls.Add(this.lblPlaca);
            this.gbDadosMulta.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosMulta.Location = new System.Drawing.Point(6, 6);
            this.gbDadosMulta.Name = "gbDadosMulta";
            this.gbDadosMulta.Size = new System.Drawing.Size(621, 445);
            this.gbDadosMulta.TabIndex = 1;
            this.gbDadosMulta.TabStop = false;
            this.gbDadosMulta.Text = "Dados";
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
            this.lblCancelar.Location = new System.Drawing.Point(273, 311);
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
            this.cbCPF.Location = new System.Drawing.Point(312, 54);
            this.cbCPF.Name = "cbCPF";
            this.cbCPF.Size = new System.Drawing.Size(297, 33);
            this.cbCPF.TabIndex = 15;
            // 
            // cbPlaca
            // 
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(11, 55);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(295, 33);
            this.cbPlaca.TabIndex = 14;
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(407, 88);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(112, 25);
            this.lblDataPagamento.TabIndex = 38;
            this.lblDataPagamento.Text = "Data Pagamento:";
            // 
            // dtMultaPaga
            // 
            this.dtMultaPaga.CustomFormat = "dd/mm/yyyy";
            this.dtMultaPaga.Enabled = false;
            this.dtMultaPaga.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtMultaPaga.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMultaPaga.Location = new System.Drawing.Point(412, 116);
            this.dtMultaPaga.Name = "dtMultaPaga";
            this.dtMultaPaga.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtMultaPaga.Size = new System.Drawing.Size(197, 31);
            this.dtMultaPaga.TabIndex = 20;
            // 
            // rdNaoPaga
            // 
            this.rdNaoPaga.AutoSize = true;
            this.rdNaoPaga.Location = new System.Drawing.Point(319, 128);
            this.rdNaoPaga.Name = "rdNaoPaga";
            this.rdNaoPaga.Size = new System.Drawing.Size(87, 29);
            this.rdNaoPaga.TabIndex = 19;
            this.rdNaoPaga.TabStop = true;
            this.rdNaoPaga.Text = "Não Paga";
            this.rdNaoPaga.UseVisualStyleBackColor = true;
            this.rdNaoPaga.CheckedChanged += new System.EventHandler(this.rdNaoPaga_CheckedChanged);
            // 
            // rdPaga
            // 
            this.rdPaga.AutoSize = true;
            this.rdPaga.Location = new System.Drawing.Point(319, 93);
            this.rdPaga.Name = "rdPaga";
            this.rdPaga.Size = new System.Drawing.Size(60, 29);
            this.rdPaga.TabIndex = 18;
            this.rdPaga.TabStop = true;
            this.rdPaga.Text = "Paga";
            this.rdPaga.UseVisualStyleBackColor = true;
            this.rdPaga.CheckedChanged += new System.EventHandler(this.rdPaga_CheckedChanged);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(307, 26);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(110, 25);
            this.lblCPF.TabIndex = 33;
            this.lblCPF.Text = "CPF - Motorista:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(11, 241);
            this.txtDesc.MaxLength = 150;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(487, 54);
            this.txtDesc.TabIndex = 22;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 213);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 25);
            this.lblDesc.TabIndex = 31;
            this.lblDesc.Text = "Descrição:";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(214, 116);
            this.txtvalor.Mask = "0000000000";
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(99, 32);
            this.txtvalor.TabIndex = 17;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(209, 88);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 25);
            this.lblValor.TabIndex = 29;
            this.lblValor.Text = "Valor:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(11, 178);
            this.txtLocal.MaxLength = 150;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(487, 32);
            this.txtLocal.TabIndex = 21;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(6, 88);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 25);
            this.lblData.TabIndex = 27;
            this.lblData.Text = "Data:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(6, 150);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(45, 25);
            this.lblLocal.TabIndex = 26;
            this.lblLocal.Text = "Local:";
            // 
            // dtDataMulta
            // 
            this.dtDataMulta.CustomFormat = "dd/mm/yyyy";
            this.dtDataMulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataMulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataMulta.Location = new System.Drawing.Point(11, 116);
            this.dtDataMulta.Name = "dtDataMulta";
            this.dtDataMulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataMulta.Size = new System.Drawing.Size(197, 31);
            this.dtDataMulta.TabIndex = 16;
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
            this.btnExcluirVeiculo.Location = new System.Drawing.Point(244, 399);
            this.btnExcluirVeiculo.Name = "btnExcluirVeiculo";
            this.btnExcluirVeiculo.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirVeiculo.TabIndex = 25;
            this.btnExcluirVeiculo.Text = "Excluir";
            this.btnExcluirVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirVeiculo.UseVisualStyleBackColor = false;
            this.btnExcluirVeiculo.Click += new System.EventHandler(this.btnExcluirVeiculo_Click);
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
            this.btnAlterarVeiculo.Location = new System.Drawing.Point(244, 353);
            this.btnAlterarVeiculo.Name = "btnAlterarVeiculo";
            this.btnAlterarVeiculo.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarVeiculo.TabIndex = 24;
            this.btnAlterarVeiculo.Text = "Alterar";
            this.btnAlterarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarVeiculo.UseVisualStyleBackColor = false;
            this.btnAlterarVeiculo.Click += new System.EventHandler(this.btnAlterarVeiculo_Click);
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
            this.btnCadastrarVeiculo.Location = new System.Drawing.Point(121, 307);
            this.btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            this.btnCadastrarVeiculo.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarVeiculo.TabIndex = 23;
            this.btnCadastrarVeiculo.Text = "Cadastrar";
            this.btnCadastrarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarVeiculo.UseVisualStyleBackColor = false;
            this.btnCadastrarVeiculo.Click += new System.EventHandler(this.btnCadastrarVeiculo_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(6, 26);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(104, 25);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Veiculo - Placa:";
            // 
            // tbPageConsultaMultas
            // 
            this.tbPageConsultaMultas.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaMultas.Controls.Add(this.gbConsultaMultas);
            this.tbPageConsultaMultas.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaMultas.Name = "tbPageConsultaMultas";
            this.tbPageConsultaMultas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaMultas.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaMultas.TabIndex = 1;
            this.tbPageConsultaMultas.Text = "Consultar";
            // 
            // gbConsultaMultas
            // 
            this.gbConsultaMultas.Controls.Add(this.panelConsultarPorData);
            this.gbConsultaMultas.Controls.Add(this.cbCPFMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.cbPlacaMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.lblCPFMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.lblDataMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.dtDataMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.lblPlacaMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.btnTrasferirMultas);
            this.gbConsultaMultas.Controls.Add(this.dgMultasConsulta);
            this.gbConsultaMultas.Controls.Add(this.btnTodosMultas);
            this.gbConsultaMultas.Controls.Add(this.btnConsultarMultas);
            this.gbConsultaMultas.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaMultas.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaMultas.Name = "gbConsultaMultas";
            this.gbConsultaMultas.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaMultas.TabIndex = 2;
            this.gbConsultaMultas.TabStop = false;
            this.gbConsultaMultas.Text = "Consulta";
            // 
            // panelConsultarPorData
            // 
            this.panelConsultarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelConsultarPorData.Controls.Add(this.gbData);
            this.panelConsultarPorData.Location = new System.Drawing.Point(438, 70);
            this.panelConsultarPorData.Name = "panelConsultarPorData";
            this.panelConsultarPorData.Size = new System.Drawing.Size(177, 213);
            this.panelConsultarPorData.TabIndex = 36;
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
            // cbCPFMultasConsulta
            // 
            this.cbCPFMultasConsulta.FormattingEnabled = true;
            this.cbCPFMultasConsulta.Location = new System.Drawing.Point(122, 67);
            this.cbCPFMultasConsulta.Name = "cbCPFMultasConsulta";
            this.cbCPFMultasConsulta.Size = new System.Drawing.Size(297, 33);
            this.cbCPFMultasConsulta.TabIndex = 15;
            // 
            // cbPlacaMultasConsulta
            // 
            this.cbPlacaMultasConsulta.FormattingEnabled = true;
            this.cbPlacaMultasConsulta.Location = new System.Drawing.Point(122, 28);
            this.cbPlacaMultasConsulta.Name = "cbPlacaMultasConsulta";
            this.cbPlacaMultasConsulta.Size = new System.Drawing.Size(297, 33);
            this.cbPlacaMultasConsulta.TabIndex = 14;
            // 
            // lblCPFMultasConsulta
            // 
            this.lblCPFMultasConsulta.AutoSize = true;
            this.lblCPFMultasConsulta.Location = new System.Drawing.Point(6, 70);
            this.lblCPFMultasConsulta.Name = "lblCPFMultasConsulta";
            this.lblCPFMultasConsulta.Size = new System.Drawing.Size(110, 25);
            this.lblCPFMultasConsulta.TabIndex = 39;
            this.lblCPFMultasConsulta.Text = "CPF - Motorista:";
            // 
            // lblDataMultasConsulta
            // 
            this.lblDataMultasConsulta.AutoSize = true;
            this.lblDataMultasConsulta.Location = new System.Drawing.Point(74, 106);
            this.lblDataMultasConsulta.Name = "lblDataMultasConsulta";
            this.lblDataMultasConsulta.Size = new System.Drawing.Size(42, 25);
            this.lblDataMultasConsulta.TabIndex = 38;
            this.lblDataMultasConsulta.Text = "Data:";
            // 
            // dtDataMultasConsulta
            // 
            this.dtDataMultasConsulta.CustomFormat = "dd/mm/yyyy";
            this.dtDataMultasConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataMultasConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataMultasConsulta.Location = new System.Drawing.Point(122, 106);
            this.dtDataMultasConsulta.Name = "dtDataMultasConsulta";
            this.dtDataMultasConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataMultasConsulta.Size = new System.Drawing.Size(200, 31);
            this.dtDataMultasConsulta.TabIndex = 16;
            // 
            // lblPlacaMultasConsulta
            // 
            this.lblPlacaMultasConsulta.AutoSize = true;
            this.lblPlacaMultasConsulta.Location = new System.Drawing.Point(12, 31);
            this.lblPlacaMultasConsulta.Name = "lblPlacaMultasConsulta";
            this.lblPlacaMultasConsulta.Size = new System.Drawing.Size(104, 25);
            this.lblPlacaMultasConsulta.TabIndex = 35;
            this.lblPlacaMultasConsulta.Text = "Veiculo - Placa:";
            // 
            // btnTrasferirMultas
            // 
            this.btnTrasferirMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirMultas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirMultas.BackgroundImage")));
            this.btnTrasferirMultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirMultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrasferirMultas.FlatAppearance.BorderSize = 0;
            this.btnTrasferirMultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirMultas.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirMultas.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirMultas.Location = new System.Drawing.Point(577, 24);
            this.btnTrasferirMultas.Name = "btnTrasferirMultas";
            this.btnTrasferirMultas.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirMultas.TabIndex = 19;
            this.btnTrasferirMultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirMultas.UseVisualStyleBackColor = false;
            this.btnTrasferirMultas.Click += new System.EventHandler(this.btnTrasferirMultas_Click);
            // 
            // dgMultasConsulta
            // 
            this.dgMultasConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgMultasConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMultasConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgMultasConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgMultasConsulta.Location = new System.Drawing.Point(7, 143);
            this.dgMultasConsulta.Name = "dgMultasConsulta";
            this.dgMultasConsulta.ReadOnly = true;
            this.dgMultasConsulta.Size = new System.Drawing.Size(608, 296);
            this.dgMultasConsulta.TabIndex = 20;
            this.dgMultasConsulta.DoubleClick += new System.EventHandler(this.dgMultasConsulta_DoubleClick);
            // 
            // btnTodosMultas
            // 
            this.btnTodosMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosMultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosMultas.FlatAppearance.BorderSize = 0;
            this.btnTodosMultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosMultas.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosMultas.ForeColor = System.Drawing.Color.White;
            this.btnTodosMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosMultas.Location = new System.Drawing.Point(438, 70);
            this.btnTodosMultas.Name = "btnTodosMultas";
            this.btnTodosMultas.Size = new System.Drawing.Size(177, 40);
            this.btnTodosMultas.TabIndex = 18;
            this.btnTodosMultas.Text = "Consultar p/ Data";
            this.btnTodosMultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosMultas.UseVisualStyleBackColor = false;
            this.btnTodosMultas.Click += new System.EventHandler(this.btnTodosMultas_Click);
            // 
            // btnConsultarMultas
            // 
            this.btnConsultarMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarMultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarMultas.FlatAppearance.BorderSize = 0;
            this.btnConsultarMultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarMultas.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarMultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultarMultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarMultas.Image")));
            this.btnConsultarMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarMultas.Location = new System.Drawing.Point(425, 24);
            this.btnConsultarMultas.Name = "btnConsultarMultas";
            this.btnConsultarMultas.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarMultas.TabIndex = 17;
            this.btnConsultarMultas.Text = "    Consultar";
            this.btnConsultarMultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarMultas.UseVisualStyleBackColor = false;
            this.btnConsultarMultas.Click += new System.EventHandler(this.btnConsultarMultas_Click);
            // 
            // Multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlMultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Multas";
            this.Text = "Multas";
            this.Load += new System.EventHandler(this.Multas_Load);
            this.tbControlMultas.ResumeLayout(false);
            this.tbPageCadastroMultas.ResumeLayout(false);
            this.gbDadosMulta.ResumeLayout(false);
            this.gbDadosMulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).EndInit();
            this.tbPageConsultaMultas.ResumeLayout(false);
            this.gbConsultaMultas.ResumeLayout(false);
            this.gbConsultaMultas.PerformLayout();
            this.panelConsultarPorData.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMultasConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlMultas;
        private System.Windows.Forms.TabPage tbPageCadastroMultas;
        private System.Windows.Forms.GroupBox gbDadosMulta;
        private System.Windows.Forms.Button btnExcluirVeiculo;
        private System.Windows.Forms.Button btnAlterarVeiculo;
        private System.Windows.Forms.Button btnCadastrarVeiculo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TabPage tbPageConsultaMultas;
        private System.Windows.Forms.GroupBox gbConsultaMultas;
        private System.Windows.Forms.Button btnTrasferirMultas;
        private System.Windows.Forms.DataGridView dgMultasConsulta;
        private System.Windows.Forms.Button btnTodosMultas;
        private System.Windows.Forms.Button btnConsultarMultas;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.DateTimePicker dtMultaPaga;
        private System.Windows.Forms.RadioButton rdNaoPaga;
        private System.Windows.Forms.RadioButton rdPaga;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.MaskedTextBox txtvalor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.DateTimePicker dtDataMulta;
        private System.Windows.Forms.Label lblCPFMultasConsulta;
        private System.Windows.Forms.Label lblDataMultasConsulta;
        private System.Windows.Forms.DateTimePicker dtDataMultasConsulta;
        private System.Windows.Forms.Label lblPlacaMultasConsulta;
        private System.Windows.Forms.ComboBox cbCPF;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.ComboBox cbCPFMultasConsulta;
        private System.Windows.Forms.ComboBox cbPlacaMultasConsulta;
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