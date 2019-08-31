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
    class ServicoExternoService
    {
        private readonly ServicoExternoDAL _servicoExternoDAL;

        public ServicoExternoService(ServicoExternoDAL servicoExternoDAL)
        {
            _servicoExternoDAL = servicoExternoDAL;
        }
        public void Cadastrar(ServicoExterno servicoExterno) //Mudança na Query, Verificar
        {
            try
            {
                ServicoExterno obj = _servicoExternoDAL.BuscarCNPJ(servicoExterno.CNPJ); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um Serviço Externo com esses dados no sistema!");
                }
                _servicoExternoDAL.Cadastrar(servicoExterno);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public void Deletar(int cnpj)
        {
            try
            {
                _servicoExternoDAL.Deletar(cnpj);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Serviço Externo não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(ServicoExterno servicoExterno, int cnpj)
        {
            try
            {
                ServicoExterno obj = _servicoExternoDAL.BuscarCNPJ(cnpj); //Falta criar os métodos de busca
                if (obj == null)
                {
                    throw new NaoEncontradoException("Serviço Externo não encontrado.");
                }
                _servicoExternoDAL.Alterar(servicoExterno, cnpj);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
    }
}
