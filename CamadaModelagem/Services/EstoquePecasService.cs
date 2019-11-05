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

        public bool Cadastrar(EstoquePeca estoquePeca, int idpeca)
        {
            try
            {
                EstoquePeca obj = _estoquePecasDAL.BuscarEstoquePecas(idpeca); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe uma peça com essa Identificação no sistema!");
                }
                return _estoquePecasDAL.Cadastrar(estoquePeca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public EstoquePeca BuscarEstoquePecas(int idpeca)
        {
            try
            {
                EstoquePeca estoquePeca = _estoquePecasDAL.BuscarEstoquePecas(idpeca);
                return estoquePeca;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
        public List<EstoquePeca> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<EstoquePeca> pecas = new List<EstoquePeca>();
            try
            {
                pecas.AddRange(_estoquePecasDAL.BuscarTodos(dtinicio, dtfim));
                return pecas;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(int idpeca)
        {
            try
            {
                return _estoquePecasDAL.Deletar(idpeca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Peça não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public bool Alterar(EstoquePeca estoquePeca, int idpeca)
        {
            try
            {
                EstoquePeca obj = _estoquePecasDAL.BuscarEstoquePecas(idpeca); //Falta criar os métodos de busca
                if (obj == null)
                {
                    throw new NaoEncontradoException("Peça não encontrada.");
                }
                _estoquePecasDAL.Alterar(estoquePeca, idpeca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
            return true;
        }

        public int PopulaID()
        {
            try
            {
                return _estoquePecasDAL.PopulaID();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<EstoquePeca> Pesquisar(string buscar)
        {
            List<EstoquePeca> estoquePecas = new List<EstoquePeca>();
            try
            {
                estoquePecas.AddRange(_estoquePecasDAL.Pesquisar(buscar));
                return estoquePecas;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
