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
    public class ClienteService
    {
        private readonly ClienteDAL _clienteDAL;

        public ClienteService(ClienteDAL clienteDAL)
        {
            _clienteDAL = clienteDAL;
        }

        public bool Cadastrar(Cliente cliente, string cpf) //Mudança na Query, Verificar
        {
            try
            {
                Cliente obj = _clienteDAL.BuscarCPF(cliente.CPF); //Metodo criado, falta validar
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um cliente com esse CPF no sistema!");
                }
                return _clienteDAL.Cadastrar(cliente);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public Cliente BuscarCPF(string cpf)
        {
            try
            {
                Cliente cliente = _clienteDAL.BuscarCPF(cpf);
                return cliente;
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Cliente> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                clientes.AddRange(_clienteDAL.BuscarTodos(dtinicio, dtfim));
                return clientes;
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string cpf)
        {
            try
            {
                return _clienteDAL.Deletar(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Cliente não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public bool Alterar(Cliente cliente, string cpf)
        {
            try
            {
                Cliente obj = _clienteDAL.BuscarCPF(cpf);
                if (obj != null)
                {
                    return _clienteDAL.Alterar(cliente, cpf);
                }
                else
                {
                    throw new NaoEncontradoException("Cliente não encontrado.");
                }
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Cliente> Pesquisar(string buscar)
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                clientes.AddRange(_clienteDAL.Pesquisar(buscar));
                return clientes;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
