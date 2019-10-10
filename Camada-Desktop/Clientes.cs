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
    public partial class Clientes : Form
    {
        private readonly ClienteController _clienteController;
        private Cliente Cliente;

        public Clientes()
        {
            InitializeComponent();
            _clienteController = InstanciarCamadas();
            Cliente = null;
        }

        private ClienteController InstanciarCamadas()
        {
            Banco banco = new Banco();
            ClienteDAL clienteDAL = new ClienteDAL(banco);
            ClienteService clienteService = new ClienteService(clienteDAL);
            return new ClienteController(clienteService);
        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCPF.Text == "" || txtCPF.Text.Length < 12 || txtRG.Text == "" || txtTelefone.Text == "" || txtEndereço.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Preencha os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string[] strings = new string[] { ".", "/", "-", ",", "(", ")", " " };

                string cpf = txtCPF.Text;
                string Telefone = txtTelefone.Text;

                foreach (string str in strings) //limpando as strings
                {
                    cpf = cpf.Replace(str, "");
                    Telefone = Telefone.Replace(str, "");
                }

                long telefone = long.Parse(Telefone);
                DateTime dtinico = DateTime.Today;


                Cliente cliente = new Cliente(cpf, txtNome.Text, txtRG.Text, txtEndereço.Text, telefone, txtemail.Text, dtDataNascimento.Value, dtinico);

                try
                {
                    if (_clienteController.Cadastrar(cliente, cpf))
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
