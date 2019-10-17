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
        long NApoliceAntiga;
        string TipoAntigo;
        public Seguros()
        {
            InitializeComponent();
            _seguroController = InstanciarCamadas();
            Seguro = null;
            NApoliceAntiga = long.MaxValue;
            TipoAntigo = "";
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
            cbTipoConsulta.DataSource = Enum.GetValues(typeof(TipoSeguro));
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTipo.SelectedItem.ToString() == "Automóvel")
                {
                    lblItemSegurado.Text = "Veículo - Placa:";
                    cbItemSegurado.DataSource = _seguroController.PopularPlacas();
                    cbItemSegurado.DisplayMember = "MODELO";
                    cbItemSegurado.ValueMember = "VCL_PLACA";
                    cbFranquia.Enabled = true;
                    txtValorFranquia.Enabled = true;
                    cbFranquia.SelectedItem = "Normal";
                    cbFranquia.Text = "Normal";
                }
                else if (cbTipo.SelectedItem.ToString() == "Vida")
                {
                    lblItemSegurado.Text = "Motorista - CPF:";
                    cbItemSegurado.DataSource = _seguroController.PopularCPFs();
                    cbItemSegurado.DisplayMember = "MOTORISTA";
                    cbItemSegurado.ValueMember = "MT_CPF";
                    cbFranquia.Enabled = false;
                    txtValorFranquia.Enabled = false;
                    cbFranquia.Text = "";
                    txtValorFranquia.Text = "";
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
            else
            {
                TipoSeguro tipoSeguro;
                Seguro seguro = null;

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
                        tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipo.SelectedItem.ToString());
                        long cNPJ = Convert.ToInt64(cbSeguradora.SelectedValue);
                        long numeroApolice = Convert.ToInt64(txtNApolice.Text);
                        string itemSegurado = cbItemSegurado.SelectedValue.ToString();
                        double valor = double.Parse(txtValor.Text);
                        string franquia = cbFranquia.SelectedItem.ToString();
                        double valorFranquia = double.Parse(txtValorFranquia.Text);


                        seguro = new Seguro(numeroApolice, itemSegurado, tipoSeguro, valor, dtInicio.Value, dtfimvigencia.Value, franquia, valorFranquia, cNPJ);
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
                        tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipo.SelectedItem.ToString());
                        long cNPJ = Convert.ToInt64(cbSeguradora.SelectedValue);
                        long numeroApolice = Convert.ToInt64(txtNApolice.Text);
                        string itemSegurado = cbItemSegurado.SelectedValue.ToString();
                        double valor = double.Parse(txtValor.Text);

                        seguro = new Seguro(numeroApolice, itemSegurado, tipoSeguro, valor, dtInicio.Value, dtfimvigencia.Value, cNPJ);
                    }
                }

                if(seguro != null)
                {
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

        private void BtnConsultarSeguros_Click(object sender, EventArgs e)
        {
            if (txtNApoliceConsulta.Text == "")
            {
                MessageBox.Show("Preencha o campo Número da Apólice corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    TipoSeguro tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipoConsulta.SelectedItem.ToString());
                    long numeroApolice = Convert.ToInt64(txtNApoliceConsulta.Text);

                    Seguro seguro = _seguroController.BuscarSeguro(tipoSeguro, numeroApolice);
                    if (seguro == null)
                    {
                        dgSegurosConsulta.DataSource = null;
                    }
                    else
                    {
                        if (cbTipoConsulta.SelectedItem.ToString() == "Automóvel")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("Número Apólice", typeof(long));
                            dt.Columns.Add("Seguradora", typeof(long));
                            dt.Columns.Add("Veículo - Placa", typeof(string));
                            dt.Columns.Add("Valor", typeof(double));
                            dt.Columns.Add("Data Inicial", typeof(DateTime));
                            dt.Columns.Add("Data Vencimento", typeof(DateTime));
                            dt.Columns.Add("Tipo de Franquia", typeof(string));
                            dt.Columns.Add("Valor da Franquia", typeof(double));

                            dt.Rows.Add(seguro.NumeroApolice, seguro.CNPJ, seguro.ItemSegurado, seguro.Valor, seguro.DataInicio, seguro.FimVigencia,
                                seguro.Franquia, seguro.ValorFranquia);

                            dgSegurosConsulta.DataSource = dt;
                        }
                        else if (cbTipoConsulta.SelectedItem.ToString() == "Vida")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("Número Apólice", typeof(long));
                            dt.Columns.Add("Seguradora", typeof(long));
                            dt.Columns.Add("Motorista - CPF", typeof(string));
                            dt.Columns.Add("Valor", typeof(double));
                            dt.Columns.Add("Data Inicial", typeof(DateTime));
                            dt.Columns.Add("Data Vencimento", typeof(DateTime));

                            dt.Rows.Add(seguro.NumeroApolice, seguro.CNPJ, seguro.ItemSegurado, seguro.Valor, seguro.DataInicio, seguro.FimVigencia);

                            dgSegurosConsulta.DataSource = dt;
                        }
                        Seguro = seguro;
                        seguro = null;
                    }    
                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }                   
            }
        }

        private void BtnTodosSeguros_Click(object sender, EventArgs e)
        {
            try
            {
                List<Seguro> seguros = _seguroController.BuscarTodos();

                DataTable dt = new DataTable();
                dt.Columns.Add("Número Apólice", typeof(long));
                dt.Columns.Add("Seguradora", typeof(long));
                dt.Columns.Add("Tipo de Seguro", typeof(string));
                dt.Columns.Add("Item Segurado", typeof(string));
                dt.Columns.Add("Valor", typeof(double));
                dt.Columns.Add("Data Inicial", typeof(DateTime));
                dt.Columns.Add("Data Vencimento", typeof(DateTime));
                dt.Columns.Add("Tipo de Franquia", typeof(string));
                dt.Columns.Add("Valor da Franquia", typeof(double));

                foreach (Seguro seguro in seguros)
                {

                    if(seguro.Franquia != "")
                    {
                        dt.Rows.Add(seguro.NumeroApolice, seguro.CNPJ , seguro.Tipo.ToString(), seguro.ItemSegurado, seguro.Valor, seguro.DataInicio, seguro.FimVigencia,
                               seguro.Franquia, seguro.ValorFranquia);
                    }
                    else
                    {
                        dt.Rows.Add(seguro.NumeroApolice, seguro.CNPJ, seguro.Tipo.ToString(), seguro.ItemSegurado, seguro.Valor, seguro.DataInicio, seguro.FimVigencia);
                    }
                }
                dgSegurosConsulta.DataSource = dt;
            }
            catch (ConcorrenciaBancoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnTrasferirSeguros_Click(object sender, EventArgs e)
        {
            if (Seguro == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                NApoliceAntiga = Seguro.NumeroApolice;
                TipoAntigo = Seguro.Tipo.ToString();

                cbTipo.SelectedItem = Seguro.Tipo;
                cbSeguradora.SelectedValue = Seguro.CNPJ;
                txtNApolice.Text = Seguro.NumeroApolice.ToString();
                cbItemSegurado.SelectedValue = Seguro.ItemSegurado;
                txtValor.Text = Seguro.Valor.ToString();
                dtInicio.Value = Seguro.DataInicio;
                dtfimvigencia.Value = Seguro.FimVigencia;

                if(Seguro.Franquia != "")
                {
                    cbFranquia.SelectedItem = Seguro.Franquia;
                    txtValorFranquia.Text = Seguro.ValorFranquia.ToString();
                }

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlSeguros.SelectTab("tbPageCadastroSeguros");
                if (tbControlSeguros.SelectedTab == tbPageCadastroSeguros)
                {
                    txtNApoliceConsulta.Text = "";
                    Seguro = null;
                }
            }
        }

        private void BtnAlterarSeguros_Click(object sender, EventArgs e)
        {
            if (cbSeguradora.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma seguradora antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtValor.Text == "" || txtNApolice.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                TipoSeguro tipoSeguro;
                Seguro seguro = null;

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
                        tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipo.SelectedItem.ToString());
                        long cNPJ = Convert.ToInt64(cbSeguradora.SelectedValue);
                        long numeroApolice = Convert.ToInt64(txtNApolice.Text);
                        string itemSegurado = cbItemSegurado.SelectedValue.ToString();
                        double valor = double.Parse(txtValor.Text);
                        string franquia = cbFranquia.SelectedItem.ToString();
                        double valorFranquia = double.Parse(txtValorFranquia.Text);


                        seguro = new Seguro(numeroApolice, itemSegurado, tipoSeguro, valor, dtInicio.Value, dtfimvigencia.Value, franquia, valorFranquia, cNPJ);
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
                        tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipo.SelectedItem.ToString());
                        long cNPJ = Convert.ToInt64(cbSeguradora.SelectedValue);
                        long numeroApolice = Convert.ToInt64(txtNApolice.Text);
                        string itemSegurado = cbItemSegurado.SelectedValue.ToString();
                        double valor = double.Parse(txtValor.Text);

                        seguro = new Seguro(numeroApolice, itemSegurado, tipoSeguro, valor, dtInicio.Value, dtfimvigencia.Value, cNPJ);
                    }
                }

                if(seguro != null)
                {
                    try
                    {
                        if (NApoliceAntiga == long.MaxValue)
                        {
                            NApoliceAntiga = seguro.NumeroApolice;
                        }
                        if (TipoAntigo == "")
                        {
                            tipoSeguro = seguro.Tipo;
                            TipoAntigo = tipoSeguro.ToString();
                        }
                        else
                        {
                            tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), TipoAntigo);
                        }

                        if (_seguroController.Alterar(seguro, tipoSeguro, NApoliceAntiga))
                        {
                            MessageBox.Show("Alteração realizada com Sucesso!");
                            NApoliceAntiga = long.MaxValue;
                            TipoAntigo = "";
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
        }

        private void BtnExcluirSeguros_Click(object sender, EventArgs e)
        {
            if (cbSeguradora.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma seguradora antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNApolice.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cbTipo.SelectedItem.ToString() == "Automóvel")
                {
                    if (cbItemSegurado.Items.Count < 1)
                    {
                        MessageBox.Show("Cadastre um veiculo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (cbTipo.SelectedItem.ToString() == "Vida")
                {
                    if (cbItemSegurado.Items.Count < 1)
                    {
                        MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                
                if(cbItemSegurado.Items.Count >= 1 && txtNApolice.Text != "")
                {
                    TipoSeguro tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipo.SelectedItem.ToString());
                    long numeroApolice = Convert.ToInt64(txtNApolice.Text);

                    try
                    {
                        if (MessageBox.Show("Deseja realmente excluir?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (_seguroController.Deletar(tipoSeguro, numeroApolice))
                            {
                                MessageBox.Show("Exclusão realizada com Sucesso!");
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
        }
    }
}
