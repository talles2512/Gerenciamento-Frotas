using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models.Enums;

namespace CamadaModelagem.Models
{
    public class Manutencao
    {
        public ManutencaoTipo Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public SituacaoManutencao Situacao { get; set; }
        public long CNPJ { get; set; }
        public string Placa { get; set; }

        public Manutencao()
        {

        }

        public Manutencao(ManutencaoTipo tipo, string descricao, DateTime data, double valor, SituacaoManutencao situacao, long cNPJ, string placa)
        {
            Tipo = tipo;
            Descricao = descricao;
            Data = data;
            Valor = valor;
            Situacao = situacao;
            CNPJ = cNPJ;
            Placa = placa;
        }
    }
}
