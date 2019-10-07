using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Services.Exceptions;

namespace CamadaModelagem.Data
{
    public class MotoristaDAL
    {
        private readonly Banco _banco;

        public MotoristaDAL(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Motorista motorista, CNH cnh) //Mudança na Query, Verificar
        {
            string query = "INSERT INTO[dbo].[TB_MOTORISTA]([MT_CPF],[MT_NOME],[MT_RG],[MT_ENDERECO],[MT_DTNASCIMENTO],[MT_TELEFONE],[MT_TELEFONE_RECADO],[MT_SITUACAO],[MT_CNH_NUMERO])" +
                "VALUES (" + motorista.CPF + ", '" + motorista.Name + "', '" + motorista.RG + "', '" + motorista.Endereco + "', '" + motorista.DataNascimento + "', " + motorista.Telefone + ", " + motorista.TelefoneContato + ", " + motorista.Situacao + "," + cnh.Numero + ") GO" +
                "INSERT INTO [dbo].[TB_CNH]([CNH_NUMERO],[CNH_DTEMISSAO],[CNH_DTVENC],[CNH_CATEGORIA],[CNH_ORGAOEMISSOR],[CNH_MT_CPF])" +
                "VALUES (" + cnh.Numero + ", '" + cnh.DataEmissao + "', '" + cnh.DataVencimento + "', '" + cnh.Categoria + "', '" + cnh.OrgaoEmissor + "', '" + motorista.CPF + ")";
            try
            {
                _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public void Deletar(int cpf) //Mudança na Query, Verificar
        {
            string Query = "DELETE [TB_MOTORISTA],[TB_CNH] WHERE [TB_MOTORISTA].[MT_CPF] = " + cpf + " AND [TB_CNH].[CNH_MT_CPF] = " + cpf;
            // Como deletar tabela de CNH a partir da Veiculos ?
            try
            {
                _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public void Alterar(Motorista motorista, CNH cnh, int cpf) //Mudança na Query, Verificar
        {
            string Query = "UPDATE [TB_MOTORISTA] SET [MT_CPF] =" + motorista.CPF + ", [MT_NOME] = '" + motorista.Name + "', [MT_RG] = '" + motorista.RG + "', [MT_ENDERECO] = '" + motorista.RG + "', [MT_ENDERECO] ='" + motorista.Endereco + "', [MT_DTNASCIMENTO] = '" + motorista.DataNascimento + "',[MT_TELEFONE] = " + motorista.Telefone + ", [MT_TELEFONE_RECADO] = " + motorista.TelefoneContato + ", [MT_SITUACAO] = " + motorista.Situacao + ", [MT_CNH_NUMERO] =" + cnh.Numero + " WHERE [MT_CPF] = " + cpf + "; GO" +
                "UPDATE [TB_CNH] SET [CNH_NUMERO] =" + cnh.Numero + ", [CNH_DTEMISSAO] = '" + cnh.DataEmissao + "', [CNH_DTVENC] '" + cnh.DataVencimento + "', [CNH_CATEGORIA] ='" + cnh.Categoria + "', [CNH_ORGAOEMISSOR] = '" + cnh.OrgaoEmissor + "' , [CNH_MT_CPF] = " + motorista.CPF + " WHERE [CNH_MT_CPF] = " + cpf;
            _banco.ExecutarInstrucao(Query);
        }
    }
}
