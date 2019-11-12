using System.Web.Http;
using System.Linq;
using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;
using System.Collections.Generic;
using System;
using CamadaControle.Instancia;

namespace WebApi.Controllerss
{

    [RoutePrefix("api/veiculo")]
    public class VeiculoController : ApiController
    {

        private readonly VeiculoService _veiculoService;

        public VeiculoController()
        {

        }
        public VeiculoController(VeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        #region [AplicacaoDesktop]

        public bool Cadastrar(Veiculo veiculo, string placa)
        {
            try
            {
                return _veiculoService.Cadastrar(veiculo, placa);
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

        public Veiculo BuscarPlaca(string placa)
        {
            try
            {
                return _veiculoService.BuscarPlaca(placa);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Veiculo> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _veiculoService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Inativar(string placa)
        {
            try
            {
                return _veiculoService.Inativar(placa);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Veiculo veiculo, string placa)
        {
            try
            {
                return _veiculoService.Alterar(veiculo, placa);
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

        public List<Veiculo> Pesquisar(string busca)
        {
            try
            {
                return _veiculoService.Pesquisar(busca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        #endregion

        #region [AplicacaoWeb]
        // GET: api/Veiculo?placa=VALOR
        [HttpGet]
        public IHttpActionResult Get(string placa)
        {
            InstanciaVeiculo instanciaVeiculo = new InstanciaVeiculo();
            try
            {
                var result = instanciaVeiculo._veiculoService.BuscarPlaca(placa);
                if (result == null)
                {
                    return BadRequest("Veículo não encontrado!");
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

        // GET: api/Veiculo?placa=VALOR&modelo=VALOR
        [HttpGet]
        public IHttpActionResult Get(string placa, string modelo)
        {
            InstanciaVeiculo instanciaVeiculo = new InstanciaVeiculo();
            try
            {
                var result = instanciaVeiculo._veiculoService.BuscarPlaca(placa);
                if (result == null)
                {
                    return BadRequest("Veículo não encontrado!");
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

        //POST: api/veiculo
        [HttpPost]
       [Route("add")]
        public IHttpActionResult Post([FromBody] Veiculo veiculo)
        {
            if (veiculo == null)
                return BadRequest();

            try
            {
                InstanciaVeiculo instanciaVeiculo = new InstanciaVeiculo();
                bool result = instanciaVeiculo._veiculoService.Cadastrar(veiculo, veiculo.Placa);
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
