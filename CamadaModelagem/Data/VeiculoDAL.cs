using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;

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
            string query = "INSERT INTO [dbo].[TB_VEICULOS]([VCL_PLACA],[VCL_MARCA],[VCL_MODELO],[VCL_CHASSI],[VCL_ANO],[VCL_COR],[VCL_COMBUSTIVEL],[VCL_ALUGADO],[VCL_SITUACAO]) " +
                "VALUES('" + veiculo.Placa + "', '" + veiculo.Marca + "', '" + veiculo.Modelo + "', '" + veiculo.Chassi + "', '" + veiculo.Ano + "', " + veiculo.Cor + "," + veiculo.Combustivel + ", '" + veiculo.Alugado + "', " + veiculo.SituacaoVeiculo + ")";
            _banco.ExecutarInstrucao(query);
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
