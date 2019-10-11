using CamadaModelagem.Models;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;
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

        #region [AplicacaoDesktop]
        public bool Cadastrar(Funcionario funcionario, string login)
        {
            try
            {
                return _funcionarioService.Cadastrar(funcionario, login);
            }
            catch (RegistroExisteException e)
            {
                throw new RegistroExisteException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
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

        #region [AplicacaoWeb]



        #endregion
    }
}
