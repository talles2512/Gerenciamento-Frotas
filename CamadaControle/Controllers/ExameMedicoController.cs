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
    public class ExameMedicoController
    {
        private readonly ExameMedicoService _exameMedicoService;

        public ExameMedicoController(ExameMedicoService exameMedicoService)
        {
            _exameMedicoService = exameMedicoService;
        }

        #region [AplicacaoDesktop]
        public bool Cadastrar(ExameMedico exameMedico) //Mudança na Query, Verificar
        {           
            try
            {
                return _exameMedicoService.Cadastrar(exameMedico);
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

        public ExameMedico BuscarExameMedico(string cpf, DateTime data)
        {
            try
            {
                return _exameMedicoService.BuscarExameMedico(cpf, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<ExameMedico> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            try
            {
                return _exameMedicoService.BuscarTodos(dtinicio, dtfim);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public bool Deletar(string cpf, DateTime data)
        {            
            try
            {
                return _exameMedicoService.Deletar(cpf, data);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }

        }

        public bool Alterar(ExameMedico exameMedico, string cpf, DateTime data)
        {          
            try
            {
                return _exameMedicoService.Alterar(exameMedico, cpf, data);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
