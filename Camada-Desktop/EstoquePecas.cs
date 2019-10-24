using CamadaControle.Controllers;
using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
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
        private EstoquePeca EstoquePeca;

        public EstoquePecas()
        {
            InitializeComponent();
            _estoquePecasController = InstanciarCamadas();
            EstoquePeca = null;
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
                        dt.Columns.Add("Valor", typeof(double));
                        dt.Columns.Add("Quantidade", typeof(int));
                        dt.Columns.Add("Descrição", typeof(string));

                        dt.Rows.Add(estoquePeca.Id, estoquePeca.ValorUnit, estoquePeca.Quantidade, estoquePeca.Descricao);

                        dgEstoqueConsulta.DataSource = dt;

                        EstoquePeca = estoquePeca;
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
            try
            {
                List<EstoquePeca> pecas = _estoquePecasController.BuscarTodos();

                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Valor", typeof(double));
                dt.Columns.Add("Quantidade", typeof(int));
                dt.Columns.Add("Descrição", typeof(string));

                foreach (EstoquePeca estoquePeca in pecas)
                {
                    dt.Rows.Add(estoquePeca.Id, estoquePeca.ValorUnit, estoquePeca.Quantidade, estoquePeca.Descricao);
                }

                dgEstoqueConsulta.DataSource = dt;

            }
            catch (ConcorrenciaBancoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                }
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
        }
    }
}
