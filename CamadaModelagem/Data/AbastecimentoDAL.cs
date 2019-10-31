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
    public class AbastecimentoDAL
    {
        private readonly Banco _banco;

        public AbastecimentoDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(Abastecimento abastecimento)
        {
            int tipoAbastecimento = abastecimento.Tipo.GetHashCode();
            DateTime datareg = DateTime.Now;
            string query = " INSERT INTO [dbo].[TB_ABASTECIMENTO]([ABS_VCL_PLACA],[ABS_SERVEXT_CNPJ],[ABS_TIPO],[ABS_LITROS],[ABS_VALOR],[ABS_DATA],[ABS_DATAREGISTRO])" +
                "VALUES('" + abastecimento.Placa + "', " + abastecimento.CNPJ + ", " + tipoAbastecimento + ", " + abastecimento.Litros + ", "
                + abastecimento.Valor + ", '" + abastecimento.Data.ToShortDateString() + "', '" + datareg.ToShortDateString() + "')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(string placa, AbastecimentoTipo tipo, DateTime data) //Modificado
        {
            int tipoAbastecimento = tipo.GetHashCode();
            string Query = "DELETE [TB_ABASTECIMENTO] WHERE [ABS_VCL_PLACA] = '" + placa + "' AND [ABS_TIPO] = " + tipoAbastecimento + " AND [ABS_DATA] = '" + data + "'";
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Abastecimento abastecimento, string placa, AbastecimentoTipo tipo, DateTime data) // Modificado
        {
            int tipoAbastecimento = abastecimento.Tipo.GetHashCode();
            int tipoAbastecimentoAntigo = tipo.GetHashCode();
            string Query = "UPDATE TB_ABASTECIMENTO SET [ABS_VCL_PLACA] = '" + abastecimento.Placa + "', [ABS_SERVEXT_CNPJ] = "
                + abastecimento.CNPJ + " ,[ABS_TIPO] = " + tipoAbastecimento + ",[ABS_LITROS] = " + abastecimento.Litros
                + ",[ABS_VALOR] = " + abastecimento.Valor + ",[ABS_DATA] = '"
                + abastecimento.Data + "' WHERE [ABS_VCL_PLACA] = '" + placa + "' AND [ABS_TIPO] = " + tipoAbastecimentoAntigo + " AND [ABS_DATA] = '" + data + "'";
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Abastecimento BuscarAbastecimento(string placa, AbastecimentoTipo tipo, DateTime data)
        {
            int tipoAbastecimento = tipo.GetHashCode();
            string query = "SELECT [ABS_ID], [ABS_VCL_PLACA], [ABS_SERVEXT_CNPJ], [ABS_TIPO], [ABS_LITROS], [ABS_VALOR], [ABS_DATA]" +
                "FROM[TB_ABASTECIMENTO] WHERE [ABS_VCL_PLACA] = '" + placa + "' AND [ABS_TIPO] = " + tipoAbastecimento + "  AND [ABS_DATA] = '" + data.ToShortDateString() + "'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Abastecimento abastecimento = null;
                DataRow[] dataRows = dt.Select("[ABS_VCL_PLACA] = '" + placa + "' AND [ABS_TIPO] = " + tipoAbastecimento + "  AND [ABS_DATA] = '" + data.ToShortDateString() + "'");
                foreach (DataRow dr in dataRows)
                {
                    AbastecimentoTipo abastecimentoTipo = (AbastecimentoTipo)Enum.Parse(typeof(AbastecimentoTipo), dr["ABS_TIPO"].ToString());
                    long cNPJ = long.Parse(dr["ABS_SERVEXT_CNPJ"].ToString());
                    DateTime dataAbastecimento = Convert.ToDateTime(dr["ABS_DATA"].ToString());
                    double litros = double.Parse(dr["ABS_LITROS"].ToString());
                    double valor = double.Parse(dr["ABS_VALOR"].ToString());

                    abastecimento = new Abastecimento(abastecimentoTipo, valor, litros, dataAbastecimento, dr["ABS_VCL_PLACA"].ToString(), cNPJ);
                }
                return abastecimento;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Abastecimento> BuscarTodos(long cnpj)
        {
            List<Abastecimento> abastecimentos = new List<Abastecimento>();
            string query = "SELECT [ABS_ID], [ABS_VCL_PLACA], [ABS_SERVEXT_CNPJ], [ABS_TIPO], [ABS_LITROS], [ABS_VALOR], [ABS_DATA]" +
                "FROM[TB_ABASTECIMENTO] WHERE [ABS_SERVEXT_CNPJ] = " + cnpj;
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Abastecimento abastecimento = null;
                DataRow[] dataRows = dt.Select("[ABS_SERVEXT_CNPJ] = " + cnpj);
                foreach (DataRow dr in dataRows)
                {
                    AbastecimentoTipo abastecimentoTipo = (AbastecimentoTipo)Enum.Parse(typeof(AbastecimentoTipo), dr["ABS_TIPO"].ToString());
                    long cNPJ = long.Parse(dr["ABS_SERVEXT_CNPJ"].ToString());
                    DateTime dataAbastecimento = Convert.ToDateTime(dr["ABS_DATA"].ToString());
                    double litros = double.Parse(dr["ABS_LITROS"].ToString());
                    double valor = double.Parse(dr["ABS_VALOR"].ToString());

                    abastecimento = new Abastecimento(abastecimentoTipo, valor, litros, dataAbastecimento, dr["ABS_VCL_PLACA"].ToString(), cNPJ);
                    abastecimentos.Add(abastecimento);
                }
                return abastecimentos;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Abastecimento> BuscarTodos(string placa)
        {
            List<Abastecimento> abastecimentos = new List<Abastecimento>();
            string query = "SELECT [ABS_ID], [ABS_VCL_PLACA], [ABS_SERVEXT_CNPJ], [ABS_TIPO], [ABS_LITROS], [ABS_VALOR], [ABS_DATA]" +
                "FROM [TB_ABASTECIMENTO] WHERE [ABS_VCL_PLACA] = '" + placa +"'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Abastecimento abastecimento = null;
                DataRow[] dataRows = dt.Select("[ABS_VCL_PLACA] = '" + placa + "'");
                foreach (DataRow dr in dataRows)
                {
                    AbastecimentoTipo abastecimentoTipo = (AbastecimentoTipo)Enum.Parse(typeof(AbastecimentoTipo), dr["ABS_TIPO"].ToString());
                    long cNPJ = long.Parse(dr["ABS_SERVEXT_CNPJ"].ToString());
                    DateTime dataAbastecimento = Convert.ToDateTime(dr["ABS_DATA"].ToString());
                    double litros = double.Parse(dr["ABS_LITROS"].ToString());
                    double valor = double.Parse(dr["ABS_VALOR"].ToString());

                    abastecimento = new Abastecimento(abastecimentoTipo, valor, litros, dataAbastecimento, dr["ABS_VCL_PLACA"].ToString(), cNPJ);
                    abastecimentos.Add(abastecimento);
                }
                return abastecimentos;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Abastecimento> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Abastecimento> abastecimentos = new List<Abastecimento>();

            string query = "SELECT * FROM [dbo].[TB_ABASTECIMENTO] WHERE" +
                    "((YEAR([ABS_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([ABS_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                    "AND MONTH([ABS_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([ABS_DATAREGISTRO]) <= '" + dtfim.Month + "')";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Abastecimento abastecimento = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    AbastecimentoTipo abastecimentoTipo = (AbastecimentoTipo)Enum.Parse(typeof(AbastecimentoTipo), dr["ABS_TIPO"].ToString());
                    long cNPJ = long.Parse(dr["ABS_SERVEXT_CNPJ"].ToString());
                    DateTime dataAbastecimento = Convert.ToDateTime(dr["ABS_DATA"].ToString());
                    double litros = double.Parse(dr["ABS_LITROS"].ToString());
                    double valor = double.Parse(dr["ABS_VALOR"].ToString());

                    abastecimento = new Abastecimento(abastecimentoTipo, valor, litros, dataAbastecimento, dr["ABS_VCL_PLACA"].ToString(), cNPJ);
                    abastecimentos.Add(abastecimento);
                }
                return abastecimentos;
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
            string query = "SELECT [SERVEXT_CNPJ], [SERVEXT_NOME] FROM [DB_GERENCFROTA].[dbo].[TB_SERVICOS_EXTERNOS] WHERE [SERVEXT_TIPO] = 'Posto'";
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
