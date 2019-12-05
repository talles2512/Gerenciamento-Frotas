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
    [RoutePrefix("api/ServicoExterno")]
    public class ServicoExternoController : ApiController
    {
        private readonly ServicoExternoService _servicoExternoService;

        public ServicoExternoController()
        {
            Banco banco = new Banco();
            ServicoExternoDAL servicoExternoDAL = new ServicoExternoDAL(banco);
            ManutencaoDAL manutencaoDAL = new ManutencaoDAL(banco);
            AbastecimentoDAL abastecimentoDAL = new AbastecimentoDAL(banco);
            EntradaSaidaDAL entradaSaidaDAL = new EntradaSaidaDAL(banco);
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            _servicoExternoService = new ServicoExternoService(servicoExternoDAL, manutencaoDAL, abastecimentoDAL, entradaSaidaDAL, seguroDAL);
        }
        public ServicoExternoController(ServicoExternoService servicoExternoService)
        {
            _servicoExternoService = servicoExternoService;
        }

        #region [AplicacaoDesktop]

        public bool Cadastrar(ServicoExterno servicoExterno, long cnpj)
        {
            try
            {
                return _servicoExternoService.Cadastrar(servicoExterno, cnpj); ;
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

        public ServicoExterno BuscarCNPJ(long cnpj)
        {
            try
            {
                return _servicoExternoService.BuscarCNPJ(cnpj);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<ServicoExterno> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _servicoExternoService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(long cnpj)
        {
            try
            {
                return _servicoExternoService.Deletar(cnpj);
            }
            catch (IntegridadeException e)
            {
                throw new IntegridadeException(e.Message);
            }
            catch (TransacaoException e)
            {
                throw new TransacaoException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(ServicoExterno servicoExterno, long cnpj, TipoServicoExterno tipo)
        {
            try
            {
                return _servicoExternoService.Alterar(servicoExterno, cnpj, tipo);
            }
            catch (NaoEncontradoException e)
            {
                throw new NaoEncontradoException(e.Message);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
            catch (TransacaoException e)
            {
                throw new TransacaoException(e.Message);
            }
            catch (IntegridadeException e)
            {
                throw new IntegridadeException(e.Message);
            }
        }

        public List<ServicoExterno> Pesquisar(string busca)
        {
            try
            {
                return _servicoExternoService.Pesquisar(busca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        #endregion

        #region [AplicacaoWeb]

        // GET: api/ServicoExterno?cnpj=VALOR
        [HttpGet]
        public IHttpActionResult Get(long cnpj)
        {
            try
            {
                var result = _servicoExternoService.BuscarCNPJ(cnpj);
                if (result == null)
                {
                    return BadRequest("Serviço Externo não encontrado!");
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

        // GET: api/ServicoExterno?cnpj=VALOR
        [HttpGet]
        public IHttpActionResult GetPesquisa(string pesquisa)
        {
            try
            {
                var result = _servicoExternoService.Pesquisar(pesquisa);
                if (result == null)
                {
                    return BadRequest("Serviços Externos não encontrados!");
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

        //POST: api/ServicoExterno
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] ServicoExterno servicoExterno)
        {
            if (servicoExterno == null)
                return BadRequest();

            try
            {
                if (!servicoExterno.Conveniado)
                {
                    servicoExterno.ServicoExternoConveniado = null;
                }
                bool result = _servicoExternoService.Cadastrar(servicoExterno, servicoExterno.CNPJ);
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
