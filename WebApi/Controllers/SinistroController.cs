using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Sinistro")]
    public class SinistroController : ApiController
    {
        private readonly SinistroService _sinistroService;

        public SinistroController()
        {
            Banco banco = new Banco();
            SinistroDAL sinistroDAL = new SinistroDAL(banco);
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            _sinistroService = new SinistroService(sinistroDAL);
        }
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

        // GET: api/Sinistro?id=VALOR&data=VALOR&tipo=VALOR
        [HttpGet]
        public IHttpActionResult Get(int id, DateTime data, string item, string tipo)
        {
            try
            {
                var result = _sinistroService.BuscarSinistro(id, data, item, tipo);
                if (result == null)
                {
                    return BadRequest("Sinistro não encontrado!");
                }
                else
                {
                    return Ok(result);
                }
            }
            catch (ConcorrenciaBancoException)
            {
                return BadRequest("Favor tentar novamente mais tarde.");
            }
        }

        //POST: api/Sinistro
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Sinistro sinistro)
        {
            if (sinistro == null)
                return BadRequest();

            try
            {
                bool result = _sinistroService.Cadastrar(sinistro, sinistro.Id, sinistro.DataHora, sinistro.Item, sinistro.Seguro.NumeroApolice, sinistro.ItemSegurado.ToString());
                if (result)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Houve um erro na operação!");
                }
            }
            catch (RegistroExisteException e)
            {
                return BadRequest(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                return BadRequest(e.Message);
            }

        }

        #endregion
    }
}
