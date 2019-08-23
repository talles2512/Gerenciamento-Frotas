using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Modelagem
{
    class SeguroCobertura
    {
        public string Descricao { get; set; }

        public SeguroCobertura()
        {

        }

        public SeguroCobertura(string descricao)
        {
            Descricao = descricao;
        }
    }
}
