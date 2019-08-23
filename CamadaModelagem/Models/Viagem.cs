using CamadaModelagem.Modelagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Modelagem
{
    class Viagem
    {
        public int Requisicao { get; set; }
        public bool Ocupante { get; set; } //Sim ou Não
        public List<Ocupante> Ocupantes { get; set; } = new List<Ocupante>();
        public string Destino { get; set; }
        public DateTime DataSaida { get; set; }
        public Veiculo Veiculo { get; set; }
        public Motorista Motorista { get; set; }
        public ServicoExterno ServicoExterno { get; set; }

        public Viagem()
        {

        }

        public Viagem(int requisicao,bool ocupante,string destino,DateTime dataSaida, Veiculo veiculo, Motorista motorista, ServicoExterno servicoExterno)
        {
            Requisicao = requisicao;
            Ocupante = ocupante;
            Destino = destino;
            DataSaida = dataSaida;
            Veiculo = veiculo;
            Motorista = motorista;
            ServicoExterno = servicoExterno;
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
