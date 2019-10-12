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

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            if (txtLoginFuncionarioConsulta.Text == "" || txtLoginFuncionarioConsulta.Text.Length < 7)
            {
                MessageBox.Show("Preencha o campo da Login!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Funcionario funcionario = _funcionarioController.BuscarCPF(txtLoginFuncionarioConsulta.Text);
                    if (funcionario == null)
                    {
                        MessageBox.Show("Não existe cadastro com esse CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("Login", typeof(string));
                        dt.Columns.Add("Senha", typeof(string));
                        dt.Columns.Add("Perfil de Acesso", typeof(string));

                        dt.Rows.Add(funcionario.Nome, funcionario.Login, funcionario.Senha, funcionario.PerfilAcesso);

                        dgFuncionarioConsulta.DataSource = dt;

                        Funcionario = funcionario;
                        funcionario = null;
                    }

                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnTodosFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                List<Funcionario> funcionarios = _funcionarioController.BuscarTodos();

                DataTable dt = new DataTable();
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Login", typeof(string));
                dt.Columns.Add("Senha", typeof(string));
                dt.Columns.Add("Perfil de Acesso", typeof(string));

                foreach (Funcionario funcionario in funcionarios)
                {
                    dt.Rows.Add(funcionario.Nome, funcionario.Login, funcionario.Senha, funcionario.PerfilAcesso);
                }

                dgFuncionarioConsulta.DataSource = dt;

            }
            catch (ConcorrenciaBancoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTrasferirFuncionario_Click(object sender, EventArgs e)
        {
            if (Funcionario == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtnome.Text = Funcionario.Nome;
                txtLogin.Text = Funcionario.Login;
                txtSenha.Text = Funcionario.Senha;
                cbPerfilAcesso.SelectedItem = Funcionario.PerfilAcesso;

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");

                tbControlFuncionario.SelectTab("tbPageCadastroFuncionario");
                if (tbControlFuncionario.SelectedTab == tbPageCadastroFuncionario)
                {
                    Funcionario = null;
                }
            }
        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
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
                    if (_funcionarioController.Alterar(funcionario, txtLogin.Text))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        txtnome.Text = "";
                        txtLogin.Text = "";
                        txtSenha.Text = "";
                        cbPerfilAcesso.ResetText(); 
                    }
                }
                catch (NaoEncontradoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "   -")
            {
                MessageBox.Show("Preencha o campo Login corretamente para realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Deseja realmente inativar?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_funcionarioController.Deletar(txtLogin.Text))
                        {
                            MessageBox.Show("Inativação realizada com Sucesso!");
                            txtnome.Text = "";
                            txtLogin.Text = "";
                            txtSenha.Text = "";
                            cbPerfilAcesso.ResetText();
                        }
                    }
                }
                catch (NaoEncontradoException ex)
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
