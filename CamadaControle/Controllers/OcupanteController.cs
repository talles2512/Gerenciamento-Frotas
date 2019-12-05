using CamadaModelagem.Models;
using CamadaModelagem.Services;
using CamadaModelagem.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    public class OcupanteController
    {
        private readonly OcupanteService _ocupanteService;

        public OcupanteController(OcupanteService ocupanteService)
        {
            _ocupanteService = ocupanteService;
        }

        #region [AplicacaoDesktop]

        public void Cadastrar(Ocupante ocupante)
        {
            _ocupanteService.Cadastrar(ocupante);
        }

        public Ocupante BuscarOcupante(int req,string cpf)
        {
            try
            {
                return _ocupanteService.BuscarOcupante(req,cpf);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<Ocupante> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _ocupanteService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public void Deletar(int cpf)
        {
            _ocupanteService.Deletar(cpf);
        }

        public void Alterar(Ocupante ocupante, int cpf)
        {
            _ocupanteService.Alterar(ocupante,cpf);
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
