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
    class ManutencaoService
    {
        private readonly ManutencaoDAL _manutencaoDAL;

        public ManutencaoService(ManutencaoDAL manutencaoDAL)
        {
            _manutencaoDAL = manutencaoDAL;
        }

        public void Cadastrar(Manutencao manutencao)
        {
            try
            {
                Manutencao obj = _manutencaoDAL.BuscarManutencao(manutencao.Veiculo.Placa,manutencao.Tipo,manutencao.Data); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe uma manutenção com esses dados no sistema!");
                }
                _manutencaoDAL.Cadastrar(manutencao);
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
                _manutencaoDAL.Deletar(placa,tipo,data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Manutenção não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Manutencao manutencao, string placa, int tipo, DateTime data)
        {
            try
            {
                Manutencao obj = _manutencaoDAL.BuscarManutencao(placa,tipo,data); //Falta criar os métodos de busca
                if (obj == null)
                {
                    throw new NaoEncontradoException("Manutencao não encontrada.");
                }
                _manutencaoDAL.Alterar(manutencao,placa,tipo,data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
    }
}
