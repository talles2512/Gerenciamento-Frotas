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
    public class ServicoExternoService
    {
        private readonly ServicoExternoDAL _servicoExternoDAL;

        public ServicoExternoService(ServicoExternoDAL servicoExternoDAL)
        {
            _servicoExternoDAL = servicoExternoDAL;
        }
        public bool Cadastrar(ServicoExterno servicoExterno, long cnpj) //Mudança na Query, Verificar
        {
            try
            {
                ServicoExterno obj1 = _servicoExternoDAL.BuscarCNPJ(cnpj);
                ServicoExterno obj2 = _servicoExternoDAL.BuscarCNPJConveniado(cnpj);
                if (obj1 != null || obj2 != null)
                {
                    throw new RegistroExisteException("Já existe um Serviço Externo com esse CNPJ no sistema!");
                }

                if (servicoExterno.ServicoExternoConveniado != null)
                {
                    return _servicoExternoDAL.CadastrarConveniado(servicoExterno);
                }
                else
                {
                    return _servicoExternoDAL.Cadastrar(servicoExterno);
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

        public ServicoExterno BuscarCNPJ(long cnpj)
        {
            try
            {
                ServicoExterno servicoExterno = _servicoExternoDAL.BuscarCNPJConveniado(cnpj);
                if (servicoExterno == null)
                {
                    servicoExterno = _servicoExternoDAL.BuscarCNPJ(cnpj);
                }
                return servicoExterno;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<ServicoExterno> BuscarTodos()
        {
            List<ServicoExterno> servicoExternos = new List<ServicoExterno>();
            try
            {
                servicoExternos.AddRange(_servicoExternoDAL.BuscarTodosConveniados());
                servicoExternos.AddRange(_servicoExternoDAL.BuscarTodos());
                return servicoExternos;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Inativar(long cnpj)
        {
            try
            {
                return _servicoExternoDAL.Inativar(cnpj);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(ServicoExterno servicoExterno, long cnpj)
        {
            try
            {
                ServicoExterno obj = _servicoExternoDAL.BuscarCNPJConveniado(cnpj);
                if (obj != null)
                {
                    return _servicoExternoDAL.AlterarConveniado(servicoExterno, cnpj);
                }
                else
                {
                    obj = _servicoExternoDAL.BuscarCNPJ(cnpj);

                    if (obj != null)
                    {
                        if (servicoExterno.ServicoExternoConveniado != null)
                        {
                            return _servicoExternoDAL.AlterarConveniado(servicoExterno, cnpj);
                        }
                        else
                        {
                            return _servicoExternoDAL.Alterar(servicoExterno, cnpj);
                        }
                    }
                    else
                    {
                        throw new NaoEncontradoException("Veículo não encontrado.");
                    }
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
    }
}
