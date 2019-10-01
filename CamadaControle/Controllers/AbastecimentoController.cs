using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    public class AbastecimentoController
    {
        private readonly AbastecimentoService _abastecimentoService;

        public AbastecimentoController(AbastecimentoService abastecimentoService)
        {
            _abastecimentoService = abastecimentoService;
        }

        #region [AplicacaoDesktop]
        public void Cadastrar(Abastecimento abastecimento)
        {
            _abastecimentoService.Cadastrar(abastecimento);
        }

        public void Deletar(string placa, int tipo, DateTime data)
        {
            _abastecimentoService.Deletar(placa, tipo, data);
        }

        public void Alterar(Abastecimento abastecimento, string placa, int tipo, DateTime data)
        {
            _abastecimentoService.Alterar(abastecimento, placa, tipo, data);
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
