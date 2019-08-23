using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Modelagem //Precisa ainda dessa Class ?
{
    class MultaPaga
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
