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
    public class OcupanteService
    {
        private readonly OcupanteDAL _ocupanteDAL;

        public OcupanteService(OcupanteDAL ocupanteDAL)
        {
            _ocupanteDAL = ocupanteDAL;
        }

        public bool Cadastrar(Ocupante ocupante)
        {

            try
            {
                Ocupante obj = _ocupanteDAL.BuscarOcupante(ocupante.Requisicao, ocupante.CPF.ToString()); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe uma multa com esse dados no sistema!");
                }
                return _ocupanteDAL.Cadastrar(ocupante);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public Ocupante BuscarOcupante(int req,string cpf)
        {
            try
            {
                Ocupante ocupante = _ocupanteDAL.BuscarOcupante(req,cpf);
                return ocupante;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Ocupante> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Ocupante> ocupantes = new List<Ocupante>();
            try
            {
                ocupantes.AddRange(_ocupanteDAL.BuscarTodos(dtinicio, dtfim));
                return ocupantes;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
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
            //try
            //{
            //    Ocupante obj = _ocupanteDAL.BuscarOcupante(cpf); //Falta criar os métodos de busca
            //    if (obj == null)
            //    {
            //        throw new NaoEncontradoException("Ocupante não encontrado.");
            //    }
            //    _ocupanteDAL.Alterar(ocupante,cpf);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }
    }
}
