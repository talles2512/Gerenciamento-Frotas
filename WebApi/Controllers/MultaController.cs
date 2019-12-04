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
    [RoutePrefix("api/Multa")]
    public class MultaController : ApiController
    {
        private readonly MultaService _multaService;


        public MultaController()
        {
            Banco banco = new Banco();
            MultaDAL multaDAL = new MultaDAL(banco);
            _multaService = new MultaService(multaDAL);
        }
        public MultaController(MultaService multaService)
        {
            _multaService = multaService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(Multa multa)
        {
            try
            {
                return _multaService.Cadastrar(multa);
            }
            catch (RegistroExisteException e)
            {
                throw new RegistroExisteException(e.Message);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public Multa BuscarMulta(string placa, string cpf, DateTime dataocorrencia)
        {
            try
            {
                return _multaService.BuscarMulta(placa, cpf, dataocorrencia);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Multa> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _multaService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string placa, string cpf, DateTime data)
        {
            try
            {
                return _multaService.Deletar(placa, cpf, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }

        }

        public bool Alterar(Multa multa, string placa, string cpf, DateTime data)
        {
            try
            {
                return _multaService.Alterar(multa, placa, cpf, data);
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
                return _multaService.PopularPlacas();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public DataTable PopularCPF()
        {
            try
            {
                return _multaService.PopularCPF();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public Veiculo BuscarPlaca(string placa)
        {
            try
            {
                return _multaService.BuscarPlaca(placa);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public Motorista BuscarCPF(string cpf)
        {
            try
            {
                return _multaService.BuscarCPF(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]

        // GET: api/Multa?placa=VALOR&cpf=VALOR&data=VALOR
        [HttpGet]
        public IHttpActionResult Get(string placa, string cpf, DateTime data)
        {
            try
            {
                var result = _multaService.BuscarMulta(placa, cpf, data);
                if (result == null)
                {
                    return BadRequest("Multa não encontrada!");
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

        // GET: api/Multa?pesquisa=VALOR
        //[HttpGet]
        //public IHttpActionResult GetPesquisa(string pesquisa)
        //{
        //    try
        //    {
        //        var result = _multaService.Pesquisar(pesquisa);
        //        if (result == null)
        //        {
        //            return BadRequest("Multa não encontrada!");
        //        }
        //        else
        //        {
        //            return Ok(result);
        //        }
        //    }
        //    catch (ConcorrenciaBancoException)
        //    {
        //        return BadRequest("Favor tentar novamente mais tarde.");
        //    }
        //}

        // GET: api/Multa?cpfs=VALOR
        [HttpGet]
        public IHttpActionResult GetMotoristas(string cpfs)
        {
            try
            {
                var result = _multaService.PopularCPF();
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
                        CPFs.Add(dr["NOMECPF"].ToString());
                    }

                    return Ok(CPFs);
                }
            }
            catch (ConcorrenciaBancoException)
            {
                return BadRequest("Favor tentar novamente mais tarde.");
            }
        }

        // GET: api/Multa?placas=VALOR
        [HttpGet]
        public IHttpActionResult GetVeiculos(string placas)
        {
            try
            {
                var result = _multaService.PopularPlacas();
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

        //POST: api/Multa
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Multa multa)
        {
            if (multa == null)
                return BadRequest();

            try
            {
                bool result = _multaService.Cadastrar(multa);
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
