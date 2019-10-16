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

            if(seguro.Tipo.ToString() == "Automóvel")
            {
                query = " INSERT INTO [dbo].[TB_SEGURO_VEICULO]([SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_PLACA], [SEG_VALOR],"
                        + " [SEG_DATAINICIO], [SEG_FIMVIGENCIA], [SEG_FRANQUIA], [SEG_VALORFRANQUIA]) VALUES(" + seguro.NumeroApolice
                        + ", " + seguro.CNPJ + ", '" + seguro.ItemSegurado + "', " + seguro.Valor + ", '"
                        + seguro.DataInicio.ToShortDateString() + "', '" + seguro.FimVigencia.ToShortDateString() 
                        + "', '" + seguro.Franquia + "', " + seguro.ValorFranquia + ")";
            }
            else if(seguro.Tipo.ToString() == "Vida")
            {
                query = " INSERT INTO [dbo].[TB_SEGURO_VEICULO]([SEG_NUMAPOLICE], [SEG_SEGURADORA], [SEG_ITEMSEG_CPF], [SEG_VALOR],"
                        + " [SEG_DATAINICIO], [SEG_FIMVIGENCIA]) VALUES(" + seguro.NumeroApolice + ", " + seguro.CNPJ + ", '" 
                        + seguro.ItemSegurado + "', " + seguro.Valor + ", '" + seguro.DataInicio.ToShortDateString() + "', '"
                        + seguro.FimVigencia.ToShortDateString() + "')";
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

        public void Alterar(Seguro seguro, int numApolice)
        {
            //string Query = "UPDATE [dbo].[TB_SEGURO] SET [SEG_NUMAPOLICE] =" + seguro.NumeroApolice + ",[SEG_SEGURADORA] =" + seguro.ServicoExterno.CNPJ + ",[SEG_ITEMSEG]=" + seguro.ItemSegurado
            //    + ",[SEG_TIPO] =" + seguro.Tipo + ",[SEG_VALOR] =" + seguro.Valor + ",[SEG_DATAINICIO] =" + seguro.DataInicio + ",[SEG_FIMVIGENCIA] =" + seguro.FimVigencia + ",[SEG_FRANQUIA] ='" + seguro.Franquia + "',[SEG_VALORFRANQUIA] =" + seguro.ValorFranquia + " WHERE [SEG_NUMAPOLICE] =" + numApolice;
            //_banco.ExecutarInstrucao(Query);
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
    }
}
