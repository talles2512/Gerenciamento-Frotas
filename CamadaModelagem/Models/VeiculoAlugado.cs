using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    public class VeiculoAlugado
    {
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataVencimento { get; set; }

        public VeiculoAlugado()
        {

        }

        public VeiculoAlugado(double valor, DateTime dataInicio, DateTime dataVencimento)
        {
            Valor = valor;
            DataInicio = dataInicio;
            DataVencimento = dataVencimento;
        }
    }
}
