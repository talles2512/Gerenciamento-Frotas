using CamadaModelagem.Models;
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
    public class ViagemController
    {
        private readonly ViagemService _viagemService;

        public ViagemController(ViagemService viagemService)
        {
            _viagemService = viagemService;
        }

        #region [AplicacaoDesktop]

        public bool Cadastrar(Viagem viagem,int requisicao)
        {
            try
            {
                return _viagemService.Cadastrar(viagem, requisicao);
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

        public Viagem BuscarViagem(int requisicao)
        {
            try
            {
                return _viagemService.BuscarViagem(requisicao);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Viagem> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _viagemService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(int requisicao)
        {
            try
            {
                return _viagemService.Deletar(requisicao);
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

        public bool Alterar(Viagem viagem, int requisicao)
        {
            try
            {
                return _viagemService.Alterar(viagem, requisicao);
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

        public int PopularRequisicao()
        {
            try
            {
                return _viagemService.PopularRequisicao();
            }
            catch
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public DataTable PopularCPFs()
        {
            try
            {
                return _viagemService.PopularCPFs();
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
                return _viagemService.PopularPlacas();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Viagem> Pesquisar(string busca)
        {
            try
            {
                return _viagemService.Pesquisar(busca);
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
