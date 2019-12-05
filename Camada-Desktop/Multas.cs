using CamadaModelagem.Data;
using CamadaControle.Controllers;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Services;
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
using CamadaModelagem.Services.Exceptions;
using CamadaModelagem.Models.Enums;

namespace CamadaDesktop
{
    public partial class Multas : Form
    {
        private readonly CamadaControle.Controllers.MultaController _multaController;
        private List<Multa> ListaMultas; 
        private Multa Multa;
        string cpfantigo;
        string placaantiga;
        DateTime dataantiga;
        PerfilAcesso PerfilAcesso;

        public Multas()
        {
            InitializeComponent();
            _multaController = InstanciarCamadas();
            Multa = null;
            cpfantigo = "";
            placaantiga = "";
        }

        public Multas(PerfilAcesso perfilAcesso)
        {
            InitializeComponent();
            _multaController = InstanciarCamadas();
            Multa = null;
            cpfantigo = "";
            placaantiga = "";
            PerfilAcesso = perfilAcesso;
        }

        private MultaController InstanciarCamadas()
        {
            Banco banco = new Banco();
            MultaDAL multaDAL = new MultaDAL(banco);
            MultaService multaService = new MultaService(multaDAL);
            return new MultaController(multaService);
        }

        private void rdPaga_CheckedChanged(object sender, EventArgs e)
        {
            dtMultaPaga.Enabled = true;
        }

        private void rdNaoPaga_CheckedChanged(object sender, EventArgs e)
        {
            dtMultaPaga.Enabled = false;
        }

