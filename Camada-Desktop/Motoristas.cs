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
    public partial class Motoristas : Form
    {
        public Motoristas()
        {
            InitializeComponent();
        }

        private void btnAddExameMedico_Click_1(object sender, EventArgs e)
        {
            tbControlMotorista.SelectedTab = tbPageExames;
        }
    }
}
