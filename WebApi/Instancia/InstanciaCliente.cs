using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Instancia
{
    public class InstanciaCliente
    {
        public ClienteService _clienteService;

        public InstanciaCliente()
        {
            Banco banco = new Banco();
            ClienteDAL clienteDAL = new ClienteDAL(banco);
            _clienteService = new ClienteService(clienteDAL);
        }
    }
}