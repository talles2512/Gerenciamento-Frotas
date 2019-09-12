using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Services
{
    public class EstoquePecasService
    {
        private readonly EstoquePecasDAL _estoquePecasDAL;

        public EstoquePecasService(EstoquePecasDAL estoquePecasDAL)
        {
            _estoquePecasDAL = estoquePecasDAL;
        }

        public void Cadastrar(EstoquePeca estoquePeca, int idpeca)
        {
            //try
            //{
            //    EstoquePeca obj = _estoquePecasDAL.BuscarEstoquePecas(idpeca); //Falta criar os métodos de busca
            //    if (obj != null)
            //    {
            //        throw new RegistroExisteException("Já existe uma peça com essa Identificação no sistema!");
            //    }
            //    _estoquePecasDAL.Cadastrar(estoquePeca);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }

        public void Deletar(int idpeca)
        {
            try
            {
                _estoquePecasDAL.Deletar(idpeca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Peça não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(EstoquePeca estoquePeca, int idpeca)
        {
            //try
            //{
            //    EstoquePeca obj = _estoquePecasDAL.BuscarEstoquePecas(idpeca); //Falta criar os métodos de busca
            //    if (obj == null)
            //    {
            //        throw new NaoEncontradoException("Peça não encontrada.");
            //    }
            //    _estoquePecasDAL.Alterar(estoquePeca, idpeca);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }
    }
}
