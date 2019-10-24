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
    public partial class PanelHome : Form
    {
        public PanelHome()
        {
            InitializeComponent();
        }

        private void PanelHome_Load(object sender, EventArgs e)
        {
            AtualizarCor();
        }

        public void AtualizarCor()
        {
            this.BackColor = Properties.Settings.Default.myColorFundo;
        }
    }
}
