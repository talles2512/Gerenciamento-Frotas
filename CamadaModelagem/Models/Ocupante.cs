using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    public class Ocupante
    {
        public string Nome { get; set; }
        public long CPF { get; set; }
        public int Requisicao { get; set; }

        public Ocupante()
        {

        }

        public Ocupante(string nome,long cPF, int requisicao)
        {
            Nome = nome;
            CPF = cPF;
            Requisicao = requisicao;
        }
    }
}