        private void Multas_Load(object sender, EventArgs e)
        {
            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao.Visible = true;
                toolTipPermissao.SetToolTip(this.pbpermissao, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao.Hide(pbpermissao);
            }

            cbPlaca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPlaca.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbPlacaMultasConsulta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPlacaMultasConsulta.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbCPF.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCPF.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbCPFMultasConsulta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCPFMultasConsulta.AutoCompleteSource = AutoCompleteSource.ListItems;

            toolTipTransfere.SetToolTip(this.btnTrasferirMultas, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirMultas);

            try
            {
                cbPlaca.DataSource = _multaController.PopularPlacas();
                cbPlaca.DisplayMember = "MODELO";
                cbPlaca.ValueMember = "VCL_PLACA";

                cbPlacaMultasConsulta.DataSource = _multaController.PopularPlacas();
                cbPlacaMultasConsulta.DisplayMember = "MODELO";
                cbPlacaMultasConsulta.ValueMember = "VCL_PLACA";
            }
            catch (ConcorrenciaBancoException)
            {
                cbPlaca.DataSource = null;
                cbPlacaMultasConsulta = null;
            }

            try
            {
                cbCPF.DataSource = _multaController.PopularCPF();
                cbCPF.DisplayMember = "NOMECPF";
                cbCPF.ValueMember = "MT_CPF";

                cbCPFMultasConsulta.DataSource = _multaController.PopularCPF();
                cbCPFMultasConsulta.DisplayMember = "NOMECPF";
                cbCPFMultasConsulta.ValueMember = "MT_CPF";

            }
            catch (ConcorrenciaBancoException)
            {
                cbCPF.DataSource = null;
                cbCPFMultasConsulta = null;
            }

            AtualizarCor();
        }

        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {


                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (cbCPF.Items.Count < 1)
                {
                    MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (txtvalor.Text == "" || txtLocal.Text == "" || txtDesc.Text == "")
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (rdPaga.Checked)
                    {
                        MessageBox.Show("Preencha os campos Datas corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                      
                    }
                }               
            }
            else
            {
                bool situacao;
                DateTime? multapaga;

                if (rdPaga.Checked)
                {
                    situacao = true;
                    multapaga = dtDataMulta.Value;
                }
                else
                {
                    situacao = false;
                    multapaga = null;
                }

                double valor = double.Parse(txtvalor.Text);
                string placa = cbPlaca.SelectedValue.ToString();
                string cpf = cbCPF.SelectedValue.ToString();


                Multa multa = null;
                Veiculo veiculo = _multaController.BuscarPlaca(placa);
                Motorista motorista = _multaController.BuscarCPF(cpf);

                try
                {
                    multa = new Multa(txtDesc.Text, txtLocal.Text, dtDataMulta.Value, valor, situacao, multapaga, veiculo, motorista);
                    if (_multaController.Cadastrar(multa))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");
                        cbPlaca.Text = "";
                        cbCPF.Text = "";
                        dtDataMulta.Value = DateTime.Now;
                        txtvalor.Text = "";
                        rdPaga.Checked = false;
                        rdNaoPaga.Checked = false;
                        dtMultaPaga.Value = DateTime.Now;
                        txtLocal.Text = "";
                        txtDesc.Text = "";
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

        private void btnConsultarMultas_Click(object sender, EventArgs e)
        {
            if (cbPlacaMultasConsulta.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbCPFMultasConsulta.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string cpf = cbCPFMultasConsulta.SelectedValue.ToString();
                    string placa = cbPlacaMultasConsulta.SelectedValue.ToString();
                    Motorista motorista = _multaController.BuscarCPF(cpf);
                    Veiculo veiculo = _multaController.BuscarPlaca(placa);
                    if (motorista == null || veiculo == null)
                    {
                        MessageBox.Show("Não existe cadastro com essa Placa e CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Multa multa = _multaController.BuscarMulta(placa, cpf, dtDataMultasConsulta.Value);
                        if (multa == null)
                        {
                            MessageBox.Show("Não existe cadastro com essa Multa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("Placa", typeof(string));
                            dt.Columns.Add("CPF", typeof(string));
                            dt.Columns.Add("Descrição", typeof(string));
                            dt.Columns.Add("Local", typeof(string));
                            dt.Columns.Add("Data Ocorrencia", typeof(DateTime));
                            dt.Columns.Add("Valor", typeof(double));
                            dt.Columns.Add("Pago", typeof(string));
                            dt.Columns.Add("Data Pagamento", typeof(DateTime));

                            string situacao = null;

                            if (multa.Paga)
                            {
                                situacao = "Sim";
                            }
                            else
                            {
                                situacao = "Não";
                            }


                            dt.Rows.Add(multa.Veiculo.Placa, multa.Motorista.CPF, multa.Descricao, multa.Local, multa.DataOcorrencia, multa.Valor, situacao, multa.MultasPagas);

                        dgMultasConsulta.DataSource = dt;
                        }
                        Multa = multa;
                        ListaMultas = new List<Multa>();
                        ListaMultas.Add(multa);
                        multa = null;
                    }    
                }
                catch (ConcorrenciaBancoException)
                {
                    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                }
            }
        }

        private void btnTodosMultas_Click(object sender, EventArgs e)
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
                        List<Multa> multas = _multaController.BuscarTodos(dtInicioConsulta.Value, dtFimConsulta.Value);

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Placa", typeof(string));
                        dt.Columns.Add("CPF", typeof(string));
                        dt.Columns.Add("Descrição", typeof(string));
                        dt.Columns.Add("Local", typeof(string));
                        dt.Columns.Add("Data Ocorrencia", typeof(DateTime));
                        dt.Columns.Add("Valor", typeof(double));
                        dt.Columns.Add("Pago", typeof(string));
                        dt.Columns.Add("Data Pagamento", typeof(DateTime));

                        string situacao = null;

                        foreach (Multa multa in multas)
                        {
                            if (multa.Paga)
                            {
                                situacao = "Sim";
                            }
                            else
                            {
                                situacao = "Não";
                            }
                            dt.Rows.Add(multa.Veiculo.Placa, multa.Motorista.CPF, multa.Descricao, multa.Local, multa.DataOcorrencia, multa.Valor, situacao, multa.MultasPagas);
                        }
                        ListaMultas = multas;
                        dgMultasConsulta.DataSource = dt;
                    }
                    catch (ConcorrenciaBancoException)
                    {
                        throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                    }
                }
            }        
        }

