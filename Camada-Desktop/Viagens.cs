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
        string PlacaAntiga;
        long cnpjAntigo;
        string TipoAntigo;
        DateTime dataAntiga;
        public Viagens()
        {
            InitializeComponent();
            _viagemController = InstanciarCamadas();
            Viagem = null;
            PlacaAntiga = "";
            cnpjAntigo = long.MaxValue;
            TipoAntigo = "";
            dataAntiga = new DateTime(2000, 01, 01);
        }

        private ViagemController InstanciarCamadas()
        {
            Banco banco = new Banco();
            ViagemDAL viagemDAL = new ViagemDAL(banco);
            ViagemService viagemService = new ViagemService(viagemDAL);
            return new ViagemController(viagemService);
        }

        private void rdOcupante_CheckedChanged(object sender, EventArgs e)
        {
            gbOcupante.Enabled = true;
        }

        private void rdsemOcupante_CheckedChanged(object sender, EventArgs e)
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

            }
            catch (ConcorrenciaBancoException)
            {
                cbCPF.DataSource = null;
            }

            try
            {
                cbPlaca.DataSource = _viagemController.PopularPlacas();
                cbPlaca.DisplayMember = "MODELO";
                cbPlaca.ValueMember = "VCL_PLACA";
            }
            catch (ConcorrenciaBancoException)
            {
                cbPlaca.DataSource = null;
            }
        }

        private void BtnCadastrarViagens_Click(object sender, EventArgs e)
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

                string cpf = cbCPF.SelectedValue.ToString();
                string placa = cbPlaca.SelectedValue.ToString();

                bool ocupante = false;

                if (rdOcupante.Checked)
                {
                    ocupante = true;
                }

                try
                {
                    int requisicao = _viagemController.PopularRequisicao();
                    Viagem viagem = new Viagem(requisicao, ocupante, txtDestino.Text, dtDataSaida.Value, placa, cpf);

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
    }
}
