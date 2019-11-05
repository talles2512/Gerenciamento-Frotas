using CamadaModelagem.Models;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    public class EstoquePecasController
    {
        private readonly EstoquePecasService _estoquePecasService;

        public EstoquePecasController(EstoquePecasService estoquePecasService)
        {
            _estoquePecasService = estoquePecasService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(EstoquePeca estoquePeca, int idpeca)
        {           
            try
            {
                return _estoquePecasService.Cadastrar(estoquePeca, idpeca);
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

        public EstoquePeca BuscarEstoquePecas(int idpeca)
        {
            try
            {
                return _estoquePecasService.BuscarEstoquePecas(idpeca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        public List<EstoquePeca> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _estoquePecasService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(int idpeca)
        {            
            try
            {
                return _estoquePecasService.Deletar(idpeca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Alterar(EstoquePeca estoquePeca, int idpeca)
        {          
            try
            {
                return _estoquePecasService.Alterar(estoquePeca, idpeca);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }

        }

        public int PopulaID()
        {
            try
            {
                return _estoquePecasService.PopulaID();
            }
            catch
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<EstoquePeca> Pesquisar(string busca)
        {
            try
            {
                return _estoquePecasService.Pesquisar(busca);
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
