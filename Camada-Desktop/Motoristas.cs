using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaModelagem.Models;
using CamadaControle.Controllers;
using CamadaModelagem.Services;
using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Services.Exceptions;
using CamadaModelagem.Models.Enums;

namespace CamadaDesktop
{
    public partial class Motoristas : Form
    {
        private readonly MotoristaController _motoristaController;
        private readonly ExameMedicoController _exameMedicoController;
        private List<Motorista> ListaMotoristas;
        private Motorista Motorista;
        private CNH cNH;
        private List<ExameMedico> ListaExamesMedicos;
        private ExameMedico ExameMedico;
        string cpfantigo;
        string cpfExameAntigo;
        DateTime dataExameAntigo;
        PerfilAcesso PerfilAcesso;
        bool situacao;

        public Motoristas()
        {
            InitializeComponent();
            _motoristaController = InstanciarCamadas();
            _exameMedicoController = InstanciarCamadasExames();
            Motorista = null;
            cNH = null;
            cpfantigo = "";
            cpfExameAntigo = "";
            situacao = true;
        }

        public Motoristas(PerfilAcesso perfilAcesso)
        {
            InitializeComponent();
            _motoristaController = InstanciarCamadas();
            _exameMedicoController = InstanciarCamadasExames();
            Motorista = null;
            cNH = null;
            cpfantigo = "";
            cpfExameAntigo = "";
            PerfilAcesso = perfilAcesso;
            situacao = true;
        }

        private MotoristaController InstanciarCamadas()
        {
            Banco banco = new Banco();
            MotoristaDAL motoristaDAL = new MotoristaDAL(banco);
            EntradaSaidaDAL entradaSaidaDAL = new EntradaSaidaDAL(banco);
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            MotoristaService motoristaService = new MotoristaService(motoristaDAL, entradaSaidaDAL, seguroDAL);
            return new MotoristaController(motoristaService);
        }

        private ExameMedicoController InstanciarCamadasExames()
        {
            Banco banco = new Banco();
            ExameMedicoDAL exameMedicoDAL = new ExameMedicoDAL(banco);
            ExameMedicoService exameMedicoService = new ExameMedicoService(exameMedicoDAL);
            return new ExameMedicoController(exameMedicoService);
        }

