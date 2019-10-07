using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Data.Configuration
{
    public class Banco
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

        public void ExecutaTransaction(string query1, string query2)
        {
            Configuracao configuracao = new Configuracao();
            string stringConexao = configuracao.StringConfiguracao;
            SqlConnection SqlConn = new SqlConnection(stringConexao);
            try
            {
                SqlConn.Open();
                SqlCommand cmd = SqlConn.CreateCommand();
                SqlTransaction transaction = SqlConn.BeginTransaction();
                cmd.Connection = SqlConn;
                cmd.Transaction = transaction;
                try
                {
                    cmd.CommandText = query1;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = query2;
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Houve erro na operação. Tente novamente!");
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {
                        throw new TransacaoException("Erro na inserção, tente novamente mais tarde!");
                    }
                }
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
            finally
            {
                SqlConn.Close();
            }
        }

        public SqlDataReader BuscarRegistro(string querySQL)
        {
            Configuracao configuracao = new Configuracao();

            string stringConexao = configuracao.StringConfiguracao;
            string query = querySQL;

            SqlConnection sqlConnection = new SqlConnection(stringConexao);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader dr = null;

            try
            {
                sqlConnection.Open();
                dr = sqlCommand.ExecuteReader();
                return dr;
            }
            catch (Exception)
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
