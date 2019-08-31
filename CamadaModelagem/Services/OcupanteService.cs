using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Services
{
    class OcupanteService
    {
        private readonly OcupanteDAL _ocupanteDAL;

        public OcupanteService(OcupanteDAL ocupanteDAL)
        {
            _ocupanteDAL = ocupanteDAL;
        }

        public void Cadastrar(Ocupante ocupante, int cpf)
        {
            try
            {
                Ocupante obj = _ocupanteDAL.BuscarOcupante(cpf); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um ocupante com esse CPF no sistema!");
                }
                _ocupanteDAL.Cadastrar(ocupante);
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
                _ocupanteDAL.Deletar(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Ocupante não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Ocupante ocupante, int cpf)
        {
            try
            {
                Ocupante obj = _ocupanteDAL.BuscarOcupante(cpf); //Falta criar os métodos de busca
                if (obj == null)
                {
                    throw new NaoEncontradoException("Ocupante não encontrado.");
                }
                _ocupanteDAL.Alterar(ocupante,cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
    }
}
