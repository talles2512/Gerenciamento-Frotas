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
    public class ServicoExternoDAL
    {
        private readonly Banco _banco;

        public ServicoExternoDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(ServicoExterno servicoExterno)
        {
            int conveniado = Convert.ToInt32(servicoExterno.Conveniado);
            string query = "INSERT INTO [dbo].[TB_SERVICOS_EXTERNOS] ([SERVEXT_CNPJ],[SERVEXT_TIPO],[SERVEXT_NOME],[SERVEXT_TELEFONE],[SERVEXT_EMAIL],[SERVEXT_ENDERECO],"
                + "[SERVEXT_CONVENIADO])" + "VALUES (" + servicoExterno.CNPJ + ", '" + servicoExterno.Tipo.ToString() + "', '" + servicoExterno.Nome + "', " + servicoExterno.Telefone + ", '"
                + servicoExterno.Email + "', '" + servicoExterno.Endereco + "', " + conveniado + ")";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool CadastrarConveniado(ServicoExterno servicoExterno)
        {
            int conveniado = Convert.ToInt32(servicoExterno.Conveniado);
            string query1 = "INSERT INTO [dbo].[TB_SERVICOS_EXTERNOS] ([SERVEXT_CNPJ],[SERVEXT_TIPO],[SERVEXT_NOME],[SERVEXT_TELEFONE],[SERVEXT_EMAIL],[SERVEXT_ENDERECO],"
                + "[SERVEXT_CONVENIADO])" + "VALUES (" + servicoExterno.CNPJ + ", '" + servicoExterno.Tipo.ToString() + "', '" + servicoExterno.Nome + "', " + servicoExterno.Telefone + ", '"
                + servicoExterno.Email + "', '" + servicoExterno.Endereco + "', " + conveniado + ")";
            string query2 = "INSERT INTO [dbo].[TB_SERVICOS_EXTERNOS_CONVENIADOS]([SERVEXTCONV_VALOR],[SERVEXTCONV_DTINICIO],[SERVEXTCONV_DTVENC],[SERVEXTCONV_SERVEXT_CNPJ]) " +
                "VALUES(" + servicoExterno.ServicoExternoConveniado.Valor + ", '" + servicoExterno.ServicoExternoConveniado.DataInicio.ToShortDateString() + "', '"
                + servicoExterno.ServicoExternoConveniado.DataVencimento.ToShortDateString() + "', " + servicoExterno.CNPJ + ")";
            try
            {
                return _banco.ExecutaTransaction(query1, query2);
            }
            catch (TransacaoException e)
            {
                throw new TransacaoException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public ServicoExterno BuscarCNPJ(long cnpj)
        {
            string query = "SELECT SERVEXT_CNPJ, SERVEXT_TIPO, SERVEXT_NOME, SERVEXT_TELEFONE, SERVEXT_EMAIL, SERVEXT_ENDERECO, SERVEXT_CONVENIADO " +
                "FROM TB_SERVICOS_EXTERNOS WHERE SERVEXT_CNPJ = " + cnpj;
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                ServicoExternoConveniado servicoExternoConveniado = null;
                ServicoExterno servicoExterno = null;
                DataRow[] dataRows = dt.Select("SERVEXT_CNPJ = " + cnpj);
                foreach (DataRow dr in dataRows)
                {
                    long cNPJ = long.Parse(dr["SERVEXT_CNPJ"].ToString());
                    TipoServicoExterno tipo = (TipoServicoExterno)Enum.Parse(typeof(TipoServicoExterno), dr["SERVEXT_TIPO"].ToString());
                    long telefone = long.Parse(dr["SERVEXT_TELEFONE"].ToString());
                    bool conveniado = bool.Parse(dr["SERVEXT_CONVENIADO"].ToString());


                    servicoExterno = new ServicoExterno(cNPJ, tipo, dr["SERVEXT_NOME"].ToString(), telefone, dr["SERVEXT_EMAIL"].ToString()
                        , dr["SERVEXT_ENDERECO"].ToString()
                        , conveniado, servicoExternoConveniado);
                }
                return servicoExterno;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public ServicoExterno BuscarCNPJConveniado(long cnpj)
        {
            string query = "SELECT S.SERVEXT_CNPJ, S.SERVEXT_TIPO, S.SERVEXT_NOME, S.SERVEXT_TELEFONE, S.SERVEXT_EMAIL, S.SERVEXT_ENDERECO, S.SERVEXT_CONVENIADO " +
                ", C.SERVEXTCONV_VALOR, C.SERVEXTCONV_DTINICIO, C.SERVEXTCONV_DTVENC " +
                "FROM TB_SERVICOS_EXTERNOS as S JOIN TB_SERVICOS_EXTERNOS_CONVENIADOS C " +
                "ON S.SERVEXT_CNPJ = C.SERVEXTCONV_SERVEXT_CNPJ WHERE S.SERVEXT_CNPJ = " + cnpj;
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                ServicoExternoConveniado servicoExternoConveniado = null;
                ServicoExterno servicoExterno = null;
                DataRow[] dataRows = dt.Select("SERVEXT_CNPJ = " + cnpj);
                foreach (DataRow dr in dataRows)
                {
                    long cNPJ = long.Parse(dr["SERVEXT_CNPJ"].ToString());
                    TipoServicoExterno tipo = (TipoServicoExterno)Enum.Parse(typeof(TipoServicoExterno), dr["SERVEXT_TIPO"].ToString());
                    long telefone = long.Parse(dr["SERVEXT_TELEFONE"].ToString());
                    bool conveniado = bool.Parse(dr["SERVEXT_CONVENIADO"].ToString());

                    if (conveniado)
                    {
                        double valor = double.Parse(dr["SERVEXTCONV_VALOR"].ToString());
                        DateTime dtInicio = DateTime.Parse(dr["SERVEXTCONV_DTINICIO"].ToString());
                        DateTime dtVencimento = DateTime.Parse(dr["SERVEXTCONV_DTVENC"].ToString());
                        servicoExternoConveniado = new ServicoExternoConveniado(valor, dtInicio, dtVencimento);
                    }
                    servicoExterno = new ServicoExterno(cNPJ, tipo, dr["SERVEXT_NOME"].ToString(), telefone, dr["SERVEXT_EMAIL"].ToString()
                        , dr["SERVEXT_ENDERECO"].ToString()
                        , conveniado, servicoExternoConveniado);
                }
                return servicoExterno;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<ServicoExterno> BuscarTodos()
        {
            List<ServicoExterno> servicoExternos = new List<ServicoExterno>();
            string query = "SELECT SERVEXT_CNPJ, SERVEXT_TIPO, SERVEXT_NOME, SERVEXT_TELEFONE, SERVEXT_EMAIL, SERVEXT_ENDERECO, SERVEXT_CONVENIADO " +
                "from TB_SERVICOS_EXTERNOS WHERE SERVEXT_CONVENIADO = 0";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                ServicoExternoConveniado servicoExternoConveniado = null;
                ServicoExterno servicoExterno = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    long cNPJ = long.Parse(dr["SERVEXT_CNPJ"].ToString());
                    TipoServicoExterno tipo = (TipoServicoExterno)Enum.Parse(typeof(TipoServicoExterno), dr["SERVEXT_TIPO"].ToString());
                    long telefone = long.Parse(dr["SERVEXT_TELEFONE"].ToString());
                    bool conveniado = bool.Parse(dr["SERVEXT_CONVENIADO"].ToString());


                    servicoExterno = new ServicoExterno(cNPJ, tipo, dr["SERVEXT_NOME"].ToString(), telefone, dr["SERVEXT_EMAIL"].ToString()
                        , dr["SERVEXT_ENDERECO"].ToString()
                        , conveniado, servicoExternoConveniado);
                    servicoExternos.Add(servicoExterno);
                }
                return servicoExternos;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<ServicoExterno> BuscarTodosConveniados()
        {
            List<ServicoExterno> servicoExternos = new List<ServicoExterno>();
            string query = "SELECT S.SERVEXT_CNPJ, S.SERVEXT_TIPO, S.SERVEXT_NOME, S.SERVEXT_TELEFONE, S.SERVEXT_EMAIL, S.SERVEXT_ENDERECO, S.SERVEXT_CONVENIADO " +
                ", C.SERVEXTCONV_VALOR, C.SERVEXTCONV_DTINICIO, C.SERVEXTCONV_DTVENC " +
                "FROM TB_SERVICOS_EXTERNOS as S JOIN TB_SERVICOS_EXTERNOS_CONVENIADOS C " +
                "ON S.SERVEXT_CNPJ = C.SERVEXTCONV_SERVEXT_CNPJ ORDER BY S.SERVEXT_TIPO";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                ServicoExternoConveniado servicoExternoConveniado = null;
                ServicoExterno servicoExterno = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    long cNPJ = long.Parse(dr["SERVEXT_CNPJ"].ToString());
                    TipoServicoExterno tipo = (TipoServicoExterno)Enum.Parse(typeof(TipoServicoExterno), dr["SERVEXT_TIPO"].ToString());
                    long telefone = long.Parse(dr["SERVEXT_TELEFONE"].ToString());
                    bool conveniado = bool.Parse(dr["SERVEXT_CONVENIADO"].ToString());

                    if (conveniado)
                    {
                        double valor = double.Parse(dr["SERVEXTCONV_VALOR"].ToString());
                        DateTime dtInicio = DateTime.Parse(dr["SERVEXTCONV_DTINICIO"].ToString());
                        DateTime dtVencimento = DateTime.Parse(dr["SERVEXTCONV_DTVENC"].ToString());
                        servicoExternoConveniado = new ServicoExternoConveniado(valor, dtInicio, dtVencimento);
                    }
                    servicoExterno = new ServicoExterno(cNPJ, tipo, dr["SERVEXT_NOME"].ToString(), telefone, dr["SERVEXT_EMAIL"].ToString()
                        , dr["SERVEXT_ENDERECO"].ToString()
                        , conveniado, servicoExternoConveniado);
                    servicoExternos.Add(servicoExterno);
                }
                return servicoExternos;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public bool Deletar(long cnpj)
        {
            string query1 = "DELETE FROM [TB_SERVICOS_EXTERNOS_CONVENIADOS] WHERE [SERVEXTCONV_SERVEXT_CNPJ] = " + cnpj;
            string query2 = "DELETE FROM [TB_SERVICOS_EXTERNOS] WHERE [SERVEXT_CNPJ] = " + cnpj;
            try
            {
                return _banco.ExecutaTransaction(query1, query2);
            }
            catch (TransacaoException e)
            {
                throw new TransacaoException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(ServicoExterno servicoExterno, long cnpj)
        {
            int conveniado = Convert.ToInt32(servicoExterno.Conveniado);
            string Query = "UPDATE [dbo].[TB_SERVICOS_EXTERNOS] SET [SERVEXT_CNPJ] =" + servicoExterno.CNPJ + ",[SERVEXT_TIPO] = '" + servicoExterno.Tipo.ToString() + "',[SERVEXT_NOME]='" + servicoExterno.Nome
                + "',[SERVEXT_TELEFONE] =" + servicoExterno.Telefone + ",[SERVEXT_EMAIL] ='" + servicoExterno.Email + "',[SERVEXT_ENDERECO] ='" + servicoExterno.Endereco + "',[SERVEXT_CONVENIADO] ="
                + conveniado + " WHERE [SERVEXT_CNPJ] =" + cnpj;
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool AlterarConveniado(ServicoExterno servicoExterno, long cnpj)
        {
            int conveniado = Convert.ToInt32(servicoExterno.Conveniado);
            string query1 = "";
            string query2 = "";
            try
            {
                ServicoExterno obj = BuscarCNPJConveniado(cnpj); //Definindo quais querys serão usadas dependendo da alteração

                if (obj == null) //Caso altere o serviço externo e adicione seu convênio
                {
                    query1 = "UPDATE [dbo].[TB_SERVICOS_EXTERNOS] SET [SERVEXT_CNPJ] =" + servicoExterno.CNPJ + ",[SERVEXT_TIPO] = '" + servicoExterno.Tipo.ToString() + "',[SERVEXT_NOME]='" + servicoExterno.Nome
                        + "',[SERVEXT_TELEFONE] =" + servicoExterno.Telefone + ",[SERVEXT_EMAIL] ='" + servicoExterno.Email + "',[SERVEXT_ENDERECO] ='" + servicoExterno.Endereco + "',[SERVEXT_CONVENIADO] ="
                        + conveniado + " WHERE [SERVEXT_CNPJ] =" + cnpj;
                    query2 = "INSERT INTO [dbo].[TB_SERVICOS_EXTERNOS_CONVENIADOS]([SERVEXTCONV_VALOR],[SERVEXTCONV_DTINICIO],[SERVEXTCONV_DTVENC],[SERVEXTCONV_SERVEXT_CNPJ]) " +
                "VALUES(" + servicoExterno.ServicoExternoConveniado.Valor + ", '" + servicoExterno.ServicoExternoConveniado.DataInicio.ToShortDateString() + "', '"
                + servicoExterno.ServicoExternoConveniado.DataVencimento.ToShortDateString() + "', " + servicoExterno.CNPJ + ")";
                }

                else if (servicoExterno.ServicoExternoConveniado == null) //Caso o serviço externo e remova seu convênio
                {
                    query1 = "UPDATE [dbo].[TB_SERVICOS_EXTERNOS] SET [SERVEXT_CNPJ] =" + servicoExterno.CNPJ + ",[SERVEXT_TIPO] = '" + servicoExterno.Tipo.ToString() + "',[SERVEXT_NOME]='" + servicoExterno.Nome
                        + "',[SERVEXT_TELEFONE] =" + servicoExterno.Telefone + ",[SERVEXT_EMAIL] ='" + servicoExterno.Email + "',[SERVEXT_ENDERECO] ='" + servicoExterno.Endereco + "',[SERVEXT_CONVENIADO] ="
                        + conveniado + " WHERE [SERVEXT_CNPJ] =" + cnpj;
                    query2 = "DELETE FROM [dbo].[TB_SERVICOS_EXTERNOS_CONVENIADOS] WHERE [SERVEXTCONV_SERVEXT_CNPJ] = " + servicoExterno.CNPJ;
                }
                else  //Caso altere o serviço externo e seu convênio
                {
                    query1 = "UPDATE [dbo].[TB_SERVICOS_EXTERNOS] SET [SERVEXT_CNPJ] =" + servicoExterno.CNPJ + ",[SERVEXT_TIPO] = '" + servicoExterno.Tipo.ToString()
                        + "',[SERVEXT_NOME]='" + servicoExterno.Nome + "',[SERVEXT_TELEFONE] =" + servicoExterno.Telefone + ",[SERVEXT_EMAIL] ='"
                        + servicoExterno.Email + "',[SERVEXT_ENDERECO] ='" + servicoExterno.Endereco + "',[SERVEXT_CONVENIADO] ="
                        + conveniado + " WHERE [SERVEXT_CNPJ] =" + cnpj;
                    query2 = "UPDATE [dbo].[TB_SERVICOS_EXTERNOS_CONVENIADOS] SET [SERVEXTCONV_VALOR] = " + servicoExterno.ServicoExternoConveniado.Valor
                        + ", [SERVEXTCONV_DTINICIO] = '" + servicoExterno.ServicoExternoConveniado.DataInicio.ToShortDateString()
                        + "',[SERVEXTCONV_DTVENC] = '" + servicoExterno.ServicoExternoConveniado.DataVencimento.ToShortDateString()
                        + "',[SERVEXTCONV_SERVEXT_CNPJ] = " + servicoExterno.CNPJ + " WHERE [SERVEXTCONV_SERVEXT_CNPJ] = " + servicoExterno.CNPJ;
                }

                return _banco.ExecutaTransaction(query1, query2);
            }
            catch (TransacaoException e)
            {
                throw new TransacaoException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
