using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models.Enums;

namespace CamadaModelagem.Modelagem
{
    class Sinistro
    {
        public ItemSegurado ItemSegurado { get; set; } //Duvidas futuras aqui
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public Seguro Seguro { get; set; }

        public Sinistro()
        {

        }

        public Sinistro(ItemSegurado itemSegurado, string descricao, DateTime dataHora,Seguro seguro)
        {
            ItemSegurado = itemSegurado;
            Descricao = descricao;
            DataHora = dataHora;
            Seguro = seguro;
        }
    }
}
