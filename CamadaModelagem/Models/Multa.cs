using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    public class Multa
    {
        public string Descricao { get; set; }
        public string Local { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public double Valor { get; set; }
        public bool Paga { get; set; } //Sim ou Não
        public DateTime? MultasPagas { get; set; } //Nova adição da tabela [TB_MULTASPAGAS] para essa;
        public Veiculo Veiculo { get; set; } //A multa está relacionada à um veículo
        public Motorista Motorista { get; set; } //e à um motorista

        public Multa()
        {

        }

        public Multa(string descricao, string local, DateTime dataOcorrencia, double valor, bool paga, DateTime? multasPagas, Veiculo veiculo, Motorista motorista)
        {
            Descricao = descricao;
            Local = local;
            DataOcorrencia = dataOcorrencia;
            Valor = valor;
            Paga = paga;
            MultasPagas = multasPagas;
            Veiculo = veiculo;
            Motorista = motorista;
        }
    }
}
