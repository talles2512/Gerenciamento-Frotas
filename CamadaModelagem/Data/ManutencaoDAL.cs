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
            string query = "INSERT INTO [dbo].[TB_MANUTENCAO] ([MTC_TIPO],[MTC_SERVEXT_CNPJ],[MTC_DESCRICAO],[MTC_DATA],[MTC_VALOR],[MTC_SITUACAO],[MTC_VCL_PLACA])" +
                "VALUES (" + manuntencao.Tipo + ", " + manuntencao.CNPJ + ", '" + manuntencao.Descricao + "','" + manuntencao.Data + "', " + manuntencao.Valor + ", " + manuntencao.Situacao + ", '" + manuntencao.Placa + "')";
            return _banco.ExecutarInstrucao(query);
        }

        //public void Deletar(string placa, int tipo, DateTime data) //Modificado
        //{
        //    string Query = "DELETE [dbo].[TB_MANUTENCAO] WHERE [MTC_VCL_PLACA] = '" + placa + "' AND [MTC_TIPO] = " + tipo + " AND [MTC_DATA] = '" + data + "'";
        //    _banco.ExecutarInstrucao(Query);
        //}

        //public void Alterar(Manutencao manuntencao, string placa, int tipo, DateTime data) // Modificado
        //{
        //    string Query = "UPDATE [dbo].[TB_MANUTENCAO] SET [MTC_TIPO] = " + manuntencao.Tipo + ",[MTC_SERVEXT_CNPJ]= " + manuntencao.ServicoExterno.CNPJ + ",[MTC_DESCRICAO]= '" + manuntencao.Descricao + "',[MTC_DATA]='" + manuntencao.Data + "',[MTC_VALOR]= " + manuntencao.Valor + ",[MTC_SITUACAO]= " + manuntencao.Situacao + ",[MTC_VCL_PLACA]= '" + manuntencao.Veiculo.Placa + "' WHERE [MTC_VCL_PLACA] = '" + placa + "' AND [MTC_TIPO] = " + tipo + "AND [MTC_DATA] = '" + data + "'";
        //    _banco.ExecutarInstrucao(Query);
        //}

        public Manutencao BuscarManutencao(string placa, ManutencaoTipo tipo, DateTime data)
        {
            //int tipoManutencao = tipo.GetHashCode();
            //string query = "SELECT SERVEXT_CNPJ, SERVEXT_TIPO, SERVEXT_NOME, SERVEXT_TELEFONE, SERVEXT_EMAIL, SERVEXT_ENDERECO, SERVEXT_CONVENIADO " +
            //    "FROM TB_SERVICOS_EXTERNOS WHERE SERVEXT_CNPJ = " + cnpj;
            //try
            //{
            //    DataTable dt = _banco.BuscarRegistro(query);
            //    ServicoExternoConveniado servicoExternoConveniado = null;
            //    ServicoExterno servicoExterno = null;
            //    DataRow[] dataRows = dt.Select("SERVEXT_CNPJ = " + cnpj);
            //    foreach (DataRow dr in dataRows)
            //    {
            //        long cNPJ = long.Parse(dr["SERVEXT_CNPJ"].ToString());
            //        TipoServicoExterno tipo = (TipoServicoExterno)Enum.Parse(typeof(TipoServicoExterno), dr["SERVEXT_TIPO"].ToString());
            //        long telefone = long.Parse(dr["SERVEXT_TELEFONE"].ToString());
            //        bool conveniado = bool.Parse(dr["SERVEXT_CONVENIADO"].ToString());


            //        servicoExterno = new ServicoExterno(cNPJ, tipo, dr["SERVEXT_NOME"].ToString(), telefone, dr["SERVEXT_EMAIL"].ToString()
            //            , dr["SERVEXT_ENDERECO"].ToString()
            //            , conveniado, servicoExternoConveniado);
            //    }
            //    return servicoExterno;
            //}
            //catch (Exception)
            //{
            //    throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            //}

            return new Manutencao();
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
