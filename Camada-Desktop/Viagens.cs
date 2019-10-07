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
    public partial class Viagens : Form
    {
        public Viagens()
        {
            InitializeComponent();
        }

        private void rdOcupante_CheckedChanged(object sender, EventArgs e)
        {
            gbOcupante.Enabled = true;
        }

        private void rdsemOcupante_CheckedChanged(object sender, EventArgs e)
        {
            gbOcupante.Enabled = false;
        }
    }
}
