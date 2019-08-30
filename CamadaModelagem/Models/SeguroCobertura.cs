using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    class SeguroCobertura
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Seguro Seguro { get; set; }

        public SeguroCobertura()
        {

        }

        public SeguroCobertura(int id,string descricao, Seguro seguro)
        {
            Id = id;
            Descricao = descricao;
            Seguro = seguro;
        }
    }
}
