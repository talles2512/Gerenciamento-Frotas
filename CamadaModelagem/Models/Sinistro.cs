using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models.Enums;

namespace CamadaModelagem.Models
{
    public class Sinistro
    {
        public int Id { get; set; }
        public ItemSegurado ItemSegurado { get; set; } //Duvidas futuras aqui
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public Seguro Seguro { get; set; }

        public Sinistro()
        {

        }

        public Sinistro(int id, ItemSegurado itemSegurado, string descricao, DateTime dataHora,Seguro seguro)
        {
            Id = id;
            ItemSegurado = itemSegurado;
            Descricao = descricao;
            DataHora = dataHora;
            Seguro = seguro;
        }
    }
}
