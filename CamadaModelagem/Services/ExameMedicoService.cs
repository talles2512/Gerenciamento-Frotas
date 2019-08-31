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
    class ExameMedicoService
    {
        private readonly ExameMedicoDAL _exameMedicoDAL;

        public ExameMedicoService(ExameMedicoDAL exameMedicoDAL)
        {
            _exameMedicoDAL = exameMedicoDAL;
        }
        public void Cadastrar(ExameMedico exameMedico) //Mudança na Query, Verificar
        {
            try
            {
                ExameMedico obj = _exameMedicoDAL.BuscarExameMedico(exameMedico.Motorista.CPF, exameMedico.Data); //Falta criar os métodos de busca
                if (obj != null)
                {
                    throw new RegistroExisteException("Já existe um Exame Médico com esses dados no sistema!");
                }
                _exameMedicoDAL.Cadastrar(exameMedico);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }

        public void Deletar(int cpf, DateTime data)
        {
            try
            {
                _exameMedicoDAL.Deletar(cpf, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new IntegridadeException("Exame Médico não pode ser deletado, pois está ligado a outros serviços.");
            }
        }

        public void Alterar(ExameMedico exameMedico, int cpf, DateTime data)
        {
            try
            {
                ExameMedico obj = _exameMedicoDAL.BuscarExameMedico(cpf, data);
                if (obj == null)
                {
                    throw new NaoEncontradoException("Exame Médico não encontrado.");
                }
                _exameMedicoDAL.Alterar(exameMedico, cpf, data);
            }
            catch (ConcorrenciaBancoException)
            {
                throw new ConcorrenciaBancoException("Favor tentar novamente mais tarde.");
            }
        }
    }
}
