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
using CamadaModelagem.Models.Enums;
using CamadaControle.Controllers;
using CamadaModelagem.Services;
using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Services.Exceptions;

namespace CamadaDesktop
{
    public partial class ServicoExterno_Conveniados : Form
    {
        private readonly ServicoExternoController _servicoExternoController;
        private ServicoExterno ServicoExterno;
        private string TipoAntigo;
        private long cnpjAntigo;
        public ServicoExterno_Conveniados()
        {
            InitializeComponent();
            _servicoExternoController = InstanciarCamadas();
            ServicoExterno = null;
            TipoAntigo = "";
            cnpjAntigo = long.MaxValue;
        }
        private ServicoExternoController InstanciarCamadas()
        {
            Banco banco = new Banco();
            ServicoExternoDAL servicoExternoDAL = new ServicoExternoDAL(banco);
            ManutencaoDAL manutencaoDAL = new ManutencaoDAL(banco);
            AbastecimentoDAL abastecimentoDAL = new AbastecimentoDAL(banco);
            EntradaSaidaDAL entradaSaidaDAL = new EntradaSaidaDAL(banco);
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            ServicoExternoService servicoExternoService = new ServicoExternoService(servicoExternoDAL, manutencaoDAL, abastecimentoDAL, entradaSaidaDAL, seguroDAL);
            return new ServicoExternoController(servicoExternoService);
        }

        private void rdConveniado_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Enabled = true;
            dtInicio.Enabled = true;
            dtVencimento.Enabled = true;
        }

