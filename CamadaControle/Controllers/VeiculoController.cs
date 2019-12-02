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

        public List<Veiculo> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _veiculoService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Inativar(string placa, bool sit)
        {
            try
            {
                return _veiculoService.Inativar(placa, sit);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Veiculo veiculo, string placa)
        {
            try
            {
                return _veiculoService.Alterar(veiculo, placa);
            }
            catch (NaoEncontradoException e)
            {
                throw new NaoEncontradoException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
            catch (TransacaoException e)
            {
                throw new TransacaoException(e.Message);
            }
            catch (IntegridadeException e)
            {
                throw new IntegridadeException(e.Message);
            }
        }

        public List<Veiculo> Pesquisar(string busca)
        {
            try
            {
                return _veiculoService.Pesquisar(busca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
