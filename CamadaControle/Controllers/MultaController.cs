using CamadaModelagem.Models;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    public class MultaController
    {
        private readonly MultaService _multaService;

        public MultaController(MultaService multaService)
        {
            _multaService = multaService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(Multa multa)
        {          
            try
            {
                return _multaService.Cadastrar(multa);
            }
            catch (RegistroExisteException e)
            {
                throw new RegistroExisteException(e.Message);
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
                return _multaService.BuscarMulta(placa, cpf, dataocorrencia);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Multa> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _multaService.BuscarTodos(dtinicio, dtfim);
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
                return _multaService.Deletar(placa, cpf, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }

        }

        public bool Alterar(Multa multa, string placa, string cpf, DateTime data)
        {          
            try
            {
                return _multaService.Alterar(multa, placa, cpf, data);
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
                return _multaService.PopularPlacas();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
        
        public DataTable PopularCPF()
        {
            try
            {
                return _multaService.PopularCPF();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public Veiculo BuscarPlaca(string placa)
        {
            try
            {
                return _multaService.BuscarPlaca(placa);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public Motorista BuscarCPF(string cpf)
        {
            try
            {
                return _multaService.BuscarCPF(cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        #endregion

        #region [AplicacaoWeb]

        #endregion
    }
}