        private void rdNaoConveniado_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Enabled = false;
            dtInicio.Enabled = false;
            dtVencimento.Enabled = false;
        }

        private void ServicoExterno_Conveniados_Load(object sender, EventArgs e)
        {
            cbTipo.DataSource = Enum.GetValues(typeof(TipoServicoExterno));
            AtualizarCor();
        }

        private void BtnCadastrarServicoExterno_Click(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "" || txtNomeServico.Text == "" || txtTelefone.Text == "" || txtemail.Text == "" || txtEndereco.Text == "" || txtCNPJ.Text.Length < 17)
            {
                if (rdConveniado.Checked)
                {
                    if (dtInicio.Value > dtVencimento.Value)
                    {
                        MessageBox.Show("A Data de Vencimento deve ser maior que a data de Início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (txtValor.Text == "")
                    {
                        MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                TipoServicoExterno tipoServicoExterno = (TipoServicoExterno)Enum.Parse(typeof(TipoServicoExterno), cbTipo.SelectedItem.ToString());
                bool conveniado = false;
                ServicoExternoConveniado servicoExternoConveniado = null;

                if (rdConveniado.Checked)
                {
                    conveniado = true;
                    double valor = double.Parse(txtValor.Text);
                    servicoExternoConveniado = new ServicoExternoConveniado(valor, dtInicio.Value, dtVencimento.Value);
                }

                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cnpj = txtCNPJ.Text;
                string telefone = txtTelefone.Text;

                foreach (string str in strings)
                {
                    cnpj = cnpj.Replace(str, "");
                    telefone = telefone.Replace(str, "");
                }

                ServicoExterno servicoExterno = new ServicoExterno(long.Parse(cnpj), tipoServicoExterno, txtNomeServico.Text, long.Parse(telefone), txtemail.Text,
                    txtEndereco.Text, conveniado, servicoExternoConveniado);

                try
                {
                    if (_servicoExternoController.Cadastrar(servicoExterno, servicoExterno.CNPJ))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");
                        txtCNPJ.Text = "";
                        txtNomeServico.Text = "";
                        cbTipo.Text = "";
                        txtTelefone.Text = "";
                        txtemail.Text = "";
                        txtEndereco.Text = "";
                        rdConveniado.Checked = false;
                        rdNaoConveniado.Checked = false;
                        txtValor.Text = "";
                        dtInicio.Value = DateTime.Now;
                        dtVencimento.Value = DateTime.Now;
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

        private void BtnConsultarConveniado_Click(object sender, EventArgs e)
        {
            if (txtCNPJConsulta.Text == "" || txtCNPJConsulta.Text.Length < 17)
            {
                MessageBox.Show("Preencha o campo da Placa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                    string cnpj = txtCNPJConsulta.Text;

                    foreach (string str in strings)
                    {
                        cnpj = cnpj.Replace(str, "");
                    }
                    ServicoExterno servicoExterno = _servicoExternoController.BuscarCNPJ(long.Parse(cnpj));
                    if (servicoExterno == null)
                    {

                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("CNPJ", typeof(long));
                        dt.Columns.Add("Tipo", typeof(string));
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("Telefone", typeof(long));
                        dt.Columns.Add("Email", typeof(string));
                        dt.Columns.Add("Endereço", typeof(string));
                        dt.Columns.Add("Conveniado", typeof(string));
                        dt.Columns.Add("Valor Convênio", typeof(double));
                        dt.Columns.Add("Data Inicio", typeof(DateTime));
                        dt.Columns.Add("Data Vencimento", typeof(DateTime));

                        string conveniado = null;

                        if (servicoExterno.Conveniado)
                        {
                            conveniado = "Sim";
                        }
                        else
                        {
                            conveniado = "Não";
                        }

                        if (servicoExterno.ServicoExternoConveniado == null)
                        {
                            dt.Rows.Add(servicoExterno.CNPJ, servicoExterno.Tipo.ToString(), servicoExterno.Nome
                                , servicoExterno.Telefone, servicoExterno.Email, servicoExterno.Endereco, conveniado);
                        }
                        else
                        {
                            dt.Rows.Add(servicoExterno.CNPJ, servicoExterno.Tipo.ToString(), servicoExterno.Nome
                                , servicoExterno.Telefone, servicoExterno.Email, servicoExterno.Endereco, conveniado
                                , servicoExterno.ServicoExternoConveniado.Valor, servicoExterno.ServicoExternoConveniado.DataInicio
                                , servicoExterno.ServicoExternoConveniado.DataVencimento);
                        }
                        dgConveniadoConsulta.DataSource = dt;

                        ServicoExterno = servicoExterno;
                        servicoExterno = null;
                    }

                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void BtnTodosConveniado_Click(object sender, EventArgs e)
        {
            try
            {
                List<ServicoExterno> servicoExternos = _servicoExternoController.BuscarTodos();

                DataTable dt = new DataTable();
                dt.Columns.Add("CNPJ", typeof(long));
                dt.Columns.Add("Tipo", typeof(string));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Telefone", typeof(long));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Endereço", typeof(string));
                dt.Columns.Add("Conveniado", typeof(string));
                dt.Columns.Add("Valor Convênio", typeof(double));
                dt.Columns.Add("Data Inicio", typeof(DateTime));
                dt.Columns.Add("Data Vencimento", typeof(DateTime));

                foreach (ServicoExterno servicoExterno in servicoExternos)
                {
                    string conveniado = null;

                    if (servicoExterno.Conveniado)
                    {
                        conveniado = "Sim";
                    }
                    else
                    {
                        conveniado = "Não";
                    }

                    if (servicoExterno.ServicoExternoConveniado == null)
                    {
                        dt.Rows.Add(servicoExterno.CNPJ, servicoExterno.Tipo.ToString(), servicoExterno.Nome
                            , servicoExterno.Telefone, servicoExterno.Email, servicoExterno.Endereco, conveniado);
                    }
                    else
                    {
                        dt.Rows.Add(servicoExterno.CNPJ, servicoExterno.Tipo.ToString(), servicoExterno.Nome
                            , servicoExterno.Telefone, servicoExterno.Email, servicoExterno.Endereco, conveniado
                            , servicoExterno.ServicoExternoConveniado.Valor, servicoExterno.ServicoExternoConveniado.DataInicio
                            , servicoExterno.ServicoExternoConveniado.DataVencimento);
                    }
                }
                dgConveniadoConsulta.DataSource = dt;

            }
            catch (ConcorrenciaBancoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnTrasferirConveniado_Click(object sender, EventArgs e)
        {
            if (ServicoExterno == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtValor.Text = "";
                dtInicio.Value = DateTime.Now;
                dtVencimento.Value = DateTime.Now;

                cnpjAntigo = ServicoExterno.CNPJ;
                TipoAntigo = ServicoExterno.Tipo.ToString();
                txtCNPJ.Text = ServicoExterno.CNPJ.ToString();
                txtNomeServico.Text = ServicoExterno.Nome;
                cbTipo.SelectedItem = ServicoExterno.Tipo;
                txtTelefone.Text = ServicoExterno.Telefone.ToString();
                txtemail.Text = ServicoExterno.Email;
                txtEndereco.Text = ServicoExterno.Endereco;

                if (ServicoExterno.Conveniado)
                {
                    rdConveniado.Checked = true;
                    txtValor.Enabled = true;
                    dtInicio.Enabled = true;
                    dtVencimento.Checked = true;

                    txtValor.Text = ServicoExterno.ServicoExternoConveniado.Valor.ToString();
                    dtInicio.Value = ServicoExterno.ServicoExternoConveniado.DataInicio;
                    dtVencimento.Value = ServicoExterno.ServicoExternoConveniado.DataVencimento;
                }
                else
                {
                    rdNaoConveniado.Checked = true;
                }

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlConveniados.SelectTab("tbPageCadastroConveniados");
                if (tbControlConveniados.SelectedTab == tbPageCadastroConveniados)
                {
                    txtCNPJConsulta.Text = "";
                    ServicoExterno = null;
                }
            }
        }

        private void BtnAlterarServicoExterno_Click(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "" || txtNomeServico.Text == "" || txtTelefone.Text == "" || txtemail.Text == "" || txtEndereco.Text == "")
            {
                if (rdConveniado.Checked)
                {
                    if (dtInicio.Value > dtVencimento.Value)
                    {
                        MessageBox.Show("A Data de Vencimento deve ser maior que a data de Início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (txtValor.Text == "")
                    {
                        MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                TipoServicoExterno tipoServicoExterno = (TipoServicoExterno)Enum.Parse(typeof(TipoServicoExterno), cbTipo.SelectedItem.ToString());
                bool conveniado = false;
                ServicoExternoConveniado servicoExternoConveniado = null;

                if (rdConveniado.Checked)
                {
                    conveniado = true;
                    double valor = double.Parse(txtValor.Text);
                    servicoExternoConveniado = new ServicoExternoConveniado(valor, dtInicio.Value, dtVencimento.Value);
                }

                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cnpj = txtCNPJ.Text;
                string telefone = txtTelefone.Text;

                foreach (string str in strings)
                {
                    cnpj = cnpj.Replace(str, "");
                    telefone = telefone.Replace(str, "");
                }

                ServicoExterno servicoExterno = new ServicoExterno(long.Parse(cnpj), tipoServicoExterno, txtNomeServico.Text, long.Parse(telefone), txtemail.Text,
                    txtEndereco.Text, conveniado, servicoExternoConveniado);

                try
                {
                    if(cnpjAntigo == long.MaxValue)
                    {
                        cnpjAntigo = servicoExterno.CNPJ;
                    }
                    if (TipoAntigo == "")
                    {
                        tipoServicoExterno = servicoExterno.Tipo;
                        TipoAntigo = tipoServicoExterno.ToString();
                    }
                    else
                    {
                        tipoServicoExterno = (TipoServicoExterno)Enum.Parse(typeof(TipoServicoExterno), TipoAntigo);
                    }
                    if (_servicoExternoController.Alterar(servicoExterno, cnpjAntigo, tipoServicoExterno))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        cnpjAntigo = long.MaxValue;
                        txtCNPJ.Text = "";
                        txtNomeServico.Text = "";
                        cbTipo.Text = "";
                        txtTelefone.Text = "";
                        txtemail.Text = "";
                        txtEndereco.Text = "";
                        rdConveniado.Checked = false;
                        rdNaoConveniado.Checked = false;
                        txtValor.Text = "";
                        dtInicio.Value = DateTime.Now;
                        dtVencimento.Value = DateTime.Now;
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
                    txtCNPJ.Text = cnpjAntigo.ToString();
                    cbTipo.SelectedItem = tipoServicoExterno;
                }
            }
        }

        private void BtnExcluirServicoExterno_Click(object sender, EventArgs e)
        {
            if (txtCNPJ.Text == "  .   .   /    -")
            {
                MessageBox.Show("Preencha o campo CNPJ corretamente para realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cnpj = txtCNPJ.Text;

                foreach (string str in strings)
                {
                    cnpj = cnpj.Replace(str, "");
                }

                try
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_servicoExternoController.Deletar(long.Parse(cnpj)))
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");
                            txtCNPJ.Text = "";
                            txtNomeServico.Text = "";
                            cbTipo.Text = "";
                            txtTelefone.Text = "";
                            txtemail.Text = "";
                            txtEndereco.Text = "";
                            rdConveniado.Checked = false;
                            rdNaoConveniado.Checked = false;
                            txtValor.Text = "";
                            dtInicio.Value = DateTime.Now;
                            dtVencimento.Value = DateTime.Now;
                        }
                    }
                }
                catch (IntegridadeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (TransacaoException ex)
                {
                    throw new TransacaoException(ex.Message);
                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void AtualizarCor()
        {
            btnCadastrarServicoExterno.BackColor = Properties.Settings.Default.myColor;
            btnConsultarConveniado.BackColor = Properties.Settings.Default.myColor;
            btnTodosConveniado.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirConveniado.BackColor = Properties.Settings.Default.myColor;
            btnAlterarServicoExterno.BackColor = Properties.Settings.Default.myColor;
        }
    }
}
