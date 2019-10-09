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

        public VeiculoService(VeiculoDAL veiculoDAL)
        {
            _veiculoDAL = veiculoDAL;
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

                if(veiculo.VeiculoAlugado != null)
                {
                    return _veiculoDAL.CadastrarAlugado(veiculo);
                }
                else
                {
                    return _veiculoDAL.Cadastrar(veiculo);
                }
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public Veiculo BuscarPlaca(string placa)
        {
            try
            {
               Veiculo veiculo = _veiculoDAL.BuscarPlacaAlugado(placa);
               if(veiculo == null)
                {
                    veiculo = _veiculoDAL.BuscarPlaca(placa);
                }
                return veiculo;
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Veiculo> BuscarTodos()
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            try
            {
                veiculos.AddRange(_veiculoDAL.BuscarTodosAlugados());
                veiculos.AddRange(_veiculoDAL.BuscarTodos());
                return veiculos;
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Inativar(string placa)
        {
            try
            {
                return _veiculoDAL.Inativar(placa);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Veículo não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public bool Alterar(Veiculo veiculo, string placa)
        {
            try
            {
                Veiculo obj = _veiculoDAL.BuscarPlacaAlugado(placa);
                if (obj != null)
                {
                        return _veiculoDAL.AlterarAlugado(veiculo, placa);
                }
                else
                {
                    obj = _veiculoDAL.BuscarPlaca(placa);

                    if(obj != null)
                    {
                        if(veiculo.VeiculoAlugado != null)
                        {
                            return _veiculoDAL.AlterarAlugado(veiculo, placa);
                        }
                        else
                        {
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
    }
}
