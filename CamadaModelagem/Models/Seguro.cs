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
        public long NumeroApolice { get; set; }
        public string ItemSegurado { get; set; } //Duvidas futuras aqui
        public TipoSeguro Tipo { get; set; }
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime FimVigencia { get; set; }
        public string Franquia { get; set; } //Duvidas futuras aqui
        public double ValorFranquia { get; set; }
        public List<SeguroCobertura> Cobertura { get; set; } = new List<SeguroCobertura>();
        public long CNPJ { get; set; }

        public Seguro()
        {

        }

        public Seguro(long numeroApolice, string itemSegurado, TipoSeguro tipo, double valor, DateTime dataInicio, DateTime fimVigencia, long cNPJ)
        {
            NumeroApolice = numeroApolice;
            ItemSegurado = itemSegurado;
            Tipo = tipo;
            Valor = valor;
            DataInicio = dataInicio;
            FimVigencia = fimVigencia;
            Franquia = "";
            ValorFranquia = 0;
            CNPJ = cNPJ;
        }

        public Seguro(long numeroApolice, string itemSegurado, TipoSeguro tipo, double valor, DateTime dataInicio, DateTime fimVigencia, string franquia, double valorFranquia,
            long cNPJ)
        {
            NumeroApolice = numeroApolice;
            ItemSegurado = itemSegurado;
            Tipo = tipo;
            Valor = valor;
            DataInicio = dataInicio;
            FimVigencia = fimVigencia;
            Franquia = franquia;
            ValorFranquia = valorFranquia;
            CNPJ = cNPJ;
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
