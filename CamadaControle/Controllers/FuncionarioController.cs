using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    public class FuncionarioController
    {
        private readonly FuncionarioService _funcionarioService;

        public FuncionarioController(FuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        #region AplicacaoDesktop
        public void Cadastrar(Funcionario funcionario, string login)
        {
            _funcionarioService.Cadastrar(funcionario, login);
        }

        public void Deletar(string login)
        {
            _funcionarioService.Deletar(login);
        }

        public void Alterar(Funcionario funcionario, string login)
        {
            _funcionarioService.Alterar(funcionario, login);
        }

        #endregion

        #region AplicacaoWeb



        #endregion
    }
}
