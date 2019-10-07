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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void AbrirForms(object FormsFilhos)
        {
            if (this.panelConteudo.Controls.Count > 0)
                this.panelConteudo.Controls.RemoveAt(0);
            Form ff = FormsFilhos as Form;
            ff.TopLevel = false;
            ff.Dock = DockStyle.Fill;
            this.panelConteudo.Controls.Add(ff);
            this.panelConteudo.Tag = ff;
           ff.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            pbLogo_Click(null, e);
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            AbrirForms(new Veiculos());
            label2.Text = "Veículos";
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMotorista_Click(object sender, EventArgs e)
        {
            AbrirForms(new Motoristas());
            label2.Text = "Motoristas";
        }

        private void btnEntradaSaida_Click(object sender, EventArgs e)
        {
            AbrirForms(new EntradaSaida());
            label2.Text = "Entrada/Saída";
        }

        private void btnConveniados_Click(object sender, EventArgs e)
        {
            AbrirForms(new ServicoExterno_Conveniados());
            label2.Text = "Serviços Externos";
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            AbrirForms(new PanelHome());
            label2.Text = "Home";
        }

        private void btnViagem_Click(object sender, EventArgs e)
        {
            AbrirForms(new Viagens());
            label2.Text = "Viagens";
        }

        private void btnManutencao_Click(object sender, EventArgs e)
        {
            AbrirForms(new Manutencao());
            label2.Text = "Manutenção";
        }

        private void btnAbastecimento_Click(object sender, EventArgs e)
        {
            AbrirForms(new Abastecimento());
            label2.Text = "Abastecimento";
        }

        private void btnMultas_Click(object sender, EventArgs e)
        {
            AbrirForms(new Multas());
            label2.Text = "Multas";
        }
       private void btnSinistros_Click(object sender, EventArgs e)
        {
            AbrirForms(new Sinistros());
            label2.Text = "Sinistros";
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AbrirForms(new EstoquePecas());
            label2.Text = "Estoque";
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirForms(new Funcionarios());
            label2.Text = "Funcionários";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForms(new Clientes());
            label2.Text = "Clientes";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)

            {

                MenuVertical.Width = 58;
            }

            else

                MenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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
