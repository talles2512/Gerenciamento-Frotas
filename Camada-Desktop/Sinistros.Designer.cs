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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sinistros));
            this.tbControlSinistros = new System.Windows.Forms.TabControl();
            this.tbPageCadastroSinistros = new System.Windows.Forms.TabPage();
            this.gbDadosSinistros = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.cbSeguro = new System.Windows.Forms.ComboBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.cbItemSegurado = new System.Windows.Forms.ComboBox();
            this.lblItemSegurado = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtDataMulta = new System.Windows.Forms.DateTimePicker();
            this.btnExcluirSinistros = new System.Windows.Forms.Button();
            this.btnAlterarSinistros = new System.Windows.Forms.Button();
            this.btnCadastrarSinistros = new System.Windows.Forms.Button();
            this.tbPageConsultaSinistros = new System.Windows.Forms.TabPage();
            this.gbConsultaSinistros = new System.Windows.Forms.GroupBox();
            this.txtIDSinistrosConsulta = new System.Windows.Forms.TextBox();
            this.lblIDSinistrosConsulta = new System.Windows.Forms.Label();
            this.lblDataSinistrosConsulta = new System.Windows.Forms.Label();
            this.dtDataSinistrosConsulta = new System.Windows.Forms.DateTimePicker();
            this.btnTrasferirSinistros = new System.Windows.Forms.Button();
            this.dgSinistrosConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosSinistros = new System.Windows.Forms.Button();
            this.btnConsultarSinistros = new System.Windows.Forms.Button();
            this.tbControlSinistros.SuspendLayout();
            this.tbPageCadastroSinistros.SuspendLayout();
            this.gbDadosSinistros.SuspendLayout();
            this.tbPageConsultaSinistros.SuspendLayout();
            this.gbConsultaSinistros.SuspendLayout();
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
            this.gbDadosSinistros.Controls.Add(this.txtid);
            this.gbDadosSinistros.Controls.Add(this.lblIdentificador);
            this.gbDadosSinistros.Controls.Add(this.cbSeguro);
            this.gbDadosSinistros.Controls.Add(this.lblSeguro);
            this.gbDadosSinistros.Controls.Add(this.cbItemSegurado);
            this.gbDadosSinistros.Controls.Add(this.lblItemSegurado);
            this.gbDadosSinistros.Controls.Add(this.txtDesc);
            this.gbDadosSinistros.Controls.Add(this.lblDesc);
            this.gbDadosSinistros.Controls.Add(this.lblData);
            this.gbDadosSinistros.Controls.Add(this.dtDataMulta);
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
            this.cbSeguro.Location = new System.Drawing.Point(360, 55);
            this.cbSeguro.Name = "cbSeguro";
            this.cbSeguro.Size = new System.Drawing.Size(197, 33);
            this.cbSeguro.TabIndex = 16;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Location = new System.Drawing.Point(355, 28);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(58, 25);
            this.lblSeguro.TabIndex = 35;
            this.lblSeguro.Text = "Seguro:";
            // 
            // cbItemSegurado
            // 
            this.cbItemSegurado.FormattingEnabled = true;
            this.cbItemSegurado.Location = new System.Drawing.Point(157, 55);
            this.cbItemSegurado.Name = "cbItemSegurado";
            this.cbItemSegurado.Size = new System.Drawing.Size(197, 33);
            this.cbItemSegurado.TabIndex = 15;
            // 
            // lblItemSegurado
            // 
            this.lblItemSegurado.AutoSize = true;
            this.lblItemSegurado.Location = new System.Drawing.Point(152, 28);
            this.lblItemSegurado.Name = "lblItemSegurado";
            this.lblItemSegurado.Size = new System.Drawing.Size(102, 25);
            this.lblItemSegurado.TabIndex = 33;
            this.lblItemSegurado.Text = "Item Segurado:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(11, 181);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(487, 85);
            this.txtDesc.TabIndex = 18;
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
            this.lblData.Location = new System.Drawing.Point(6, 91);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 25);
            this.lblData.TabIndex = 27;
            this.lblData.Text = "Data:";
            // 
            // dtDataMulta
            // 
            this.dtDataMulta.CustomFormat = "dd/mm/yyyy";
            this.dtDataMulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataMulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataMulta.Location = new System.Drawing.Point(11, 119);
            this.dtDataMulta.Name = "dtDataMulta";
            this.dtDataMulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataMulta.Size = new System.Drawing.Size(197, 31);
            this.dtDataMulta.TabIndex = 17;
            // 
            // btnExcluirSinistros
            // 
            this.btnExcluirSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.btnExcluirSinistros.TabIndex = 21;
            this.btnExcluirSinistros.Text = "Excluir";
            this.btnExcluirSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirSinistros.UseVisualStyleBackColor = false;
            // 
            // btnAlterarSinistros
            // 
            this.btnAlterarSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
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
            this.btnAlterarSinistros.TabIndex = 20;
            this.btnAlterarSinistros.Text = "Alterar";
            this.btnAlterarSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarSinistros.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarSinistros
            // 
            this.btnCadastrarSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarSinistros.FlatAppearance.BorderSize = 0;
            this.btnCadastrarSinistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarSinistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSinistros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSinistros.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarSinistros.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarSinistros.Image")));
            this.btnCadastrarSinistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarSinistros.Location = new System.Drawing.Point(119, 307);
            this.btnCadastrarSinistros.Name = "btnCadastrarSinistros";
            this.btnCadastrarSinistros.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarSinistros.TabIndex = 19;
            this.btnCadastrarSinistros.Text = "Cadastrar";
            this.btnCadastrarSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarSinistros.UseVisualStyleBackColor = false;
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
            this.gbConsultaSinistros.Controls.Add(this.txtIDSinistrosConsulta);
            this.gbConsultaSinistros.Controls.Add(this.lblIDSinistrosConsulta);
            this.gbConsultaSinistros.Controls.Add(this.lblDataSinistrosConsulta);
            this.gbConsultaSinistros.Controls.Add(this.dtDataSinistrosConsulta);
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
            // txtIDSinistrosConsulta
            // 
            this.txtIDSinistrosConsulta.Location = new System.Drawing.Point(99, 25);
            this.txtIDSinistrosConsulta.Name = "txtIDSinistrosConsulta";
            this.txtIDSinistrosConsulta.Size = new System.Drawing.Size(140, 32);
            this.txtIDSinistrosConsulta.TabIndex = 14;
            // 
            // lblIDSinistrosConsulta
            // 
            this.lblIDSinistrosConsulta.AutoSize = true;
            this.lblIDSinistrosConsulta.Location = new System.Drawing.Point(6, 28);
            this.lblIDSinistrosConsulta.Name = "lblIDSinistrosConsulta";
            this.lblIDSinistrosConsulta.Size = new System.Drawing.Size(87, 25);
            this.lblIDSinistrosConsulta.TabIndex = 41;
            this.lblIDSinistrosConsulta.Text = "Identificador:";
            // 
            // lblDataSinistrosConsulta
            // 
            this.lblDataSinistrosConsulta.AutoSize = true;
            this.lblDataSinistrosConsulta.Location = new System.Drawing.Point(245, 28);
            this.lblDataSinistrosConsulta.Name = "lblDataSinistrosConsulta";
            this.lblDataSinistrosConsulta.Size = new System.Drawing.Size(42, 25);
            this.lblDataSinistrosConsulta.TabIndex = 40;
            this.lblDataSinistrosConsulta.Text = "Data:";
            // 
            // dtDataSinistrosConsulta
            // 
            this.dtDataSinistrosConsulta.CustomFormat = "dd/mm/yyyy";
            this.dtDataSinistrosConsulta.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.dtDataSinistrosConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataSinistrosConsulta.Location = new System.Drawing.Point(293, 25);
            this.dtDataSinistrosConsulta.Name = "dtDataSinistrosConsulta";
            this.dtDataSinistrosConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDataSinistrosConsulta.Size = new System.Drawing.Size(197, 31);
            this.dtDataSinistrosConsulta.TabIndex = 15;
            // 
            // btnTrasferirSinistros
            // 
            this.btnTrasferirSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirSinistros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirSinistros.BackgroundImage")));
            this.btnTrasferirSinistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirSinistros.FlatAppearance.BorderSize = 0;
            this.btnTrasferirSinistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirSinistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirSinistros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirSinistros.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirSinistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirSinistros.Location = new System.Drawing.Point(577, 64);
            this.btnTrasferirSinistros.Name = "btnTrasferirSinistros";
            this.btnTrasferirSinistros.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirSinistros.TabIndex = 18;
            this.btnTrasferirSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirSinistros.UseVisualStyleBackColor = false;
            // 
            // dgSinistrosConsulta
            // 
            this.dgSinistrosConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgSinistrosConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSinistrosConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgSinistrosConsulta.Location = new System.Drawing.Point(7, 110);
            this.dgSinistrosConsulta.Name = "dgSinistrosConsulta";
            this.dgSinistrosConsulta.Size = new System.Drawing.Size(608, 329);
            this.dgSinistrosConsulta.TabIndex = 19;
            // 
            // btnTodosSinistros
            // 
            this.btnTodosSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosSinistros.FlatAppearance.BorderSize = 0;
            this.btnTodosSinistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosSinistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosSinistros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosSinistros.ForeColor = System.Drawing.Color.White;
            this.btnTodosSinistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosSinistros.Location = new System.Drawing.Point(412, 64);
            this.btnTodosSinistros.Name = "btnTodosSinistros";
            this.btnTodosSinistros.Size = new System.Drawing.Size(159, 40);
            this.btnTodosSinistros.TabIndex = 17;
            this.btnTodosSinistros.Text = "Consultar Todos";
            this.btnTodosSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosSinistros.UseVisualStyleBackColor = false;
            // 
            // btnConsultarSinistros
            // 
            this.btnConsultarSinistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarSinistros.FlatAppearance.BorderSize = 0;
            this.btnConsultarSinistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarSinistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarSinistros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarSinistros.ForeColor = System.Drawing.Color.White;
            this.btnConsultarSinistros.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarSinistros.Image")));
            this.btnConsultarSinistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarSinistros.Location = new System.Drawing.Point(260, 64);
            this.btnConsultarSinistros.Name = "btnConsultarSinistros";
            this.btnConsultarSinistros.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarSinistros.TabIndex = 16;
            this.btnConsultarSinistros.Text = "    Consultar";
            this.btnConsultarSinistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarSinistros.UseVisualStyleBackColor = false;
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
            this.tbControlSinistros.ResumeLayout(false);
            this.tbPageCadastroSinistros.ResumeLayout(false);
            this.gbDadosSinistros.ResumeLayout(false);
            this.gbDadosSinistros.PerformLayout();
            this.tbPageConsultaSinistros.ResumeLayout(false);
            this.gbConsultaSinistros.ResumeLayout(false);
            this.gbConsultaSinistros.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtDataMulta;
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
        private System.Windows.Forms.DateTimePicker dtDataSinistrosConsulta;
    }
}