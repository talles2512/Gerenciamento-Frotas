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
    public partial class Opcoes : Form
    {
        int x = 0;
        int y = 0;
        Color cor;

        public Opcoes()
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

        public void Opcoes_Load(object sender, EventArgs e)
        {
            cor = panelOpc.BackColor;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Opcoes_Load(this, new EventArgs());
            frmHome frmhome = new frmHome();
            frmhome.frmHome_Load(this, new EventArgs());
            this.Close();
        }

        public Color RecebeCor()
        {
            return cor;
        }

        private void btncorazul_Click(object sender, EventArgs e)
        {
            panelOpc.BackColor = Color.FromArgb(0, 122, 204);
            cor = panelOpc.BackColor;
        }

        private void btncorverde_Click(object sender, EventArgs e)
        {
            panelOpc.BackColor = Color.FromArgb(0, 64, 0);
            cor = panelOpc.BackColor;
        }

        private void btncorvermelho_Click(object sender, EventArgs e)
        {
            panelOpc.BackColor = Color.FromArgb(192, 0, 0);
            cor = panelOpc.BackColor;
        }

        private void btncoramarelo_Click(object sender, EventArgs e)
        {
            panelOpc.BackColor = Color.FromArgb(192, 192, 0);
            cor = panelOpc.BackColor;
        }
    }
}
