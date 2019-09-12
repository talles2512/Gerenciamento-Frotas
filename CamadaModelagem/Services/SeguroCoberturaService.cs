using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data;
using CamadaModelagem.Models;
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
        public void Cadastrar(SeguroCobertura seguroCobertura) //Mudança na Query, Verificar
        {
            //try
            //{
            //    SeguroCobertura obj = _seguroCoberturaDAL.BuscarId(seguroCobertura.Id); //Falta criar os métodos de busca
            //    if (obj != null)
            //    {
            //        throw new RegistroExisteException("Já existe uma Cobertura com essa Identificação no sistema!");
            //    }
            //    _seguroCoberturaDAL.Cadastrar(seguroCobertura);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }

        public void Deletar(int id)
        {
            try
            {
                _seguroCoberturaDAL.Deletar(id);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Cobertura não pode ser deletada, pois está ligada a outros serviços.");
            }
        }

        public void Alterar(SeguroCobertura seguroCobertura, int id)
        {
            //try
            //{
            //    SeguroCobertura obj = _seguroCoberturaDAL.BuscarId(id);
            //    if (obj == null)
            //    {
            //        throw new NaoEncontradoException("Cobertura não encontrada.");
            //    }
            //    _seguroCoberturaDAL.Alterar(seguroCobertura, id);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }
    }
}
