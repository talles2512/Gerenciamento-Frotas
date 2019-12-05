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
    [RoutePrefix("api/ExameMedico")]
    public class ExameMedicoController : ApiController
    {
        private readonly ExameMedicoService _exameMedicoService;

        public ExameMedicoController()
        {
            Banco banco = new Banco();
            ExameMedicoDAL exameMedicoDAL = new ExameMedicoDAL(banco);
            _exameMedicoService = new ExameMedicoService(exameMedicoDAL);
        }
        public ExameMedicoController(ExameMedicoService exameMedicoService)
        {
            _exameMedicoService = exameMedicoService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(ExameMedico exameMedico) //Mudança na Query, Verificar
        {
            try
            {
                return _exameMedicoService.Cadastrar(exameMedico);
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

        public ExameMedico BuscarExameMedico(string cpf, DateTime data)
        {
            try
            {
                return _exameMedicoService.BuscarExameMedico(cpf, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<ExameMedico> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _exameMedicoService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string cpf, DateTime data)
        {
            try
            {
                return _exameMedicoService.Deletar(cpf, data);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }

        }

        public bool Alterar(ExameMedico exameMedico, string cpf, DateTime data)
        {
            try
            {
                return _exameMedicoService.Alterar(exameMedico, cpf, data);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        #endregion

        #region [AplicacaoWeb]

        // GET: api/ExameMedico?cpf=VALOR&data=VALOR
        [HttpGet]
        public IHttpActionResult Get(string cpf, DateTime data)
        {
            try
            {
                var result = _exameMedicoService.BuscarExameMedico(cpf, data);
                if (result == null)
                {
                    return BadRequest("Exame Médico não encontrado!");
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

        //POST: api/ExameMedico
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] ExameMedico exameMedico)
        {
            if (exameMedico == null)
                return BadRequest();

            try
            {
                bool result = _exameMedicoService.Cadastrar(exameMedico);
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
