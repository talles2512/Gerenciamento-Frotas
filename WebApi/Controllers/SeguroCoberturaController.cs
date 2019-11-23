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
    [RoutePrefix("api/SeguroCobertura")]
    public class SeguroCoberturaController : ApiController
    {
        private readonly SeguroCoberturaService _seguroCoberturaService;

        public SeguroCoberturaController()
        {
            Banco banco = new Banco();
            SeguroCoberturaDAL seguroCoberturaDAL = new SeguroCoberturaDAL(banco);
            _seguroCoberturaService = new SeguroCoberturaService(seguroCoberturaDAL);
        }
        public SeguroCoberturaController(SeguroCoberturaService seguroCoberturaService)
        {
            _seguroCoberturaService = seguroCoberturaService;
        }

        #region [AplicacaoDesktop]

        public bool Cadastrar(SeguroCobertura seguroCobertura)
        {
            try
            {
                return _seguroCoberturaService.Cadastrar(seguroCobertura);
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

        public SeguroCobertura BuscarSeguroCobertura(TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                return _seguroCoberturaService.BuscarSeguroCobertura(tipo, numeroApolice);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<SeguroCobertura> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _seguroCoberturaService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                return _seguroCoberturaService.Deletar(tipo, numeroApolice);
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

        public bool Alterar(SeguroCobertura seguroCobertura, TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                return _seguroCoberturaService.Alterar(seguroCobertura, tipo, numeroApolice);
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

        public DataTable PopularSeguros(TipoSeguro tipo)
        {
            try
            {
                return _seguroCoberturaService.PopularSeguros(tipo);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]

        // GET: api/SeguroCobertura?tipo=VALOR&apolice=VALOR
        [HttpGet]
        public IHttpActionResult Get(TipoSeguro tipo, long apolice)
        {
            try
            {
                var result = _seguroCoberturaService.BuscarSeguroCobertura(tipo, apolice);
                if (result == null)
                {
                    return BadRequest("Cobertura do Seguro não encontrada!");
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

        //POST: api/SeguroCobertura
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] SeguroCobertura seguroCobertura)
        {
            if (seguroCobertura == null)
                return BadRequest();

            try
            {
                bool result = _seguroCoberturaService.Cadastrar(seguroCobertura);
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
