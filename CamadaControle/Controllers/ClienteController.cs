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
    public class ClienteController
    {
        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(Cliente cliente, string cpf)
        {
            try
            {
                return _clienteService.Cadastrar(cliente, cpf);
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

        public void Deletar(int cpf)
        {
            _clienteService.Deletar(cpf);
        }

        public void Alterar(Cliente cliente, int cpf)
        {
            _clienteService.Alterar(cliente, cpf);
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
