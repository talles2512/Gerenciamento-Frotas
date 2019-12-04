using CamadaModelagem.Data;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using System.Data;

namespace CamadaModelagem.Services
{
    public class VeiculoService
    {
        private readonly VeiculoDAL _veiculoDAL;
        private readonly ManutencaoDAL _manutencaoDAL;
        private readonly AbastecimentoDAL _abastecimentoDAL;
        private readonly EntradaSaidaDAL _entradaSaidaDAL;
        private readonly SeguroDAL _seguroDAL;

        public VeiculoService(VeiculoDAL veiculoDAL, ManutencaoDAL manutencaoDAL, AbastecimentoDAL abastecimentoDAL, EntradaSaidaDAL entradaSaidaDAL, SeguroDAL seguroDAL)
        {
            _veiculoDAL = veiculoDAL;
            _manutencaoDAL = manutencaoDAL;
            _abastecimentoDAL = abastecimentoDAL;
            _entradaSaidaDAL = entradaSaidaDAL;
            _seguroDAL = seguroDAL;
        }

        public bool Cadastrar(Veiculo veiculo, string placa)
        {
            try
            {
                Veiculo obj1 = _veiculoDAL.BuscarPlaca(placa);
                Veiculo obj2 = _veiculoDAL.BuscarPlacaAlugado(placa);
                if (obj1 != null || obj2 != null)
                {
                    throw new RegistroExisteException("Já existe um veículo com essa Placa no sistema!");
                }

                if (veiculo.VeiculoAlugado != null)
                {
                    return _veiculoDAL.CadastrarAlugado(veiculo);
                }
                else
                {
                    return _veiculoDAL.Cadastrar(veiculo);
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

        public Veiculo BuscarPlaca(string placa)
        {
            try
            {
                Veiculo veiculo = _veiculoDAL.BuscarPlacaAlugado(placa);
                if (veiculo == null)
                {
                    veiculo = _veiculoDAL.BuscarPlaca(placa);
                }
                return veiculo;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Veiculo> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            try
            {
                veiculos.AddRange(_veiculoDAL.BuscarTodosAlugados(dtinicio, dtfim));
                veiculos.AddRange(_veiculoDAL.BuscarTodos(dtinicio, dtfim));
                return veiculos;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Inativar(string placa, bool sit)
        {
            try
            {
                return _veiculoDAL.Inativar(placa, sit);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Veiculo veiculo, string placa)
        {
            try
            {
                Veiculo obj = _veiculoDAL.BuscarPlacaAlugado(placa);
                if (obj != null)
                {
                    if (veiculo.Placa != placa)
                    {
                        VerificarVinculo(placa);
                    }
                    return _veiculoDAL.AlterarAlugado(veiculo, placa);
                }
                else
                {
                    obj = _veiculoDAL.BuscarPlaca(placa);

                    if (obj != null)
                    {
                        if (veiculo.VeiculoAlugado != null)
                        {
                            if (veiculo.Placa != placa)
                            {
                                VerificarVinculo(placa);
                            }

                            return _veiculoDAL.AlterarAlugado(veiculo, placa);
                        }
                        else
                        {
                            if (veiculo.Placa != placa)
                            {
                                VerificarVinculo(placa);
                            }

                            return _veiculoDAL.Alterar(veiculo, placa);
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

        private void VerificarVinculo(string placa)
        {
            List<Manutencao> manutencoes = _manutencaoDAL.BuscarTodos(placa);
            foreach (Manutencao manutencao in manutencoes)
            {
                if (manutencao != null)
                {
                    throw new IntegridadeException("Placa do Veículo não pode ser alterada, pois ainda está vinculada à Oficinas.");
                }
            }

            List<Abastecimento> abastecimentos = _abastecimentoDAL.BuscarTodos(placa);
            foreach (Abastecimento abastecimento in abastecimentos)
            {
                if (abastecimento != null)
                {
                    throw new IntegridadeException("Placa do Veículo não pode ser alterada, pois ainda está vinculada à Postos.");
                }
            }

            List<EntradaSaida> entradasSaidas = _entradaSaidaDAL.BuscarTodos(placa);
            foreach (EntradaSaida entradaSaida in entradasSaidas)
            {
                if (entradaSaida != null)
                {
                    throw new IntegridadeException("Placa do Veículo não pode ser alterada, pois ainda está vinculada à Garagens / Estacionamentos.");
                }
            }

            List<Seguro> seguros = _seguroDAL.BuscarTodos(placa);
            foreach (Seguro seguro in seguros)
            {
                if (seguro != null)
                {
                    throw new IntegridadeException("Placa do Veículo não pode ser alterada, pois ainda está vinculada à Seguradoras.");
                }
            }

        }


        public List<Veiculo> Pesquisar(string buscar)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            try
            {
                veiculos.AddRange(_veiculoDAL.Pesquisar(buscar));
                veiculos.AddRange(_veiculoDAL.PesquisarAlugados(buscar));
                return veiculos;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
