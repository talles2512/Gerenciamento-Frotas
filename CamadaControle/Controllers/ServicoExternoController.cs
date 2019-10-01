using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    class ServicoExternoController
    {
        private readonly ServicoExternoService _servicoExternoService;

        public ServicoExternoController(ServicoExternoService servicoExternoService)
        {
            _servicoExternoService = servicoExternoService;
        }

        #region [AplicacaoDesktop]

        public void Cadastrar(ServicoExterno servicoExterno)
        {
            _servicoExternoService.Cadastrar(servicoExterno);
        }

        public void Deletar(int cnpj)
        {
            _servicoExternoService.Deletar(cnpj);
        }

        public void Alterar(ServicoExterno servicoExterno, int cnpj)
        {
            _servicoExternoService.Alterar(servicoExterno,cnpj);
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
