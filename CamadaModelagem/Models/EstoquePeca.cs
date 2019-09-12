using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    public class EstoquePeca
    {
        public int Id { get; set; } //Já Identity no Banco
        public string Descricao { get; set; }
        public double ValorUnit { get; set; }
        public int Quantidade { get; set; }

        public EstoquePeca()
        {

        }

        public EstoquePeca(int id, string descricao, double valorUnit, int quantidade)
        {
            Id = id; 
            Descricao = descricao;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
        }
    }
}
