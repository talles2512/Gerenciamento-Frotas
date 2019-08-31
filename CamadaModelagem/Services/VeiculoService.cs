using CamadaModelagem.Data;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;

namespace CamadaModelagem.Services
{
    class VeiculoService
    {
        private readonly VeiculoDAL _veiculoDAL;

        public VeiculoService(VeiculoDAL veiculoDAL)
        {
            _veiculoDAL = veiculoDAL;
        }
                                               
        public void Cadastrar(Veiculo veiculo, string placa) 
        {
            try
            {
                Veiculo obj = _veiculoDAL.BuscarPlaca(placa); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um veículo com essa Placa no sistema!");
                }
                _veiculoDAL.Cadastrar(veiculo);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public void Deletar(string placa)
        {
            try
            {
                _veiculoDAL.Deletar(placa);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Veículo não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Veiculo veiculo, string placa)
        {
            try
            {
               Veiculo obj = _veiculoDAL.BuscarPlaca(placa); //Falta criar os métodos de busca
               if  (obj == null)
               {
                    throw new NaoEncontradoException("Veículo não encontrado.");
                }
                _veiculoDAL.Alterar(veiculo,placa);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
    }
}
