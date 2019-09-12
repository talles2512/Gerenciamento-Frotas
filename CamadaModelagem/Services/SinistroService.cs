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
    public class SinistroService
    {
        private readonly SinistroDAL _sinistroDAL;

        public SinistroService(SinistroDAL sinitroDAL)
        {
            _sinistroDAL = sinitroDAL;
        }

        public void Cadastrar(Sinistro sinistro, int id, DateTime data)
        {
            //try
            //{
            //    Sinistro obj = _sinistroDAL.BuscarSinistro (id,data); //Falta criar os métodos de busca
            //    if (obj != null)
            //    {
            //        throw new RegistroExisteException("Já existe um sinistro com esse dados no sistema!");
            //    }
            //    _sinistroDAL.Cadastrar(sinistro);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }

        public void Deletar(int id, DateTime data)
        {
            try
            {
                _sinistroDAL.Deletar(id,data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Sinistro não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Sinistro sinistro, int id, DateTime data)
        {
            //try
            //{
            //    Sinistro obj = _sinistroDAL.BuscarSinistro(id,data); //Falta criar os métodos de busca
            //    if (obj == null)
            //    {
            //        throw new NaoEncontradoException("Sinistro não encontrado.");
            //    }
            //    _sinistroDAL.Alterar(sinistro,id,data);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }
    }
}
