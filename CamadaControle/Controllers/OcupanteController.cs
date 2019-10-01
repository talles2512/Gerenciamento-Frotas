using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    class OcupanteController
    {
        private readonly OcupanteService _ocupanteService;

        public OcupanteController(OcupanteService ocupanteService)
        {
            _ocupanteService = ocupanteService;
        }

        #region [AplicacaoDesktop]

        public void Cadastrar(Ocupante ocupante,int cpf)
        {
            _ocupanteService.Cadastrar(ocupante,cpf);
        }

        public void Deletar(int cpf)
        {
            _ocupanteService.Deletar(cpf);
        }

        public void Alterar(Ocupante ocupante, int cpf)
        {
            _ocupanteService.Alterar(ocupante,cpf);
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
