using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
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

        public bool Cadastrar(Sinistro sinistro, int id, DateTime data, string item, long numapolice, string tipo)
        {
            try
            {
                Sinistro obj = _sinistroDAL.BuscarSinistro(id, data, item, tipo); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um sinistro com esse dados no sistema!");
                }
                return _sinistroDAL.Cadastrar(sinistro, numapolice);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        public Sinistro BuscarSinistro(int id, DateTime data, string item, string tipo)
        {
            try
            {
                return _sinistroDAL.BuscarSinistro(id, data, item, tipo);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Sinistro> BuscarTodos(string tipo, DateTime dtinicio, DateTime dtfim)
        {
            List<Sinistro> sinistros = new List<Sinistro>();
            try
            {
                sinistros.AddRange(_sinistroDAL.BuscarTodos(tipo, dtinicio, dtfim));
                return sinistros;
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(Sinistro sinistro, int id, DateTime data, string tipo)
        {
            try
            {
                return _sinistroDAL.Deletar(sinistro, id, data, tipo);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Sinistro não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public bool Alterar(Sinistro sinistro, int id, string item, DateTime data, long numapolice, string tipo)
        {
            try
            {
                Sinistro obj = _sinistroDAL.BuscarSinistro(id, data, item, tipo); //Falta criar os métodos de busca
                if (obj == null)
                {
                    throw new NaoEncontradoException("Sinistro não encontrado.");
                }
                return _sinistroDAL.Alterar(sinistro, id, data, numapolice, tipo);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public int PopulaID(string tipo)
        {
            try
            {
                return _sinistroDAL.PopulaID(tipo);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        public DataTable PopularPlacas()
        {
            try
            {
                return _sinistroDAL.PopularPlacas();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public DataTable PopularCPFs()
        {
            try
            {
                return _sinistroDAL.PopularCPFs();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public DataTable PopularSeguroCPFs(string cpf)
        {
            try
            {
                return _sinistroDAL.PopularSeguroCPFs(cpf);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public DataTable PopularSeguroPlacas(string placa)
        {
            try
            {
                return _sinistroDAL.PopularSeguroPlacas(placa);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Seguro BuscarSeguro(TipoSeguro tipo, long numeroApolice)
        {
            try
            {
                return _sinistroDAL.BuscarSeguro(tipo, numeroApolice);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
