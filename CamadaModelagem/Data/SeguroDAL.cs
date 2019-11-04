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
    public class SeguroDAL
    {
        private readonly Banco _banco;

        public SeguroDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(Seguro seguro)
        {
            string query = "";
            DateTime datareg = DateTime.Now;

            if(seguro.Tipo.ToString() == "Automóvel")
            {
                query = " INSERT INTO [dbo].[TB_SEGURO_VEICULO]([SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_PLACA], [SEG_VALOR],"
                        + " [SEG_DATAINICIO], [SEG_FIMVIGENCIA], [SEG_FRANQUIA], [SEG_VALORFRANQUIA], [SEG_DATAREGISTRO]) VALUES(" + seguro.NumeroApolice
                        + ", " + seguro.CNPJ + ", '" + seguro.ItemSegurado + "', " + seguro.Valor + ", '"
                        + seguro.DataInicio.ToShortDateString() + "', '" + seguro.FimVigencia.ToShortDateString() 
                        + "', '" + seguro.Franquia + "', " + seguro.ValorFranquia + ",'" + datareg.ToShortDateString() + "')";
            }
            else if(seguro.Tipo.ToString() == "Vida")
            {
                query = " INSERT INTO [dbo].[TB_SEGURO_MOTORISTA]([SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_CPF], [SEG_VALOR],"
                        + " [SEG_DATAINICIO], [SEG_FIMVIGENCIA], [SEG_DATAREGISTRO]) VALUES(" + seguro.NumeroApolice + ", " + seguro.CNPJ + ", '" 
                        + seguro.ItemSegurado + "', " + seguro.Valor + ", '" + seguro.DataInicio.ToShortDateString() + "', '"
                        + seguro.FimVigencia.ToShortDateString() + "','" + datareg.ToShortDateString() + "')";
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

        public bool Deletar(TipoSeguro tipo, long numeroApolice)
        {
            string Query = "";

            if (tipo.ToString() == "Automóvel")
            {
                Query = "DELETE FROM [dbo].[TB_SEGURO_VEICULO] WHERE[SEG_NUMAPOLICE] = " + numeroApolice;
            }
            else if(tipo.ToString() == "Vida")
            {
                Query = "DELETE FROM [dbo].[TB_SEGURO_MOTORISTA] WHERE[SEG_NUMAPOLICE] = " + numeroApolice;
            }
            
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Seguro seguro, TipoSeguro tipo, long numeroApolice)
        {
            string Query = "";

            if (tipo.ToString() == "Automóvel")
            {
                Query = "UPDATE [dbo].[TB_SEGURO_VEICULO] SET [SEG_NUMAPOLICE] = " + seguro.NumeroApolice + ", [SEG_SEGURADORA] =" + seguro.CNPJ + "  ,"
                    + "[SEG_ITEMSEG_PLACA] ='" + seguro.ItemSegurado +"', [SEG_VALOR] =" + seguro.Valor +",[SEG_DATAINICIO] ='" + seguro.DataInicio.ToShortDateString() + "', " +
                    "[SEG_FIMVIGENCIA] ='" + seguro.FimVigencia.ToShortDateString() +"', [SEG_FRANQUIA] ='" + seguro.Franquia +"', [SEG_VALORFRANQUIA] = " + seguro.ValorFranquia
                    + " WHERE [SEG_NUMAPOLICE] =" + numeroApolice;
            }
            else if (tipo.ToString() == "Vida")
            {
                Query = "UPDATE [dbo].[TB_SEGURO_MOTORISTA] SET [SEG_NUMAPOLICE] = " + seguro.NumeroApolice + ", [SEG_SEGURADORA] =" + seguro.CNPJ + "  ,"
                    + "[SEG_ITEMSEG_CPF] ='" + seguro.ItemSegurado + "', [SEG_VALOR] =" + seguro.Valor + ",[SEG_DATAINICIO] ='" + seguro.DataInicio.ToShortDateString() + "', " +
                    "[SEG_FIMVIGENCIA] ='" + seguro.FimVigencia.ToShortDateString() + "' WHERE [SEG_NUMAPOLICE] =" + numeroApolice;
            }

            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
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
                        double valorFranquia = double.Parse(dr["SEG_VALORFRANQUIA"].ToString());

                        seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_PLACA"].ToString(), tipo, valor, dataInicio, dataFim, dr["SEG_FRANQUIA"].ToString(), valorFranquia, cNPJ);
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

        public Seguro BuscarSeguro(TipoSeguro tipo, string itemSegurado)
        {
            string Query = "";

            if (tipo.ToString() == "Automóvel")
            {
                Query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_PLACA], [SEG_VALOR], [SEG_DATAINICIO]," +
                    " [SEG_FIMVIGENCIA], [SEG_FRANQUIA], [SEG_VALORFRANQUIA] FROM [dbo].[TB_SEGURO_VEICULO] WHERE[SEG_ITEMSEG_PLACA] = '" + itemSegurado +"'";
            }
            else if (tipo.ToString() == "Vida")
            {
                Query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_CPF], [SEG_VALOR], [SEG_DATAINICIO]," +
                    " [SEG_FIMVIGENCIA] FROM [dbo].[TB_SEGURO_MOTORISTA] WHERE [SEG_ITEMSEG_CPF] = '" + itemSegurado + "'";
            }
            try
            {
                DataTable dt = _banco.BuscarRegistro(Query);
                Seguro seguro = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEG_NUMAPOLICE"].ToString());
                    long cNPJ = long.Parse(dr["SEG_SEGURADORA"].ToString());
                    double valor = double.Parse(dr["SEG_VALOR"].ToString());
                    DateTime dataInicio = Convert.ToDateTime(dr["SEG_DATAINICIO"].ToString());
                    DateTime dataFim = Convert.ToDateTime(dr["SEG_FIMVIGENCIA"].ToString());

                    if (tipo.ToString() == "Automóvel")
                    {
                        double valorFranquia = double.Parse(dr["SEG_VALORFRANQUIA"].ToString());

                        seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_PLACA"].ToString(), tipo, valor, dataInicio, dataFim, dr["SEG_FRANQUIA"].ToString(), valorFranquia, cNPJ);
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

        public List<Seguro> BuscarTodos(long cnpj)
        {
            List<Seguro> seguros = new List<Seguro>();
            string Query = "";
            Query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_PLACA], [SEG_VALOR], [SEG_DATAINICIO]," +
                    " [SEG_FIMVIGENCIA], [SEG_FRANQUIA], [SEG_VALORFRANQUIA] FROM [dbo].[TB_SEGURO_VEICULO] WHERE[SEG_SEGURADORA] = " + cnpj;
            try
            {
                DataTable dt = _banco.BuscarRegistro(Query);
                Seguro seguro = null;
                DataRow[] dataRows = dt.Select("[SEG_SEGURADORA] = " + cnpj);
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEG_NUMAPOLICE"].ToString());
                    long cNPJ = long.Parse(dr["SEG_SEGURADORA"].ToString());
                    double valor = double.Parse(dr["SEG_VALOR"].ToString());
                    DateTime dataInicio = Convert.ToDateTime(dr["SEG_DATAINICIO"].ToString());
                    DateTime dataFim = Convert.ToDateTime(dr["SEG_FIMVIGENCIA"].ToString());
                    double valorFranquia = double.Parse(dr["SEG_VALORFRANQUIA"].ToString());
                    TipoSeguro tipo = TipoSeguro.Automóvel;
                    seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_PLACA"].ToString(), tipo, valor, dataInicio, dataFim, dr["SEG_FRANQUIA"].ToString(), valorFranquia, cNPJ);
                    seguros.Add(seguro);
                }
                Query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_CPF], [SEG_VALOR], [SEG_DATAINICIO]," +
                " [SEG_FIMVIGENCIA] FROM [dbo].[TB_SEGURO_MOTORISTA] WHERE [SEG_SEGURADORA] = " + cnpj;
                dt = _banco.BuscarRegistro(Query);
                seguro = null;
                dataRows = dt.Select("[SEG_SEGURADORA] = " + cnpj);
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEG_NUMAPOLICE"].ToString());
                    long cNPJ = long.Parse(dr["SEG_SEGURADORA"].ToString());
                    double valor = double.Parse(dr["SEG_VALOR"].ToString());
                    DateTime dataInicio = Convert.ToDateTime(dr["SEG_DATAINICIO"].ToString());
                    DateTime dataFim = Convert.ToDateTime(dr["SEG_FIMVIGENCIA"].ToString());
                    TipoSeguro tipo = TipoSeguro.Vida;
                    seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_CPF"].ToString(), tipo, valor, dataInicio, dataFim, cNPJ);
                    seguros.Add(seguro);
                }
                return seguros;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Seguro> BuscarTodos(string placa)
        {
            List<Seguro> seguros = new List<Seguro>();
            string Query = "";
            Query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_PLACA], [SEG_VALOR], [SEG_DATAINICIO]," +
                    " [SEG_FIMVIGENCIA], [SEG_FRANQUIA], [SEG_VALORFRANQUIA] FROM [dbo].[TB_SEGURO_VEICULO] WHERE[SEG_ITEMSEG_PLACA] = '" + placa +"'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(Query);
                Seguro seguro = null;
                DataRow[] dataRows = dt.Select("[SEG_ITEMSEG_PLACA] = '" + placa + "'");
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEG_NUMAPOLICE"].ToString());
                    long cNPJ = long.Parse(dr["SEG_SEGURADORA"].ToString());
                    double valor = double.Parse(dr["SEG_VALOR"].ToString());
                    DateTime dataInicio = Convert.ToDateTime(dr["SEG_DATAINICIO"].ToString());
                    DateTime dataFim = Convert.ToDateTime(dr["SEG_FIMVIGENCIA"].ToString());
                    double valorFranquia = double.Parse(dr["SEG_VALORFRANQUIA"].ToString());
                    TipoSeguro tipo = TipoSeguro.Automóvel;
                    seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_PLACA"].ToString(), tipo, valor, dataInicio, dataFim, dr["SEG_FRANQUIA"].ToString(), valorFranquia, cNPJ);
                    seguros.Add(seguro);
                }
                return seguros;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Seguro> BuscarTodosMotoristas(string cpf)
        {
            List<Seguro> seguros = new List<Seguro>();
            string Query = "";
            Query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_CPF], [SEG_VALOR], [SEG_DATAINICIO]," +
                    " [SEG_FIMVIGENCIA] FROM [dbo].[TB_SEGURO_MOTORISTA] WHERE[SEG_ITEMSEG_CPF] = '" + cpf + "'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(Query);
                Seguro seguro = null;
                DataRow[] dataRows = dt.Select("[SEG_ITEMSEG_CPF] = '" + cpf + "'");
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEG_NUMAPOLICE"].ToString());
                    long cNPJ = long.Parse(dr["SEG_SEGURADORA"].ToString());
                    double valor = double.Parse(dr["SEG_VALOR"].ToString());
                    DateTime dataInicio = Convert.ToDateTime(dr["SEG_DATAINICIO"].ToString());
                    DateTime dataFim = Convert.ToDateTime(dr["SEG_FIMVIGENCIA"].ToString());
                    TipoSeguro tipo = TipoSeguro.Automóvel;
                    seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_CPF"].ToString(), tipo, valor, dataInicio, dataFim, cNPJ);
                    seguros.Add(seguro);
                }
                return seguros;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Seguro> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Seguro> seguros = new List<Seguro>();

            string Query = "";
            Query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_PLACA], [SEG_VALOR], [SEG_DATAINICIO]," +
                    " [SEG_FIMVIGENCIA], [SEG_FRANQUIA], [SEG_VALORFRANQUIA] FROM [dbo].[TB_SEGURO_VEICULO]" +
                    "WHERE ((YEAR([SEG_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([SEG_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                    "AND MONTH([SEG_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([SEG_DATAREGISTRO]) <= '" + dtfim.Month + "')";

            try
            {
                DataTable dt = _banco.BuscarRegistro(Query);
                Seguro seguro = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEG_NUMAPOLICE"].ToString());
                    long cNPJ = long.Parse(dr["SEG_SEGURADORA"].ToString());
                    double valor = double.Parse(dr["SEG_VALOR"].ToString());
                    DateTime dataInicio = Convert.ToDateTime(dr["SEG_DATAINICIO"].ToString());
                    DateTime dataFim = Convert.ToDateTime(dr["SEG_FIMVIGENCIA"].ToString());
                    double valorFranquia = double.Parse(dr["SEG_VALORFRANQUIA"].ToString());
                    TipoSeguro tipo = TipoSeguro.Automóvel;
                    seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_PLACA"].ToString(), tipo, valor, dataInicio, dataFim, dr["SEG_FRANQUIA"].ToString(), valorFranquia, cNPJ);
                    seguros.Add(seguro);
                }

                Query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_CPF], [SEG_VALOR], [SEG_DATAINICIO]," +
                    " [SEG_FIMVIGENCIA] FROM [dbo].[TB_SEGURO_MOTORISTA]" +
                    "WHERE ((YEAR([SEG_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([SEG_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                    "AND MONTH([SEG_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([SEG_DATAREGISTRO]) <= '" + dtfim.Month + "')";

                dt = _banco.BuscarRegistro(Query);
                seguro = null;
                dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEG_NUMAPOLICE"].ToString());
                    long cNPJ = long.Parse(dr["SEG_SEGURADORA"].ToString());
                    double valor = double.Parse(dr["SEG_VALOR"].ToString());
                    DateTime dataInicio = Convert.ToDateTime(dr["SEG_DATAINICIO"].ToString());
                    DateTime dataFim = Convert.ToDateTime(dr["SEG_FIMVIGENCIA"].ToString());
                    TipoSeguro tipo = TipoSeguro.Vida;
                    seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_CPF"].ToString(), tipo, valor, dataInicio, dataFim, cNPJ);
                    seguros.Add(seguro);
                }
                return seguros;
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

        public DataTable PopularServicosExternos()
        {
            string query = "SELECT [SERVEXT_CNPJ], [SERVEXT_NOME] FROM [DB_GERENCFROTA].[dbo].[TB_SERVICOS_EXTERNOS] WHERE [SERVEXT_TIPO] = 'Seguradora'";
            try
            {
                return _banco.BuscarRegistro(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Seguro> Pesquisar(string busca)
        {
            List<Seguro> seguros = new List<Seguro>();
            string query;

            if (busca == "")
            {
                return seguros;
            }

            if (DetectaChar(busca) > 0)
            {
                query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_PLACA], [SEG_VALOR], [SEG_DATAINICIO]," +
                        " [SEG_FIMVIGENCIA], [SEG_FRANQUIA], [SEG_VALORFRANQUIA] FROM [dbo].[TB_SEGURO_VEICULO] JOIN [dbo].[TB_VEICULOS]" +
                        " ON SEG_ITEMSEG_PLACA = VCL_PLACA JOIN [dbo].[TB_SERVICOS_EXTERNOS] ON SEG_SEGURADORA = SERVEXT_CNPJ" +
                        " WHERE (SEG_ITEMSEG_PLACA LIKE '%" + busca + "%' OR VCL_MODELO LIKE '%" + busca + "%'" +
                        " OR VCL_MARCA LIKE '%" + busca + "%' OR SERVEXT_NOME LIKE '%" + busca + "%')";
            }
            else
            {
                query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_PLACA], [SEG_VALOR], [SEG_DATAINICIO]," +
                        " [SEG_FIMVIGENCIA], [SEG_FRANQUIA], [SEG_VALORFRANQUIA] FROM [dbo].[TB_SEGURO_VEICULO] JOIN [dbo].[TB_VEICULOS]" +
                        " ON SEG_ITEMSEG_PLACA = VCL_PLACA JOIN [dbo].[TB_SERVICOS_EXTERNOS] ON SEG_SEGURADORA = SERVEXT_CNPJ" +
                        " WHERE (CONVERT(varchar,SEG_NUMAPOLICE) LIKE '%" + busca + "%' OR CONVERT(varchar,SEG_SEGURADORA) LIKE '%" + busca + "%'" +
                        " OR SEG_ITEMSEG_PLACA LIKE '%" + busca + "%' OR VCL_MODELO LIKE '%" + busca + "%'" +
                        " OR VCL_MARCA LIKE '%" + busca + "%' OR SERVEXT_NOME LIKE '%" + busca + "%')";
            }

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Seguro seguro = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEG_NUMAPOLICE"].ToString());
                    long cNPJ = long.Parse(dr["SEG_SEGURADORA"].ToString());
                    double valor = double.Parse(dr["SEG_VALOR"].ToString());
                    DateTime dataInicio = Convert.ToDateTime(dr["SEG_DATAINICIO"].ToString());
                    DateTime dataFim = Convert.ToDateTime(dr["SEG_FIMVIGENCIA"].ToString());
                    double valorFranquia = double.Parse(dr["SEG_VALORFRANQUIA"].ToString());
                    TipoSeguro tipo = TipoSeguro.Automóvel;
                    seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_PLACA"].ToString(), tipo, valor, dataInicio, dataFim, dr["SEG_FRANQUIA"].ToString(), valorFranquia, cNPJ);
                    seguros.Add(seguro);
                }

                if (DetectaChar(busca) > 0)
                {
                    query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_CPF], [SEG_VALOR], [SEG_DATAINICIO]," +
                    " [SEG_FIMVIGENCIA] FROM [dbo].[TB_SEGURO_MOTORISTA] JOIN [dbo].[TB_MOTORISTA] ON SEG_ITEMSEG_CPF = MT_CPF" +
                    " JOIN [dbo].[TB_SERVICOS_EXTERNOS] ON SEG_SEGURADORA = SERVEXT_CNPJ" +
                    " WHERE (SEG_ITEMSEG_CPF LIKE '%" + busca + "%' OR MT_NOME LIKE '%" + busca + "%'" +
                    " OR SERVEXT_NOME LIKE '%" + busca + "%')";
                }
                else
                {
                    query = "SELECT [SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_CPF], [SEG_VALOR], [SEG_DATAINICIO]," +
                    " [SEG_FIMVIGENCIA] FROM [dbo].[TB_SEGURO_MOTORISTA] JOIN [dbo].[TB_MOTORISTA] ON SEG_ITEMSEG_CPF = MT_CPF" +
                    " JOIN [dbo].[TB_SERVICOS_EXTERNOS] ON SEG_SEGURADORA = SERVEXT_CNPJ" +
                    " WHERE (CONVERT(varchar,SEG_NUMAPOLICE) LIKE '%" + busca + "%' OR CONVERT(varchar,SEG_SEGURADORA) LIKE '%" + busca + "%'" +
                        " OR SEG_ITEMSEG_CPF LIKE '%" + busca + "%' OR MT_NOME LIKE '%" + busca + "%'" +
                        " OR SERVEXT_NOME LIKE '%" + busca + "%')";
                }

                dt = _banco.BuscarRegistro(query);
                seguro = null;
                dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEG_NUMAPOLICE"].ToString());
                    long cNPJ = long.Parse(dr["SEG_SEGURADORA"].ToString());
                    double valor = double.Parse(dr["SEG_VALOR"].ToString());
                    DateTime dataInicio = Convert.ToDateTime(dr["SEG_DATAINICIO"].ToString());
                    DateTime dataFim = Convert.ToDateTime(dr["SEG_FIMVIGENCIA"].ToString());
                    TipoSeguro tipo = TipoSeguro.Vida;
                    seguro = new Seguro(numApolice, dr["SEG_ITEMSEG_CPF"].ToString(), tipo, valor, dataInicio, dataFim, cNPJ);
                    seguros.Add(seguro);
                }
                return seguros;
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
