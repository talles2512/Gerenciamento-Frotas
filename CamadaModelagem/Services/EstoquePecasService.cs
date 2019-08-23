using CamadaModelagem.Data;
using CamadaModelagem.Modelagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Services
{
    class EstoquePecasService
    {
        private readonly Banco _banco;

        public EstoquePecasService(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(EstoquePeca estoquepeca) 
        {
            string query = "INSERT INTO [dbo].[TB_ESTOQUE_PECAS] ([EP_DESCRICAO],[EP_VALORUNIT],[EP_QUANTD])" +
                "VALUES ('" + estoquepeca.Descricao + "', " + estoquepeca.ValorUnit + ", " + estoquepeca.Quantidade + ")";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(int idpeca) //provisorio, ID da Peça é o unico identificador 
        {
            string Query = "DELETE [dbo].[TB_ESTOQUE_PECAS] WHERE [EP_ID] = " + idpeca ;
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(EstoquePeca estoquepeca, int idpeca)
        {
            string Query = "UPDATE [dbo].[TB_ESTOQUE_PECAS] SET [TB_ESTOQUE_PECAS] ='" + estoquepeca.Descricao + "',[EP_VALORUNIT] =" + estoquepeca.ValorUnit + ",[EP_QUANTD]=" + estoquepeca.Quantidade + " WHERE [EP_ID] =" + idpeca;
            _banco.ExecutarInstrucao(Query);
        }
    }
}
