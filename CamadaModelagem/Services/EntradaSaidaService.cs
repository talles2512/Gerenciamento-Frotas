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
    class EntradaSaidaService
    {
        private readonly EntradaSaidaDAL _entradaSaidaDAL;

        public EntradaSaidaService(EntradaSaidaDAL entradaSaidaDAL)
        {
            _entradaSaidaDAL = entradaSaidaDAL;
        }
        public void Cadastrar(EntradaSaida entsaid) //Mudança na Query, Verificar
        {
            try
            {
                EntradaSaida obj = _entradaSaidaDAL.BuscarEntradaSaida(entsaid.Veiculo.Placa, entsaid.Tipo, entsaid.DataHora); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe uma Entrada/Saída com esses dados no sistema!");
                }
                _entradaSaidaDAL.Cadastrar(entsaid);
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
                _entradaSaidaDAL.Deletar(placa, tipo, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Entrada/Saída não pode ser deletada, pois está ligada a outros serviços.");
            }
        }

        public void Alterar(EntradaSaida entsaid, string placa, int tipo, DateTime data)
        {
            try
            {
                EntradaSaida obj = _entradaSaidaDAL.BuscarEntradaSaida(placa, tipo, data);
                if (obj == null)
                {
                    throw new NaoEncontradoException("Entrada/Saída não encontrada.");
                }
                _entradaSaidaDAL.Alterar(entsaid, placa, tipo, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
    }
}
