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
        public string Item { get; set; } //Duvidas tambem aqui
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public Seguro Seguro { get; set; }

        public Sinistro()
        {
        }

        public Sinistro(int id, string item, string descricao, DateTime dataHora,Seguro seguro)
        {
            Id = id;
            Item = item;
            Descricao = descricao;
            DataHora = dataHora;
            Seguro = seguro;
        }
    }
}
