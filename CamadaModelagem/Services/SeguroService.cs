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
    public class SeguroService
    {
        private readonly SeguroDAL _seguroDAL;

        public SeguroService(SeguroDAL seguroDAL)
        {
            _seguroDAL = seguroDAL;
        }
        public void Cadastrar(Seguro seguro) //Mudança na Query, Verificar
        {
            //try
            //{
            //    Seguro obj = _seguroDAL.BuscarApolice(seguro.NumeroApolice); //Falta criar os métodos de busca
            //    if (obj != null)
            //    {
            //        throw new RegistroExisteException("Já existe um Seguro com esses dados no sistema!");
            //    }
            //    _seguroDAL.Cadastrar(seguro);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }

        public void Deletar(int numApolice)
        {
            try
            {
                _seguroDAL.Deletar(numApolice);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Seguro não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Seguro seguro, int numApolice)
        {
            //try
            //{
            //    Seguro obj = _seguroDAL.BuscarApolice(numApolice); //Falta criar os métodos de busca
            //    if (obj == null)
            //    {
            //        throw new NaoEncontradoException("Seguro não encontrado.");
            //    }
            //    _seguroDAL.Alterar(seguro, numApolice);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }
    }
}
