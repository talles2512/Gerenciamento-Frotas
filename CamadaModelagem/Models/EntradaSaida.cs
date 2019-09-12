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
        public Motorista Motorista { get; set; }
        public Veiculo Veiculo { get; set; }
        public ServicoExterno ServicoExterno { get; set; }


        public EntradaSaida()
        {

        }

        public EntradaSaida(EntradaSaidaTipo tipo, DateTime dataHora, Motorista motorista, Veiculo veiculo, ServicoExterno servicoExterno)
        {
            Tipo = tipo;
            DataHora = dataHora;
            Motorista = motorista;
            Veiculo = veiculo;
            ServicoExterno = servicoExterno;
        }
    }
}
