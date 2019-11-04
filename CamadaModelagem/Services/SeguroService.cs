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
    public class SeguroService
    {
        private readonly SeguroDAL _seguroDAL;

        public SeguroService(SeguroDAL seguroDAL)
        {
            _seguroDAL = seguroDAL;
        }
        public bool Cadastrar(Seguro seguro, TipoSeguro tipo, long numeroApolice) //Mudança na Query, Verificar
        {
            try
            {
                Seguro obj1 = _seguroDAL.BuscarSeguro(tipo, numeroApolice);
                Seguro obj2 = _seguroDAL.BuscarSeguro(tipo, seguro.ItemSegurado);
                if (obj1 != null)
                {
                    throw new RegistroExisteException("Já existe um Seguro com esses dados no sistema!");
                }
                else if (obj2 != null)
                {
                    throw new RegistroExisteException("Este Item Segurado já possui um Seguro cadastrado no sistema!");
                }

                return _seguroDAL.Cadastrar(seguro);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Seguro BuscarSeguro(TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                return _seguroDAL.BuscarSeguro(tipo, numeroApolice);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Seguro> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Seguro> seguros = new List<Seguro>();
            try
            {
                seguros.AddRange(_seguroDAL.BuscarTodos(dtinicio, dtfim));
                return seguros;
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
                if (_seguroDAL.Deletar(tipo, numeroApolice))
                {
                    return true;
                }
                else
                {
                    throw new IntegridadeException("Seguro não pode ser deletado, pois ainda está vinculado à outros serviços.");
                }
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Seguro seguro, TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                Seguro obj = _seguroDAL.BuscarSeguro(tipo, numeroApolice);
                if (obj != null)
                {
                    return _seguroDAL.Alterar(seguro, tipo, numeroApolice);
                }
                else
                {
                    throw new NaoEncontradoException("Seguro não encontrado.");
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

        public DataTable PopularPlacas()
        {
            try
            {
                return _seguroDAL.PopularPlacas();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public DataTable PopularCPFs()
        {
            try
            {
                return _seguroDAL.PopularCPFs();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public DataTable PopularServicosExternos()
        {
            try
            {
                return _seguroDAL.PopularServicosExternos();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Seguro> Pesquisar(string buscar)
        {
            List<Seguro> seguros = new List<Seguro>();
            try
            {
                seguros.AddRange(_seguroDAL.Pesquisar(buscar));
                return seguros;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
