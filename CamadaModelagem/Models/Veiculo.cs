using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models.Enums;

namespace CamadaModelagem.Models
{
    public class Veiculo : ItemSeguradoAbstrato
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Chassi { get; set; }
        public int Ano { get; set; }
        public VeiculoTipoCor Cor { get; set; }  //NOVO
        public VeiculoCombustivel Combustivel { get; set; }
        public bool Alugado { get; set; }
        public bool SituacaoVeiculo { get; set; }
        public VeiculoAlugado VeiculoAlugado { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(string placa, string marca, string modelo, string chassi, int ano, VeiculoTipoCor cor, VeiculoCombustivel combustivel, bool alugado, bool situacaoVeiculo, VeiculoAlugado veiculoAlugado)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Chassi = chassi;
            Ano = ano;
            Cor = cor;
            Combustivel = combustivel;
            Alugado = alugado;
            SituacaoVeiculo = situacaoVeiculo;
            VeiculoAlugado = veiculoAlugado;
        }
    }
}
