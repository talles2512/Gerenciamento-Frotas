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

namespace CamadaDesktop
{
    public partial class Funcionarios : Form
    {
        private readonly FuncionarioController _funcionarioController;
        private Funcionario Funcionario;

        public Funcionarios()
        {
            InitializeComponent();
            _funcionarioController = InstanciarCamadas();
            Funcionario = null;
        }

        private FuncionarioController InstanciarCamadas()
        {
            Banco banco = new Banco();
            FuncionarioDAL funcionarioDAL = new FuncionarioDAL(banco);
            FuncionarioService funcionarioService = new FuncionarioService(funcionarioDAL);
            return new FuncionarioController(funcionarioService);
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            cbPerfilAcesso.DataSource = Enum.GetValues(typeof(PerfilAcesso));
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "" || txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                PerfilAcesso perfilAcesso = (PerfilAcesso)Enum.Parse(typeof(PerfilAcesso), cbPerfilAcesso.SelectedItem.ToString());

                Funcionario funcionario = new Funcionario(txtnome.Text, txtLogin.Text, txtSenha.Text, perfilAcesso);

                try
                {
                    if (_funcionarioController.Cadastrar(funcionario, txtLogin.Text))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");
                    }
                }
                catch (RegistroExisteException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
