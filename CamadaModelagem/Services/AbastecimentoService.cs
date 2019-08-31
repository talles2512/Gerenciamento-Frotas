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
    class AbastecimentoService
    {
        private readonly AbastecimentoDAL _abastecimentoDAL;

        public AbastecimentoService(AbastecimentoDAL abastecimentoDAL)
        {
            _abastecimentoDAL = abastecimentoDAL;
        }
        public void Cadastrar(Abastecimento abastecimento) //Mudança na Query, Verificar
        {
            try
            {
                Abastecimento obj = _abastecimentoDAL.BuscarAbastecimento(abastecimento.Veiculo.Placa, abastecimento.Tipo, abastecimento.Data); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um Abastecimento com esses dados no sistema!");
                }
                _abastecimentoDAL.Cadastrar(abastecimento);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public void Deletar(string placa, int tipo, DateTime data)
        {
            try
            {
                _abastecimentoDAL.Deletar(placa, tipo, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Abastecimento não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Abastecimento abastecimento, string placa, int tipo, DateTime data)
        {
            try
            {
                Abastecimento obj = _abastecimentoDAL.BuscarAbastecimento(placa, tipo, data);
                if (obj == null)
                {
                    throw new NaoEncontradoException("Abastecimento não encontrado.");
                }
                _abastecimentoDAL.Alterar(abastecimento, placa, tipo, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
    }
}