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
    [RoutePrefix("api/Manutencao")]
    public class ManutencaoController : ApiController
    {
        private readonly ManutencaoService _manutencaoService;

        public ManutencaoController()
        {
            Banco banco = new Banco();
            ManutencaoDAL manutencaoDAL = new ManutencaoDAL(banco);
            _manutencaoService = new ManutencaoService(manutencaoDAL);
        }
        public ManutencaoController(ManutencaoService manutencaoService)
        {
            _manutencaoService = manutencaoService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(Manutencao manutencao, string placa, ManutencaoTipo tipo, DateTime data)
        {
            try
            {
                return _manutencaoService.Cadastrar(manutencao, placa, tipo, data);
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

        public Manutencao BuscarManutencao(string placa, ManutencaoTipo tipo, DateTime data)
        {
            try
            {
                return _manutencaoService.BuscarManutencao(placa, tipo, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Manutencao> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _manutencaoService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string placa, ManutencaoTipo tipo, DateTime data)
        {
            try
            {
                return _manutencaoService.Deletar(placa, tipo, data);
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

        public bool Alterar(Manutencao manutencao, string placa, ManutencaoTipo tipo, DateTime data)
        {
            try
            {
                return _manutencaoService.Alterar(manutencao, placa, tipo, data);
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
                return _manutencaoService.PopularPlacas();
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
                return _manutencaoService.PopularServicosExternos();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        #endregion

        #region [AplicacaoWeb]

        // GET: api/Manutencao?placa=VALOR&tipo=VALOR&data=VALOR
        [HttpGet]
        public IHttpActionResult Get(string placa, ManutencaoTipo tipo, DateTime data)
        {
            try
            {
                var result = _manutencaoService.BuscarManutencao(placa, tipo, data);
                if (result == null)
                {
                    return BadRequest("Manutenção não encontrada!");
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

        // GET: api/Manutencao?cnpjs=VALOR
        [HttpGet]
        public IHttpActionResult GetOficinas(string cnpjs)
        {
            try
            {
                var result = _manutencaoService.PopularServicosExternos();
                if (result == null)
                {
                    return BadRequest("Oficinas não encontradas!");
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

        // GET: api/Manutencao?placas=VALOR
        [HttpGet]
        public IHttpActionResult GetVeiculos(string placas)
        {
            try
            {
                var result = _manutencaoService.PopularPlacas();
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

        //POST: api/Manutencao
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Manutencao manutencao)
        {
            if (manutencao == null)
                return BadRequest();

            try
            {
                bool result = _manutencaoService.Cadastrar(manutencao, manutencao.Placa, manutencao.Tipo, manutencao.Data);
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
