using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models //Precisa ainda dessa Class ?
{
    public class MultaPaga
    {
        public DateTime DataPagamento { get; set; }

        public MultaPaga()
        {

        }

        public MultaPaga(DateTime dataPagamento)
        {
            DataPagamento = dataPagamento;
        }
    }
}
