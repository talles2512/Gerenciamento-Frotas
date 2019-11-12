using CamadaModelagem.Models;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Instancia;

namespace WebApi.Controllers
{
    [RoutePrefix("api/motoristas")]
    public class MotoristaController : ApiController
    {
        #region [AplicacaoWeb]
        // GET: api/Motoristas/5
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            InstanciaMotorista instanciaMotorista = new InstanciaMotorista();
            try
            {
                var result = instanciaMotorista._motoristaService.BuscarCPF(id);
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

        //POST: api/Motoristas
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Motorista motorista)
        {
            if (motorista == null)
                return BadRequest();

            try
            {
                InstanciaMotorista instanciaMotorista = new InstanciaMotorista();
                bool result = instanciaMotorista._motoristaService.Cadastrar(motorista, motorista.CNH);
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
