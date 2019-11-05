using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Data
{
    public class EstoquePecasDAL
    {
        private readonly Banco _banco;

        public EstoquePecasDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(EstoquePeca estoquepeca)
        {
            DateTime datareg = DateTime.Now;
            string query = "INSERT INTO [dbo].[TB_ESTOQUE_PECAS] ([EP_DESCRICAO],[EP_VALORUNIT],[EP_QUANTD],[EP_DATAREGISTRO])" +
                "VALUES ('" + estoquepeca.Descricao + "', " + estoquepeca.ValorUnit + ", " + estoquepeca.Quantidade + ", '" + datareg.ToShortDateString() + "')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public EstoquePeca BuscarEstoquePecas(int idpeca)
        {
            string query = "SELECT * FROM [dbo].[TB_ESTOQUE_PECAS] WHERE [EP_ID] = " + idpeca;
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                EstoquePeca estoquePeca = null;
                DataRow[] dataRows = dt.Select("EP_ID = " + idpeca);

                foreach (DataRow dr in dataRows)
                {
                    double valor = double.Parse(dr["EP_VALORUNIT"].ToString());
                    int qtd = int.Parse(dr["EP_QUANTD"].ToString());

                    estoquePeca = new EstoquePeca(idpeca, dr["EP_DESCRICAO"].ToString(), valor, qtd);
                }

                return estoquePeca;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }
        public List<EstoquePeca> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<EstoquePeca> pecas = new List<EstoquePeca>();

            string query = "SELECT * FROM [dbo].[TB_ESTOQUE_PECAS] WHERE" +
                    "((YEAR([EP_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([EP_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                    "AND MONTH([EP_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([EP_DATAREGISTRO]) <= '" + dtfim.Month + "')";

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                EstoquePeca estoquePeca = null;
                DataRow[] dataRows = dt.Select();

                foreach (DataRow dr in dataRows)
                {
                    double valor = double.Parse(dr["EP_VALORUNIT"].ToString());
                    int qtd = int.Parse(dr["EP_QUANTD"].ToString());
                    int idpeca = int.Parse(dr["EP_ID"].ToString());

                    estoquePeca = new EstoquePeca(idpeca, dr["EP_DESCRICAO"].ToString(), valor, qtd);
                    pecas.Add(estoquePeca);
                }
                return pecas;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public bool Deletar(int idpeca) //provisorio, ID da Peça é o unico identificador 
        {
            string Query = "DELETE [dbo].[TB_ESTOQUE_PECAS] WHERE [EP_ID] = " + idpeca;
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(EstoquePeca estoquepeca, int idpeca)
        {
            string Query = "UPDATE [dbo].[TB_ESTOQUE_PECAS] SET [EP_DESCRICAO] ='" + estoquepeca.Descricao + "',[EP_VALORUNIT] =" + estoquepeca.ValorUnit + ",[EP_QUANTD]=" + estoquepeca.Quantidade + " WHERE [EP_ID] =" + idpeca;           
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public int PopulaID()
        {
            string Query = "SELECT MAX(EP_ID) AS ID FROM [TB_ESTOQUE_PECAS]";
            try
            {
                DataTable dt = _banco.BuscarRegistro(Query);
                DataRow dr = dt.Rows[0];
                try
                {
                    int id = int.Parse(dr[0].ToString());
                    id += 1;
                    return id;
                }
                catch
                {
                    return 1;
                }                          
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<EstoquePeca> Pesquisar(string busca)
        {
            List<EstoquePeca> pecas = new List<EstoquePeca>();
            string query;

            if (busca == "")
            {
                return pecas;
            }

            if (DetectaChar(busca) > 0)
            {
                query = "SELECT * FROM [dbo].[TB_ESTOQUE_PECAS] WHERE (EP_DESCRICAO LIKE '%" + busca + "%')";
            }
            else
            {
                query = "SELECT * FROM [dbo].[TB_ESTOQUE_PECAS] WHERE (CONVERT(varchar,EP_ID) LIKE '%" + busca + "%'" +
                    " OR EP_DESCRICAO LIKE '%" + busca + "%')";
            }

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                EstoquePeca estoquePeca = null;
                DataRow[] dataRows = dt.Select();

                foreach (DataRow dr in dataRows)
                {
                    double valor = double.Parse(dr["EP_VALORUNIT"].ToString());
                    int qtd = int.Parse(dr["EP_QUANTD"].ToString());
                    int idpeca = int.Parse(dr["EP_ID"].ToString());

                    estoquePeca = new EstoquePeca(idpeca, dr["EP_DESCRICAO"].ToString(), valor, qtd);
                    pecas.Add(estoquePeca);
                }
                return pecas;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        private int DetectaChar(string busca)
        {
            int contador = 0;

            char[] caracteres = busca.ToCharArray();
            foreach (char caractere in caracteres)
            {
                if (!char.IsDigit(caractere))
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
