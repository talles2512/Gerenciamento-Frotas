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
    public partial class EstoquePecas : Form
    {
        private readonly EstoquePecasController _estoquePecasController;
        private List<EstoquePeca> ListaEstoquePecas;
        private EstoquePeca EstoquePeca;
        PerfilAcesso PerfilAcesso;

        public EstoquePecas()
        {
            InitializeComponent();
            _estoquePecasController = InstanciarCamadas();
            EstoquePeca = null;
        }

        public EstoquePecas(PerfilAcesso perfilAcesso)
        {
            InitializeComponent();
            _estoquePecasController = InstanciarCamadas();
            EstoquePeca = null;
            PerfilAcesso = perfilAcesso;
        }

        private EstoquePecasController InstanciarCamadas()
        {
            Banco banco = new Banco();
            EstoquePecasDAL estoquePecasDAL = new EstoquePecasDAL(banco);
            EstoquePecasService estoquePecasService = new EstoquePecasService(estoquePecasDAL);
            return new EstoquePecasController(estoquePecasService);
        }

        private void EstoquePecas_Load(object sender, EventArgs e)
        {
            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
            {
                pbpermissao.Visible = true;
                toolTipPermissao.SetToolTip(this.pbpermissao, "Sem permissão para realizar essa ação!\nPara mais detalhes consulte seu Administrador.");
                toolTipPermissao.Hide(pbpermissao);
            }

            toolTipTransfere.SetToolTip(this.btnTrasferirEstoque, "Transferir Dados");
            toolTipTransfere.Hide(btnTrasferirEstoque);
            txtid.Text = _estoquePecasController.PopulaID().ToString();
            AtualizarCor();
        }

        private void btnCadastrarEstoque_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "" || txtDesc.Text == "" || nudQuantidade.Value <= 0)
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id = int.Parse(txtid.Text);
                double valor = double.Parse(txtValor.Text);
                int qtd = Convert.ToInt32(nudQuantidade.Value);
                EstoquePeca estoquePeca = new EstoquePeca(id, txtDesc.Text, valor, qtd);
                try
                {
                    if (_estoquePecasController.Cadastrar(estoquePeca, id))
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso!");
                        txtValor.Text = "";
                        txtDesc.Text = "";
                        nudQuantidade.Value = 0;
                        txtid.Text = _estoquePecasController.PopulaID().ToString();
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

        private void btnConsultarEstoque_Click(object sender, EventArgs e)
        {
            if (txtIDEstoqueConsulta.Text == "")
            {
                MessageBox.Show("Preencha o campo do Identificador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int id = int.Parse(txtIDEstoqueConsulta.Text);
                    EstoquePeca estoquePeca = _estoquePecasController.BuscarEstoquePecas(id);
                    if (estoquePeca == null)
                    {
                        MessageBox.Show("Não existe cadastro com esse Identificador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("ID", typeof(int));
                        dt.Columns.Add("Descrição", typeof(string));
                        dt.Columns.Add("Valor", typeof(double));
                        dt.Columns.Add("Quantidade", typeof(int));

                        dt.Rows.Add(estoquePeca.Id, estoquePeca.Descricao, estoquePeca.ValorUnit, estoquePeca.Quantidade);

                        dgEstoqueConsulta.DataSource = dt;

                        EstoquePeca = estoquePeca;
                        ListaEstoquePecas = new List<EstoquePeca>();
                        ListaEstoquePecas.Add(estoquePeca);
                        estoquePeca = null;
                    }

                }
                catch (ConcorrenciaBancoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnTodosEstoque_Click(object sender, EventArgs e)
        {
            panelConsultarPorData.Visible = true;
        }

        private void btnConsultarPorData_Click_1(object sender, EventArgs e)
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
                        List<EstoquePeca> pecas = _estoquePecasController.BuscarTodos(dtInicioConsulta.Value, dtFimConsulta.Value);

                        DataTable dt = new DataTable();
                        dt.Columns.Add("ID", typeof(int));
                        dt.Columns.Add("Descrição", typeof(string));
                        dt.Columns.Add("Valor", typeof(double));
                        dt.Columns.Add("Quantidade", typeof(int));


                        foreach (EstoquePeca estoquePeca in pecas)
                        {
                            dt.Rows.Add(estoquePeca.Id, estoquePeca.Descricao, estoquePeca.ValorUnit, estoquePeca.Quantidade);
                        }
                        dgEstoqueConsulta.DataSource = dt;

                    }
                    catch (ConcorrenciaBancoException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }           
        }

        private void btnTrasferirEstoque_Click(object sender, EventArgs e)
        {
            if (EstoquePeca == null)
            {
                MessageBox.Show("Use a função Consultar antes de realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtid.Text = EstoquePeca.Id.ToString();
                txtValor.Text = EstoquePeca.ValorUnit.ToString();
                nudQuantidade.Value = EstoquePeca.Quantidade;
                txtDesc.Text = EstoquePeca.Descricao;

                MessageBox.Show("Dados enviados para a Tela de Cadastro.");

                tbControlEstoque.SelectTab("tbPageCadastroEstoque");
                if (tbControlEstoque.SelectedTab == tbPageCadastroEstoque)
                {
                    EstoquePeca = null;
                    txtIDEstoqueConsulta.Text = "";

                    btnCadastrarEstoque.Visible = false;
                    lblCancelar.Visible = true;
                    btnAlterarEstoque.Enabled = true;
                    btnExcluirEstoque.Enabled = true;

                    if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                    {
                        btnExcluirEstoque.Enabled = false;
                    }
                    else
                    {
                        btnExcluirEstoque.Enabled = true;
                    }
                }
            }
        }

        private void dgEstoqueConsulta_DoubleClick(object sender, EventArgs e)
        {
            if (dgEstoqueConsulta.DataSource == null)
            {

            }
            else if (dgEstoqueConsulta.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Selecione uma linha válida!");
            }
            else
            {
                int id = int.Parse(dgEstoqueConsulta.CurrentRow.Cells[0].Value.ToString());

                foreach (EstoquePeca estoquePeca in ListaEstoquePecas)
                {
                    if (estoquePeca.Id == id)
                    {
                        txtid.Text = estoquePeca.Id.ToString();
                        txtValor.Text = estoquePeca.ValorUnit.ToString();
                        nudQuantidade.Value = estoquePeca.Quantidade;
                        txtDesc.Text = estoquePeca.Descricao;

                        MessageBox.Show("Dados enviados para a Tela de Cadastro.");

                        tbControlEstoque.SelectTab("tbPageCadastroEstoque");
                        if (tbControlEstoque.SelectedTab == tbPageCadastroEstoque)
                        {
                            EstoquePeca = null;
                            txtIDEstoqueConsulta.Text = "";

                            btnCadastrarEstoque.Visible = false;
                            lblCancelar.Visible = true;
                            btnAlterarEstoque.Enabled = true;

                            if (PerfilAcesso == PerfilAcesso.Atendimento || PerfilAcesso == PerfilAcesso.Operacional)
                            {
                                btnExcluirEstoque.Enabled = false;
                            }
                            else
                            {
                                btnExcluirEstoque.Enabled = true;
                            }
                        }
                    }
                }
                textPesquisar.Text = "";
                dgEstoqueConsulta.DataSource = null;
            }
        }

        private void btnAlterarEstoque_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "" || txtDesc.Text == "" || nudQuantidade.Value <= 0)
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id = int.Parse(txtid.Text);
                double valor = double.Parse(txtValor.Text);
                int qtd = Convert.ToInt32(nudQuantidade.Value);
                EstoquePeca estoquePeca = new EstoquePeca(id, txtDesc.Text, valor, qtd);
                try
                {
                    if (_estoquePecasController.Alterar(estoquePeca, id))
                    {
                        MessageBox.Show("Alteração realizada com Sucesso!");
                        txtValor.Text = "";
                        txtDesc.Text = "";
                        nudQuantidade.Value = 0;
                        txtid.Text = _estoquePecasController.PopulaID().ToString();

                        btnCadastrarEstoque.Visible = true;
                        lblCancelar.Visible = false;
                        btnAlterarEstoque.Enabled = false;
                        btnExcluirEstoque.Enabled = false;
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

        private void btnExcluirEstoque_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Identificador incorreto para realizar esta operação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = int.Parse(txtid.Text);
                        if (_estoquePecasController.Deletar(id))
                        {
                            MessageBox.Show("Exclusão realizada com Sucesso!");
                            txtValor.Text = "";
                            txtDesc.Text = "";
                            nudQuantidade.Value = 0;
                            txtid.Text = _estoquePecasController.PopulaID().ToString();

                            btnCadastrarEstoque.Visible = true;
                            lblCancelar.Visible = false;
                            btnAlterarEstoque.Enabled = false;
                            btnExcluirEstoque.Enabled = false;
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

        public void AtualizarCor()
        {
            this.BackColor = Properties.Settings.Default.myColorFundo;

            btnCadastrarEstoque.BackColor = Properties.Settings.Default.myColor;
            btnConsultarEstoque.BackColor = Properties.Settings.Default.myColor;
            btnTodosEstoque.BackColor = Properties.Settings.Default.myColor;
            btnTrasferirEstoque.BackColor = Properties.Settings.Default.myColor;
            btnAlterarEstoque.BackColor = Properties.Settings.Default.myColor;

            btnCadastrarEstoque.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnConsultarEstoque.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTodosEstoque.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnTrasferirEstoque.ForeColor = Properties.Settings.Default.myColorFonteMenu;
            btnAlterarEstoque.ForeColor = Properties.Settings.Default.myColorFonteMenu;

            btnConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            panelConsultarPorData.BackColor = Properties.Settings.Default.myColor;
            btnConsultarPorData.ForeColor = Properties.Settings.Default.myColorFonteMenu;
        }

        private void btnConsultarPorData_Click(object sender, EventArgs e)
        {

        }

        private void panelConsultarPorData_MouseLeave(object sender, EventArgs e)
        {
            panelConsultarPorData.Visible = false;
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar manipulação de dados?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtValor.Text = "";
                txtDesc.Text = "";
                nudQuantidade.Value = 0;
                txtid.Text = _estoquePecasController.PopulaID().ToString();

                btnCadastrarEstoque.Visible = true;
                lblCancelar.Visible = false;
                btnAlterarEstoque.Enabled = false;
                btnExcluirEstoque.Enabled = false;

                EstoquePeca = null;
            }
        }

        private void TextPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<EstoquePeca> estoquePecas = _estoquePecasController.Pesquisar(textPesquisar.Text);

                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Descrição", typeof(string));
                dt.Columns.Add("Valor", typeof(double));
                dt.Columns.Add("Quantidade", typeof(int));


                foreach (EstoquePeca estoquePeca in estoquePecas)
                {
                    dt.Rows.Add(estoquePeca.Id, estoquePeca.Descricao, estoquePeca.ValorUnit, estoquePeca.Quantidade);
                }
                ListaEstoquePecas = estoquePecas;
                dgEstoqueConsulta.DataSource = dt;

            }
            catch (ConcorrenciaBancoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
