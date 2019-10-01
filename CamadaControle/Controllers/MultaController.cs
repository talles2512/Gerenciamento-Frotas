using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    class MultaController
    {
        private readonly MultaService _multaService;

        public MultaController(MultaService multaService)
        {
            _multaService = multaService;
        }

        #region [AplicacaoDesktop]
        public void Cadastrar(Multa multa)
        {
            _multaService.Cadastrar(multa);
        }

        public void Deletar(string placa, int cpf, DateTime data)
        {
            _multaService.Deletar(placa,cpf,data);
        }

        public void Alterar(Multa multa, string placa, int cpf, DateTime data)
        {
            _multaService.Alterar(multa,placa,cpf,data);
        }

        #endregion

        #region [AplicacaoWeb]

        #endregion
    }
}
