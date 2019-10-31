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
    public class MultaDAL
    {
        private readonly Banco _banco;

        public MultaDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(Multa multa)
        {
            string datapaga;

            if(multa.MultasPagas != null)
            {
                datapaga = multa.MultasPagas.ToString();
                DateTime dtpaga = DateTime.Parse(datapaga);
                datapaga = dtpaga.ToString();
            }
            else
            {
                datapaga = null;
            }

            int situacao = Convert.ToInt32(multa.Paga);
            DateTime datareg = DateTime.Now;

            string query = "INSERT INTO [dbo].[TB_MULTAS] ([MULT_VCL_PLACA],[MULT_MT_CPF],[MULT_DESCRICAO],[MULT_LOCAL],[MULT_DTOCORRENCIA],[MULT_VALOR],[MULT_PAGO],[MULTPAG_DTPAGAMENTO],[MULT_DATAREGISTRO])" +
                "VALUES ('" + multa.Veiculo.Placa + "', '" + multa.Motorista.CPF + "', '" + multa.Descricao + "', '" + multa.Local + "','" + multa.DataOcorrencia.ToShortDateString() + "'," + multa.Valor + "," + situacao + ",'" + datapaga + "','" + datareg.ToShortDateString() + "')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }
        public Multa BuscarMulta(string placa, string cpf, DateTime dataocorrencia)
        {
            string query = "SELECT * FROM [dbo].[TB_MULTAS] WHERE [MULT_VCL_PLACA] = '" + placa + "' AND [MULT_MT_CPF] = '" + cpf + "' AND [MULT_DTOCORRENCIA] = '" + dataocorrencia.ToShortDateString() + "'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);

                Multa multa = null;
                DataRow[] dataRows = dt.Select("MULT_VCL_PLACA = '" + placa + "' AND MULT_MT_CPF = '" + cpf + "' AND MULT_DTOCORRENCIA = '" + dataocorrencia.ToShortDateString() + "'");
                foreach (DataRow dr in dataRows)
                {
                    DateTime dtocorrencia = DateTime.Parse(dr["MULT_DTOCORRENCIA"].ToString());
                    DateTime? dtpagamento = null;

                    if (string.IsNullOrEmpty(dr["MULTPAG_DTPAGAMENTO"].ToString()))
                    {

                    }
                    else
                    {
                        dtpagamento = DateTime.Parse(dr["MULTPAG_DTPAGAMENTO"].ToString());
                    }

                    double valor = double.Parse(dr["MULT_VALOR"].ToString());
                    bool paga = bool.Parse(dr["MULT_PAGO"].ToString());
                    Veiculo veiculo = BuscarPlaca(dr["MULT_VCL_PLACA"].ToString());
                    Motorista motorista = BuscarCPF(dr["MULT_MT_CPF"].ToString());

                    multa = new Multa(dr["MULT_DESCRICAO"].ToString(), dr["MULT_LOCAL"].ToString(), dtocorrencia, valor, paga, dtpagamento, veiculo, motorista);
                }

                return multa;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Multa> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Multa> multas = new List<Multa>();

            string query = "SELECT * FROM [dbo].[TB_MULTAS] WHERE" +
                    "((YEAR([MULT_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([MULT_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                    "AND MONTH([MULT_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([MULT_DATAREGISTRO]) <= '" + dtfim.Month + "')";

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Multa multa = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    DateTime dtocorrencia = DateTime.Parse(dr["MULT_DTOCORRENCIA"].ToString());
                    DateTime? dtpagamento = null;

                    if (string.IsNullOrEmpty(dr["MULTPAG_DTPAGAMENTO"].ToString()))
                    {

                    }
                    else
                    {
                        dtpagamento = DateTime.Parse(dr["MULTPAG_DTPAGAMENTO"].ToString());
                    }
                    
                    double valor = double.Parse(dr["MULT_VALOR"].ToString());
                    bool paga = bool.Parse(dr["MULT_PAGO"].ToString());
                    Veiculo veiculo = new Veiculo();
                    veiculo.Placa = dr["MULT_VCL_PLACA"].ToString();
                    Motorista motorista = new Motorista();
                    motorista.CPF = dr["MULT_MT_CPF"].ToString();

                    multa = new Multa(dr["MULT_DESCRICAO"].ToString(), dr["MULT_LOCAL"].ToString(), dtocorrencia, valor, paga, dtpagamento, veiculo, motorista);
                    multas.Add(multa);
                }

                return multas;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(string placa, string cpf, DateTime dataocorrencia) //Modificado
        {
            string data = dataocorrencia.ToString("yyyy/MM/dd");
            string query = "DELETE [dbo].[TB_MULTAS] WHERE [MULT_VCL_PLACA] = '" + placa + "' AND [MULT_MT_CPF] = '" + cpf + "' AND [MULT_DTOCORRENCIA] = '" + data + "'";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public bool Alterar(Multa multa, string placa, string cpf, DateTime dataocorrencia) //Modificado
        {
            string data = dataocorrencia.ToString("yyyy/MM/dd");
            int situacao = Convert.ToInt32(multa.Paga);
            string query = "UPDATE [dbo].[TB_MULTAS] SET [MULT_VCL_PLACA]='" + multa.Veiculo.Placa + "',[MULT_MT_CPF]= " + multa.Motorista.CPF + ",[MULT_DESCRICAO]= '" + multa.Descricao + "',[MULT_LOCAL]= '" + multa.Local + "',[MULT_DTOCORRENCIA]= '" + data + "',[MULT_VALOR]=" + multa.Valor + ",[MULT_PAGO]=" + situacao + ",[MULTPAG_DTPAGAMENTO]= '" + multa.MultasPagas + "' WHERE [MULT_VCL_PLACA] = '" + placa + "' AND [MULT_MT_CPF] = " + cpf + " AND [MULT_DTOCORRENCIA] = '" + data + "'";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public DataTable PopularPlacas()
        {
            string query = "SELECT [VCL_MODELO] + ' - ' + [VCL_PLACA] as MODELO, [VCL_PLACA] FROM [DB_GERENCFROTA].[dbo].[TB_VEICULOS] WHERE [VCL_SITUACAO] = 1";
            try
            {
                return _banco.BuscarRegistro(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public DataTable PopularCPF()
        {
            string query = "SELECT [MT_NOME] + ' - ' + [MT_CPF] as NOMECPF, [MT_CPF] FROM [DB_GERENCFROTA].[dbo].[TB_MOTORISTA] WHERE [MT_SITUACAO] = 1";
            try
            {
                return _banco.BuscarRegistro(query);
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public Veiculo BuscarPlaca(string placa)
        {
            string query = "select VCL_PLACA, VCL_MARCA, VCL_MODELO, VCL_CHASSI, VCL_ANO, VCL_COR, VCL_COMBUSTIVEL, VCL_ALUGADO, VCL_SITUACAO " +
                "from TB_VEICULOS WHERE VCL_PLACA = '" + placa + "'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                VeiculoAlugado veiculoAlugado = null;
                Veiculo veiculo = null;
                DataRow[] dataRows = dt.Select("VCL_PLACA = '" + placa + "'");
                foreach (DataRow dr in dataRows)
                {
                    int ano = int.Parse(dr["VCL_ANO"].ToString());
                    VeiculoTipoCor cor = (VeiculoTipoCor)Enum.Parse(typeof(VeiculoTipoCor), dr["VCL_COR"].ToString());
                    VeiculoCombustivel combustivel = (VeiculoCombustivel)Enum.Parse(typeof(VeiculoCombustivel), dr["VCL_COMBUSTIVEL"].ToString());
                    bool alugado = bool.Parse(dr["VCL_ALUGADO"].ToString());
                    bool situacao = bool.Parse(dr["VCL_SITUACAO"].ToString());

                    veiculo = new Veiculo(dr["VCL_PLACA"].ToString(), dr["VCL_MARCA"].ToString(), dr["VCL_MODELO"].ToString(), dr["VCL_CHASSI"].ToString(), ano, cor, combustivel, alugado, situacao, veiculoAlugado);
                }
                return veiculo;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public Veiculo BuscarPlacaAlugado(string placa)
        {
            string query = "select V.VCL_PLACA, V.VCL_MARCA, V.VCL_MODELO, V.VCL_CHASSI, V.VCL_ANO, V.VCL_COR, V.VCL_COMBUSTIVEL, V.VCL_ALUGADO, V.VCL_SITUACAO," +
                " A.VCLAL_VALOR, A.VCLAL_DTINICIO, A.VCLAL_DTVENC from TB_VEICULOS as V join TB_VEICULOS_ALUGUEL as A " +
                "on V.VCL_PLACA = A.VCL_PLACA WHERE V.VCL_PLACA = '" + placa + "'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                VeiculoAlugado veiculoAlugado = null;
                Veiculo veiculo = null;
                DataRow[] dataRows = dt.Select("VCL_PLACA = '" + placa + "'");
                foreach (DataRow dr in dataRows)
                {
                    int ano = int.Parse(dr["VCL_ANO"].ToString());
                    VeiculoTipoCor cor = (VeiculoTipoCor)Enum.Parse(typeof(VeiculoTipoCor), dr["VCL_COR"].ToString());
                    VeiculoCombustivel combustivel = (VeiculoCombustivel)Enum.Parse(typeof(VeiculoCombustivel), dr["VCL_COMBUSTIVEL"].ToString());
                    bool alugado = bool.Parse(dr["VCL_ALUGADO"].ToString());
                    bool situacao = bool.Parse(dr["VCL_SITUACAO"].ToString());

                    if (alugado)
                    {
                        double valor = double.Parse(dr["VCLAL_VALOR"].ToString());
                        DateTime dtInicio = DateTime.Parse(dr["VCLAL_DTINICIO"].ToString());
                        DateTime dtVencimento = DateTime.Parse(dr["VCLAL_DTVENC"].ToString());
                        veiculoAlugado = new VeiculoAlugado(valor, dtInicio, dtVencimento);
                    }
                    veiculo = new Veiculo(dr["VCL_PLACA"].ToString(), dr["VCL_MARCA"].ToString(), dr["VCL_MODELO"].ToString(), dr["VCL_CHASSI"].ToString(), ano, cor, combustivel, alugado, situacao, veiculoAlugado);
                }
                return veiculo;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public Motorista BuscarCPF(string cpf)
        {
            string query = "SELECT M.[MT_CPF], M.[MT_NOME], M.[MT_RG], M.[MT_ENDERECO], M.[MT_DTNASCIMENTO], M.[MT_TELEFONE], M.[MT_TELEFONE_RECADO]" +
                ", M.[MT_SITUACAO], C.[CNH_NUMERO], C.[CNH_DTEMISSAO], C.[CNH_DTVENC], C.[CNH_CATEGORIA], C.[CNH_ORGAOEMISSOR], C.[CNH_MT_CPF]" +
                "FROM [TB_MOTORISTA] AS M JOIN [TB_CNH] AS C ON M.[MT_CPF] = C.[CNH_MT_CPF] WHERE M.[MT_CPF] = '" + cpf + "'";

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);

                Motorista motorista = null;
                CNH cNH = new CNH();
                DataRow[] dataRows = dt.Select("MT_CPF = '" + cpf + "'");
                foreach (DataRow dr in dataRows)
                {
                    DateTime dtnascimento = Convert.ToDateTime(dr["MT_DTNASCIMENTO"].ToString());
                    long telefone = long.Parse(dr["MT_TELEFONE"].ToString());
                    long telefonerecado = long.Parse(dr["MT_TELEFONE_RECADO"].ToString());
                    bool situacao = bool.Parse(dr["MT_SITUACAO"].ToString());
                    cNH.Numero = long.Parse(dr["CNH_NUMERO"].ToString());
                    cNH.DataEmissao = Convert.ToDateTime(dr["CNH_DTEMISSAO"].ToString());
                    cNH.DataVencimento = Convert.ToDateTime(dr["CNH_DTVENC"].ToString());
                    cNH.Categoria = dr["CNH_CATEGORIA"].ToString();
                    cNH.OrgaoEmissor = dr["CNH_ORGAOEMISSOR"].ToString();

                    motorista = new Motorista(dr["MT_CPF"].ToString(), dr["MT_NOME"].ToString(), dr["MT_RG"].ToString(), dr["MT_DTNASCIMENTO"].ToString(), dtnascimento, telefone, telefonerecado, situacao, cNH);
                }

                return motorista;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
