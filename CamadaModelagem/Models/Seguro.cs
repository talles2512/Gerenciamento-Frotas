using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models.Enums;

namespace CamadaModelagem.Models
{
    public class Seguro
    {
        public int NumeroApolice { get; set; }
        public ItemSeguradoAbstrato ItemSegurado { get; set; } //Duvidas futuras aqui
        public string Tipo { get; set; }
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime FimVigencia { get; set; }
        public string Franquia { get; set; } //Duvidas futuras aqui
        public double ValorFranquia { get; set; }
        public List<SeguroCobertura> Cobertura { get; set; } = new List<SeguroCobertura>();
        public ServicoExterno ServicoExterno { get; set; }

        public Seguro()
        {

        }

        public Seguro(int numeroApolice, ItemSeguradoAbstrato itemSegurado, string tipo, double valor, DateTime dataInicio, DateTime fimVigencia, string franquia, double valorFranquia,
            ServicoExterno servicoExterno)
        {
            NumeroApolice = numeroApolice;
            ItemSegurado = itemSegurado;
            Tipo = tipo;
            Valor = valor;
            DataInicio = dataInicio;
            FimVigencia = fimVigencia;
            Franquia = franquia;
            ValorFranquia = valorFranquia;
            ServicoExterno = servicoExterno;
        }

        public void AdicionarCobertura(SeguroCobertura seguroCobertura)
        {
            Cobertura.Add(seguroCobertura);
        }

        public void RemoverCobertura(SeguroCobertura seguroCobertura)
        {
            Cobertura.Add(seguroCobertura);
        }
    }
}
