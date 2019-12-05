using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Motorista")]
    public class MotoristaController : ApiController
    {
        private readonly MotoristaService _motoristaService;


        public MotoristaController()
        {
            Banco banco = new Banco();
            MotoristaDAL motoristaDAL = new MotoristaDAL(banco);
            EntradaSaidaDAL entradaSaidaDAL = new EntradaSaidaDAL(banco);
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            _motoristaService = new MotoristaService(motoristaDAL, entradaSaidaDAL, seguroDAL);
        }
        public MotoristaController(MotoristaService motoristaService)
        {
            _motoristaService = motoristaService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(Motorista motorista, CNH cnh)
        {
            try
            {
                return _motoristaService.Cadastrar(motorista, cnh);
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

        public Motorista BuscarCPF(string cpf)
        {
            try
            {
                return _motoristaService.BuscarCPF(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Motorista> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _motoristaService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Inativar(string cpf, bool sit)
        {
            try
            {
                return _motoristaService.Inativar(cpf, sit);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Motorista motorista, CNH cnh, string cpf)
        {
            try
            {
                return _motoristaService.Alterar(motorista, cnh, cpf);
            }
            catch (NaoEncontradoException e)
            {
                throw new NaoEncontradoException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
            catch (IntegridadeException e)
            {
                throw new IntegridadeException(e.Message);
            }
        }

        public List<Motorista> Pesquisar(string busca)
        {
            try
            {
                return _motoristaService.Pesquisar(busca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        #endregion

        #region [AplicacaoWeb]
        // GET: api/Motorista?cpf=VALOR
        [HttpGet]
        public IHttpActionResult Get(string cpf)
        {
            try
            {
                var result = _motoristaService.BuscarCPF(cpf);
                if (result == null)
                {
                    return BadRequest("Motorista não encontrado!");
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

        // GET: api/Motorista?pesquisa=VALOR
        [HttpGet]
        public IHttpActionResult GetPesquisa(string pesquisa)
        {
            try
            {
                var result = _motoristaService.Pesquisar(pesquisa);
                if (result == null)
                {
                    return BadRequest("Motorista não encontrado!");
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

        //POST: api/Motorista
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Motorista motorista)
        {
            if (motorista == null)
                return BadRequest();

            try
            {
                motorista.Situacao = true;
                bool result = _motoristaService.Cadastrar(motorista, motorista.CNH);
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

        //// PUT: api/Veiculos/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Veiculos/5
        //public void Delete(int id)
        //{
        //}


        #endregion
    }
}
