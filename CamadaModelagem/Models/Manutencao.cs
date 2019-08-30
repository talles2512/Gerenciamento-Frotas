using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models.Enums;

namespace CamadaModelagem.Models
{
    class Manutencao
    {
        public ManutencaoTipo Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public float Valor { get; set; }
        public SituacaoManutencao Situacao { get; set; }
        public ServicoExterno ServicoExterno { get; set; }
        public Veiculo Veiculo { get; set; }

        public Manutencao()
        {

        }

        public Manutencao(ManutencaoTipo tipo, string descricao, DateTime data, float valor, SituacaoManutencao situacao, ServicoExterno servicoExterno, Veiculo veiculo)
        {
            Tipo = tipo;
            Descricao = descricao;
            Data = data;
            Valor = valor;
            Situacao = situacao;
            ServicoExterno = servicoExterno;
            Veiculo = veiculo;
        }
    }
}
