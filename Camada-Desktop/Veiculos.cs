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

namespace CamadaDesktop
{
    public partial class Veiculos : Form
    {
        private readonly VeiculoController _veiculoController;
        public Veiculos()
        {
            InitializeComponent();
            _veiculoController = InstanciarCamadas();
        }

        private VeiculoController InstanciarCamadas()
        {
            Banco banco = new Banco();
            VeiculoDAL veiculoDAL = new VeiculoDAL(banco);
            VeiculoService veiculoService = new VeiculoService(veiculoDAL);
            return new VeiculoController(veiculoService);
        }
        private void Veiculos_Load(object sender, EventArgs e)
        {
            cbCombustivel.DataSource = Enum.GetValues(typeof(VeiculoCombustivel));
            cbCor.DataSource = Enum.GetValues(typeof(VeiculoTipoCor));
        }

        private void BtnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            if(txtPlaca.Text == "" || txtChassi.Text == "" || txtChassi.Text.Length < 17 || txtMarca.Text == "" || txtModelo.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                VeiculoCombustivel veiculoCombustivel = (VeiculoCombustivel)Enum.Parse(typeof(VeiculoCombustivel), cbCombustivel.SelectedItem.ToString());
                VeiculoTipoCor veiculoTipoCor = (VeiculoTipoCor)Enum.Parse(typeof(VeiculoTipoCor), cbCor.SelectedItem.ToString());
                MessageBox.Show(veiculoCombustivel.ToString() + " " + veiculoTipoCor.ToString());
                //Veiculo veiculo = new Veiculo (txtPlaca.Text, txtMarca.Text, txtModelo.Text, txtChassi.Text, dtAno.Value.Year, veiculoTipoCor, veiculoCombustivel, )
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
    }
}
