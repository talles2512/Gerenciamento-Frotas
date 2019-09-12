using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;

namespace CamadaModelagem.Data
{
    public class ServicoExternoDAL
    {
        private readonly Banco _banco;

        public ServicoExternoDAL(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(ServicoExterno servicoExterno)
        {
            string query = "INSERT INTO [dbo].[TB_SERVICOS_EXTERNOS] ([SERVEXT_CNPJ],[SERVEXT_TIPO],[SERVEXT_NOME],[SERVEXT_TELEFONE],[SERVEXT_EMAIL],[SERVEXT_ENDERECO],"
                + "[SERVEXT_CONVENIADO])" + "VALUES (" + servicoExterno.CNPJ + ", " + servicoExterno.Tipo + ", '" + servicoExterno.Nome + "', " + servicoExterno.Telefone + ", '" + servicoExterno.Email + "', '" + servicoExterno.Endereco + "', " + servicoExterno.Conveniado + ")";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(int cnpj)
        {
            string Query = "DELETE [dbo].[TB_SERVICOS_EXTERNOS] WHERE [SERVEXT_CNPJ] = " + cnpj;
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(ServicoExterno servicoExterno, int cnpj)
        {
            string Query = "UPDATE [dbo].[TB_SERVICOS_EXTERNOS] SET [SERVEXT_CNPJ] =" + servicoExterno.CNPJ + ",[SERVEXT_TIPO] =" + servicoExterno.Tipo + ",[SERVEXT_NOME]='" + servicoExterno.Nome
                + "',[SERVEXT_TELEFONE] =" + servicoExterno.Telefone + ",[SERVEXT_EMAIL] ='" + servicoExterno.Email + "',[SERVEXT_ENDERECO] ='" + servicoExterno.Endereco + "',[SERVEXT_CONVENIADO] =" + servicoExterno.Conveniado + " WHERE [SERVEXT_CNPJ] =" + cnpj;
            _banco.ExecutarInstrucao(Query);
        }
    }
}
