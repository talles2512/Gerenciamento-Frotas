using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;

namespace CamadaModelagem.Data
{
    class AbastecimentoDAL
    {
        private readonly Banco _banco;

        public AbastecimentoDAL(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Abastecimento abastecimento)
        {
            string query = " INSERT INTO [dbo].[TB_ABASTECIMENTO]([ABS_VCL_PLACA],[ABS_SERVEXT_CNPJ],[ABS_TIPO],[ABS_VALORLITRO],[ABS_DATA])" +
                "VALUES('" + abastecimento.Veiculo.Placa + "', " + abastecimento.ServicoExterno.CNPJ + ", " + abastecimento.Tipo + ", " + abastecimento.ValorLitro + ", '" + abastecimento.Data + "')";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(string placa, int tipo, DateTime data) //Modificado
        {
            string Query = "DELETE [TB_ABASTECIMENTO] WHERE [ABS_VCL_PLACA] = '" + placa + "' AND [ABS_TIPO] = " + tipo + " AND [ABS_DATA] = '" + data + "'";
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(Abastecimento abastecimento, string placa, int tipo, DateTime data) // Modificado
        {
            string Query = "UPDATE TB_ABASTECIMENTO SET [ABS_VCL_PLACA] = '" + abastecimento.Veiculo.Placa + "', [ABS_SERVEXT_CNPJ] = " + abastecimento.ServicoExterno.CNPJ + " ,[ABS_TIPO] = " + abastecimento.Tipo + ",[ABS_VALORLITRO] = " + abastecimento.ValorLitro + ",[ABS_DATA] = '" + abastecimento.Data + "' WHERE [ABS_VCL_PLACA] = '" + placa + "' AND [ABS_TIPO] = " + tipo + " AND [ABS_DATA] = '" + data + "'";
            _banco.ExecutarInstrucao(Query);
        }
    }
}
