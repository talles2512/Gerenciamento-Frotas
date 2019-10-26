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
        private Viagem Viagem;
        List<Ocupante> ocupantes = new List<Ocupante>();
        int RequisicaoAntiga;
        public Viagens()
        {
            InitializeComponent();
            _viagemController = InstanciarCamadas();
            Viagem = null;
            RequisicaoAntiga = int.MaxValue;
        }

        private ViagemController InstanciarCamadas()
        {
            Banco banco = new Banco();
            ViagemDAL viagemDAL = new ViagemDAL(banco);
            OcupanteDAL ocupanteDAL = new OcupanteDAL(banco);
            ViagemService viagemService = new ViagemService(viagemDAL, ocupanteDAL);
            return new ViagemController(viagemService);
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
            try
            {
                List<Viagem> viagens = _viagemController.BuscarTodos();
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
                }
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
            //Falta Metodo
        }

        private void btnConsultaTodosOcupante_Click(object sender, EventArgs e)
        {
            panelConsultarPorDataOcupantes.Visible = true;
        }

        private void btnConsultarPorDataOcupantes_Click(object sender, EventArgs e)
        {
            //Falta Metodo
        }

        private void panelConsultarPorDataOcupantes_MouseLeave(object sender, EventArgs e)
        {
            panelConsultarPorDataOcupantes.Visible = false;
        }
    }
}
