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
    public class MotoristaService
    {
        private readonly MotoristaDAL _motoristaDAL;

        public MotoristaService(MotoristaDAL motoristaDAL)
        {
            _motoristaDAL = motoristaDAL;
        }
        public void Cadastrar(Motorista motorista, CNH cnh) //Mudança na Query, Verificar
        {
            //try
            //{
            //    Motorista obj = _motoristaDAL.BuscarCPF(motorista.CPF); //Falta criar os métodos de busca
            //    if (obj != null)
            //    {
            //        throw new RegistroExisteException("Já existe um motorista com esse CPF no sistema!");
            //    }
            //    _motoristaDAL.Cadastrar(motorista, cnh);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }

        public void Deletar(int cpf)
        {
            try
            {
                _motoristaDAL.Deletar(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Motorista não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Motorista motorista, CNH cnh, int cpf)
        {
            //try
            //{
            //    Motorista obj = _motoristaDAL.BuscarCPF(cpf);
            //    if(obj == null)
            //    {
            //        throw new NaoEncontradoException("Motorista não encontrado.");
            //    }
            //    _motoristaDAL.Alterar(motorista, cnh, cpf);
            //}
            //catch(ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }

    }
}
