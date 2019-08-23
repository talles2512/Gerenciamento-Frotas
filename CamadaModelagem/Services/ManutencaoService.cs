using CamadaModelagem.Data;
using CamadaModelagem.Modelagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Services
{ 
    class ManutencaoService
    {
        private readonly Banco _banco;

        public ManutencaoService(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Manutencao manuntencao) //Exemplo Cadastrar
        {
            string query = "INSERT INTO [dbo].[TB_MANUTENCAO] ([MTC_TIPO],[MTC_SERVEXT_CNPJ],[MTC_DESCRICAO],[MTC_DATA],[MTC_VALOR],[MTC_SITUACAO],[MTC_VCL_PLACA])" +
                "VALUES (" + manuntencao.Tipo + ", " + manuntencao.ServicoExterno.CNPJ + ", '" + manuntencao.Descricao + "','" + manuntencao.Data + "', " + manuntencao.Valor + ", " + manuntencao.Situacao + ", '" + manuntencao.Veiculo.Placa + "')";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(string placa, int tipo, DateTime data) //Modificado
        {
            string Query = "DELETE [dbo].[TB_MANUTENCAO] WHERE [MTC_VCL_PLACA] = '" + placa + "' AND [MTC_TIPO] = " + tipo + " AND [MTC_DATA] = '" + data +"'";
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(Manutencao manuntencao, string placa, int tipo, DateTime data) // Modificado
        {
            string Query = "UPDATE [dbo].[TB_MANUTENCAO] SET [MTC_TIPO] = " + manuntencao.Tipo + ",[MTC_SERVEXT_CNPJ]= " + manuntencao.ServicoExterno.CNPJ + ",[MTC_DESCRICAO]= '" + manuntencao.Descricao + "',[MTC_DATA]='" + manuntencao.Data + "',[MTC_VALOR]= " + manuntencao.Valor + ",[MTC_SITUACAO]= " + manuntencao.Situacao + ",[MTC_VCL_PLACA]= '" + manuntencao.Veiculo.Placa + "' WHERE [MTC_VCL_PLACA] = '" + placa + "' AND [MTC_TIPO] = " + tipo + "AND [MTC_DATA] = '" + data + "'";
            _banco.ExecutarInstrucao(Query);
        }
    }
}
