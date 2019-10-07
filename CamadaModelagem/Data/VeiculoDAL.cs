using System;
using System.Collections.Generic;
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
        public void Cadastrar(Veiculo veiculo) //Exemplo Cadastrar
        {
            int cor = veiculo.Cor.GetHashCode();
            int combustivel = veiculo.Combustivel.GetHashCode();
            int alugado = Convert.ToInt32(veiculo.Alugado);
            int situacao = Convert.ToInt32(veiculo.SituacaoVeiculo);

            string query = "INSERT INTO [dbo].[TB_VEICULOS]([VCL_PLACA],[VCL_MARCA],[VCL_MODELO],[VCL_CHASSI],[VCL_ANO],[VCL_COR],[VCL_COMBUSTIVEL],[VCL_ALUGADO],[VCL_SITUACAO]) " +
                "VALUES('" + veiculo.Placa + "', '" + veiculo.Marca + "', '" + veiculo.Modelo + "', '" + veiculo.Chassi + "', '" + veiculo.Ano + "', " + cor + "," + combustivel + ", " + alugado + ", " + situacao + ")";
            _banco.ExecutarInstrucao(query);
        }

        public void CadastrarAlugado(Veiculo veiculo)
        {
            int cor = veiculo.Cor.GetHashCode();
            int combustivel = veiculo.Combustivel.GetHashCode();
            int alugado = Convert.ToInt32(veiculo.Alugado);
            int situacao = Convert.ToInt32(veiculo.SituacaoVeiculo);

            string query1 = "INSERT INTO [dbo].[TB_VEICULOS]([VCL_PLACA],[VCL_MARCA],[VCL_MODELO],[VCL_CHASSI],[VCL_ANO],[VCL_COR],[VCL_COMBUSTIVEL],[VCL_ALUGADO],[VCL_SITUACAO]) " +
                "VALUES('" + veiculo.Placa + "', '" + veiculo.Marca + "', '" + veiculo.Modelo + "', '" + veiculo.Chassi + "', '" + veiculo.Ano + "', " + cor + "," + combustivel + ", " + alugado + ", " + situacao + ")";
            string query2 = "INSERT INTO [dbo].[TB_VEICULOS_ALUGUEL]([VCL_PLACA],[VCLAL_VALOR],[VCLAL_DTINICIO],[VCLAL_DTVENC]) " +
                "VALUES('" + veiculo.Placa + "', " + veiculo.VeiculoAlugado.Valor + ", '" + veiculo.VeiculoAlugado.DataInicio.ToShortDateString() + "', '" + veiculo.VeiculoAlugado.DataVencimento.ToShortDateString() + "')";
            _banco.ExecutaTransaction(query1, query2);
        }

        public Veiculo BuscarPlaca(string placa)
        {
            string query = "select V.*, A.VCLAL_VALOR, A.VCLAL_DTINICIO, A.VCLAL_DTVENC V from TB_VEICULOS as V join TB_VEICULOS_ALUGUEL as A " +
                "on V.VCL_PLACA = a.VCL_PLACA WHERE V.VCL_PLACA = " + placa;
            SqlDataReader dr = _banco.BuscarRegistro(query);
            VeiculoAlugado veiculoAlugado = null;
            Veiculo veiculo = null;
            if (dr.Read())
            {
                DateTime ano = DateTime.Parse(dr["VCL_ANO"].ToString());
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
                veiculo = new Veiculo(dr["VCL_PLACA"].ToString(), dr["VCL_MARCA"].ToString(), dr["VCL_MODELO"].ToString(), dr["VCL_CHASSI"].ToString(), ano.Year, cor, combustivel, alugado, situacao, veiculoAlugado);
            }
            return veiculo;
        }

        public void Deletar(string placa) //Exemplo Deletar --- Será mudado para Inativar
        {
            string Query = "DELETE TB_VEICULOS WHERE VCL_PLACA = '" + placa + "' ";
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(Veiculo veiculo, string placa)
        {
            string Query = "UPDATE TB_VEICULOS SET VCL_PLACA = '" + veiculo.Placa + "', VCL_MARCA = '" + veiculo.Marca + "', VCL_MODELO = '" + veiculo.Modelo + "',VCL_CHASSI = '" + veiculo.Chassi + "',VCL_ANO =  " + veiculo.Ano + ",VCL_COR = " + veiculo.Cor + ",VCL_COMBUSTIVEL = " + veiculo.Combustivel + ",VCL_ALUGADO = '" + veiculo.Alugado + "' WHERE VCL_PLACA = '" + placa + "' ";
            _banco.ExecutarInstrucao(Query);
        }

    }
}
