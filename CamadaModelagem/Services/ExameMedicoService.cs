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
    public class ExameMedicoService
    {
        private readonly ExameMedicoDAL _exameMedicoDAL;

        public ExameMedicoService(ExameMedicoDAL exameMedicoDAL)
        {
            _exameMedicoDAL = exameMedicoDAL;
        }
        public bool Cadastrar(ExameMedico exameMedico) //Mudança na Query, Verificar
        {
            try
            {
                ExameMedico obj = _exameMedicoDAL.BuscarExameMedico(exameMedico.Motorista.CPF, exameMedico.Data); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um Exame Médico com esses dados no sistema!");
                }
                return _exameMedicoDAL.Cadastrar(exameMedico);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public ExameMedico BuscarExameMedico(string cpf, DateTime data)
        {
            try
            {
                ExameMedico exameMedico = _exameMedicoDAL.BuscarExameMedico(cpf, data);
                return exameMedico;
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public List<ExameMedico> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<ExameMedico> exames = new List<ExameMedico>();
            try
            {
                exames.AddRange(_exameMedicoDAL.BuscarTodos(dtinicio, dtfim));
                return exames;
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
               return _exameMedicoDAL.Deletar(cpf, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Exame Médico não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public bool Alterar(ExameMedico exameMedico, string cpf, DateTime data)
        {
            try
            {
                ExameMedico obj = _exameMedicoDAL.BuscarExameMedico(cpf, data);
                if (obj == null)
                {
                    throw new NaoEncontradoException("Exame Médico não encontrado.");
                }
                return _exameMedicoDAL.Alterar(exameMedico, cpf, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
    }
}
