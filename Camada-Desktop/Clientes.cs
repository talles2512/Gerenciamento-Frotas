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
    public partial class Clientes : Form
    {
        private readonly ClienteController _clienteController;
        private List<Cliente> ListaClientes;
        private Cliente Cliente;
        string cpfantigo;
        PerfilAcesso PerfilAcesso;

        public Clientes()
        {
            InitializeComponent();
            _clienteController = InstanciarCamadas();
            Cliente = null;
            cpfantigo = "";
        }

        public Clientes(PerfilAcesso perfilAcesso)
        {
            InitializeComponent();
            _clienteController = InstanciarCamadas();
            Cliente = null;
            cpfantigo = "";
            PerfilAcesso = perfilAcesso;
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
            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao.Visible = true;
                toolTipPermissao.SetToolTip(this.pbpermissao, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao.Hide(pbpermissao);
            }

            tooltipPesquisar.SetToolTip(lbPesquisar, "Pesquise pelo Nome, CPF ou email do Cliente.");
            tooltipPesquisar.Hide(lbPesquisar);
            toolTipTransfere.SetToolTip(this.btnTrasferirClientes, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirClientes);
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
                    ListaClientes = new List<Cliente>();
                    ListaClientes.Add(cliente);
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
                        ListaClientes = clientes;
                        dgClientesConsulta.DataSource = dt;

                    }
                    catch (ConcorrenciaBancoException)
                    {
                        throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                    }
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

                    btnCadastrarClientes.Visible = false;
                    lblCancelar.Visible = true;
                    btnAlterarClientes.Enabled = true;

                    if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                    {
                        btnExcluirClientes.Enabled = false;
                    }
                    else
                    {
                        btnExcluirClientes.Enabled = true;
                    }
                }
            }
        }

        private void dgClientesConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgClientesConsulta.DataSource == null)
            {

            }
            else if (dgClientesConsulta.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                string cpf = dgClientesConsulta.CurrentRow.Cells[0].Value.ToString();

                foreach (Cliente cliente in ListaClientes)
                {
                    if (cliente.CPF == cpf)
                    {
                        txtCPF.Text = cliente.CPF;
                        cpfantigo = cliente.CPF;
                        txtNome.Text = cliente.Nome;
                        txtRG.Text = cliente.RG;
                        txtEndereço.Text = cliente.Endereco;
                        txtTelefone.Text = cliente.Telefone.ToString();
                        txtemail.Text = cliente.Email;
                        dtDataNascimento.Value = cliente.DataNascimento;
                        lblrecebedata.Text = cliente.DataInicioContrato.ToString();

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                        tbControlClientes.SelectTab("tbPageCadastroClientes");
                        if (tbControlClientes.SelectedTab == tbPageCadastroClientes)
                        {
                            txtCPFClientesConsulta.Text = "";
                            Cliente = null;

                            btnCadastrarClientes.Visible = false;
                            lblCancelar.Visible = true;
                            btnAlterarClientes.Enabled = true;

                            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                            {
                                btnExcluirClientes.Enabled = false;
                            }
                            else
                            {
                                btnExcluirClientes.Enabled = true;
                            }
                        }
                    }
                }
                textPesquisar.Text = "";
                dgClientesConsulta.DataSource = null;
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

                        btnCadastrarClientes.Visible = true;
                        lblCancelar.Visible = false;
                        btnAlterarClientes.Enabled = false;
                        btnExcluirClientes.Enabled = false;
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

                            btnCadastrarClientes.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarClientes.Enabled = false;
                            btnExcluirClientes.Enabled = false;
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

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar manipulação de dados?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtNome.Text = "";
                txtCPF.Text = "";
                txtEndereço.Text = "";
                txtemail.Text = "";
                txtRG.Text = "";
                txtTelefone.Text = "";
                dtDataNascimento.Text = "";

                btnCadastrarClientes.Visible = true;
                lblCancelar.Visible = false;
                btnAlterarClientes.Enabled = false;
                btnExcluirClientes.Enabled = false;

                Cliente = null;
            }
        }

        private void TextPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> clientes = _clienteController.Pesquisar(textPesquisar.Text);

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
                ListaClientes = clientes;
                dgClientesConsulta.DataSource = dt;

            }
            catch (ConcorrenciaBancoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

