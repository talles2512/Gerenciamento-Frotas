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
    public class AbastecimentoService
    {
        private readonly AbastecimentoDAL _abastecimentoDAL;
        private readonly VeiculoDAL _veiculoDAL;

        public AbastecimentoService(AbastecimentoDAL abastecimentoDAL, VeiculoDAL veiculoDAL)
        {
            _abastecimentoDAL = abastecimentoDAL;
            _veiculoDAL = veiculoDAL;
        }
        public bool Cadastrar(Abastecimento abastecimento, string placa, AbastecimentoTipo tipo, DateTime data) //Mudança na Query, Verificar
        {
            try
            {
                Abastecimento obj = _abastecimentoDAL.BuscarAbastecimento(placa, tipo, data);
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe uma Manutenção com esses dados no sistema!");
                }
                else
                {
                    Veiculo veiculo = _veiculoDAL.BuscarPlaca(placa);
                    AbastecimentoTipo abastecimentoTipo = (AbastecimentoTipo)Enum.Parse(typeof(AbastecimentoTipo), veiculo.Combustivel.ToString());

                    if (abastecimentoTipo == AbastecimentoTipo.Flex)
                    {
                        if (abastecimento.Tipo == AbastecimentoTipo.Gasolina || abastecimento.Tipo == AbastecimentoTipo.Etanol
                            || abastecimento.Tipo == AbastecimentoTipo.Gasolina_Aditivada)
                        {
                            return _abastecimentoDAL.Cadastrar(abastecimento);
                        }
                        else
                        {
                            throw new TipoCombustivelException("Combustível escolhido é incompatível com o veículo!");
                        }
                    }
                    else if (abastecimentoTipo == abastecimento.Tipo)
                    {
                        return _abastecimentoDAL.Cadastrar(abastecimento);
                    }
                    else
                    {
                        throw new TipoCombustivelException("Combustível escolhido é incompatível com o veículo!");
                    }
                }

            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Abastecimento BuscarAbastecimento(string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                return _abastecimentoDAL.BuscarAbastecimento(placa, tipo, data);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Abastecimento> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Abastecimento> abastecimentos = new List<Abastecimento>();
            try
            {
                abastecimentos.AddRange(_abastecimentoDAL.BuscarTodos(dtinicio, dtfim));
                return abastecimentos;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Deletar(string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                if (_abastecimentoDAL.Deletar(placa, tipo, data))
                {
                    return true;
                }
                else
                {
                    throw new IntegridadeException("Abastecimento não pode ser deletado, pois ainda está vinculado à outros serviços.");
                }
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Abastecimento abastecimento, string placa, AbastecimentoTipo tipo, DateTime data)
        {
            try
            {
                Abastecimento obj = _abastecimentoDAL.BuscarAbastecimento(placa, tipo, data);
                if (obj != null)
                {
                    Veiculo veiculo = _veiculoDAL.BuscarPlaca(placa);
                    AbastecimentoTipo abastecimentoTipo = (AbastecimentoTipo)Enum.Parse(typeof(AbastecimentoTipo), veiculo.Combustivel.ToString());

                    if (abastecimentoTipo == AbastecimentoTipo.Flex)
                    {
                        if (abastecimento.Tipo == AbastecimentoTipo.Gasolina || abastecimento.Tipo == AbastecimentoTipo.Etanol
                            || abastecimento.Tipo == AbastecimentoTipo.Gasolina_Aditivada)
                        {
                            return _abastecimentoDAL.Alterar(abastecimento, placa, tipo, data);
                        }
                        else
                        {
                            throw new TipoCombustivelException("Combustível escolhido é incompatível com o veículo!");
                        }
                    }
                    else if (abastecimentoTipo == abastecimento.Tipo)
                    {
                        return _abastecimentoDAL.Alterar(abastecimento, placa, tipo, data);
                    }
                    else
                    {
                        throw new TipoCombustivelException("Combustível escolhido é incompatível com o veículo!");
                    }
                }
                else
                {
                    throw new NaoEncontradoException("Abastecimento não encontrado.");
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
                return _abastecimentoDAL.PopularPlacas();
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
                return _abastecimentoDAL.PopularServicosExternos();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}