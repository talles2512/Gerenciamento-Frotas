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
    public class ServicoExternoConveniadoService
    {
        private readonly ServicoExternoConveniadoDAL _servicoExternoConveniadoDAL;

        public ServicoExternoConveniadoService(ServicoExternoConveniadoDAL servicoExternoConveniadoDAL)
        {
            _servicoExternoConveniadoDAL = servicoExternoConveniadoDAL;
        }
        public void Cadastrar(ServicoExternoConveniado servicoExternoConveniado) //Mudança na Query, Verificar
        {
            //try
            //{
            //    ServicoExternoConveniado obj = _servicoExternoConveniadoDAL.BuscarCNPJ(servicoExternoConveniado.ServicoExterno.CNPJ); //Falta criar os métodos de busca
            //    if (obj != null)
            //    {
            //        throw new RegistroExisteException("Já existe um Convenio Externo com esses dados no sistema!");
            //    }
            //    _servicoExternoConveniadoDAL.Cadastrar(servicoExternoConveniado);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }

        public void Deletar(int cnpj)
        {
            //try
            //{
            //    _servicoExternoConveniadoDAL.Deletar(cnpj);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new IntegridadeException("Convenio não pode ser deletado, pois está ligado a outros serviços.");
            //}
        }

        public void Alterar(ServicoExternoConveniado servicoExternoConveniado, int cnpj)
        {
            //try
            //{
            //    ServicoExternoConveniado obj = _servicoExternoConveniadoDAL.BuscarCNPJ(cnpj); //Falta criar os métodos de busca
            //    if (obj == null)
            //    {
            //        throw new NaoEncontradoException("Convenio não encontrado.");
            //    }
            //    _servicoExternoConveniadoDAL.Alterar(servicoExternoConveniado, cnpj);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }
    }
}
