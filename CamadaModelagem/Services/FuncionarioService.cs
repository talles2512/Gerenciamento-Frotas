using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Services
{
    public class FuncionarioService
    {
        private readonly FuncionarioDAL _funcionarioDAL;

        public FuncionarioService(FuncionarioDAL funcionarioDAL)
        {
            _funcionarioDAL = funcionarioDAL;
        }

        public bool Cadastrar(Funcionario funcionario, string login)
        {
            try
            {
                Funcionario obj = _funcionarioDAL.BuscarLogin(login); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um funcionario com esse Login no sistema!");
                }
                return _funcionarioDAL.Cadastrar(funcionario);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public void Deletar(string login)
        {
            try
            {
                _funcionarioDAL.Deletar(login);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Funcionario não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Funcionario funcionario, string login)
        {
            //try
            //{
            //    Funcionario obj = _funcionarioDAL.BuscarLogin(login); //Falta criar os métodos de busca
            //    if (obj == null)
            //    {
            //        throw new NaoEncontradoException("Funcionario não encontrado.");
            //    }
            //    _funcionarioDAL.Alterar(funcionario,login);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }
    }
}
