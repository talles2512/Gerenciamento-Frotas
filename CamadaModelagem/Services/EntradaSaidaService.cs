using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Services
{
    public class EntradaSaidaService
    {
        private readonly EntradaSaidaDAL _entradaSaidaDAL;

        public EntradaSaidaService(EntradaSaidaDAL entradaSaidaDAL)
        {
            _entradaSaidaDAL = entradaSaidaDAL;
        }
        public bool Cadastrar(EntradaSaida entradaSaida, string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data) //Mudança na Query, Verificar
        {
            try
            {
                EntradaSaida obj = _entradaSaidaDAL.BuscarEntradaSaida(placa, cnpj, tipo, data);
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe uma Manutenção com esses dados no sistema!");
                }

                return _entradaSaidaDAL.Cadastrar(entradaSaida);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public EntradaSaida BuscarEntradaSaida(string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data)
        {
            try
            {
                return _entradaSaidaDAL.BuscarEntradaSaida(placa, cnpj, tipo, data);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<EntradaSaida> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<EntradaSaida> entradasSaidas = new List<EntradaSaida>();
            try
            {
                entradasSaidas.AddRange(_entradaSaidaDAL.BuscarTodos(dtinicio, dtfim));
                return entradasSaidas;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data)
        {
            try
            {
                if (_entradaSaidaDAL.Deletar(placa, cnpj, tipo, data))
                {
                    return true;
                }
                else
                {
                    throw new IntegridadeException("Entrada / Saída não pode ser deletada, pois ainda está vinculada à outros serviços.");
                }
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(EntradaSaida entradaSaida, string placa, long cnpj, EntradaSaidaTipo tipo, DateTime data)
        {
            try
            {
                EntradaSaida obj = _entradaSaidaDAL.BuscarEntradaSaida(placa, cnpj, tipo, data);
                if (obj != null)
                {
                    return _entradaSaidaDAL.Alterar(entradaSaida ,placa, cnpj, tipo, data);
                }
                else
                {
                    throw new NaoEncontradoException("Entrada/Saída não encontrada.");
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

        public DataTable PopularCPFs()
        {
            try
            {
                return _entradaSaidaDAL.PopularCPFs();
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
                return _entradaSaidaDAL.PopularPlacas();
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
                return _entradaSaidaDAL.PopularServicosExternos();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
