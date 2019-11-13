using CamadaControle.Controllers;
using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CamadaDesktop
{
    public partial class LoginSistema : Form
    {
        int x = 0;
        int y = 0;

        private readonly FuncionarioController _funcionarioController;

        public LoginSistema()
        {
            //Thread t = new Thread(new ThreadStart(StartForm));
            //t.Start();
            //Thread.Sleep(6000);          
            InitializeComponent();
            //t.Abort();
            //this.BringToFront();
            this.MouseDown += new MouseEventHandler(frmHome_MouseDown);
            this.MouseMove += new MouseEventHandler(frmHome_MouseMove);
            _funcionarioController = InstanciarCamadas();
        }

        //public void StartForm()
        //{
        //    Application.Run(new SplashScreen());
        //}

        private FuncionarioController InstanciarCamadas()
        {
            Banco banco = new Banco();
            FuncionarioDAL funcionarioDAL = new FuncionarioDAL(banco);
            FuncionarioService funcionarioService = new FuncionarioService(funcionarioDAL);
            return new FuncionarioController(funcionarioService);
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
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Insira o usuário e a senha corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Funcionario funcionario = _funcionarioController.BuscarCPF(txtLogin.Text);
                    if (funcionario == null)
                    {
                        MessageBox.Show("Usuário inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (txtLogin.Text == funcionario.Login)
                        {
                            if (txtSenha.Text == funcionario.Senha)
                            {
                                PerfilAcesso perfilAcesso = funcionario.PerfilAcesso;
                                this.Hide();
                                frmHome home = new frmHome(perfilAcesso);
                                home.FormClosed += new FormClosedEventHandler(fecharhome);
                                home.Show();
                                txtLogin.Text = "";
                                txtSenha.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Senha inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (ConcorrenciaBancoException)
                {
                    MessageBox.Show("Sistema em Manutenção. Contate seu Administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void fecharhome(object sender, FormClosedEventArgs e)
        {
            this.Show();
            AtualizarCor();
        }

        public void AtualizarCor()
        {
            this.BackColor = Properties.Settings.Default.myColorFundo;
            panelLogin.BackColor = Properties.Settings.Default.myColor;
            btnLoginSistema.BackColor = Properties.Settings.Default.myColor;
            label3.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            lblver.ForeColor = Properties.Settings.Default.myColorFonteMenu;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoginSistema_Click(sender, e);
            }
        }

        private void TxtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(txtSenha.Text == "")
                {
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    btnLoginSistema_Click(sender, e);
                }
            }
        }
    }
}
