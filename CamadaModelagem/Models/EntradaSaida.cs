using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models.Enums;

namespace CamadaModelagem.Models
{
    public class EntradaSaida
    {
        public EntradaSaidaTipo Tipo { get; set; }
        public DateTime DataHora { get; set; }
        public string CPF { get; set; }
        public string Placa { get; set; }
        public long CNPJ { get; set; }


        public EntradaSaida()
        {

        }

        public EntradaSaida(EntradaSaidaTipo tipo, DateTime dataHora, string cPF, string placa, long cNPJ)
        {
            Tipo = tipo;
            DataHora = dataHora;
            CPF = cPF;
            Placa = placa;
            CNPJ = cNPJ;
        }
    }
}
