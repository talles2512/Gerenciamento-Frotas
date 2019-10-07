﻿namespace CamadaDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.tbControlClientes = new System.Windows.Forms.TabControl();
            this.tbPageCadastroClientes = new System.Windows.Forms.TabPage();
            this.gbDadosClientes = new System.Windows.Forms.GroupBox();
            this.tbPageConsultaClientes = new System.Windows.Forms.TabPage();
            this.gbConsultaClientes = new System.Windows.Forms.GroupBox();
            this.btnTrasferirClientes = new System.Windows.Forms.Button();
            this.dgClientesConsulta = new System.Windows.Forms.DataGridView();
            this.btnTodosClientes = new System.Windows.Forms.Button();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.btnExcluirClientes = new System.Windows.Forms.Button();
            this.btnAlterarClientes = new System.Windows.Forms.Button();
            this.btnCadastrarClientes = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtCPFClientesConsulta = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFConsultaClientes = new System.Windows.Forms.Label();
            this.tbControlClientes.SuspendLayout();
            this.tbPageCadastroClientes.SuspendLayout();
            this.gbDadosClientes.SuspendLayout();
            this.tbPageConsultaClientes.SuspendLayout();
            this.gbConsultaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientesConsulta)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.tbControlClientes.Size = new System.Drawing.Size(644, 498);
            this.tbControlClientes.TabIndex = 23;
            // 
            // tbPageCadastroClientes
            // 
            this.tbPageCadastroClientes.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageCadastroClientes.Controls.Add(this.gbDadosClientes);
            this.tbPageCadastroClientes.Location = new System.Drawing.Point(4, 37);
            this.tbPageCadastroClientes.Name = "tbPageCadastroClientes";
            this.tbPageCadastroClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageCadastroClientes.Size = new System.Drawing.Size(636, 457);
            this.tbPageCadastroClientes.TabIndex = 0;
            this.tbPageCadastroClientes.Text = "Cadastrar";
            // 
            // gbDadosClientes
            // 
            this.gbDadosClientes.Controls.Add(this.panel1);
            this.gbDadosClientes.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosClientes.Location = new System.Drawing.Point(6, 6);
            this.gbDadosClientes.Name = "gbDadosClientes";
            this.gbDadosClientes.Size = new System.Drawing.Size(621, 445);
            this.gbDadosClientes.TabIndex = 1;
            this.gbDadosClientes.TabStop = false;
            this.gbDadosClientes.Text = "Dados";
            // 
            // tbPageConsultaClientes
            // 
            this.tbPageConsultaClientes.BackColor = System.Drawing.SystemColors.Control;
            this.tbPageConsultaClientes.Controls.Add(this.gbConsultaClientes);
            this.tbPageConsultaClientes.Location = new System.Drawing.Point(4, 37);
            this.tbPageConsultaClientes.Name = "tbPageConsultaClientes";
            this.tbPageConsultaClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageConsultaClientes.Size = new System.Drawing.Size(636, 457);
            this.tbPageConsultaClientes.TabIndex = 1;
            this.tbPageConsultaClientes.Text = "Consultar";
            // 
            // gbConsultaClientes
            // 
            this.gbConsultaClientes.Controls.Add(this.txtCPFClientesConsulta);
            this.gbConsultaClientes.Controls.Add(this.lblCPFConsultaClientes);
            this.gbConsultaClientes.Controls.Add(this.btnTrasferirClientes);
            this.gbConsultaClientes.Controls.Add(this.dgClientesConsulta);
            this.gbConsultaClientes.Controls.Add(this.btnTodosClientes);
            this.gbConsultaClientes.Controls.Add(this.btnConsultarClientes);
            this.gbConsultaClientes.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultaClientes.Location = new System.Drawing.Point(8, 10);
            this.gbConsultaClientes.Name = "gbConsultaClientes";
            this.gbConsultaClientes.Size = new System.Drawing.Size(621, 445);
            this.gbConsultaClientes.TabIndex = 2;
            this.gbConsultaClientes.TabStop = false;
            this.gbConsultaClientes.Text = "Consulta";
            // 
            // btnTrasferirClientes
            // 
            this.btnTrasferirClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTrasferirClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrasferirClientes.BackgroundImage")));
            this.btnTrasferirClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTrasferirClientes.FlatAppearance.BorderSize = 0;
            this.btnTrasferirClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrasferirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrasferirClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasferirClientes.ForeColor = System.Drawing.Color.White;
            this.btnTrasferirClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrasferirClientes.Location = new System.Drawing.Point(580, 24);
            this.btnTrasferirClientes.Name = "btnTrasferirClientes";
            this.btnTrasferirClientes.Size = new System.Drawing.Size(38, 40);
            this.btnTrasferirClientes.TabIndex = 21;
            this.btnTrasferirClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrasferirClientes.UseVisualStyleBackColor = false;
            // 
            // dgClientesConsulta
            // 
            this.dgClientesConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgClientesConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientesConsulta.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgClientesConsulta.Location = new System.Drawing.Point(7, 68);
            this.dgClientesConsulta.Name = "dgClientesConsulta";
            this.dgClientesConsulta.Size = new System.Drawing.Size(608, 371);
            this.dgClientesConsulta.TabIndex = 25;
            // 
            // btnTodosClientes
            // 
            this.btnTodosClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTodosClientes.FlatAppearance.BorderSize = 0;
            this.btnTodosClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTodosClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosClientes.ForeColor = System.Drawing.Color.White;
            this.btnTodosClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosClientes.Location = new System.Drawing.Point(418, 24);
            this.btnTodosClientes.Name = "btnTodosClientes";
            this.btnTodosClientes.Size = new System.Drawing.Size(159, 40);
            this.btnTodosClientes.TabIndex = 24;
            this.btnTodosClientes.Text = "Consultar Todos";
            this.btnTodosClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTodosClientes.UseVisualStyleBackColor = false;
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConsultarClientes.FlatAppearance.BorderSize = 0;
            this.btnConsultarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarClientes.ForeColor = System.Drawing.Color.White;
            this.btnConsultarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarClientes.Image")));
            this.btnConsultarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarClientes.Location = new System.Drawing.Point(266, 24);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(146, 40);
            this.btnConsultarClientes.TabIndex = 23;
            this.btnConsultarClientes.Text = "    Consultar";
            this.btnConsultarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarClientes.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblDataNascimento);
            this.panel1.Controls.Add(this.btnExcluirClientes);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.dtDataNascimento);
            this.panel1.Controls.Add(this.maskedTextBox1);
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
            this.panel1.Size = new System.Drawing.Size(609, 408);
            this.panel1.TabIndex = 0;
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
            this.dtDataNascimento.TabIndex = 42;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(298, 155);
            this.maskedTextBox1.Mask = "(99) 0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(197, 32);
            this.maskedTextBox1.TabIndex = 41;
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
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(485, 32);
            this.txtEndereço.TabIndex = 39;
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
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(197, 32);
            this.txtRG.TabIndex = 37;
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
            // btnExcluirClientes
            // 
            this.btnExcluirClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluirClientes.FlatAppearance.BorderSize = 0;
            this.btnExcluirClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirClientes.ForeColor = System.Drawing.Color.White;
            this.btnExcluirClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirClientes.Image")));
            this.btnExcluirClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirClientes.Location = new System.Drawing.Point(229, 450);
            this.btnExcluirClientes.Name = "btnExcluirClientes";
            this.btnExcluirClientes.Size = new System.Drawing.Size(146, 40);
            this.btnExcluirClientes.TabIndex = 35;
            this.btnExcluirClientes.Text = "Excluir";
            this.btnExcluirClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirClientes.UseVisualStyleBackColor = false;
            // 
            // btnAlterarClientes
            // 
            this.btnAlterarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAlterarClientes.FlatAppearance.BorderSize = 0;
            this.btnAlterarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlterarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarClientes.ForeColor = System.Drawing.Color.White;
            this.btnAlterarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarClientes.Image")));
            this.btnAlterarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarClientes.Location = new System.Drawing.Point(229, 404);
            this.btnAlterarClientes.Name = "btnAlterarClientes";
            this.btnAlterarClientes.Size = new System.Drawing.Size(146, 40);
            this.btnAlterarClientes.TabIndex = 34;
            this.btnAlterarClientes.Text = "Alterar";
            this.btnAlterarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarClientes.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarClientes
            // 
            this.btnCadastrarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCadastrarClientes.FlatAppearance.BorderSize = 0;
            this.btnCadastrarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCadastrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarClientes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarClientes.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarClientes.Image")));
            this.btnCadastrarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarClientes.Location = new System.Drawing.Point(106, 358);
            this.btnCadastrarClientes.Name = "btnCadastrarClientes";
            this.btnCadastrarClientes.Size = new System.Drawing.Size(389, 40);
            this.btnCadastrarClientes.TabIndex = 33;
            this.btnCadastrarClientes.Text = "Cadastrar";
            this.btnCadastrarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarClientes.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(485, 32);
            this.txtNome.TabIndex = 32;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(8, 91);
            this.txtCPF.Mask = "999.999.999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(197, 32);
            this.txtCPF.TabIndex = 31;
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
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(3, 252);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 25);
            this.lblemail.TabIndex = 43;
            this.lblemail.Text = "e-mail:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(8, 280);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(485, 32);
            this.txtemail.TabIndex = 44;
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
            // txtCPFClientesConsulta
            // 
            this.txtCPFClientesConsulta.Location = new System.Drawing.Point(63, 30);
            this.txtCPFClientesConsulta.Mask = "999.999.999-99";
            this.txtCPFClientesConsulta.Name = "txtCPFClientesConsulta";
            this.txtCPFClientesConsulta.Size = new System.Drawing.Size(197, 32);
            this.txtCPFClientesConsulta.TabIndex = 33;
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
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.tbControlClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.tbControlClientes.ResumeLayout(false);
            this.tbPageCadastroClientes.ResumeLayout(false);
            this.gbDadosClientes.ResumeLayout(false);
            this.tbPageConsultaClientes.ResumeLayout(false);
            this.gbConsultaClientes.ResumeLayout(false);
            this.gbConsultaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientesConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
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
    }
}