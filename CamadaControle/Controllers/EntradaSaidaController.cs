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
    public class EntradaSaidaController
    {
        private readonly EntradaSaidaService _entradaSaidaService;

        public EntradaSaidaController(EntradaSaidaService entradaSaidaService)
        {
            _entradaSaidaService = entradaSaidaService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(EntradaSaida entradaSaida, string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data) //Mudança na Query, Verificar
        {
            try
            {
                return _entradaSaidaService.Cadastrar(entradaSaida, placa, cnpj, tipo, data);
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

        public EntradaSaida BuscarEntradaSaida(string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data)
        {
            try
            {
                return _entradaSaidaService.BuscarEntradaSaida(placa, cnpj, tipo, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<EntradaSaida> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _entradaSaidaService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data)
        {
            try
            {
                return _entradaSaidaService.Deletar(placa, cnpj, tipo, data);
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

        public bool Alterar(EntradaSaida entradaSaida, string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data)
        {
            try
            {
                return _entradaSaidaService.Alterar(entradaSaida, placa, cnpj, tipo, data);
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

        public DataTable PopularCPFs()
        {
            try
            {
                return _entradaSaidaService.PopularCPFs();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        public DataTable PopularPlacas()
        {
            try
            {
                return _entradaSaidaService.PopularPlacas();
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
                return _entradaSaidaService.PopularServicosExternos();
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
