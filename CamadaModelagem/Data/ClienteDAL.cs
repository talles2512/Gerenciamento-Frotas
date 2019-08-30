using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;

namespace CamadaModelagem.Data
{
    class ClienteDAL
    {
        private readonly Banco _banco;

        public ClienteDAL(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Cliente cliente)
        {
            string query = "INSERT INTO[dbo].[TB_CLIENTES]([CLT_CPF],[CLT_NOME],[CLT_RG],[CLT_ENDERECO],[CLT_TELEFONE],[CLT_EMAIL],[CLT_DTNASCIMENTO],[CLT_DTINICIO_CONTRATO])" +
                "VALUES(" + cliente.CPF + ", '" + cliente.Nome + "', '" + cliente.RG + "', '" + cliente.Endereco + "', " + cliente.Telefone + ", '" + cliente.Email + "', '" + cliente.DataNascimento + "', '" + cliente.DataInicioContrato + "')";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(int cpf)
        {
            string Query = "DELETE [TB_CLIENTES] WHERE [CLT_CPF] = " + cpf;
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(Cliente cliente, int cpf)
        {
            string Query = "UPDATE [TB_CLIENTES] SET [CLT_CPF] = " + cliente.CPF + "',[CLT_NOME] = '" + cliente.Nome + "', [CLT_RG] = '" + cliente.RG + "',[CLT_ENDERECO] = '" + cliente.Endereco + "',[CLT_TELEFONE] = " + cliente.Telefone + ",[CLT_EMAIL] = '" + cliente.Endereco + "',[CLT_DTNASCIMENTO] = '" + cliente.DataNascimento + "', [CLT_DTINICIO_CONTRATO] = '" + cliente.DataInicioContrato + "' WHERE [CLT_CPF] = '" + cpf + "' ";
            _banco.ExecutarInstrucao(Query);
        }
    }
}
