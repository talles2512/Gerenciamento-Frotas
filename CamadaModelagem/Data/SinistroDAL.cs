using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Data
{
    public class SinistroDAL
    {
        private readonly Banco _banco;

        public SinistroDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(Sinistro sinistro, long numapolice)
        {
            string query = "";

            string data = sinistro.DataHora.ToString("yyyy/MM/dd HH:mm");
            DateTime datareg = DateTime.Now;
            if (sinistro.ItemSegurado.ToString() == "Veiculo")
            {

                query = "INSERT INTO [dbo].[TB_SINISTRO_VEICULO] ([SIN_ITEMSEG],[SIN_SEGURO],[SIN_DESCRICAO],[SIN_DATAHORA],[SIN_DATAREGISTRO])" +
                    "VALUES ('" + sinistro.Item + "', " + numapolice + ", '" + sinistro.Descricao + "', '" + data + "','" + datareg.ToShortDateString() + "')";
            }
            else if (sinistro.ItemSegurado.ToString() == "Motorista")
            {
                query = "INSERT INTO [dbo].[TB_SINISTRO_MOTORISTA] ([SIN_ITEMSEG],[SIN_SEGURO],[SIN_DESCRICAO],[SIN_DATAHORA],[SIN_DATAREGISTRO])" +
                    "VALUES ('" + sinistro.Item + "', " + numapolice + ", '" + sinistro.Descricao + "', '" + data + "','" + datareg.ToShortDateString() + "')";
            }
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Sinistro BuscarSinistro(int id, DateTime data, string item, string tipo)
        {
            string Query = "";
            TipoSeguro tiposeg;
            string datahora = data.ToString("yyyy/MM/dd HH:mm");

            if (tipo.ToString() == "Veiculo")
            {
                Query = "SELECT * FROM [dbo].[TB_SINISTRO_VEICULO] WHERE [SIN_ID] = " + id + " AND [SIN_DATAHORA] = '" + datahora + "'";
                tiposeg = TipoSeguro.Automóvel;
            }
            else
            {
                Query = "SELECT * FROM [dbo].[TB_SINISTRO_MOTORISTA] WHERE [SIN_ID] = " + id + " AND [SIN_DATAHORA] = '" + datahora + "'";
                tiposeg = TipoSeguro.Vida;
            }
            try { 
                DataTable dt = _banco.BuscarRegistro(Query);
                Sinistro sinistro = null;
                DataRow[] dataRows = dt.Select("[SIN_ID] = " + id);
                
                foreach (DataRow dr in dataRows)
                {
                    int idsin = int.Parse(dr["SIN_ID"].ToString());
                    DateTime datasin = DateTime.Parse(dr["SIN_DATAHORA"].ToString());
                    string itemseg = dr["SIN_ITEMSEG"].ToString();
                    //ItemSegurado item = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), dr["SIN_ITEMSEG"].ToString());
                    
                    long napolice = long.Parse(dr["SIN_SEGURO"].ToString());
                    Seguro seguro = BuscarSeguro(tiposeg, napolice);

                    sinistro = new Sinistro(idsin, itemseg, dr["SIN_DESCRICAO"].ToString(), datasin, seguro);
                }
                return sinistro;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Sinistro> BuscarTodos(string tipo, DateTime dtinicio, DateTime dtfim)
        {
            List<Sinistro> sinistros = new List<Sinistro>();
            string query = "";
            TipoSeguro tiposeg;

            if(tipo == "Veiculo")
            {
                query = "SELECT * FROM [dbo].[TB_SINISTRO_VEICULO]"+
                        "WHERE ((YEAR([SIN_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([SIN_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                        "AND MONTH([SIN_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([SIN_DATAREGISTRO]) <= '" + dtfim.Month + "')";
                tiposeg = TipoSeguro.Automóvel;
            }
            else
            {
                query = "SELECT * FROM [dbo].[TB_SINISTRO_MOTORISTA]"+
                        "WHERE ((YEAR([SIN_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([SIN_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                        "AND MONTH([SIN_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([SIN_DATAREGISTRO]) <= '" + dtfim.Month + "')";
                tiposeg = TipoSeguro.Vida;
            }
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Sinistro sinistro = null;
                DataRow[] dataRows = dt.Select();

                foreach (DataRow dr in dataRows)
                {
                    int idsin = int.Parse(dr["SIN_ID"].ToString());
                    DateTime datasin = DateTime.Parse(dr["SIN_DATAHORA"].ToString());
                    string item = dr["SIN_ITEMSEG"].ToString();
                    //ItemSegurado item = (ItemSegurado)Enum.Parse(typeof(ItemSegurado), dr["SIN_ITEMSEG"].ToString());
                    long napolice = long.Parse(dr["SIN_SEGURO"].ToString());
                    Seguro seguro = BuscarSeguro(tiposeg, napolice);
                    sinistro = new Sinistro(idsin, item, dr["SIN_DESCRICAO"].ToString(), datasin, seguro);

                    sinistros.Add(sinistro);
                }

                return sinistros;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(Sinistro sinistro, int id, DateTime data, string tipo)
        {
            string dataantiga = data.ToString("yyyy/MM/dd hh:mm");
            string query = "";

            if (tipo == "Veiculo")
            {
                query = "DELETE [dbo].[TB_SINISTRO_VEICULO] WHERE [SIN_ID] = " + id + " AND [SIN_DATAHORA] = '" + dataantiga + "'";
            }
            else if (tipo == "Motorista")
            {
                query = "DELETE [dbo].[TB_SINISTRO_MOTORISTA] WHERE [SIN_ID] = " + id + " AND [SIN_DATAHORA] = '" + dataantiga + "'";
            }
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Sinistro sinistro, int id, DateTime data, long numapolice, string tipo)
        {
            string query = "";

            string datahora = sinistro.DataHora.ToString("yyyy/MM/dd hh:mm");
            string dataantiga = data.ToString("yyyy/MM/dd hh:mm");
            if (tipo == "Veiculo")
            {

                query = "UPDATE [dbo].[TB_SINISTRO_VEICULO] SET[SIN_ITEMSEG] = '" + sinistro.Item + "', [SIN_SEGURO] = " + numapolice + ", [SIN_DESCRICAO] = '" + sinistro.Descricao + "', [SIN_DATAHORA] = '" + datahora + "' " +
                    "WHERE [SIN_ID] = " + id + " AND SIN_DATAHORA = '" + dataantiga + "'";
    }
            else if (tipo == "Motorista")
            {
                query = "UPDATE [dbo].[TB_SINISTRO_MOTORISTA] SET[SIN_ITEMSEG] = '" + sinistro.Item + "', [SIN_SEGURO] = " + numapolice + ", [SIN_DESCRICAO] = '" + sinistro.Descricao + "', [SIN_DATAHORA] = '" + datahora + "'" +
                    "WHERE [SIN_ID] = " + id + " AND SIN_DATAHORA = '" + dataantiga + "'";
            }
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public int PopulaID(string tipo)
        {
            string Query = "";
            if(tipo == "Veiculo")
            {
                Query = "SELECT MAX(SIN_ID) AS ID FROM [dbo].[TB_SINISTRO_VEICULO]";
            }
            else
            {
                Query = "SELECT MAX(SIN_ID) AS ID FROM [dbo].[TB_SINISTRO_MOTORISTA]";               
            }
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
        public DataTable PopularPlacas()
        {
            string query = "SELECT [VCL_MODELO] + ' - ' + [VCL_PLACA] as MODELO, [VCL_PLACA] FROM [DB_GERENCFROTA].[dbo].[TB_VEICULOS]	WHERE [VCL_SITUACAO] = 1";
            try
            {
                return _banco.BuscarRegistro(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public DataTable PopularCPFs()
        {
            string query = "SELECT [MT_NOME] + ' - ' + [MT_CPF] as MOTORISTA, [MT_CPF] FROM [DB_GERENCFROTA].[dbo].[TB_MOTORISTA]	WHERE [MT_SITUACAO] = 1";
            try
            {
                return _banco.BuscarRegistro(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public DataTable PopularSeguroCPFs(string cpf)
        {
            string query = "SELECT CONCAT('Nº Apólice: ',[SEG_NUMAPOLICE]) AS APOLICE, [SEG_NUMAPOLICE] FROM [dbo].[TB_SEGURO_MOTORISTA] WHERE [SEG_ITEMSEG_CPF] = '" + cpf + "'";
            try
            {
                return _banco.BuscarRegistro(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public DataTable PopularSeguroPlacas(string placa)
        {
            string query = "SELECT CONCAT('Nº Apólice: ',[SEG_NUMAPOLICE]) AS APOLICE, [SEG_NUMAPOLICE] FROM [dbo].[TB_SEGURO_VEICULO] WHERE [SEG_ITEMSEG_PLACA] = '" + placa + "'";
            try
            {
                return _banco.BuscarRegistro(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public Seguro BuscarSeguro(TipoSeguro tipo, long numeroApolice)
        {
            string Query = "";

            if (tipo.ToString() == "Automóvel")
            {
                Query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_PLACA], [SEG_VALOR], [SEG_DATAINICIO]," +
                    " [SEG_FIMVIGENCIA], [SEG_FRANQUIA], [SEG_VALORFRANQUIA] FROM [dbo].[TB_SEGURO_VEICULO] WHERE[SEG_NUMAPOLICE] = " + numeroApolice;
            }
            else if (tipo.ToString() == "Vida")
            {
                Query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_CPF], [SEG_VALOR], [SEG_DATAINICIO]," +
                    " [SEG_FIMVIGENCIA] FROM [dbo].[TB_SEGURO_MOTORISTA] WHERE [SEG_NUMAPOLICE] = " + numeroApolice;
            }
            try
            {
                DataTable dt = _banco.BuscarRegistro(Query);
                Seguro seguro = null;
                DataRow[] dataRows = dt.Select("[SEG_NUMAPOLICE] = " + numeroApolice);
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEG_NUMAPOLICE"].ToString());
                    long cNPJ = long.Parse(dr["SEG_SEGURADORA"].ToString());
                    double valor = double.Parse(dr["SEG_VALOR"].ToString());
                    DateTime dataInicio = Convert.ToDateTime(dr["SEG_DATAINICIO"].ToString());
                    DateTime dataFim = Convert.ToDateTime(dr["SEG_FIMVIGENCIA"].ToString());

                    if (tipo.ToString() == "Automóvel")
                    {
                        double valorFranquia = double.Parse(dr["SEG_VALOR"].ToString());

                        seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_PLACA"].ToString(), tipo, valor, dataInicio, dataFim, dr["SEG_FRANQUIA"].ToString(), valor, cNPJ);
                    }
                    else if (tipo.ToString() == "Vida")
                    {
                        seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_CPF"].ToString(), tipo, valor, dataInicio, dataFim, cNPJ);
                    }
                }
                return seguro;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }
    }
}
