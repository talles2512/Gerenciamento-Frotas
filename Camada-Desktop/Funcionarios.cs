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
        private List<Funcionario> ListaFuncionarios;
        private Funcionario Funcionario;
        string loginantigo;

        public Funcionarios()
        {
            InitializeComponent();
            _funcionarioController = InstanciarCamadas();
            Funcionario = null;
            loginantigo = "";
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
            cbPerfilAcesso.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPerfilAcesso.AutoCompleteSource = AutoCompleteSource.ListItems;

            tooltipPesquisar.SetToolTip(lbPesquisar, "Pesquise pelo Nome ou Login do Funcionário.");
            tooltipPesquisar.Hide(lbPesquisar);

            toolTipTransfere.SetToolTip(this.btnTrasferirFuncionario, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirFuncionario);

            cbPerfilAcesso.DataSource = Enum.GetValues(typeof(PerfilAcesso));
            AtualizarCor();
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
                        txtnome.Text = "";
                        txtLogin.Text = "";
                        txtSenha.Text = "";
                        cbPerfilAcesso.Text = "";
                        loginantigo = "";
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
            if (txtLoginFuncionarioConsulta.Text == "")
            {
                MessageBox.Show("Preencha o campo do Login!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                        dt.Rows.Add(funcionario.Nome, funcionario.Login, funcionario.Senha, funcionario.PerfilAcesso.ToString());

                        dgFuncionarioConsulta.DataSource = dt;

                        Funcionario = funcionario;
                        ListaFuncionarios = new List<Funcionario>();
                        ListaFuncionarios.Add(funcionario);
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
            panelConsultarPorData.Visible = true;
        }

        private void btnConsultarPorData_Click(object sender, EventArgs e)
        {
            TimeSpan dtlimite = Convert.ToDateTime(dtFimConsulta.Value).Subtract(Convert.ToDateTime(dtInicioConsulta.Value));

            if (dtlimite.TotalDays >= 93)
            {
                MessageBox.Show("Ops, limite maximo atingido! Pesquise no prazo maximo de três meses.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dtFimConsulta.Value < dtInicioConsulta.Value)
                {
                    MessageBox.Show("A Data final deve ser maior que a data de início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        List<Funcionario> funcionarios = _funcionarioController.BuscarTodos(dtInicioConsulta.Value, dtFimConsulta.Value);

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("Login", typeof(string));
                        dt.Columns.Add("Senha", typeof(string));
                        dt.Columns.Add("Perfil de Acesso", typeof(string));

                        foreach (Funcionario funcionario in funcionarios)
                        {
                            dt.Rows.Add(funcionario.Nome, funcionario.Login, funcionario.Senha, funcionario.PerfilAcesso.ToString());
                        }
                        ListaFuncionarios = funcionarios;
                        dgFuncionarioConsulta.DataSource = dt;

                    }
                    catch (ConcorrenciaBancoException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
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
                cbPerfilAcesso.SelectedItem = Funcionario.PerfilAcesso.ToString();

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");

                tbControlFuncionario.SelectTab("tbPageCadastroFuncionario");
                if (tbControlFuncionario.SelectedTab == tbPageCadastroFuncionario)
                {
                    Funcionario = null;
                    txtLoginFuncionarioConsulta.Text = "";

                    btnCadastrarFuncionario.Visible = false;
                    lblCancelar.Visible = true;
                    btnAlterarFuncionario.Enabled = true;
                    btnExcluirFuncionario.Enabled = true;
                }
            }
        }

        private void dgFuncionarioConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgFuncionarioConsulta.DataSource == null)
            {

            }
            else if (dgFuncionarioConsulta.CurrentRow.Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                string login = dgFuncionarioConsulta.CurrentRow.Cells[1].Value.ToString();

                foreach (Funcionario funcionario in ListaFuncionarios)
                {
                    if (funcionario.Login == login)
                    {
                        txtnome.Text = funcionario.Nome;
                        txtLogin.Text = funcionario.Login;
                        txtSenha.Text = funcionario.Senha;
                        cbPerfilAcesso.SelectedItem = funcionario.PerfilAcesso.ToString();

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");

                        tbControlFuncionario.SelectTab("tbPageCadastroFuncionario");
                        if (tbControlFuncionario.SelectedTab == tbPageCadastroFuncionario)
                        {
                            Funcionario = null;
                            txtLoginFuncionarioConsulta.Text = "";

                            btnCadastrarFuncionario.Visible = false;
                            lblCancelar.Visible = true;
                            btnAlterarFuncionario.Enabled = true;
                            btnExcluirFuncionario.Enabled = true;
                        }
                    }
                }
                textPesquisar.Text = "";
                dgFuncionarioConsulta.DataSource = null;
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
                    if (loginantigo == "")
                    {
                        loginantigo = funcionario.Login;
                    }
                    if (_funcionarioController.Alterar(funcionario, loginantigo))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        txtnome.Text = "";
                        txtLogin.Text = "";
                        txtSenha.Text = "";
                        cbPerfilAcesso.SelectedItem = cbPerfilAcesso.Items[0];
                        loginantigo = "";

                        btnCadastrarFuncionario.Visible = true;
                        lblCancelar.Visible = false;
                        btnAlterarFuncionario.Enabled = false;
                        btnExcluirFuncionario.Enabled = false;
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
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Preencha o campo Login corretamente para realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_funcionarioController.Deletar(txtLogin.Text))
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");
                            txtnome.Text = "";
                            txtLogin.Text = "";
                            txtSenha.Text = "";
                            cbPerfilAcesso.SelectedItem = cbPerfilAcesso.Items[0];

                            btnCadastrarFuncionario.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarFuncionario.Enabled = false;
                            btnExcluirFuncionario.Enabled = false;
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

        public void AtualizarCor()
        {
            this.BackColor = Properties.Settings.Default.myColorFundo;

            btnCadastrarFuncionario.BackColor = Properties.Settings.Default.myColor;
            btnConsultarFuncionario.BackColor = Properties.Settings.Default.myColor;
            btnTodosFuncionario.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirFuncionario.BackColor = Properties.Settings.Default.myColor;
            btnAlterarFuncionario.BackColor = Properties.Settings.Default.myColor;

            btnCadastrarFuncionario.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarFuncionario.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodosFuncionario.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirFuncionario.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarFuncionario.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            btnConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            panelConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            btnConsultarPorData.ForeColor = Properties.Settings.Default.myColorFonteMenu;
        }

        private void panelConsultarPorData_MouseLeave(object sender, EventArgs e)
        {
            panelConsultarPorData.Visible = false;
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar manipulação de dados?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtnome.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
                cbPerfilAcesso.SelectedItem = cbPerfilAcesso.Items[0];

                btnCadastrarFuncionario.Visible = true;
                lblCancelar.Visible = false;
                btnAlterarFuncionario.Enabled = false;
                btnExcluirFuncionario.Enabled = false;

                Funcionario = null;
            }
        }

        private void TextPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Funcionario> funcionarios = _funcionarioController.Pesquisar(textPesquisar.Text);

                DataTable dt = new DataTable();
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Login", typeof(string));
                dt.Columns.Add("Senha", typeof(string));
                dt.Columns.Add("Perfil de Acesso", typeof(string));

                foreach (Funcionario funcionario in funcionarios)
                {
                    dt.Rows.Add(funcionario.Nome, funcionario.Login, funcionario.Senha, funcionario.PerfilAcesso.ToString());
                }
                ListaFuncionarios = funcionarios;
                dgFuncionarioConsulta.DataSource = dt;

            }
            catch (ConcorrenciaBancoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