        private void btnTrasferirMultas_Click(object sender, EventArgs e)
        {
            if (Multa == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cbPlaca.Text = Multa.Veiculo.Placa;
                placaantiga = Multa.Veiculo.Placa;
                cbCPF.Text = Multa.Motorista.CPF;
                cpfantigo = Multa.Motorista.CPF;
                txtDesc.Text = Multa.Descricao;
                txtLocal.Text = Multa.Local;
                dtDataMulta.Value = Multa.DataOcorrencia;
                dataantiga = Multa.DataOcorrencia;
                txtvalor.Text = Multa.Valor.ToString();
                dtMultaPaga.Text = Multa.MultasPagas.ToString();

                if (Multa.Paga)
                {
                    rdPaga.Checked = true;
                }
                else
                {
                    rdNaoPaga.Checked = true;
                }

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlMultas.SelectTab("tbPageCadastroMultas");
                if (tbControlMultas.SelectedTab == tbPageCadastroMultas)
                {
                    dtDataMultasConsulta.Text = "";
                    cbPlacaMultasConsulta.Text = "";
                    cbCPFMultasConsulta.Text = "";
                    Multa = null;

                    btnCadastrarVeiculo.Visible = false;
                    lblCancelar.Visible = true;
                    btnAlterarVeiculo.Enabled = true;
                    
                    if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                    {
                        btnExcluirVeiculo.Enabled = false;
                    }
                    else
                    {
                        btnExcluirVeiculo.Enabled = true;
                    }
                }
            }
        }

