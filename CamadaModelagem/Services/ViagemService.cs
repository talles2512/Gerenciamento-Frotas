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
    public class ViagemService
    {
        private readonly ViagemDAL _viagemDAL;

        public ViagemService(ViagemDAL viagemDAL)
        {
            _viagemDAL = viagemDAL;
        }

        public void Cadastrar(Viagem viagem, int requisicao)
        {
            //try
            //{
            //    Viagem obj = _viagemDAL.BuscarViagem(requisicao); //Falta criar os métodos de busca
            //    if (obj != null)
            //    {
            //        throw new RegistroExisteException("Já existe uma viagaem com essa Requisição no sistema!");
            //    }
            //    _viagemDAL.Cadastrar(viagem);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }

        public void Deletar(int requisicao)
        {
            try
            {
                _viagemDAL.Deletar(requisicao);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Viagem não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Viagem viagem, int requisicao)
        {
            //try
            //{
            //    Viagem obj = _viagemDAL.BuscarViagem(requisicao); //Falta criar os métodos de busca
            //    if (obj == null)
            //    {
            //        throw new NaoEncontradoException("Viagem não encontrada.");
            //    }
            //    _viagemDAL.Alterar(viagem, requisicao);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }
    }
}
