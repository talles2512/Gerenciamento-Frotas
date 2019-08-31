using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Services
{
    class ClienteService
    {
        private readonly ClienteDAL _clienteDAL;

        public ClienteService(ClienteDAL clienteDAL)
        {
            _clienteDAL = clienteDAL;
        }

        public void Cadastrar(Cliente cliente, int cpf)
        {
            try
            {
                Cliente obj = _clienteDAL.BuscarCPF(cpf); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um cliente com esse CPF no sistema!");
                }
                _clienteDAL.Cadastrar(cliente);
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
                _clienteDAL.Deletar(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Cliente não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Cliente cliente, int cpf)
        {
            try
            {
                Cliente obj = _clienteDAL.BuscarCPF(cpf); //Falta criar os métodos de busca
                if (obj == null)
                {
                    throw new NaoEncontradoException("Cliente não encontrado.");
                }
                _clienteDAL.Alterar(cliente, cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
    }
}
