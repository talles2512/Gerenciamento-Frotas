using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CamadaModelagem.Services.Exceptions;
using System.Data;

namespace CamadaModelagem.Data.Configuration
{
    public class Banco
    {
        public bool ExecutarInstrucao(string querySQL)
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
                return true;
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

        public bool ExecutaTransaction(string query1, string query2)
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
                    return true;
                }
                catch (Exception)
                {
                    try
                    {
                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception)
                    {
                        throw new TransacaoException("Erro na operação, tente novamente mais tarde!");
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

        public DataTable BuscarRegistro(string querySQL)
        {
            Configuracao configuracao = new Configuracao();

            string stringConexao = configuracao.StringConfiguracao;
            string query = querySQL;

            SqlConnection sqlConnection = new SqlConnection(stringConexao);
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            try
            {
                sqlConnection.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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

        public int TestarConexao()
        {
            Configuracao configuracao = new Configuracao();

            string stringConexao = configuracao.StringConfiguracao;
            string query = "SELECT COUNT(GRANTOR) FROM DB_GERENCFROTA.INFORMATION_SCHEMA.COLUMN_PRIVILEGES";

            SqlConnection sqlConnection = new SqlConnection(stringConexao);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                return (int) sqlCommand.ExecuteScalar();
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
