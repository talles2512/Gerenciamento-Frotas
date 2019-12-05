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
    [RoutePrefix("api/Multa")]
    public class OcupanteController : ApiController
    {
        private readonly OcupanteService _ocupanteService;

        public OcupanteController()
        {
            Banco banco = new Banco();
            OcupanteDAL ocupanteDAL = new OcupanteDAL(banco);
            _ocupanteService = new OcupanteService(ocupanteDAL);
        }
        public OcupanteController(OcupanteService ocupanteService)
        {
            _ocupanteService = ocupanteService;
        }

        #region [AplicacaoDesktop]

        public void Cadastrar(Ocupante ocupante)
        {
            _ocupanteService.Cadastrar(ocupante);
        }

        public Ocupante BuscarOcupante(int req, string cpf)
        {
            try
            {
                return _ocupanteService.BuscarOcupante(req, cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Ocupante> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _ocupanteService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public void Deletar(int cpf)
        {
            _ocupanteService.Deletar(cpf);
        }

        public void Alterar(Ocupante ocupante, int cpf)
        {
            _ocupanteService.Alterar(ocupante, cpf);
        }

        #endregion

        #region [AplicacaoWeb]

        // GET: api/Ocupante?requisicao=VALOR&cpf=VALOR
        [HttpGet]
        public IHttpActionResult Get(int requisicao, string cpf)
        {
            try
            {
                var result = _ocupanteService.BuscarOcupante(requisicao, cpf);
                if (result == null)
                {
                    return BadRequest("Ocupante não encontrado!");
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

        #endregion
    }
}
