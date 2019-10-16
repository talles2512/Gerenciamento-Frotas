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
    public partial class Seguros : Form
    {
        private readonly SeguroController _seguroController;
        private Seguro Seguro;
        string PlacaAntiga;
        string TipoAntigo;
        DateTime dataAntiga;
        public Seguros()
        {
            InitializeComponent();
            _seguroController = InstanciarCamadas();
            Seguro = null;
            PlacaAntiga = "";
            TipoAntigo = "";
            dataAntiga = new DateTime(2000, 01, 01);
        }

        private SeguroController InstanciarCamadas()
        {
            Banco banco = new Banco();
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            VeiculoDAL veiculoDAL = new VeiculoDAL(banco);
            SeguroService seguroService = new SeguroService(seguroDAL, veiculoDAL);
            return new SeguroController(seguroService);
        }

        private void Seguros_Load(object sender, EventArgs e)
        {
            try
            {
                cbItemSegurado.DataSource = _seguroController.PopularPlacas();
                cbItemSegurado.DisplayMember = "MODELO";
                cbItemSegurado.ValueMember = "VCL_PLACA";

                cbSeguradora.DataSource = _seguroController.PopularServicosExternos();
                cbSeguradora.DisplayMember = "SERVEXT_NOME";
                cbSeguradora.ValueMember = "SERVEXT_CNPJ";
            }
            catch (ConcorrenciaBancoException)
            {
                cbItemSegurado.DataSource = null;
                cbSeguradora.DataSource = null;
            }

            cbTipo.DataSource = Enum.GetValues(typeof(TipoSeguro));
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTipo.SelectedItem.ToString() == "Automóvel")
                {
                    cbItemSegurado.DataSource = _seguroController.PopularPlacas();
                    cbItemSegurado.DisplayMember = "MODELO";
                    cbItemSegurado.ValueMember = "VCL_PLACA";
                    cbFranquia.Enabled = true;
                    txtValorFranquia.Enabled = true;
                }
                else if (cbTipo.SelectedItem.ToString() == "Vida")
                {
                    cbItemSegurado.DataSource = _seguroController.PopularCPFs();
                    cbItemSegurado.DisplayMember = "MOTORISTA";
                    cbItemSegurado.ValueMember = "MT_CPF";
                    cbFranquia.Enabled = false;
                    txtValorFranquia.Enabled = false;
                }
            }
            catch (ConcorrenciaBancoException)
            {
                cbItemSegurado.DataSource = null;
            }
        }

        private void BtnCadastrarSeguros_Click(object sender, EventArgs e)
        {
            if (cbSeguradora.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma seguradora antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtValor.Text == "" || txtNApolice.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (cbTipo.SelectedItem.ToString() == "Automóvel")
            {
                if (cbItemSegurado.Items.Count < 1)
                {
                    MessageBox.Show("Cadastre um veiculo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtValorFranquia.Text == "" || dtInicio.Value >= dtfimvigencia.Value)
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TipoSeguro tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipo.SelectedItem.ToString());
                    long cNPJ = Convert.ToInt64(cbSeguradora.SelectedValue);
                    long numeroApolice = Convert.ToInt64(txtNApolice.Text);
                    string itemSegurado = cbTipo.SelectedValue.ToString();
                    double valor = double.Parse(txtValor.Text);
                    string franquia = cbFranquia.SelectedItem.ToString();
                    double valorFranquia = double.Parse(txtValorFranquia.Text);


                    Seguro seguro = new Seguro(numeroApolice, itemSegurado, tipoSeguro, valor, dtInicio.Value, dtfimvigencia.Value, franquia, valorFranquia, cNPJ);

                    try
                    {
                        if (_seguroController.Cadastrar(seguro, seguro.Tipo, seguro.NumeroApolice))
                        {
                            MessageBox.Show("Cadastro realizado com Sucesso!");
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
            else if (cbTipo.SelectedItem.ToString() == "Vida")
            {
                if (cbItemSegurado.Items.Count < 1)
                {
                    MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TipoSeguro tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipo.SelectedItem.ToString());
                    long cNPJ = Convert.ToInt64(cbSeguradora.SelectedValue);
                    long numeroApolice = Convert.ToInt64(txtNApolice.Text);
                    string itemSegurado = cbTipo.SelectedValue.ToString();
                    double valor = double.Parse(txtValor.Text);

                    Seguro seguro = new Seguro(numeroApolice, itemSegurado, tipoSeguro, valor, dtInicio.Value, dtfimvigencia.Value, cNPJ);

                    try
                    {
                        if (_seguroController.Cadastrar(seguro, seguro.Tipo, seguro.NumeroApolice))
                        {
                            MessageBox.Show("Cadastro realizado com Sucesso!");
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
        }
    }
}
