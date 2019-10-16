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
        private readonly VeiculoDAL _veiculoDAL;

        public SeguroService(SeguroDAL seguroDAL, VeiculoDAL veiculoDAL)
        {
            _seguroDAL = seguroDAL;
            _veiculoDAL = veiculoDAL;
        }
        public bool Cadastrar(Seguro seguro, TipoSeguro tipo, long numeroApolice) //Mudança na Query, Verificar
        {
            //try
            //{
            //    Seguro obj = _seguroDAL.BuscarSeguro(tipo, numeroApolice);
            //    if (obj != null)
            //    {
            //        throw new RegistroExisteException("Já existe uma Manutenção com esses dados no sistema!");
            //    }

            //    return _seguroDAL.Cadastrar(seguro);
            //}
            //catch (ConcorrenciaBancoException e)
            //{
            //    throw new ConcorrenciaBancoException(e.Message);
            //}
            return true;
        }

        public Seguro BuscarSeguro(TipoSeguro tipo, long numeroApolice)
        {
            //try
            //{
            //    return _seguroDAL.BuscarAbastecimento(tipo, numeroApolice);
            //}
            //catch (ConcorrenciaBancoException e)
            //{
            //    throw new ConcorrenciaBancoException(e.Message);
            //}
            return new Seguro();
        }

        public List<Seguro> BuscarTodos()
        {
            List<Seguro> seguros = new List<Seguro>();
            //try
            //{
            //    seguros.AddRange(_seguroDAL.BuscarTodos());
            //    return seguros;
            //}
            //catch (ConcorrenciaBancoException e)
            //{
            //    throw new ConcorrenciaBancoException(e.Message);
            //}
            return seguros;
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
            //try
            //{
            //    Seguro obj = _seguroDAL.BuscarSeguro(tipo, numeroApolice);
            //    if (obj != null)
            //    {
            //        return _seguroDAL.Alterar(seguro, tipo, numeroApolice);
            //    }
            //    else
            //    {
            //        throw new NaoEncontradoException("Seguro não encontrada.");
            //    }
            //}
            //catch (TransacaoException e)
            //{
            //    throw new TransacaoException(e.Message);
            //}
            //catch (ConcorrenciaBancoException e)
            //{
            //    throw new ConcorrenciaBancoException(e.Message);
            //}
            return true;
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
    }
}
