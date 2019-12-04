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
    public partial class Manutencoes : Form
    {
        private readonly ManutencaoController _manutencaoController;
        private List<Manutencao> ListaManutencoes;
        private Manutencao Manutencao;
        string PlacaAntiga;
        string TipoAntigo;
        DateTime dataAntiga;
        PerfilAcesso PerfilAcesso;

        public Manutencoes()
        {
            InitializeComponent();
            _manutencaoController = InstanciarCamadas();
            Manutencao = null;
            PlacaAntiga = "";
            TipoAntigo = "";
            dataAntiga = new DateTime(2000,01,01);

        }

        public Manutencoes(PerfilAcesso perfilAcesso)
        {
            InitializeComponent();
            _manutencaoController = InstanciarCamadas();
            Manutencao = null;
            PlacaAntiga = "";
            TipoAntigo = "";
            dataAntiga = new DateTime(2000, 01, 01);
            PerfilAcesso = perfilAcesso;
        }

        private ManutencaoController InstanciarCamadas()
        {
            Banco banco = new Banco();
            ManutencaoDAL manutencaoDAL = new ManutencaoDAL(banco);
            ManutencaoService manutencaoService = new ManutencaoService(manutencaoDAL);
            return new ManutencaoController(manutencaoService);
        }

        private void Manutencoes_Load(object sender, EventArgs e)
        {
            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao.Visible = true;
                toolTipPermissao.SetToolTip(this.pbpermissao, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao.Hide(pbpermissao);
            }

            cbTipo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTipo.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbTipoManuntConsulta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTipoManuntConsulta.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbPlaca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPlaca.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbPlacaConsulta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPlacaConsulta.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbServicoExterno.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbServicoExterno.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbSituacao.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSituacao.AutoCompleteSource = AutoCompleteSource.ListItems;

            toolTipTransfere.SetToolTip(this.btnTrasferirManunt, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirManunt);

            cbTipo.DataSource = Enum.GetValues(typeof(ManutencaoTipo));
            cbTipoManuntConsulta.DataSource = Enum.GetValues(typeof(ManutencaoTipo));

            cbSituacao.DataSource = Enum.GetValues(typeof(SituacaoManutencao));
            try
            {
                cbPlaca.DataSource = _manutencaoController.PopularPlacas();
                cbPlaca.DisplayMember = "MODELO";
                cbPlaca.ValueMember = "VCL_PLACA";

                cbPlacaConsulta.DataSource = _manutencaoController.PopularPlacas();
                cbPlacaConsulta.DisplayMember = "MODELO";
                cbPlacaConsulta.ValueMember = "VCL_PLACA";
            }
            catch (ConcorrenciaBancoException)
            {
                cbPlaca.DataSource = null;
            }
            try
            {
                cbServicoExterno.DataSource = _manutencaoController.PopularServicosExternos();
                cbServicoExterno.DisplayMember = "SERVEXT_NOME";
                cbServicoExterno.ValueMember = "SERVEXT_CNPJ";
            }
            catch (ConcorrenciaBancoException)
            {
                cbServicoExterno.DataSource = null;
            }

            AtualizarCor();
        }

        private void BtnCadastrarManunt_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbServicoExterno.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma oficina antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtValor.Text == "" || txtDescricao.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ManutencaoTipo manutencaoTipo = (ManutencaoTipo)Enum.Parse(typeof(ManutencaoTipo), cbTipo.SelectedItem.ToString());
                SituacaoManutencao situacaoManutencao = (SituacaoManutencao)Enum.Parse(typeof(SituacaoManutencao), cbSituacao.SelectedItem.ToString());
                double valor = double.Parse(txtValor.Text);
                string placa = cbPlaca.SelectedValue.ToString();
                long cNPJ = Convert.ToInt64(cbServicoExterno.SelectedValue);

                Manutencao manutencao = new Manutencao(manutencaoTipo, txtDescricao.Text, dtDataManunt.Value, valor, situacaoManutencao, cNPJ, placa);

                try
                {
                    if (_manutencaoController.Cadastrar(manutencao, manutencao.Placa, manutencao.Tipo, manutencao.Data))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");
                        cbTipo.Text = "";
                        dtDataManunt.Value = DateTime.Now;
                        txtValor.Text = "";
                        cbPlaca.Text = "";
                        cbServicoExterno.Text = "";
                        txtDescricao.Text = "";
                        cbSituacao.Text = "";
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

        private void BtnConsultarManunt_Click(object sender, EventArgs e)
        {
            if (cbPlacaConsulta.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    ManutencaoTipo manutencaoTipo = (ManutencaoTipo)Enum.Parse(typeof(ManutencaoTipo), cbTipoManuntConsulta.SelectedItem.ToString());
                    string placa = cbPlacaConsulta.SelectedValue.ToString();

                    Manutencao manutencao = _manutencaoController.BuscarManutencao(placa, manutencaoTipo, dtDataManuntConsulta.Value);
                    if (manutencao == null)
                    {
                        dgVeiculoManunt.DataSource = null;
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Tipo", typeof(string));
                        dt.Columns.Add("CNPJ", typeof(long));
                        dt.Columns.Add("Placa", typeof(string));
                        dt.Columns.Add("Descrição", typeof(string));
                        dt.Columns.Add("Valor Manutenção", typeof(double));
                        dt.Columns.Add("Data", typeof(DateTime));
                        dt.Columns.Add("Situação", typeof(string));


                        dt.Rows.Add(manutencao.Tipo.ToString(), manutencao.CNPJ, manutencao.Placa, manutencao.Descricao, manutencao.Valor
                            , manutencao.Data, manutencao.Situacao.ToString());
                        dgVeiculoManunt.DataSource = dt;

                        Manutencao = manutencao;
                        ListaManutencoes = new List<Manutencao>();
                        ListaManutencoes.Add(manutencao);
                        manutencao = null;
                    }

                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void BtnTodosManunt_Click(object sender, EventArgs e)
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
                    if (cbPlacaConsulta.Items.Count < 1)
                    {
                        MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (cbServicoExterno.Items.Count < 1)
                    {
                        MessageBox.Show("Cadastre uma oficina antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {
                            List<Manutencao> manutencoes = _manutencaoController.BuscarTodos(dtInicioConsulta.Value, dtFimConsulta.Value);

                            DataTable dt = new DataTable();
                            dt.Columns.Add("Tipo", typeof(string));
                            dt.Columns.Add("CNPJ", typeof(long));
                            dt.Columns.Add("Placa", typeof(string));
                            dt.Columns.Add("Descrição", typeof(string));
                            dt.Columns.Add("Valor Manutenção", typeof(double));
                            dt.Columns.Add("Data", typeof(DateTime));
                            dt.Columns.Add("Situação", typeof(string));

                            foreach (Manutencao manutencao in manutencoes)
                            {
                                dt.Rows.Add(manutencao.Tipo.ToString(), manutencao.CNPJ, manutencao.Placa, manutencao.Descricao, manutencao.Valor
                                    , manutencao.Data, manutencao.Situacao.ToString());
                            }
                            ListaManutencoes = manutencoes;
                            dgVeiculoManunt.DataSource = dt;
                        }
                        catch (ConcorrenciaBancoException ex)
                        {
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }                     
        }

        private void BtnTrasferirManunt_Click(object sender, EventArgs e)
        {
            if (Manutencao == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                PlacaAntiga = Manutencao.Placa;
                TipoAntigo = Manutencao.Tipo.ToString();
                dataAntiga = Manutencao.Data;

                cbTipo.SelectedItem = Manutencao.Tipo;
                dtDataManunt.Value = Manutencao.Data;
                txtValor.Text = Manutencao.Valor.ToString();
                cbPlaca.SelectedValue = Manutencao.Placa;
                cbServicoExterno.SelectedValue = Manutencao.CNPJ;
                txtDescricao.Text = Manutencao.Descricao;
                cbSituacao.SelectedItem = Manutencao.Situacao;

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlManunt.SelectTab("tbPageCadastroManunt");
                if (tbControlManunt.SelectedTab == tbPageCadastroManunt)
                {
                    dtDataManuntConsulta.Value = DateTime.Now;
                    cbTipoManuntConsulta.Text = "";
                    cbPlacaConsulta.Text = "";
                    Manutencao = null;

                    btnCadastrarManunt.Visible = false;
                    lblCancelar.Visible = true;
                    btnAlterarManunt.Enabled = true;

                    if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                    {
                        btnExcluirManunt.Enabled = false;
                    }
                    else
                    {
                        btnExcluirManunt.Enabled = true;
                    }                    
                }
            }
        }

        private void dgVeiculoManunt_DoubleClick(object sender, EventArgs e)
        {
            if (dgVeiculoManunt.DataSource == null)
            {

            }
            else if (dgVeiculoManunt.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                long cnpj = long.Parse(dgVeiculoManunt.CurrentRow.Cells[1].Value.ToString());
                string placa = dgVeiculoManunt.CurrentRow.Cells[2].Value.ToString();
                string descricao = dgVeiculoManunt.CurrentRow.Cells[3].Value.ToString();
                DateTime data = Convert.ToDateTime(dgVeiculoManunt.CurrentRow.Cells[5].Value);

                foreach (Manutencao manutencao in ListaManutencoes)
                {
                    if (manutencao.Placa == placa && manutencao.CNPJ == cnpj && manutencao.Data == data && manutencao.Descricao == descricao)
                    {
                        PlacaAntiga = manutencao.Placa;
                        TipoAntigo = manutencao.Tipo.ToString();
                        dataAntiga = manutencao.Data;

                        cbTipo.SelectedItem = manutencao.Tipo;
                        dtDataManunt.Value = manutencao.Data;
                        txtValor.Text = manutencao.Valor.ToString();
                        cbPlaca.SelectedValue = manutencao.Placa;
                        cbServicoExterno.SelectedValue = manutencao.CNPJ;
                        txtDescricao.Text = manutencao.Descricao;
                        cbSituacao.SelectedItem = manutencao.Situacao;

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                        tbControlManunt.SelectTab("tbPageCadastroManunt");
                        if (tbControlManunt.SelectedTab == tbPageCadastroManunt)
                        {
                            dtDataManuntConsulta.Value = DateTime.Now;
                            cbTipoManuntConsulta.Text = "";
                            cbPlacaConsulta.Text = "";
                            Manutencao = null;

                            btnCadastrarManunt.Visible = false;
                            lblCancelar.Visible = true;
                            btnAlterarManunt.Enabled = true;

                            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                            {
                                btnExcluirManunt.Enabled = false;
                            }
                            else
                            {
                                btnExcluirManunt.Enabled = true;
                            }
                        }
                    }
                }
                dgVeiculoManunt.DataSource = null;
            }
        }

        private void BtnAlterarManunt_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbServicoExterno.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma oficina antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (txtValor.Text == "" || txtDescricao.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ManutencaoTipo manutencaoTipo = (ManutencaoTipo)Enum.Parse(typeof(ManutencaoTipo), cbTipo.SelectedItem.ToString());
                SituacaoManutencao situacaoManutencao = (SituacaoManutencao)Enum.Parse(typeof(SituacaoManutencao), cbSituacao.SelectedItem.ToString());
                double valor = double.Parse(txtValor.Text);
                string placa = cbPlaca.SelectedValue.ToString();
                long cNPJ = Convert.ToInt64(cbServicoExterno.SelectedValue);

                Manutencao manutencao = new Manutencao(manutencaoTipo, txtDescricao.Text, dtDataManunt.Value, valor, situacaoManutencao, cNPJ, placa);

                try
                {
                    if(PlacaAntiga == "")
                    {
                        PlacaAntiga = manutencao.Placa;
                    }
                    if(dataAntiga == new DateTime(2000,01,01))
                    {
                        dataAntiga = manutencao.Data;
                    }
                    if(TipoAntigo == "")
                    {
                        manutencaoTipo = manutencao.Tipo;
                        TipoAntigo = manutencaoTipo.ToString();
                    }
                    else
                    {
                        manutencaoTipo = (ManutencaoTipo)Enum.Parse(typeof(ManutencaoTipo), TipoAntigo);
                    }

                    if (_manutencaoController.Alterar(manutencao, PlacaAntiga, manutencaoTipo, dataAntiga))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        PlacaAntiga = "";
                        TipoAntigo = "";
                        dataAntiga = new DateTime(2000, 01, 01);
                        cbTipo.SelectedItem = cbTipo.Items[0];
                        dtDataManunt.Value = DateTime.Now;
                        txtValor.Text = "";
                        cbPlaca.SelectedItem = cbPlaca.Items[0];
                        cbServicoExterno.SelectedItem = cbServicoExterno.Items[0];
                        txtDescricao.Text = "";
                        cbSituacao.SelectedItem = cbSituacao.Items[0];

                        btnCadastrarManunt.Visible = true;
                        lblCancelar.Visible = false;
                        btnAlterarManunt.Enabled = false;
                        btnExcluirManunt.Enabled = false;
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

        private void BtnExcluirManunt_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbServicoExterno.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma oficina antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ManutencaoTipo manutencaoTipo = (ManutencaoTipo)Enum.Parse(typeof(ManutencaoTipo), cbTipo.SelectedItem.ToString());
                string placa = cbPlaca.SelectedValue.ToString();
                try
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_manutencaoController.Deletar(placa, manutencaoTipo, dtDataManunt.Value))
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");
                            cbTipo.SelectedItem = cbTipo.Items[0];
                            dtDataManunt.Value = DateTime.Now;
                            txtValor.Text = "";
                            cbPlaca.SelectedItem = cbPlaca.Items[0];
                            cbServicoExterno.SelectedItem = cbServicoExterno.Items[0];
                            txtDescricao.Text = "";
                            cbSituacao.SelectedItem = cbSituacao.Items[0];

                            btnCadastrarManunt.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarManunt.Enabled = false;
                            btnExcluirManunt.Enabled = false;
                        }
                    }
                }
                catch (IntegridadeException ex)
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

            btnCadastrarManunt.BackColor = Properties.Settings.Default.myColor;
            btnConsultarManunt.BackColor = Properties.Settings.Default.myColor;
            btnTodosManunt.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirManunt.BackColor = Properties.Settings.Default.myColor;
            btnAlterarManunt.BackColor = Properties.Settings.Default.myColor;

            btnCadastrarManunt.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarManunt.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodosManunt.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirManunt.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarManunt.ForeColor = Properties.Settings.Default.myColorFonteMenu;

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
                cbTipo.SelectedItem = cbTipo.Items[0];
                dtDataManunt.Value = DateTime.Now;
                txtValor.Text = "";
                cbPlaca.SelectedItem = cbPlaca.Items[0];
                cbServicoExterno.SelectedItem = cbServicoExterno.Items[0];
                txtDescricao.Text = "";
                cbSituacao.SelectedItem = cbSituacao.Items[0];

                btnCadastrarManunt.Visible = true;
                lblCancelar.Visible = false;
                btnAlterarManunt.Enabled = false;
                btnExcluirManunt.Enabled = false;

                Manutencao = null;
            }
        }
    }
}
