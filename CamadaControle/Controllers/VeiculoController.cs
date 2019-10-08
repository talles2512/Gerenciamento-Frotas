using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;

namespace CamadaControle.Controllers
{
    public class VeiculoController
    {
        private readonly VeiculoService _veiculoService;

        public VeiculoController(VeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        #region [AplicacaoDesktop]

        public bool Cadastrar(Veiculo veiculo, string placa)
        {
            try
            {
               return _veiculoService.Cadastrar(veiculo, placa);
            }
            catch (RegistroExisteException e)
            {
                throw new RegistroExisteException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Veiculo BuscarPlaca(string placa)
        {
            try
            {
                return _veiculoService.BuscarPlaca(placa);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Veiculo> BuscarTodos()
        {
            try
            {
                return _veiculoService.BuscarTodos();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
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

        #region [AplicacaoWeb]



        #endregion
    }
}
