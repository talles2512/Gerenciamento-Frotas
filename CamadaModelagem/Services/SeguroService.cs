using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data;
using CamadaModelagem.Modelagem;

namespace CamadaModelagem.Services
{
    class SeguroService
    {
        private readonly Banco _banco;

        public SeguroService(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Seguro seguro)
        {
            string query = "INSERT INTO [dbo].[TB_SEGURO] ([SEG_NUMAPOLICE],[SEG_SEGURADORA],[SEG_ITEMSEG],[SEG_TIPO],[SEG_VALOR],[SEG_DATAINICIO],"
                + "[SEG_FIMVIGENCIA],[SEG_FRANQUIA],[SEG_VALORFRANQUIA])" + "VALUES (" + seguro.NumeroApolice + ", " + seguro.ServicoExterno.CNPJ + ", " + seguro.ItemSegurado + ", '" + seguro.Tipo + "', " + seguro.Valor + ", " + seguro.DataInicio + ", " + seguro.FimVigencia + ", '" + seguro.Franquia + "', " + seguro.ValorFranquia + ")";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(int numApolice) 
        {
            string Query = "DELETE [dbo].[TB_SEGURO] WHERE [SEG_NUMAPOLICE] = " + numApolice;
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(Seguro seguro, int numApolice)
        {
            string Query = "UPDATE [dbo].[TB_SEGURO] SET [SEG_NUMAPOLICE] =" + seguro.NumeroApolice + ",[SEG_SEGURADORA] =" + seguro.ServicoExterno.CNPJ + ",[SEG_ITEMSEG]=" + seguro.ItemSegurado
                + ",[SEG_TIPO] =" + seguro.Tipo + ",[SEG_VALOR] =" + seguro.Valor + ",[SEG_DATAINICIO] =" + seguro.DataInicio + ",[SEG_FIMVIGENCIA] =" + seguro.FimVigencia + ",[SEG_FRANQUIA] ='" + seguro.Franquia + "',[SEG_VALORFRANQUIA] =" + seguro.ValorFranquia + " WHERE [SEG_NUMAPOLICE] =" + numApolice;
            _banco.ExecutarInstrucao(Query);
        }
    }
}
