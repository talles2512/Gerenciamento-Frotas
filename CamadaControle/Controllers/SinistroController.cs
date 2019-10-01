using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    class SinistroController
    {
        private readonly SinistroService _sinistroService;

        public SinistroController(SinistroService sinistroService)
        {
            _sinistroService = sinistroService;
        }

        #region [AplicacaoDesktop]

        public void Cadastrar(Sinistro sinistro, int id, DateTime data)
        {
            _sinistroService.Cadastrar(sinistro,id,data);
        }

        public void Deletar(int id, DateTime data)
        {
            _sinistroService.Deletar(id,data);
        }

        public void Alterar(Sinistro sinistro, int id, DateTime data)
        {
            _sinistroService.Alterar(sinistro,id,data);
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
