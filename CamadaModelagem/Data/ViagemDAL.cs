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
    public class ViagemDAL
    {
        private readonly Banco _banco;

        public ViagemDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(Viagem viagem)
        {
            int ocupante = Convert.ToInt32(viagem.Ocupante);
            DateTime datareg = DateTime.Now;
            string query = "INSERT INTO [dbo].[TB_VIAGENS] ([VG_REQ],[VG_VCL_PLACA],[VG_MT_CPF],[VG_OCUPANTES],[VG_DESTINO],[VG_DTSAIDA],[VG_DATAREGISTRO])"
                + "VALUES (" + viagem.Requisicao + ",'" + viagem.Placa + "', '" + viagem.CPF + "', " + ocupante
                + ", '" + viagem.Destino + "', '" + viagem.DataSaida.ToString() + "','" + datareg.ToShortDateString() + "')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(int requisicao)
        {
            string Query = "DELETE [dbo].[TB_VIAGENS] WHERE [VG_REQ] = " + requisicao;
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Viagem viagem, int requisicao)
        {
            int ocupante = Convert.ToInt32(viagem.Ocupante);
            string Query = "UPDATE [dbo].[TB_VIAGENS] SET [VG_VCL_PLACA] ='" + viagem.Placa + "',[VG_MT_CPF] ='" + viagem.CPF 
                + "',[VG_OCUPANTES] =" + ocupante + ",[VG_DESTINO] ='" + viagem.Destino + "',[VG_DTSAIDA] ='" 
                + viagem.DataSaida + "' WHERE [VG_REQ] =" + requisicao;
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Viagem BuscarViagem(int requisicao)
        {
            string query = "SELECT [VG_REQ],[VG_VCL_PLACA],[VG_MT_CPF],[VG_OCUPANTES],[VG_DESTINO],[VG_DTSAIDA] " +
                "FROM[DB_GERENCFROTA].[dbo].[TB_VIAGENS] WHERE[VG_REQ] = " + requisicao;
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Viagem viagem = null;
                DataRow[] dataRows = dt.Select("[VG_REQ] = " + requisicao);
                foreach (DataRow dr in dataRows)
                {
                    int numRequisicao = int.Parse(dr["VG_REQ"].ToString());
                    bool ocupante = bool.Parse(dr["VG_OCUPANTES"].ToString());
                    DateTime dataSaida = Convert.ToDateTime(dr["VG_DTSAIDA"].ToString());

                    viagem = new Viagem(numRequisicao, ocupante, dr["VG_DESTINO"].ToString(), dataSaida, dr["VG_VCL_PLACA"].ToString()
                        , dr["VG_MT_CPF"].ToString());
                }
                return viagem;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Viagem> BuscarTodos(string placa)
        {
            List<Viagem> viagens = new List<Viagem>();
            string query = "SELECT [VG_REQ],[VG_VCL_PLACA],[VG_MT_CPF],[VG_OCUPANTES],[VG_DESTINO],[VG_DTSAIDA] " +
                "FROM[DB_GERENCFROTA].[dbo].[TB_VIAGENS] WHERE[VG_VCL_PLACA] = '" + placa +"'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Viagem viagem = null;
                DataRow[] dataRows = dt.Select("[VG_VCL_PLACA] = '" + placa + "'");
                foreach (DataRow dr in dataRows)
                {
                    int numRequisicao = int.Parse(dr["VG_REQ"].ToString());
                    bool ocupante = bool.Parse(dr["VG_OCUPANTES"].ToString());
                    DateTime dataSaida = Convert.ToDateTime(dr["VG_DTSAIDA"].ToString());

                    viagem = new Viagem(numRequisicao, ocupante, dr["VG_DESTINO"].ToString(), dataSaida, dr["VG_VCL_PLACA"].ToString()
                        , dr["VG_MT_CPF"].ToString());
                    viagens.Add(viagem);
                }
                return viagens;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Viagem> BuscarTodosMotoristas(string cpf)
        {
            List<Viagem> viagens = new List<Viagem>();
            string query = "SELECT [VG_REQ],[VG_VCL_PLACA],[VG_MT_CPF],[VG_OCUPANTES],[VG_DESTINO],[VG_DTSAIDA] " +
                "FROM[DB_GERENCFROTA].[dbo].[TB_VIAGENS] WHERE[VG_MT_CPF] = '" + cpf + "'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Viagem viagem = null;
                DataRow[] dataRows = dt.Select("[VG_MT_CPF] = '" + cpf + "'");
                foreach (DataRow dr in dataRows)
                {
                    int numRequisicao = int.Parse(dr["VG_REQ"].ToString());
                    bool ocupante = bool.Parse(dr["VG_OCUPANTES"].ToString());
                    DateTime dataSaida = Convert.ToDateTime(dr["VG_DTSAIDA"].ToString());

                    viagem = new Viagem(numRequisicao, ocupante, dr["VG_DESTINO"].ToString(), dataSaida, dr["VG_VCL_PLACA"].ToString()
                        , dr["VG_MT_CPF"].ToString());
                    viagens.Add(viagem);
                }
                return viagens;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Viagem> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Viagem> viagens = new List<Viagem>();
            string query = "SELECT [VG_REQ],[VG_VCL_PLACA],[VG_MT_CPF],[VG_OCUPANTES],[VG_DESTINO],[VG_DTSAIDA] " +
                "FROM[DB_GERENCFROTA].[dbo].[TB_VIAGENS] " +
                "WHERE ((YEAR([VG_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([VG_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                "AND MONTH([VG_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([VG_DATAREGISTRO]) <= '" + dtfim.Month + "')";

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Viagem viagem = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    int numRequisicao = int.Parse(dr["VG_REQ"].ToString());
                    bool ocupante = bool.Parse(dr["VG_OCUPANTES"].ToString());
                    DateTime dataSaida = Convert.ToDateTime(dr["VG_DTSAIDA"].ToString());

                    viagem = new Viagem(numRequisicao, ocupante, dr["VG_DESTINO"].ToString(), dataSaida, dr["VG_VCL_PLACA"].ToString()
                        , dr["VG_MT_CPF"].ToString());
                    viagens.Add(viagem);
                }
                return viagens;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public int PopularRequisicao()
        {
            string Query = "SELECT MAX([VG_REQ]) AS ID FROM [DB_GERENCFROTA].[dbo].[TB_VIAGENS]";
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


        public DataTable PopularCPFs()
        {
            string query = "SELECT [MT_NOME] + '-' + [MT_CPF] as MOTORISTA, [MT_CPF] FROM [DB_GERENCFROTA].[dbo].[TB_MOTORISTA]	WHERE [MT_SITUACAO] = 1";
            try
            {
                return _banco.BuscarRegistro(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public DataTable PopularPlacas()
        {
            string query = "SELECT [VCL_MODELO] + '-' + [VCL_PLACA] as MODELO, [VCL_PLACA] FROM [DB_GERENCFROTA].[dbo].[TB_VEICULOS]	WHERE [VCL_SITUACAO] = 1";
            try
            {
                return _banco.BuscarRegistro(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Viagem> Pesquisar(string busca)
        {
            List<Viagem> viagens = new List<Viagem>();
            string query;

            if (busca == "")
            {
                return viagens;
            }

            if(DetectaChar(busca) > 0)
            {
                query = "SELECT [VG_REQ],[VG_VCL_PLACA],[VG_MT_CPF],[VG_OCUPANTES],[VG_DESTINO],[VG_DTSAIDA] " +
                "FROM[DB_GERENCFROTA].[dbo].[TB_VIAGENS] JOIN [dbo].[TB_MOTORISTA] ON VG_MT_CPF = MT_CPF" +
                " JOIN [dbo].[TB_VEICULOS] ON VG_VCL_PLACA = VCL_PLACA WHERE(VG_VCL_PLACA LIKE '%" + busca + "%'" +
                " OR VG_MT_CPF LIKE '%" + busca + "%' OR MT_NOME LIKE '%" + busca + "%' OR VCL_MODELO LIKE '%" + busca + "%'" +
                " OR VCL_MARCA LIKE '%" + busca + "%' OR VG_DESTINO LIKE '%" + busca + "%')";
            }
            else
            {
                query = "SELECT [VG_REQ],[VG_VCL_PLACA],[VG_MT_CPF],[VG_OCUPANTES],[VG_DESTINO],[VG_DTSAIDA]" +
                " FROM[DB_GERENCFROTA].[dbo].[TB_VIAGENS] JOIN [dbo].[TB_MOTORISTA] ON VG_MT_CPF = MT_CPF" +
                " JOIN [dbo].[TB_VEICULOS] ON VG_VCL_PLACA = VCL_PLACA WHERE(CONVERT(varchar,VG_REQ) LIKE '%" + busca + "%'" +
                " OR VG_VCL_PLACA LIKE '%" + busca + "%' OR VG_MT_CPF LIKE '%" + busca + "%' OR MT_NOME LIKE '%" + busca + "%'" +
                " OR VCL_MODELO LIKE '%" + busca + "%' OR VCL_MARCA LIKE '%" + busca + "%' OR VG_DESTINO LIKE '%" + busca + "%')";
            }

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Viagem viagem = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    int numRequisicao = int.Parse(dr["VG_REQ"].ToString());
                    bool ocupante = bool.Parse(dr["VG_OCUPANTES"].ToString());
                    DateTime dataSaida = Convert.ToDateTime(dr["VG_DTSAIDA"].ToString());

                    viagem = new Viagem(numRequisicao, ocupante, dr["VG_DESTINO"].ToString(), dataSaida, dr["VG_VCL_PLACA"].ToString()
                        , dr["VG_MT_CPF"].ToString());
                    viagens.Add(viagem);
                }
                return viagens;
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
