using CamadaModelagem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public PerfilAcesso PerfilAcesso { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, string login ,string senha, PerfilAcesso perfilAcesso)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            PerfilAcesso = perfilAcesso;
        }
    }
}
