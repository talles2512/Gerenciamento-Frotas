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
    [RoutePrefix("api/Cliente")]
    public class ClienteController : ApiController
    {
        private readonly ClienteService _clienteService;

        public ClienteController()
        {
            Banco banco = new Banco();
            ClienteDAL clienteDAL = new ClienteDAL(banco);
            _clienteService = new ClienteService(clienteDAL);
        }
        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(Cliente cliente, string cpf)
        {
            try
            {
                return _clienteService.Cadastrar(cliente, cpf);
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

        public Cliente BuscarCPF(string cpf)
        {
            try
            {
                return _clienteService.BuscarCPF(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Cliente> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _clienteService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string cpf)
        {
            try
            {
                return _clienteService.Deletar(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }

        }

        public bool Alterar(Cliente cliente, string cpf)
        {
            try
            {
                return _clienteService.Alterar(cliente, cpf);
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

        public List<Cliente> Pesquisar(string busca)
        {
            try
            {
                return _clienteService.Pesquisar(busca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]

        // GET: api/Cliente?cpf=VALOR
        [HttpGet]
        public IHttpActionResult Get(string cpf)
        {
            try
            {
                var result = _clienteService.BuscarCPF(cpf);
                if (result == null)
                {
                    return BadRequest("Cliente não encontrado!");
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

        // GET: api/Cliente?cpf=VALOR&nome=VALOR
        [HttpGet]
        public IHttpActionResult Get(string cpf, string nome) //Testando multiparametrização
        {
            try
            {
                var result = _clienteService.BuscarCPF(cpf);
                if (result == null)
                {
                    return BadRequest("Cliente não encontrado!");
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

        // GET: api/Cliente?pesquisa=VALOR
        [HttpGet]
        public IHttpActionResult GetPesquisa(string pesquisa)
        {
            try
            {
                var result = _clienteService.Pesquisar(pesquisa);
                if (result == null)
                {
                    return BadRequest("Cliente não encontrado!");
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

        //POST: api/Cliente
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Cliente cliente)
        {
            if (cliente == null)
                return BadRequest();

            try
            {
                bool result = _clienteService.Cadastrar(cliente, cliente.CPF);
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
