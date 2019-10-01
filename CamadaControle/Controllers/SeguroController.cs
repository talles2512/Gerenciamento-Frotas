using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    class SeguroController
    {
        private readonly SeguroService _seguroService;

        public SeguroController(SeguroService seguroService)
        {
            _seguroService = seguroService;
        }

        #region [AplicacaoDesktop]

        public void Cadastrar(Seguro seguro)
        {
            _seguroService.Cadastrar(seguro);
        }

        public void Deletar(int numApolice)
        {
            _seguroService.Deletar(numApolice);
        }

        public void Alterar(Seguro seguro, int numApolice)
        {
            _seguroService.Alterar(seguro,numApolice);
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
