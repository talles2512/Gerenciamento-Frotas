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
        private readonly EntradaSaidaDAL _entradaSaidaDAL;
        private readonly SeguroDAL _seguroDAL;

        public MotoristaService(MotoristaDAL motoristaDAL, EntradaSaidaDAL entradaSaidaDAL, SeguroDAL seguroDAL)
        {
            _motoristaDAL = motoristaDAL;
            _entradaSaidaDAL = entradaSaidaDAL;
            _seguroDAL = seguroDAL;
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

        public List<Motorista> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Motorista> motoristas = new List<Motorista>();
            try
            {
                motoristas.AddRange(_motoristaDAL.BuscarTodos(dtinicio, dtfim));
                return motoristas;
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Inativar(string cpf, bool sit)
        {
            try
            {
                return _motoristaDAL.Inativar(cpf, sit);
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
                    if (motorista.CPF != cpf)
                    {
                        VerificarVinculo(cpf);
                    }
                    return _motoristaDAL.Alterar(motorista, cnh, cpf);
                }
                else
                {
                    throw new NaoEncontradoException("Motorista não encontrado.");
                }
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        private void VerificarVinculo(string cpf)
        {
            List<EntradaSaida> entradasSaidas = _entradaSaidaDAL.BuscarTodosMotoristas(cpf);
            foreach (EntradaSaida entradaSaida in entradasSaidas)
            {
                if (entradaSaida != null)
                {
                    throw new IntegridadeException("CPF do Motorista não pode ser alterado, pois ainda está vinculado à Garagens / Estacionamentos.");
                }
            }

            List<Seguro> seguros = _seguroDAL.BuscarTodosMotoristas(cpf);
            foreach (Seguro seguro in seguros)
            {
                if (seguro != null)
                {
                    throw new IntegridadeException("CPF do Motorista não pode ser alterado, pois ainda está vinculado à Seguradoras.");
                }
            }
        }

        public List<Motorista> Pesquisar(string buscar)
        {
            List<Motorista> motoristas = new List<Motorista>();
            try
            {
                motoristas.AddRange(_motoristaDAL.Pesquisar(buscar));
                return motoristas;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
