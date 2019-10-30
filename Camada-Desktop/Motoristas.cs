﻿using System;
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
        private Motorista Motorista;
        private CNH cNH;
        private ExameMedico ExameMedico;
        string cpfantigo;
        string cpfExameAntigo;
        DateTime dataExameAntigo;

        public Motoristas()
        {
            InitializeComponent();
            _motoristaController = InstanciarCamadas();
            _exameMedicoController = InstanciarCamadasExames();
            Motorista = null;
            cNH = null;
            cpfantigo = "";
            cpfExameAntigo = "";
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
            if (dtFimConsulta.Value < dtInicioConsulta.Value)
            {
                MessageBox.Show("A Data Final deve ser maior que a data de Início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    txtCPFConsulta.Text = "";
                    Motorista = null;
                }
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
                        if (_motoristaController.Inativar(cpf))
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //EXAME MEDICO
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
        private void Motoristas_Load(object sender, EventArgs e)
        {
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
            if (dtFimConsultaporDataExames.Value < dtInicioConsultaporDataExames.Value)
            {
                MessageBox.Show("A Data Final deve ser maior que a data de Início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                    dgExameConsulta.DataSource = dt;

                }
                catch (ConcorrenciaBancoException)
                {
                    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
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
                dgExameConsulta.ClearSelection();
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
    }
}
