using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    public class Viagem
    {
        public int Requisicao { get; set; }
        public bool Ocupante { get; set; } //Sim ou Não
        public List<Ocupante> Ocupantes { get; set; } = new List<Ocupante>();
        public string Destino { get; set; }
        public DateTime DataSaida { get; set; }
        public string Placa { get; set; }
        public string CPF { get; set; }

        public Viagem()
        {

        }

        public Viagem(int requisicao,bool ocupante,string destino,DateTime dataSaida, string placa, string cPF)
        {
            Requisicao = requisicao;
            Ocupante = ocupante;
            Destino = destino;
            DataSaida = dataSaida;
            Placa = placa;
            CPF = cPF;
        }

        public void AdicionarOcupante(Ocupante ocupante)
        {
            Ocupantes.Add(ocupante);
        }

        public void RemoverOcupante(Ocupante ocupante)
        {
            Ocupantes.Remove(ocupante);
        }

    }
}
