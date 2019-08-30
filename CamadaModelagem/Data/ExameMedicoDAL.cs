using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;

namespace CamadaModelagem.Data
{
    class ExameMedicoDAL
    {
        private readonly Banco _banco;

        public ExameMedicoDAL(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(ExameMedico examemedico)
        {
            string query = "INSERT INTO[dbo].[TB_EXAMEDICO] ([EXAM_DATA],[EXAM_DESCRICAO],[EXAM_SITUACAO],[EXAM_MT_CPF])" +
                "VALUES ('" + examemedico.Data + "', '" + examemedico.Descricao + "', " + examemedico.Situacao + ", " + examemedico.Motorista.CPF + ")";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(int cpf, DateTime data) //Modificado
        {
            string Query = "DELETE [dbo].[TB_EXAMEDICO] WHERE [EXAM_MT_CPF] = " + cpf + " AND [EXAM_DATA] = '" + data + "'";
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(ExameMedico examemedico, int cpf, DateTime data) // Modificado
        {
            string Query = "UPDATE [dbo].[TB_EXAMEDICO] SET [EXAM_DATA] = '" + examemedico.Data + "',[EXAM_DESCRICAO]= '" + examemedico.Descricao + "',[EXAM_SITUACAO]= " + examemedico.Situacao + ",[EXAM_MT_CPF]= " + examemedico.Motorista.CPF + " WHERE [EXAM_MT_CPF] = " + cpf + " AND [EXAM_DATA] = '" + data + "'";
            _banco.ExecutarInstrucao(Query);
        }
    }
}
