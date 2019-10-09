using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;

namespace CamadaModelagem.Data
{
    public class ServicoExternoConveniadoDAL
    {
        private readonly Banco _banco;

        public ServicoExternoConveniadoDAL(Banco banco)
        {
            _banco = banco;
        }

        //public void Cadastrar(ServicoExternoConveniado servicoExternoConveniado)
        //{
        //    string query = "INSERT INTO [dbo].[TB_SERVICOS_EXTERNOS_CONVENIADOS] ([SERVEXTCONV_VALOR],[SERVEXTCONV_DTINICIO],[SERVEXTCONV_DTVENC],[SERVEXTCONV_SERVEXT_CNPJ])"
        //        + "VALUES (" + servicoExternoConveniado.Valor + ", '" + servicoExternoConveniado.DataInicio + "', '" + servicoExternoConveniado.DataVencimento + "', " + servicoExternoConveniado.ServicoExterno.CNPJ + ")";
        //    _banco.ExecutarInstrucao(query);
        //}

        //public void Deletar(int cnpj)
        //{
        //    string Query = "DELETE [dbo].[TB_SERVICOS_EXTERNOS_CONVENIADOS] WHERE [SERVEXTCONV_SERVEXT_CNPJ] = " + cnpj;
        //    _banco.ExecutarInstrucao(Query);
        //}

        //public void Alterar(ServicoExternoConveniado servicoExternoConveniado, int cnpj)
        //{
        //    string Query = "UPDATE [dbo].[TB_SERVICOS_EXTERNOS_CONVENIADOS] SET [SERVEXTCONV_VALOR] =" + servicoExternoConveniado.Valor + ",[SERVEXTCONV_DTINICIO] ='" + servicoExternoConveniado.DataInicio + "',[SERVEXTCONV_DTVENC]='" + servicoExternoConveniado.DataVencimento
        //        + "',[SERVEXTCONV_SERVEXT_CNPJ] =" + servicoExternoConveniado.ServicoExterno.CNPJ + " WHERE [SERVEXT_CNPJ] =" + cnpj;
        //    _banco.ExecutarInstrucao(Query);
        //}
    }
}
