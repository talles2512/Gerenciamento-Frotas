
using CamadaModelagem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    public class Abastecimento
    {
        public AbastecimentoTipo Tipo { get; set; } //Enum de Abastecimento
        public double ValorLitro { get; set; }
        public DateTime Data { get; set; }
        public Veiculo Veiculo { get; set; }
        public ServicoExterno ServicoExterno { get; set; }

        public Abastecimento()
        {

        }

        public Abastecimento(AbastecimentoTipo tipo, double valorLitro, DateTime data, Veiculo veiculo, ServicoExterno servicoExterno)
        {
            Tipo = tipo;
            ValorLitro = valorLitro;
            Data = data;
            Veiculo = veiculo;
            ServicoExterno = servicoExterno;
        }
    }
}
