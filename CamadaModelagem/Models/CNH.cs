using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    public class CNH
    {
        public int Numero { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Categoria { get; set; }
        public string OrgaoEmissor { get; set; }
        public Motorista CPF { get; set; }  //Nova FK [CNH_MT_CPF]

        public CNH()
        {

        }

        public CNH(int numero, DateTime dataEmissao, DateTime dataVencimento, string categoria, string orgaoEmissor, Motorista cPF)
        {
            Numero = numero;
            DataEmissao = dataEmissao;
            DataVencimento = dataVencimento;
            Categoria = categoria;
            OrgaoEmissor = orgaoEmissor;
            CPF = cPF;
        }
    }
}
