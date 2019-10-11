using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    public class Cliente
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public long Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? DataInicioContrato { get; set; }

        
        public Cliente()
        {

        }

        public Cliente(string cPF,string nome, string rg, string endereco, long telefone, string email, DateTime dataNascimento, DateTime? dataInicioContrato)
        {
            CPF = cPF;
            Nome = nome;
            RG = rg;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            DataInicioContrato = dataInicioContrato;
        }
    }
}
