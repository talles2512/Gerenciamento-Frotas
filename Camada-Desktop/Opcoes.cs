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
            toolTipcor.SetToolTip(this.btncormenu, "Visualizar Cor dos Menus");
            toolTipcor.Hide(btncormenu);
            toolTippersonalizarcor.SetToolTip(this.btnPersonalizarCor, "Personalizar Cor dos Menus");
            toolTippersonalizarcor.Hide(btnPersonalizarCor);
            toolTipcorfundo.SetToolTip(this.btncorfundo, "Visualizar Cor do Fundo");
            toolTipcorfundo.Hide(btncorfundo);
            toolTippersonalizefundo.SetToolTip(this.btnpersonalizarfundo, "Personalizar Cor do Fundo");
            toolTippersonalizefundo.Hide(btnpersonalizarfundo);
            toolTipcorfonte.SetToolTip(this.btncorfonte, "Visualizar Cor das Fontes dos Menus");
            toolTipcorfonte.Hide(btncorfonte);
            toolTippersonalizefonte.SetToolTip(this.btnpersonalizarfontemenu, "Personalizar Cor das Fontes dos Menus");
            toolTippersonalizefonte.Hide(btnpersonalizarfontemenu);
            toolTipundo.SetToolTip(this.btnundo, "Redefenir Opções do Sistema");
            toolTipundo.Hide(btnundo);
            toolTipfechar.SetToolTip(this.iconcerrar, "Fechar Opções");
            toolTipfechar.Hide(btnundo);


            panelOpc.BackColor = Properties.Settings.Default.myColor;
            btncormenu.BackColor = Properties.Settings.Default.myColor;
            btncorfundo.BackColor = Properties.Settings.Default.myColorFundo;
            this.BackColor = Properties.Settings.Default.myColorFundo;
            btncorfonte.BackColor = Properties.Settings.Default.myColorFonteMenu;
            lblOpc.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            lblver.ForeColor = Properties.Settings.Default.myColorFonteMenu;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnPersonalizarCor_Click(object sender, EventArgs e)
        {
            if (boxcor.ShowDialog() == DialogResult.OK)
            {
                btncormenu.BackColor = boxcor.Color;
                panelOpc.BackColor = boxcor.Color;
                Properties.Settings.Default.myColor = boxcor.Color;
            }
        }

        private void btnpersonalizarfundo_Click(object sender, EventArgs e)
        {
            if (boxcor.ShowDialog() == DialogResult.OK)
            {
                btncorfundo.BackColor = boxcor.Color;
                this.BackColor = boxcor.Color;
                Properties.Settings.Default.myColorFundo = boxcor.Color;
            }
        }

        private void btnpersonalizarfontemenu_Click(object sender, EventArgs e)
        {
            if (boxcor.ShowDialog() == DialogResult.OK)
            {
                btncorfonte.BackColor = boxcor.Color;
                lblOpc.ForeColor = boxcor.Color;
                lblver.ForeColor = boxcor.Color;
                Properties.Settings.Default.myColorFonteMenu = boxcor.Color;
            }
        }

        private void btnundo_Click(object sender, EventArgs e)
        {
            btncormenu.BackColor = Color.FromArgb(0, 122, 204);
            panelOpc.BackColor = Color.FromArgb(0, 122, 204);
            Properties.Settings.Default.myColor = btncormenu.BackColor;

            btncorfundo.BackColor = Color.FromKnownColor(KnownColor.Control);
            this.BackColor = Color.FromKnownColor(KnownColor.Control);
            Properties.Settings.Default.myColorFundo = btncorfundo.BackColor;


            btncorfonte.BackColor = Color.White;
            lblOpc.ForeColor = Color.White;
            lblver.ForeColor = Color.White;
            Properties.Settings.Default.myColorFonteMenu = btncorfonte.BackColor;

        }
    }
}
