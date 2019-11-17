using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaModelagem.Data.Configuration;

namespace CamadaDesktop
{
    public partial class SplashScreen : Form
    {
        int contador = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //intervalo para o tick de 6 segundos;
            timer1.Interval = 6000;
            //Criar metodos de verificação de conexão BANCO;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(contador < 1)
            {
                contador++;
                try
                {
                    int teste = new Banco().TestarConexao();
                    LoginSistema login = new LoginSistema();
                    login.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro de Conexão! Contate seu Administrador para saber mais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }        
            }
            
        }
    }
}
