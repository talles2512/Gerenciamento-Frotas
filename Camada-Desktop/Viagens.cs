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
    public partial class Viagens : Form
    {
        private readonly ViagemController _viagemController;
        private readonly OcupanteController _ocupanteController;
        private List<Viagem> ListaViagens;
        private Viagem Viagem;
        List<Ocupante> ocupantes = new List<Ocupante>();
        int RequisicaoAntiga;
        PerfilAcesso PerfilAcesso;

        public Viagens()
        {
            InitializeComponent();
            _viagemController = InstanciarCamadas();
            _ocupanteController = InstaciarCamadasOcupantes();
            Viagem = null;
            RequisicaoAntiga = int.MaxValue;
        }

        public Viagens(PerfilAcesso perfilAcesso)
        {
            InitializeComponent();
            _viagemController = InstanciarCamadas();
            _ocupanteController = InstaciarCamadasOcupantes();
            Viagem = null;
            RequisicaoAntiga = int.MaxValue;
            PerfilAcesso = perfilAcesso;
        }

        private ViagemController InstanciarCamadas()
        {
            Banco banco = new Banco();
            ViagemDAL viagemDAL = new ViagemDAL(banco);
            OcupanteDAL ocupanteDAL = new OcupanteDAL(banco);
            ViagemService viagemService = new ViagemService(viagemDAL, ocupanteDAL);
            return new ViagemController(viagemService);
        }

        private OcupanteController InstaciarCamadasOcupantes()
        {
            Banco banco = new Banco();
            OcupanteDAL ocupanteDAL = new OcupanteDAL(banco);
            OcupanteService ocupanteService = new OcupanteService(ocupanteDAL);
            return new OcupanteController(ocupanteService);
        }

        private void rdOcupante_CheckedChanged_1(object sender, EventArgs e)
        {
            gbOcupante.Enabled = true;
        }

        private void rdsemOcupante_CheckedChanged_1(object sender, EventArgs e)
        {
            gbOcupante.Enabled = false;
        }

        private void Viagens_Load(object sender, EventArgs e)
        {
            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao.Visible = true;
                toolTipPermissao.SetToolTip(this.pbpermissao, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao.Hide(pbpermissao);
            }

            cbPlaca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPlaca.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbCPF.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCPF.AutoCompleteSource = AutoCompleteSource.ListItems;

            tooltipPesquisar.SetToolTip(lbPesquisar, "Pesquise pelo Nome ou CPF do Motorista." +
                                        " \nMarca, Placa ou Modelo do Veículo." +
                                        " \nEndereço ou Número da Requisção da Viagem.");
            tooltipPesquisar.Hide(lbPesquisar);
            toolTipTransfere.SetToolTip(this.btnTrasferirViagens, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirViagens);

            try
            {
                cbCPF.DataSource = _viagemController.PopularCPFs();
                cbCPF.DisplayMember = "MOTORISTA";
                cbCPF.ValueMember = "MT_CPF";

                cbPlaca.DataSource = _viagemController.PopularPlacas();
                cbPlaca.DisplayMember = "MODELO";
                cbPlaca.ValueMember = "VCL_PLACA";

            }
            catch (ConcorrenciaBancoException)
            {
                cbCPF.DataSource = null;
                cbPlaca.DataSource = null;
            }

            AtualizarCor();
        }

        private void BtnAddOcupante_Click(object sender, EventArgs e)
        {
            if (txtNomeOcupante.Text == "" || txtCPFOcupante.Text.Length < 11 || txtCPFOcupante.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPFOcupante.Text;

                foreach (string str in strings)
                {
                    cpf = cpf.Replace(str, "");
                }

                int requisicao;

                if (RequisicaoAntiga != int.MaxValue)
                {
                    requisicao = RequisicaoAntiga;
                }
                else
                {
                    requisicao = _viagemController.PopularRequisicao();
                }

                Ocupante ocupante = new Ocupante(txtNomeOcupante.Text, long.Parse(cpf), requisicao);
                listboxOcupantes.Items.Add(ocupante.Nome);
                ocupantes.Add(ocupante);

                txtNomeOcupante.Text = "";
                txtCPFOcupante.Text = "";
            }
        }

        private void BtnRemoverOcupante_Click(object sender, EventArgs e)
        {
            if (listboxOcupantes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um ocupante!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (Ocupante ocupante in ocupantes)
                {
                    if (ocupante.Nome == listboxOcupantes.SelectedItem.ToString())
                    {
                        listboxOcupantes.Items.Remove(ocupante.Nome);
                        ocupantes.Remove(ocupante);
                        break;
                    }
                }

                btnRemoverOcupante.Enabled = false;
            }
        }

        private void ListboxOcupantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverOcupante.Enabled = true;
        }

        private void btnCadastrarViagens_Click_1(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rdOcupante.Checked && !ocupantes.Any())
            {
                MessageBox.Show("Cadastre ao menos um ocupante!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbCPF.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string cpf = cbCPF.SelectedValue.ToString();
                string placa = cbPlaca.SelectedValue.ToString();

                bool ocupante = false;

                if (rdOcupante.Checked)
                {
                    ocupante = true;
                }

                try
                {
                    int requisicao;

                    if (RequisicaoAntiga != int.MaxValue)
                    {
                        requisicao = RequisicaoAntiga;
                    }
                    else
                    {
                        requisicao = _viagemController.PopularRequisicao();
                    }

                    Viagem viagem = new Viagem(requisicao, ocupante, txtDestino.Text, dtDataSaida.Value, placa, cpf);
                    viagem.Ocupantes = ocupantes;
                    if (_viagemController.Cadastrar(viagem, requisicao))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");
                        txtDestino.Text = "";
                        dtDataSaida.Value = DateTime.Now;
                        cbPlaca.Text = "";
                        cbCPF.Text = "";
                        rdOcupante.Checked = false;
                        rdsemOcupante.Checked = false;
                        txtNomeOcupante.Text = "";
                        txtCPFOcupante.Text = "";
                        listboxOcupantes.DataSource = null;
                        listboxOcupantes.Items.Clear();

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

        

        private void BtnConsultarViagens_Click(object sender, EventArgs e)
        {
            if (txtRequisicaoConsulta.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int requisicao = int.Parse(txtRequisicaoConsulta.Text);
                try
                {
                    Viagem viagem = _viagemController.BuscarViagem(requisicao);
                    if (viagem == null)
                    {
                        dgViagensConsulta.DataSource = null;
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Código Requisição", typeof(string));
                        dt.Columns.Add("Veículo - Placa", typeof(string));
                        dt.Columns.Add("Motorista - CPF", typeof(string));
                        dt.Columns.Add("Ocupantes", typeof(string));
                        dt.Columns.Add("Destino", typeof(string));
                        dt.Columns.Add("Data/Hora Saída", typeof(DateTime));

                        string existeOcupantes = null;

                        if (viagem.Ocupante)
                        {
                            existeOcupantes = "Sim";
                        }
                        else
                        {
                            existeOcupantes = "Não";
                        }
                        dt.Rows.Add(viagem.Requisicao, viagem.Placa, viagem.CPF, existeOcupantes, viagem.Destino, viagem.DataSaida);
                        dgViagensConsulta.DataSource = dt;

                        Viagem = viagem;
                        ListaViagens = new List<Viagem>();
                        ListaViagens.Add(viagem);
                        viagem = null;
                    }

                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void BtnTodasViagens_Click(object sender, EventArgs e)
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
                        List<Viagem> viagens = _viagemController.BuscarTodos(dtInicioConsulta.Value, dtFimConsulta.Value);
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Código Requisição", typeof(string));
                        dt.Columns.Add("Veículo - Placa", typeof(string));
                        dt.Columns.Add("Motorista - CPF", typeof(string));
                        dt.Columns.Add("Ocupantes", typeof(string));
                        dt.Columns.Add("Destino", typeof(string));
                        dt.Columns.Add("Data/Hora Saída", typeof(DateTime));

                        foreach (Viagem viagem in viagens)
                        {
                            string existeOcupantes = null;

                            if (viagem.Ocupante)
                            {
                                existeOcupantes = "Sim";
                            }
                            else
                            {
                                existeOcupantes = "Não";
                            }
                            dt.Rows.Add(viagem.Requisicao, viagem.Placa, viagem.CPF, existeOcupantes, viagem.Destino, viagem.DataSaida);

                        }
                        dgViagensConsulta.DataSource = dt;
                    }
                    catch (ConcorrenciaBancoException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }         
        }

        private void BtnTrasferirViagens_Click(object sender, EventArgs e)
        {
            if (Viagem == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                listboxOcupantes.Items.Clear();
                ocupantes.Clear();

                RequisicaoAntiga = Viagem.Requisicao;

                txtDestino.Text = Viagem.Destino;
                dtDataSaida.Value = Viagem.DataSaida;
                cbPlaca.SelectedValue = Viagem.Placa;
                cbCPF.SelectedValue = Viagem.CPF;

                if (Viagem.Ocupante)
                {
                    rdOcupante.Checked = true;
                    ocupantes = Viagem.Ocupantes;

                    foreach(Ocupante ocupante in ocupantes)
                    {
                        listboxOcupantes.Items.Add(ocupante.Nome);
                    }
                }
                else
                {
                    rdsemOcupante.Checked = true;
                }

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlViagens.SelectTab("tbPageCadastroViagem");
                if (tbControlViagens.SelectedTab == tbPageCadastroViagem)
                {
                    Viagem = null;
                    txtRequisicaoConsulta.Text = "";

                    btnCadastrarViagens.Visible = false;
                    lblCancelar.Visible = true;
                    btnAlterarViagens.Enabled = true;
                    
                    if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                    {
                        btnExcluirViagens.Enabled = false;
                    }
                    else
                    {
                        btnExcluirViagens.Enabled = true;
                    }
                }
            }
        }

        private void dgViagensConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgViagensConsulta.DataSource == null)
            {

            }
            else if (dgViagensConsulta.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                int requisicao = int.Parse(dgViagensConsulta.CurrentRow.Cells[0].Value.ToString());

                foreach (Viagem viagem in ListaViagens)
                {
                    if (viagem.Requisicao == requisicao)
                    {
                        listboxOcupantes.Items.Clear();
                        ocupantes.Clear();

                        RequisicaoAntiga = viagem.Requisicao;

                        txtDestino.Text = viagem.Destino;
                        dtDataSaida.Value = viagem.DataSaida;
                        cbPlaca.SelectedValue = viagem.Placa;
                        cbCPF.SelectedValue = viagem.CPF;

                        if (viagem.Ocupante)
                        {
                            rdOcupante.Checked = true;
                            ocupantes = viagem.Ocupantes;

                            foreach (Ocupante ocupante in ocupantes)
                            {
                                listboxOcupantes.Items.Add(ocupante.Nome);
                            }
                        }
                        else
                        {
                            rdsemOcupante.Checked = true;
                        }

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                        tbControlViagens.SelectTab("tbPageCadastroViagem");
                        if (tbControlViagens.SelectedTab == tbPageCadastroViagem)
                        {
                            Viagem = null;
                            txtRequisicaoConsulta.Text = "";

                            btnCadastrarViagens.Visible = false;
                            lblCancelar.Visible = true;
                            btnAlterarViagens.Enabled = true;

                            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                            {
                                btnExcluirViagens.Enabled = false;
                            }
                            else
                            {
                                btnExcluirViagens.Enabled = true;
                            }
                        }
                    }
                }
                textPesquisar.Text = "";
                dgViagensConsulta.DataSource = null;
            }
        }

        private void BtnAlterarViagens_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rdOcupante.Checked && !ocupantes.Any())
            {
                MessageBox.Show("Cadastre ao menos um ocupante!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbCPF.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string cpf = cbCPF.SelectedValue.ToString();
                string placa = cbPlaca.SelectedValue.ToString();

                bool ocupante = false;

                if (rdOcupante.Checked)
                {
                    ocupante = true;
                }
                else if (rdsemOcupante.Checked)
                {
                    ocupantes.Clear();
                }

                int requisicao;

                if (RequisicaoAntiga != int.MaxValue)
                {
                    requisicao = RequisicaoAntiga;
                }
                else
                {
                    requisicao = _viagemController.PopularRequisicao();
                }

                Viagem viagem = new Viagem(requisicao, ocupante, txtDestino.Text, dtDataSaida.Value, placa, cpf);
                viagem.Ocupantes = ocupantes;

                try
                {
                    if (_viagemController.Alterar(viagem, viagem.Requisicao))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        RequisicaoAntiga = int.MaxValue;

                        txtDestino.Text = "";
                        dtDataSaida.Value = DateTime.Now;
                        cbPlaca.SelectedItem = cbPlaca.Items[0];
                        cbCPF.SelectedItem = cbCPF.Items[0];
                        rdOcupante.Checked = false;
                        rdsemOcupante.Checked = false;
                        txtNomeOcupante.Text = "";
                        txtCPFOcupante.Text = "";
                        listboxOcupantes.DataSource = null;
                        listboxOcupantes.Items.Clear();

                        btnCadastrarViagens.Visible = true;
                        lblCancelar.Visible = false;
                        btnAlterarViagens.Enabled = false;
                        btnExcluirViagens.Enabled = false;
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

        private void btnExcluirViagens_Click(object sender, EventArgs e)
        {
            if (cbPlaca.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbCPF.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int requisicao;

                if (RequisicaoAntiga != int.MaxValue)
                {
                    requisicao = RequisicaoAntiga;
                }
                else
                {
                    requisicao = _viagemController.PopularRequisicao();
                }

                try
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_viagemController.Deletar(requisicao))
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");
                            RequisicaoAntiga = int.MaxValue;

                            txtDestino.Text = "";
                            dtDataSaida.Value = DateTime.Now;
                            cbPlaca.SelectedItem = cbPlaca.Items[0];
                            cbCPF.SelectedItem = cbCPF.Items[0];
                            rdOcupante.Checked = false;
                            rdsemOcupante.Checked = false;
                            txtNomeOcupante.Text = "";
                            txtCPFOcupante.Text = "";
                            listboxOcupantes.DataSource = null;
                            listboxOcupantes.Items.Clear();

                            btnCadastrarViagens.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarViagens.Enabled = false;
                            btnExcluirViagens.Enabled = false;
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

            btnCadastrarViagens.BackColor = Properties.Settings.Default.myColor;
            btnConsultarViagens.BackColor = Properties.Settings.Default.myColor;
            btnTodasViagens.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirViagens.BackColor = Properties.Settings.Default.myColor;
            btnAlterarViagens.BackColor = Properties.Settings.Default.myColor;
            btnAddOcupante.BackColor = Properties.Settings.Default.myColor;
            btnConsultaOcupante.BackColor = Properties.Settings.Default.myColor;
            btnConsultaTodosOcupante.BackColor = Properties.Settings.Default.myColor;
            
            btnCadastrarViagens.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarViagens.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodasViagens.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirViagens.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarViagens.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAddOcupante.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultaOcupante.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultaTodosOcupante.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            btnConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            panelConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            btnConsultarPorData.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            btnConsultarPorDataOcupantes.BackColor = Properties.Settings.Default.myColor;
            panelConsultarPorDataOcupantes.BackColor = Properties.Settings.Default.myColor;
            btnConsultarPorDataOcupantes.ForeColor = Properties.Settings.Default.myColorFonteMenu;
        }

        private void panelConsultarPorData_MouseLeave(object sender, EventArgs e)
        {
            panelConsultarPorData.Visible = false;
        }

        private void btnConsultaOcupante_Click(object sender, EventArgs e)
        {
            if (txtReqOcupanteConsulta.Text == "" || txtCPFOcupanteConsulta.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int req = int.Parse(txtReqOcupanteConsulta.Text);

                    string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                    string cpf = txtCPFOcupanteConsulta.Text;

                    foreach (string str in strings)
                    {
                        cpf = cpf.Replace(str, "");
                    }

                    Ocupante ocupante = _ocupanteController.BuscarOcupante(req,cpf);
                    if (ocupante == null)
                    {
                        dgOcupanteConsulta.DataSource = null;
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Requisição", typeof(int));
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("CPF", typeof(string));

                        dt.Rows.Add(ocupante.Requisicao, ocupante.Nome, ocupante.CPF);
                        dgOcupanteConsulta.DataSource = dt;
                    }

                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnConsultaTodosOcupante_Click(object sender, EventArgs e)
        {
            panelConsultarPorDataOcupantes.Visible = true;
        }

        private void btnConsultarPorDataOcupantes_Click(object sender, EventArgs e)
        {
            TimeSpan dtlimiteocupante = Convert.ToDateTime(dtFimConsultarPorDataOcupantes.Value).Subtract(Convert.ToDateTime(dtInicioConsultarPorDataOcupantes.Value));

            if (dtlimiteocupante.TotalDays >= 93)
            {
                MessageBox.Show("Ops, limite maximo atingido! Pesquise no prazo maximo de três meses.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dtFimConsultarPorDataOcupantes.Value < dtInicioConsultarPorDataOcupantes.Value)
                {
                    MessageBox.Show("A Data final deve ser maior que a data de início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        List<Ocupante> ocupantes = _ocupanteController.BuscarTodos(dtInicioConsultarPorDataOcupantes.Value, dtFimConsultarPorDataOcupantes.Value);
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Requisição", typeof(int));
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("CPF", typeof(string));

                        foreach (Ocupante ocupante in ocupantes)
                        {
                            dt.Rows.Add(ocupante.Requisicao, ocupante.Nome, ocupante.CPF);
                        }
                        dgOcupanteConsulta.DataSource = dt;
                    }
                    catch (ConcorrenciaBancoException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }

        private void panelConsultarPorDataOcupantes_MouseLeave(object sender, EventArgs e)
        {
            panelConsultarPorDataOcupantes.Visible = false;
        }



        private void lblCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar manipulação de dados?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtDestino.Text = "";
                dtDataSaida.Value = DateTime.Now;
                cbPlaca.SelectedItem = cbPlaca.Items[0];
                cbCPF.SelectedItem = cbCPF.Items[0];
                rdOcupante.Checked = false;
                rdsemOcupante.Checked = false;
                txtNomeOcupante.Text = "";
                txtCPFOcupante.Text = "";
                listboxOcupantes.DataSource = null;

                btnCadastrarViagens.Visible = true;
                lblCancelar.Visible = false;
                btnAlterarViagens.Enabled = false;
                btnExcluirViagens.Enabled = false;

                Viagem = null;
            }
        }

        private void TextPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Viagem> viagens = _viagemController.Pesquisar(textPesquisar.Text);

                DataTable dt = new DataTable();
                dt.Columns.Add("Código Requisição", typeof(string));
                dt.Columns.Add("Veículo - Placa", typeof(string));
                dt.Columns.Add("Motorista - CPF", typeof(string));
                dt.Columns.Add("Ocupantes", typeof(string));
                dt.Columns.Add("Destino", typeof(string));
                dt.Columns.Add("Data/Hora Saída", typeof(DateTime));

                foreach (Viagem viagem in viagens)
                {
                    string existeOcupantes = null;

                    if (viagem.Ocupante)
                    {
                        existeOcupantes = "Sim";
                    }
                    else
                    {
                        existeOcupantes = "Não";
                    }
                    dt.Rows.Add(viagem.Requisicao, viagem.Placa, viagem.CPF, existeOcupantes, viagem.Destino, viagem.DataSaida);

                }
                ListaViagens = viagens;
                dgViagensConsulta.DataSource = dt;

            }
            catch (ConcorrenciaBancoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
