﻿using CamadaControle.Controllers;
using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
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
    public partial class Clientes : Form
    {
        private readonly ClienteController _clienteController;
        private Cliente Cliente;
        string cpfantigo;

        public Clientes()
        {
            InitializeComponent();
            _clienteController = InstanciarCamadas();
            Cliente = null;
            cpfantigo = "";
        }

        private ClienteController InstanciarCamadas()
        {
            Banco banco = new Banco();
            ClienteDAL clienteDAL = new ClienteDAL(banco);
            ClienteService clienteService = new ClienteService(clienteDAL);
            return new ClienteController(clienteService);
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            AtualizarCor();
        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCPF.Text == "" || txtCPF.Text.Length < 12 || txtRG.Text == "" || txtTelefone.Text == "" || txtEndereço.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPF.Text;
                string Telefone = txtTelefone.Text;

                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                    Telefone = Telefone.Replace(str, "");
                }

                long telefone = long.Parse(Telefone);
                DateTime? dtinicio = DateTime.Today;


                Cliente cliente = new Cliente(cpf, txtNome.Text, txtRG.Text, txtEndereço.Text, telefone, txtemail.Text, dtDataNascimento.Value, dtinicio);

                try
                {
                    if (_clienteController.Cadastrar(cliente, cpf))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");
                        txtNome.Text = "";
                        txtCPF.Text = "";
                        txtEndereço.Text = "";
                        txtemail.Text = "";
                        txtRG.Text = "";
                        txtTelefone.Text = "";
                        dtDataNascimento.Text = "";
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

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            if (txtCPFClientesConsulta.Text == "" || txtCPFClientesConsulta.Text.Length < 12)
            {
                MessageBox.Show("Preencha o campo do CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPFClientesConsulta.Text;
                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                }

                try
                {
                    Cliente cliente = _clienteController.BuscarCPF(cpf);
                    if (cliente == null)
                    {
                        MessageBox.Show("Não existe cadastro com esse CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("CPF", typeof(string));
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("RG", typeof(string));
                        dt.Columns.Add("Endereço", typeof(string));
                        dt.Columns.Add("e-mail", typeof(string));
                        dt.Columns.Add("Data Nascimento", typeof(DateTime));
                        dt.Columns.Add("Data Inicio Contrato", typeof(DateTime));

                        dt.Rows.Add(cliente.CPF, cliente.Nome, cliente.RG
                                    , cliente.Endereco, cliente.Email, cliente.DataNascimento, cliente.DataInicioContrato);

                        dgClientesConsulta.DataSource = dt;
                    }
                    Cliente = cliente;
                    cliente = null;
                }
                catch (ConcorrenciaBancoException)
                {
                    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                }
            }
        }

        private void btnTodosClientes_Click(object sender, EventArgs e)
        {
            panelConsultarPorData.Visible = true;
        }

        private void btnConsultarPorData_Click(object sender, EventArgs e)
        {
            if (dtFimConsulta.Value < dtInicioConsulta.Value)
            {
                MessageBox.Show("A Data Final deve ser maior que a data de Início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                try
                {
                    List<Cliente> clientes = _clienteController.BuscarTodos(dtInicioConsulta.Value, dtFimConsulta.Value);

                    DataTable dt = new DataTable();
                    dt.Columns.Add("CPF", typeof(string));
                    dt.Columns.Add("Nome", typeof(string));
                    dt.Columns.Add("RG", typeof(string));
                    dt.Columns.Add("Endereço", typeof(string));
                    dt.Columns.Add("e-mail", typeof(string));
                    dt.Columns.Add("Data Nascimento", typeof(DateTime));
                    dt.Columns.Add("Data Inicio Contrato", typeof(DateTime));

                    foreach (Cliente cliente in clientes)
                    {

                        dt.Rows.Add(cliente.CPF, cliente.Nome, cliente.RG
                            , cliente.Endereco, cliente.Email, cliente.DataNascimento, cliente.DataInicioContrato);
                    }

                    dgClientesConsulta.DataSource = dt;

                }
                catch (ConcorrenciaBancoException)
                {
                    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                }
            }
        }

        private void btnTrasferirClientes_Click(object sender, EventArgs e)
        {
            if (Cliente == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtCPF.Text = Cliente.CPF;
                cpfantigo = Cliente.CPF;
                txtNome.Text = Cliente.Nome;
                txtRG.Text = Cliente.RG;
                txtEndereço.Text = Cliente.Endereco;
                txtTelefone.Text = Cliente.Telefone.ToString();
                txtemail.Text = Cliente.Email;
                dtDataNascimento.Value = Cliente.DataNascimento;
                lblrecebedata.Text = Cliente.DataInicioContrato.ToString();

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlClientes.SelectTab("tbPageCadastroClientes");
                if (tbControlClientes.SelectedTab == tbPageCadastroClientes)
                {
                    txtCPFClientesConsulta.Text = "";
                    Cliente = null;
                }
            }
        }

        private void dgClientesConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cliente == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtCPF.Text = Cliente.CPF;
                txtNome.Text = Cliente.Nome;
                txtRG.Text = Cliente.RG;
                txtEndereço.Text = Cliente.Endereco;
                txtTelefone.Text = Cliente.Telefone.ToString();
                txtemail.Text = Cliente.Email;
                dtDataNascimento.Value = Cliente.DataNascimento;
                lblrecebedata.Text = Cliente.DataInicioContrato.ToString();

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlClientes.SelectTab("tbPageCadastroClientes");
                if (tbControlClientes.SelectedTab == tbPageCadastroClientes)
                {
                    txtCPFClientesConsulta.Text = "";
                    Cliente = null;
                }
            }
        }

        private void btnAlterarClientes_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCPF.Text == "" || txtCPF.Text.Length < 12 || txtRG.Text == "" || txtTelefone.Text == "" || txtEndereço.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPF.Text;
                string Telefone = txtTelefone.Text;

                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                    Telefone = Telefone.Replace(str, "");
                }

                long telefone = long.Parse(Telefone);
                DateTime? datainicio = DateTime.Parse(lblrecebedata.Text);

                Cliente cliente = new Cliente(cpf, txtNome.Text, txtRG.Text, txtEndereço.Text, telefone, txtemail.Text, dtDataNascimento.Value, datainicio);
                try
                {
                    if (_clienteController.Alterar(cliente, cpfantigo))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        cpfantigo = "";
                        txtNome.Text = "";
                        txtCPF.Text = "";
                        txtEndereço.Text = "";
                        txtemail.Text = "";
                        txtRG.Text = "";
                        txtTelefone.Text = "";
                        dtDataNascimento.Text = "";
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

        private void btnExcluirClientes_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                MessageBox.Show("Preencha o campo CPF corretamente para realizar esta opereção!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPF.Text;
                string Telefone = txtTelefone.Text;

                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                    Telefone = Telefone.Replace(str, "");
                }

                try
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_clienteController.Deletar(cpf))
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");
                            txtNome.Text = "";
                            txtCPF.Text = "";
                            txtEndereço.Text = "";
                            txtemail.Text = "";
                            txtRG.Text = "";
                            txtTelefone.Text = "";
                            dtDataNascimento.Text = "";
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

            btnCadastrarClientes.BackColor = Properties.Settings.Default.myColor;
            btnConsultarClientes.BackColor = Properties.Settings.Default.myColor;
            btnTodosClientes.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirClientes.BackColor = Properties.Settings.Default.myColor;
            btnAlterarClientes.BackColor = Properties.Settings.Default.myColor;

            panelConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            btnConsultarPorData.BackColor = Properties.Settings.Default.myColor;

            btnCadastrarClientes.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarClientes.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodosClientes.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirClientes.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarClientes.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            btnConsultarPorData.ForeColor = Properties.Settings.Default.myColorFonteMenu;
        }

        private void panelConsultarPorData_MouseLeave(object sender, EventArgs e)
        {
            panelConsultarPorData.Visible = false;
        }
    }
}

