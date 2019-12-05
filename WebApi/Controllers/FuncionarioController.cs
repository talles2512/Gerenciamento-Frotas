using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
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
    [RoutePrefix("api/Funcionario")]
    public class FuncionarioController : ApiController
    {
        private readonly FuncionarioService _funcionarioService;

        public FuncionarioController()
        {
            Banco banco = new Banco();
            FuncionarioDAL funcionarioDAL = new FuncionarioDAL(banco);
            _funcionarioService = new FuncionarioService(funcionarioDAL);
        }
        public FuncionarioController(FuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(Funcionario funcionario, string login)
        {
            try
            {
                return _funcionarioService.Cadastrar(funcionario, login);
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

        public Funcionario BuscarCPF(string login)
        {
            try
            {
                return _funcionarioService.BuscarCPF(login);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Funcionario> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _funcionarioService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string login)
        {
            try
            {
                return _funcionarioService.Deletar(login);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Alterar(Funcionario funcionario, string login)
        {
            try
            {
                return _funcionarioService.Alterar(funcionario, login);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }

        }

        public List<Funcionario> Pesquisar(string busca)
        {
            try
            {
                return _funcionarioService.Pesquisar(busca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]

        // GET: api/Funcionario?login=VALOR
        [HttpGet]
        public IHttpActionResult Get(string login)
        {
            try
            {
                var result = _funcionarioService.BuscarCPF(login);
                if (result == null)
                {
                    return BadRequest("Funcionário não encontrado!");
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

        // GET: api/Funcionario?pesquisa=VALOR
        public IHttpActionResult GetPesquisa(string pesquisa)
        {
            try
            {
                var result = _funcionarioService.Pesquisar(pesquisa);
                if (result == null)
                {
                    return BadRequest("Funcionários não encontrados!");
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

        //POST: api/Funcionario
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Funcionario funcionario)
        {
            if (funcionario == null)
                return BadRequest();

            try
            {
                bool result = _funcionarioService.Cadastrar(funcionario, funcionario.Login);
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
