using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Services
{
    public class SeguroCoberturaService
    {
        private readonly SeguroCoberturaDAL _seguroCoberturaDAL;

        public SeguroCoberturaService(SeguroCoberturaDAL seguroCoberturaDAL)
        {
            _seguroCoberturaDAL = seguroCoberturaDAL;
        }
        public bool Cadastrar(SeguroCobertura seguroCobertura) //Mudança na Query, Verificar
        {
            try
            {
                SeguroCobertura obj = _seguroCoberturaDAL.BuscarSeguroCobertura(seguroCobertura.Tipo, seguroCobertura.NumeroApolice);
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um Seguro com esses dados no sistema!");
                }

                return _seguroCoberturaDAL.Cadastrar(seguroCobertura);
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
                return _seguroCoberturaDAL.BuscarSeguroCobertura(tipo, numeroApolice);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<SeguroCobertura> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<SeguroCobertura> segurosCoberturas = new List<SeguroCobertura>();
            try
            {
                segurosCoberturas.AddRange(_seguroCoberturaDAL.BuscarTodos(dtinicio, dtfim));
                return segurosCoberturas;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                if (_seguroCoberturaDAL.Deletar(tipo, numeroApolice))
                {
                    return true;
                }
                else
                {
                    throw new IntegridadeException("Cobertura não pode ser deletada, pois ainda está vinculada à outros serviços.");
                }
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
                SeguroCobertura obj = _seguroCoberturaDAL.BuscarSeguroCobertura(tipo, numeroApolice);
                if (obj != null)
                {
                    return _seguroCoberturaDAL.Alterar(seguroCobertura, tipo, numeroApolice);
                }
                else
                {
                    throw new NaoEncontradoException("Cobertura de seguro não encontrada.");
                }
            }
            catch (TransacaoException e)
            {
                throw new TransacaoException(e.Message);
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
                return _seguroCoberturaDAL.PopularSeguros(tipo);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
