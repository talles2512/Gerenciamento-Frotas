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
    public class MotoristaController
    {
        private readonly MotoristaService _motoristaService;

        public MotoristaController(MotoristaService motoristaService)
        {
            _motoristaService = motoristaService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(Motorista motorista, CNH cnh)
        {
            try
            {
                return _motoristaService.Cadastrar(motorista, cnh);
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

        public Motorista BuscarCPF(string cpf)
        {
            try
            {
                return _motoristaService.BuscarCPF(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Motorista> BuscarTodos()
        {
            try
            {
                return _motoristaService.BuscarTodos();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Inativar(string cpf)
        {
            try
            {
                return _motoristaService.Inativar(cpf);
            }          
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Motorista motorista, CNH cnh, string cpf)
        {
            try
            {
                return _motoristaService.Alterar(motorista, cnh, cpf);
            }
            catch (NaoEncontradoException e)
            {
                throw new NaoEncontradoException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
        #endregion

        #region [AplicacaoWeb]
        #endregion
    }
}

    
