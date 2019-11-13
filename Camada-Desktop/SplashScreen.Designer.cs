namespace CamadaDesktop
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pnSS = new System.Windows.Forms.Panel();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblver = new System.Windows.Forms.Label();
            this.lblgf = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSS
            // 
            this.pnSS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSS.BackgroundImage")));
            this.pnSS.Controls.Add(this.lblCarregando);
            this.pnSS.Controls.Add(this.pictureBox2);
            this.pnSS.Controls.Add(this.lblver);
            this.pnSS.Controls.Add(this.lblgf);
            this.pnSS.Controls.Add(this.pictureBox1);
            this.pnSS.Location = new System.Drawing.Point(-52, -160);
            this.pnSS.Name = "pnSS";
            this.pnSS.Size = new System.Drawing.Size(677, 410);
            this.pnSS.TabIndex = 0;
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.BackColor = System.Drawing.Color.Transparent;
            this.lblCarregando.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblCarregando.Location = new System.Drawing.Point(569, 357);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(68, 20);
            this.lblCarregando.TabIndex = 51;
            this.lblCarregando.Text = "Carregando";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(501, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 190);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // lblver
            // 
            this.lblver.AutoSize = true;
            this.lblver.BackColor = System.Drawing.Color.Transparent;
            this.lblver.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblver.ForeColor = System.Drawing.Color.Black;
            this.lblver.Location = new System.Drawing.Point(629, 165);
            this.lblver.Name = "lblver";
            this.lblver.Size = new System.Drawing.Size(42, 18);
            this.lblver.TabIndex = 50;
            this.lblver.Text = "ver. 1.0";
            // 
            // lblgf
            // 
            this.lblgf.AutoSize = true;
            this.lblgf.BackColor = System.Drawing.Color.Transparent;
            this.lblgf.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgf.Location = new System.Drawing.Point(274, 205);
            this.lblgf.Name = "lblgf";
            this.lblgf.Size = new System.Drawing.Size(182, 39);
            this.lblgf.TabIndex = 1;
            this.lblgf.Text = "GERENCFROTAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 247);
            this.Controls.Add(this.pnSS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.pnSS.ResumeLayout(false);
            this.pnSS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSS;
        private System.Windows.Forms.Label lblgf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.Label lblver;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}