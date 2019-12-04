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
    public partial class Veiculos : Form
    {
        private readonly VeiculoController _veiculoController;
        private List<Veiculo> ListaVeiculos;
        private Veiculo Veiculo;
        string PlacaAntiga;
        bool situacao;

        PerfilAcesso PerfilAcesso;
        public Veiculos()
        {
            InitializeComponent();
            _veiculoController = InstanciarCamadas();
            Veiculo = null;
            PlacaAntiga = "";
            situacao = true;
        }
        public Veiculos(PerfilAcesso perfilAcesso) // <<<------- Instanciando o Perfil de Acesso para ser usado neste menu
        {
            InitializeComponent();
            _veiculoController = InstanciarCamadas();
            Veiculo = null;
            PlacaAntiga = "";
            PerfilAcesso = perfilAcesso;
            situacao = true;
        }

        private VeiculoController InstanciarCamadas()
        {
            Banco banco = new Banco();
            VeiculoDAL veiculoDAL = new VeiculoDAL(banco);
            ManutencaoDAL manutencaoDAL = new ManutencaoDAL(banco);
            AbastecimentoDAL abastecimentoDAL = new AbastecimentoDAL(banco);
            EntradaSaidaDAL entradaSaidaDAL = new EntradaSaidaDAL(banco);
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            VeiculoService veiculoService = new VeiculoService(veiculoDAL, manutencaoDAL, abastecimentoDAL, entradaSaidaDAL, seguroDAL);
            return new VeiculoController(veiculoService);
        }
        private void Veiculos_Load(object sender, EventArgs e)
        {
            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao.Visible = true;
                toolTipPermissao.SetToolTip(this.pbpermissao, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao.Hide(pbpermissao);
            }
            
            cbCor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCor.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbCombustivel.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCombustivel.AutoCompleteSource = AutoCompleteSource.ListItems;

            tooltipPesquisar.SetToolTip(lbPesquisar, "Pesquise pela Placa, Marca, Modelo ou Chassi do Veículo.");
            tooltipPesquisar.Hide(lbPesquisar);

            toolTipTransfere.SetToolTip(this.btnTrasferirVeiculo, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirVeiculo);

            cbCombustivel.DataSource = Enum.GetValues(typeof(VeiculoCombustivel));
            cbCor.DataSource = Enum.GetValues(typeof(VeiculoTipoCor));
            AtualizarCor();
        }

        private void BtnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            if(txtPlaca.Text == "" || txtChassi.Text == "" || txtChassi.Text.Length < 17 || txtMarca.Text == "" || txtModelo.Text == "")
            {
                if (rdAlugado.Checked)
                {
                    if(dtInicio.Value > dtVencimento.Value)
                    {
                        MessageBox.Show("A Data de Vencimento deve ser maior que a data de Início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if(txtValor.Text == "")
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
                VeiculoCombustivel veiculoCombustivel = (VeiculoCombustivel)Enum.Parse(typeof(VeiculoCombustivel), cbCombustivel.SelectedItem.ToString());
                VeiculoTipoCor veiculoTipoCor = (VeiculoTipoCor)Enum.Parse(typeof(VeiculoTipoCor), cbCor.SelectedItem.ToString());
                bool alugado = false;
                VeiculoAlugado veiculoAlugado = null;
                bool situacao = true;
                if (rdAlugado.Checked)
                {
                    alugado = true;
                    double valor = double.Parse(txtValor.Text);
                    veiculoAlugado = new VeiculoAlugado(valor, dtInicio.Value, dtVencimento.Value);
                }

                Veiculo veiculo = new Veiculo(txtPlaca.Text.Replace("-",""), txtMarca.Text, txtModelo.Text, txtChassi.Text, dtAno.Value.Year, veiculoTipoCor, veiculoCombustivel, alugado, situacao, veiculoAlugado);
                try
                {
                    if(_veiculoController.Cadastrar(veiculo, veiculo.Placa))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");
                        txtPlaca.Clear();
                        txtMarca.Clear();
                        txtModelo.Clear();
                        txtChassi.Clear();
                        dtAno.Value = DateTime.Now;
                        cbCombustivel.Text = "";
                        cbCor.Text = "";
                        rdAlugado.Checked = false;
                        rdNaoAlugado.Checked = false;
                        txtValor.Clear();
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

        private void BtnConsultarVeiculo_Click(object sender, EventArgs e)
        {
            if(txtPlacaConsulta.Text == "" || txtPlacaConsulta.Text.Length < 7)
            {
                MessageBox.Show("Preencha o campo da Placa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Veiculo veiculo = _veiculoController.BuscarPlaca(txtPlacaConsulta.Text.Replace("-", ""));
                    if(veiculo == null)
                    {
                        MessageBox.Show("Não existe cadastro com essa Placa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Placa", typeof(string));
                        dt.Columns.Add("Marca", typeof(string));
                        dt.Columns.Add("Modelo", typeof(string));
                        dt.Columns.Add("Chassi", typeof(string));
                        dt.Columns.Add("Ano", typeof(int));
                        dt.Columns.Add("Cor", typeof(string));
                        dt.Columns.Add("Combustível", typeof(string));
                        dt.Columns.Add("Alugado", typeof(string));
                        dt.Columns.Add("Situacao", typeof(string));
                        dt.Columns.Add("Valor Aluguel", typeof(double));
                        dt.Columns.Add("Data Inicio", typeof(DateTime));
                        dt.Columns.Add("Data Vencimento", typeof(DateTime));

                        string alugado = null;
                        string situacao = null;

                        if (veiculo.Alugado)
                        {
                            alugado = "Sim";
                        }
                        else
                        {
                            alugado = "Não";
                        }

                        if (veiculo.SituacaoVeiculo)
                        {
                            situacao = "Ativo";
                        }
                        else
                        {
                            situacao = "Inativo";
                        }

                        if (veiculo.VeiculoAlugado == null)
                        {
                            dt.Rows.Add(veiculo.Placa, veiculo.Marca, veiculo.Modelo
                                , veiculo.Chassi, veiculo.Ano, veiculo.Cor.ToString(), veiculo.Combustivel.ToString()
                                , alugado, situacao);
                        }
                        else
                        {
                            dt.Rows.Add(veiculo.Placa, veiculo.Marca, veiculo.Modelo
                                , veiculo.Chassi, veiculo.Ano, veiculo.Cor.ToString(), veiculo.Combustivel.ToString()
                                , alugado, situacao, veiculo.VeiculoAlugado.Valor
                                , veiculo.VeiculoAlugado.DataInicio, veiculo.VeiculoAlugado.DataVencimento);
                        }
                        dgVeiculoConsulta.DataSource = dt;

                        Veiculo = veiculo;
                        ListaVeiculos = new List<Veiculo>();
                        ListaVeiculos.Add(veiculo);
                        veiculo = null;
                    }
                    
                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void rdAlugado_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Enabled = true;
            dtInicio.Enabled = true;
            dtVencimento.Enabled = true;
        }

        private void rdNaoAlugado_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Enabled = false;
            dtInicio.Enabled = false;
            dtVencimento.Enabled = false;
        }

        private void BtnTodosVeiculo_Click(object sender, EventArgs e)
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
                        List<Veiculo> veiculos = _veiculoController.BuscarTodos(dtInicioConsulta.Value, dtFimConsulta.Value);

                        DataTable dt = new DataTable();
                        dt.Columns.Add("Placa", typeof(string));
                        dt.Columns.Add("Marca", typeof(string));
                        dt.Columns.Add("Modelo", typeof(string));
                        dt.Columns.Add("Chassi", typeof(string));
                        dt.Columns.Add("Ano", typeof(int));
                        dt.Columns.Add("Cor", typeof(string));
                        dt.Columns.Add("Combustível", typeof(string));
                        dt.Columns.Add("Alugado", typeof(string));
                        dt.Columns.Add("Situacao", typeof(string));
                        dt.Columns.Add("Valor Aluguel", typeof(double));
                        dt.Columns.Add("Data Inicio", typeof(DateTime));
                        dt.Columns.Add("Data Vencimento", typeof(DateTime));

                        foreach (Veiculo veiculo in veiculos)
                        {
                            string alugado = null;
                            string situacao = null;

                            if (veiculo.Alugado)
                            {
                                alugado = "Sim";
                            }
                            else
                            {
                                alugado = "Não";
                            }

                            if (veiculo.SituacaoVeiculo)
                            {
                                situacao = "Ativo";
                            }
                            else
                            {
                                situacao = "Inativo";
                            }

                            if (veiculo.VeiculoAlugado == null)
                            {
                                dt.Rows.Add(veiculo.Placa, veiculo.Marca, veiculo.Modelo
                                    , veiculo.Chassi, veiculo.Ano, veiculo.Cor.ToString(), veiculo.Combustivel.ToString()
                                    , alugado, situacao);
                            }
                            else
                            {
                                dt.Rows.Add(veiculo.Placa, veiculo.Marca, veiculo.Modelo
                                    , veiculo.Chassi, veiculo.Ano, veiculo.Cor.ToString(), veiculo.Combustivel.ToString()
                                    , alugado, situacao, veiculo.VeiculoAlugado.Valor
                                    , veiculo.VeiculoAlugado.DataInicio, veiculo.VeiculoAlugado.DataVencimento);
                            }
                        }
                        ListaVeiculos = veiculos;
                        dgVeiculoConsulta.DataSource = dt;

                    }
                    catch (ConcorrenciaBancoException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }           
        }

        private void BtnTrasferirVeiculo_Click(object sender, EventArgs e)
        {
            if(Veiculo == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtValor.Text = "";
                dtInicio.Value = DateTime.Now;
                dtVencimento.Value = DateTime.Now;

                PlacaAntiga = Veiculo.Placa;
                DateTime ano = new DateTime(Veiculo.Ano, DateTime.Now.Month, DateTime.Now.Day);
                txtPlaca.Text = Veiculo.Placa;
                txtMarca.Text = Veiculo.Marca;
                dtAno.Value = ano;
                txtModelo.Text = Veiculo.Modelo;
                txtChassi.Text = Veiculo.Chassi;
                cbCor.SelectedItem = Veiculo.Cor;
                cbCor.Text = Veiculo.Cor.ToString();
                cbCombustivel.SelectedItem = Veiculo.Combustivel;
                cbCombustivel.Text = Veiculo.Combustivel.ToString();

                if (Veiculo.Alugado)
                {
                    rdAlugado.Checked = true;
                    txtValor.Enabled = true;
                    dtInicio.Enabled = true;
                    dtVencimento.Checked = true;

                    txtValor.Text = Veiculo.VeiculoAlugado.Valor.ToString();
                    dtInicio.Value = Veiculo.VeiculoAlugado.DataInicio;
                    dtVencimento.Value = Veiculo.VeiculoAlugado.DataVencimento;
                }
                else
                {
                    rdNaoAlugado.Checked = true;
                }

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlVeiculos.SelectTab("tbPageCadastroVeiculo");
                if(tbControlVeiculos.SelectedTab == tbPageCadastroVeiculo)
                {
                    if (Veiculo.SituacaoVeiculo)
                    {
                        txtPlacaConsulta.Text = "";
                        Veiculo = null;

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
                    else
                    {
                        txtPlaca.Enabled = false;
                        txtMarca.Enabled = false;
                        txtModelo.Enabled = false;
                        txtChassi.Enabled = false;
                        dtAno.Enabled = false;
                        cbCombustivel.Enabled = false;
                        cbCor.Enabled = false;
                        rdAlugado.Enabled = false;
                        rdNaoAlugado.Enabled = false;
                        txtValor.Enabled = false;
                        dtInicio.Enabled = false;
                        dtVencimento.Enabled = false;

                        btnCadastrarVeiculo.Visible = false;
                        lblCancelar.Visible = true;
                        btnAlterarVeiculo.Enabled = false;                       
                        situacao = false;

                        if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                        {
                            btnAtivarVeiculo.Enabled = false;
                            btnAtivarVeiculo.Visible = false;
                            btnExcluirVeiculo.Visible = false;
                        }
                        else
                        {
                            btnAtivarVeiculo.Enabled = true;
                            btnAtivarVeiculo.Visible = true;
                            btnExcluirVeiculo.Visible = false;
                        }
                    }
                }
            }
        }

        private void DgVeiculoConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgVeiculoConsulta.DataSource == null)
            {

            }
            else if (dgVeiculoConsulta.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                string placa = dgVeiculoConsulta.CurrentRow.Cells[0].Value.ToString();

                foreach (Veiculo veiculo in ListaVeiculos)
                {
                    if (veiculo.Placa == placa)
                    {
                        txtValor.Text = "";
                        dtInicio.Value = DateTime.Now;
                        dtVencimento.Value = DateTime.Now;

                        PlacaAntiga = veiculo.Placa;
                        DateTime ano = new DateTime(veiculo.Ano, DateTime.Now.Month, DateTime.Now.Day);
                        txtPlaca.Text = veiculo.Placa;
                        txtMarca.Text = veiculo.Marca;
                        dtAno.Value = ano;
                        txtModelo.Text = veiculo.Modelo;
                        txtChassi.Text = veiculo.Chassi;
                        cbCor.SelectedItem = veiculo.Cor;
                        cbCor.Text = veiculo.Cor.ToString();
                        cbCombustivel.SelectedItem = veiculo.Combustivel;
                        cbCombustivel.Text = veiculo.Combustivel.ToString();

                        if (veiculo.Alugado)
                        {
                            rdAlugado.Checked = true;
                            txtValor.Enabled = true;
                            dtInicio.Enabled = true;
                            dtVencimento.Checked = true;

                            txtValor.Text = veiculo.VeiculoAlugado.Valor.ToString();
                            dtInicio.Value = veiculo.VeiculoAlugado.DataInicio;
                            dtVencimento.Value = veiculo.VeiculoAlugado.DataVencimento;
                        }
                        else
                        {
                            rdNaoAlugado.Checked = true;
                        }

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                        tbControlVeiculos.SelectTab("tbPageCadastroVeiculo");
                        if (tbControlVeiculos.SelectedTab == tbPageCadastroVeiculo)
                        {
                            if (veiculo.SituacaoVeiculo)
                            {
                                txtPlacaConsulta.Text = "";
                                Veiculo = null;

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
                            else
                            {
                                txtPlaca.Enabled = false;
                                txtMarca.Enabled = false;
                                txtModelo.Enabled = false;
                                txtChassi.Enabled = false;
                                dtAno.Enabled = false;
                                cbCombustivel.Enabled = false;
                                cbCor.Enabled = false;
                                rdAlugado.Enabled = false;
                                rdNaoAlugado.Enabled = false;
                                txtValor.Enabled = false;
                                dtInicio.Enabled = false;
                                dtVencimento.Enabled = false;

                                btnCadastrarVeiculo.Visible = false;
                                lblCancelar.Visible = true;
                                btnAlterarVeiculo.Enabled = false;
                                situacao = false;

                                if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                                {
                                    btnAtivarVeiculo.Enabled = false;
                                    btnAtivarVeiculo.Visible = true;
                                    btnExcluirVeiculo.Visible = false;
                                }
                                else
                                {
                                    btnAtivarVeiculo.Enabled = true;
                                    btnAtivarVeiculo.Visible = true;
                                    btnExcluirVeiculo.Visible = false;
                                }
                            }
                        }
                    }
                }
                textPesquisar.Text = "";
                dgVeiculoConsulta.DataSource = null;
            }
        }

        private void BtnAlterarVeiculo_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "" || txtChassi.Text == "" || txtChassi.Text.Length < 17 || txtMarca.Text == "" || txtModelo.Text == "")
            {
                if (rdAlugado.Checked)
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
                VeiculoCombustivel veiculoCombustivel = (VeiculoCombustivel)Enum.Parse(typeof(VeiculoCombustivel), cbCombustivel.SelectedItem.ToString());
                VeiculoTipoCor veiculoTipoCor = (VeiculoTipoCor)Enum.Parse(typeof(VeiculoTipoCor), cbCor.SelectedItem.ToString());
                bool alugado = false;
                VeiculoAlugado veiculoAlugado = null;
                bool situacao = true;
                if (rdAlugado.Checked)
                {
                    alugado = true;
                    double valor = double.Parse(txtValor.Text);
                    veiculoAlugado = new VeiculoAlugado(valor, dtInicio.Value, dtVencimento.Value);

                }

                Veiculo veiculo = new Veiculo(txtPlaca.Text.Replace("-", ""), txtMarca.Text, txtModelo.Text, txtChassi.Text, dtAno.Value.Year, veiculoTipoCor, veiculoCombustivel, alugado, situacao, veiculoAlugado);
                try
                {
                    if(PlacaAntiga == "")
                    {
                        PlacaAntiga = veiculo.Placa;
                    }
                    if (_veiculoController.Alterar(veiculo, PlacaAntiga))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        PlacaAntiga = "";
                        txtPlaca.Clear();
                        txtMarca.Clear();
                        txtModelo.Clear();
                        txtChassi.Clear();
                        dtAno.Value = DateTime.Now;
                        cbCombustivel.Text = "";
                        cbCor.Text = "";
                        rdAlugado.Checked = false;
                        rdNaoAlugado.Checked = false;
                        txtValor.Clear();
                        dtInicio.Value = DateTime.Now;
                        dtVencimento.Value = DateTime.Now;

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
                catch (IntegridadeException ex)
                {
                    MessageBox.Show(ex.Message);
                    txtPlaca.Text = PlacaAntiga;
                }
            }
        }

        private void BtnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "   -")
            {
                MessageBox.Show("Preencha o campo Placa corretamente para realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string placa = txtPlaca.Text.Replace("-", "");
                try
                {
                    if (MessageBox.Show("Deseja realmente inativar?\nAtenção! As viagens vinculadas a esse veículo serão excluidas nessa ação.", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_veiculoController.Inativar(placa, situacao))
                        {
                            MessageBox.Show("Inativação realizada com Sucesso!");
                            txtPlaca.Clear();
                            txtMarca.Clear();
                            txtModelo.Clear();
                            txtChassi.Clear();
                            dtAno.Value = DateTime.Now;
                            cbCombustivel.Text = "";
                            cbCor.Text = "";
                            rdAlugado.Checked = false;
                            rdNaoAlugado.Checked = false;
                            txtValor.Clear();
                            dtInicio.Value = DateTime.Now;
                            dtVencimento.Value = DateTime.Now;

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

        private void btnAtivarVeiculo_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "   -")
            {
                MessageBox.Show("Preencha o campo Placa corretamente para realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string placa = txtPlaca.Text.Replace("-", "");
                try
                {
                    if (MessageBox.Show("Deseja realmente ativar?\nAtenção! As viagens vinculados a esse veículo foram excluidas, cadastre novamente para atribuir novas.", "Ativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_veiculoController.Inativar(placa, situacao))
                        {
                            MessageBox.Show("Ativação realizada com Sucesso!");
                            txtPlaca.Clear();
                            txtMarca.Clear();
                            txtModelo.Clear();
                            txtChassi.Clear();
                            dtAno.Value = DateTime.Now;
                            cbCombustivel.Text = "";
                            cbCor.Text = "";
                            rdAlugado.Checked = false;
                            rdNaoAlugado.Checked = false;
                            txtValor.Clear();
                            dtInicio.Value = DateTime.Now;
                            dtVencimento.Value = DateTime.Now;

                            btnCadastrarVeiculo.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarVeiculo.Enabled = false;
                            btnExcluirVeiculo.Visible = true;
                            btnExcluirVeiculo.Enabled = false;
                            btnAtivarVeiculo.Enabled = false;
                            btnAtivarVeiculo.Visible = false;

                            txtPlaca.Enabled = true;
                            txtMarca.Enabled = true;
                            txtModelo.Enabled = true;
                            txtChassi.Enabled = true;
                            dtAno.Enabled = true;
                            cbCombustivel.Enabled = true;
                            cbCor.Enabled = true;
                            rdAlugado.Enabled = true;
                            rdNaoAlugado.Enabled = true;
                            txtValor.Enabled = true;
                            dtInicio.Enabled = true;
                            dtVencimento.Enabled = true;
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

        public void AtualizarCor()
        {
            this.BackColor = Properties.Settings.Default.myColorFundo;
            btnCadastrarVeiculo.BackColor = Properties.Settings.Default.myColor;
            btnConsultarVeiculo.BackColor = Properties.Settings.Default.myColor;
            btnTodosVeiculo.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirVeiculo.BackColor = Properties.Settings.Default.myColor;
            btnAlterarVeiculo.BackColor = Properties.Settings.Default.myColor;
                                    
            btnCadastrarVeiculo.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarVeiculo.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodosVeiculo.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirVeiculo.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarVeiculo.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            btnConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            panelConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            btnConsultarPorData.ForeColor = Properties.Settings.Default.myColorFonteMenu;
        }

        private void TextPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Veiculo> veiculos = _veiculoController.Pesquisar(textPesquisar.Text);

                DataTable dt = new DataTable();
                dt.Columns.Add("Placa", typeof(string));
                dt.Columns.Add("Marca", typeof(string));
                dt.Columns.Add("Modelo", typeof(string));
                dt.Columns.Add("Chassi", typeof(string));
                dt.Columns.Add("Ano", typeof(int));
                dt.Columns.Add("Cor", typeof(string));
                dt.Columns.Add("Combustível", typeof(string));
                dt.Columns.Add("Alugado", typeof(string));
                dt.Columns.Add("Situacao", typeof(string));
                dt.Columns.Add("Valor Aluguel", typeof(double));
                dt.Columns.Add("Data Inicio", typeof(DateTime));
                dt.Columns.Add("Data Vencimento", typeof(DateTime));

                foreach (Veiculo veiculo in veiculos)
                {
                    string alugado = null;
                    string situacao = null;

                    if (veiculo.Alugado)
                    {
                        alugado = "Sim";
                    }
                    else
                    {
                        alugado = "Não";
                    }

                    if (veiculo.SituacaoVeiculo)
                    {
                        situacao = "Ativo";
                    }
                    else
                    {
                        situacao = "Inativo";
                    }

                    if (veiculo.VeiculoAlugado == null)
                    {
                        dt.Rows.Add(veiculo.Placa, veiculo.Marca, veiculo.Modelo
                            , veiculo.Chassi, veiculo.Ano, veiculo.Cor.ToString(), veiculo.Combustivel.ToString()
                            , alugado, situacao);
                    }
                    else
                    {
                        dt.Rows.Add(veiculo.Placa, veiculo.Marca, veiculo.Modelo
                            , veiculo.Chassi, veiculo.Ano, veiculo.Cor.ToString(), veiculo.Combustivel.ToString()
                            , alugado, situacao, veiculo.VeiculoAlugado.Valor
                            , veiculo.VeiculoAlugado.DataInicio, veiculo.VeiculoAlugado.DataVencimento);
                    }
                }
                ListaVeiculos = veiculos;
                dgVeiculoConsulta.DataSource = dt;

            }
            catch (ConcorrenciaBancoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panelConsultarPorData_MouseLeave(object sender, EventArgs e)
        {
            panelConsultarPorData.Visible = false;
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar manipulação de dados?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtPlaca.Clear();
                txtMarca.Clear();
                txtModelo.Clear();
                txtChassi.Clear();
                dtAno.Value = DateTime.Now;
                cbCombustivel.Text = "";
                cbCor.Text = "";
                rdAlugado.Checked = false;
                rdNaoAlugado.Checked = false;
                txtValor.Clear();
                dtInicio.Value = DateTime.Now;
                dtVencimento.Value = DateTime.Now;

                btnCadastrarVeiculo.Visible = true;
                lblCancelar.Visible = false;
                btnAlterarVeiculo.Enabled = false;
                btnExcluirVeiculo.Enabled = false;
                btnAtivarVeiculo.Enabled = false;
                btnAtivarVeiculo.Visible = false;
                btnExcluirVeiculo.Visible = true;

                Veiculo = null;

                txtPlaca.Enabled = true;
                txtMarca.Enabled = true;
                txtModelo.Enabled = true;
                txtChassi.Enabled = true;
                dtAno.Enabled = true;
                cbCombustivel.Enabled = true;
                cbCor.Enabled = true;
                rdAlugado.Enabled = true;
                rdNaoAlugado.Enabled = true;
                txtValor.Enabled = true;
                dtInicio.Enabled = true;
                dtVencimento.Enabled = true;
                situacao = true;
            }
        }
    }
}
