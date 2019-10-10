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
    public class ServicoExternoController
    {
        private readonly ServicoExternoService _servicoExternoService;

        public ServicoExternoController(ServicoExternoService servicoExternoService)
        {
            _servicoExternoService = servicoExternoService;
        }

        #region [AplicacaoDesktop]

        public bool Cadastrar(ServicoExterno servicoExterno, long cnpj)
        {
            try
            {
                return _servicoExternoService.Cadastrar(servicoExterno, cnpj); ;
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

        public ServicoExterno BuscarCNPJ(long cnpj)
        {
            try
            {
                return _servicoExternoService.BuscarCNPJ(cnpj);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<ServicoExterno> BuscarTodos()
        {
            try
            {
                return _servicoExternoService.BuscarTodos();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(long cnpj)
        {
            try
            {
                return _servicoExternoService.Deletar(cnpj);
            }
            catch (IntegridadeException e)
            {
                throw new IntegridadeException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(ServicoExterno servicoExterno, long cnpj)
        {
            try
            {
                return _servicoExternoService.Alterar(servicoExterno,cnpj);
            }
            catch (NaoEncontradoException e)
            {
                throw new NaoEncontradoException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
            catch (TransacaoException e)
            {
                throw new TransacaoException(e.Message);
            }
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
