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

        public Funcionario BuscarCPF(string login)
        {
            try
            {
                return _funcionarioService.BuscarCPF(login);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Funcionario> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _funcionarioService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string login)
        {           
            try
            {
                return _funcionarioService.Deletar(login);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Alterar(Funcionario funcionario, string login)
        {
            try
            {
                return _funcionarioService.Alterar(funcionario, login);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }

        }

        public List<Funcionario> Pesquisar(string busca)
        {
            try
            {
                return _funcionarioService.Pesquisar(busca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
