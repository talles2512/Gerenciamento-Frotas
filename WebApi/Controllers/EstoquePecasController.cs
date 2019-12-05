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
    [RoutePrefix("api/EstoquePecas")]
    public class EstoquePecasController : ApiController
    {
        private readonly EstoquePecasService _estoquePecasService;

        public EstoquePecasController()
        {
            Banco banco = new Banco();
            EstoquePecasDAL estoquePecasDAL = new EstoquePecasDAL(banco);
            _estoquePecasService = new EstoquePecasService(estoquePecasDAL);
        }
        public EstoquePecasController(EstoquePecasService estoquePecasService)
        {
            _estoquePecasService = estoquePecasService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(EstoquePeca estoquePeca, int idpeca)
        {
            try
            {
                return _estoquePecasService.Cadastrar(estoquePeca, idpeca);
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

        public EstoquePeca BuscarEstoquePecas(int idpeca)
        {
            try
            {
                return _estoquePecasService.BuscarEstoquePecas(idpeca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        public List<EstoquePeca> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _estoquePecasService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(int idpeca)
        {
            try
            {
                return _estoquePecasService.Deletar(idpeca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Alterar(EstoquePeca estoquePeca, int idpeca)
        {
            try
            {
                return _estoquePecasService.Alterar(estoquePeca, idpeca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }

        }

        public int PopulaID()
        {
            try
            {
                return _estoquePecasService.PopulaID();
            }
            catch
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<EstoquePeca> Pesquisar(string busca)
        {
            try
            {
                return _estoquePecasService.Pesquisar(busca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]

        // GET: api/EstoquePecas?id=VALOR
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var result = _estoquePecasService.BuscarEstoquePecas(id);
                if (result == null)
                {
                    return BadRequest("Estoque de Peças não encontrado!");
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

        // GET: api/EstoquePecas?pesquisa=VALOR
        public IHttpActionResult GetPesquisa(string pesquisa)
        {
            try
            {
                var result = _estoquePecasService.Pesquisar(pesquisa);
                if (result == null)
                {
                    return BadRequest("Estoques não encontrados!");
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

        //POST: api/EstoquePecas
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] EstoquePeca estoquePeca)
        {
            if (estoquePeca == null)
                return BadRequest();

            try
            {
                bool result = _estoquePecasService.Cadastrar(estoquePeca, estoquePeca.Id);
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
