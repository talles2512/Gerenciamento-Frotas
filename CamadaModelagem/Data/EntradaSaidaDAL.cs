using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;

namespace CamadaModelagem.Data
{
    class EntradaSaidaDAL
    {
        private readonly Banco _banco;

        public EntradaSaidaDAL(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(EntradaSaida entsaid) //Verificar Query
        {
            string query = "INSERT INTO[dbo].[TB_ENTRADA_SAIDA] ([ES_MT_CPF],[ES_VCL_PLACA],[ES_SERVEXT_CNPJ],[ES_TIPO],[ES_DATAHORA]) " +
                "VALUES (" + entsaid.Motorista.CPF + ", '" + entsaid.Veiculo.Placa + "', " + entsaid.ServicoExterno.CNPJ + ", " + entsaid.Tipo + ", '" + entsaid.DataHora + "')";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(string placa, int tipo, DateTime data) // Modificado
        {
            string Query = "DELETE [dbo].[TB_ENTRADA_SAIDA] WHERE [ES_VCL_PLACA] = '" + placa + "' AND [ES_TIPO] = " + tipo + " AND [ES_DATAHORA] = '" + data + "'";
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(EntradaSaida entsaid, string placa, int tipo, DateTime data) // Modificado
        {
            string Query = "UPDATE [dbo].[TB_ENTRADA_SAIDA] SET [ES_MT_CPF] = " + entsaid.Motorista.CPF + "', [ES_VCL_PLACA] = '" + entsaid.Veiculo.Placa + "',[ES_SERVEXT_CNPJ] = " + entsaid.ServicoExterno.CNPJ + ", [ES_TIPO] =" + entsaid.Tipo + ", [ES_DATAHORA] ='" + entsaid.DataHora + "' WHERE [ES_VCL_PLACA] = '" + placa + "' AND [ES_TIPO] = " + tipo + " AND [ES_DATAHORA] = '" + data + "'";
        }
    }
}
