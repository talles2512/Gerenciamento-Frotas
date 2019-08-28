using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data;
using CamadaModelagem.Modelagem;

namespace CamadaModelagem.Services
{
    class SeguroCoberturaService
    {
        private readonly Banco _banco;

        public SeguroCoberturaService(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(SeguroCobertura seguroCobertura)
        {
            string query = "INSERT INTO [dbo].[TB_SEGCOBERTURA] ([SEGC_DESCRICAO],[SEGC_SEGURO_NUMAPOLICE])" + "VALUES ('" + seguroCobertura.Descricao + "', " + seguroCobertura.Seguro.NumeroApolice + ")";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(int id)
        {
            string Query = "DELETE [dbo].[TB_SEGCOBERTURA] WHERE [SEGC_ID] = " + id;
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(SeguroCobertura seguroCobertura, int id)
        {
            string Query = "UPDATE [dbo].[TB_SEGCOBERTURA] SET [SEGC_DESCRICAO] ='" + seguroCobertura.Descricao + "',[SEGC_SEGURO_NUMAPOLICE] =" + seguroCobertura.Seguro.NumeroApolice + " WHERE [SEGC_ID] =" + id;
            _banco.ExecutarInstrucao(Query);
        }
    }
}
