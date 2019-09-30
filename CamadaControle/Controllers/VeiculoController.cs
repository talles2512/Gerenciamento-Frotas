using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models;
using CamadaModelagem.Services;

namespace CamadaControle.Controllers
{
    public class VeiculoController
    {
        private readonly VeiculoService _veiculoService;

        public VeiculoController(VeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        #region AplicacaoDesktop
        public void Cadastrar(Veiculo veiculo, string placa)
        {
            _veiculoService.Cadastrar(veiculo, placa);
        }

        public void Deletar(string placa)
        {
            _veiculoService.Deletar(placa);
        }

        public void Alterar(Veiculo veiculo, string placa)
        {
            _veiculoService.Alterar(veiculo, placa);
        }

        #endregion

        #region AplicacaoWeb



        #endregion
    }
}
