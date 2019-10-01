using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    class ViagemController
    {
        private readonly ViagemService _viagemService;

        public ViagemController(ViagemService viagemService)
        {
            _viagemService = viagemService;
        }

        #region [AplicacaoDesktop]

        public void Cadastrar(Viagem viagem,int requisicao)
        {
            _viagemService.Cadastrar(viagem,requisicao);
        }

        public void Deletar(int requisicao)
        {
            _viagemService.Deletar(requisicao);
        }

        public void Alterar(Viagem viagem, int requisicao)
        {
            _viagemService.Alterar(viagem,requisicao);
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
