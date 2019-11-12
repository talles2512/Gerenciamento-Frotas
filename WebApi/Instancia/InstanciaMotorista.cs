using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Instancia
{
    public class InstanciaMotorista
    {
        public MotoristaService _motoristaService;

        public InstanciaMotorista()
        {
            Banco banco = new Banco();
            MotoristaDAL motoristaDAL = new MotoristaDAL(banco);
            EntradaSaidaDAL entradaSaidaDAL = new EntradaSaidaDAL(banco);
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            _motoristaService = new MotoristaService(motoristaDAL, entradaSaidaDAL, seguroDAL);
        }
    }
}