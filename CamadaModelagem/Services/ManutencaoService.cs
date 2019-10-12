using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Services
{
    public class ManutencaoService
    {
        private readonly ManutencaoDAL _manutencaoDAL;

        public ManutencaoService(ManutencaoDAL manutencaoDAL)
        {
            _manutencaoDAL = manutencaoDAL;
        }

        public bool Cadastrar(Manutencao manutencao, string placa, ManutencaoTipo tipo, DateTime data)
        {
            try
            {
                Manutencao obj = _manutencaoDAL.BuscarManutencao(placa, tipo, data);
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe uma Manutenção com esses dados no sistema!");
                }

                return _manutencaoDAL.Cadastrar(manutencao);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Manutencao BuscarManutencao(string placa, ManutencaoTipo tipo, DateTime data)
        {
            try
            {
                return _manutencaoDAL.BuscarManutencao(placa, tipo, data);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Manutencao> BuscarTodos()
        {
            List<Manutencao> manutencoes = new List<Manutencao>();
            try
            {
                manutencoes.AddRange(_manutencaoDAL.BuscarTodos());
                return manutencoes;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public void Deletar(string placa, int tipo, DateTime data)
        {
            //try
            //{
            //    _manutencaoDAL.Deletar(placa,tipo,data);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new IntegridadeException("Manutenção não pode ser deletado, pois está ligado a outros serviços.");
            //}
        }

        public void Alterar(Manutencao manutencao, string placa, int tipo, DateTime data)
        {
            //try
            //{
            //    Manutencao obj = _manutencaoDAL.BuscarManutencao(placa,tipo,data); //Falta criar os métodos de busca
            //    if (obj == null)
            //    {
            //        throw new NaoEncontradoException("Manutencao não encontrada.");
            //    }
            //    _manutencaoDAL.Alterar(manutencao,placa,tipo,data);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }

        public DataTable PopularPlacas()
        {
            try
            {
                return _manutencaoDAL.PopularPlacas();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public DataTable PopularServicosExternos()
        {
            try
            {
                return _manutencaoDAL.PopularServicosExternos();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
