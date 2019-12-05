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
    [RoutePrefix("api/Seguro")]
    public class SeguroController : ApiController
    {
        private readonly SeguroService _seguroService;

        public SeguroController()
        {
            Banco banco = new Banco();
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            _seguroService = new SeguroService(seguroDAL);
        }
        public SeguroController(SeguroService seguroService)
        {
            _seguroService = seguroService;
        }

        #region [AplicacaoDesktop]

        public bool Cadastrar(Seguro seguro, TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                return _seguroService.Cadastrar(seguro, tipo, numeroApolice);
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

        public Seguro BuscarSeguro(TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                return _seguroService.BuscarSeguro(tipo, numeroApolice);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Seguro> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _seguroService.BuscarTodos(dtinicio, dtfim);
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
                return _seguroService.Deletar(tipo, numeroApolice);
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

        public bool Alterar(Seguro seguro, TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                return _seguroService.Alterar(seguro, tipo, numeroApolice);
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
                return _seguroService.PopularPlacas();
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
                return _seguroService.PopularCPFs();
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
                return _seguroService.PopularServicosExternos();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Seguro> Pesquisar(string busca)
        {
            try
            {
                return _seguroService.Pesquisar(busca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]

        // GET: api/Seguro?tipo=VALOR&apolice=VALOR
        [HttpGet]
        public IHttpActionResult Get(TipoSeguro tipo, long apolice)
        {
            try
            {
                var result = _seguroService.BuscarSeguro(tipo, apolice);
                if (result == null)
                {
                    return BadRequest("Seguro não encontrado!");
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

        // GET: api/Seguro?pesquisa=VALOR
        [HttpGet]
        public IHttpActionResult GetPesquisa(string pesquisa)
        {
            try
            {
                var result = _seguroService.Pesquisar(pesquisa);
                if (result == null)
                {
                    return BadRequest("Seguro não encontrado!");
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

        // GET: api/Seguro?cnpjs=VALOR
        [HttpGet]
        public IHttpActionResult GetSeguradoras(string cnpjs)
        {
            try
            {
                var result = _seguroService.PopularServicosExternos();
                if (result == null)
                {
                    return BadRequest("Seguradoras não encontradas!");
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

        // GET: api/Seguro?cpfs=VALOR
        [HttpGet]
        public IHttpActionResult GetMotoristas(string cpfs)
        {
            try
            {
                var result = _seguroService.PopularCPFs();
                if (result == null)
                {
                    return BadRequest("Motoristas não encontrados!");
                }
                else
                {
                    DataRow[] dataRows = result.Select();
                    List<string> CPFs = new List<string>();
                    foreach (DataRow dr in dataRows)
                    {
                        CPFs.Add(dr["MOTORISTA"].ToString());
                    }

                    return Ok(CPFs);
                }
            }
            catch (ConcorrenciaBancoException)
            {
                return BadRequest("Favor tentar novamente mais tarde.");
            }
        }

        // GET: api/Seguro?placas=VALOR
        [HttpGet]
        public IHttpActionResult GetVeiculos(string placas)
        {
            try
            {
                var result = _seguroService.PopularPlacas();
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

        //POST: api/Seguro
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Seguro seguro)
        {
            if (seguro == null)
                return BadRequest();

            try
            {
                bool result = _seguroService.Cadastrar(seguro, seguro.Tipo, seguro.NumeroApolice);
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