        private void btnCadastrarMotorista_Click(object sender, EventArgs e)
        {
            if(txtCPF.Text == "" || txtCPF.Text.Length < 12 || txtNome.Text == "" || txtEndereco.Text == "" || txtTelefone.Text == "" || txtTelefoneContato.Text == "" || txtCNHnumero.Text == "" || txtCNHnumero.Text.Length < 12 || cbCategoriaCNH.Text == "" || cbOrgaoEmissor. Text == "")
            {
                if (dtDataEmissaoCNH.Value > dtDataVencimentoCNH.Value)
                {
                    MessageBox.Show("A Data de Vencimento deve ser maior que a data de Início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {

                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " "};

                string cpf = txtCPF.Text;
                string Telefone = txtTelefone.Text;
                string Telefonecontato = txtTelefoneContato.Text;

                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                    Telefone = Telefone.Replace(str, "");
                    Telefonecontato = Telefonecontato.Replace(str, "");
                }

                long telefone = long.Parse(Telefone);
                long telefonecontato = long.Parse(Telefonecontato);
                bool situacao = true;

                cNH = new CNH(long.Parse(txtCNHnumero.Text), dtDataEmissaoCNH.Value, dtDataVencimentoCNH.Value
                    , cbCategoriaCNH.SelectedItem.ToString(), cbOrgaoEmissor.SelectedItem.ToString());

                Motorista motorista = new Motorista(cpf, txtNome.Text, txtRG.Text, txtEndereco.Text, dtDataNascimento.Value, telefone, telefonecontato, situacao, cNH);
                try
                {
                    if (_motoristaController.Cadastrar(motorista, cNH))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");
                        txtCPF.Text = "";
                        txtNome.Text = "";
                        txtRG.Text = "";
                        dtDataNascimento.Value = DateTime.Now;
                        txtEndereco.Text = "";
                        txtTelefone.Text = "";
                        txtTelefoneContato.Text = "";
                        txtCNHnumero.Text = "";
                        cbCategoriaCNH.Text = "";
                        cbOrgaoEmissor.Text = "";
                        dtDataEmissaoCNH.Value = DateTime.Now;
                        dtDataVencimentoCNH.Value = DateTime.Now;
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

        private void btnConsultarMotorista_Click(object sender, EventArgs e)
        {
            if (txtCPFConsulta.Text == "" || txtCPFConsulta.Text.Length < 12)
            {
                MessageBox.Show("Preencha o campo do CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPFConsulta.Text;
                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                }

                try
                {
                    Motorista motorista = _motoristaController.BuscarCPF(cpf);
                    if (motorista == null)
                    {
                        MessageBox.Show("Não existe cadastro com esse CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("CPF", typeof(string));
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("RG", typeof(string));
                        dt.Columns.Add("Data Nascimento", typeof(DateTime));
                        dt.Columns.Add("Endereço", typeof(string));
                        dt.Columns.Add("Telefone", typeof(long));
                        dt.Columns.Add("Telefone p/Recado", typeof(long));
                        dt.Columns.Add("Situação", typeof(string));
                        dt.Columns.Add("CNH Nº", typeof(long));
                        dt.Columns.Add("Categoria CNH", typeof(string));
                        dt.Columns.Add("Orgão Emissor", typeof(string));
                        dt.Columns.Add("Data Emissão CNH", typeof(DateTime));
                        dt.Columns.Add("Data Vencimento CNH", typeof(DateTime));

                        string situacao = null;

                        if (motorista.Situacao)
                        {
                            situacao = "Ativo";
                        }
                        else
                        {
                            situacao = "Inativo";
                        }


                        dt.Rows.Add(motorista.CPF, motorista.Name, motorista.RG
                            , motorista.DataNascimento, motorista.Endereco, motorista.Telefone, motorista.TelefoneContato
                            , situacao, motorista.CNH.Numero, motorista.CNH.Categoria, motorista.CNH.OrgaoEmissor
                            , motorista.CNH.DataEmissao, motorista.CNH.DataVencimento);

                        dgMotoristaConsulta.DataSource = dt;
                    }
                    Motorista = motorista;
                    ListaMotoristas = new List<Motorista>();
                    ListaMotoristas.Add(motorista);
                    motorista = null;
                }
                catch (ConcorrenciaBancoException)
                {
                    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                }
            }
        }

        private void btnTodosMotorista_Click(object sender, EventArgs e)
        {
            panelConsultarPorData.Visible = true;
        }

        private void btnConsultarPorData_Click_1(object sender, EventArgs e)
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
                        List<Motorista> motoristas = _motoristaController.BuscarTodos(dtInicioConsulta.Value, dtFimConsulta.Value);

                        DataTable dt = new DataTable();
                        dt.Columns.Add("CPF", typeof(string));
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("RG", typeof(string));
                        dt.Columns.Add("Data Nascimento", typeof(DateTime));
                        dt.Columns.Add("Endereço", typeof(string));
                        dt.Columns.Add("Telefone", typeof(long));
                        dt.Columns.Add("Telefone p/Recado", typeof(long));
                        dt.Columns.Add("Situação", typeof(string));
                        dt.Columns.Add("CNH Nº", typeof(long));
                        dt.Columns.Add("Categoria CNH", typeof(string));
                        dt.Columns.Add("Orgão Emissor", typeof(string));
                        dt.Columns.Add("Data Emissão CNH", typeof(DateTime));
                        dt.Columns.Add("Data Vencimento CNH", typeof(DateTime));

                        foreach (Motorista motorista in motoristas)
                        {
                            string situacao = null;

                            if (motorista.Situacao)
                            {
                                situacao = "Ativo";
                            }
                            else
                            {
                                situacao = "Inativo";
                            }

                            dt.Rows.Add(motorista.CPF, motorista.Name, motorista.RG
                                , motorista.DataNascimento, motorista.Endereco, motorista.Telefone, motorista.TelefoneContato
                                , situacao, motorista.CNH.Numero, motorista.CNH.Categoria, motorista.CNH.OrgaoEmissor
                                , motorista.CNH.DataEmissao, motorista.CNH.DataVencimento);
                        }

                        dgMotoristaConsulta.DataSource = dt;

                    }
                    catch (ConcorrenciaBancoException)
                    {
                        throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                    }
                }
            }           
        }

