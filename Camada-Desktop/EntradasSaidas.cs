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
    public partial class EntradasSaidas : Form
    {
        private readonly EntradaSaidaController _entradaSaidaController;
        private List<EntradaSaida> ListaEntradasSaidas;
        private EntradaSaida EntradaSaida;
        string PlacaAntiga;
        long cnpjAntigo;
        string TipoAntigo;
        DateTime dataAntiga;
        PerfilAcesso PerfilAcesso;

        public EntradasSaidas()
        {
            InitializeComponent();
            _entradaSaidaController = InstanciarCamadas();
            EntradaSaida = null;
            PlacaAntiga = "";
            cnpjAntigo = long.MaxValue;
            TipoAntigo = "";
            dataAntiga = new DateTime(2000, 01, 01);
        }

        public EntradasSaidas(PerfilAcesso perfilAcesso)
        {
            InitializeComponent();
            _entradaSaidaController = InstanciarCamadas();
            EntradaSaida = null;
            PlacaAntiga = "";
            cnpjAntigo = long.MaxValue;
            TipoAntigo = "";
            dataAntiga = new DateTime(2000, 01, 01);
            PerfilAcesso = perfilAcesso;
        }

        private EntradaSaidaController InstanciarCamadas()
        {
            Banco banco = new Banco();
            EntradaSaidaDAL entradaSaidaDAL = new EntradaSaidaDAL(banco);
            EntradaSaidaService entradaSaidaService = new EntradaSaidaService(entradaSaidaDAL);
            return new EntradaSaidaController(entradaSaidaService);
        }

        private void EntradaSaida_Load(object sender, EventArgs e)
        {
            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao.Visible = true;
                toolTipPermissao.SetToolTip(this.pbpermissao, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao.Hide(pbpermissao);
            }

            cbTipo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTipo.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbTipoConsulta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTipoConsulta.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbPlaca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPlaca.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbPlacaConsulta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPlacaConsulta.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbServicoExterno.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbServicoExterno.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbServicoExternoEntradaSaidaConsulta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbServicoExternoEntradaSaidaConsulta.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbCPF.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCPF.AutoCompleteSource = AutoCompleteSource.ListItems;

            toolTipTransfere.SetToolTip(this.btnTrasferirEntradaSaida, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirEntradaSaida);

            cbTipo.DataSource = Enum.GetValues(typeof(EntradaSaidaTipo));
            cbTipoConsulta.DataSource = Enum.GetValues(typeof(EntradaSaidaTipo));

            try
            {
                cbCPF.DataSource = _entradaSaidaController.PopularCPFs();
                cbCPF.DisplayMember = "MOTORISTA";
                cbCPF.ValueMember = "MT_CPF";

            }
            catch (ConcorrenciaBancoException)
            {
                cbCPF.DataSource = null;
            }

            try
            {
                cbPlaca.DataSource = _entradaSaidaController.PopularPlacas();
                cbPlaca.DisplayMember = "MODELO";
                cbPlaca.ValueMember = "VCL_PLACA";

                cbPlacaConsulta.DataSource = _entradaSaidaController.PopularPlacas();
                cbPlacaConsulta.DisplayMember = "MODELO";
                cbPlacaConsulta.ValueMember = "VCL_PLACA";
            }
            catch (ConcorrenciaBancoException)
            {
                cbPlaca.DataSource = null;
            }

            try
            {
                cbServicoExterno.DataSource = _entradaSaidaController.PopularServicosExternos();
                cbServicoExterno.DisplayMember = "SERVEXT_NOME";
                cbServicoExterno.ValueMember = "SERVEXT_CNPJ";

                cbServicoExternoEntradaSaidaConsulta.DataSource = _entradaSaidaController.PopularServicosExternos();
                cbServicoExternoEntradaSaidaConsulta.DisplayMember = "SERVEXT_NOME";
                cbServicoExternoEntradaSaidaConsulta.ValueMember = "SERVEXT_CNPJ";
            }
            catch (ConcorrenciaBancoException)
            {
                cbServicoExterno.DataSource = null;
            }

            AtualizarCor();
        }

        private void BtnCadastrarEntradaSaida_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbServicoExterno.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma garagem / estacionamento antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbCPF.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                EntradaSaidaTipo entradaSaidaTipo = (EntradaSaidaTipo)Enum.Parse(typeof(EntradaSaidaTipo), cbTipo.SelectedItem.ToString());
                string cpf = cbCPF.SelectedValue.ToString();
                string placa = cbPlaca.SelectedValue.ToString();
                long cNPJ = Convert.ToInt64(cbServicoExterno.SelectedValue);
                DateTime dthora = new DateTime(dtDataHora.Value.Year, dtDataHora.Value.Month, dtDataHora.Value.Day, dtDataHora.Value.Hour, dtDataHora.Value.Minute, 0);

                EntradaSaida entradaSaida = new EntradaSaida(entradaSaidaTipo, dthora, cpf, placa, cNPJ);

                try
                {
                    if (_entradaSaidaController.Cadastrar(entradaSaida, entradaSaida.Placa, entradaSaida.CNPJ, entradaSaida.Tipo, entradaSaida.DataHora))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");
                        cbTipo.Text = "";
                        dtDataHora.Value = DateTime.Now;
                        cbPlaca.Text = "";
                        cbServicoExterno.Text = "";
                        cbCPF.Text = "";
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

        private void BtnConsultarEntradaSaida_Click(object sender, EventArgs e)
        {
            if (cbPlacaConsulta.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbServicoExterno.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma garagem / estacionamento antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    EntradaSaidaTipo entradaSaidaTipo = (EntradaSaidaTipo)Enum.Parse(typeof(EntradaSaidaTipo), cbTipoConsulta.SelectedItem.ToString());
                    string placa = cbPlacaConsulta.SelectedValue.ToString();
                    long cNPJ = long.Parse(cbServicoExternoEntradaSaidaConsulta.SelectedValue.ToString());
                    DateTime dthora = new DateTime(dtDataHoraEntradaSaidaConsulta.Value.Year, dtDataHoraEntradaSaidaConsulta.Value.Month,
                        dtDataHoraEntradaSaidaConsulta.Value.Day, dtDataHoraEntradaSaidaConsulta.Value.Hour, dtDataHoraEntradaSaidaConsulta.Value.Minute, 0);

                    EntradaSaida entradaSaida = _entradaSaidaController.BuscarEntradaSaida(placa, cNPJ, entradaSaidaTipo, dthora);
                    if (entradaSaida == null)
                    {
                        dgEntradaSaidaConsulta.DataSource = null;
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Tipo", typeof(string));
                        dt.Columns.Add("Placa", typeof(string));
                        dt.Columns.Add("CNPJ", typeof(long));
                        dt.Columns.Add("CPF", typeof(string));
                        dt.Columns.Add("Data/Hora", typeof(DateTime));


                        dt.Rows.Add(entradaSaida.Tipo.ToString(), entradaSaida.Placa, entradaSaida.CNPJ, entradaSaida.CPF, entradaSaida.DataHora);
                        dgEntradaSaidaConsulta.DataSource = dt;

                        EntradaSaida = entradaSaida;
                        ListaEntradasSaidas = new List<EntradaSaida>();
                        ListaEntradasSaidas.Add(entradaSaida);
                        entradaSaida = null;
                    }

                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void BtnTodosEntradaSaida_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Cadastre uma garagem / estacionamento antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {
                            List<EntradaSaida> entradasSaidas = _entradaSaidaController.BuscarTodos(dtInicioConsulta.Value, dtFimConsulta.Value);

                            DataTable dt = new DataTable();
                            dt.Columns.Add("Tipo", typeof(string));
                            dt.Columns.Add("Placa", typeof(string));
                            dt.Columns.Add("CNPJ", typeof(long));
                            dt.Columns.Add("CPF", typeof(string));
                            dt.Columns.Add("Data/Hora", typeof(DateTime));

                            foreach (EntradaSaida entradaSaida in entradasSaidas)
                            {
                                dt.Rows.Add(entradaSaida.Tipo.ToString(), entradaSaida.Placa, entradaSaida.CNPJ, entradaSaida.CPF, entradaSaida.DataHora);
                            }
                            ListaEntradasSaidas = entradasSaidas;
                            dgEntradaSaidaConsulta.DataSource = dt;
                        }
                        catch (ConcorrenciaBancoException ex)
                        {
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }                    
        }

        private void BtnTrasferirEntradaSaida_Click(object sender, EventArgs e)
        {
            if (EntradaSaida == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                PlacaAntiga = EntradaSaida.Placa;
                cnpjAntigo = EntradaSaida.CNPJ;
                TipoAntigo = EntradaSaida.Tipo.ToString();
                dataAntiga = EntradaSaida.DataHora;


                cbTipo.SelectedItem = EntradaSaida.Tipo;
                dtDataHora.Value = EntradaSaida.DataHora;
                cbPlaca.SelectedValue = EntradaSaida.Placa;
                cbServicoExterno.SelectedValue = EntradaSaida.CNPJ;
                cbCPF.SelectedValue = EntradaSaida.CPF;

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlEntradaSaida.SelectTab("tbPageCadastroEntradaSaida");
                if (tbControlEntradaSaida.SelectedTab == tbPageCadastroEntradaSaida)
                {
                    dtDataHoraEntradaSaidaConsulta.Value = DateTime.Now;
                    EntradaSaida = null;
                    cbTipoConsulta.Text = "";
                    cbServicoExternoEntradaSaidaConsulta.Text = "";
                    cbPlacaConsulta.Text = "";
                    dtDataHoraEntradaSaidaConsulta.Value = DateTime.Now;

                    btnAlterarEntradaSaida.Enabled = true;
                    btnExcluirEntradaSaida.Enabled = true;
                    btnCadastrarEntradaSaida.Visible = false;
                    lblCancelar.Visible = true;
                }
            }
        }

        private void dgEntradaSaidaConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgEntradaSaidaConsulta.DataSource == null)
            {

            }
            else if (dgEntradaSaidaConsulta.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                string tipo = dgEntradaSaidaConsulta.CurrentRow.Cells[0].Value.ToString();
                string placa = dgEntradaSaidaConsulta.CurrentRow.Cells[1].Value.ToString();
                long cnpj = long.Parse(dgEntradaSaidaConsulta.CurrentRow.Cells[2].Value.ToString());
                DateTime dataHora = Convert.ToDateTime(dgEntradaSaidaConsulta.CurrentRow.Cells[4].Value);

                foreach (EntradaSaida entradaSaida in ListaEntradasSaidas)
                {
                    if (entradaSaida.Placa == placa && entradaSaida.CNPJ == cnpj && entradaSaida.DataHora == dataHora && entradaSaida.Tipo.ToString() == tipo)
                    {
                        PlacaAntiga = entradaSaida.Placa;
                        cnpjAntigo = entradaSaida.CNPJ;
                        TipoAntigo = entradaSaida.Tipo.ToString();
                        dataAntiga = entradaSaida.DataHora;


                        cbTipo.SelectedItem = entradaSaida.Tipo;
                        dtDataHora.Value = entradaSaida.DataHora;
                        cbPlaca.SelectedValue = entradaSaida.Placa;
                        cbServicoExterno.SelectedValue = entradaSaida.CNPJ;
                        cbCPF.SelectedValue = entradaSaida.CPF;

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                        tbControlEntradaSaida.SelectTab("tbPageCadastroEntradaSaida");
                        if (tbControlEntradaSaida.SelectedTab == tbPageCadastroEntradaSaida)
                        {
                            dtDataHoraEntradaSaidaConsulta.Value = DateTime.Now;
                            EntradaSaida = null;
                            cbTipoConsulta.Text = "";
                            cbServicoExternoEntradaSaidaConsulta.Text = "";
                            cbPlacaConsulta.Text = "";
                            dtDataHoraEntradaSaidaConsulta.Value = DateTime.Now;

                            btnAlterarEntradaSaida.Enabled = true;                           
                            btnCadastrarEntradaSaida.Visible = false;
                            lblCancelar.Visible = true;

                            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                            {
                                btnExcluirEntradaSaida.Enabled = false;
                            }
                            else
                            {
                                btnExcluirEntradaSaida.Enabled = true;
                            }
                        }
                    }
                }
                dgEntradaSaidaConsulta.DataSource = null;
            }
        }

        private void BtnAlterarEntradaSaida_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbServicoExterno.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma garagem / estacionamento antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbCPF.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                EntradaSaidaTipo entradaSaidaTipo = (EntradaSaidaTipo)Enum.Parse(typeof(EntradaSaidaTipo), cbTipo.SelectedItem.ToString());
                string cpf = cbCPF.SelectedValue.ToString();
                string placa = cbPlaca.SelectedValue.ToString();
                long cNPJ = Convert.ToInt64(cbServicoExterno.SelectedValue);
                DateTime dthora = new DateTime(dtDataHora.Value.Year, dtDataHora.Value.Month, dtDataHora.Value.Day, dtDataHora.Value.Hour, dtDataHora.Value.Minute, 0);

                EntradaSaida entradaSaida = new EntradaSaida(entradaSaidaTipo, dthora, cpf, placa, cNPJ);

                try
                {
                    if (cnpjAntigo == long.MaxValue)
                    {
                        cnpjAntigo = entradaSaida.CNPJ;
                    }
                    if (PlacaAntiga == "")
                    {
                        PlacaAntiga = entradaSaida.Placa;
                    }
                    if (dataAntiga == new DateTime(2000, 01, 01))
                    {
                        dataAntiga = dthora;
                    }
                    if (TipoAntigo == "")
                    {
                        entradaSaidaTipo = entradaSaida.Tipo;
                        TipoAntigo = entradaSaidaTipo.ToString();
                    }
                    else
                    {
                        entradaSaidaTipo = (EntradaSaidaTipo)Enum.Parse(typeof(EntradaSaidaTipo), TipoAntigo);
                    }

                    if (_entradaSaidaController.Alterar(entradaSaida, PlacaAntiga, cnpjAntigo, entradaSaidaTipo, dataAntiga))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        PlacaAntiga = "";
                        TipoAntigo = "";
                        dataAntiga = new DateTime(2000, 01, 01);
                        cbTipo.SelectedItem = cbTipo.Items[0];
                        dtDataHora.Value = DateTime.Now;
                        cbPlaca.SelectedItem = cbPlaca.Items[0];
                        cbServicoExterno.SelectedItem = cbServicoExterno.Items[0];
                        cbCPF.SelectedItem = cbCPF.Items[0];

                        btnAlterarEntradaSaida.Enabled = false;
                        btnCadastrarEntradaSaida.Visible = true;
                        lblCancelar.Visible = false;

                        if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                        {
                            btnExcluirEntradaSaida.Enabled = false;
                        }
                        else
                        {
                            btnExcluirEntradaSaida.Enabled = true;
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

        private void BtnExcluirEntradaSaida_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbServicoExterno.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma garagem / estacionamento antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbCPF.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                EntradaSaidaTipo entradaSaidaTipo = (EntradaSaidaTipo)Enum.Parse(typeof(EntradaSaidaTipo), cbTipo.SelectedItem.ToString());
                string cpf = cbCPF.SelectedValue.ToString();
                string placa = cbPlaca.SelectedValue.ToString();
                long cNPJ = Convert.ToInt64(cbServicoExterno.SelectedValue);
                DateTime dthora = new DateTime(dtDataHora.Value.Year, dtDataHora.Value.Month, dtDataHora.Value.Day, dtDataHora.Value.Hour, dtDataHora.Value.Minute, 0);

                try
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_entradaSaidaController.Deletar(placa, cNPJ, entradaSaidaTipo, dthora))
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");
                            cbTipo.SelectedItem = cbTipo.Items[0];
                            dtDataHora.Value = DateTime.Now;
                            cbPlaca.SelectedItem = cbPlaca.Items[0];
                            cbServicoExterno.SelectedItem = cbServicoExterno.Items[0];
                            cbCPF.SelectedItem = cbCPF.Items[0];

                            btnAlterarEntradaSaida.Enabled = false;
                            btnExcluirEntradaSaida.Enabled = false;
                            btnCadastrarEntradaSaida.Visible = true;
                            lblCancelar.Visible = false;
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

            btnCadastrarEntradaSaida.BackColor = Properties.Settings.Default.myColor;
            btnConsultarEntradaSaida.BackColor = Properties.Settings.Default.myColor;
            btnTodosEntradaSaida.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirEntradaSaida.BackColor = Properties.Settings.Default.myColor;
            btnAlterarEntradaSaida.BackColor = Properties.Settings.Default.myColor;
            panelConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            btnConsultarPorData.BackColor = Properties.Settings.Default.myColor;

            btnCadastrarEntradaSaida.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarEntradaSaida.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodosEntradaSaida.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirEntradaSaida.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarEntradaSaida.ForeColor = Properties.Settings.Default.myColorFonteMenu;
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
                dtDataHora.Value = DateTime.Now;
                cbPlaca.SelectedItem = cbPlaca.Items[0];
                cbServicoExterno.SelectedItem = cbServicoExterno.Items[0];
                cbCPF.SelectedItem = cbCPF.Items[0];

                btnAlterarEntradaSaida.Enabled = false;
                btnExcluirEntradaSaida.Enabled = false;
                btnCadastrarEntradaSaida.Visible = true;
                lblCancelar.Visible = false;

                EntradaSaida = null;
            }
        }
    }
}
