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
    public partial class Veiculos : Form
    {
        public Veiculos()
        {
            InitializeComponent();
        }

        private void rdAlugado_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Enabled = true;
            dtInicio.Enabled = true;
            dtVencimento.Enabled = true;
        }

        private void rdNaoAlugado_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Enabled = false;
            dtInicio.Enabled = false;
            dtVencimento.Enabled = false;
        }
    }
}
