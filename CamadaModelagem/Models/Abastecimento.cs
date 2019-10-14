
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
        public double Valor { get; set; }
        public double Litros { get; set; }
        public DateTime Data { get; set; }
        public string Placa { get; set; }
        public long CNPJ { get; set; }

        public Abastecimento()
        {

        }

        public Abastecimento(AbastecimentoTipo tipo, double valor, double litros, DateTime data, string placa, long cNPJ)
        {
            Tipo = tipo;
            Valor = valor;
            Litros = litros;
            Data = data;
            Placa = placa;
            CNPJ = cNPJ;
        }
    }
}
