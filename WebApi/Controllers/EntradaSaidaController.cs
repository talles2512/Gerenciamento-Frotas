﻿using CamadaModelagem.Data;
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
    [RoutePrefix("api/EntradaSaida")]
    public class EntradaSaidaController : ApiController
    {
        private readonly EntradaSaidaService _entradaSaidaService;

        public EntradaSaidaController()
        {
            Banco banco = new Banco();
            EntradaSaidaDAL entradaSaidaDAL = new EntradaSaidaDAL(banco);
            _entradaSaidaService = new EntradaSaidaService(entradaSaidaDAL);
        }
        public EntradaSaidaController(EntradaSaidaService entradaSaidaService)
        {
            _entradaSaidaService = entradaSaidaService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(EntradaSaida entradaSaida, string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data) //Mudança na Query, Verificar
        {
            try
            {
                return _entradaSaidaService.Cadastrar(entradaSaida, placa, cnpj, tipo, data);
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

        public EntradaSaida BuscarEntradaSaida(string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data)
        {
            try
            {
                return _entradaSaidaService.BuscarEntradaSaida(placa, cnpj, tipo, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<EntradaSaida> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _entradaSaidaService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data)
        {
            try
            {
                return _entradaSaidaService.Deletar(placa, cnpj, tipo, data);
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

        public bool Alterar(EntradaSaida entradaSaida, string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data)
        {
            try
            {
                return _entradaSaidaService.Alterar(entradaSaida, placa, cnpj, tipo, data);
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

        public DataTable PopularCPFs()
        {
            try
            {
                return _entradaSaidaService.PopularCPFs();
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
                return _entradaSaidaService.PopularPlacas();
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
                return _entradaSaidaService.PopularServicosExternos();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]

        // GET: api/EntradaSaida?placa=VALOR&cnpj=VALOR&tipo=VALOR&data=VALOR
        [HttpGet]
        public IHttpActionResult Get(string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data)
        {
            try
            {
                var result = _entradaSaidaService.BuscarEntradaSaida(placa, cnpj, tipo, data);
                if (result == null)
                {
                    return BadRequest("Entrada ou Saída não encontrada!");
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

        //POST: api/EntradaSaida
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] EntradaSaida entradaSaida)
        {
            if (entradaSaida == null)
                return BadRequest();

            try
            {
                bool result = _entradaSaidaService.Cadastrar(entradaSaida, entradaSaida.Placa, entradaSaida.CNPJ, entradaSaida.Tipo, entradaSaida.DataHora);
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
