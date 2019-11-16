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

namespace WebApi.Controllers
{
    [RoutePrefix("api/Viagem")]
    public class ViagemController : ApiController
    {
        private readonly ViagemService _viagemService;

        public ViagemController()
        {
            Banco banco = new Banco();
            ViagemDAL viagemDAL = new ViagemDAL(banco);
            OcupanteDAL ocupanteDAL = new OcupanteDAL(banco);
            _viagemService = new ViagemService(viagemDAL, ocupanteDAL);
        }
        public ViagemController(ViagemService viagemService)
        {
            _viagemService = viagemService;
        }

        #region [AplicacaoDesktop]

        public bool Cadastrar(Viagem viagem, int requisicao)
        {
            try
            {
                return _viagemService.Cadastrar(viagem, requisicao);
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

        public Viagem BuscarViagem(int requisicao)
        {
            try
            {
                return _viagemService.BuscarViagem(requisicao);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Viagem> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _viagemService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(int requisicao)
        {
            try
            {
                return _viagemService.Deletar(requisicao);
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

        public bool Alterar(Viagem viagem, int requisicao)
        {
            try
            {
                return _viagemService.Alterar(viagem, requisicao);
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

        public int PopularRequisicao()
        {
            try
            {
                return _viagemService.PopularRequisicao();
            }
            catch
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public DataTable PopularCPFs()
        {
            try
            {
                return _viagemService.PopularCPFs();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        public DataTable PopularPlacas()
        {
            try
            {
                return _viagemService.PopularPlacas();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Viagem> Pesquisar(string busca)
        {
            try
            {
                return _viagemService.Pesquisar(busca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]

        // GET: api/Viagem?requisicao=VALOR
        [HttpGet]
        public IHttpActionResult Get(int requisicao)
        {
            try
            {
                var result = _viagemService.BuscarViagem(requisicao);
                if (result == null)
                {
                    return BadRequest("Viagem não encontrada!");
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

        //POST: api/Viagem
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Viagem viagem)
        {
            if (viagem == null)
                return BadRequest();

            try
            {
                bool result = _viagemService.Cadastrar(viagem, viagem.Requisicao);
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
