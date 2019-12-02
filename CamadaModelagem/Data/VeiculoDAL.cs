using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Data
{
    public class VeiculoDAL
    {
        private readonly Banco _banco;

        public VeiculoDAL(Banco banco)
        {
            _banco = banco;
        }
        //Os exemplos abaixo não são funcionais, irão ser adaptados futuramente
        public bool Cadastrar(Veiculo veiculo) //Exemplo Cadastrar
        {
            int cor = veiculo.Cor.GetHashCode();
            int combustivel = veiculo.Combustivel.GetHashCode();
            int alugado = Convert.ToInt32(veiculo.Alugado);
            int situacao = Convert.ToInt32(veiculo.SituacaoVeiculo);
            DateTime datareg = DateTime.Now;

            string query = "INSERT INTO [dbo].[TB_VEICULOS]([VCL_PLACA],[VCL_MARCA],[VCL_MODELO],[VCL_CHASSI],[VCL_ANO],[VCL_COR],[VCL_COMBUSTIVEL],[VCL_ALUGADO],[VCL_SITUACAO],[VCL_DATAREGISTRO]) " +
                "VALUES('" + veiculo.Placa + "', '" + veiculo.Marca + "', '" + veiculo.Modelo + "', '" + veiculo.Chassi + "', " + veiculo.Ano + ", " + cor + "," + combustivel + ", " + alugado + ", " + situacao + ",'" + datareg.ToShortDateString() + "')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }

        }

        public bool CadastrarAlugado(Veiculo veiculo)
        {
            int cor = veiculo.Cor.GetHashCode();
            int combustivel = veiculo.Combustivel.GetHashCode();
            int alugado = Convert.ToInt32(veiculo.Alugado);
            int situacao = Convert.ToInt32(veiculo.SituacaoVeiculo);
            DateTime datareg = DateTime.Now;

            string query1 = "INSERT INTO [dbo].[TB_VEICULOS]([VCL_PLACA],[VCL_MARCA],[VCL_MODELO],[VCL_CHASSI],[VCL_ANO],[VCL_COR],[VCL_COMBUSTIVEL],[VCL_ALUGADO],[VCL_SITUACAO],[VCL_DATAREGISTRO]) " +
                "VALUES('" + veiculo.Placa + "', '" + veiculo.Marca + "', '" + veiculo.Modelo + "', '" + veiculo.Chassi + "', '" + veiculo.Ano + "', " + cor + "," + combustivel + ", " + alugado + ", " + situacao + ",'" + datareg.ToShortDateString() + "')";
            string query2 = "INSERT INTO [dbo].[TB_VEICULOS_ALUGUEL]([VCL_PLACA],[VCLAL_VALOR],[VCLAL_DTINICIO],[VCLAL_DTVENC]) " +
                "VALUES('" + veiculo.Placa + "', " + veiculo.VeiculoAlugado.Valor + ", '" + veiculo.VeiculoAlugado.DataInicio.ToShortDateString() + "', '" + veiculo.VeiculoAlugado.DataVencimento.ToShortDateString() + "')";
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

        public List<Veiculo> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            string query = "select VCL_PLACA, VCL_MARCA, VCL_MODELO, VCL_CHASSI, VCL_ANO, VCL_COR, VCL_COMBUSTIVEL, VCL_ALUGADO, VCL_SITUACAO " +
                "from TB_VEICULOS WHERE VCL_ALUGADO = 0 AND " +
                "((YEAR([VCL_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([VCL_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                "AND MONTH([VCL_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([VCL_DATAREGISTRO]) <= '" + dtfim.Month + "')";

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                VeiculoAlugado veiculoAlugado = null;
                Veiculo veiculo = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    int ano = int.Parse(dr["VCL_ANO"].ToString());
                    VeiculoTipoCor cor = (VeiculoTipoCor)Enum.Parse(typeof(VeiculoTipoCor), dr["VCL_COR"].ToString());
                    VeiculoCombustivel combustivel = (VeiculoCombustivel)Enum.Parse(typeof(VeiculoCombustivel), dr["VCL_COMBUSTIVEL"].ToString());
                    bool alugado = bool.Parse(dr["VCL_ALUGADO"].ToString());
                    bool situacao = bool.Parse(dr["VCL_SITUACAO"].ToString());

                    veiculo = new Veiculo(dr["VCL_PLACA"].ToString(), dr["VCL_MARCA"].ToString(), dr["VCL_MODELO"].ToString(), dr["VCL_CHASSI"].ToString(), ano, cor, combustivel, alugado, situacao, veiculoAlugado);
                    veiculos.Add(veiculo);
                }
                return veiculos;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }  
        }

        public List<Veiculo> BuscarTodosAlugados(DateTime dtinicio, DateTime dtfim)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            string query = "select V.VCL_PLACA, V.VCL_MARCA, V.VCL_MODELO, V.VCL_CHASSI, V.VCL_ANO, V.VCL_COR, V.VCL_COMBUSTIVEL, V.VCL_ALUGADO, V.VCL_SITUACAO," +
                " A.VCLAL_VALOR, A.VCLAL_DTINICIO, A.VCLAL_DTVENC from TB_VEICULOS as V join TB_VEICULOS_ALUGUEL as A " +
                "on V.VCL_PLACA = A.VCL_PLACA " +
                "WHERE ((YEAR(V.[VCL_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR(V.[VCL_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                "AND MONTH(V.[VCL_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH(V.[VCL_DATAREGISTRO]) <= '" + dtfim.Month + "')";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                VeiculoAlugado veiculoAlugado = null;
                Veiculo veiculo = null;
                DataRow[] dataRows = dt.Select();
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
                    veiculos.Add(veiculo);
                }
                return veiculos;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }
        public bool Inativar(string placa, bool sit) 
        {
            if (sit)
            {
                string query = "DELETE TB_VIAGENS_OCUPANTES WHERE EXISTS (SELECT VG_VCL_PLACA FROM TB_VIAGENS WHERE VG_VCL_PLACA = '" + placa + "')";
                string Query = "UPDATE TB_VEICULOS SET VCL_SITUACAO = 0 WHERE VCL_PLACA = '" + placa + "' ";
                string Query2 = "DELETE FROM [TB_VIAGENS] WHERE [VG_VCL_PLACA] = '" + placa + "' ";
                try
                {
                    _banco.ExecutarInstrucao(query);
                    return _banco.ExecutaTransaction(Query, Query2);
                }
                catch (ConcorrenciaBancoException e)
                {
                    throw new ConcorrenciaBancoException(e.Message);
                }
            }
            else
            {
                string Query = "UPDATE TB_VEICULOS SET VCL_SITUACAO = 1 WHERE VCL_PLACA = '" + placa + "' ";
                try
                {
                    return _banco.ExecutarInstrucao(Query);
                }
                catch (ConcorrenciaBancoException e)
                {
                    throw new ConcorrenciaBancoException(e.Message);
                }
            }
            
        }

        public bool Alterar(Veiculo veiculo, string placa)
        {
            int cor = veiculo.Cor.GetHashCode();
            int combustivel = veiculo.Combustivel.GetHashCode();
            int alugado = Convert.ToInt32(veiculo.Alugado);
            int situacao = Convert.ToInt32(veiculo.SituacaoVeiculo);

            string Query = "UPDATE TB_VEICULOS SET VCL_PLACA = '" + veiculo.Placa + "', VCL_MARCA = '" + veiculo.Marca
                + "', VCL_MODELO = '" + veiculo.Modelo + "',VCL_CHASSI = '" + veiculo.Chassi + "',VCL_ANO =  "
                + veiculo.Ano + ",VCL_COR = " + cor + ",VCL_COMBUSTIVEL = " + combustivel
                + ",VCL_ALUGADO = " + alugado + ", VCL_SITUACAO = " + situacao + " WHERE VCL_PLACA = '" + placa + "' ";
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool AlterarAlugado(Veiculo veiculo, string placa)
        {
            int cor = veiculo.Cor.GetHashCode();
            int combustivel = veiculo.Combustivel.GetHashCode();
            int alugado = Convert.ToInt32(veiculo.Alugado);
            int situacao = Convert.ToInt32(veiculo.SituacaoVeiculo);
            string query1 = "";
            string query2 = "";
            try
            {
                Veiculo obj = BuscarPlacaAlugado(placa); //Definindo quais querys serão usadas dependendo da alteração

                if (obj == null) //Caso altere o veiculo e adicione seu aluguel
                {
                    query1 = "UPDATE TB_VEICULOS SET VCL_PLACA = '" + veiculo.Placa + "', VCL_MARCA = '" + veiculo.Marca
                        + "', VCL_MODELO = '" + veiculo.Modelo + "',VCL_CHASSI = '" + veiculo.Chassi + "',VCL_ANO =  "
                        + veiculo.Ano + ",VCL_COR = " + cor + ",VCL_COMBUSTIVEL = " + combustivel
                        + ",VCL_ALUGADO = " + alugado + ", VCL_SITUACAO = " + situacao + " WHERE VCL_PLACA = '" + placa + "' ";
                    query2 = "INSERT INTO [dbo].[TB_VEICULOS_ALUGUEL]([VCL_PLACA],[VCLAL_VALOR],[VCLAL_DTINICIO],[VCLAL_DTVENC]) " +
                        "VALUES('" + veiculo.Placa + "', " + veiculo.VeiculoAlugado.Valor + ", '"
                        + veiculo.VeiculoAlugado.DataInicio.ToShortDateString() + "', '"
                        + veiculo.VeiculoAlugado.DataVencimento.ToShortDateString() + "')";
                }

                else if (veiculo.VeiculoAlugado == null) //Caso altere o veiculo e remova seu aluguel
                {
                    query1 = "DELETE FROM [dbo].[TB_VEICULOS_ALUGUEL] WHERE VCL_PLACA = '" + placa + "'";
                    query2 = "UPDATE TB_VEICULOS SET VCL_PLACA = '" + veiculo.Placa + "', VCL_MARCA = '" + veiculo.Marca
                        + "', VCL_MODELO = '" + veiculo.Modelo + "',VCL_CHASSI = '" + veiculo.Chassi + "',VCL_ANO =  "
                        + veiculo.Ano + ",VCL_COR = " + cor + ",VCL_COMBUSTIVEL = " + combustivel
                        + ",VCL_ALUGADO = " + alugado + ", VCL_SITUACAO = " + situacao + " WHERE VCL_PLACA = '" + placa + "' ";
                }
                else  //Caso altere o veiculo e seu aluguel
                {
                    string query = "DELETE FROM TB_VEICULOS_ALUGUEL WHERE VCL_PLACA = '" + placa + "'";
                    if (_banco.ExecutarInstrucao(query))
                    {
                        query1 = "UPDATE TB_VEICULOS SET VCL_PLACA = '" + veiculo.Placa + "', VCL_MARCA = '" + veiculo.Marca
                        + "', VCL_MODELO = '" + veiculo.Modelo + "',VCL_CHASSI = '" + veiculo.Chassi + "',VCL_ANO =  "
                        + veiculo.Ano + ",VCL_COR = " + cor + ",VCL_COMBUSTIVEL = " + combustivel
                        + ",VCL_ALUGADO = " + alugado + ", VCL_SITUACAO = " + situacao + " WHERE VCL_PLACA = '" + placa + "' ";
                        query2 = "INSERT INTO [dbo].[TB_VEICULOS_ALUGUEL]([VCL_PLACA],[VCLAL_VALOR],[VCLAL_DTINICIO],[VCLAL_DTVENC]) " +
                        "VALUES('" + veiculo.Placa + "', " + veiculo.VeiculoAlugado.Valor + ", '"
                        + veiculo.VeiculoAlugado.DataInicio.ToShortDateString() + "', '"
                        + veiculo.VeiculoAlugado.DataVencimento.ToShortDateString() + "')";
                    }
                    else
                    {
                        throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
                    }
                }

                return _banco.ExecutaTransaction(query1, query2);
            }
            catch(TransacaoException e)
            {
                throw new TransacaoException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Veiculo> Pesquisar(string busca)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            if (busca == "")
            {
                return veiculos;
            }
            string query = "select VCL_PLACA, VCL_MARCA, VCL_MODELO, VCL_CHASSI, VCL_ANO, VCL_COR, VCL_COMBUSTIVEL, VCL_ALUGADO, VCL_SITUACAO " +
                "from TB_VEICULOS WHERE VCL_ALUGADO = 0 AND (VCL_PLACA LIKE '%" + busca + "%' OR VCL_MARCA LIKE '%" + busca + "%' OR VCL_MODELO LIKE '%" + busca + "%'" +
                " OR VCL_CHASSI LIKE '%" + busca + "%')";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                VeiculoAlugado veiculoAlugado = null;
                Veiculo veiculo = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    int ano = int.Parse(dr["VCL_ANO"].ToString());
                    VeiculoTipoCor cor = (VeiculoTipoCor)Enum.Parse(typeof(VeiculoTipoCor), dr["VCL_COR"].ToString());
                    VeiculoCombustivel combustivel = (VeiculoCombustivel)Enum.Parse(typeof(VeiculoCombustivel), dr["VCL_COMBUSTIVEL"].ToString());
                    bool alugado = bool.Parse(dr["VCL_ALUGADO"].ToString());
                    bool situacao = bool.Parse(dr["VCL_SITUACAO"].ToString());

                    veiculo = new Veiculo(dr["VCL_PLACA"].ToString(), dr["VCL_MARCA"].ToString(), dr["VCL_MODELO"].ToString(), dr["VCL_CHASSI"].ToString(), ano, cor, combustivel, alugado, situacao, veiculoAlugado);
                    veiculos.Add(veiculo);
                }
                return veiculos;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Veiculo> PesquisarAlugados(string busca)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            if(busca == "")
            {
                return veiculos;
            }
            string query = "select V.VCL_PLACA, V.VCL_MARCA, V.VCL_MODELO, V.VCL_CHASSI, V.VCL_ANO, V.VCL_COR, V.VCL_COMBUSTIVEL, V.VCL_ALUGADO, V.VCL_SITUACAO, A.VCLAL_VALOR, A.VCLAL_DTINICIO, A.VCLAL_DTVENC " +
                    "from TB_VEICULOS as V join TB_VEICULOS_ALUGUEL as A on V.VCL_PLACA = A.VCL_PLACA" +
                    " WHERE V.VCL_PLACA LIKE '%" +busca +"%' OR V.VCL_MARCA LIKE '%" +busca +"%' OR V.VCL_MODELO LIKE '%" +busca + "%' OR V.VCL_CHASSI LIKE '%" +busca +"%'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                VeiculoAlugado veiculoAlugado = null;
                Veiculo veiculo = null;
                DataRow[] dataRows = dt.Select();
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
                    veiculos.Add(veiculo);
                }
                return veiculos;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }
    }
}
