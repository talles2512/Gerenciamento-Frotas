using CamadaModelagem.Data;
using CamadaModelagem.Modelagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Services
{
    class FuncionarioService
    {
        private readonly Banco _banco;

        public FuncionarioService(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Funcionario funcionario) 
        {
            string query = "INSERT INTO [dbo].[TB_FUNCIONARIO] ([FUNC_NOME],[FUNC_LOGIN],[FUNC_SENHA],[FUNC_PERFIL_ACESSO])" +
                "VALUES ('" + funcionario.Nome + "', '" + funcionario.Login + "', '" + funcionario.Senha + "', " + funcionario.PerfilAcesso + ")";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(string login) //Podemos usar na clausula WHERE o NOME ou LOGIN
        {
            string Query = "DELETE [dbo].[TB_FUNCIONARIO] WHERE [FUNC_LOGIN] = '" + login + "' ";
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(Funcionario funcionario, string login)
        {
            string Query = "UPDATE [dbo].[TB_FUNCIONARIO] SET [FUNC_NOME]= '" + funcionario.Nome + "',[FUNC_LOGIN]= '" + funcionario.Login + "',[FUNC_SENHA] '" + funcionario.Senha + "',[FUNC_PERFIL_ACESSO]= " + funcionario.PerfilAcesso + " WHERE [FUNC_LOGIN]= '" +login;
            _banco.ExecutarInstrucao(Query);
        }
    }
}
