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
        private readonly SeguroCoberturaController _seguroCoberturaController;
        private List<Seguro> ListaSeguros;
        private Seguro Seguro;
        private List<SeguroCobertura> ListaSeguroCoberturas;
        private SeguroCobertura SeguroCobertura;
        long NApoliceAntiga;
        string TipoAntigo;
        long NApoliceAntigaCobertura;
        string TipoAntigoCobertura;
        PerfilAcesso PerfilAcesso;

        public Seguros()
        {
            InitializeComponent();
            _seguroController = InstanciarCamadas1();
            _seguroCoberturaController = InstanciarCamadas2();
            Seguro = null;
            NApoliceAntiga = long.MaxValue;
            TipoAntigo = "";

            SeguroCobertura = null;
            NApoliceAntigaCobertura = long.MaxValue;
            TipoAntigoCobertura = "";
        }

        public Seguros(PerfilAcesso perfilAcesso)
        {
            InitializeComponent();
            _seguroController = InstanciarCamadas1();
            _seguroCoberturaController = InstanciarCamadas2();
            Seguro = null;
            NApoliceAntiga = long.MaxValue;
            TipoAntigo = "";

            SeguroCobertura = null;
            NApoliceAntigaCobertura = long.MaxValue;
            TipoAntigoCobertura = "";
            PerfilAcesso = perfilAcesso;
        }

        private SeguroController InstanciarCamadas1()
        {
            Banco banco = new Banco();
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            SeguroService seguroService = new SeguroService(seguroDAL);
            return new SeguroController(seguroService);
        }

        private SeguroCoberturaController InstanciarCamadas2()
        {
            Banco banco = new Banco();
            SeguroCoberturaDAL seguroCoberturaDAL = new SeguroCoberturaDAL(banco);
            SeguroCoberturaService seguroCoberturaService = new SeguroCoberturaService(seguroCoberturaDAL);
            return new SeguroCoberturaController(seguroCoberturaService);
        }

        private void Seguros_Load(object sender, EventArgs e)
        {
            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao.Visible = true;
                toolTipPermissao.SetToolTip(this.pbpermissao, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao.Hide(pbpermissao);
            }

            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao1.Visible = true;
                toolTipPermissao.SetToolTip(this.pbpermissao1, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao.Hide(pbpermissao1);
            }

            cbTipo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTipo.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbSeguradora.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSeguradora.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbItemSegurado.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbItemSegurado.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbFranquia.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbFranquia.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbTipoConsulta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTipoConsulta.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbTipoCobertura.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTipoCobertura.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbSeguro.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSeguro.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbTipoCoberturaConsulta.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTipoCoberturaConsulta.AutoCompleteSource = AutoCompleteSource.ListItems;

            tooltipPesquisar.SetToolTip(lbPesquisar, "Pesquise pelo Nome ou CPF do Motorista." +
                " \nMarca, Placa ou Modelo do Veículo." +
                " \nNome da Seguradora ou CNPJ ou Número da Apolice do Seguro.");
            tooltipPesquisar.Hide(lbPesquisar);
            toolTipTransfere.SetToolTip(this.btnTrasferirSeguros, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirSeguros);
            toolTipTransfereCobertura.SetToolTip(this.btnTransfereCobertura, "Transferir Dados");
            toolTipTransfereCobertura.Hide(btnTransfereCobertura);

            try
            {
                cbItemSegurado.DataSource = _seguroController.PopularPlacas();
                cbItemSegurado.DisplayMember = "MODELO";
                cbItemSegurado.ValueMember = "VCL_PLACA";

                cbSeguradora.DataSource = _seguroController.PopularServicosExternos();
                cbSeguradora.DisplayMember = "SERVEXT_NOME";
                cbSeguradora.ValueMember = "SERVEXT_CNPJ";

                cbSeguro.DataSource = _seguroCoberturaController.PopularSeguros(TipoSeguro.Automóvel);
                cbSeguro.DisplayMember = "SEG_NUMAPOLICE";
                cbSeguro.ValueMember = "SEG_NUMAPOLICE";
            }
            catch (ConcorrenciaBancoException)
            {
                cbItemSegurado.DataSource = null;
                cbSeguradora.DataSource = null;
                cbSeguro.DataSource = null;
            }


            cbTipo.DataSource = Enum.GetValues(typeof(TipoSeguro));
            cbTipoConsulta.DataSource = Enum.GetValues(typeof(TipoSeguro));

            cbTipoCobertura.DataSource = Enum.GetValues(typeof(TipoSeguro));
            cbTipoCoberturaConsulta.DataSource = Enum.GetValues(typeof(TipoSeguro));

            AtualizarCor();
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
                            cbTipo.Text = "";
                            cbSeguradora.Text = "";
                            txtNApolice.Text = "";
                            cbItemSegurado.Text = "";
                            txtValor.Text = "";
                            dtInicio.Value = DateTime.Now;
                            dtfimvigencia.Value = DateTime.Now;
                            cbFranquia.Text = "";
                            txtValorFranquia.Text = "";
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
                        ListaSeguros = new List<Seguro>();
                        ListaSeguros.Add(seguro);
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
                        List<Seguro> seguros = _seguroController.BuscarTodos(dtInicioConsulta.Value, dtFimConsulta.Value);

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

                            if (seguro.Franquia != "")
                            {
                                dt.Rows.Add(seguro.NumeroApolice, seguro.CNPJ, seguro.Tipo.ToString(), seguro.ItemSegurado, seguro.Valor, seguro.DataInicio, seguro.FimVigencia,
                                       seguro.Franquia, seguro.ValorFranquia);
                            }
                            else
                            {
                                dt.Rows.Add(seguro.NumeroApolice, seguro.CNPJ, seguro.Tipo.ToString(), seguro.ItemSegurado, seguro.Valor, seguro.DataInicio, seguro.FimVigencia);
                            }
                        }
                        ListaSeguros = seguros;
                        dgSegurosConsulta.DataSource = dt;
                    }
                    catch (ConcorrenciaBancoException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
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
                    cbTipoCoberturaConsulta.Text = "";
                    Seguro = null;

                    btnCadastrarSeguros.Visible = false;
                    lblCancelar.Visible = true;
                    btnAlterarSeguros.Enabled = true;
                    
                    if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                    {
                        btnExcluirSeguros.Enabled = false;
                    }
                    else
                    {
                        btnExcluirSeguros.Enabled = true;
                    }
                }
            }
        }

        private void dgSegurosConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgSegurosConsulta.DataSource == null)
            {

            }
            else if (dgSegurosConsulta.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                string itemsegurado = dgSegurosConsulta.CurrentRow.Cells[3].Value.ToString();

                foreach (Seguro seguro in ListaSeguros)
                {
                    if (seguro.ItemSegurado == itemsegurado)
                    {
                        NApoliceAntiga = seguro.NumeroApolice;
                        TipoAntigo = seguro.Tipo.ToString();

                        cbTipo.SelectedItem = seguro.Tipo;
                        cbSeguradora.SelectedValue = seguro.CNPJ;
                        txtNApolice.Text = seguro.NumeroApolice.ToString();
                        cbItemSegurado.SelectedValue = seguro.ItemSegurado;
                        txtValor.Text = seguro.Valor.ToString();
                        dtInicio.Value = seguro.DataInicio;
                        dtfimvigencia.Value = seguro.FimVigencia;

                        if (seguro.Franquia != "")
                        {
                            cbFranquia.SelectedItem = seguro.Franquia;
                            txtValorFranquia.Text = seguro.ValorFranquia.ToString();
                        }

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                        tbControlSeguros.SelectTab("tbPageCadastroSeguros");
                        if (tbControlSeguros.SelectedTab == tbPageCadastroSeguros)
                        {
                            txtNApoliceConsulta.Text = "";
                            cbTipoCoberturaConsulta.Text = "";
                            Seguro = null;

                            btnCadastrarSeguros.Visible = false;
                            lblCancelar.Visible = true;
                            btnAlterarSeguros.Enabled = true;

                            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                            {
                                btnExcluirSeguros.Enabled = false;
                            }
                            else
                            {
                                btnExcluirSeguros.Enabled = true;
                            }
                        }
                    }
                }
                textPesquisar.Text = "";
                dgSegurosConsulta.DataSource = null;
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
                            cbTipo.SelectedItem = cbTipo.Items[0];
                            cbSeguradora.SelectedItem = cbSeguradora.Items[0];
                            cbItemSegurado.SelectedItem = cbItemSegurado.Items[0];
                            txtNApolice.Text = "";
                            txtValor.Text = "";
                            dtInicio.Value = DateTime.Now;
                            dtfimvigencia.Value = DateTime.Now;
                            cbFranquia.SelectedItem = cbFranquia.Items[0];
                            txtValorFranquia.Text = "";

                            btnCadastrarSeguros.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarSeguros.Enabled = false;
                            btnExcluirSeguros.Enabled = false;
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
                                cbTipo.SelectedItem = cbTipo.Items[0];
                                cbSeguradora.SelectedItem = cbSeguradora.Items[0];
                                cbItemSegurado.SelectedItem = cbItemSegurado.Items[0];
                                txtNApolice.Text = "";
                                txtValor.Text = "";
                                dtInicio.Value = DateTime.Now;
                                dtfimvigencia.Value = DateTime.Now;
                                cbFranquia.SelectedItem = cbFranquia.Items[0];
                                txtValorFranquia.Text = "";

                                btnCadastrarSeguros.Visible = true;
                                lblCancelar.Visible = false;
                                btnAlterarSeguros.Enabled = false;
                                btnExcluirSeguros.Enabled = false;
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

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar manipulação de dados?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cbTipo.SelectedItem = cbTipo.Items[0];
                cbSeguradora.SelectedItem = cbSeguradora.Items[0];
                cbItemSegurado.SelectedItem = cbItemSegurado.Items[0];
                txtNApolice.Text = "";
                txtValor.Text = "";
                dtInicio.Value = DateTime.Now;
                dtfimvigencia.Value = DateTime.Now;
                cbFranquia.SelectedItem = cbFranquia.Items[0];
                txtValorFranquia.Text = "";

                btnCadastrarSeguros.Visible = true;
                lblCancelar.Visible = false;
                btnAlterarSeguros.Enabled = false;
                btnExcluirSeguros.Enabled = false;

                Seguro = null;
            }
        }

        private void CbTipoCobertura_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCoberturaDescricao.Text = "";
            if (cbTipoCobertura.SelectedItem.ToString() == "Automóvel")
            {
                try
                {
                    cbSeguro.DataSource = _seguroCoberturaController.PopularSeguros(TipoSeguro.Automóvel);
                    cbSeguro.DisplayMember = "SEG_NUMAPOLICE";
                    cbSeguro.ValueMember = "SEG_NUMAPOLICE";
                }
                catch (ConcorrenciaBancoException)
                {
                    cbSeguro.DataSource = null;
                }
            }
            else if (cbTipoCobertura.SelectedItem.ToString() == "Vida")
            {
                try
                {
                    cbSeguro.DataSource = _seguroCoberturaController.PopularSeguros(TipoSeguro.Vida);
                    cbSeguro.DisplayMember = "SEG_NUMAPOLICE";
                    cbSeguro.ValueMember = "SEG_NUMAPOLICE";
                }
                catch (ConcorrenciaBancoException)
                {
                    cbSeguro.DataSource = null;
                }
            }
        }

        private void BtnCadastrarCobertura_Click(object sender, EventArgs e)
        {
            if (txtCoberturaDescricao.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(cbSeguro.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma segurado antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                TipoSeguro tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipoCobertura.SelectedItem.ToString());
                long numeroApolice = long.Parse(cbSeguro.SelectedValue.ToString());

                SeguroCobertura seguroCobertura = new SeguroCobertura(tipoSeguro, txtCoberturaDescricao.Text, numeroApolice);

                try
                {
                    if (_seguroCoberturaController.Cadastrar(seguroCobertura))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");
                        cbTipoCobertura.Text = "";
                        cbSeguro.Text = "";
                        txtCoberturaDescricao.Text = "";
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

        private void BtnConsultaCobertura_Click(object sender, EventArgs e)
        {
            if (txtNApoliceCoberturaConsulta.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    TipoSeguro tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipoCoberturaConsulta.SelectedItem.ToString());
                    long numeroApolice = Convert.ToInt64(txtNApoliceCoberturaConsulta.Text);

                    SeguroCobertura seguroCobertura = _seguroCoberturaController.BuscarSeguroCobertura(tipoSeguro, numeroApolice);
                    if (seguroCobertura == null)
                    {
                        dgCoberturaConsulta.DataSource = null;
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Número Apólice", typeof(long));
                        dt.Columns.Add("Tipo de Seguro", typeof(string));
                        dt.Columns.Add("Descrição", typeof(string));

                        dt.Rows.Add(seguroCobertura.NumeroApolice, seguroCobertura.Tipo.ToString(), seguroCobertura.Descricao);

                        dgCoberturaConsulta.DataSource = dt;
                    }
                    SeguroCobertura = seguroCobertura;
                    ListaSeguroCoberturas = new List<SeguroCobertura>();
                    ListaSeguroCoberturas.Add(seguroCobertura);
                    seguroCobertura = null;
                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void BtnConsultaTodosCobertura_Click(object sender, EventArgs e)
        {
            panelConsultarporDataCobertura.Visible = true;
        }


        private void btnConsultarporDataCobertura_Click(object sender, EventArgs e)
        {
            TimeSpan dtlimitecobertura = Convert.ToDateTime(dtFimConsultarporDataCobertura.Value).Subtract(Convert.ToDateTime(dtInicioConsultarporDataCobertura.Value));

            if (dtlimitecobertura.TotalDays >= 93)
            {
                MessageBox.Show("Ops, limite maximo atingido! Pesquise no prazo maximo de três meses.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dtFimConsultarporDataCobertura.Value < dtInicioConsultarporDataCobertura.Value)
                {
                    MessageBox.Show("A Data final deve ser maior que a data de início!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        List<SeguroCobertura> seguroCoberturas = _seguroCoberturaController.BuscarTodos(dtInicioConsultarporDataCobertura.Value, dtFimConsultarporDataCobertura.Value);
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Número Apólice", typeof(long));
                        dt.Columns.Add("Tipo de Seguro", typeof(string));
                        dt.Columns.Add("Descrição", typeof(string));

                        foreach (SeguroCobertura seguroCobertura in seguroCoberturas)
                        {
                            dt.Rows.Add(seguroCobertura.NumeroApolice, seguroCobertura.Tipo.ToString(), seguroCobertura.Descricao);
                        }
                        ListaSeguroCoberturas = seguroCoberturas;
                        dgCoberturaConsulta.DataSource = dt;
                    }
                    catch (ConcorrenciaBancoException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }          
        }

        private void BtnTransfereCobertura_Click(object sender, EventArgs e)
        {
            if (SeguroCobertura == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                NApoliceAntigaCobertura = SeguroCobertura.NumeroApolice;
                TipoAntigoCobertura = SeguroCobertura.Tipo.ToString();

                cbTipoCobertura.SelectedItem = SeguroCobertura.Tipo;
                cbSeguro.SelectedValue = SeguroCobertura.NumeroApolice;
                txtCoberturaDescricao.Text = SeguroCobertura.Descricao;

                if (txtCoberturaDescricao.Text != "")
                {
                    txtNApoliceCoberturaConsulta.Text = "";
                    cbTipoCoberturaConsulta.Text = "";
                    SeguroCobertura = null;
                    dgCoberturaConsulta.DataSource = null;

                    btnCadastrarCobertura.Visible = false;
                    lblCancelarCobertura.Visible = true;
                    btnAlterarCobertura.Enabled = true;
                    
                    if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                    {
                        btnExcluirCobertura.Enabled = false;
                    }
                    else
                    {
                        btnExcluirCobertura.Enabled = true;
                    }
                }
            }
        }

        private void dgCoberturaConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgCoberturaConsulta.DataSource == null)
            {

            }
            else if (dgCoberturaConsulta.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                long numApolice = long.Parse(dgCoberturaConsulta.CurrentRow.Cells[0].Value.ToString());
                string tipo = dgCoberturaConsulta.CurrentRow.Cells[1].Value.ToString();
                string descricao = dgCoberturaConsulta.CurrentRow.Cells[2].Value.ToString();

                foreach (SeguroCobertura seguroCobertura in ListaSeguroCoberturas)
                {
                    if (seguroCobertura.NumeroApolice == numApolice && seguroCobertura.Tipo.ToString() == tipo && seguroCobertura.Descricao == descricao)
                    {
                        NApoliceAntigaCobertura = seguroCobertura.NumeroApolice;
                        TipoAntigoCobertura = seguroCobertura.Tipo.ToString();

                        cbTipoCobertura.SelectedItem = seguroCobertura.Tipo;
                        cbSeguro.SelectedValue = seguroCobertura.NumeroApolice;
                        txtCoberturaDescricao.Text = seguroCobertura.Descricao;

                        if (txtCoberturaDescricao.Text != "")
                        {
                            txtNApoliceCoberturaConsulta.Text = "";
                            cbTipoCoberturaConsulta.Text = "";
                            SeguroCobertura = null;
                            dgCoberturaConsulta.DataSource = null;

                            btnCadastrarCobertura.Visible = false;
                            lblCancelarCobertura.Visible = true;
                            btnAlterarCobertura.Enabled = true;

                            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                            {
                                btnExcluirCobertura.Enabled = false;
                            }
                            else
                            {
                                btnExcluirCobertura.Enabled = true;
                            }
                        }
                    }
                }
                dgCoberturaConsulta.DataSource = null;
            }
        }

        private void BtnAlterarCobertura_Click(object sender, EventArgs e)
        {
            if (txtCoberturaDescricao.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                TipoSeguro tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipoCobertura.SelectedItem.ToString());
                long numeroApolice = long.Parse(cbSeguro.SelectedValue.ToString());

                SeguroCobertura seguroCobertura = new SeguroCobertura(tipoSeguro, txtCoberturaDescricao.Text, numeroApolice);

                try
                {
                    if (NApoliceAntigaCobertura == long.MaxValue)
                    {
                        NApoliceAntigaCobertura = seguroCobertura.NumeroApolice;
                    }
                    if (TipoAntigoCobertura == "")
                    {
                        tipoSeguro = seguroCobertura.Tipo;
                        TipoAntigoCobertura = tipoSeguro.ToString();
                    }
                    else
                    {
                        tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), TipoAntigoCobertura);
                    }
                    if (_seguroCoberturaController.Alterar(seguroCobertura, tipoSeguro, NApoliceAntigaCobertura))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        NApoliceAntigaCobertura = long.MaxValue;
                        TipoAntigoCobertura = "";
                        cbTipoCobertura.SelectedItem = cbTipoCobertura.Items[0];
                        cbSeguro.SelectedItem = cbSeguro.Items[0];
                        txtCoberturaDescricao.Text = "";

                        btnCadastrarCobertura.Visible = true;
                        lblCancelarCobertura.Visible = false;
                        btnAlterarCobertura.Enabled = false;
                        btnExcluirCobertura.Enabled = false;
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

        private void BtnExcluirCobertura_Click(object sender, EventArgs e)
        {
            if (cbSeguro.Items.Count < 1)
            {
                MessageBox.Show("Cadastre uma segurado antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    TipoSeguro tipoSeguro = (TipoSeguro)Enum.Parse(typeof(TipoSeguro), cbTipoCobertura.SelectedItem.ToString());
                    long numeroApolice = long.Parse(cbSeguro.SelectedValue.ToString());

                    if (MessageBox.Show("Deseja realmente excluir?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_seguroCoberturaController.Deletar(tipoSeguro, numeroApolice))
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");
                            cbTipoCobertura.SelectedItem = cbTipoCobertura.Items[0];
                            cbSeguro.SelectedItem = cbSeguro.Items[0];
                            txtCoberturaDescricao.Text = "";

                            btnCadastrarCobertura.Visible = true;
                            lblCancelarCobertura.Visible = false;
                            btnAlterarCobertura.Enabled = false;
                            btnExcluirCobertura.Enabled = false;
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

            btnCadastrarSeguros.BackColor = Properties.Settings.Default.myColor;
            btnCadastrarCobertura.BackColor = Properties.Settings.Default.myColor;
            btnConsultarSeguros.BackColor = Properties.Settings.Default.myColor;
            btnConsultaCobertura.BackColor = Properties.Settings.Default.myColor;
            btnTodosSeguros.BackColor = Properties.Settings.Default.myColor;
            btnConsultaTodosCobertura.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirSeguros.BackColor = Properties.Settings.Default.myColor;
            btnTransfereCobertura.BackColor = Properties.Settings.Default.myColor;
            btnAlterarSeguros.BackColor = Properties.Settings.Default.myColor;
            btnAlterarCobertura.BackColor = Properties.Settings.Default.myColor;
                        
            btnCadastrarSeguros.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnCadastrarCobertura.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarSeguros.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultaCobertura.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodosSeguros.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultaTodosCobertura.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirSeguros.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTransfereCobertura.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarSeguros.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarCobertura.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            btnConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            panelConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            btnConsultarPorData.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            btnConsultarporDataCobertura.BackColor = Properties.Settings.Default.myColor;
            panelConsultarporDataCobertura.BackColor = Properties.Settings.Default.myColor;
            btnConsultarporDataCobertura.ForeColor = Properties.Settings.Default.myColorFonteMenu;
        }

        private void panelConsultarPorData_MouseLeave(object sender, EventArgs e)
        {
            panelConsultarPorData.Visible = false;
        }

        private void panelConsultarporDataCobertura_MouseLeave(object sender, EventArgs e)
        {
            panelConsultarporDataCobertura.Visible = false;
        }

        private void lblCancelarCobertura_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar manipulação de dados?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cbTipoCobertura.SelectedItem = cbTipoCobertura.Items[0];
                cbSeguro.SelectedItem = cbSeguro.Items[0];
                txtCoberturaDescricao.Text = "";

                btnCadastrarCobertura.Visible = true;
                lblCancelarCobertura.Visible = false;
                btnAlterarCobertura.Enabled = false;
                btnExcluirCobertura.Enabled = false;

                SeguroCobertura = null;
            }
        }

        private void TextPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Seguro> seguros = _seguroController.Pesquisar(textPesquisar.Text);

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

                    if (seguro.Franquia != "")
                    {
                        dt.Rows.Add(seguro.NumeroApolice, seguro.CNPJ, seguro.Tipo.ToString(), seguro.ItemSegurado, seguro.Valor, seguro.DataInicio, seguro.FimVigencia,
                               seguro.Franquia, seguro.ValorFranquia);
                    }
                    else
                    {
                        dt.Rows.Add(seguro.NumeroApolice, seguro.CNPJ, seguro.Tipo.ToString(), seguro.ItemSegurado, seguro.Valor, seguro.DataInicio, seguro.FimVigencia);
                    }
                }
                ListaSeguros = seguros;
                dgSegurosConsulta.DataSource = dt;

            }
            catch (ConcorrenciaBancoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
