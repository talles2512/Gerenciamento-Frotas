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
            this.tbControlAbast.SuspendLayout();
            this.tbPageCadastroAbast.SuspendLayout();
            this.gbDadosAbast.SuspendLayout();
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
            this.tbControlAbast.Location = new System.Drawing.Point(1, 30);
            this.tbControlAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbControlAbast.Name = "tbControlAbast";
            this.tbControlAbast.SelectedIndex = 0;
            this.tbControlAbast.Size = new System.Drawing.Size(859, 613);
            this.tbControlAbast.TabIndex = 24;
            // 
            // tbPageCadastroAbast
            // 
            this.tbPageCadastroAbast.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroAbast.Controls.Add(this.gbDadosAbast);
            this.tbPageCadastroAbast.Location = new System.Drawing.Point(4, 45);
            this.tbPageCadastroAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPageCadastroAbast.Name = "tbPageCadastroAbast";
            this.tbPageCadastroAbast.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPageCadastroAbast.Size = new System.Drawing.Size(851, 564);
            this.tbPageCadastroAbast.TabIndex = 0;
            this.tbPageCadastroAbast.Text = "Cadastrar";
            // 
            // gbDadosAbast
            // 
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
            this.gbDadosAbast.Location = new System.Drawing.Point(8, 7);
            this.gbDadosAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDadosAbast.Name = "gbDadosAbast";
            this.gbDadosAbast.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDadosAbast.Size = new System.Drawing.Size(828, 548);
            this.gbDadosAbast.TabIndex = 1;
            this.gbDadosAbast.TabStop = false;
            this.gbDadosAbast.Text = "Dados";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCancelar.Font = new System.Drawing.Font("Agency FB", 20.25F);
            this.lblCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCancelar.Location = new System.Drawing.Point(363, 379);
            this.lblCancelar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(107, 42);
            this.lblCancelar.TabIndex = 47;
            this.lblCancelar.Text = "Cancelar";
            this.lblCancelar.Visible = false;
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(279, 113);
            this.lblLitros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(167, 32);
            this.lblLitros.TabIndex = 30;
            this.lblLitros.Text = "Quantidade/Litros:";
            // 
            // txtQuantidadeLitros
            // 
            this.txtQuantidadeLitros.Location = new System.Drawing.Point(285, 148);
            this.txtQuantidadeLitros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantidadeLitros.Mask = "00.00";
            this.txtQuantidadeLitros.Name = "txtQuantidadeLitros";
            this.txtQuantidadeLitros.Size = new System.Drawing.Size(132, 39);
            this.txtQuantidadeLitros.TabIndex = 29;
            // 
            // cbPlaca
            // 
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(15, 224);
            this.cbPlaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(261, 39);
            this.cbPlaca.TabIndex = 17;
            // 
            // cbServicoExterno
            // 
            this.cbServicoExterno.FormattingEnabled = true;
            this.cbServicoExterno.Location = new System.Drawing.Point(15, 303);
            this.cbServicoExterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbServicoExterno.Name = "cbServicoExterno";
            this.cbServicoExterno.Size = new System.Drawing.Size(532, 39);
            this.cbServicoExterno.TabIndex = 18;
            // 
            // lblServicoExterno
            // 
            this.lblServicoExterno.AutoSize = true;
            this.lblServicoExterno.Location = new System.Drawing.Point(8, 268);
            this.lblServicoExterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicoExterno.Name = "lblServicoExterno";
            this.lblServicoExterno.Size = new System.Drawing.Size(65, 32);
            this.lblServicoExterno.TabIndex = 28;
            this.lblServicoExterno.Text = "Posto:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(15, 148);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.Mask = "000000000";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(261, 39);
            this.txtValor.TabIndex = 16;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(8, 113);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(101, 32);
            this.lblValor.TabIndex = 26;
            this.lblValor.Text = "Valor total:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(279, 34);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(55, 32);
            this.lblData.TabIndex = 25;
            this.lblData.Text = "Data:";
            // 
            // dtDataAbast
            // 
            this.dtDataAbast.CustomFormat = "dd/mm/yyyy";
            this.dtDataAbast.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataAbast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataAbast.Location = new System.Drawing.Point(285, 69);
            this.dtDataAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDataAbast.Name = "dtDataAbast";
            this.dtDataAbast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataAbast.Size = new System.Drawing.Size(377, 36);
            this.dtDataAbast.TabIndex = 15;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(15, 69);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(261, 39);
            this.cbTipo.TabIndex = 14;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(8, 34);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 32);
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
            this.btnExcluirAbast.Location = new System.Drawing.Point(325, 487);
            this.btnExcluirAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluirAbast.Name = "btnExcluirAbast";
            this.btnExcluirAbast.Size = new System.Drawing.Size(195, 49);
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
            this.btnAlterarAbast.Location = new System.Drawing.Point(325, 431);
            this.btnAlterarAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterarAbast.Name = "btnAlterarAbast";
            this.btnAlterarAbast.Size = new System.Drawing.Size(195, 49);
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
            this.btnCadastrarAbast.Location = new System.Drawing.Point(159, 374);
            this.btnCadastrarAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarAbast.Name = "btnCadastrarAbast";
            this.btnCadastrarAbast.Size = new System.Drawing.Size(519, 49);
            this.btnCadastrarAbast.TabIndex = 19;
            this.btnCadastrarAbast.Text = "Cadastrar";
            this.btnCadastrarAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarAbast.UseVisualStyleBackColor = false;
            this.btnCadastrarAbast.Click += new System.EventHandler(this.BtnCadastrarAbast_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(8, 190);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(140, 32);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Veículo - Placa:";
            // 
            // tbPageConsultaAbast
            // 
            this.tbPageConsultaAbast.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaAbast.Controls.Add(this.gbConsultaAbast);
            this.tbPageConsultaAbast.Location = new System.Drawing.Point(4, 45);
            this.tbPageConsultaAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPageConsultaAbast.Name = "tbPageConsultaAbast";
            this.tbPageConsultaAbast.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPageConsultaAbast.Size = new System.Drawing.Size(851, 564);
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
            this.gbConsultaAbast.Location = new System.Drawing.Point(11, 12);
            this.gbConsultaAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConsultaAbast.Name = "gbConsultaAbast";
            this.gbConsultaAbast.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConsultaAbast.Size = new System.Drawing.Size(828, 548);
            this.gbConsultaAbast.TabIndex = 2;
            this.gbConsultaAbast.TabStop = false;
            this.gbConsultaAbast.Text = "Consulta";
            // 
            // panelConsultarPorData
            // 
            this.panelConsultarPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelConsultarPorData.Controls.Add(this.gbData);
            this.panelConsultarPorData.Location = new System.Drawing.Point(525, 79);
            this.panelConsultarPorData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelConsultarPorData.Name = "panelConsultarPorData";
            this.panelConsultarPorData.Size = new System.Drawing.Size(236, 262);
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
            this.gbData.Location = new System.Drawing.Point(4, 9);
            this.gbData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbData.Size = new System.Drawing.Size(228, 247);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
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
            this.btnConsultarPorData.Location = new System.Drawing.Point(8, 191);
            this.btnConsultarPorData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultarPorData.Name = "btnConsultarPorData";
            this.btnConsultarPorData.Size = new System.Drawing.Size(212, 49);
            this.btnConsultarPorData.TabIndex = 21;
            this.btnConsultarPorData.Text = "    Consultar";
            this.btnConsultarPorData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarPorData.UseVisualStyleBackColor = false;
            this.btnConsultarPorData.Click += new System.EventHandler(this.btnConsultarPorData_Click);
            // 
            // lblFimConsulta
            // 
            this.lblFimConsulta.AutoSize = true;
            this.lblFimConsulta.Location = new System.Drawing.Point(0, 111);
            this.lblFimConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFimConsulta.Name = "lblFimConsulta";
            this.lblFimConsulta.Size = new System.Drawing.Size(47, 32);
            this.lblFimConsulta.TabIndex = 34;
            this.lblFimConsulta.Text = "Fim:";
            // 
            // lblInicioConsulta
            // 
            this.lblInicioConsulta.AutoSize = true;
            this.lblInicioConsulta.Location = new System.Drawing.Point(1, 34);
            this.lblInicioConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicioConsulta.Name = "lblInicioConsulta";
            this.lblInicioConsulta.Size = new System.Drawing.Size(61, 32);
            this.lblInicioConsulta.TabIndex = 33;
            this.lblInicioConsulta.Text = "Inicio:";
            // 
            // dtFimConsulta
            // 
            this.dtFimConsulta.CustomFormat = "MM/yyyy";
            this.dtFimConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtFimConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFimConsulta.Location = new System.Drawing.Point(8, 145);
            this.dtFimConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFimConsulta.Name = "dtFimConsulta";
            this.dtFimConsulta.Size = new System.Drawing.Size(211, 36);
            this.dtFimConsulta.TabIndex = 20;
            this.dtFimConsulta.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            // 
            // dtInicioConsulta
            // 
            this.dtInicioConsulta.CustomFormat = "MM/yyyy";
            this.dtInicioConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtInicioConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicioConsulta.Location = new System.Drawing.Point(8, 69);
            this.dtInicioConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtInicioConsulta.Name = "dtInicioConsulta";
            this.dtInicioConsulta.Size = new System.Drawing.Size(211, 36);
            this.dtInicioConsulta.TabIndex = 19;
            this.dtInicioConsulta.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            // 
            // cbPlacaAbastConsulta
            // 
            this.cbPlacaAbastConsulta.FormattingEnabled = true;
            this.cbPlacaAbastConsulta.Location = new System.Drawing.Point(395, 30);
            this.cbPlacaAbastConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPlacaAbastConsulta.Name = "cbPlacaAbastConsulta";
            this.cbPlacaAbastConsulta.Size = new System.Drawing.Size(261, 39);
            this.cbPlacaAbastConsulta.TabIndex = 15;
            // 
            // lblDataAbastConsulta
            // 
            this.lblDataAbastConsulta.AutoSize = true;
            this.lblDataAbastConsulta.Location = new System.Drawing.Point(3, 79);
            this.lblDataAbastConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataAbastConsulta.Name = "lblDataAbastConsulta";
            this.lblDataAbastConsulta.Size = new System.Drawing.Size(55, 32);
            this.lblDataAbastConsulta.TabIndex = 29;
            this.lblDataAbastConsulta.Text = "Data:";
            // 
            // dtDataAbastConsulta
            // 
            this.dtDataAbastConsulta.CustomFormat = "dd/mm/yyyy";
            this.dtDataAbastConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataAbastConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataAbastConsulta.Location = new System.Drawing.Point(67, 79);
            this.dtDataAbastConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDataAbastConsulta.Name = "dtDataAbastConsulta";
            this.dtDataAbastConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataAbastConsulta.Size = new System.Drawing.Size(193, 36);
            this.dtDataAbastConsulta.TabIndex = 16;
            // 
            // cbTipoAbastConsulta
            // 
            this.cbTipoAbastConsulta.FormattingEnabled = true;
            this.cbTipoAbastConsulta.Location = new System.Drawing.Point(67, 31);
            this.cbTipoAbastConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipoAbastConsulta.Name = "cbTipoAbastConsulta";
            this.cbTipoAbastConsulta.Size = new System.Drawing.Size(247, 39);
            this.cbTipoAbastConsulta.TabIndex = 14;
            // 
            // lblTipoAbastConsulta
            // 
            this.lblTipoAbastConsulta.AutoSize = true;
            this.lblTipoAbastConsulta.Location = new System.Drawing.Point(8, 34);
            this.lblTipoAbastConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoAbastConsulta.Name = "lblTipoAbastConsulta";
            this.lblTipoAbastConsulta.Size = new System.Drawing.Size(51, 32);
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
            this.btnTrasferirAbast.Location = new System.Drawing.Point(769, 79);
            this.btnTrasferirAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrasferirAbast.Name = "btnTrasferirAbast";
            this.btnTrasferirAbast.Size = new System.Drawing.Size(51, 49);
            this.btnTrasferirAbast.TabIndex = 19;
            this.btnTrasferirAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirAbast.UseVisualStyleBackColor = false;
            this.btnTrasferirAbast.Click += new System.EventHandler(this.BtnTrasferirAbast_Click);
            // 
            // dgVeiculoAbast
            // 
            this.dgVeiculoAbast.BackgroundColor = System.Drawing.Color.White;
            this.dgVeiculoAbast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeiculoAbast.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgVeiculoAbast.Location = new System.Drawing.Point(9, 135);
            this.dgVeiculoAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgVeiculoAbast.Name = "dgVeiculoAbast";
            this.dgVeiculoAbast.RowHeadersWidth = 51;
            this.dgVeiculoAbast.Size = new System.Drawing.Size(811, 405);
            this.dgVeiculoAbast.TabIndex = 20;
            this.dgVeiculoAbast.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVeiculoAbast_CellContentClick);
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
            this.btnTodosAbast.Location = new System.Drawing.Point(525, 79);
            this.btnTodosAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTodosAbast.Name = "btnTodosAbast";
            this.btnTodosAbast.Size = new System.Drawing.Size(236, 49);
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
            this.btnConsultarAbast.Location = new System.Drawing.Point(323, 79);
            this.btnConsultarAbast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultarAbast.Name = "btnConsultarAbast";
            this.btnConsultarAbast.Size = new System.Drawing.Size(195, 49);
            this.btnConsultarAbast.TabIndex = 17;
            this.btnConsultarAbast.Text = "    Consultar";
            this.btnConsultarAbast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarAbast.UseVisualStyleBackColor = false;
            this.btnConsultarAbast.Click += new System.EventHandler(this.BtnConsultarAbast_Click);
            // 
            // lblPlacaConsulta
            // 
            this.lblPlacaConsulta.AutoSize = true;
            this.lblPlacaConsulta.Location = new System.Drawing.Point(323, 34);
            this.lblPlacaConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlacaConsulta.Name = "lblPlacaConsulta";
            this.lblPlacaConsulta.Size = new System.Drawing.Size(64, 32);
            this.lblPlacaConsulta.TabIndex = 17;
            this.lblPlacaConsulta.Text = "Placa:";
            // 
            // Abastecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 657);
            this.Controls.Add(this.tbControlAbast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Abastecimentos";
            this.Text = "Abastecimento";
            this.Load += new System.EventHandler(this.Abastecimento_Load);
            this.tbControlAbast.ResumeLayout(false);
            this.tbPageCadastroAbast.ResumeLayout(false);
            this.gbDadosAbast.ResumeLayout(false);
            this.gbDadosAbast.PerformLayout();
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
    }
}