using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data;
using CamadaModelagem.Modelagem;

namespace CamadaModelagem.Services
{
    class SinistroService
    {
        private readonly Banco _banco;

        public SinistroService(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Sinistro sinistro)
        {
            string query = "INSERT INTO [dbo].[TB_SINISTRO] ([SIN_ITEMSEG],[SIN_SEGURO],[SIN_DESCRICAO],[SIN_DATAHORA])" + "VALUES ('" + sinistro.ItemSegurado + "', " + sinistro.Seguro.NumeroApolice + ", '" + sinistro.Descricao + "', '" + sinistro.DataHora + ")";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(int id)
        {
            string Query = "DELETE [dbo].[TB_SINISTRO] WHERE [SIN_ID] = " + id;
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(Sinistro sinistro, int id)
        {
            string Query = "UPDATE [dbo].[TB_SINISTRO] SET [SIN_ITEMSEG] ='" + sinistro.ItemSegurado + "',[SIN_SEGURO] =" + sinistro.Seguro.NumeroApolice + ",[SIN_DESCRICAO]='" + sinistro.Descricao
                + "',[SIN_DATAHORA] ='" + sinistro.DataHora + "' WHERE [SEG_NUMAPOLICE] =" + id;
            _banco.ExecutarInstrucao(Query);
        }
    }
}
