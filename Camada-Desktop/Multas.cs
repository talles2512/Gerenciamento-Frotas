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
    public partial class Multas : Form
    {
        public Multas()
        {
            InitializeComponent();
        }

        private void rdPaga_CheckedChanged(object sender, EventArgs e)
        {
            dtMultaPaga.Enabled = true;
        }

        private void rdNaoPaga_CheckedChanged(object sender, EventArgs e)
        {
            dtMultaPaga.Enabled = false;
        }
    }
}
