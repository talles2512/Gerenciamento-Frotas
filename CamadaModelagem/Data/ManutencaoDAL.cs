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
    public class ManutencaoDAL
    {
        private readonly Banco _banco;

        public ManutencaoDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(Manutencao manuntencao) //Exemplo Cadastrar
        {
            int tipoManutencao = manuntencao.Tipo.GetHashCode();
            int situacaoManutencao = manuntencao.Situacao.GetHashCode();
            DateTime datareg = DateTime.Now;
            string query = "INSERT INTO [dbo].[TB_MANUTENCAO] ([MTC_TIPO],[MTC_SERVEXT_CNPJ],[MTC_DESCRICAO],[MTC_DATA],[MTC_VALOR],[MTC_SITUACAO],[MTC_VCL_PLACA], [MTC_DATAREGISTRO])" +
                "VALUES (" + tipoManutencao + ", " + manuntencao.CNPJ + ", '" + manuntencao.Descricao + "','" + manuntencao.Data.ToShortDateString() + "', " + manuntencao.Valor + ", " + situacaoManutencao + ", '" + manuntencao.Placa + "', '" + datareg.ToShortDateString() + "')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(string placa, ManutencaoTipo tipo, DateTime data) //Modificado
        {
            int tipoManutencao = tipo.GetHashCode();
            string Query = "DELETE [dbo].[TB_MANUTENCAO] WHERE [MTC_VCL_PLACA] = '" + placa + "' AND [MTC_TIPO] = " + tipoManutencao + " AND [MTC_DATA] = '" + data.ToShortDateString() + "'";
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Manutencao manuntencao, string placa, ManutencaoTipo tipo, DateTime data) // Modificado
        {
            int tipoManutencao = manuntencao.Tipo.GetHashCode();
            int tipoManutencaoAntiga = tipo.GetHashCode();
            int situacaoManutencao = manuntencao.Situacao.GetHashCode();
            string Query = "UPDATE [dbo].[TB_MANUTENCAO] SET [MTC_TIPO] = " + tipoManutencao + ",[MTC_SERVEXT_CNPJ]= " + manuntencao.CNPJ + "," +
                "[MTC_DESCRICAO]= '" + manuntencao.Descricao + "',[MTC_DATA]='" + manuntencao.Data.ToShortDateString() + 
                "',[MTC_VALOR]= " + manuntencao.Valor + ",[MTC_SITUACAO]= " + situacaoManutencao + ",[MTC_VCL_PLACA]= '" + manuntencao.Placa +
                "' WHERE [MTC_VCL_PLACA] = '" + placa + "' AND [MTC_TIPO] = " + tipoManutencaoAntiga + "  AND [MTC_DATA] = '" + data.ToShortDateString() + "'";
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Manutencao BuscarManutencao(string placa, ManutencaoTipo tipo, DateTime data)
        {
            int tipoManutencao = tipo.GetHashCode();
            string query = "SELECT [MTC_ID], [MTC_TIPO], [MTC_SERVEXT_CNPJ], [MTC_DESCRICAO], [MTC_DATA], [MTC_VALOR], [MTC_SITUACAO], [MTC_VCL_PLACA]" +
                "FROM[TB_MANUTENCAO] WHERE [MTC_VCL_PLACA] = '" + placa + "' AND [MTC_TIPO] = " + tipoManutencao + "  AND [MTC_DATA] = '" + data.ToShortDateString() + "'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Manutencao manutencao = null;
                DataRow[] dataRows = dt.Select("[MTC_VCL_PLACA] = '" + placa + "' AND [MTC_TIPO] = " + tipoManutencao + " AND [MTC_DATA] = '" + data.ToShortDateString() +"'");
                foreach (DataRow dr in dataRows)
                {
                    ManutencaoTipo manutencaoTipo = (ManutencaoTipo)Enum.Parse(typeof(ManutencaoTipo), dr["MTC_TIPO"].ToString());
                    long cNPJ = long.Parse(dr["MTC_SERVEXT_CNPJ"].ToString());
                    DateTime dataManutencao = Convert.ToDateTime(dr["MTC_DATA"].ToString());
                    double valor = double.Parse(dr["MTC_VALOR"].ToString());
                    SituacaoManutencao situacaoManutencao = (SituacaoManutencao)Enum.Parse(typeof(SituacaoManutencao), dr["MTC_SITUACAO"].ToString());


                    manutencao = new Manutencao(manutencaoTipo, dr["MTC_DESCRICAO"].ToString(), dataManutencao, valor, situacaoManutencao, cNPJ
                        , dr["MTC_VCL_PLACA"].ToString());
                }
                return manutencao;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Manutencao> BuscarTodos(long cnpj)
        {
            List<Manutencao> manutencoes = new List<Manutencao>();
            string query = "SELECT [MTC_ID], [MTC_TIPO], [MTC_SERVEXT_CNPJ], [MTC_DESCRICAO], [MTC_DATA], [MTC_VALOR], [MTC_SITUACAO], [MTC_VCL_PLACA]" +
                "FROM[TB_MANUTENCAO] WHERE [MTC_SERVEXT_CNPJ] = " + cnpj;
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Manutencao manutencao = null;
                DataRow[] dataRows = dt.Select("[MTC_SERVEXT_CNPJ] = " + cnpj);
                foreach (DataRow dr in dataRows)
                {
                    ManutencaoTipo manutencaoTipo = (ManutencaoTipo)Enum.Parse(typeof(ManutencaoTipo), dr["MTC_TIPO"].ToString());
                    long cNPJ = long.Parse(dr["MTC_SERVEXT_CNPJ"].ToString());
                    DateTime dataManutencao = Convert.ToDateTime(dr["MTC_DATA"].ToString());
                    double valor = double.Parse(dr["MTC_VALOR"].ToString());
                    SituacaoManutencao situacaoManutencao = (SituacaoManutencao)Enum.Parse(typeof(SituacaoManutencao), dr["MTC_SITUACAO"].ToString());


                    manutencao = new Manutencao(manutencaoTipo, dr["MTC_DESCRICAO"].ToString(), dataManutencao, valor, situacaoManutencao, cNPJ
                        , dr["MTC_VCL_PLACA"].ToString());
                    manutencoes.Add(manutencao);
                }
                return manutencoes;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Manutencao> BuscarTodos(string placa)
        {
            List<Manutencao> manutencoes = new List<Manutencao>();
            string query = "SELECT [MTC_ID], [MTC_TIPO], [MTC_SERVEXT_CNPJ], [MTC_DESCRICAO], [MTC_DATA], [MTC_VALOR], [MTC_SITUACAO], [MTC_VCL_PLACA]" +
                "FROM[TB_MANUTENCAO] WHERE [MTC_VCL_PLACA] = '" + placa + "'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Manutencao manutencao = null;
                DataRow[] dataRows = dt.Select("[MTC_VCL_PLACA] = '" + placa + "'");
                foreach (DataRow dr in dataRows)
                {
                    ManutencaoTipo manutencaoTipo = (ManutencaoTipo)Enum.Parse(typeof(ManutencaoTipo), dr["MTC_TIPO"].ToString());
                    long cNPJ = long.Parse(dr["MTC_SERVEXT_CNPJ"].ToString());
                    DateTime dataManutencao = Convert.ToDateTime(dr["MTC_DATA"].ToString());
                    double valor = double.Parse(dr["MTC_VALOR"].ToString());
                    SituacaoManutencao situacaoManutencao = (SituacaoManutencao)Enum.Parse(typeof(SituacaoManutencao), dr["MTC_SITUACAO"].ToString());


                    manutencao = new Manutencao(manutencaoTipo, dr["MTC_DESCRICAO"].ToString(), dataManutencao, valor, situacaoManutencao, cNPJ
                        , dr["MTC_VCL_PLACA"].ToString());
                    manutencoes.Add(manutencao);
                }
                return manutencoes;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Manutencao> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Manutencao> manutencoes = new List<Manutencao>();

            string query = "SELECT * FROM [dbo].[TB_MANUTENCAO] WHERE" +
                    "((YEAR([MTC_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([MTC_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                    "AND MONTH([MTC_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([MTC_DATAREGISTRO]) <= '" + dtfim.Month + "')";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Manutencao manutencao = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    ManutencaoTipo manutencaoTipo = (ManutencaoTipo)Enum.Parse(typeof(ManutencaoTipo), dr["MTC_TIPO"].ToString());
                    long cNPJ = long.Parse(dr["MTC_SERVEXT_CNPJ"].ToString());
                    DateTime dataManutencao = Convert.ToDateTime(dr["MTC_DATA"].ToString());
                    double valor = double.Parse(dr["MTC_VALOR"].ToString());
                    SituacaoManutencao situacaoManutencao = (SituacaoManutencao)Enum.Parse(typeof(SituacaoManutencao), dr["MTC_SITUACAO"].ToString());


                    manutencao = new Manutencao(manutencaoTipo, dr["MTC_DESCRICAO"].ToString(), dataManutencao, valor, situacaoManutencao, cNPJ
                        , dr["MTC_VCL_PLACA"].ToString());
                    manutencoes.Add(manutencao);
                }
                return manutencoes;
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
            string query = "SELECT [SERVEXT_CNPJ], [SERVEXT_NOME] FROM [DB_GERENCFROTA].[dbo].[TB_SERVICOS_EXTERNOS] WHERE [SERVEXT_TIPO] = 'Oficina'";
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
