using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
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
    public class ManutencaoController
    {
        private readonly ManutencaoService _manutencaoService;

        public ManutencaoController(ManutencaoService manutencaoService)
        {
            _manutencaoService = manutencaoService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(Manutencao manutencao, string placa, ManutencaoTipo tipo, DateTime data)
        {
            try
            {
                return _manutencaoService.Cadastrar(manutencao, placa, tipo, data);
            }
            catch (RegistroExisteException e)
            {
                throw new RegistroExisteException(e.Message);
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
                return _manutencaoService.BuscarManutencao(placa, tipo, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Manutencao> BuscarTodos()
        {
            try
            {
                return _manutencaoService.BuscarTodos();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public void Deletar(string placa, int tipo, DateTime data)
        {
            _manutencaoService.Deletar(placa, tipo, data);
        }

        public void Alterar(Manutencao manutencao, string placa, int tipo, DateTime data)
        {
            _manutencaoService.Alterar(manutencao, placa, tipo, data);
        }

        public DataTable PopularPlacas()
        {
            try
            {
                return _manutencaoService.PopularPlacas();
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public DataTable PopularServicosExternos()
        {
            try
            {
                return _manutencaoService.PopularServicosExternos();
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
