namespace CamadaDesktop
{
    partial class Seguros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seguros));
            this.tbControlSeguros = new System.Windows.Forms.TabControl();
            this.tbPageCadastroSeguros = new System.Windows.Forms.TabPage();
            this.gbDadosSeguros = new System.Windows.Forms.GroupBox();
            this.cbFranquia = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtValorFranquia = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtfimvigencia = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFranquia = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbItemSegurado = new System.Windows.Forms.ComboBox();
            this.cbSeguradora = new System.Windows.Forms.ComboBox();
            this.lblItemSegurado = new System.Windows.Forms.Label();
            this.lblSeguradora = new System.Windows.Forms.Label();
            this.txtNApolice = new System.Windows.Forms.TextBox();
            this.lblNApólice = new System.Windows.Forms.Label();
            this.btnExcluirSeguros = new System.Windows.Forms.Button();
            this.btnAlterarSeguros = new System.Windows.Forms.Button();
            this.btnCadastrarSeguros = new System.Windows.Forms.Button();
            this.tbPageConsultaSeguros = new System.Windows.Forms.TabPage();
            this.gbConsultaSeguros = new System.Windows.Forms.GroupBox();
            this.txtNApoliceConsulta = new System.Windows.Forms.TextBox();
            this.lblNApoliceConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirSeguros = new System.Windows.Forms.Button();
            this.dgSegurosConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosSeguros = new System.Windows.Forms.Button();
            this.btnConsultarSeguros = new System.Windows.Forms.Button();
            this.tbPageCobertura = new System.Windows.Forms.TabPage();
            this.gbDadosCobertura = new System.Windows.Forms.GroupBox();
            this.txtCoberturaDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricaoCobertura = new System.Windows.Forms.Label();
            this.btnExcluirCobertura = new System.Windows.Forms.Button();
            this.btnAlterarCobertura = new System.Windows.Forms.Button();
            this.btnCadastrarCobertura = new System.Windows.Forms.Button();
            this.cbTipoCobertura = new System.Windows.Forms.ComboBox();
            this.lblTipoCobertura = new System.Windows.Forms.Label();
            this.txtNApoliceCobertura = new System.Windows.Forms.TextBox();
            this.lblNApoliceCobertura = new System.Windows.Forms.Label();
            this.gbConsultaCobertura = new System.Windows.Forms.GroupBox();
            this.btnTransfereCobertura = new System.Windows.Forms.Button();
            this.dgCoberturaConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsultaTodosCobertura = new System.Windows.Forms.Button();
            this.btnConsultaCobertura = new System.Windows.Forms.Button();
            this.lblNApoliceCoberturaConsulta = new System.Windows.Forms.Label();
            this.txtNApoliceCoberturaConsulta = new System.Windows.Forms.TextBox();
            this.cbTipoCoberturaConsulta = new System.Windows.Forms.ComboBox();
            this.lblTipoCoberturaConsulta = new System.Windows.Forms.Label();
            this.tbControlSeguros.SuspendLayout();
            this.tbPageCadastroSeguros.SuspendLayout();
            this.gbDadosSeguros.SuspendLayout();
            this.tbPageConsultaSeguros.SuspendLayout();
            this.gbConsultaSeguros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSegurosConsulta)).BeginInit();
            this.tbPageCobertura.SuspendLayout();
            this.gbDadosCobertura.SuspendLayout();
            this.gbConsultaCobertura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCoberturaConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlSeguros
            // 
            this.tbControlSeguros.Controls.Add(this.tbPageCadastroSeguros);
            this.tbControlSeguros.Controls.Add(this.tbPageConsultaSeguros);
            this.tbControlSeguros.Controls.Add(this.tbPageCobertura);
            this.tbControlSeguros.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlSeguros.Location = new System.Drawing.Point(1, 24);
            this.tbControlSeguros.Name = "tbControlSeguros";
            this.tbControlSeguros.SelectedIndex = 0;
            this.tbControlSeguros.Size = new System.Drawing.Size(644, 498);
            this.tbControlSeguros.TabIndex = 30;
            // 
            // tbPageCadastroSeguros
            // 
            this.tbPageCadastroSeguros.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroSeguros.Controls.Add(this.gbDadosSeguros);
            this.tbPageCadastroSeguros.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroSeguros.Name = "tbPageCadastroSeguros";
            this.tbPageCadastroSeguros.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroSeguros.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroSeguros.TabIndex = 0;
            this.tbPageCadastroSeguros.Text = "Cadastrar";
            // 
            // gbDadosSeguros
            // 
            this.gbDadosSeguros.Controls.Add(this.cbFranquia);
            this.gbDadosSeguros.Controls.Add(this.cbTipo);
            this.gbDadosSeguros.Controls.Add(this.txtValorFranquia);
            this.gbDadosSeguros.Controls.Add(this.label2);
            this.gbDadosSeguros.Controls.Add(this.label1);
            this.gbDadosSeguros.Controls.Add(this.lblDataInicio);
            this.gbDadosSeguros.Controls.Add(this.dtfimvigencia);
            this.gbDadosSeguros.Controls.Add(this.dtInicio);
            this.gbDadosSeguros.Controls.Add(this.lblFranquia);
            this.gbDadosSeguros.Controls.Add(this.txtValor);
            this.gbDadosSeguros.Controls.Add(this.lblValor);
            this.gbDadosSeguros.Controls.Add(this.lblTipo);
            this.gbDadosSeguros.Controls.Add(this.cbItemSegurado);
            this.gbDadosSeguros.Controls.Add(this.cbSeguradora);
            this.gbDadosSeguros.Controls.Add(this.lblItemSegurado);
            this.gbDadosSeguros.Controls.Add(this.lblSeguradora);
            this.gbDadosSeguros.Controls.Add(this.txtNApolice);
            this.gbDadosSeguros.Controls.Add(this.lblNApólice);
            this.gbDadosSeguros.Controls.Add(this.btnExcluirSeguros);
            this.gbDadosSeguros.Controls.Add(this.btnAlterarSeguros);
            this.gbDadosSeguros.Controls.Add(this.btnCadastrarSeguros);
            this.gbDadosSeguros.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosSeguros.Location = new System.Drawing.Point(6, 6);
            this.gbDadosSeguros.Name = "gbDadosSeguros";
            this.gbDadosSeguros.Size = new System.Drawing.Size(621, 445);
            this.gbDadosSeguros.TabIndex = 1;
            this.gbDadosSeguros.TabStop = false;
            this.gbDadosSeguros.Text = "Dados";
            // 
            // cbFranquia
            // 
            this.cbFranquia.Enabled = false;
            this.cbFranquia.FormattingEnabled = true;
            this.cbFranquia.Items.AddRange(new object[] {
            "Normal",
            "Majorada",
            "Reduzida",
            "Isenta"});
            this.cbFranquia.Location = new System.Drawing.Point(11, 243);
            this.cbFranquia.Name = "cbFranquia";
            this.cbFranquia.Size = new System.Drawing.Size(197, 33);
            this.cbFranquia.TabIndex = 63;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(14, 55);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(197, 33);
            this.cbTipo.TabIndex = 62;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.CbTipo_SelectedIndexChanged);
            // 
            // txtValorFranquia
            // 
            this.txtValorFranquia.Enabled = false;
            this.txtValorFranquia.Location = new System.Drawing.Point(214, 244);
            this.txtValorFranquia.Mask = "0000000000";
            this.txtValorFranquia.Name = "txtValorFranquia";
            this.txtValorFranquia.Size = new System.Drawing.Size(197, 32);
            this.txtValorFranquia.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Valor Franquia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Fim Vigência:";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(6, 154);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(77, 25);
            this.lblDataInicio.TabIndex = 59;
            this.lblDataInicio.Text = "Data Inicio:";
            // 
            // dtfimvigencia
            // 
            this.dtfimvigencia.CustomFormat = "dd/mm/yyyy";
            this.dtfimvigencia.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtfimvigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfimvigencia.Location = new System.Drawing.Point(301, 182);
            this.dtfimvigencia.Name = "dtfimvigencia";
            this.dtfimvigencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtfimvigencia.Size = new System.Drawing.Size(284, 31);
            this.dtfimvigencia.TabIndex = 21;
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/mm/yyyy";
            this.dtInicio.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(11, 182);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtInicio.Size = new System.Drawing.Size(284, 31);
            this.dtInicio.TabIndex = 20;
            // 
            // lblFranquia
            // 
            this.lblFranquia.AutoSize = true;
            this.lblFranquia.Location = new System.Drawing.Point(6, 216);
            this.lblFranquia.Name = "lblFranquia";
            this.lblFranquia.Size = new System.Drawing.Size(67, 25);
            this.lblFranquia.TabIndex = 55;
            this.lblFranquia.Text = "Franquia:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(420, 120);
            this.txtValor.Mask = "0000000000";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(197, 32);
            this.txtValor.TabIndex = 18;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(412, 91);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 25);
            this.lblValor.TabIndex = 53;
            this.lblValor.Text = "Valor:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(9, 27);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 25);
            this.lblTipo.TabIndex = 51;
            this.lblTipo.Text = "Tipo:";
            // 
            // cbItemSegurado
            // 
            this.cbItemSegurado.FormattingEnabled = true;
            this.cbItemSegurado.Location = new System.Drawing.Point(217, 120);
            this.cbItemSegurado.Name = "cbItemSegurado";
            this.cbItemSegurado.Size = new System.Drawing.Size(197, 33);
            this.cbItemSegurado.TabIndex = 16;
            // 
            // cbSeguradora
            // 
            this.cbSeguradora.FormattingEnabled = true;
            this.cbSeguradora.Location = new System.Drawing.Point(217, 55);
            this.cbSeguradora.Name = "cbSeguradora";
            this.cbSeguradora.Size = new System.Drawing.Size(197, 33);
            this.cbSeguradora.TabIndex = 15;
            // 
            // lblItemSegurado
            // 
            this.lblItemSegurado.AutoSize = true;
            this.lblItemSegurado.Location = new System.Drawing.Point(212, 91);
            this.lblItemSegurado.Name = "lblItemSegurado";
            this.lblItemSegurado.Size = new System.Drawing.Size(102, 25);
            this.lblItemSegurado.TabIndex = 45;
            this.lblItemSegurado.Text = "Item Segurado:";
            // 
            // lblSeguradora
            // 
            this.lblSeguradora.AutoSize = true;
            this.lblSeguradora.Location = new System.Drawing.Point(212, 27);
            this.lblSeguradora.Name = "lblSeguradora";
            this.lblSeguradora.Size = new System.Drawing.Size(85, 25);
            this.lblSeguradora.TabIndex = 39;
            this.lblSeguradora.Text = "Seguradora:";
            // 
            // txtNApolice
            // 
            this.txtNApolice.Location = new System.Drawing.Point(14, 120);
            this.txtNApolice.Name = "txtNApolice";
            this.txtNApolice.Size = new System.Drawing.Size(197, 32);
            this.txtNApolice.TabIndex = 14;
            // 
            // lblNApólice
            // 
            this.lblNApólice.AutoSize = true;
            this.lblNApólice.Location = new System.Drawing.Point(9, 91);
            this.lblNApólice.Name = "lblNApólice";
            this.lblNApólice.Size = new System.Drawing.Size(77, 25);
            this.lblNApólice.TabIndex = 37;
            this.lblNApólice.Text = "Nº Apólice:";
            // 
            // btnExcluirSeguros
            // 
            this.btnExcluirSeguros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirSeguros.FlatAppearance.BorderSize = 0;
            this.btnExcluirSeguros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirSeguros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirSeguros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirSeguros.ForeColor = System.Drawing.Color.White;
            this.btnExcluirSeguros.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirSeguros.Image")));
            this.btnExcluirSeguros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirSeguros.Location = new System.Drawing.Point(244, 399);
            this.btnExcluirSeguros.Name = "btnExcluirSeguros";
            this.btnExcluirSeguros.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirSeguros.TabIndex = 25;
            this.btnExcluirSeguros.Text = "Excluir";
            this.btnExcluirSeguros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirSeguros.UseVisualStyleBackColor = false;
            // 
            // btnAlterarSeguros
            // 
            this.btnAlterarSeguros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarSeguros.FlatAppearance.BorderSize = 0;
            this.btnAlterarSeguros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarSeguros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSeguros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSeguros.ForeColor = System.Drawing.Color.White;
            this.btnAlterarSeguros.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarSeguros.Image")));
            this.btnAlterarSeguros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarSeguros.Location = new System.Drawing.Point(244, 353);
            this.btnAlterarSeguros.Name = "btnAlterarSeguros";
            this.btnAlterarSeguros.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarSeguros.TabIndex = 24;
            this.btnAlterarSeguros.Text = "Alterar";
            this.btnAlterarSeguros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarSeguros.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarSeguros
            // 
            this.btnCadastrarSeguros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarSeguros.FlatAppearance.BorderSize = 0;
            this.btnCadastrarSeguros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarSeguros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSeguros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSeguros.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarSeguros.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarSeguros.Image")));
            this.btnCadastrarSeguros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarSeguros.Location = new System.Drawing.Point(120, 307);
            this.btnCadastrarSeguros.Name = "btnCadastrarSeguros";
            this.btnCadastrarSeguros.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarSeguros.TabIndex = 23;
            this.btnCadastrarSeguros.Text = "Cadastrar";
            this.btnCadastrarSeguros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarSeguros.UseVisualStyleBackColor = false;
            this.btnCadastrarSeguros.Click += new System.EventHandler(this.BtnCadastrarSeguros_Click);
            // 
            // tbPageConsultaSeguros
            // 
            this.tbPageConsultaSeguros.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaSeguros.Controls.Add(this.gbConsultaSeguros);
            this.tbPageConsultaSeguros.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaSeguros.Name = "tbPageConsultaSeguros";
            this.tbPageConsultaSeguros.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaSeguros.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaSeguros.TabIndex = 1;
            this.tbPageConsultaSeguros.Text = "Consultar";
            // 
            // gbConsultaSeguros
            // 
            this.gbConsultaSeguros.Controls.Add(this.txtNApoliceConsulta);
            this.gbConsultaSeguros.Controls.Add(this.lblNApoliceConsulta);
            this.gbConsultaSeguros.Controls.Add(this.btnTrasferirSeguros);
            this.gbConsultaSeguros.Controls.Add(this.dgSegurosConsulta);
            this.gbConsultaSeguros.Controls.Add(this.btnTodosSeguros);
            this.gbConsultaSeguros.Controls.Add(this.btnConsultarSeguros);
            this.gbConsultaSeguros.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaSeguros.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaSeguros.Name = "gbConsultaSeguros";
            this.gbConsultaSeguros.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaSeguros.TabIndex = 2;
            this.gbConsultaSeguros.TabStop = false;
            this.gbConsultaSeguros.Text = "Consulta";
            // 
            // txtNApoliceConsulta
            // 
            this.txtNApoliceConsulta.Location = new System.Drawing.Point(82, 27);
            this.txtNApoliceConsulta.Name = "txtNApoliceConsulta";
            this.txtNApoliceConsulta.Size = new System.Drawing.Size(172, 32);
            this.txtNApoliceConsulta.TabIndex = 14;
            // 
            // lblNApoliceConsulta
            // 
            this.lblNApoliceConsulta.AutoSize = true;
            this.lblNApoliceConsulta.Location = new System.Drawing.Point(6, 30);
            this.lblNApoliceConsulta.Name = "lblNApoliceConsulta";
            this.lblNApoliceConsulta.Size = new System.Drawing.Size(77, 25);
            this.lblNApoliceConsulta.TabIndex = 41;
            this.lblNApoliceConsulta.Text = "Nº Apólice:";
            // 
            // btnTrasferirSeguros
            // 
            this.btnTrasferirSeguros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirSeguros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirSeguros.BackgroundImage")));
            this.btnTrasferirSeguros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirSeguros.FlatAppearance.BorderSize = 0;
            this.btnTrasferirSeguros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirSeguros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirSeguros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirSeguros.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirSeguros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirSeguros.Location = new System.Drawing.Point(577, 21);
            this.btnTrasferirSeguros.Name = "btnTrasferirSeguros";
            this.btnTrasferirSeguros.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirSeguros.TabIndex = 17;
            this.btnTrasferirSeguros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirSeguros.UseVisualStyleBackColor = false;
            // 
            // dgSegurosConsulta
            // 
            this.dgSegurosConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgSegurosConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSegurosConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgSegurosConsulta.Location = new System.Drawing.Point(7, 67);
            this.dgSegurosConsulta.Name = "dgSegurosConsulta";
            this.dgSegurosConsulta.Size = new System.Drawing.Size(608, 372);
            this.dgSegurosConsulta.TabIndex = 18;
            // 
            // btnTodosSeguros
            // 
            this.btnTodosSeguros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosSeguros.FlatAppearance.BorderSize = 0;
            this.btnTodosSeguros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosSeguros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosSeguros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosSeguros.ForeColor = System.Drawing.Color.White;
            this.btnTodosSeguros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosSeguros.Location = new System.Drawing.Point(412, 21);
            this.btnTodosSeguros.Name = "btnTodosSeguros";
            this.btnTodosSeguros.Size = new System.Drawing.Size(159, 40);
            this.btnTodosSeguros.TabIndex = 16;
            this.btnTodosSeguros.Text = "Consultar Todos";
            this.btnTodosSeguros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosSeguros.UseVisualStyleBackColor = false;
            // 
            // btnConsultarSeguros
            // 
            this.btnConsultarSeguros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarSeguros.FlatAppearance.BorderSize = 0;
            this.btnConsultarSeguros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarSeguros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarSeguros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarSeguros.ForeColor = System.Drawing.Color.White;
            this.btnConsultarSeguros.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarSeguros.Image")));
            this.btnConsultarSeguros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarSeguros.Location = new System.Drawing.Point(260, 21);
            this.btnConsultarSeguros.Name = "btnConsultarSeguros";
            this.btnConsultarSeguros.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarSeguros.TabIndex = 15;
            this.btnConsultarSeguros.Text = "    Consultar";
            this.btnConsultarSeguros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarSeguros.UseVisualStyleBackColor = false;
            // 
            // tbPageCobertura
            // 
            this.tbPageCobertura.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCobertura.Controls.Add(this.gbConsultaCobertura);
            this.tbPageCobertura.Controls.Add(this.gbDadosCobertura);
            this.tbPageCobertura.Location = new System.Drawing.Point(4, 37);
            this.tbPageCobertura.Name = "tbPageCobertura";
            this.tbPageCobertura.Size = new System.Drawing.Size(636, 457);
            this.tbPageCobertura.TabIndex = 2;
            this.tbPageCobertura.Text = "Cobertura";
            // 
            // gbDadosCobertura
            // 
            this.gbDadosCobertura.Controls.Add(this.cbTipoCobertura);
            this.gbDadosCobertura.Controls.Add(this.lblTipoCobertura);
            this.gbDadosCobertura.Controls.Add(this.txtNApoliceCobertura);
            this.gbDadosCobertura.Controls.Add(this.lblNApoliceCobertura);
            this.gbDadosCobertura.Controls.Add(this.txtCoberturaDescricao);
            this.gbDadosCobertura.Controls.Add(this.lblDescricaoCobertura);
            this.gbDadosCobertura.Controls.Add(this.btnExcluirCobertura);
            this.gbDadosCobertura.Controls.Add(this.btnAlterarCobertura);
            this.gbDadosCobertura.Controls.Add(this.btnCadastrarCobertura);
            this.gbDadosCobertura.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosCobertura.Location = new System.Drawing.Point(6, 6);
            this.gbDadosCobertura.Name = "gbDadosCobertura";
            this.gbDadosCobertura.Size = new System.Drawing.Size(621, 204);
            this.gbDadosCobertura.TabIndex = 24;
            this.gbDadosCobertura.TabStop = false;
            this.gbDadosCobertura.Text = "Dados";
            // 
            // txtCoberturaDescricao
            // 
            this.txtCoberturaDescricao.Location = new System.Drawing.Point(11, 119);
            this.txtCoberturaDescricao.Multiline = true;
            this.txtCoberturaDescricao.Name = "txtCoberturaDescricao";
            this.txtCoberturaDescricao.Size = new System.Drawing.Size(421, 76);
            this.txtCoberturaDescricao.TabIndex = 16;
            // 
            // lblDescricaoCobertura
            // 
            this.lblDescricaoCobertura.AutoSize = true;
            this.lblDescricaoCobertura.Location = new System.Drawing.Point(6, 91);
            this.lblDescricaoCobertura.Name = "lblDescricaoCobertura";
            this.lblDescricaoCobertura.Size = new System.Drawing.Size(75, 25);
            this.lblDescricaoCobertura.TabIndex = 23;
            this.lblDescricaoCobertura.Text = "Descrição:";
            // 
            // btnExcluirCobertura
            // 
            this.btnExcluirCobertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirCobertura.FlatAppearance.BorderSize = 0;
            this.btnExcluirCobertura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirCobertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCobertura.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCobertura.ForeColor = System.Drawing.Color.White;
            this.btnExcluirCobertura.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCobertura.Image")));
            this.btnExcluirCobertura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCobertura.Location = new System.Drawing.Point(469, 155);
            this.btnExcluirCobertura.Name = "btnExcluirCobertura";
            this.btnExcluirCobertura.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirCobertura.TabIndex = 19;
            this.btnExcluirCobertura.Text = "Excluir";
            this.btnExcluirCobertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirCobertura.UseVisualStyleBackColor = false;
            // 
            // btnAlterarCobertura
            // 
            this.btnAlterarCobertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarCobertura.FlatAppearance.BorderSize = 0;
            this.btnAlterarCobertura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarCobertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarCobertura.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCobertura.ForeColor = System.Drawing.Color.White;
            this.btnAlterarCobertura.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarCobertura.Image")));
            this.btnAlterarCobertura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarCobertura.Location = new System.Drawing.Point(469, 109);
            this.btnAlterarCobertura.Name = "btnAlterarCobertura";
            this.btnAlterarCobertura.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarCobertura.TabIndex = 18;
            this.btnAlterarCobertura.Text = "Alterar";
            this.btnAlterarCobertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarCobertura.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarCobertura
            // 
            this.btnCadastrarCobertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarCobertura.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCobertura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarCobertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCobertura.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCobertura.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCobertura.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCobertura.Image")));
            this.btnCadastrarCobertura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarCobertura.Location = new System.Drawing.Point(469, 63);
            this.btnCadastrarCobertura.Name = "btnCadastrarCobertura";
            this.btnCadastrarCobertura.Size = new System.Drawing.Size(146, 40);
            this.btnCadastrarCobertura.TabIndex = 17;
            this.btnCadastrarCobertura.Text = "     Cadastrar";
            this.btnCadastrarCobertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarCobertura.UseVisualStyleBackColor = false;
            // 
            // cbTipoCobertura
            // 
            this.cbTipoCobertura.FormattingEnabled = true;
            this.cbTipoCobertura.Location = new System.Drawing.Point(11, 55);
            this.cbTipoCobertura.Name = "cbTipoCobertura";
            this.cbTipoCobertura.Size = new System.Drawing.Size(197, 33);
            this.cbTipoCobertura.TabIndex = 14;
            // 
            // lblTipoCobertura
            // 
            this.lblTipoCobertura.AutoSize = true;
            this.lblTipoCobertura.Location = new System.Drawing.Point(6, 28);
            this.lblTipoCobertura.Name = "lblTipoCobertura";
            this.lblTipoCobertura.Size = new System.Drawing.Size(38, 25);
            this.lblTipoCobertura.TabIndex = 65;
            this.lblTipoCobertura.Text = "Tipo:";
            // 
            // txtNApoliceCobertura
            // 
            this.txtNApoliceCobertura.Location = new System.Drawing.Point(214, 56);
            this.txtNApoliceCobertura.Name = "txtNApoliceCobertura";
            this.txtNApoliceCobertura.Size = new System.Drawing.Size(197, 32);
            this.txtNApoliceCobertura.TabIndex = 15;
            // 
            // lblNApoliceCobertura
            // 
            this.lblNApoliceCobertura.AutoSize = true;
            this.lblNApoliceCobertura.Location = new System.Drawing.Point(209, 28);
            this.lblNApoliceCobertura.Name = "lblNApoliceCobertura";
            this.lblNApoliceCobertura.Size = new System.Drawing.Size(77, 25);
            this.lblNApoliceCobertura.TabIndex = 64;
            this.lblNApoliceCobertura.Text = "Nº Apólice:";
            // 
            // gbConsultaCobertura
            // 
            this.gbConsultaCobertura.Controls.Add(this.lblTipoCoberturaConsulta);
            this.gbConsultaCobertura.Controls.Add(this.cbTipoCoberturaConsulta);
            this.gbConsultaCobertura.Controls.Add(this.txtNApoliceCoberturaConsulta);
            this.gbConsultaCobertura.Controls.Add(this.lblNApoliceCoberturaConsulta);
            this.gbConsultaCobertura.Controls.Add(this.btnTransfereCobertura);
            this.gbConsultaCobertura.Controls.Add(this.dgCoberturaConsulta);
            this.gbConsultaCobertura.Controls.Add(this.btnConsultaTodosCobertura);
            this.gbConsultaCobertura.Controls.Add(this.btnConsultaCobertura);
            this.gbConsultaCobertura.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaCobertura.Location = new System.Drawing.Point(6, 216);
            this.gbConsultaCobertura.Name = "gbConsultaCobertura";
            this.gbConsultaCobertura.Size = new System.Drawing.Size(621, 238);
            this.gbConsultaCobertura.TabIndex = 26;
            this.gbConsultaCobertura.TabStop = false;
            this.gbConsultaCobertura.Text = "Consulta";
            // 
            // btnTransfereCobertura
            // 
            this.btnTransfereCobertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTransfereCobertura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransfereCobertura.BackgroundImage")));
            this.btnTransfereCobertura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransfereCobertura.FlatAppearance.BorderSize = 0;
            this.btnTransfereCobertura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTransfereCobertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfereCobertura.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfereCobertura.ForeColor = System.Drawing.Color.White;
            this.btnTransfereCobertura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfereCobertura.Location = new System.Drawing.Point(577, 19);
            this.btnTransfereCobertura.Name = "btnTransfereCobertura";
            this.btnTransfereCobertura.Size = new System.Drawing.Size(38, 40);
            this.btnTransfereCobertura.TabIndex = 24;
            this.btnTransfereCobertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransfereCobertura.UseVisualStyleBackColor = false;
            // 
            // dgCoberturaConsulta
            // 
            this.dgCoberturaConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgCoberturaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCoberturaConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgCoberturaConsulta.Location = new System.Drawing.Point(7, 65);
            this.dgCoberturaConsulta.Name = "dgCoberturaConsulta";
            this.dgCoberturaConsulta.Size = new System.Drawing.Size(443, 167);
            this.dgCoberturaConsulta.TabIndex = 25;
            // 
            // btnConsultaTodosCobertura
            // 
            this.btnConsultaTodosCobertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultaTodosCobertura.FlatAppearance.BorderSize = 0;
            this.btnConsultaTodosCobertura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaTodosCobertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaTodosCobertura.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaTodosCobertura.ForeColor = System.Drawing.Color.White;
            this.btnConsultaTodosCobertura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaTodosCobertura.Location = new System.Drawing.Point(456, 109);
            this.btnConsultaTodosCobertura.Name = "btnConsultaTodosCobertura";
            this.btnConsultaTodosCobertura.Size = new System.Drawing.Size(159, 40);
            this.btnConsultaTodosCobertura.TabIndex = 23;
            this.btnConsultaTodosCobertura.Text = "Consultar Todos";
            this.btnConsultaTodosCobertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultaTodosCobertura.UseVisualStyleBackColor = false;
            // 
            // btnConsultaCobertura
            // 
            this.btnConsultaCobertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultaCobertura.FlatAppearance.BorderSize = 0;
            this.btnConsultaCobertura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaCobertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCobertura.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCobertura.ForeColor = System.Drawing.Color.White;
            this.btnConsultaCobertura.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaCobertura.Image")));
            this.btnConsultaCobertura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaCobertura.Location = new System.Drawing.Point(456, 65);
            this.btnConsultaCobertura.Name = "btnConsultaCobertura";
            this.btnConsultaCobertura.Size = new System.Drawing.Size(159, 40);
            this.btnConsultaCobertura.TabIndex = 22;
            this.btnConsultaCobertura.Text = "    Consultar";
            this.btnConsultaCobertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultaCobertura.UseVisualStyleBackColor = false;
            // 
            // lblNApoliceCoberturaConsulta
            // 
            this.lblNApoliceCoberturaConsulta.AutoSize = true;
            this.lblNApoliceCoberturaConsulta.Location = new System.Drawing.Point(253, 28);
            this.lblNApoliceCoberturaConsulta.Name = "lblNApoliceCoberturaConsulta";
            this.lblNApoliceCoberturaConsulta.Size = new System.Drawing.Size(77, 25);
            this.lblNApoliceCoberturaConsulta.TabIndex = 65;
            this.lblNApoliceCoberturaConsulta.Text = "Nº Apólice:";
            // 
            // txtNApoliceCoberturaConsulta
            // 
            this.txtNApoliceCoberturaConsulta.Location = new System.Drawing.Point(336, 25);
            this.txtNApoliceCoberturaConsulta.Name = "txtNApoliceCoberturaConsulta";
            this.txtNApoliceCoberturaConsulta.Size = new System.Drawing.Size(197, 32);
            this.txtNApoliceCoberturaConsulta.TabIndex = 21;
            // 
            // cbTipoCoberturaConsulta
            // 
            this.cbTipoCoberturaConsulta.FormattingEnabled = true;
            this.cbTipoCoberturaConsulta.Location = new System.Drawing.Point(50, 25);
            this.cbTipoCoberturaConsulta.Name = "cbTipoCoberturaConsulta";
            this.cbTipoCoberturaConsulta.Size = new System.Drawing.Size(197, 33);
            this.cbTipoCoberturaConsulta.TabIndex = 20;
            // 
            // lblTipoCoberturaConsulta
            // 
            this.lblTipoCoberturaConsulta.AutoSize = true;
            this.lblTipoCoberturaConsulta.Location = new System.Drawing.Point(6, 28);
            this.lblTipoCoberturaConsulta.Name = "lblTipoCoberturaConsulta";
            this.lblTipoCoberturaConsulta.Size = new System.Drawing.Size(38, 25);
            this.lblTipoCoberturaConsulta.TabIndex = 67;
            this.lblTipoCoberturaConsulta.Text = "Tipo:";
            // 
            // Seguros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlSeguros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seguros";
            this.Text = "Seguros";
            this.Load += new System.EventHandler(this.Seguros_Load);
            this.tbControlSeguros.ResumeLayout(false);
            this.tbPageCadastroSeguros.ResumeLayout(false);
            this.gbDadosSeguros.ResumeLayout(false);
            this.gbDadosSeguros.PerformLayout();
            this.tbPageConsultaSeguros.ResumeLayout(false);
            this.gbConsultaSeguros.ResumeLayout(false);
            this.gbConsultaSeguros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSegurosConsulta)).EndInit();
            this.tbPageCobertura.ResumeLayout(false);
            this.gbDadosCobertura.ResumeLayout(false);
            this.gbDadosCobertura.PerformLayout();
            this.gbConsultaCobertura.ResumeLayout(false);
            this.gbConsultaCobertura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCoberturaConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlSeguros;
        private System.Windows.Forms.TabPage tbPageCadastroSeguros;
        private System.Windows.Forms.GroupBox gbDadosSeguros;
        private System.Windows.Forms.Label lblItemSegurado;
        private System.Windows.Forms.Label lblSeguradora;
        private System.Windows.Forms.TextBox txtNApolice;
        private System.Windows.Forms.Label lblNApólice;
        private System.Windows.Forms.Button btnExcluirSeguros;
        private System.Windows.Forms.Button btnAlterarSeguros;
        private System.Windows.Forms.Button btnCadastrarSeguros;
        private System.Windows.Forms.TabPage tbPageConsultaSeguros;
        private System.Windows.Forms.GroupBox gbConsultaSeguros;
        private System.Windows.Forms.TextBox txtNApoliceConsulta;
        private System.Windows.Forms.Label lblNApoliceConsulta;
        private System.Windows.Forms.Button btnTrasferirSeguros;
        private System.Windows.Forms.DataGridView dgSegurosConsulta;
        private System.Windows.Forms.Button btnTodosSeguros;
        private System.Windows.Forms.Button btnConsultarSeguros;
        private System.Windows.Forms.ComboBox cbSeguradora;
        private System.Windows.Forms.Label lblFranquia;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbItemSegurado;
        private System.Windows.Forms.MaskedTextBox txtValorFranquia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtfimvigencia;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbFranquia;
        private System.Windows.Forms.TabPage tbPageCobertura;
        private System.Windows.Forms.GroupBox gbDadosCobertura;
        private System.Windows.Forms.TextBox txtCoberturaDescricao;
        private System.Windows.Forms.Label lblDescricaoCobertura;
        private System.Windows.Forms.Button btnExcluirCobertura;
        private System.Windows.Forms.Button btnAlterarCobertura;
        private System.Windows.Forms.Button btnCadastrarCobertura;
        private System.Windows.Forms.ComboBox cbTipoCobertura;
        private System.Windows.Forms.Label lblTipoCobertura;
        private System.Windows.Forms.TextBox txtNApoliceCobertura;
        private System.Windows.Forms.Label lblNApoliceCobertura;
        private System.Windows.Forms.GroupBox gbConsultaCobertura;
        private System.Windows.Forms.Label lblNApoliceCoberturaConsulta;
        private System.Windows.Forms.Button btnTransfereCobertura;
        private System.Windows.Forms.DataGridView dgCoberturaConsulta;
        private System.Windows.Forms.Button btnConsultaTodosCobertura;
        private System.Windows.Forms.Button btnConsultaCobertura;
        private System.Windows.Forms.TextBox txtNApoliceCoberturaConsulta;
        private System.Windows.Forms.Label lblTipoCoberturaConsulta;
        private System.Windows.Forms.ComboBox cbTipoCoberturaConsulta;
    }
}