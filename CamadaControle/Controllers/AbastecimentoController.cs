using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
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
        public bool Cadastrar(Abastecimento abastecimento, string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                return _abastecimentoService.Cadastrar(abastecimento, placa, tipo, data);
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

        public Abastecimento BuscarAbastecimento(string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                return _abastecimentoService.BuscarAbastecimento(placa, tipo, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Abastecimento> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _abastecimentoService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                return _abastecimentoService.Deletar(placa, tipo, data);
            }
            catch (IntegridadeException e)
            {
                throw new IntegridadeException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Abastecimento abastecimento, string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                return _abastecimentoService.Alterar(abastecimento, placa, tipo, data);
            }
            catch (NaoEncontradoException e)
            {
                throw new NaoEncontradoException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public DataTable PopularPlacas()
        {
            try
            {
                return _abastecimentoService.PopularPlacas();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public DataTable PopularServicosExternos()
        {
            try
            {
                return _abastecimentoService.PopularServicosExternos();
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
