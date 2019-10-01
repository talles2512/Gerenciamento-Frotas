using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    class SeguroCoberturaController
    {
        private readonly SeguroCoberturaService _seguroCoberturaService;

        public SeguroCoberturaController(SeguroCoberturaService seguroCoberturaService)
        {
            _seguroCoberturaService = seguroCoberturaService;
        }

        #region [AplicacaoDesktop]

        public void Cadastrar(SeguroCobertura seguroCobertura)
        {
            _seguroCoberturaService.Cadastrar(seguroCobertura);
        }

        public void Deletar(int id)
        {
            _seguroCoberturaService.Deletar(id);
        }

        public void Alterar(SeguroCobertura seguroCobertura, int id)
        {
            _seguroCoberturaService.Alterar(seguroCobertura,id);
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
