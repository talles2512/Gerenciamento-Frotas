using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Services
{
    public class ViagemService
    {
        private readonly ViagemDAL _viagemDAL;

        public ViagemService(ViagemDAL viagemDAL)
        {
            _viagemDAL = viagemDAL;
        }

        public bool Cadastrar(Viagem viagem, int requisicao)
        {
            try
            {
                Viagem obj = _viagemDAL.BuscarViagem(requisicao);
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe uma Manutenção com esses dados no sistema!");
                }

                return _viagemDAL.Cadastrar(viagem);
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
                return _viagemDAL.BuscarViagem(requisicao);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Viagem> BuscarTodos()
        {
            List<Viagem> viagens = new List<Viagem>();
            try
            {
                viagens.AddRange(_viagemDAL.BuscarTodos());
                return viagens;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(int requisicao)
        {
            try
            {
                if (_viagemDAL.Deletar(requisicao))
                {
                    return true;
                }
                else
                {
                    throw new IntegridadeException("Viagem não pode ser deletada, pois ainda está vinculada à outros serviços.");
                }
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
                Viagem obj = _viagemDAL.BuscarViagem(requisicao);
                if (obj != null)
                {
                    return _viagemDAL.Alterar(viagem, requisicao);
                }
                else
                {
                    throw new NaoEncontradoException("Viagem não encontrada.");
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

        public int PopularRequisicao()
        {
            try
            {
                return _viagemDAL.PopularRequisicao();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public DataTable PopularCPFs()
        {
            try
            {
                return _viagemDAL.PopularCPFs();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public DataTable PopularPlacas()
        {
            try
            {
                return _viagemDAL.PopularPlacas();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
