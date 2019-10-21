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
        private Sinistro Sinistro;
        private Seguro Seguro;
        ItemSegurado itemseguradoantigo;
        DateTime datahoraantigo;
        long numapoliceantigo;


        public Sinistros()
        {
            InitializeComponent();
            _sinistroController = InstanciarCamadas1();
            _seguroController = InstanciarCamadas2();
            Sinistro = null;
            Seguro = null;
            numapoliceantigo = 0;
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
            cbTipo.DataSource = Enum.GetValues(typeof(ItemSegurado));
            cbTipoConsulta.DataSource = Enum.GetValues(typeof(ItemSegurado));
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
                    ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipo.SelectedItem.ToString());
                    int id = int.Parse(txtid.Text);
                    long seg = long.Parse(cbSeguro.SelectedValue.ToString());

                    Seguro seguro = _seguroController.BuscarSeguro(tipoSeguro, seg);
                    long numapolice = Convert.ToInt64(seguro.NumeroApolice);
                    Sinistro sinistro = new Sinistro(id, itemsegurado, txtDesc.Text, dtDataSinistro.Value, seguro);

                    try
                    {
                        if ( _sinistroController.Cadastrar(sinistro, id, dtDataSinistro.Value, sinistro.ItemSegurado, numapolice))
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
                    ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipo.SelectedItem.ToString());
                    int id = int.Parse(txtid.Text);
                    long seg = long.Parse(cbSeguro.SelectedValue.ToString());

                    Seguro seguro = _sinistroController.BuscarSeguro(tipoSeguro, seg);
                    long numapolice = Convert.ToInt64(seguro.NumeroApolice);

                    Sinistro sinistro = new Sinistro(id, itemsegurado, txtDesc.Text, dtDataSinistro.Value, seguro);
                    try
                    {
                        if ( _sinistroController.Cadastrar(sinistro, id, dtDataSinistro.Value, sinistro.ItemSegurado, numapolice))
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
                        ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipoConsulta.SelectedItem.ToString());
                        
                        Sinistro sinistro = _sinistroController.BuscarSinistro(id, dtDataSinistroConsulta.Value, itemsegurado);
                        if (sinistro == null)
                        {
                            MessageBox.Show("Não existe cadastro com esse Identificador,Data e Tipo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("ID", typeof(int));
                            dt.Columns.Add("Item Segurado", typeof(string));
                            dt.Columns.Add("Nº Apólice", typeof(long));
                            dt.Columns.Add("Data/Hora", typeof(DateTime));
                            dt.Columns.Add("Descrição", typeof(string));

                            dt.Rows.Add(sinistro.Id, sinistro.ItemSegurado, sinistro.Seguro.NumeroApolice, sinistro.DataHora, sinistro.Descricao);

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
                else
                {
                    try
                    {
                        int id = int.Parse(txtIDSinistrosConsulta.Text);
                        ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipoConsulta.SelectedItem.ToString());

                        Sinistro sinistro = _sinistroController.BuscarSinistro(id, dtDataSinistroConsulta.Value, itemsegurado);
                        if (sinistro == null)
                        {
                            MessageBox.Show("Não existe cadastro com esse Identificador,Data e Tipo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("ID", typeof(int));
                            dt.Columns.Add("Item Segurado", typeof(string));
                            dt.Columns.Add("Nº Apólice", typeof(long));
                            dt.Columns.Add("Data/Hora", typeof(DateTime));
                            dt.Columns.Add("Descrição", typeof(string));

                            dt.Rows.Add(sinistro.Id, sinistro.ItemSegurado, sinistro.Seguro.NumeroApolice, sinistro.DataHora, sinistro.Descricao);

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
            string tipo;
            if (cbTipoConsulta.SelectedItem.ToString()=="")
            {
                MessageBox.Show("Selecione tipo para realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if(cbTipoConsulta.SelectedValue.ToString() == "Veiculo")
                {
                    tipo = "Veiculo";
                }
                else
                {
                    tipo = "Motorista";
                }
                try
                {
                    List<Sinistro> sinistros = _sinistroController.BuscarTodos(tipo);

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Item Segurado", typeof(string));
                    dt.Columns.Add("Nº Apólice", typeof(long));
                    dt.Columns.Add("Data/Hora", typeof(DateTime));
                    dt.Columns.Add("Descrição", typeof(string));

                    foreach (Sinistro sinistro in sinistros)
                    {

                        dt.Rows.Add(sinistro.Id, sinistro.ItemSegurado, sinistro.Seguro.NumeroApolice, sinistro.DataHora, sinistro.Descricao);
                    }

                    dgSinistrosConsulta.DataSource = dt;

                }
                catch (ConcorrenciaBancoException)
                {
                    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
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
                cbTipo.Text = Sinistro.ItemSegurado.ToString();
                itemseguradoantigo = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), Sinistro.ItemSegurado.ToString());
                numapoliceantigo = Sinistro.Seguro.NumeroApolice;

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
                }
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
                    ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipo.SelectedItem.ToString());
                    int id = int.Parse(txtid.Text);
                    long seg = long.Parse(cbSeguro.ValueMember.ToString());

                    Seguro seguro = _seguroController.BuscarSeguro(tipoSeguro, seg);
                    long numapolice = Convert.ToInt64(seguro.NumeroApolice);
                    Sinistro sinistro = new Sinistro(id, itemsegurado, txtDesc.Text, dtDataSinistro.Value, seguro);

                    try
                    {
                        if (_sinistroController.Alterar(sinistro, id, itemseguradoantigo, datahoraantigo,  numapoliceantigo))
                        {
                            MessageBox.Show("Alteração realizada com Sucesso!");
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
                    ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipo.SelectedItem.ToString());
                    int id = int.Parse(txtid.Text);
                    long seg = long.Parse(cbSeguro.SelectedValue.ToString());

                    Seguro seguro = _sinistroController.BuscarSeguro(tipoSeguro, seg);
                    long numapolice = Convert.ToInt64(seguro.NumeroApolice);

                    Sinistro sinistro = new Sinistro(id, itemsegurado, txtDesc.Text, dtDataSinistro.Value, seguro);
                    try
                    {
                        if (_sinistroController.Alterar(sinistro, id, itemseguradoantigo, datahoraantigo, numapoliceantigo))
                        {
                            MessageBox.Show("Alteração realizada com Sucesso!");
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

        private void btnExcluirSinistros_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente inativar?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TipoSeguro tipoSeguro = TipoSeguro.Vida;
                    ItemSegurado itemsegurado = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), cbTipo.SelectedItem.ToString());
                    int id = int.Parse(txtid.Text);
                    long seg = long.Parse(cbSeguro.SelectedValue.ToString());

                    Seguro seguro = _sinistroController.BuscarSeguro(tipoSeguro, seg);
                    long numapolice = Convert.ToInt64(seguro.NumeroApolice);

                    Sinistro sinistro = new Sinistro(id, itemsegurado, txtDesc.Text, dtDataSinistro.Value, seguro);

                    if (_sinistroController.Deletar(sinistro, id, datahoraantigo))
                    {
                        if (MessageBox.Show("Deseja realmente excluir?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");
                            txtid.Text = _sinistroController.PopularID(cbTipo.SelectedItem.ToString()).ToString();
                            txtDesc.Text = "";
                            cbSeguro.Text = "";
                            cbTipo.Text = "";
                            cbItemSegurado.Text = "";
                            dtDataSinistro.Text = "";
                        }                 
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
}

