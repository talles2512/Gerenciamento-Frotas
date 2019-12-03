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
    [RoutePrefix("api/Viagem")]
    public class ViagemController : ApiController
    {
        private readonly ViagemService _viagemService;
        private readonly MotoristaDAL _motoristaDAL;
        private readonly VeiculoDAL _veiculoDAL;

        public ViagemController()
        {
            Banco banco = new Banco();
            ViagemDAL viagemDAL = new ViagemDAL(banco);
            OcupanteDAL ocupanteDAL = new OcupanteDAL(banco);
            _viagemService = new ViagemService(viagemDAL, ocupanteDAL);

            _motoristaDAL = new MotoristaDAL(banco);
            _veiculoDAL = new VeiculoDAL(banco);

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

        // GET: api/Viagem?pesquisa=VALOR
        [HttpGet]
        public IHttpActionResult GetPesquisa(string pesquisa)
        {
            try
            {
                var result = _viagemService.Pesquisar(pesquisa);
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

        // GET: api/Viagem?cpfs=VALOR
        [HttpGet]
        public IHttpActionResult GetMotoristas(string cpfs)
        {
            try
            {
                var result = _viagemService.PopularCPFs();
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

        // GET: api/Viagem?placas=VALOR
        [HttpGet]
        public IHttpActionResult GetVeiculos(string placas)
        {
            try
            {
                var result = _viagemService.PopularPlacas();
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

        //POST: api/Viagem
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Viagem viagem)
        {
            if (viagem == null)
                return BadRequest();

            Motorista motorista = _motoristaDAL.BuscarCPF(viagem.CPF);
            if (motorista == null)
            {
                return BadRequest();
            }

            Veiculo veiculo = _veiculoDAL.BuscarPlaca(viagem.Placa);
            if(veiculo == null)
            {
                veiculo = _veiculoDAL.BuscarPlacaAlugado(viagem.Placa);

                if(veiculo == null)
                {
                    return BadRequest();
                }
            }

            try
            {
                int requisicao = _viagemService.PopularRequisicao();
                viagem.Requisicao = requisicao;
                viagem.Ocupante = false;

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

        //POST: api/Viagem
        [HttpPost]
        [Route("add/Ocupantes")]
        public IHttpActionResult Post([FromBody] List<Ocupante> ocupantes)
        {
            if (ocupantes == null)
                return BadRequest();

            try
            {
                int requisicao = (_viagemService.PopularRequisicao()-1);
                foreach (Ocupante ocupante in ocupantes)
                {
                    ocupante.Requisicao = requisicao;
                }

                Viagem viagem = _viagemService.BuscarViagem(requisicao);
                viagem.Ocupantes = ocupantes;
                viagem.Ocupante = true;

                bool result = _viagemService.Alterar(viagem, requisicao);
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
