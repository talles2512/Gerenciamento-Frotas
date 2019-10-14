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
            this.gbDadosFuncionario = new System.Windows.Forms.GroupBox();
            this.lblItemSegurado = new System.Windows.Forms.Label();
            this.lblSeguradora = new System.Windows.Forms.Label();
            this.txtNApolice = new System.Windows.Forms.TextBox();
            this.lblNApólice = new System.Windows.Forms.Label();
            this.btnExcluirSeguros = new System.Windows.Forms.Button();
            this.btnAlterarSeguros = new System.Windows.Forms.Button();
            this.btnCadastrarSeguros = new System.Windows.Forms.Button();
            this.tbPageConsultaSeguros = new System.Windows.Forms.TabPage();
            this.gbConsultaFuncionario = new System.Windows.Forms.GroupBox();
            this.txtNApoliceConsulta = new System.Windows.Forms.TextBox();
            this.lblNApoliceConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirSeguros = new System.Windows.Forms.Button();
            this.dgSegurosConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosSeguros = new System.Windows.Forms.Button();
            this.btnConsultarSeguros = new System.Windows.Forms.Button();
            this.cbSeguradora = new System.Windows.Forms.ComboBox();
            this.cbItemSegurado = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.lblFranquia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtfimvigencia = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorFranquia = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbControlSeguros.SuspendLayout();
            this.tbPageCadastroSeguros.SuspendLayout();
            this.gbDadosFuncionario.SuspendLayout();
            this.tbPageConsultaSeguros.SuspendLayout();
            this.gbConsultaFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSegurosConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlSeguros
            // 
            this.tbControlSeguros.Controls.Add(this.tbPageCadastroSeguros);
            this.tbControlSeguros.Controls.Add(this.tbPageConsultaSeguros);
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
            this.tbPageCadastroSeguros.Controls.Add(this.gbDadosFuncionario);
            this.tbPageCadastroSeguros.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroSeguros.Name = "tbPageCadastroSeguros";
            this.tbPageCadastroSeguros.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroSeguros.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroSeguros.TabIndex = 0;
            this.tbPageCadastroSeguros.Text = "Cadastrar";
            // 
            // gbDadosFuncionario
            // 
            this.gbDadosFuncionario.Controls.Add(this.txtValorFranquia);
            this.gbDadosFuncionario.Controls.Add(this.label2);
            this.gbDadosFuncionario.Controls.Add(this.label1);
            this.gbDadosFuncionario.Controls.Add(this.lblDataInicio);
            this.gbDadosFuncionario.Controls.Add(this.dtfimvigencia);
            this.gbDadosFuncionario.Controls.Add(this.dtInicio);
            this.gbDadosFuncionario.Controls.Add(this.textBox1);
            this.gbDadosFuncionario.Controls.Add(this.lblFranquia);
            this.gbDadosFuncionario.Controls.Add(this.txtValor);
            this.gbDadosFuncionario.Controls.Add(this.lblValor);
            this.gbDadosFuncionario.Controls.Add(this.txtTipo);
            this.gbDadosFuncionario.Controls.Add(this.lblTipo);
            this.gbDadosFuncionario.Controls.Add(this.cbItemSegurado);
            this.gbDadosFuncionario.Controls.Add(this.cbSeguradora);
            this.gbDadosFuncionario.Controls.Add(this.lblItemSegurado);
            this.gbDadosFuncionario.Controls.Add(this.lblSeguradora);
            this.gbDadosFuncionario.Controls.Add(this.txtNApolice);
            this.gbDadosFuncionario.Controls.Add(this.lblNApólice);
            this.gbDadosFuncionario.Controls.Add(this.btnExcluirSeguros);
            this.gbDadosFuncionario.Controls.Add(this.btnAlterarSeguros);
            this.gbDadosFuncionario.Controls.Add(this.btnCadastrarSeguros);
            this.gbDadosFuncionario.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosFuncionario.Location = new System.Drawing.Point(6, 6);
            this.gbDadosFuncionario.Name = "gbDadosFuncionario";
            this.gbDadosFuncionario.Size = new System.Drawing.Size(621, 445);
            this.gbDadosFuncionario.TabIndex = 1;
            this.gbDadosFuncionario.TabStop = false;
            this.gbDadosFuncionario.Text = "Dados";
            // 
            // lblItemSegurado
            // 
            this.lblItemSegurado.AutoSize = true;
            this.lblItemSegurado.Location = new System.Drawing.Point(412, 27);
            this.lblItemSegurado.Name = "lblItemSegurado";
            this.lblItemSegurado.Size = new System.Drawing.Size(102, 25);
            this.lblItemSegurado.TabIndex = 45;
            this.lblItemSegurado.Text = "Item Segurado:";
            // 
            // lblSeguradora
            // 
            this.lblSeguradora.AutoSize = true;
            this.lblSeguradora.Location = new System.Drawing.Point(209, 28);
            this.lblSeguradora.Name = "lblSeguradora";
            this.lblSeguradora.Size = new System.Drawing.Size(85, 25);
            this.lblSeguradora.TabIndex = 39;
            this.lblSeguradora.Text = "Seguradora:";
            // 
            // txtNApolice
            // 
            this.txtNApolice.Location = new System.Drawing.Point(11, 56);
            this.txtNApolice.Name = "txtNApolice";
            this.txtNApolice.Size = new System.Drawing.Size(197, 32);
            this.txtNApolice.TabIndex = 14;
            // 
            // lblNApólice
            // 
            this.lblNApólice.AutoSize = true;
            this.lblNApólice.Location = new System.Drawing.Point(6, 28);
            this.lblNApólice.Name = "lblNApólice";
            this.lblNApólice.Size = new System.Drawing.Size(74, 25);
            this.lblNApólice.TabIndex = 37;
            this.lblNApólice.Text = "Nº Apólice";
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
            // 
            // tbPageConsultaSeguros
            // 
            this.tbPageConsultaSeguros.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaSeguros.Controls.Add(this.gbConsultaFuncionario);
            this.tbPageConsultaSeguros.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaSeguros.Name = "tbPageConsultaSeguros";
            this.tbPageConsultaSeguros.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaSeguros.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaSeguros.TabIndex = 1;
            this.tbPageConsultaSeguros.Text = "Consultar";
            // 
            // gbConsultaFuncionario
            // 
            this.gbConsultaFuncionario.Controls.Add(this.txtNApoliceConsulta);
            this.gbConsultaFuncionario.Controls.Add(this.lblNApoliceConsulta);
            this.gbConsultaFuncionario.Controls.Add(this.btnTrasferirSeguros);
            this.gbConsultaFuncionario.Controls.Add(this.dgSegurosConsulta);
            this.gbConsultaFuncionario.Controls.Add(this.btnTodosSeguros);
            this.gbConsultaFuncionario.Controls.Add(this.btnConsultarSeguros);
            this.gbConsultaFuncionario.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaFuncionario.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaFuncionario.Name = "gbConsultaFuncionario";
            this.gbConsultaFuncionario.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaFuncionario.TabIndex = 2;
            this.gbConsultaFuncionario.TabStop = false;
            this.gbConsultaFuncionario.Text = "Consulta";
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
            // cbSeguradora
            // 
            this.cbSeguradora.FormattingEnabled = true;
            this.cbSeguradora.Location = new System.Drawing.Point(214, 55);
            this.cbSeguradora.Name = "cbSeguradora";
            this.cbSeguradora.Size = new System.Drawing.Size(197, 33);
            this.cbSeguradora.TabIndex = 15;
            // 
            // cbItemSegurado
            // 
            this.cbItemSegurado.FormattingEnabled = true;
            this.cbItemSegurado.Location = new System.Drawing.Point(417, 55);
            this.cbItemSegurado.Name = "cbItemSegurado";
            this.cbItemSegurado.Size = new System.Drawing.Size(197, 33);
            this.cbItemSegurado.TabIndex = 16;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 91);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 25);
            this.lblTipo.TabIndex = 51;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(11, 119);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(197, 32);
            this.txtTipo.TabIndex = 17;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(209, 91);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 25);
            this.lblValor.TabIndex = 53;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(214, 119);
            this.txtValor.Mask = "0000000000";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(197, 32);
            this.txtValor.TabIndex = 18;
            // 
            // lblFranquia
            // 
            this.lblFranquia.AutoSize = true;
            this.lblFranquia.Location = new System.Drawing.Point(412, 91);
            this.lblFranquia.Name = "lblFranquia";
            this.lblFranquia.Size = new System.Drawing.Size(67, 25);
            this.lblFranquia.TabIndex = 55;
            this.lblFranquia.Text = "Franquia:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 32);
            this.textBox1.TabIndex = 19;
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
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(6, 154);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(77, 25);
            this.lblDataInicio.TabIndex = 59;
            this.lblDataInicio.Text = "Data Inicio:";
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
            // txtValorFranquia
            // 
            this.txtValorFranquia.Location = new System.Drawing.Point(11, 246);
            this.txtValorFranquia.Mask = "0000000000";
            this.txtValorFranquia.Name = "txtValorFranquia";
            this.txtValorFranquia.Size = new System.Drawing.Size(197, 32);
            this.txtValorFranquia.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Valor Franquia:";
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
            this.tbControlSeguros.ResumeLayout(false);
            this.tbPageCadastroSeguros.ResumeLayout(false);
            this.gbDadosFuncionario.ResumeLayout(false);
            this.gbDadosFuncionario.PerformLayout();
            this.tbPageConsultaSeguros.ResumeLayout(false);
            this.gbConsultaFuncionario.ResumeLayout(false);
            this.gbConsultaFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSegurosConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlSeguros;
        private System.Windows.Forms.TabPage tbPageCadastroSeguros;
        private System.Windows.Forms.GroupBox gbDadosFuncionario;
        private System.Windows.Forms.Label lblItemSegurado;
        private System.Windows.Forms.Label lblSeguradora;
        private System.Windows.Forms.TextBox txtNApolice;
        private System.Windows.Forms.Label lblNApólice;
        private System.Windows.Forms.Button btnExcluirSeguros;
        private System.Windows.Forms.Button btnAlterarSeguros;
        private System.Windows.Forms.Button btnCadastrarSeguros;
        private System.Windows.Forms.TabPage tbPageConsultaSeguros;
        private System.Windows.Forms.GroupBox gbConsultaFuncionario;
        private System.Windows.Forms.TextBox txtNApoliceConsulta;
        private System.Windows.Forms.Label lblNApoliceConsulta;
        private System.Windows.Forms.Button btnTrasferirSeguros;
        private System.Windows.Forms.DataGridView dgSegurosConsulta;
        private System.Windows.Forms.Button btnTodosSeguros;
        private System.Windows.Forms.Button btnConsultarSeguros;
        private System.Windows.Forms.ComboBox cbSeguradora;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFranquia;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbItemSegurado;
        private System.Windows.Forms.MaskedTextBox txtValorFranquia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtfimvigencia;
        private System.Windows.Forms.DateTimePicker dtInicio;
    }
}