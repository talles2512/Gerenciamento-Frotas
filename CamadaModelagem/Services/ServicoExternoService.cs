using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Services
{
    public class ServicoExternoService
    {
        private readonly ServicoExternoDAL _servicoExternoDAL;
        private readonly ManutencaoDAL _manutencaoDAL;
        private readonly AbastecimentoDAL _abastecimentoDAL;
        private readonly EntradaSaidaDAL _entradaSaidaDAL;
        private readonly SeguroDAL _seguroDAL;

        public ServicoExternoService(ServicoExternoDAL servicoExternoDAL, ManutencaoDAL manutencaoDAL, AbastecimentoDAL abastecimentoDAL, EntradaSaidaDAL entradaSaidaDAL, SeguroDAL seguroDAL)
        {
            _servicoExternoDAL = servicoExternoDAL;
            _manutencaoDAL = manutencaoDAL;
            _abastecimentoDAL = abastecimentoDAL;
            _entradaSaidaDAL = entradaSaidaDAL;
            _seguroDAL = seguroDAL;
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

        public List<ServicoExterno> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<ServicoExterno> servicoExternos = new List<ServicoExterno>();
            try
            {
                servicoExternos.AddRange(_servicoExternoDAL.BuscarTodosConveniados(dtinicio,dtfim));
                servicoExternos.AddRange(_servicoExternoDAL.BuscarTodos(dtinicio,dtfim));
                return servicoExternos;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(long cnpj)
        {
            try
            {
                if (_servicoExternoDAL.Deletar(cnpj))
                {
                    return true;
                }
                else
                {
                    throw new IntegridadeException("Serviço Externo não pode ser deletado, pois ainda está vinculado à outros serviços.");
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

        public bool Alterar(ServicoExterno servicoExterno, long cnpj, TipoServicoExterno tipo)
        {
            try
            {
                ServicoExterno obj = _servicoExternoDAL.BuscarCNPJConveniado(cnpj);
                if (obj != null)
                {
                    if (servicoExterno.CNPJ != cnpj || servicoExterno.Tipo != tipo)
                    {
                        VerificarVinculo(tipo, cnpj);                   
                    }
                    return _servicoExternoDAL.AlterarConveniado(servicoExterno, cnpj);
                }
                else
                {
                    obj = _servicoExternoDAL.BuscarCNPJ(cnpj);

                    if (obj != null)
                    {

                        if (servicoExterno.ServicoExternoConveniado != null)
                        {
                            if (servicoExterno.CNPJ != cnpj || servicoExterno.Tipo != tipo)
                            {
                                VerificarVinculo(tipo, cnpj);
                            }

                            return _servicoExternoDAL.AlterarConveniado(servicoExterno, cnpj);
                        }
                        else
                        {
                            if (servicoExterno.CNPJ != cnpj || servicoExterno.Tipo != tipo)
                            {
                                VerificarVinculo(tipo, cnpj);
                            }

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
        private void VerificarVinculo(TipoServicoExterno tipo, long cnpj)
        {
            if (tipo == TipoServicoExterno.Oficina)
            {
                List<Manutencao> manutencoes = _manutencaoDAL.BuscarTodos(cnpj);
                foreach (Manutencao manutencao in manutencoes)
                {
                    if (manutencao != null)
                    {
                        throw new IntegridadeException("CNPJ da Oficina ou Tipo de Serviço Externo não podem ser alterados, pois ainda está vinculado à outros serviços.");
                    }
                }
            }
            else if (tipo == TipoServicoExterno.Posto)
            {
                List<Abastecimento> abastecimentos = _abastecimentoDAL.BuscarTodos(cnpj);
                foreach (Abastecimento abastecimento in abastecimentos)
                {
                    if (abastecimento != null)
                    {
                        throw new IntegridadeException("CNPJ do Posto ou Tipo de Serviço Externo não podem ser alterados, pois ainda está vinculado à outros serviços.");
                    }
                }
            }

            else if (tipo == TipoServicoExterno.GaragemEstacionamento)
            {
                List<EntradaSaida> entradasSaidas = _entradaSaidaDAL.BuscarTodos(cnpj);
                foreach (EntradaSaida entradaSaida in entradasSaidas)
                {
                    if (entradaSaida != null)
                    {
                        throw new IntegridadeException("CNPJ da Garagem / Estacionamento ou Tipo de Serviço Externo não podem ser alterados, pois ainda está vinculado à outros serviços.");
                    }
                }
            }

            else if (tipo == TipoServicoExterno.Seguradora)
            {
                List<Seguro> seguros = _seguroDAL.BuscarTodos(cnpj);
                foreach (Seguro seguro in seguros)
                {
                    if(seguro != null)
                    {
                        throw new IntegridadeException("CNPJ da Seguradora ou Tipo de Serviço Externo não podem ser alterados, pois ainda está vinculado à outros serviços.");
                    }
                }
            }
        }

        public List<ServicoExterno> Pesquisar(string buscar)
        {
            List<ServicoExterno> servicoExternos = new List<ServicoExterno>();
            try
            {
                servicoExternos.AddRange(_servicoExternoDAL.Pesquisar(buscar));
                servicoExternos.AddRange(_servicoExternoDAL.PesquisarConveniados(buscar));
                return servicoExternos;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }  
}
