using CamadaControle.Controllers;
using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaDesktop
{
    public partial class Sinistros : Form
    {
        private readonly SinistroController _sinistroController;
        private readonly SeguroController _seguroController;
        private List<Sinistro> ListaSinistros;
        private Sinistro Sinistro;
        private Seguro Seguro;
        string itemseguradoantigo;
        DateTime datahoraantigo;
        long numapoliceantigo;
        string tipoantigo;
        PerfilAcesso PerfilAcesso;

        public Sinistros()
        {
            InitializeComponent();
            _sinistroController = InstanciarCamadas1();
            _seguroController = InstanciarCamadas2();
            Sinistro = null;
            Seguro = null;
            numapoliceantigo = 0;
            itemseguradoantigo = "";
            tipoantigo = "";
        }

        public Sinistros(PerfilAcesso perfilAcesso)
        {
            InitializeComponent();
            _sinistroController = InstanciarCamadas1();
            _seguroController = InstanciarCamadas2();
            Sinistro = null;
            Seguro = null;
            numapoliceantigo = 0;
            itemseguradoantigo = "";
            tipoantigo = "";
            PerfilAcesso = perfilAcesso;
        }

        private SinistroController InstanciarCamadas1()
        {
            Banco banco = new Banco();
            SinistroDAL sinistroDAL = new SinistroDAL(banco);
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            SinistroService sinistroService = new SinistroService(sinistroDAL);
            return new SinistroController(sinistroService);
        }

        private SeguroController InstanciarCamadas2()
        {
            Banco banco = new Banco();
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            SeguroService seguroService = new SeguroService(seguroDAL);
            return new SeguroController(seguroService);
        }

        private void Sinistros_Load(object sender, EventArgs e)
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

            cbItemSegurado.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbItemSegurado.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbSeguro.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSeguro.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbTipo.DataSource = Enum.GetValues(typeof(ItemSegurado));
            cbTipoConsulta.DataSource = Enum.GetValues(typeof(ItemSegurado));
            toolTipTransfere.SetToolTip(this.btnTrasferirSinistros, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirSinistros);

            AtualizarCor();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTipo.SelectedItem.ToString() == "Veiculo")
                {
                    lblItemSegurado.Text = "Veículo - Placa:";
                    cbItemSegurado.DataSource = _sinistroController.PopularPlacas();
                    cbItemSegurado.DisplayMember = "MODELO";
                    cbItemSegurado.ValueMember = "VCL_PLACA";
                    txtid.Text = _sinistroController.PopularID(cbTipo.SelectedItem.ToString()).ToString();
                    cbSeguro.Text = "";
                }
                else if (cbTipo.SelectedItem.ToString() == "Motorista")
                {
                    lblItemSegurado.Text = "Motorista - CPF:";
                    cbItemSegurado.DataSource = _sinistroController.PopularCPFs();
                    cbItemSegurado.DisplayMember = "MOTORISTA";
                    cbItemSegurado.ValueMember = "MT_CPF";
                    txtid.Text = _sinistroController.PopularID(cbTipo.SelectedItem.ToString()).ToString();
                    cbSeguro.Text = "";
                }
            }
            catch (ConcorrenciaBancoException)
            {
                cbItemSegurado.DataSource = null;
            }
        }

        private void cbItemSegurado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTipo.SelectedItem.ToString() == "Veiculo")
                {
                    if(cbItemSegurado.Items.Count < 1)
                    {
                        MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string placa = cbItemSegurado.SelectedValue.ToString();
                        cbSeguro.DataSource = _sinistroController.PopularSeguroPlacas(placa);
                        cbSeguro.DisplayMember = "APOLICE";
                        cbSeguro.ValueMember = "SEG_NUMAPOLICE";
                    }
                }
                else if (cbTipo.SelectedItem.ToString() == "Motorista")
                {
                    if (cbItemSegurado.Items.Count < 1)
                    {
                        MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string cpf = cbItemSegurado.SelectedValue.ToString();
                        cbSeguro.DataSource = _sinistroController.PopularSeguroCPFs(cpf);
                        cbSeguro.DisplayMember = "APOLICE";
                        cbSeguro.ValueMember = "SEG_NUMAPOLICE";
                    }
                }
            }
            catch (ConcorrenciaBancoException)
            {
                cbItemSegurado.DataSource = null;
            }
        }

        private void btnCadastrarSinistros_Click(object sender, EventArgs e)
        {
            if (cbSeguro.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um seguro antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtDesc.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (cbTipo.SelectedItem.ToString() == "Veiculo")
            {
                if (cbItemSegurado.Items.Count < 1)
                {
                    MessageBox.Show("Cadastre um veiculo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TipoSeguro tipoSeguro = TipoSeguro.Automóvel;
                    string itemsegurado = cbItemSegurado.SelectedValue.ToString();
                    int id = int.Parse(txtid.Text);
                    long seg = long.Parse(cbSeguro.SelectedValue.ToString());

                    Seguro seguro = _seguroController.BuscarSeguro(tipoSeguro, seg);
                    long numapolice = Convert.ToInt64(seguro.NumeroApolice);
                    Sinistro sinistro = new Sinistro(id, itemsegurado, txtDesc.Text, dtDataSinistro.Value, seguro);

                    try
                    {
                        if (_sinistroController.Cadastrar(sinistro, id, dtDataSinistro.Value, sinistro.Item, numapolice, cbTipo.SelectedValue.ToString()))
                        {
                            MessageBox.Show("Cadastro realizado com Sucesso!");
                            txtid.Text = _sinistroController.PopularID(cbTipo.SelectedItem.ToString()).ToString();
                            txtDesc.Text = "";
                            cbSeguro.Text = "";
                            cbTipo.Text = "";
                            cbItemSegurado.Text = "";
                            dtDataSinistro.Text = "";
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

            if (cbTipo.SelectedItem.ToString() == "Motorista")
            {
                if (cbItemSegurado.Items.Count < 1)
                {
                    MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TipoSeguro tipoSeguro = TipoSeguro.Vida;
                    //ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipo.SelectedItem.ToString());
                    string itemsegurado = cbItemSegurado.SelectedValue.ToString();
                    int id = int.Parse(txtid.Text);
                    long seg = long.Parse(cbSeguro.SelectedValue.ToString());

                    Seguro seguro = _sinistroController.BuscarSeguro(tipoSeguro, seg);
                    long numapolice = Convert.ToInt64(seguro.NumeroApolice);

                    Sinistro sinistro = new Sinistro(id, itemsegurado, txtDesc.Text, dtDataSinistro.Value, seguro);
                    try
                    {
                        if ( _sinistroController.Cadastrar(sinistro, id, dtDataSinistro.Value, sinistro.Item, numapolice, cbTipo.SelectedValue.ToString()))
                        {
                            MessageBox.Show("Cadastro realizado com Sucesso!");
                            txtid.Text = _sinistroController.PopularID(cbTipo.SelectedItem.ToString()).ToString();
                            txtDesc.Text = "";
                            cbSeguro.Text = "";
                            cbTipo.Text = "";
                            cbItemSegurado.Text = "";
                            dtDataSinistro.Text = "";
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

        private void btnConsultarSinistros_Click(object sender, EventArgs e)
        {
            if (txtIDSinistrosConsulta.Text == "")
            {
                MessageBox.Show("Preencha o campo do Identificador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cbTipo.SelectedItem.ToString() == "Veiculo")
                {
                    try
                    {
                        int id = int.Parse(txtIDSinistrosConsulta.Text);
                        //ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipoConsulta.SelectedItem.ToString());
                        string itemsegurado = cbItemSegurado.SelectedValue.ToString();

                        Sinistro sinistro = _sinistroController.BuscarSinistro(id, dtDataSinistroConsulta.Value, itemsegurado, cbTipo.SelectedValue.ToString());
                        if (sinistro == null)
                        {
                            MessageBox.Show("Não existe cadastro com esse Identificador,Data e Tipo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("ID", typeof(int));
                            dt.Columns.Add("Item Segurado - Placa", typeof(string));
                            dt.Columns.Add("Nº Apólice", typeof(long));
                            dt.Columns.Add("Data/Hora", typeof(DateTime));
                            dt.Columns.Add("Descrição", typeof(string));

                            dt.Rows.Add(sinistro.Id, sinistro.Item, sinistro.Seguro.NumeroApolice, sinistro.DataHora, sinistro.Descricao);

                            dgSinistrosConsulta.DataSource = dt;
                        }
                        Sinistro = sinistro;
                        ListaSinistros = new List<Sinistro>();
                        ListaSinistros.Add(sinistro);
                        sinistro = null;
                    }
                    catch (ConcorrenciaBancoException)
                    {
                        throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                    }
                }
                else
                {
                    try
                    {
                        int id = int.Parse(txtIDSinistrosConsulta.Text);
                        //ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipoConsulta.SelectedItem.ToString());
                        string itemsegurado = cbItemSegurado.SelectedValue.ToString();

                        Sinistro sinistro = _sinistroController.BuscarSinistro(id, dtDataSinistroConsulta.Value, itemsegurado, cbTipo.SelectedValue.ToString());
                        if (sinistro == null)
                        {
                            MessageBox.Show("Não existe cadastro com esse Identificador,Data e Tipo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("ID", typeof(int));
                            dt.Columns.Add("Item Segurado - CPF", typeof(string));
                            dt.Columns.Add("Nº Apólice", typeof(long));
                            dt.Columns.Add("Data/Hora", typeof(DateTime));
                            dt.Columns.Add("Descrição", typeof(string));

                            dt.Rows.Add(sinistro.Id, sinistro.Item, sinistro.Seguro.NumeroApolice, sinistro.DataHora, sinistro.Descricao);

                            dgSinistrosConsulta.DataSource = dt;
                        }
                        Sinistro = sinistro;
                        sinistro = null;
                    }
                    catch (ConcorrenciaBancoException)
                    {
                        throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                    }
                }
            }
        }

        private void btnTodosSinistros_Click(object sender, EventArgs e)
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
                    string tipo;
                    if (cbTipoConsulta.SelectedItem.ToString() == "")
                    {
                        MessageBox.Show("Selecione tipo para realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (cbTipoConsulta.SelectedValue.ToString() == "Veiculo")
                        {
                            tipo = "Veiculo";

                            try
                            {
                                List<Sinistro> sinistros = _sinistroController.BuscarTodos(tipo, dtInicioConsulta.Value, dtFimConsulta.Value);

                                DataTable dt = new DataTable();
                                dt.Columns.Add("ID", typeof(int));
                                dt.Columns.Add("Item Segurado - Placa", typeof(string));
                                dt.Columns.Add("Nº Apólice", typeof(long));
                                dt.Columns.Add("Data/Hora", typeof(DateTime));
                                dt.Columns.Add("Descrição", typeof(string));

                                foreach (Sinistro sinistro in sinistros)
                                {

                                    dt.Rows.Add(sinistro.Id, sinistro.Item, sinistro.Seguro.NumeroApolice, sinistro.DataHora, sinistro.Descricao);
                                }
                                ListaSinistros = sinistros;
                                dgSinistrosConsulta.DataSource = dt;

                            }
                            catch (ConcorrenciaBancoException)
                            {
                                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                            }
                        }
                        else
                        {
                            tipo = "Motorista";

                            try
                            {
                                List<Sinistro> sinistros = _sinistroController.BuscarTodos(tipo, dtInicioConsulta.Value, dtFimConsulta.Value);

                                DataTable dt = new DataTable();
                                dt.Columns.Add("ID", typeof(int));
                                dt.Columns.Add("Item Segurado - CPF", typeof(string));
                                dt.Columns.Add("Nº Apólice", typeof(long));
                                dt.Columns.Add("Data/Hora", typeof(DateTime));
                                dt.Columns.Add("Descrição", typeof(string));

                                foreach (Sinistro sinistro in sinistros)
                                {

                                    dt.Rows.Add(sinistro.Id, sinistro.Item, sinistro.Seguro.NumeroApolice, sinistro.DataHora, sinistro.Descricao);
                                }
                                ListaSinistros = sinistros;
                                dgSinistrosConsulta.DataSource = dt;

                            }
                            catch (ConcorrenciaBancoException)
                            {
                                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
                            }
                        }
                    }
                }
            }                  
        }

        private void btnTrasferirSinistros_Click(object sender, EventArgs e)
        {
            if (Sinistro == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id = int.Parse(Sinistro.Id.ToString());
                if (cbTipoConsulta.SelectedValue.ToString() == "Veiculo")
                {
                    cbTipo.Text = "Veiculo";
                }
                else
                {
                    cbTipo.Text = "Motorista";
                }
                    
                itemseguradoantigo = cbTipoConsulta.SelectedItem.ToString();
                numapoliceantigo = Sinistro.Seguro.NumeroApolice;
                tipoantigo = cbTipoConsulta.SelectedValue.ToString();
                cbItemSegurado.SelectedValue = Sinistro.Item;

                if (cbTipo.SelectedItem.ToString() == "Veiculo")
                {
                    if (cbItemSegurado.Items.Count < 1)
                    {
                        MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string placa = cbItemSegurado.SelectedValue.ToString();
                        cbSeguro.DataSource = _sinistroController.PopularSeguroPlacas(placa);
                        cbSeguro.DisplayMember = "APOLICE";
                        cbSeguro.ValueMember = "SEG_NUMAPOLICE";
                    }
                }
                else if (cbTipo.SelectedItem.ToString() == "Motorista")
                {
                    if (cbItemSegurado.Items.Count < 1)
                    {
                        MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string cpf = cbItemSegurado.SelectedValue.ToString();
                        cbSeguro.DataSource = _sinistroController.PopularSeguroCPFs(cpf);
                        cbSeguro.DisplayMember = "APOLICE";
                        cbSeguro.ValueMember = "SEG_NUMAPOLICE";
                    }
                }

                dtDataSinistro.Value = Sinistro.DataHora;
                datahoraantigo = Sinistro.DataHora;
                txtDesc.Text = Sinistro.Descricao;

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                tbControlSinistros.SelectTab("tbPageCadastroSinistros");
                if (tbControlSinistros.SelectedTab == tbPageCadastroSinistros)
                {
                    txtIDSinistrosConsulta.Text = "";
                    dtDataSinistroConsulta.Text = "";
                    cbTipoConsulta.Text = "";
                    Sinistro = null;
                    txtid.Text = id.ToString();

                    btnCadastrarSinistros.Visible = false;
                    lblCancelar.Visible = true;
                    btnAlterarSinistros.Enabled = true;
                    
                    if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                    {
                        btnExcluirSinistros.Enabled = false;
                    }
                    else
                    {
                        btnExcluirSinistros.Enabled = true;
                    }
                }
            }
        }

        private void DgSinistrosConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgSinistrosConsulta.DataSource == null)
            {

            }
            else if (dgSinistrosConsulta.CurrentRow.Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                string itemSegurado = dgSinistrosConsulta.CurrentRow.Cells[1].Value.ToString();

                foreach (Sinistro sinistro in ListaSinistros)
                {
                    if (sinistro.Item == itemSegurado)
                    {
                        int id = int.Parse(sinistro.Id.ToString());
                        if (cbTipoConsulta.SelectedValue.ToString() == "Veiculo")
                        {
                            cbTipo.Text = "Veiculo";
                        }
                        else
                        {
                            cbTipo.Text = "Motorista";
                        }

                        itemseguradoantigo = cbTipoConsulta.SelectedItem.ToString();
                        numapoliceantigo = sinistro.Seguro.NumeroApolice;
                        tipoantigo = cbTipoConsulta.SelectedValue.ToString();
                        cbItemSegurado.SelectedValue = sinistro.Item;

                        if (cbTipo.SelectedItem.ToString() == "Veiculo")
                        {
                            if (cbItemSegurado.Items.Count < 1)
                            {
                                MessageBox.Show("Cadastre um veículo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                string placa = cbItemSegurado.SelectedValue.ToString();
                                cbSeguro.DataSource = _sinistroController.PopularSeguroPlacas(placa);
                                cbSeguro.DisplayMember = "APOLICE";
                                cbSeguro.ValueMember = "SEG_NUMAPOLICE";
                            }
                        }
                        else if (cbTipo.SelectedItem.ToString() == "Motorista")
                        {
                            if (cbItemSegurado.Items.Count < 1)
                            {
                                MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                string cpf = cbItemSegurado.SelectedValue.ToString();
                                cbSeguro.DataSource = _sinistroController.PopularSeguroCPFs(cpf);
                                cbSeguro.DisplayMember = "APOLICE";
                                cbSeguro.ValueMember = "SEG_NUMAPOLICE";
                            }
                        }

                        dtDataSinistro.Value = sinistro.DataHora;
                        datahoraantigo = sinistro.DataHora;
                        txtDesc.Text = sinistro.Descricao;

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");
                        tbControlSinistros.SelectTab("tbPageCadastroSinistros");
                        if (tbControlSinistros.SelectedTab == tbPageCadastroSinistros)
                        {
                            txtIDSinistrosConsulta.Text = "";
                            dtDataSinistroConsulta.Text = "";
                            cbTipoConsulta.Text = "";
                            Sinistro = null;
                            txtid.Text = id.ToString();

                            btnCadastrarSinistros.Visible = false;
                            lblCancelar.Visible = true;
                            btnAlterarSinistros.Enabled = true;

                            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                            {
                                btnExcluirSinistros.Enabled = false;
                            }
                            else
                            {
                                btnExcluirSinistros.Enabled = true;
                            }
                        }
                    }
                }
                dgSinistrosConsulta.DataSource = null;
            }
        }

        private void btnAlterarSinistros_Click(object sender, EventArgs e)
        {
            if (cbSeguro.Items.Count < 1)
            {
                MessageBox.Show("Cadastre um seguro antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtDesc.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (cbTipo.SelectedItem.ToString() == "Veiculo")
            {
                if (cbItemSegurado.Items.Count < 1)
                {
                    MessageBox.Show("Cadastre um veiculo antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TipoSeguro tipoSeguro = TipoSeguro.Automóvel;
                    //ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipo.SelectedItem.ToString());
                    string itemsegurado = cbItemSegurado.SelectedValue.ToString();
                    int id = int.Parse(txtid.Text);
                    long seg = long.Parse(cbSeguro.SelectedValue.ToString());

                    Seguro seguro = _seguroController.BuscarSeguro(tipoSeguro, seg);
                    long numapolice = Convert.ToInt64(seguro.NumeroApolice);
                    Sinistro sinistro = new Sinistro(id, itemsegurado, txtDesc.Text, dtDataSinistro.Value, seguro);

                    try
                    {
                        if (_sinistroController.Alterar(sinistro, id, itemseguradoantigo, datahoraantigo,  numapoliceantigo, tipoantigo))
                        {
                            MessageBox.Show("Alteração realizada com Sucesso!");
                            txtid.Text = _sinistroController.PopularID(cbTipo.SelectedItem.ToString()).ToString();
                            txtDesc.Text = "";
                            tipoantigo = "";

                            cbSeguro.SelectedItem = cbSeguro.Items[0];
                            cbTipo.SelectedItem = cbTipo.Items[0];
                            cbItemSegurado.SelectedItem = cbItemSegurado.Items[0];
                            dtDataSinistro.Text = "";

                            btnCadastrarSinistros.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarSinistros.Enabled = false;
                            btnExcluirSinistros.Enabled = false;
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

            if (cbTipo.SelectedItem.ToString() == "Motorista")
            {
                if (cbItemSegurado.Items.Count < 1)
                {
                    MessageBox.Show("Cadastre um motorista antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TipoSeguro tipoSeguro = TipoSeguro.Vida;
                    //ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipo.SelectedItem.ToString());
                    string itemsegurado = cbItemSegurado.SelectedValue.ToString();
                    int id = int.Parse(txtid.Text);
                    long seg = long.Parse(cbSeguro.SelectedValue.ToString());

                    Seguro seguro = _sinistroController.BuscarSeguro(tipoSeguro, seg);
                    long numapolice = Convert.ToInt64(seguro.NumeroApolice);

                    Sinistro sinistro = new Sinistro(id, itemsegurado, txtDesc.Text, dtDataSinistro.Value, seguro);
                    try
                    {
                        if (_sinistroController.Alterar(sinistro, id, itemseguradoantigo, datahoraantigo, numapoliceantigo, tipoantigo))
                        {
                            MessageBox.Show("Alteração realizada com Sucesso!");
                            txtid.Text = _sinistroController.PopularID(cbTipo.SelectedItem.ToString()).ToString();
                            txtDesc.Text = "";
                            tipoantigo = "";

                            cbSeguro.SelectedItem = cbSeguro.Items[0];
                            cbTipo.SelectedItem = cbTipo.Items[0];
                            cbItemSegurado.SelectedItem = cbItemSegurado.Items[0];
                            dtDataSinistro.Text = "";

                            btnCadastrarSinistros.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarSinistros.Enabled = false;
                            btnExcluirSinistros.Enabled = false;
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

        private void btnExcluirSinistros_Click(object sender, EventArgs e)
        {
            TipoSeguro tipoSeguro;
            try
            {
                if(cbTipo.Text == "Veiculo")
                {
                    tipoSeguro = TipoSeguro.Automóvel;
                }
                else
                {
                    tipoSeguro = TipoSeguro.Vida;
                }
                
                //ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipo.SelectedItem.ToString());
                string itemsegurado = cbItemSegurado.SelectedValue.ToString();
                int id = int.Parse(txtid.Text);
                long seg = long.Parse(cbSeguro.SelectedValue.ToString());

                Seguro seguro = _sinistroController.BuscarSeguro(tipoSeguro, seg);
                long numapolice = Convert.ToInt64(seguro.NumeroApolice);

                Sinistro sinistro = new Sinistro(id, itemsegurado, txtDesc.Text, dtDataSinistro.Value, seguro);


                    if (MessageBox.Show("Deseja realmente excluir?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_sinistroController.Deletar(sinistro, id, datahoraantigo, tipoantigo))
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");
                            txtid.Text = _sinistroController.PopularID(cbTipo.SelectedItem.ToString()).ToString();
                            txtDesc.Text = "";
                            tipoantigo = "";

                            cbSeguro.SelectedItem = cbSeguro.Items[0];
                            cbTipo.SelectedItem = cbTipo.Items[0];
                            cbItemSegurado.SelectedItem = cbItemSegurado.Items[0];
                            dtDataSinistro.Value = DateTime.Now;

                            btnCadastrarSinistros.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarSinistros.Enabled = false;
                            btnExcluirSinistros.Enabled = false;
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

        public void AtualizarCor()
        {
            this.BackColor = Properties.Settings.Default.myColorFundo;

            btnCadastrarSinistros.BackColor = Properties.Settings.Default.myColor;
            btnConsultarSinistros.BackColor = Properties.Settings.Default.myColor;
            btnTodosSinistros.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirSinistros.BackColor = Properties.Settings.Default.myColor;
            btnAlterarSinistros.BackColor = Properties.Settings.Default.myColor;

            btnCadastrarSinistros.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarSinistros.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodosSinistros.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirSinistros.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarSinistros.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            btnConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            panelConsultarPorData.BackColor = Properties.Settings.Default.myColor;
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
                txtDesc.Text = "";
                cbSeguro.SelectedItem = cbSeguro.Items[0];
                cbTipo.SelectedItem = cbTipo.Items[0];
                cbItemSegurado.SelectedItem = cbItemSegurado.Items[0];
                dtDataSinistro.Text = "";

                btnCadastrarSinistros.Visible = true;
                lblCancelar.Visible = false;
                btnAlterarSinistros.Enabled = false;
                btnExcluirSinistros.Enabled = false;

                Sinistro = null;
            }
        }


    }
}

