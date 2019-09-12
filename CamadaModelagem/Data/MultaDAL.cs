using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;

namespace CamadaModelagem.Data
{
    public class MultaDAL
    {
        private readonly Banco _banco;

        public MultaDAL(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Multa multa)
        {
            string query = "INSERT INTO [dbo].[TB_MULTAS] ([MULT_VCL_PLACA],[MULT_MT_CPF],[MULT_DESCRICAO],[MULT_LOCAL],[MULT_DTOCORRENCIA],[MULT_VALOR],[MULT_PAGO],[MULTPAG_DTPAGAMENTO])" +
                "VALUES ('" + multa.Veiculo.Placa + "', " + multa.Motorista.CPF + ", '" + multa.Descricao + "', '" + multa.Local + "','" + multa.DataOcorrencia + "'," + multa.Valor + "," + multa.Paga + ",'" + multa.MultasPagas + "')";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(string placa, int cpf, DateTime data) //Modificado
        {
            string Query = "DELETE [dbo].[TB_MULTAS] WHERE [MULT_VCL_PLACA] = '" + placa + "' AND [MULT_MT_CPF] = " + cpf + " AND [MULT_DTOCORRENCIA] = '" + data + "'";
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(Multa multa, string placa, int cpf, DateTime data) //Modificado
        {
            string Query = "UPDATE [dbo].[TB_MULTAS] SET [MULT_VCL_PLACA]='" + multa.Veiculo.Placa + "',[MULT_MT_CPF]= " + multa.Motorista.CPF + ",[MULT_DESCRICAO]= '" + multa.Descricao + "',[MULT_LOCAL]= '" + multa.Local + "',[MULT_DTOCORRENCIA]= '" + multa.DataOcorrencia + "',[MULT_VALOR]=" + multa.Valor + ",[MULT_PAGO]=" + multa.Paga + ",[MULTPAG_DTPAGAMENTO]= '" + multa.MultasPagas + "' WHERE [MULT_VCL_PLACA] = '" + placa + "' AND [MULT_MT_CPF] = " + cpf + " AND [MULT_DTOCORRENCIA] = '" + data + "'";
            _banco.ExecutarInstrucao(Query);
        }
    }
}
