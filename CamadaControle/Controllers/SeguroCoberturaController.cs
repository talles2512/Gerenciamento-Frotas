using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    public class SeguroCoberturaController
    {
        private readonly SeguroCoberturaService _seguroCoberturaService;

        public SeguroCoberturaController(SeguroCoberturaService seguroCoberturaService)
        {
            _seguroCoberturaService = seguroCoberturaService;
        }

        #region [AplicacaoDesktop]

        public bool Cadastrar(SeguroCobertura seguroCobertura)
        {
            try
            {
                return _seguroCoberturaService.Cadastrar(seguroCobertura);
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

        public SeguroCobertura BuscarSeguroCobertura(TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                return _seguroCoberturaService.BuscarSeguroCobertura(tipo, numeroApolice);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<SeguroCobertura> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _seguroCoberturaService.BuscarTodos(dtinicio, dtfim);
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
                return _seguroCoberturaService.Deletar(tipo, numeroApolice);
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

        public bool Alterar(SeguroCobertura seguroCobertura, TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                return _seguroCoberturaService.Alterar(seguroCobertura, tipo, numeroApolice);
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

        public DataTable PopularSeguros(TipoSeguro tipo)
        {
            try
            {
                return _seguroCoberturaService.PopularSeguros(tipo);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
