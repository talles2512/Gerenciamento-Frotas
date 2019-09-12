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
        public int CPF { get; set; }
        public Viagem Viagem { get; set; }

        public Ocupante()
        {

        }

        public Ocupante(string nome,int cPF, Viagem viagem)
        {
            Nome = nome;
            CPF = cPF;
            Viagem = viagem;
            //Requisicao = requisicao;
        }
    }
}
