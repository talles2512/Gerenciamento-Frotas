namespace CamadaDesktop
{
    partial class Opcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opcoes));
            this.lblOpc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelOpc = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncoramarelo = new CamadaDesktop.RoundBtn();
            this.btncorvermelho = new CamadaDesktop.RoundBtn();
            this.btncorverde = new CamadaDesktop.RoundBtn();
            this.btncorazul = new CamadaDesktop.RoundBtn();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelOpc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpc
            // 
            this.lblOpc.AutoSize = true;
            this.lblOpc.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpc.ForeColor = System.Drawing.Color.White;
            this.lblOpc.Location = new System.Drawing.Point(47, 9);
            this.lblOpc.Name = "lblOpc";
            this.lblOpc.Size = new System.Drawing.Size(76, 32);
            this.lblOpc.TabIndex = 4;
            this.lblOpc.Text = "Opções";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panelOpc
            // 
            this.panelOpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelOpc.Controls.Add(this.lblOpc);
            this.panelOpc.Controls.Add(this.pictureBox1);
            this.panelOpc.Location = new System.Drawing.Point(-1, 0);
            this.panelOpc.Name = "panelOpc";
            this.panelOpc.Size = new System.Drawing.Size(266, 49);
            this.panelOpc.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncoramarelo);
            this.groupBox1.Controls.Add(this.btncorvermelho);
            this.groupBox1.Controls.Add(this.btncorverde);
            this.groupBox1.Controls.Add(this.btncorazul);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cores";
            // 
            // btncoramarelo
            // 
            this.btncoramarelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btncoramarelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncoramarelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncoramarelo.Location = new System.Drawing.Point(184, 31);
            this.btncoramarelo.Name = "btncoramarelo";
            this.btncoramarelo.Size = new System.Drawing.Size(52, 52);
            this.btncoramarelo.TabIndex = 10;
            this.btncoramarelo.UseVisualStyleBackColor = false;
            this.btncoramarelo.Click += new System.EventHandler(this.btncoramarelo_Click);
            // 
            // btncorvermelho
            // 
            this.btncorvermelho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncorvermelho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncorvermelho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncorvermelho.Location = new System.Drawing.Point(126, 31);
            this.btncorvermelho.Name = "btncorvermelho";
            this.btncorvermelho.Size = new System.Drawing.Size(52, 52);
            this.btncorvermelho.TabIndex = 9;
            this.btncorvermelho.UseVisualStyleBackColor = false;
            this.btncorvermelho.Click += new System.EventHandler(this.btncorvermelho_Click);
            // 
            // btncorverde
            // 
            this.btncorverde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncorverde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncorverde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncorverde.Location = new System.Drawing.Point(68, 31);
            this.btncorverde.Name = "btncorverde";
            this.btncorverde.Size = new System.Drawing.Size(52, 52);
            this.btncorverde.TabIndex = 8;
            this.btncorverde.UseVisualStyleBackColor = false;
            this.btncorverde.Click += new System.EventHandler(this.btncorverde_Click);
            // 
            // btncorazul
            // 
            this.btncorazul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncorazul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncorazul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncorazul.Location = new System.Drawing.Point(10, 31);
            this.btncorazul.Name = "btncorazul";
            this.btncorazul.Size = new System.Drawing.Size(52, 52);
            this.btncorazul.TabIndex = 0;
            this.btncorazul.UseVisualStyleBackColor = false;
            this.btncorazul.Click += new System.EventHandler(this.btncorazul_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(225, 55);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 8;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 396);
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelOpc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Opcoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelOpc.ResumeLayout(false);
            this.panelOpc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOpc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelOpc;
        private System.Windows.Forms.GroupBox groupBox1;
        private RoundBtn btncoramarelo;
        private RoundBtn btncorvermelho;
        private RoundBtn btncorverde;
        private RoundBtn btncorazul;
        private System.Windows.Forms.PictureBox iconcerrar;
    }
}