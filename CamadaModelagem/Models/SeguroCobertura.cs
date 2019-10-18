using CamadaModelagem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    public class SeguroCobertura
    {
        public TipoSeguro Tipo { get; set; }
        public string Descricao { get; set; }
        public long NumeroApolice { get; set; }

        public SeguroCobertura()
        {

        }

        public SeguroCobertura(TipoSeguro tipo,string descricao, long numeroApolice)
        {
            Tipo = tipo;
            Descricao = descricao;
            NumeroApolice = numeroApolice;
        }
    }
}
