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

            string query = "INSERT INTO [dbo].[TB_VEICULOS]([VCL_PLACA],[VCL_MARCA],[VCL_MODELO],[VCL_CHASSI],[VCL_ANO],[VCL_COR],[VCL_COMBUSTIVEL],[VCL_ALUGADO],[VCL_SITUACAO]) " +
                "VALUES('" + veiculo.Placa + "', '" + veiculo.Marca + "', '" + veiculo.Modelo + "', '" + veiculo.Chassi + "', " + veiculo.Ano + ", " + cor + "," + combustivel + ", " + alugado + ", " + situacao + ")";
            return _banco.ExecutarInstrucao(query);
        }

        public bool CadastrarAlugado(Veiculo veiculo)
        {
            int cor = veiculo.Cor.GetHashCode();
            int combustivel = veiculo.Combustivel.GetHashCode();
            int alugado = Convert.ToInt32(veiculo.Alugado);
            int situacao = Convert.ToInt32(veiculo.SituacaoVeiculo);

            string query1 = "INSERT INTO [dbo].[TB_VEICULOS]([VCL_PLACA],[VCL_MARCA],[VCL_MODELO],[VCL_CHASSI],[VCL_ANO],[VCL_COR],[VCL_COMBUSTIVEL],[VCL_ALUGADO],[VCL_SITUACAO]) " +
                "VALUES('" + veiculo.Placa + "', '" + veiculo.Marca + "', '" + veiculo.Modelo + "', '" + veiculo.Chassi + "', '" + veiculo.Ano + "', " + cor + "," + combustivel + ", " + alugado + ", " + situacao + ")";
            string query2 = "INSERT INTO [dbo].[TB_VEICULOS_ALUGUEL]([VCL_PLACA],[VCLAL_VALOR],[VCLAL_DTINICIO],[VCLAL_DTVENC]) " +
                "VALUES('" + veiculo.Placa + "', " + veiculo.VeiculoAlugado.Valor + ", '" + veiculo.VeiculoAlugado.DataInicio.ToShortDateString() + "', '" + veiculo.VeiculoAlugado.DataVencimento.ToShortDateString() + "')";
            return _banco.ExecutaTransaction(query1, query2);
        }

        public Veiculo BuscarPlaca(string placa)
        {
            string query = "select VCL_PLACA, VCL_MARCA, VCL_MODELO, VCL_CHASSI, VCL_ANO, VCL_COR, VCL_COMBUSTIVEL, VCL_ALUGADO, VCL_SITUACAO " +
                "from TB_VEICULOS WHERE VCL_PLACA = '" + placa + "'";
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

        public Veiculo BuscarPlacaAlugado(string placa)
        {
            string query = "select V.VCL_PLACA, V.VCL_MARCA, V.VCL_MODELO, V.VCL_CHASSI, V.VCL_ANO, V.VCL_COR, V.VCL_COMBUSTIVEL, V.VCL_ALUGADO, V.VCL_SITUACAO," +
                " A.VCLAL_VALOR, A.VCLAL_DTINICIO, A.VCLAL_DTVENC from TB_VEICULOS as V join TB_VEICULOS_ALUGUEL as A " +
                "on V.VCL_PLACA = A.VCL_PLACA WHERE V.VCL_PLACA = '" + placa + "'";
            DataTable dt = _banco.BuscarRegistro(query);
            VeiculoAlugado veiculoAlugado = null;
            Veiculo veiculo = null;
            DataRow[] dataRows = dt.Select("VCL_PLACA = '" + placa + "'");
            foreach(DataRow dr in dataRows)
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

        public List<Veiculo> BuscarTodos()
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            string query = "select VCL_PLACA, VCL_MARCA, VCL_MODELO, VCL_CHASSI, VCL_ANO, VCL_COR, VCL_COMBUSTIVEL, VCL_ALUGADO, VCL_SITUACAO " +
                "from TB_VEICULOS WHERE VCL_ALUGADO = 0";
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

        public List<Veiculo> BuscarTodosAlugados()
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            string query = "select V.VCL_PLACA, V.VCL_MARCA, V.VCL_MODELO, V.VCL_CHASSI, V.VCL_ANO, V.VCL_COR, V.VCL_COMBUSTIVEL, V.VCL_ALUGADO, V.VCL_SITUACAO," +
                " A.VCLAL_VALOR, A.VCLAL_DTINICIO, A.VCLAL_DTVENC from TB_VEICULOS as V join TB_VEICULOS_ALUGUEL as A " +
                "on V.VCL_PLACA = A.VCL_PLACA";
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
        public bool Inativar(string placa) //Exemplo Deletar --- Será mudado para Inativar
        {
            string Query = "UPDATE TB_VEICULOS SET VCL_SITUACAO = 0 WHERE VCL_PLACA = '" + placa + "' ";
             return _banco.ExecutarInstrucao(Query);
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
            return _banco.ExecutarInstrucao(Query);
        }

        public bool AlterarAlugado(Veiculo veiculo, string placa)
        {
            int cor = veiculo.Cor.GetHashCode();
            int combustivel = veiculo.Combustivel.GetHashCode();
            int alugado = Convert.ToInt32(veiculo.Alugado);
            int situacao = Convert.ToInt32(veiculo.SituacaoVeiculo);
            string query1 = "";
            string query2 = "";
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

            else if (veiculo.VeiculoAlugado == null)
            {
                query1 = "UPDATE TB_VEICULOS SET VCL_PLACA = '" + veiculo.Placa + "', VCL_MARCA = '" + veiculo.Marca
                    + "', VCL_MODELO = '" + veiculo.Modelo + "',VCL_CHASSI = '" + veiculo.Chassi + "',VCL_ANO =  "
                    + veiculo.Ano + ",VCL_COR = " + cor + ",VCL_COMBUSTIVEL = " + combustivel
                    + ",VCL_ALUGADO = " + alugado + ", VCL_SITUACAO = " + situacao + " WHERE VCL_PLACA = '" + placa + "' ";
                query2 = "DELETE FROM [dbo].[TB_VEICULOS_ALUGUEL] WHERE VCL_PLACA = '" + veiculo.Placa + "'";
            }
            else  //Caso altere o veiculo e seu aluguel
            {
                query1 = "UPDATE TB_VEICULOS SET VCL_PLACA = '" + veiculo.Placa + "', VCL_MARCA = '" + veiculo.Marca
                    + "', VCL_MODELO = '" + veiculo.Modelo + "',VCL_CHASSI = '" + veiculo.Chassi + "',VCL_ANO =  "
                    + veiculo.Ano + ",VCL_COR = " + cor + ",VCL_COMBUSTIVEL = " + combustivel
                    + ",VCL_ALUGADO = " + alugado + ", VCL_SITUACAO = " + situacao + " WHERE VCL_PLACA = '" + placa + "' ";
                query2 = "UPDATE TB_VEICULOS SET VCL_PLACA = '" + veiculo.Placa + "', VCL_VCLAL_VALOR = " + veiculo.VeiculoAlugado.Valor
                    + ", VCL_VCLAL_DTINICIO = '" + veiculo.VeiculoAlugado.DataInicio.ToShortDateString()
                    + "',VCL_VCLAL_DTVENC = '" + veiculo.VeiculoAlugado.DataVencimento.ToShortDateString() + "' WHERE VCL_PLACA = '" + placa + "' ";
            }

            return _banco.ExecutaTransaction(query1, query2);
        }

    }
}
