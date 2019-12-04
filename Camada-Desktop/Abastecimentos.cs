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
    public partial class Abastecimentos : Form
    {
        private readonly AbastecimentoController _abastecimentoController;
        private List<Abastecimento> ListaAbastecimentos;
        private Abastecimento Abastecimento;
        string PlacaAntiga;
        string TipoAntigo;
        DateTime dataAntiga;
        PerfilAcesso PerfilAcesso;

        public Abastecimentos()
        {
            InitializeComponent();
            _abastecimentoController = InstanciarCamadas();
            Abastecimento = null;
            PlacaAntiga = "";
            TipoAntigo = "";
            dataAntiga = new DateTime(2000, 01, 01);
        }

        public Abastecimentos(PerfilAcesso perfilAcesso)
        {
            InitializeComponent();
            _abastecimentoController = InstanciarCamadas();
            Abastecimento = null;
            PlacaAntiga = "";
            TipoAntigo = "";
            dataAntiga = new DateTime(2000, 01, 01);
            PerfilAcesso = perfilAcesso;

        }

        private AbastecimentoController InstanciarCamadas()
        {
            Banco banco = new Banco();
            AbastecimentoDAL abastecimentoDAL = new AbastecimentoDAL(banco);
            VeiculoDAL veiculoDAL = new VeiculoDAL(banco);
            AbastecimentoService abastecimentoService = new AbastecimentoService(abastecimentoDAL, veiculoDAL);
            return new AbastecimentoController(abastecimentoService);
        }

        private void Abastecimento_Load(object sender, EventArgs e)
        {
            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao.Visible = true;
                toolTipPermissao.SetToolTip(this.pbpermissao, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao.Hide(pbpermissao);
            }

            cbTipo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTipo.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbTipoAbastConsulta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTipoAbastConsulta.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbPlaca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPlaca.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbServicoExterno.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbServicoExterno.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbPlacaAbastConsulta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPlacaAbastConsulta.AutoCompleteSource = AutoCompleteSource.ListItems;

            toolTipTransfere.SetToolTip(this.btnTrasferirAbast, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirAbast);

            cbTipo.DataSource = Enum.GetValues(typeof(AbastecimentoTipo));
            cbTipoAbastConsulta.DataSource = Enum.GetValues(typeof(AbastecimentoTipo));

            try
            {
                cbPlaca.DataSource = _abastecimentoController.PopularPlacas();
                cbPlaca.DisplayMember = "MODELO";
                cbPlaca.ValueMember = "VCL_PLACA";

                cbPlacaAbastConsulta.DataSource = _abastecimentoController.PopularPlacas();
                cbPlacaAbastConsulta.DisplayMember = "MODELO";
                cbPlacaAbastConsulta.ValueMember = "VCL_PLACA";
            }
            catch (ConcorrenciaBancoException)
            {
                cbPlaca.DataSource = null;
            }
            try
            {
                cbServicoExterno.DataSource = _abastecimentoController.PopularServicosExternos();
                cbServicoExterno.DisplayMember = "SERVEXT_NOME";
                cbServicoExterno.ValueMember = "SERVEXT_CNPJ";
            }
            catch (ConcorrenciaBancoException)
            {
                cbServicoExterno.DataSource = null;
            }

            AtualizarCor();
        }

        private void BtnCadastrarAbast_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbServicoExterno.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma oficina antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtValor.Text == "" || txtQuantidadeLitros.Text == "   .  ")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AbastecimentoTipo abastecimentoTipo = (AbastecimentoTipo)Enum.Parse(typeof(AbastecimentoTipo), cbTipo.SelectedItem.ToString());
                double valor = double.Parse(txtValor.Text);
                double quantidadeLitros = double.Parse(txtQuantidadeLitros.Text);
                string placa = cbPlaca.SelectedValue.ToString();
                long cNPJ = Convert.ToInt64(cbServicoExterno.SelectedValue);
                Abastecimento abastecimento = new Abastecimento(abastecimentoTipo, valor, quantidadeLitros, dtDataAbast.Value, placa, cNPJ);

                try
                {
                    if (_abastecimentoController.Cadastrar(abastecimento, abastecimento.Placa, abastecimento.Tipo, abastecimento.Data))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");

                        cbTipo.Text = "";
                        dtDataAbast.Value = DateTime.Now;
                        txtValor.Text = "";
                        txtQuantidadeLitros.Text = "";
                        cbPlaca.Text = "";
                        cbServicoExterno.Text = "";
                    }
                }
                catch (RegistroExisteException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (TipoCombustivelException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnConsultarAbast_Click(object sender, EventArgs e)
        {
            if (cbPlacaAbastConsulta.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    AbastecimentoTipo abastecimentoTipo = (AbastecimentoTipo)Enum.Parse(typeof(AbastecimentoTipo), cbTipoAbastConsulta.SelectedItem.ToString());
                    string placa = cbPlacaAbastConsulta.SelectedValue.ToString();

                    Abastecimento abastecimento = _abastecimentoController.BuscarAbastecimento(placa, abastecimentoTipo, dtDataAbastConsulta.Value);
                    if (abastecimento == null)
                    {
                        dgVeiculoAbast.DataSource = null;
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Placa", typeof(string));
                        dt.Columns.Add("CNPJ", typeof(long));
                        dt.Columns.Add("Tipo Combustível", typeof(string));
                        dt.Columns.Add("Quantidade (Litros)", typeof(double));
                        dt.Columns.Add("Valor (Total)", typeof(double));
                        dt.Columns.Add("Data", typeof(DateTime));



                        dt.Rows.Add(abastecimento.Placa, abastecimento.CNPJ, abastecimento.Tipo.ToString(), abastecimento.Litros, abastecimento.Valor
                            , abastecimento.Data);
                        dgVeiculoAbast.DataSource = dt;

                        Abastecimento = abastecimento;
                        ListaAbastecimentos = new List<Abastecimento>();
                        ListaAbastecimentos.Add(abastecimento);
                        abastecimento = null;
                    }
                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void BtnTodosAbast_Click(object sender, EventArgs e)
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
                    if (cbPlacaAbastConsulta.Items.Count < 1)
                    {
                        MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {
                            List<Abastecimento> abastecimentos = _abastecimentoController.BuscarTodos(dtInicioConsulta.Value, dtFimConsulta.Value);

                            DataTable dt = new DataTable();
                            dt.Columns.Add("Placa", typeof(string));
                            dt.Columns.Add("CNPJ", typeof(long));
                            dt.Columns.Add("Tipo Combustível", typeof(string));
                            dt.Columns.Add("Quantidade (Litros)", typeof(double));
                            dt.Columns.Add("Valor (Total)", typeof(double));
                            dt.Columns.Add("Data", typeof(DateTime));

                            foreach (Abastecimento abastecimento in abastecimentos)
                            {
                                dt.Rows.Add(abastecimento.Placa, abastecimento.CNPJ, abastecimento.Tipo.ToString(), abastecimento.Litros, abastecimento.Valor
                                                            , abastecimento.Data);
                            }
                            ListaAbastecimentos = abastecimentos;
                            dgVeiculoAbast.DataSource = dt;
                        }
                        catch (ConcorrenciaBancoException ex)
                        {
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                }
            }          
        }

        private void BtnTrasferirAbast_Click(object sender, EventArgs e)
        {
            if (Abastecimento == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                PlacaAntiga = Abastecimento.Placa;
                TipoAntigo = Abastecimento.Tipo.ToString();
                dataAntiga = Abastecimento.Data;

                cbTipo.SelectedItem = Abastecimento.Tipo;
                dtDataAbast.Value = Abastecimento.Data;
                txtQuantidadeLitros.Text = Abastecimento.Litros.ToString();
                txtValor.Text = Abastecimento.Valor.ToString();
                cbPlaca.SelectedValue = Abastecimento.Placa;
                cbServicoExterno.SelectedValue = Abastecimento.CNPJ;

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlAbast.SelectTab("tbPageCadastroAbast");
                if (tbControlAbast.SelectedTab == tbPageCadastroAbast)
                {
                    dtDataAbastConsulta.Value = DateTime.Now;
                    Abastecimento = null;

                    cbTipoAbastConsulta.Text = "";
                    cbPlacaAbastConsulta.Text = "";
                    dtDataAbastConsulta.Value = DateTime.Now;

                    btnCadastrarAbast.Visible = false;
                    lblCancelar.Visible = true;
                    btnAlterarAbast.Enabled = true;

                    if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                    {
                        btnExcluirAbast.Enabled = false;
                    }
                    else
                    {
                        btnExcluirAbast.Enabled = true;
                    }
                    
                }
            }
        }

        private void dgVeiculoAbast_DoubleClick(object sender, EventArgs e)
        {
            if (dgVeiculoAbast.DataSource == null)
            {

            }
            else if (dgVeiculoAbast.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                string placa = dgVeiculoAbast.CurrentRow.Cells[0].Value.ToString();
                long cnpj = long.Parse(dgVeiculoAbast.CurrentRow.Cells[1].Value.ToString());
                DateTime data = Convert.ToDateTime(dgVeiculoAbast.CurrentRow.Cells[5].Value);

                foreach (Abastecimento abastecimento in ListaAbastecimentos)
                {
                    if (abastecimento.Placa == placa && abastecimento.CNPJ == cnpj && abastecimento.Data == data)
                    {
                        PlacaAntiga = abastecimento.Placa;
                        TipoAntigo = abastecimento.Tipo.ToString();
                        dataAntiga = abastecimento.Data;

                        cbTipo.SelectedItem = abastecimento.Tipo;
                        dtDataAbast.Value = abastecimento.Data;
                        txtQuantidadeLitros.Text = abastecimento.Litros.ToString();
                        txtValor.Text = abastecimento.Valor.ToString();
                        cbPlaca.SelectedValue = abastecimento.Placa;
                        cbServicoExterno.SelectedValue = abastecimento.CNPJ;

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                        tbControlAbast.SelectTab("tbPageCadastroAbast");
                        if (tbControlAbast.SelectedTab == tbPageCadastroAbast)
                        {
                            dtDataAbastConsulta.Value = DateTime.Now;
                            Abastecimento = null;

                            cbTipoAbastConsulta.Text = "";
                            cbPlacaAbastConsulta.Text = "";
                            dtDataAbastConsulta.Value = DateTime.Now;

                            btnCadastrarAbast.Visible = false;
                            lblCancelar.Visible = true;
                            btnAlterarAbast.Enabled = true;

                            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                            {
                                btnExcluirAbast.Enabled = false;
                            }
                            else
                            {
                                btnExcluirAbast.Enabled = true;
                            }
                        }
                    }
                }
                dgVeiculoAbast.DataSource = null;
            }
        }

        private void BtnAlterarAbast_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbServicoExterno.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma oficina antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (txtValor.Text == "" || txtQuantidadeLitros.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AbastecimentoTipo abastecimentoTipo = (AbastecimentoTipo)Enum.Parse(typeof(AbastecimentoTipo), cbTipo.SelectedItem.ToString());
                double valor = double.Parse(txtValor.Text);
                double quantidadeLitros = double.Parse(txtQuantidadeLitros.Text);
                string placa = cbPlaca.SelectedValue.ToString();
                long cNPJ = Convert.ToInt64(cbServicoExterno.SelectedValue);
                Abastecimento abastecimento = new Abastecimento(abastecimentoTipo, valor, quantidadeLitros, dtDataAbast.Value, placa, cNPJ);

                try
                {
                    if (PlacaAntiga == "")
                    {
                        PlacaAntiga = abastecimento.Placa;
                    }
                    if (dataAntiga == new DateTime(2000, 01, 01))
                    {
                        dataAntiga = abastecimento.Data;
                    }
                    if (TipoAntigo == "")
                    {
                        abastecimentoTipo = abastecimento.Tipo;
                        TipoAntigo = abastecimentoTipo.ToString();
                    }
                    else
                    {
                        abastecimentoTipo = (AbastecimentoTipo)Enum.Parse(typeof(AbastecimentoTipo), TipoAntigo);
                    }

                    if (_abastecimentoController.Alterar(abastecimento, PlacaAntiga, abastecimentoTipo, dataAntiga))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        PlacaAntiga = "";
                        TipoAntigo = "";
                        dataAntiga = new DateTime(2000, 01, 01);

                        cbTipo.SelectedItem = cbTipo.Items[0];
                        dtDataAbast.Value = DateTime.Now;
                        txtValor.Text = "";
                        txtQuantidadeLitros.Text = "";
                        cbPlaca.SelectedItem = cbPlaca.Items[0];
                        cbServicoExterno.SelectedItem = cbServicoExterno.Items[0];

                        btnCadastrarAbast.Visible = true;
                        lblCancelar.Visible = false;
                        btnAlterarAbast.Enabled = false;
                        btnExcluirAbast.Enabled = false;
                    }
                }
                catch (NaoEncontradoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (TipoCombustivelException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnExcluirAbast_Click(object sender, EventArgs e)
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
                AbastecimentoTipo abastecimentoTipo = (AbastecimentoTipo)Enum.Parse(typeof(AbastecimentoTipo), cbTipo.SelectedItem.ToString());
                string placa = cbPlaca.SelectedValue.ToString();
                try
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_abastecimentoController.Deletar(placa, abastecimentoTipo, dtDataAbast.Value))
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");

                            cbTipo.SelectedItem = cbTipo.Items[0];
                            dtDataAbast.Value = DateTime.Now;
                            txtValor.Text = "";
                            txtQuantidadeLitros.Text = "";
                            cbPlaca.SelectedItem = cbPlaca.Items[0];
                            cbServicoExterno.SelectedItem = cbServicoExterno.Items[0];

                            btnCadastrarAbast.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarAbast.Enabled = false;
                            btnExcluirAbast.Enabled = false;
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

            btnCadastrarAbast.BackColor = Properties.Settings.Default.myColor;
            btnConsultarAbast.BackColor = Properties.Settings.Default.myColor;
            btnTodosAbast.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirAbast.BackColor = Properties.Settings.Default.myColor;
            btnAlterarAbast.BackColor = Properties.Settings.Default.myColor;

            panelConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            btnConsultarPorData.BackColor = Properties.Settings.Default.myColor;

            btnCadastrarAbast.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarAbast.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodosAbast.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirAbast.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarAbast.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            btnConsultarPorData.ForeColor = Properties.Settings.Default.myColorFonteMenu;
        }

        private void panelConsultarPorData_MouseLeave(object sender, EventArgs e)
        {
            panelConsultarPorData.Visible = false;  
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Deseja realmente cancelar manipulação de dados?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cbTipo.SelectedItem = cbTipo.Items[0];
                    dtDataAbast.Value = DateTime.Now;
                    txtValor.Text = "";
                    txtQuantidadeLitros.Text = "";
                    cbPlaca.SelectedItem = cbPlaca.Items[0];
                    cbServicoExterno.SelectedItem = cbServicoExterno.Items[0];

                    btnCadastrarAbast.Visible = true;
                    lblCancelar.Visible = false;
                    btnAlterarAbast.Enabled = false;
                    btnExcluirAbast.Enabled = false;

                    Abastecimento = null;
                }
            }
        }
    }
}
