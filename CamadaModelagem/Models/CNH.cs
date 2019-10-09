using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    public class CNH
    {
        public long Numero { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Categoria { get; set; }
        public string OrgaoEmissor { get; set; }

        public CNH()
        {

        }

        public CNH(long numero, DateTime dataEmissao, DateTime dataVencimento, string categoria, string orgaoEmissor)
        {
            Numero = numero;
            DataEmissao = dataEmissao;
            DataVencimento = dataVencimento;
            Categoria = categoria;
            OrgaoEmissor = orgaoEmissor;
        }
    }
}
