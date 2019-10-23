using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaDesktop
{
    public partial class LoginSistema : Form
    {
        int x = 0;
        int y = 0;

        public LoginSistema()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(frmHome_MouseDown);
            this.MouseMove += new MouseEventHandler(frmHome_MouseMove);
        }

        private void frmHome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            x = this.Left - MousePosition.X;
            y = this.Top - MousePosition.Y;
        }

        private void frmHome_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = x + MousePosition.X;
            this.Top = y + MousePosition.Y;
        }
        private void btnLoginSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.FormClosed += new FormClosedEventHandler(fecharhome);
            home.Show();
        }

        private void fecharhome(object sender, FormClosedEventArgs e)
        {
            this.Show();
            AtualizarCor();
        }

        public void AtualizarCor()
        {
            panelLogin.BackColor = Properties.Settings.Default.myColor;
            btnLoginSistema.BackColor = Properties.Settings.Default.myColor;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
