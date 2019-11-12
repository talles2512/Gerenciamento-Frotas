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
    public class SinistroController
    {
        private readonly SinistroService _sinistroService;

        public SinistroController(SinistroService sinistroService)
        {
            _sinistroService = sinistroService;
        }

        #region [AplicacaoDesktop]

        public bool Cadastrar(Sinistro sinistro, int id, DateTime data, string item, long numapolice, string tipo)
        {      
            try
            {
                return _sinistroService.Cadastrar(sinistro, id, data, item, numapolice, tipo);
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

        public Sinistro BuscarSinistro(int id, DateTime data, string item, string tipo)
        {
            try
            {
                return _sinistroService.BuscarSinistro(id, data, item, tipo);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Sinistro> BuscarTodos(string tipo, DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _sinistroService.BuscarTodos(tipo, dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(Sinistro sinistro, int id, DateTime data, string tipo)
        {
            try
            {
                return _sinistroService.Deletar(sinistro, id, data, tipo);
            }
            catch
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Alterar(Sinistro sinistro, int id, string item, DateTime data, long numapolice, string tipo)
        {
            try
            {
                return _sinistroService.Alterar(sinistro, id, item, data, numapolice, tipo);
            }
            catch
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public int PopularID(string tipo)
        {
            try
            {
                return _sinistroService.PopulaID(tipo);
            }
            catch
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public DataTable PopularPlacas()
        {
            try
            {
                return _sinistroService.PopularPlacas();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public DataTable PopularCPFs()
        {
            try
            {
                return _sinistroService.PopularCPFs();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public DataTable PopularSeguroCPFs(string cpf)
        {
            try
            {
                return _sinistroService.PopularSeguroCPFs(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public DataTable PopularSeguroPlacas(string placa)
        {
            try
            {
                return _sinistroService.PopularSeguroPlacas(placa);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public Seguro BuscarSeguro(TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                return _sinistroService.BuscarSeguro(tipo, numeroApolice);
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
