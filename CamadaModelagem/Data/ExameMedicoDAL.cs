using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Models.Enums;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Data
{
    public class ExameMedicoDAL
    {
        private readonly Banco _banco;
        Motorista motorista = null;

        public ExameMedicoDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(ExameMedico examemedico)
        {
            int situacaoexame = examemedico.Situacao.GetHashCode();
            string query = "INSERT INTO[dbo].[TB_EXAMEDICO] ([EXAM_DATA],[EXAM_DESCRICAO],[EXAM_SITUACAO],[EXAM_MT_CPF])" +
                "VALUES ('" + examemedico.Data + "', '" + examemedico.Descricao + "', " + situacaoexame + ", '" + examemedico.Motorista.CPF + "')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public ExameMedico BuscarExameMedico(string cpf, DateTime data)
        {
            string query = "SELECT * FROM [dbo].[TB_EXAMEDICO] WHERE [EXAM_DATA] = '" + data + "' AND [EXAM_MT_CPF] = '" + cpf + "'";

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);

                ExameMedico exameMedico = null;
                DataRow[] dataRows = dt.Select("EXAM_DATA = '" + data + "' AND EXAM_MT_CPF = '" + cpf + "'");
                foreach (DataRow dr in dataRows)
                {
                    DateTime dataexame = Convert.ToDateTime(dr["EXAM_DATA"].ToString());
                    SituacaoExameMedico situacaoExameMedico = (SituacaoExameMedico)Enum.Parse(typeof(SituacaoExameMedico), dr["EXAM_SITUACAO"].ToString());
                    motorista = new Motorista();
                    motorista.CPF = dr["EXAM_MT_CPF"].ToString();

                    exameMedico = new ExameMedico(dataexame, dr["EXAM_DESCRICAO"].ToString(), situacaoExameMedico, motorista);
                }

                return exameMedico;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<ExameMedico> BuscarTodos()
        {
            List<ExameMedico> exames = new List<ExameMedico>();
            string query = "SELECT* FROM[dbo].[TB_EXAMEDICO]";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                ExameMedico exameMedico = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    DateTime dataexame = Convert.ToDateTime(dr["EXAM_DATA"].ToString());
                    SituacaoExameMedico situacaoExameMedico = (SituacaoExameMedico)Enum.Parse(typeof(SituacaoExameMedico), dr["EXAM_SITUACAO"].ToString());
                    motorista = new Motorista();
                    motorista.CPF = dr["EXAM_MT_CPF"].ToString();

                    exameMedico = new ExameMedico(dataexame, dr["EXAM_DESCRICAO"].ToString(), situacaoExameMedico, motorista);
                    exames.Add(exameMedico);
                }
                return exames;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public bool Deletar(string cpf, DateTime data) //Modificado
        {
            string query = "DELETE [dbo].[TB_EXAMEDICO] WHERE [EXAM_MT_CPF] = '" + cpf + "' AND [EXAM_DATA] = '" + data + "'";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(ExameMedico examemedico, string cpf, DateTime data) // Modificado
        {
            string query = "UPDATE [dbo].[TB_EXAMEDICO] SET [EXAM_DATA] = '" + examemedico.Data + "',[EXAM_DESCRICAO]= '" + examemedico.Descricao + "',[EXAM_SITUACAO]= " + examemedico.Situacao + ",[EXAM_MT_CPF]= '" + examemedico.Motorista.CPF + "' WHERE [EXAM_MT_CPF] = '" + cpf + "' AND [EXAM_DATA] = '" + data + "'";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }
    }
}
