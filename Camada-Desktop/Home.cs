﻿using System;
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
        int x = 0;
        int y = 0;

        public frmHome()
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
            AbrirForms(new Manutencoes());
            label2.Text = "Manutenção";
        }

        private void btnAbastecimento_Click(object sender, EventArgs e)
        {
            AbrirForms(new Abastecimentos());
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

        private void btnSeguros_Click(object sender, EventArgs e)
        {
            AbrirForms(new Seguros());
            label2.Text = "Seguros";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 56;
                Point locpict = new Point(62, 7);
                pictureBox1.Location = locpict;
                Point loclabel = new Point(102, 9);
                label2.Location = loclabel;
                this.Width = 732;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                MenuVertical.Width = 250;
                Point locpict = new Point(256, 7);
                pictureBox1.Location = locpict;
                Point loclabel = new Point(296, 9);
                label2.Location = loclabel;
                this.Width = 929;
                this.StartPosition = FormStartPosition.CenterScreen;
            }      
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
            ContextMenu.Show(btnSair, 0, btnSair.Height);
        }

        private void sairOpcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Deslogar?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                LoginSistema login = new LoginSistema();
                login.Show();
            }
        }

        private void loggoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblver_Click(object sender, EventArgs e)
        {
            //Erik INGLESSON
        }
    }
}
