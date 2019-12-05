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
    [RoutePrefix("api/Abastecimento")]
    public class AbastecimentoController : ApiController
    {
        private readonly AbastecimentoService _abastecimentoService;

        public AbastecimentoController()
        {
            Banco banco = new Banco();
            AbastecimentoDAL abastecimentoDAL = new AbastecimentoDAL(banco);
            VeiculoDAL veiculoDAL = new VeiculoDAL(banco);
            _abastecimentoService = new AbastecimentoService(abastecimentoDAL, veiculoDAL);
        }
        public AbastecimentoController(AbastecimentoService abastecimentoService)
        {
            _abastecimentoService = abastecimentoService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(Abastecimento abastecimento, string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                return _abastecimentoService.Cadastrar(abastecimento, placa, tipo, data);
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

        public Abastecimento BuscarAbastecimento(string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                return _abastecimentoService.BuscarAbastecimento(placa, tipo, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Abastecimento> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _abastecimentoService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                return _abastecimentoService.Deletar(placa, tipo, data);
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

        public bool Alterar(Abastecimento abastecimento, string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                return _abastecimentoService.Alterar(abastecimento, placa, tipo, data);
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

        public DataTable PopularPlacas()
        {
            try
            {
                return _abastecimentoService.PopularPlacas();
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
                return _abastecimentoService.PopularServicosExternos();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]

        // GET: api/Abastecimento?placa=VALOR&tipo=VALOR&data=VALOR
        [HttpGet]
        public IHttpActionResult Get(string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                var result = _abastecimentoService.BuscarAbastecimento(placa, tipo, data);
                if (result == null)
                {
                    return BadRequest("Abastecimento não encontrado!");
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

        // GET: api/Abastecimento?cnpjs=VALOR
        [HttpGet]
        public IHttpActionResult GetPostos(string cnpjs)
        {
            try
            {
                var result = _abastecimentoService.PopularServicosExternos();
                if (result == null)
                {
                    return BadRequest("Postos não encontrados!");
                }
                else
                {
                    DataRow[] dataRows = result.Select();
                    List<string> CNPJs = new List<string>();
                    foreach (DataRow dr in dataRows)
                    {
                        CNPJs.Add(dr["SERVEXT_NOME"].ToString() + "-" + dr["SERVEXT_CNPJ"].ToString());
                    }

                    return Ok(CNPJs);
                }
            }
            catch (ConcorrenciaBancoException)
            {
                return BadRequest("Favor tentar novamente mais tarde.");
            }
        }

        // GET: api/Abastecimento?placas=VALOR
        [HttpGet]
        public IHttpActionResult GetVeiculos(string placas)
        {
            try
            {
                var result = _abastecimentoService.PopularPlacas();
                if (result == null)
                {
                    return BadRequest("Veiculos não encontrados!");
                }
                else
                {
                    DataRow[] dataRows = result.Select();
                    List<string> Placas = new List<string>();
                    foreach (DataRow dr in dataRows)
                    {
                        Placas.Add(dr["MODELO"].ToString());
                    }

                    return Ok(Placas);
                }
            }
            catch (ConcorrenciaBancoException)
            {
                return BadRequest("Favor tentar novamente mais tarde.");
            }
        }

        //POST: api/Abastecimento
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Abastecimento abastecimento)
        {
            if (abastecimento == null)
                return BadRequest();

            try
            {
                bool result = _abastecimentoService.Cadastrar(abastecimento, abastecimento.Placa, abastecimento.Tipo, abastecimento.Data);
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
            catch (TipoCombustivelException)
            {
                HttpResponseMessage message = new HttpResponseMessage(HttpStatusCode.NotAcceptable);
                return ResponseMessage(message);
            }

        }
        #endregion
    }
}
