using CamadaModelagem.Data;
using CamadaModelagem.Models;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Services
{
    public class MultaService
    {
        private readonly MultaDAL _multaDAL;

        public MultaService(MultaDAL multaDAL)
        {
            _multaDAL = multaDAL;
        }

        public bool Cadastrar(Multa multa)
        {
            string cpf = multa.Motorista.CPF;
            string placa = multa.Veiculo.Placa;
            DateTime dataocorrencia = multa.DataOcorrencia;
            try
            {
                Multa obj = _multaDAL.BuscarMulta(placa, cpf, dataocorrencia); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe uma multa com esse dados no sistema!");
                }
                return _multaDAL.Cadastrar(multa);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public Multa BuscarMulta(string placa, string cpf, DateTime dataocorrencia)
        {
            try
            {
                return _multaDAL.BuscarMulta(placa, cpf, dataocorrencia);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Multa> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Multa> multas = new List<Multa>();
            try
            {
                multas.AddRange(_multaDAL.BuscarTodos(dtinicio, dtfim));
                return multas;
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string placa, string cpf, DateTime data)
        {
            try
            {
                return _multaDAL.Deletar(placa,cpf,data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Multa não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public bool Alterar(Multa multa, string placa, string cpf, DateTime data)
        {
            try
            {
                Multa obj = _multaDAL.BuscarMulta(placa, cpf, data); //Falta criar os métodos de busca
                if (obj == null)
                {
                    throw new NaoEncontradoException("Multa não encontrada.");
                }
                return _multaDAL.Alterar(multa, placa, cpf, data);
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
                return _multaDAL.PopularPlacas();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public DataTable PopularCPF()
        {
            try
            {
                return _multaDAL.PopularCPF();
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Veiculo BuscarPlaca(string placa)
        {
            try
            {
                Veiculo veiculo = _multaDAL.BuscarPlacaAlugado(placa);
                if (veiculo == null)
                {
                    veiculo = _multaDAL.BuscarPlaca(placa);
                }
                return veiculo;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Motorista BuscarCPF(string cpf)
        {
            try
            {
                Motorista motorista = _multaDAL.BuscarCPF(cpf);
                return motorista;
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
    }
}
