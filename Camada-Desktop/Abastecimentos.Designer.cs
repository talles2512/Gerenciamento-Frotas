namespace CamadaDesktop
{
    partial class Abastecimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abastecimentos));
            this.tbControlAbast = new System.Windows.Forms.TabControl();
            this.tbPageCadastroAbast = new System.Windows.Forms.TabPage();
            this.gbDadosAbast = new System.Windows.Forms.GroupBox();
            this.pbpermissao = new System.Windows.Forms.PictureBox();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtQuantidadeLitros = new System.Windows.Forms.MaskedTextBox();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.cbServicoExterno = new System.Windows.Forms.ComboBox();
            this.lblServicoExterno = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtDataAbast = new System.Windows.Forms.DateTimePicker();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnExcluirAbast = new System.Windows.Forms.Button();
            this.btnAlterarAbast = new System.Windows.Forms.Button();
            this.btnCadastrarAbast = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.tbPageConsultaAbast = new System.Windows.Forms.TabPage();
            this.gbConsultaAbast = new System.Windows.Forms.GroupBox();
            this.panelConsultarPorData = new System.Windows.Forms.Panel();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.btnConsultarPorData = new System.Windows.Forms.Button();
            this.lblFimConsulta = new System.Windows.Forms.Label();
            this.lblInicioConsulta = new System.Windows.Forms.Label();
            this.dtFimConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.cbPlacaAbastConsulta = new System.Windows.Forms.ComboBox();
            this.lblDataAbastConsulta = new System.Windows.Forms.Label();
            this.dtDataAbastConsulta = new System.Windows.Forms.DateTimePicker();
            this.cbTipoAbastConsulta = new System.Windows.Forms.ComboBox();
            this.lblTipoAbastConsulta = new System.Windows.Forms.Label();
            this.btnTrasferirAbast = new System.Windows.Forms.Button();
            this.dgVeiculoAbast = new System.Windows.Forms.DataGridView();
            this.btnTodosAbast = new System.Windows.Forms.Button();
            this.btnConsultarAbast = new System.Windows.Forms.Button();
            this.lblPlacaConsulta = new System.Windows.Forms.Label();
            this.toolTipTransfere = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPermissao = new System.Windows.Forms.ToolTip(this.components);
            this.tbControlAbast.SuspendLayout();
            this.tbPageCadastroAbast.SuspendLayout();
            this.gbDadosAbast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).BeginInit();
            this.tbPageConsultaAbast.SuspendLayout();
            this.gbConsultaAbast.SuspendLayout();
            this.panelConsultarPorData.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculoAbast)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlAbast
            // 
            this.tbControlAbast.Controls.Add(this.tbPageCadastroAbast);
            this.tbControlAbast.Controls.Add(this.tbPageConsultaAbast);
            this.tbControlAbast.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlAbast.Location = new System.Drawing.Point(1, 24);
            this.tbControlAbast.Name = "tbControlAbast";
            this.tbControlAbast.SelectedIndex = 0;
            this.tbControlAbast.Size = new System.Drawing.Size(644, 498);
            this.tbControlAbast.TabIndex = 24;
            // 
            // tbPageCadastroAbast
            // 
            this.tbPageCadastroAbast.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroAbast.Controls.Add(this.gbDadosAbast);
            this.tbPageCadastroAbast.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroAbast.Name = "tbPageCadastroAbast";
            this.tbPageCadastroAbast.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroAbast.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroAbast.TabIndex = 0;
            this.tbPageCadastroAbast.Text = "Cadastrar";
            // 
            // gbDadosAbast
            // 
            this.gbDadosAbast.Controls.Add(this.pbpermissao);
            this.gbDadosAbast.Controls.Add(this.lblCancelar);
            this.gbDadosAbast.Controls.Add(this.lblLitros);
            this.gbDadosAbast.Controls.Add(this.txtQuantidadeLitros);
            this.gbDadosAbast.Controls.Add(this.cbPlaca);
            this.gbDadosAbast.Controls.Add(this.cbServicoExterno);
            this.gbDadosAbast.Controls.Add(this.lblServicoExterno);
            this.gbDadosAbast.Controls.Add(this.txtValor);
            this.gbDadosAbast.Controls.Add(this.lblValor);
            this.gbDadosAbast.Controls.Add(this.lblData);
            this.gbDadosAbast.Controls.Add(this.dtDataAbast);
            this.gbDadosAbast.Controls.Add(this.cbTipo);
            this.gbDadosAbast.Controls.Add(this.lblTipo);
            this.gbDadosAbast.Controls.Add(this.btnExcluirAbast);
            this.gbDadosAbast.Controls.Add(this.btnAlterarAbast);
            this.gbDadosAbast.Controls.Add(this.btnCadastrarAbast);
            this.gbDadosAbast.Controls.Add(this.lblPlaca);
            this.gbDadosAbast.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosAbast.Location = new System.Drawing.Point(6, 6);
            this.gbDadosAbast.Name = "gbDadosAbast";
            this.gbDadosAbast.Size = new System.Drawing.Size(621, 445);
            this.gbDadosAbast.TabIndex = 1;
            this.gbDadosAbast.TabStop = false;
            this.gbDadosAbast.Text = "Dados";
            // 
            // pbpermissao
            // 
            this.pbpermissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbpermissao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbpermissao.Image = ((System.Drawing.Image)(resources.GetObject("pbpermissao.Image")));
            this.pbpermissao.Location = new System.Drawing.Point(396, 396);
            this.pbpermissao.Name = "pbpermissao";
            this.pbpermissao.Size = new System.Drawing.Size(53, 40);
            this.pbpermissao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbpermissao.TabIndex = 75;
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
            this.lblCancelar.Location = new System.Drawing.Point(272, 308);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(89, 32);
            this.lblCancelar.TabIndex = 47;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Visible = false;
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(209, 92);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(122, 25);
            this.lblLitros.TabIndex = 30;
            this.lblLitros.Text = "Quantidade/Litros:";
            // 
            // txtQuantidadeLitros
            // 
            this.txtQuantidadeLitros.Location = new System.Drawing.Point(214, 120);
            this.txtQuantidadeLitros.Mask = "00.00";
            this.txtQuantidadeLitros.Name = "txtQuantidadeLitros";
            this.txtQuantidadeLitros.Size = new System.Drawing.Size(100, 32);
            this.txtQuantidadeLitros.TabIndex = 29;
            // 
            // cbPlaca
            // 
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(11, 182);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(197, 33);
            this.cbPlaca.TabIndex = 17;
            // 
            // cbServicoExterno
            // 
            this.cbServicoExterno.FormattingEnabled = true;
            this.cbServicoExterno.Location = new System.Drawing.Point(11, 246);
            this.cbServicoExterno.Name = "cbServicoExterno";
            this.cbServicoExterno.Size = new System.Drawing.Size(400, 33);
            this.cbServicoExterno.TabIndex = 18;
            // 
            // lblServicoExterno
            // 
            this.lblServicoExterno.AutoSize = true;
            this.lblServicoExterno.Location = new System.Drawing.Point(6, 218);
            this.lblServicoExterno.Name = "lblServicoExterno";
            this.lblServicoExterno.Size = new System.Drawing.Size(49, 25);
            this.lblServicoExterno.TabIndex = 28;
            this.lblServicoExterno.Text = "Posto:";
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
            this.lblValor.Size = new System.Drawing.Size(75, 25);
            this.lblValor.TabIndex = 26;
            this.lblValor.Text = "Valor total:";
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
            // dtDataAbast
            // 
            this.dtDataAbast.CustomFormat = "dd/mm/yyyy";
            this.dtDataAbast.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataAbast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataAbast.Location = new System.Drawing.Point(214, 56);
            this.dtDataAbast.Name = "dtDataAbast";
            this.dtDataAbast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataAbast.Size = new System.Drawing.Size(284, 31);
            this.dtDataAbast.TabIndex = 15;
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
            // btnExcluirAbast
            // 
            this.btnExcluirAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirAbast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirAbast.Enabled = false;
            this.btnExcluirAbast.FlatAppearance.BorderSize = 0;
            this.btnExcluirAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAbast.ForeColor = System.Drawing.Color.White;
            this.btnExcluirAbast.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirAbast.Image")));
            this.btnExcluirAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirAbast.Location = new System.Drawing.Point(244, 396);
            this.btnExcluirAbast.Name = "btnExcluirAbast";
            this.btnExcluirAbast.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirAbast.TabIndex = 21;
            this.btnExcluirAbast.Text = "Excluir";
            this.btnExcluirAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirAbast.UseVisualStyleBackColor = false;
            this.btnExcluirAbast.Click += new System.EventHandler(this.BtnExcluirAbast_Click);
            // 
            // btnAlterarAbast
            // 
            this.btnAlterarAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarAbast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarAbast.Enabled = false;
            this.btnAlterarAbast.FlatAppearance.BorderSize = 0;
            this.btnAlterarAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarAbast.ForeColor = System.Drawing.Color.White;
            this.btnAlterarAbast.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarAbast.Image")));
            this.btnAlterarAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarAbast.Location = new System.Drawing.Point(244, 350);
            this.btnAlterarAbast.Name = "btnAlterarAbast";
            this.btnAlterarAbast.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarAbast.TabIndex = 20;
            this.btnAlterarAbast.Text = "Alterar";
            this.btnAlterarAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarAbast.UseVisualStyleBackColor = false;
            this.btnAlterarAbast.Click += new System.EventHandler(this.BtnAlterarAbast_Click);
            // 
            // btnCadastrarAbast
            // 
            this.btnCadastrarAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarAbast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarAbast.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAbast.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarAbast.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarAbast.Image")));
            this.btnCadastrarAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarAbast.Location = new System.Drawing.Point(119, 304);
            this.btnCadastrarAbast.Name = "btnCadastrarAbast";
            this.btnCadastrarAbast.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarAbast.TabIndex = 19;
            this.btnCadastrarAbast.Text = "Cadastrar";
            this.btnCadastrarAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarAbast.UseVisualStyleBackColor = false;
            this.btnCadastrarAbast.Click += new System.EventHandler(this.BtnCadastrarAbast_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(6, 154);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(104, 25);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Veículo - Placa:";
            // 
            // tbPageConsultaAbast
            // 
            this.tbPageConsultaAbast.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaAbast.Controls.Add(this.gbConsultaAbast);
            this.tbPageConsultaAbast.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaAbast.Name = "tbPageConsultaAbast";
            this.tbPageConsultaAbast.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaAbast.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaAbast.TabIndex = 1;
            this.tbPageConsultaAbast.Text = "Consultar";
            // 
            // gbConsultaAbast
            // 
            this.gbConsultaAbast.Controls.Add(this.panelConsultarPorData);
            this.gbConsultaAbast.Controls.Add(this.cbPlacaAbastConsulta);
            this.gbConsultaAbast.Controls.Add(this.lblDataAbastConsulta);
            this.gbConsultaAbast.Controls.Add(this.dtDataAbastConsulta);
            this.gbConsultaAbast.Controls.Add(this.cbTipoAbastConsulta);
            this.gbConsultaAbast.Controls.Add(this.lblTipoAbastConsulta);
            this.gbConsultaAbast.Controls.Add(this.btnTrasferirAbast);
            this.gbConsultaAbast.Controls.Add(this.dgVeiculoAbast);
            this.gbConsultaAbast.Controls.Add(this.btnTodosAbast);
            this.gbConsultaAbast.Controls.Add(this.btnConsultarAbast);
            this.gbConsultaAbast.Controls.Add(this.lblPlacaConsulta);
            this.gbConsultaAbast.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaAbast.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaAbast.Name = "gbConsultaAbast";
            this.gbConsultaAbast.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaAbast.TabIndex = 2;
            this.gbConsultaAbast.TabStop = false;
            this.gbConsultaAbast.Text = "Consulta";
            // 
            // panelConsultarPorData
            // 
            this.panelConsultarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelConsultarPorData.Controls.Add(this.gbData);
            this.panelConsultarPorData.Location = new System.Drawing.Point(394, 64);
            this.panelConsultarPorData.Name = "panelConsultarPorData";
            this.panelConsultarPorData.Size = new System.Drawing.Size(177, 213);
            this.panelConsultarPorData.TabIndex = 35;
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
            // cbPlacaAbastConsulta
            // 
            this.cbPlacaAbastConsulta.FormattingEnabled = true;
            this.cbPlacaAbastConsulta.Location = new System.Drawing.Point(296, 25);
            this.cbPlacaAbastConsulta.Name = "cbPlacaAbastConsulta";
            this.cbPlacaAbastConsulta.Size = new System.Drawing.Size(197, 33);
            this.cbPlacaAbastConsulta.TabIndex = 15;
            // 
            // lblDataAbastConsulta
            // 
            this.lblDataAbastConsulta.AutoSize = true;
            this.lblDataAbastConsulta.Location = new System.Drawing.Point(2, 64);
            this.lblDataAbastConsulta.Name = "lblDataAbastConsulta";
            this.lblDataAbastConsulta.Size = new System.Drawing.Size(42, 25);
            this.lblDataAbastConsulta.TabIndex = 29;
            this.lblDataAbastConsulta.Text = "Data:";
            // 
            // dtDataAbastConsulta
            // 
            this.dtDataAbastConsulta.CustomFormat = "dd/mm/yyyy";
            this.dtDataAbastConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataAbastConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataAbastConsulta.Location = new System.Drawing.Point(50, 64);
            this.dtDataAbastConsulta.Name = "dtDataAbastConsulta";
            this.dtDataAbastConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataAbastConsulta.Size = new System.Drawing.Size(146, 31);
            this.dtDataAbastConsulta.TabIndex = 16;
            // 
            // cbTipoAbastConsulta
            // 
            this.cbTipoAbastConsulta.FormattingEnabled = true;
            this.cbTipoAbastConsulta.Location = new System.Drawing.Point(50, 25);
            this.cbTipoAbastConsulta.Name = "cbTipoAbastConsulta";
            this.cbTipoAbastConsulta.Size = new System.Drawing.Size(186, 33);
            this.cbTipoAbastConsulta.TabIndex = 14;
            // 
            // lblTipoAbastConsulta
            // 
            this.lblTipoAbastConsulta.AutoSize = true;
            this.lblTipoAbastConsulta.Location = new System.Drawing.Point(6, 28);
            this.lblTipoAbastConsulta.Name = "lblTipoAbastConsulta";
            this.lblTipoAbastConsulta.Size = new System.Drawing.Size(38, 25);
            this.lblTipoAbastConsulta.TabIndex = 26;
            this.lblTipoAbastConsulta.Text = "Tipo:";
            // 
            // btnTrasferirAbast
            // 
            this.btnTrasferirAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirAbast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirAbast.BackgroundImage")));
            this.btnTrasferirAbast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirAbast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrasferirAbast.FlatAppearance.BorderSize = 0;
            this.btnTrasferirAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirAbast.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirAbast.Location = new System.Drawing.Point(577, 64);
            this.btnTrasferirAbast.Name = "btnTrasferirAbast";
            this.btnTrasferirAbast.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirAbast.TabIndex = 19;
            this.btnTrasferirAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirAbast.UseVisualStyleBackColor = false;
            this.btnTrasferirAbast.Click += new System.EventHandler(this.BtnTrasferirAbast_Click);
            // 
            // dgVeiculoAbast
            // 
            this.dgVeiculoAbast.BackgroundColor = System.Drawing.Color.White;
            this.dgVeiculoAbast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeiculoAbast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgVeiculoAbast.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgVeiculoAbast.Location = new System.Drawing.Point(7, 110);
            this.dgVeiculoAbast.Name = "dgVeiculoAbast";
            this.dgVeiculoAbast.ReadOnly = true;
            this.dgVeiculoAbast.RowHeadersWidth = 51;
            this.dgVeiculoAbast.Size = new System.Drawing.Size(608, 329);
            this.dgVeiculoAbast.TabIndex = 20;
            this.dgVeiculoAbast.DoubleClick += new System.EventHandler(this.dgVeiculoAbast_DoubleClick);
            // 
            // btnTodosAbast
            // 
            this.btnTodosAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosAbast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosAbast.FlatAppearance.BorderSize = 0;
            this.btnTodosAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosAbast.ForeColor = System.Drawing.Color.White;
            this.btnTodosAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosAbast.Location = new System.Drawing.Point(394, 64);
            this.btnTodosAbast.Name = "btnTodosAbast";
            this.btnTodosAbast.Size = new System.Drawing.Size(177, 40);
            this.btnTodosAbast.TabIndex = 18;
            this.btnTodosAbast.Text = "Consultar p/ Data";
            this.btnTodosAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosAbast.UseVisualStyleBackColor = false;
            this.btnTodosAbast.Click += new System.EventHandler(this.BtnTodosAbast_Click);
            // 
            // btnConsultarAbast
            // 
            this.btnConsultarAbast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarAbast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarAbast.FlatAppearance.BorderSize = 0;
            this.btnConsultarAbast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarAbast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAbast.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAbast.ForeColor = System.Drawing.Color.White;
            this.btnConsultarAbast.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarAbast.Image")));
            this.btnConsultarAbast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAbast.Location = new System.Drawing.Point(242, 64);
            this.btnConsultarAbast.Name = "btnConsultarAbast";
            this.btnConsultarAbast.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarAbast.TabIndex = 17;
            this.btnConsultarAbast.Text = "    Consultar";
            this.btnConsultarAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarAbast.UseVisualStyleBackColor = false;
            this.btnConsultarAbast.Click += new System.EventHandler(this.BtnConsultarAbast_Click);
            // 
            // lblPlacaConsulta
            // 
            this.lblPlacaConsulta.AutoSize = true;
            this.lblPlacaConsulta.Location = new System.Drawing.Point(242, 28);
            this.lblPlacaConsulta.Name = "lblPlacaConsulta";
            this.lblPlacaConsulta.Size = new System.Drawing.Size(48, 25);
            this.lblPlacaConsulta.TabIndex = 17;
            this.lblPlacaConsulta.Text = "Placa:";
            // 
            // Abastecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlAbast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Abastecimentos";
            this.Text = "Abastecimento";
            this.Load += new System.EventHandler(this.Abastecimento_Load);
            this.tbControlAbast.ResumeLayout(false);
            this.tbPageCadastroAbast.ResumeLayout(false);
            this.gbDadosAbast.ResumeLayout(false);
            this.gbDadosAbast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpermissao)).EndInit();
            this.tbPageConsultaAbast.ResumeLayout(false);
            this.gbConsultaAbast.ResumeLayout(false);
            this.gbConsultaAbast.PerformLayout();
            this.panelConsultarPorData.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculoAbast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlAbast;
        private System.Windows.Forms.TabPage tbPageCadastroAbast;
        private System.Windows.Forms.GroupBox gbDadosAbast;
        private System.Windows.Forms.ComboBox cbServicoExterno;
        private System.Windows.Forms.Label lblServicoExterno;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtDataAbast;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnExcluirAbast;
        private System.Windows.Forms.Button btnAlterarAbast;
        private System.Windows.Forms.Button btnCadastrarAbast;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TabPage tbPageConsultaAbast;
        private System.Windows.Forms.GroupBox gbConsultaAbast;
        private System.Windows.Forms.Label lblDataAbastConsulta;
        private System.Windows.Forms.DateTimePicker dtDataAbastConsulta;
        private System.Windows.Forms.ComboBox cbTipoAbastConsulta;
        private System.Windows.Forms.Label lblTipoAbastConsulta;
        private System.Windows.Forms.Button btnTrasferirAbast;
        private System.Windows.Forms.DataGridView dgVeiculoAbast;
        private System.Windows.Forms.Button btnTodosAbast;
        private System.Windows.Forms.Button btnConsultarAbast;
        private System.Windows.Forms.Label lblPlacaConsulta;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.ComboBox cbPlacaAbastConsulta;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.MaskedTextBox txtQuantidadeLitros;
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