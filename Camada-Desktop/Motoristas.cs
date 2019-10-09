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

namespace CamadaDesktop
{
    public partial class Motoristas : Form
    {
        private readonly MotoristaController _motoristaController;
        private Motorista Motorista;
        private CNH cNH;

        public Motoristas()
        {
            InitializeComponent();
            _motoristaController = InstanciarCamadas();
            Motorista = null;
            cNH = null;
        }

        private MotoristaController InstanciarCamadas()
        {
            Banco banco = new Banco();
            MotoristaDAL motoristaDAL = new MotoristaDAL(banco);
            MotoristaService motoristaService = new MotoristaService(motoristaDAL);
            return new MotoristaController(motoristaService);
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
                MessageBox.Show("Preencha o campo da CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Motorista motorista = _motoristaController.BuscarCPF(txtCPFConsulta.Text.Replace("-", ""));
                    if (motorista == null)
                    {

                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("CPF", typeof(string));
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("RG", typeof(string));
                        dt.Columns.Add("Data Nascimento", typeof(DateTime));
                        dt.Columns.Add("Endereço", typeof(string));
                        dt.Columns.Add("Telefone", typeof(int));
                        dt.Columns.Add("Telefone p/Recado", typeof(int));
                        dt.Columns.Add("Situação", typeof(string));
                        dt.Columns.Add("CNH Nº", typeof(int));
                        dt.Columns.Add("Categoria CNH", typeof(string));
                        dt.Columns.Add("Orgão Emissor", typeof(string));
                        dt.Columns.Add("Data Emissão CNH", typeof(DateTime));
                        dt.Columns.Add("Data Vencimento CNH", typeof(DateTime));


                        dt.Rows.Add(motorista.CPF, motorista.Name, motorista.RG
                                , motorista.DataNascimento, motorista.Endereco, motorista.Telefone, motorista.TelefoneContato
                                , motorista.Situacao, cNH.Numero, cNH.Categoria, cNH.OrgaoEmissor
                                , cNH.DataEmissao, cNH.DataVencimento);
                        
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
            try
            {
                List<Motorista> motoristas = _motoristaController.BuscarTodos();

                DataTable dt = new DataTable();
                dt.Columns.Add("CPF", typeof(string));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("RG", typeof(string));
                dt.Columns.Add("Data Nascimento", typeof(DateTime));
                dt.Columns.Add("Endereço", typeof(string));
                dt.Columns.Add("Telefone", typeof(int));
                dt.Columns.Add("Telefone p/Recado", typeof(int));
                dt.Columns.Add("Situação", typeof(string));
                dt.Columns.Add("CNH Nº", typeof(int));
                dt.Columns.Add("Categoria CNH", typeof(string));
                dt.Columns.Add("Orgão Emissor", typeof(string));
                dt.Columns.Add("Data Emissão CNH", typeof(DateTime));
                dt.Columns.Add("Data Vencimento CNH", typeof(DateTime));

                foreach (Motorista motorista in motoristas)
                {
                    dt.Rows.Add(motorista.CPF, motorista.Name, motorista.RG
                        , motorista.DataNascimento, motorista.Endereco, motorista.Telefone, motorista.TelefoneContato
                        , motorista.Situacao, cNH.Numero, cNH.Categoria, cNH.OrgaoEmissor
                        , cNH.DataEmissao, cNH.DataVencimento);
                }
                dgMotoristaConsulta.DataSource = dt;

            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
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
                txtNome.Text = Motorista.Name;
                txtRG.Text = Motorista.RG;
                txtEndereco.Text = Motorista.Endereco;
                dtDataNascimento.Value = Motorista.DataNascimento;
                txtTelefone.Text = Motorista.Telefone.ToString();
                txtTelefoneContato.Text = Motorista.TelefoneContato.ToString();
                txtCNHnumero.Text = cNH.Numero.ToString();
                cbCategoriaCNH.Text = cNH.Categoria;
                cbOrgaoEmissor.Text = cNH.OrgaoEmissor;
                dtDataEmissaoCNH.Value = cNH.DataEmissao;
                dtDataVencimentoCNH.Value = cNH.DataVencimento;

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
                cNH.Numero = int.Parse(txtCNHnumero.Text);
                cNH.Categoria = cbCategoriaCNH.SelectedItem.ToString();
                cNH.OrgaoEmissor = cbOrgaoEmissor.SelectedItem.ToString();
                cNH.DataEmissao = Convert.ToDateTime(dtDataEmissaoCNH.Value);
                cNH.DataVencimento = Convert.ToDateTime(dtDataVencimentoCNH.Value);

                string[] strings = new string[] { ".","/", "-", ",", "(", ")" };

                foreach(string str in strings)
                {
                    txtCPF.Text.Replace(str, "");
                    txtTelefone.Text.Replace(str, "");
                    txtTelefoneContato.Text.Replace(str, "");
                }

                int telefone = int.Parse(txtTelefone.Text);
                int telefonecontato = int.Parse(txtTelefoneContato.Text);
                bool situacao = true;

                Motorista motorista = new Motorista(txtCPF.Text, txtNome.Text, txtRG.Text, txtEndereco.Text, dtDataNascimento.Value, telefone, telefonecontato, situacao, cNH);
                try
                {
                    if (_motoristaController.Alterar(motorista, cNH, motorista.CPF))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
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

        private void btnExcluirMotorista_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                MessageBox.Show("Preencha o campo CPF corretamente para realizar esta opereção!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string placa = txtCPF.Text.Replace("-", "");
                try
                {
                    if (_motoristaController.Inativar(placa))
                    {
                        MessageBox.Show("Inativação realizada com Sucesso!");
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
    }
}
