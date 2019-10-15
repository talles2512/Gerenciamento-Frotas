﻿using System;
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
    public class EntradaSaidaDAL
    {
        private readonly Banco _banco;

        public EntradaSaidaDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(EntradaSaida entradaSaida) //Verificar Query
        {
            string query = "INSERT INTO[dbo].[TB_ENTRADA_SAIDA] ([ES_MT_CPF],[ES_VCL_PLACA],[ES_SERVEXT_CNPJ],[ES_TIPO],[ES_DATAHORA]) " +
                "VALUES ('" + entradaSaida.CPF + "', '" + entradaSaida.Placa + "', " + entradaSaida.CNPJ + ", '" + entradaSaida.Tipo.ToString() + "', '" + entradaSaida.DataHora.ToString() + "')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data) // Modificado
        {
            string Query = "DELETE [dbo].[TB_ENTRADA_SAIDA] WHERE [ES_VCL_PLACA] = '" + placa + "' AND [ES_SERVEXT_CNPJ] = " + cnpj
                + " AND [ES_TIPO] = '" + tipo.ToString() + "' AND [ES_DATAHORA] = '" + data + "'";
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(EntradaSaida entradaSaida, string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data) // Modificado
        {
            string Query = "UPDATE [dbo].[TB_ENTRADA_SAIDA] SET [ES_MT_CPF] = '" + entradaSaida.CPF + "', [ES_VCL_PLACA] = '"
                + entradaSaida.Placa + "',[ES_SERVEXT_CNPJ] = " + entradaSaida.CNPJ + ", [ES_TIPO] ='" + entradaSaida.Tipo.ToString()
                + "', [ES_DATAHORA] ='" + entradaSaida.DataHora + "' WHERE [ES_VCL_PLACA] = '" + placa + "' AND [ES_SERVEXT_CNPJ] = " + cnpj 
                + " AND [ES_TIPO] = '" + tipo.ToString() + "' AND [ES_DATAHORA] = '" + data + "'";
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public EntradaSaida BuscarEntradaSaida(string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data)
        {
            string query = "SELECT [ES_ID], [ES_MT_CPF], [ES_VCL_PLACA], [ES_SERVEXT_CNPJ], [ES_TIPO], [ES_DATAHORA]" +
                "FROM[TB_ENTRADA_SAIDA] WHERE [ES_VCL_PLACA] = '" + placa + "' AND [ES_SERVEXT_CNPJ] = " + cnpj 
                + " AND [ES_TIPO] = '" + tipo.ToString() + "'  AND [ES_DATAHORA] = '" + data + "'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                EntradaSaida entradaSaida = null;
                DataRow[] dataRows = dt.Select("[ES_VCL_PLACA] = '" + placa + "' AND [ES_SERVEXT_CNPJ] = " + cnpj
                + " AND [ES_TIPO] = '" + tipo.ToString() + "'  AND [ES_DATAHORA] = '" + data + "'");
                foreach (DataRow dr in dataRows)
                {
                    EntradaSaidaTipo entradaSaidaTipo = (EntradaSaidaTipo)Enum.Parse(typeof(EntradaSaidaTipo), dr["ES_TIPO"].ToString());
                    long cNPJ = long.Parse(dr["ES_SERVEXT_CNPJ"].ToString());
                    DateTime dataHora = Convert.ToDateTime(dr["ES_DATAHORA"].ToString());

                    entradaSaida = new EntradaSaida(entradaSaidaTipo, dataHora, dr["ES_MT_CPF"].ToString(), dr["ES_VCL_PLACA"].ToString(), cNPJ);
                }
                return entradaSaida;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<EntradaSaida> BuscarTodos(long cnpj)
        {
            List<EntradaSaida> entradasSaidas = new List<EntradaSaida>();
            string query = "SELECT [ES_ID], [ES_MT_CPF], [ES_VCL_PLACA], [ES_SERVEXT_CNPJ], [ES_TIPO], [ES_DATAHORA]" +
                " FROM [DB_GERENCFROTA].[dbo].[TB_ENTRADA_SAIDA] WHERE [ES_SERVEXT_CNPJ] = " + cnpj;
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                EntradaSaida entradaSaida = null;
                DataRow[] dataRows = dt.Select("[ES_SERVEXT_CNPJ] = " + cnpj);
                foreach (DataRow dr in dataRows)
                {
                    EntradaSaidaTipo entradaSaidaTipo = (EntradaSaidaTipo)Enum.Parse(typeof(EntradaSaidaTipo), dr["ES_TIPO"].ToString());
                    long cNPJ = long.Parse(dr["ES_SERVEXT_CNPJ"].ToString());
                    DateTime dataHora = Convert.ToDateTime(dr["ES_DATAHORA"].ToString());

                    entradaSaida = new EntradaSaida(entradaSaidaTipo, dataHora, dr["ES_MT_CPF"].ToString(), dr["ES_VCL_PLACA"].ToString(), cNPJ);
                    entradasSaidas.Add(entradaSaida);
                }
                return entradasSaidas;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<EntradaSaida> BuscarTodos()
        {
            List<EntradaSaida> entradasSaidas = new List<EntradaSaida>();
            string query = "SELECT [ES_ID], [ES_MT_CPF], [ES_VCL_PLACA], [ES_SERVEXT_CNPJ], [ES_TIPO], [ES_DATAHORA]" +
                " FROM [DB_GERENCFROTA].[dbo].[TB_ENTRADA_SAIDA]";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                EntradaSaida entradaSaida = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    EntradaSaidaTipo entradaSaidaTipo = (EntradaSaidaTipo)Enum.Parse(typeof(EntradaSaidaTipo), dr["ES_TIPO"].ToString());
                    long cNPJ = long.Parse(dr["ES_SERVEXT_CNPJ"].ToString());
                    DateTime dataHora = Convert.ToDateTime(dr["ES_DATAHORA"].ToString());

                    entradaSaida = new EntradaSaida(entradaSaidaTipo, dataHora, dr["ES_MT_CPF"].ToString(), dr["ES_VCL_PLACA"].ToString(), cNPJ);
                    entradasSaidas.Add(entradaSaida);
                }
                return entradasSaidas;
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

        public DataTable PopularServicosExternos()
        {
            string query = "SELECT [SERVEXT_CNPJ], [SERVEXT_NOME] FROM [DB_GERENCFROTA].[dbo].[TB_SERVICOS_EXTERNOS] WHERE [SERVEXT_TIPO] = 'GaragemEstacionamento'";
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
