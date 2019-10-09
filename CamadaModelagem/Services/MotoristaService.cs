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
        public bool Cadastrar(Motorista motorista, CNH cnh) //Mudança na Query, Verificar
        {
            try
            {
                Motorista obj = _motoristaDAL.BuscarCPF(motorista.CPF); //Metodo criado, falta validar
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um motorista com esse CPF no sistema!");
                }
                return _motoristaDAL.Cadastrar(motorista, cnh);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public Motorista BuscarCPF(string cpf)
        {
            try
            {
                Motorista motorista = _motoristaDAL.BuscarCPF(cpf);
                return motorista;
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Motorista> BuscarTodos()
        {
            List<Motorista> motoristas = new List<Motorista>();
            try
            {
                motoristas.AddRange(_motoristaDAL.BuscarTodos());
                return motoristas;
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Inativar(string cpf)
        {
            try
            {
                return _motoristaDAL.Inativar(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Motorista não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public bool Alterar(Motorista motorista, CNH cnh, string cpf)
        {
            try
            {
                Motorista obj = _motoristaDAL.BuscarCPF(cpf);
                if (obj != null)
                {
                    return _motoristaDAL.Alterar(motorista, cnh, cpf);
                }
                else
                {
                    throw new NaoEncontradoException("Veículo não encontrado.");
                }
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
    }
}
