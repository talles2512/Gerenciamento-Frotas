using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    class MotoristaController
    {
        private readonly MotoristaService _motoristaService;

        public MotoristaController(MotoristaService motoristaService)
        {
            _motoristaService = motoristaService;
        }

        #region [AplicacaoDesktop]
        public void Cadastrar(Motorista motorista, CNH cnh)
        {
            _motoristaService.Cadastrar(motorista,cnh);
        }

        public void Deletar(int cpf)
        {
            _motoristaService.Deletar(cpf);
        }

        public void Alterar(Motorista motorista, CNH cnh, int cpf)
        {
            _motoristaService.Alterar(motorista,cnh,cpf);
        }
        #endregion

        #region [AplicacaoWeb]
        #endregion
    }
}

    