        private void btnTrasferirMotorista_Click(object sender, EventArgs e)
        {
            if (Motorista == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtCPF.Text = Motorista.CPF;
                cpfantigo = Motorista.CPF;
                txtNome.Text = Motorista.Name;
                txtRG.Text = Motorista.RG;
                txtEndereco.Text = Motorista.Endereco;
                dtDataNascimento.Value = Motorista.DataNascimento;
                txtTelefone.Text = Motorista.Telefone.ToString();
                txtTelefoneContato.Text = Motorista.TelefoneContato.ToString();
                txtCNHnumero.Text = Motorista.CNH.Numero.ToString();
                cbCategoriaCNH.Text = Motorista.CNH.Categoria;
                cbOrgaoEmissor.Text = Motorista.CNH.OrgaoEmissor;
                dtDataEmissaoCNH.Value = Motorista.CNH.DataEmissao;
                dtDataVencimentoCNH.Value = Motorista.CNH.DataVencimento;

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlMotorista.SelectTab("tbPageCadastroMotorista");
                if (tbControlMotorista.SelectedTab == tbPageCadastroMotorista)
                {
                    if (Motorista.Situacao)
                    {
                        txtCPFConsulta.Text = "";
                        Motorista = null;

                        btnCadastrarMotorista.Visible = false;
                        lblCancelarMot.Visible = true;
                        btnAlterarMotorista.Enabled = true;

                        if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                        {
                            btnExcluirMotorista.Enabled = false;
                        }
                        else
                        {
                            btnExcluirMotorista.Enabled = true;
                        }
                    }
                    else
                    {
                        txtCPF.Enabled = false;
                        txtNome.Enabled = false;
                        txtRG.Enabled = false;
                        dtDataNascimento.Enabled = false;
                        txtEndereco.Enabled = false;
                        txtTelefone.Enabled = false;
                        txtTelefoneContato.Enabled = false;
                        txtCNHnumero.Enabled = false;
                        cbCategoriaCNH.Enabled = false;
                        cbOrgaoEmissor.Enabled = false;
                        dtDataEmissaoCNH.Enabled = false;
                        dtDataVencimentoCNH.Enabled = false;
                        situacao = false;

                        txtCPFConsulta.Text = "";
                        Motorista = null;

                        btnCadastrarMotorista.Visible = false;
                        lblCancelarMot.Visible = true;
                        btnAlterarMotorista.Enabled = false;

                        if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                        {
                            btnAtivarMotorista.Enabled = false;
                            btnExcluirMotorista.Visible = false;
                            btnAtivarMotorista.Visible = true;
                        }
                        else
                        {
                            btnAtivarMotorista.Enabled = true;
                            btnExcluirMotorista.Visible = false;
                            btnAtivarMotorista.Visible = true;
                        }
                    }                    
                }
            }
        }

