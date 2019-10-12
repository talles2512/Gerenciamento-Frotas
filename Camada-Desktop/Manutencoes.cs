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
        private Manutencao Manutencao;
        string PlacaAntiga;
        string TipoAntigo;
        DateTime dataAntiga;
        public Manutencoes()
        {
            InitializeComponent();
            _manutencaoController = InstanciarCamadas();
            Manutencao = null;
            PlacaAntiga = "";
            TipoAntigo = "";
            dataAntiga = new DateTime();

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
        }

        private void BtnCadastrarManunt_Click(object sender, EventArgs e)
        {
            if (cbPlaca.DataSource == null)
            {
                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (cbServicoExterno.DataSource == null)
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
                    if (_manutencaoController.Cadastrar(manutencao, manutencao.Placa, manutencao.Tipo, manutencao.Data))
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

        private void BtnConsultarManunt_Click(object sender, EventArgs e)
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
                try
                {
                    ManutencaoTipo manutencaoTipo = (ManutencaoTipo)Enum.Parse(typeof(ManutencaoTipo), cbTipoManuntConsulta.SelectedItem.ToString());
                    string placa = cbPlaca.SelectedValue.ToString();

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
                try
                {
                    ManutencaoTipo manutencaoTipo = (ManutencaoTipo)Enum.Parse(typeof(ManutencaoTipo), cbTipoManuntConsulta.SelectedItem.ToString());
                    string placa = cbPlaca.SelectedValue.ToString();

                    List<Manutencao> manutencoes = _manutencaoController.BuscarTodos();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Tipo", typeof(string));
                    dt.Columns.Add("CNPJ", typeof(long));
                    dt.Columns.Add("Placa", typeof(string));
                    dt.Columns.Add("Descrição", typeof(string));
                    dt.Columns.Add("Valor Manutenção", typeof(double));
                    dt.Columns.Add("Data", typeof(DateTime));
                    dt.Columns.Add("Situação", typeof(string));

                    foreach(Manutencao manutencao in manutencoes)
                    {
                        dt.Rows.Add(manutencao.Tipo.ToString(), manutencao.CNPJ, manutencao.Placa, manutencao.Descricao, manutencao.Valor
                            , manutencao.Data, manutencao.Situacao.ToString());
                    }
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