        private void dgMultasConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgMultasConsulta.DataSource == null)
            {

            }
            else if (dgMultasConsulta.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                string placa = dgMultasConsulta.CurrentRow.Cells[0].Value.ToString();
                string cpf = dgMultasConsulta.CurrentRow.Cells[1].Value.ToString();
                string descricao = dgMultasConsulta.CurrentRow.Cells[2].Value.ToString();
                DateTime dataOcorrencia = Convert.ToDateTime(dgMultasConsulta.CurrentRow.Cells[4].Value);

                foreach (Multa multa in ListaMultas)
                {
                    if (multa.Veiculo.Placa == placa && multa.Motorista.CPF == cpf && multa.DataOcorrencia == dataOcorrencia && multa.Descricao == descricao)
                    {
                        cbPlaca.Text = multa.Veiculo.Placa;
                        placaantiga = multa.Veiculo.Placa;
                        cbCPF.Text = multa.Motorista.CPF;
                        cpfantigo = multa.Motorista.CPF;
                        txtDesc.Text = multa.Descricao;
                        txtLocal.Text = multa.Local;
                        dtDataMulta.Value = multa.DataOcorrencia;
                        dataantiga = multa.DataOcorrencia;
                        txtvalor.Text = multa.Valor.ToString();
                        dtMultaPaga.Text = multa.MultasPagas.ToString();

                        if (multa.Paga)
                        {
                            rdPaga.Checked = true;
                        }
                        else
                        {
                            rdNaoPaga.Checked = true;
                        }

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                        tbControlMultas.SelectTab("tbPageCadastroMultas");
                        if (tbControlMultas.SelectedTab == tbPageCadastroMultas)
                        {
                            dtDataMultasConsulta.Text = "";
                            cbPlacaMultasConsulta.Text = "";
                            cbCPFMultasConsulta.Text = "";
                            Multa = null;

                            btnCadastrarVeiculo.Visible = false;
                            lblCancelar.Visible = true;
                            btnAlterarVeiculo.Enabled = true;

                            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                            {
                                btnExcluirVeiculo.Enabled = false;
                            }
                            else
                            {
                                btnExcluirVeiculo.Enabled = true;
                            }
                        }
                    }
                }
                dgMultasConsulta.DataSource = null;
            }

        }

        private void btnAlterarVeiculo_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {


                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (cbCPF.Items.Count < 1)
                {
                    MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (txtvalor.Text == "" || txtLocal.Text == "" || txtDesc.Text == "")
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (rdPaga.Checked)
                    {
                        MessageBox.Show("Preencha os campos Datas corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                bool situacao;
                DateTime? multapaga;

                if (rdPaga.Checked)
                {
                    situacao = true;
                    multapaga = dtDataMulta.Value;
                }
                else
                {
                    situacao = false;
                    multapaga = null;
                }

                double valor = double.Parse(txtvalor.Text);
                string placa = cbPlaca.SelectedValue.ToString();
                string cpf = cbCPF.SelectedValue.ToString();


                Multa multa = null;
                Veiculo veiculo = _multaController.BuscarPlaca(placa);
                Motorista motorista = _multaController.BuscarCPF(cpf);

                multa = new Multa(txtDesc.Text, txtLocal.Text, dtDataMulta.Value, valor, situacao, multapaga, veiculo, motorista);
                try
                {
                    if (_multaController.Alterar(multa, placaantiga, cpfantigo, dataantiga))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        cpfantigo = "";
                        placaantiga = "";
                        cbPlaca.SelectedItem = cbPlaca.Items[0];
                        cbCPF.SelectedItem = cbCPF.Items[0];
                        dtDataMulta.Value = DateTime.Now;
                        txtvalor.Text = "";
                        rdPaga.Checked = false;
                        rdNaoPaga.Checked = false;
                        dtMultaPaga.Value = DateTime.Now;
                        txtLocal.Text = "";
                        txtDesc.Text = "";

                        btnCadastrarVeiculo.Visible = true;
                        lblCancelar.Visible = false;
                        btnAlterarVeiculo.Enabled = false;
                        btnExcluirVeiculo.Enabled = false;
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

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (cbCPF.Items.Count < 1)
                {
                    MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Preencha o campo CPF, Placa e Data da Ocorrencia corretamente para realizar esta opereção!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                string placa = cbPlaca.SelectedValue.ToString();
                string cpf = cbCPF.SelectedValue.ToString();
                try
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_multaController.Deletar(placa, cpf, dtDataMulta.Value))
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");
                            cbPlaca.SelectedItem = cbPlaca.Items[0];
                            cbCPF.SelectedItem = cbCPF.Items[0];
                            dtDataMulta.Value = DateTime.Now;
                            txtvalor.Text = "";
                            rdPaga.Checked = false;
                            rdNaoPaga.Checked = false;
                            dtMultaPaga.Value = DateTime.Now;
                            txtLocal.Text = "";
                            txtDesc.Text = "";

                            btnCadastrarVeiculo.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarVeiculo.Enabled = false;
                            btnExcluirVeiculo.Enabled = false;
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

            btnCadastrarVeiculo.BackColor = Properties.Settings.Default.myColor;
            btnConsultarMultas.BackColor = Properties.Settings.Default.myColor;
            btnTodosMultas.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirMultas.BackColor = Properties.Settings.Default.myColor;
            btnAlterarVeiculo.BackColor = Properties.Settings.Default.myColor;

            btnCadastrarVeiculo.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarMultas.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodosMultas.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirMultas.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarVeiculo.ForeColor = Properties.Settings.Default.myColorFonteMenu;

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
                cbPlaca.SelectedItem = cbPlaca.Items[0];
                cbCPF.SelectedItem = cbCPF.Items[0];
                dtDataMulta.Value = DateTime.Now;
                txtvalor.Text = "";
                rdPaga.Checked = false;
                rdNaoPaga.Checked = false;
                dtMultaPaga.Value = DateTime.Now;
                txtLocal.Text = "";
                txtDesc.Text = "";

                btnCadastrarVeiculo.Visible = true;
                lblCancelar.Visible = false;
                btnAlterarVeiculo.Enabled = false;
                btnExcluirVeiculo.Enabled = false;

                Multa = null;
            }
        }
    }
}
