using CamadaModelagem.Models;
using CamadaModelagem.Services;
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

        #region AplicacaoDesktop
        public void Cadastrar(ExameMedico exameMedico) //Mudança na Query, Verificar
        {
            _exameMedicoService.Cadastrar(exameMedico);
        }

        public void Deletar(int cpf, DateTime data)
        {
            _exameMedicoService.Deletar(cpf, data);
        }

        public void Alterar(ExameMedico exameMedico, int cpf, DateTime data)
        {
            _exameMedicoService.Alterar(exameMedico, cpf, data);
        }

        #endregion

        #region AplicacaoWeb



        #endregion
    }
}
