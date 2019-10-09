using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models.Enums;

namespace CamadaModelagem.Models
{
    public class ServicoExterno
    {
        public long CNPJ { get; set; }
        public TipoServicoExterno Tipo { get; set; }
        public string Nome { get; set; }
        public long Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public bool Conveniado { get; set; }
        public ServicoExternoConveniado ServicoExternoConveniado { get; set; }

        public ServicoExterno()
        {

        }

        public ServicoExterno(long cNPJ, TipoServicoExterno tipo, string nome, long telefone, string email, string endereco, bool conveniado, ServicoExternoConveniado servicoExternoConveniado)
        {
            CNPJ = cNPJ;
            Tipo = tipo;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Conveniado = conveniado;
            ServicoExternoConveniado = servicoExternoConveniado;
        }
    }
}
