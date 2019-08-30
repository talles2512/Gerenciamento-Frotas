using CamadaModelagem.Data;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Models;

namespace CamadaModelagem.Services
{
    class MotoristaService
    {
        private readonly MotoristaService _motoristaService;

        public MotoristaService(MotoristaService motoristaService)
        {
            _motoristaService = motoristaService;
        }
        public void Cadastrar(Motorista motorista, CNH cnh) //Mudança na Query, Verificar
        {
            try
            {
                Motorista obj = _motoristaService.BuscarCPF(motorista.CPF); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um motorista com esse CPF no sistema!");
                }
                _motoristaService.Cadastrar(motorista, cnh);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public void Deletar(int cpf)
        {
            try
            {
                _motoristaService.Deletar(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Motorista não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Motorista motorista, CNH cnh, int cpf)
        {

        }

    }
}
