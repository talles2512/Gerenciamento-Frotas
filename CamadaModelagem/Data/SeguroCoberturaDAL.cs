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
    public class SeguroCoberturaDAL
    {
        private readonly Banco _banco;

        public SeguroCoberturaDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(SeguroCobertura seguroCobertura)
        {
            string query = "";
            DateTime datareg = DateTime.Now;

            if (seguroCobertura.Tipo.ToString() == "Automóvel")
            {
                query = " INSERT INTO[dbo].[TB_SEGCOBERTURA_VEICULO] ([SEGC_DESCRICAO],[SEGC_SEGURO_NUMAPOLICE],[SEGC_DATAREGISTRO])"
                    + "VALUES('" + seguroCobertura.Descricao + "', " + seguroCobertura.NumeroApolice + ",'" + datareg.ToShortDateString() + "')";
            }
            else if (seguroCobertura.Tipo.ToString() == "Vida")
            {
                query = " INSERT INTO[dbo].[TB_SEGCOBERTURA_MOTORISTA] ([SEGC_DESCRICAO],[SEGC_SEGURO_NUMAPOLICE],[SEGC_DATAREGISTRO])"
                    + "VALUES('" + seguroCobertura.Descricao + "', " + seguroCobertura.NumeroApolice + ",'" + datareg.ToShortDateString() + "')";
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
                Query = "DELETE FROM [dbo].[TB_SEGCOBERTURA_VEICULO] WHERE[SEGC_SEGURO_NUMAPOLICE] = " + numeroApolice;
            }
            else if (tipo.ToString() == "Vida")
            {
                Query = "DELETE FROM [dbo].[TB_SEGCOBERTURA_MOTORISTA] WHERE[SEGC_SEGURO_NUMAPOLICE] = " + numeroApolice;
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

        public bool Alterar(SeguroCobertura seguroCobertura, TipoSeguro tipo, long numeroApolice)
        {
            string Query = "";

            if (tipo.ToString() == "Automóvel")
            {
                Query = "UPDATE [dbo].[TB_SEGCOBERTURA_VEICULO] SET [SEGC_DESCRICAO] ='" + seguroCobertura.Descricao + "',[SEGC_SEGURO_NUMAPOLICE] =" + seguroCobertura.NumeroApolice + " WHERE [SEGC_SEGURO_NUMAPOLICE] =" + numeroApolice;
            }
            else if (tipo.ToString() == "Vida")
            {
                Query = "UPDATE [dbo].[TB_SEGCOBERTURA_MOTORISTA] SET [SEGC_DESCRICAO] ='" + seguroCobertura.Descricao + "',[SEGC_SEGURO_NUMAPOLICE] =" + seguroCobertura.NumeroApolice + " WHERE [SEGC_SEGURO_NUMAPOLICE] =" + numeroApolice;
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

        public SeguroCobertura BuscarSeguroCobertura(TipoSeguro tipo, long numeroApolice)
        {
            string Query = "";

            if (tipo.ToString() == "Automóvel")
            {
                Query = "SELECT [SEGC_ID], [SEGC_DESCRICAO], [SEGC_SEGURO_NUMAPOLICE]" +
                    " FROM [dbo].[TB_SEGCOBERTURA_VEICULO] WHERE [SEGC_SEGURO_NUMAPOLICE] = " + numeroApolice;
            }
            else if (tipo.ToString() == "Vida")
            {
                Query = "SELECT [SEGC_ID], [SEGC_DESCRICAO], [SEGC_SEGURO_NUMAPOLICE]" +
                    " FROM [dbo].[TB_SEGCOBERTURA_MOTORISTA] WHERE [SEGC_SEGURO_NUMAPOLICE] = " + numeroApolice;
            }
            try
            {
                DataTable dt = _banco.BuscarRegistro(Query);
                SeguroCobertura seguroCobertura = null;
                DataRow[] dataRows = dt.Select("[SEGC_SEGURO_NUMAPOLICE] = " + numeroApolice);
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEGC_SEGURO_NUMAPOLICE"].ToString());

                    seguroCobertura = new SeguroCobertura(tipo, dr["SEGC_DESCRICAO"].ToString(), numApolice);
                }
                return seguroCobertura;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<SeguroCobertura> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<SeguroCobertura> seguroCoberturas = new List<SeguroCobertura>();
            string Query = "";
            Query = "SELECT [SEGC_ID], [SEGC_DESCRICAO], [SEGC_SEGURO_NUMAPOLICE]" +
                    " FROM [dbo].[TB_SEGCOBERTURA_VEICULO]" +
                    "WHERE ((YEAR([SEGC_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([SEGC_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                    "AND MONTH([SEGC_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([SEGC_DATAREGISTRO]) <= '" + dtfim.Month + "')";
            try
            {
                DataTable dt = _banco.BuscarRegistro(Query);
                SeguroCobertura seguroCobertura = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEGC_SEGURO_NUMAPOLICE"].ToString());
                    TipoSeguro tipo = TipoSeguro.Automóvel;
                    seguroCobertura = new SeguroCobertura(tipo, dr["SEGC_DESCRICAO"].ToString(), numApolice);
                    seguroCoberturas.Add(seguroCobertura);
                }

                Query = "SELECT [SEGC_ID], [SEGC_DESCRICAO], [SEGC_SEGURO_NUMAPOLICE]" +
                    " FROM [dbo].[TB_SEGCOBERTURA_MOTORISTA]" +
                    "WHERE ((YEAR([SEGC_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([SEGC_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                    "AND MONTH([SEGC_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([SEGC_DATAREGISTRO]) <= '" + dtfim.Month + "')";

                dt = _banco.BuscarRegistro(Query);
                seguroCobertura = null;
                dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    long numApolice = long.Parse(dr["SEGC_SEGURO_NUMAPOLICE"].ToString());
                    TipoSeguro tipo = TipoSeguro.Vida;
                    seguroCobertura = new SeguroCobertura(tipo, dr["SEGC_DESCRICAO"].ToString(), numApolice);
                    seguroCoberturas.Add(seguroCobertura);
                }
                return seguroCoberturas;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public DataTable PopularSeguros(TipoSeguro tipo)
        {
            string query = "";

            if (tipo.ToString() == "Automóvel")
            {
                query = "SELECT [SEG_NUMAPOLICE] FROM [dbo].[TB_SEGURO_VEICULO]";
            }
            else if (tipo.ToString() == "Vida")
            {
                query = "SELECT [SEG_NUMAPOLICE] FROM [dbo].[TB_SEGURO_MOTORISTA]";
            }

            try
            {
                return _banco.BuscarRegistro(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }
    }
}
