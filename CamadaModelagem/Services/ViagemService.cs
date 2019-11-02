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
        private readonly OcupanteDAL _ocupanteDAL;

        public ViagemService(ViagemDAL viagemDAL, OcupanteDAL ocupanteDAL)
        {
            _viagemDAL = viagemDAL;
            _ocupanteDAL = ocupanteDAL;
        }

        public bool Cadastrar(Viagem viagem, int requisicao)
        {
            try
            {
                Viagem obj = _viagemDAL.BuscarViagem(requisicao);
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe uma Viagem com esses dados no sistema!");
                }

                if (_viagemDAL.Cadastrar(viagem))
                {
                    if (viagem.Ocupantes.Any())
                    {
                        foreach(Ocupante ocupante in viagem.Ocupantes)
                        {
                            if (!_ocupanteDAL.Cadastrar(ocupante))
                            {
                                break;
                            }
                        }
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
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
                Viagem viagem = _viagemDAL.BuscarViagem(requisicao);
                viagem.Ocupantes = _ocupanteDAL.BuscarOcupantes(requisicao);
                return viagem;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Viagem> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Viagem> viagens = new List<Viagem>();
            try
            {
                viagens.AddRange(_viagemDAL.BuscarTodos(dtinicio, dtfim));
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
                if (_ocupanteDAL.Deletar(requisicao))
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
                    if (viagem.Ocupante)
                    {
                        if (_viagemDAL.Alterar(viagem, requisicao))
                        {
                            if (_ocupanteDAL.Deletar(requisicao))
                            {
                                foreach (Ocupante ocupante in viagem.Ocupantes)
                                {
                                    if (!_ocupanteDAL.Cadastrar(ocupante))
                                    {
                                        break;
                                    }
                                }
                                return true;
                            }
                            else
                            {
                                throw new ConcorrenciaBancoException("Não foi possível realizar esta ação. Favor tentar novamente mais tarde.");
                            }
                        }
                        else
                        {
                            throw new ConcorrenciaBancoException("Não foi possível realizar esta ação. Favor tentar novamente mais tarde.");
                        }
                    }
                    else
                    {
                        if (_ocupanteDAL.Deletar(requisicao))
                        {
                            return _viagemDAL.Alterar(viagem, requisicao);
                        }
                        else
                        {
                            throw new ConcorrenciaBancoException("Não foi possível realizar esta ação. Favor tentar novamente mais tarde.");
                        }
                    }
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

        public List<Viagem> Pesquisar(string buscar)
        {
            List<Viagem> viagens = new List<Viagem>();
            try
            {
                viagens.AddRange(_viagemDAL.Pesquisar(buscar));

                foreach(Viagem viagem in viagens)
                {
                    if (viagem.Ocupante)
                    {
                        viagem.Ocupantes = _ocupanteDAL.BuscarOcupantes(viagem.Requisicao);
                    }
                }
                return viagens;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
