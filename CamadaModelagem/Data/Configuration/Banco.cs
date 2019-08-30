using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Data.Configuration
{
    class Banco
    {
        public void ExecutarInstrucao(string querySQL)
        {
            Configuracao configuracao = new Configuracao();

            string stringConexao = configuracao.StringConfiguracao;
            string query = querySQL;

            SqlConnection sqlConnection = new SqlConnection(stringConexao);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
            finally
            {
                sqlConnection.Close();
            }
        }         
    }
}
