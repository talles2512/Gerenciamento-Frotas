using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    class ServicoExternoConveniado
    {
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataVencimento { get; set; }
        public ServicoExterno  ServicoExterno { get; set; }

        public ServicoExternoConveniado()
        {

        }

        public ServicoExternoConveniado(double valor, DateTime dataInicio, DateTime dataVencimento, ServicoExterno servicoExterno)
        {
            Valor = valor;
            DataInicio = dataInicio;
            DataVencimento = dataVencimento;
            ServicoExterno = servicoExterno;
        }
    }
}
