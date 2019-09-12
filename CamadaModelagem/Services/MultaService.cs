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
    public class MultaService
    {
        private readonly MultaDAL _multaDAL;

        public MultaService(MultaDAL multaDAL)
        {
            _multaDAL = multaDAL;
        }

        public void Cadastrar(Multa multa)
        {
            //try
            //{
            //    Multa obj = _multaDAL.BuscarMulta(multa.Veiculo.Placa,multa.Motorista.CPF,multa.DataOcorrencia); //Falta criar os métodos de busca
            //    if (obj != null)
            //    {
            //        throw new RegistroExisteException("Já existe uma multa com esse dados no sistema!");
            //    }
            //    _multaDAL.Cadastrar(multa);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }

        public void Deletar(string placa, int cpf, DateTime data)
        {
            try
            {
                _multaDAL.Deletar(placa,cpf,data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Multa não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(Multa multa, string placa, int cpf, DateTime data)
        {
            //try
            //{
            //    Multa obj = _multaDAL.BuscarMulta(placa,cpf,data); //Falta criar os métodos de busca
            //    if (obj == null)
            //    {
            //        throw new NaoEncontradoException("Multa não encontrada.");
            //    }
            //    _multaDAL.Alterar(multa,placa,cpf,data);
            //}
            //catch (ConcorrenciaBancoException)
            //{
            //    throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            //}
        }
    }
}
