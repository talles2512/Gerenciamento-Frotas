using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    class ClienteController
    {
        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        #region AplicacaoDesktop
        public void Cadastrar(Cliente cliente, int cpf)
        {
            _clienteService.Cadastrar(cliente, cpf);
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

        #region AplicacaoWeb



        #endregion
    }
}