        private void dgMotoristaConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgMotoristaConsulta.DataSource == null)
            {

            }
            else if (dgMotoristaConsulta.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                string cpf = dgMotoristaConsulta.CurrentRow.Cells[0].Value.ToString();

                foreach (Motorista motorista in ListaMotoristas)
                {
                    if (motorista.CPF == cpf)
                    {
                        txtCPF.Text = motorista.CPF;
                        cpfantigo = motorista.CPF;
                        txtNome.Text = motorista.Name;
                        txtRG.Text = motorista.RG;
                        txtEndereco.Text = motorista.Endereco;
                        dtDataNascimento.Value = motorista.DataNascimento;
                        txtTelefone.Text = motorista.Telefone.ToString();
                        txtTelefoneContato.Text = motorista.TelefoneContato.ToString();
                        txtCNHnumero.Text = motorista.CNH.Numero.ToString();
                        cbCategoriaCNH.Text = motorista.CNH.Categoria;
                        cbOrgaoEmissor.Text = motorista.CNH.OrgaoEmissor;
                        dtDataEmissaoCNH.Value = motorista.CNH.DataEmissao;
                        dtDataVencimentoCNH.Value = motorista.CNH.DataVencimento;

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                        tbControlMotorista.SelectTab("tbPageCadastroMotorista");
                        if (tbControlMotorista.SelectedTab == tbPageCadastroMotorista)
                        {
                            if (motorista.Situacao)
                            {
                                txtCPFConsulta.Text = "";
                                Motorista = null;

                                btnCadastrarMotorista.Visible = false;
                                lblCancelarMot.Visible = true;
                                btnAlterarMotorista.Enabled = true;

                                if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                                {
                                    btnExcluirMotorista.Enabled = false;
                                }
                                else
                                {
                                    btnExcluirMotorista.Enabled = true;
                                }
                            }
                            else
                            {
                                txtCPF.Enabled = false;
                                txtNome.Enabled = false;
                                txtRG.Enabled = false;
                                dtDataNascimento.Enabled = false;
                                txtEndereco.Enabled = false;
                                txtTelefone.Enabled = false;
                                txtTelefoneContato.Enabled = false;
                                txtCNHnumero.Enabled = false;
                                cbCategoriaCNH.Enabled = false;
                                cbOrgaoEmissor.Enabled = false;
                                dtDataEmissaoCNH.Enabled = false;
                                dtDataVencimentoCNH.Enabled = false;
                                situacao = false;

                                btnCadastrarMotorista.Visible = false;
                                lblCancelarMot.Visible = true;
                                btnAlterarMotorista.Enabled = false;

                                if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                                {
                                    btnAtivarMotorista.Enabled = false;
                                    btnExcluirMotorista.Visible = false;
                                    btnAtivarMotorista.Visible = true;
                                }
                                else
                                {
                                    btnAtivarMotorista.Enabled = true;
                                    btnExcluirMotorista.Visible = false;
                                    btnAtivarMotorista.Visible = true;
                                }
                            }
                        }
                    }
                }
                textPesquisar.Text = "";
                dgMotoristaConsulta.DataSource = null;
            }
        }

        private void btnAlterarMotorista_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text == "" || txtCPF.Text.Length < 12 || txtNome.Text == "" || txtEndereco.Text == "" || txtTelefone.Text == "" || txtTelefoneContato.Text == "" || txtCNHnumero.Text == "" || txtCNHnumero.Text.Length < 12 || cbCategoriaCNH.Text == "" || cbOrgaoEmissor.Text == "")
            {
                if (dtDataEmissaoCNH.Value > dtDataVencimentoCNH.Value)
                {
                    MessageBox.Show("A Data de Vencimento deve ser maior que a data de Início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                cNH = new CNH();
                cNH.Numero = long.Parse(txtCNHnumero.Text);
                cNH.Categoria = cbCategoriaCNH.SelectedItem.ToString();
                cNH.OrgaoEmissor = cbOrgaoEmissor.SelectedItem.ToString();
                cNH.DataEmissao = Convert.ToDateTime(dtDataEmissaoCNH.Value);
                cNH.DataVencimento = Convert.ToDateTime(dtDataVencimentoCNH.Value);


                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPF.Text;
                string Telefone = txtTelefone.Text;
                string Telefonecontato = txtTelefoneContato.Text;

                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                    Telefone = Telefone.Replace(str, "");
                    Telefonecontato = Telefonecontato.Replace(str, "");
                }

                long telefone = long.Parse(Telefone);
                long telefonecontato = long.Parse(Telefonecontato);
                bool situacao = true;

                Motorista motorista = new Motorista(cpf, txtNome.Text, txtRG.Text, txtEndereco.Text, dtDataNascimento.Value, telefone, telefonecontato, situacao, cNH);
                try
                {
                    if (_motoristaController.Alterar(motorista, cNH, cpfantigo))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        cpfantigo = "";
                        txtCPF.Text = "";
                        txtNome.Text = "";
                        txtRG.Text = "";
                        dtDataNascimento.Value = DateTime.Now;
                        txtEndereco.Text = "";
                        txtTelefone.Text = "";
                        txtTelefoneContato.Text = "";
                        txtCNHnumero.Text = "";
                        cbCategoriaCNH.Text = "";
                        cbOrgaoEmissor.Text = "";
                        dtDataEmissaoCNH.Value = DateTime.Now;
                        dtDataVencimentoCNH.Value = DateTime.Now;

                        btnCadastrarMotorista.Visible = true;
                        lblCancelarMot.Visible = false;
                        btnAlterarMotorista.Enabled = false;
                        btnExcluirMotorista.Enabled = false;
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
                catch (IntegridadeException ex)
                {
                    MessageBox.Show(ex.Message);
                    txtCPF.Text = cpfantigo;
                }
            }
        }

        private void btnExcluirMotorista_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                MessageBox.Show("Preencha o campo CPF corretamente para realizar esta opereção!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPF.Text;
                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                }

                try
                {
                    if (MessageBox.Show("Deseja realmente inativar?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_motoristaController.Inativar(cpf, situacao))
                        {
                            MessageBox.Show("Inativação realizada com Sucesso!");
                            txtCPF.Text = "";
                            txtNome.Text = "";
                            txtRG.Text = "";
                            dtDataNascimento.Value = DateTime.Now;
                            txtEndereco.Text = "";
                            txtTelefone.Text = "";
                            txtTelefoneContato.Text = "";
                            txtCNHnumero.Text = "";
                            cbCategoriaCNH.Text = "";
                            cbOrgaoEmissor.Text = "";
                            dtDataEmissaoCNH.Value = DateTime.Now;
                            dtDataVencimentoCNH.Value = DateTime.Now;

                            btnCadastrarMotorista.Visible = true;
                            lblCancelarMot.Visible = false;
                            btnAlterarMotorista.Enabled = false;
                            btnExcluirMotorista.Enabled = false;
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


        private void btnAtivarMotorista_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                MessageBox.Show("Preencha o campo CPF corretamente para realizar esta opereção!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPF.Text;
                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                }

                try
                {
                    if (MessageBox.Show("Deseja realmente ativar?", "Ativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_motoristaController.Inativar(cpf, situacao))
                        {
                            MessageBox.Show("Ativação realizada com Sucesso!");
                            txtCPF.Text = "";
                            txtNome.Text = "";
                            txtRG.Text = "";
                            dtDataNascimento.Value = DateTime.Now;
                            txtEndereco.Text = "";
                            txtTelefone.Text = "";
                            txtTelefoneContato.Text = "";
                            txtCNHnumero.Text = "";
                            cbCategoriaCNH.Text = "";
                            cbOrgaoEmissor.Text = "";
                            dtDataEmissaoCNH.Value = DateTime.Now;
                            dtDataVencimentoCNH.Value = DateTime.Now;

                            btnCadastrarMotorista.Visible = true;
                            lblCancelarMot.Visible = false;
                            btnAlterarMotorista.Enabled = false;
                            btnExcluirMotorista.Enabled = false;
                            btnExcluirMotorista.Visible = true;
                            btnAtivarMotorista.Visible = false;
                            btnAtivarMotorista.Enabled = false;

                            txtCPF.Enabled = true;
                            txtNome.Enabled = true;
                            txtRG.Enabled = true;
                            dtDataNascimento.Enabled = true;
                            txtEndereco.Enabled = true;
                            txtTelefone.Enabled = true;
                            txtTelefoneContato.Enabled = true;
                            txtCNHnumero.Enabled = true;
                            cbCategoriaCNH.Enabled = true;
                            cbOrgaoEmissor.Enabled = true;
                            dtDataEmissaoCNH.Enabled = true;
                            dtDataVencimentoCNH.Enabled = true;
                            situacao = true;
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

        private void btnAddExameMedico_Click_1(object sender, EventArgs e)
        {
            tbControlMotorista.SelectedTab = tbPageExames;
        }

        private void panelConsultarPorData_MouseLeave_1(object sender, EventArgs e)
        {
            panelConsultarPorData.Visible = false;
        }
        private void lblCancelarMot_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar manipulação de dados?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtCPF.Text = "";
                txtNome.Text = "";
                txtRG.Text = "";
                dtDataNascimento.Value = DateTime.Now;
                txtEndereco.Text = "";
                txtTelefone.Text = "";
                txtTelefoneContato.Text = "";
                txtCNHnumero.Text = "";
                cbCategoriaCNH.Text = "";
                cbOrgaoEmissor.Text = "";
                dtDataEmissaoCNH.Value = DateTime.Now;
                dtDataVencimentoCNH.Value = DateTime.Now;

                Motorista = null;

                btnCadastrarMotorista.Visible = true;
                lblCancelarMot.Visible = false;
                btnAlterarMotorista.Enabled = false;
                btnExcluirMotorista.Enabled = false;
                btnExcluirMotorista.Visible = true;
                btnAtivarMotorista.Visible = false;
                btnAtivarMotorista.Enabled = false;

                txtCPF.Enabled = true;
                txtNome.Enabled = true;
                txtRG.Enabled = true;
                dtDataNascimento.Enabled = true;
                txtEndereco.Enabled = true;
                txtTelefone.Enabled = true;
                txtTelefoneContato.Enabled = true;
                txtCNHnumero.Enabled = true;
                cbCategoriaCNH.Enabled = true;
                cbOrgaoEmissor.Enabled = true;
                dtDataEmissaoCNH.Enabled = true;
                dtDataVencimentoCNH.Enabled = true;
                situacao = true;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //EXAME MEDICO
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
        private void Motoristas_Load(object sender, EventArgs e)
        {
            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao.Visible = true;
                toolTipPermissao.SetToolTip(this.pbpermissao, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao.Hide(pbpermissao);
            }

            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao1.Visible = true;
                toolTipPermissao1.SetToolTip(this.pbpermissao1, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao1.Hide(pbpermissao1);
            }

            cbCategoriaCNH.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategoriaCNH.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbOrgaoEmissor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbOrgaoEmissor.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbSituacaoExame.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSituacaoExame.AutoCompleteSource = AutoCompleteSource.ListItems;

            tooltipPesquisar.SetToolTip(lbPesquisar, "Pesquise pelo Nome, CPF ou Endereço do Motorista.");
            tooltipPesquisar.Hide(lbPesquisar);
            toolTipTransfere.SetToolTip(this.btnTrasferirMotorista, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirMotorista);
            toolTipTransfereExam.SetToolTip(this.btnTransfereExame, "Transferir Dados");
            toolTipTransfereExam.Hide(btnTransfereExame);

            cbSituacaoExame.DataSource = Enum.GetValues(typeof(SituacaoExameMedico));
            AtualizarCor();
        }

        private void btnCadastrarExame_Click(object sender, EventArgs e)
        {
            if (txtCPFExames.Text == "" || txtCPFExames.Text.Length < 12 || txtExameDescricao.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPFExames.Text;

                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                }

                SituacaoExameMedico situacaoExameMedico = (SituacaoExameMedico)Enum.Parse(typeof(SituacaoExameMedico), cbSituacaoExame.SelectedItem.ToString());

                try
                {
                    Motorista motorista = _motoristaController.BuscarCPF(cpf);
                    if (motorista == null)
                    {
                        MessageBox.Show("Não existe cadastro com esse CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Motorista = motorista;
                        ExameMedico = new ExameMedico(dtDataExame.Value, txtExameDescricao.Text, situacaoExameMedico, Motorista);

                        if (_exameMedicoController.Cadastrar(ExameMedico))
                        {
                            Motorista.AdicionarExame(ExameMedico); // Não sei se ta certo, mas fiz pq o Inglesson me orientou
                            MessageBox.Show("Cadastro realizado com Sucesso!");
                            txtCPFExames.Text = "";
                            dtDataExame.Text = "";
                            cbSituacaoExame.Text = "";
                            txtExameDescricao.Text = "";
                        }
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

        private void btnConsultaExame_Click(object sender, EventArgs e)
        {
            if (txtCPFExameConsulta.Text == "" || txtCPFExameConsulta.Text.Length < 12)
            {
                MessageBox.Show("Preencha o campo d0 CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPFExameConsulta.Text;
                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                }

                try
                {
                    ExameMedico exameMedico = _exameMedicoController.BuscarExameMedico(cpf, dtDataExameConsulta.Value);
                    if (exameMedico == null)
                    {
                        MessageBox.Show("Não existe cadastro com esse CPF ou Data!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Data", typeof(DateTime));
                        dt.Columns.Add("Descrição", typeof(string));
                        dt.Columns.Add("Situação Exame", typeof(string));
                        dt.Columns.Add("CPF", typeof(string));

                        dt.Rows.Add(exameMedico.Data, exameMedico.Descricao, exameMedico.Situacao, exameMedico.Motorista.CPF);

                        dgExameConsulta.DataSource = dt;
                    }
                    ExameMedico = exameMedico;
                    ListaExamesMedicos = new List<ExameMedico>();
                    ListaExamesMedicos.Add(exameMedico);
                    exameMedico = null;
                }
                catch (ConcorrenciaBancoException)
                {
                    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                }
            }
        }

        private void btnConsultaTodosExame_Click(object sender, EventArgs e)
        {
            panelConsultaporDataExames.Visible = true;
        }


        private void btnConsultaporDataExames_Click(object sender, EventArgs e)
        {
            TimeSpan dtlimiteexame = Convert.ToDateTime(dtFimConsultaporDataExames.Value).Subtract(Convert.ToDateTime(dtInicioConsultaporDataExames.Value));

            if (dtlimiteexame.TotalDays >= 93)
            {
                MessageBox.Show("Ops, limite maximo atingido! Pesquise no prazo maximo de três meses.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dtFimConsultaporDataExames.Value < dtInicioConsultaporDataExames.Value)
                {
                    MessageBox.Show("A Data final deve ser maior que a data de início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        List<ExameMedico> exames = _exameMedicoController.BuscarTodos(dtInicioConsultaporDataExames.Value, dtFimConsultaporDataExames.Value);

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Data", typeof(DateTime));
                        dt.Columns.Add("Descrição", typeof(string));
                        dt.Columns.Add("Situação Exame", typeof(string));
                        dt.Columns.Add("CPF", typeof(string));


                        foreach (ExameMedico exameMedico in exames)
                        {
                            dt.Rows.Add(exameMedico.Data, exameMedico.Descricao, exameMedico.Situacao, exameMedico.Motorista.CPF);
                        }
                        ListaExamesMedicos = exames;
                        dgExameConsulta.DataSource = dt;

                    }
                    catch (ConcorrenciaBancoException)
                    {
                        throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                    }
                }
            }           
        }

        private void btnTransfereExame_Click(object sender, EventArgs e)
        {
            if (ExameMedico == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtCPFExames.Text = ExameMedico.Motorista.CPF;
                cpfExameAntigo = ExameMedico.Motorista.CPF;
                dtDataExame.Value = ExameMedico.Data;
                dataExameAntigo = ExameMedico.Data;
                cbSituacaoExame.Text = ExameMedico.Situacao.ToString();
                txtExameDescricao.Text = ExameMedico.Descricao;


                txtCPFExameConsulta.Text = "";
                dtDataExameConsulta.Value = DateTime.Now;
                ExameMedico = null;
                Motorista = null;
                dgExameConsulta.DataSource = null;

                btnCadastrarExame.Visible = false;
                lblCancelar.Visible = true;
                btnAlterarExame.Enabled = true;

                if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                {
                    btnExcluirMotorista.Enabled = false;
                }
                else
                {
                    btnExcluirMotorista.Enabled = true;
                }
            }
        }

        private void dgExameConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgExameConsulta.DataSource == null)
            {

            }
            else if (dgExameConsulta.CurrentRow.Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                DateTime data = Convert.ToDateTime(dgExameConsulta.CurrentRow.Cells[0].Value);
                string descricao = dgExameConsulta.CurrentRow.Cells[1].Value.ToString();
                string cpf = dgExameConsulta.CurrentRow.Cells[3].Value.ToString();

                foreach (ExameMedico exameMedico in ListaExamesMedicos)
                {
                    if (exameMedico.Motorista.CPF == cpf && exameMedico.Data == data && exameMedico.Descricao == descricao)
                    {
                        txtCPFExames.Text = exameMedico.Motorista.CPF;
                        cpfExameAntigo = exameMedico.Motorista.CPF;
                        dtDataExame.Value = exameMedico.Data;
                        dataExameAntigo = exameMedico.Data;
                        cbSituacaoExame.Text = exameMedico.Situacao.ToString();
                        txtExameDescricao.Text = exameMedico.Descricao;


                        txtCPFExameConsulta.Text = "";
                        dtDataExameConsulta.Value = DateTime.Now;
                        ExameMedico = null;
                        Motorista = null;
                        dgExameConsulta.DataSource = null;

                        btnCadastrarExame.Visible = false;
                        lblCancelar.Visible = true;
                        btnAlterarExame.Enabled = true;

                        if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                        {
                            btnExcluirMotorista.Enabled = false;
                        }
                        else
                        {
                            btnExcluirMotorista.Enabled = true;
                        }
                    }
                }
                dgExameConsulta.DataSource = null;
            }
        }

        private void btnAlterarExame_Click(object sender, EventArgs e)
        {
            if (txtCPFExames.Text == "" || txtCPFExames.Text.Length < 12 || txtExameDescricao.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPFExames.Text;

                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                }

                SituacaoExameMedico situacaoExameMedico = (SituacaoExameMedico)Enum.Parse(typeof(SituacaoExameMedico), cbSituacaoExame.SelectedItem.ToString());

                try
                {
                    Motorista motorista = _motoristaController.BuscarCPF(cpf);
                    if (motorista == null)
                    {
                        MessageBox.Show("Não existe cadastro com esse CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Motorista = motorista;
                        ExameMedico = new ExameMedico(dtDataExame.Value, txtExameDescricao.Text, situacaoExameMedico, Motorista);

                        if (_exameMedicoController.Alterar(ExameMedico, cpfExameAntigo, dataExameAntigo))
                        {
                            MessageBox.Show("Alteração realizada com Sucesso!");
                            cpfExameAntigo = "";
                            txtCPFExames.Text = "";
                            dtDataExame.Text = "";
                            cbSituacaoExame.Text = "";
                            txtExameDescricao.Text = "";

                            btnCadastrarExame.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarExame.Enabled = false;
                            btnExcluirExame.Enabled = false;
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

        private void btnExcluirExame_Click(object sender, EventArgs e)
        {
            if (txtCPFExames.Text == "")
            {
                MessageBox.Show("Preencha o campo CPF corretamente para realizar esta opereção!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPFExames.Text;
                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                }
             
                SituacaoExameMedico situacaoExameMedico = (SituacaoExameMedico)Enum.Parse(typeof(SituacaoExameMedico), cbSituacaoExame.SelectedItem.ToString());

                try
                {
                    if (MessageBox.Show("Deseja realmente inativar?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Motorista motorista = _motoristaController.BuscarCPF(cpf);
                        if (motorista == null)
                        {
                            MessageBox.Show("Não existe cadastro com esse CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            Motorista = motorista;
                            ExameMedico = new ExameMedico(dtDataExame.Value, txtExameDescricao.Text, situacaoExameMedico, Motorista);

                            if (_exameMedicoController.Deletar(Motorista.CPF, dtDataExame.Value))
                            {
                                Motorista.RemoverExame(ExameMedico);  // Verificar se está correto
                                MessageBox.Show("Inativação realizada com Sucesso!");
                                txtCPFExames.Text = "";
                                dtDataExame.Text = "";
                                cbSituacaoExame.Text = "";
                                txtExameDescricao.Text = "";

                                btnCadastrarExame.Visible = true;
                                lblCancelar.Visible = false;
                                btnAlterarExame.Enabled = false;
                                btnExcluirExame.Enabled = false;
                            }
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

            btnCadastrarMotorista.BackColor = Properties.Settings.Default.myColor;
            btnCadastrarExame.BackColor = Properties.Settings.Default.myColor;
            btnAddExameMedico.BackColor = Properties.Settings.Default.myColor;
            btnConsultarMotorista.BackColor = Properties.Settings.Default.myColor;
            btnConsultaExame.BackColor = Properties.Settings.Default.myColor;
            btnTodosMotorista.BackColor = Properties.Settings.Default.myColor;
            btnConsultaTodosExame.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirMotorista.BackColor = Properties.Settings.Default.myColor;
            btnTransfereExame.BackColor = Properties.Settings.Default.myColor;
            btnAlterarMotorista.BackColor = Properties.Settings.Default.myColor;
            btnAlterarExame.BackColor = Properties.Settings.Default.myColor;

            btnCadastrarMotorista.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnCadastrarExame.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAddExameMedico.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarMotorista.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultaExame.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodosMotorista.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultaTodosExame.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirMotorista.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTransfereExame.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarMotorista.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarExame.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            btnConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            panelConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            btnConsultarPorData.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            panelConsultaporDataExames.BackColor = Properties.Settings.Default.myColor;
            btnConsultaporDataExames.BackColor = Properties.Settings.Default.myColor;
            btnConsultaporDataExames.ForeColor = Properties.Settings.Default.myColorFonteMenu;
        }

        private void panelConsultaporDataExames_MouseLeave(object sender, EventArgs e)
        {
            panelConsultaporDataExames.Visible = false;
        }

        private void btnConsultarPorData_Click(object sender, EventArgs e)
        {
            //sem Comportamento
        }

        private void panelConsultarPorData_MouseLeave(object sender, EventArgs e)
        {
            //sem Comportamento
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar manipulação de dados?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtCPFExames.Text = "";
                dtDataExame.Text = "";
                cbSituacaoExame.Text = "";
                txtExameDescricao.Text = "";

                btnCadastrarExame.Visible = true;
                lblCancelar.Visible = false;
                btnAlterarExame.Enabled = false;
                btnExcluirExame.Enabled = false;

                ExameMedico = null;
            }
        }

        private void TextPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Motorista> motoristas = _motoristaController.Pesquisar(textPesquisar.Text);

                DataTable dt = new DataTable();
                dt.Columns.Add("CPF", typeof(string));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("RG", typeof(string));
                dt.Columns.Add("Data Nascimento", typeof(DateTime));
                dt.Columns.Add("Endereço", typeof(string));
                dt.Columns.Add("Telefone", typeof(long));
                dt.Columns.Add("Telefone p/Recado", typeof(long));
                dt.Columns.Add("Situação", typeof(string));
                dt.Columns.Add("CNH Nº", typeof(long));
                dt.Columns.Add("Categoria CNH", typeof(string));
                dt.Columns.Add("Orgão Emissor", typeof(string));
                dt.Columns.Add("Data Emissão CNH", typeof(DateTime));
                dt.Columns.Add("Data Vencimento CNH", typeof(DateTime));

                foreach (Motorista motorista in motoristas)
                {
                    string situacao = null;

                    if (motorista.Situacao)
                    {
                        situacao = "Ativo";
                    }
                    else
                    {
                        situacao = "Inativo";
                    }

                    dt.Rows.Add(motorista.CPF, motorista.Name, motorista.RG
                        , motorista.DataNascimento, motorista.Endereco, motorista.Telefone, motorista.TelefoneContato
                        , situacao, motorista.CNH.Numero, motorista.CNH.Categoria, motorista.CNH.OrgaoEmissor
                        , motorista.CNH.DataEmissao, motorista.CNH.DataVencimento);
                }
                ListaMotoristas = motoristas;
                dgMotoristaConsulta.DataSource = dt;

            }
            catch (ConcorrenciaBancoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
