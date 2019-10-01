using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    public class EstoquePecasController
    {
        private readonly EstoquePecasService _estoquePecasService;

        public EstoquePecasController(EstoquePecasService estoquePecasService)
        {
            _estoquePecasService = estoquePecasService;
        }

        #region AplicacaoDesktop
        public void Cadastrar(EstoquePeca estoquePeca, int idpeca)
        {
            _estoquePecasService.Cadastrar(estoquePeca, idpeca);
        }

        public void Deletar(int idpeca)
        {
            _estoquePecasService.Deletar(idpeca);
        }

        public void Alterar(EstoquePeca estoquePeca, int idpeca)
        {
            _estoquePecasService.Alterar(estoquePeca, idpeca);
        }

        #endregion

        #region AplicacaoWeb



        #endregion
    }
}
