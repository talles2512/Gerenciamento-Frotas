using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Data
{
    public class ClienteDAL
    {
        private readonly Banco _banco;

        public ClienteDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(Cliente cliente)
        {
            string query = "INSERT INTO[dbo].[TB_CLIENTES]([CLT_CPF],[CLT_NOME],[CLT_RG],[CLT_ENDERECO],[CLT_TELEFONE],[CLT_EMAIL],[CLT_DTNASCIMENTO],[CLT_DTINICIO_CONTRATO])" +
                                "VALUES(" + cliente.CPF + ", '" + cliente.Nome + "', '" + cliente.RG + "', '" + cliente.Endereco + "', " + cliente.Telefone + ", '" + cliente.Email + "', '" + cliente.DataNascimento + "', '" + cliente.DataInicioContrato + "')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }

        }

        public Cliente BuscarCPF(string cpf)
        {
            string query = "SELECT * FROM [dbo].[TB_CLIENTES] WHERE [CLT_CPF] = '" + cpf + "'";

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);

                Cliente cliente = null;
                DataRow[] dataRows = dt.Select("CLT_CPF = '" + cpf + "'");
                foreach (DataRow dr in dataRows)
                {
                    DateTime dtnascimento = Convert.ToDateTime(dr["CLT_DTNASCIMENTO"].ToString());
                    DateTime dtinico = Convert.ToDateTime(dr["CLT_DTINICIO_CONTRATO"].ToString());
                    long telefone = long.Parse(dr["CLT_TELEFONE"].ToString());

                    cliente = new Cliente(dr["CLT_CPF"].ToString(), dr["CLT_NOME"].ToString(), dr["CLT_RG"].ToString(), dr["CLT_ENDERECO"].ToString(), telefone, dr["CLT_EMAIL"].ToString(), dtnascimento, dtinico);
                }

                return cliente;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Cliente> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Cliente> clientes = new List<Cliente>();

            string query = "SELECT * FROM [dbo].[TB_CLIENTES] WHERE" +
                "(YEAR([CLT_DTINICIO_CONTRATO]) >= '" + dtinicio.Year + "' AND YEAR([CLT_DTINICIO_CONTRATO]) <= '" + dtfim.Year +"' )" +
                "AND(MONTH([CLT_DTINICIO_CONTRATO]) >= '" + dtinicio.Month + "' AND MONTH([CLT_DTINICIO_CONTRATO]) <= '" + dtfim.Month + "')";

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Cliente cliente = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    DateTime dtnascimento = Convert.ToDateTime(dr["CLT_DTNASCIMENTO"].ToString());
                    DateTime dtiniciocontrato = Convert.ToDateTime(dr["CLT_DTINICIO_CONTRATO"].ToString());
                    long telefone = long.Parse(dr["CLT_TELEFONE"].ToString());

                    cliente = new Cliente(dr["CLT_CPF"].ToString(), dr["CLT_NOME"].ToString(), dr["CLT_RG"].ToString(), dr["CLT_ENDERECO"].ToString(), telefone, dr["CLT_EMAIL"].ToString(), dtnascimento, dtiniciocontrato);

                    clientes.Add(cliente);
                }

                return clientes;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(string cpf)
        {
            string query = "DELETE [TB_CLIENTES] WHERE [CLT_CPF] = '" + cpf +"'";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Cliente cliente, string cpf)
        {
            string Query = "UPDATE [TB_CLIENTES] SET [CLT_CPF] = '" + cliente.CPF + "',[CLT_NOME] = '" + cliente.Nome + "', [CLT_RG] = '" + cliente.RG + "',[CLT_ENDERECO] = '" + cliente.Endereco + "',[CLT_TELEFONE] = " + cliente.Telefone + ",[CLT_EMAIL] = '" + cliente.Endereco + "',[CLT_DTNASCIMENTO] = '" + cliente.DataNascimento + "', [CLT_DTINICIO_CONTRATO] = '" + cliente.DataInicioContrato + "' WHERE [CLT_CPF] = '" + cpf + "' ";
            
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }

        }

        public List<Cliente> Pesquisar(string busca)
        {
            List<Cliente> clientes = new List<Cliente>();
            if (busca == "")
            {
                return clientes;
            }
            string query = "SELECT * FROM[dbo].[TB_CLIENTES] WHERE(CLT_CPF LIKE '%" + busca + "%'" +
                " OR CLT_NOME LIKE '%" + busca + "%' OR CLT_EMAIL LIKE '%" + busca + "%')";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Cliente cliente = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    DateTime dtnascimento = Convert.ToDateTime(dr["CLT_DTNASCIMENTO"].ToString());
                    DateTime dtiniciocontrato = Convert.ToDateTime(dr["CLT_DTINICIO_CONTRATO"].ToString());
                    long telefone = long.Parse(dr["CLT_TELEFONE"].ToString());

                    cliente = new Cliente(dr["CLT_CPF"].ToString(), dr["CLT_NOME"].ToString(), dr["CLT_RG"].ToString(), dr["CLT_ENDERECO"].ToString(), telefone, dr["CLT_EMAIL"].ToString(), dtnascimento, dtiniciocontrato);

                    clientes.Add(cliente);
                }

                return clientes;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }
    }
}
