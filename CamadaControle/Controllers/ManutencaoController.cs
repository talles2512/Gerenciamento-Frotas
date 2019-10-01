using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    public class ManutencaoController
    {
        private readonly ManutencaoService _manutencaoService;

        public ManutencaoController(ManutencaoService manutencaoService)
        {
            _manutencaoService = manutencaoService;
        }

        #region [AplicacaoDesktop]
        public void Cadastrar(Manutencao manutencao)
        {
            _manutencaoService.Cadastrar(manutencao);
        }

        public void Deletar(string placa, int tipo, DateTime data)
        {
            _manutencaoService.Deletar(placa, tipo, data);
        }

        public void Alterar(Manutencao manutencao, string placa, int tipo, DateTime data)
        {
            _manutencaoService.Alterar(manutencao, placa, tipo, data);
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
