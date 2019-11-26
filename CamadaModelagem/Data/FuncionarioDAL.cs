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
    public class FuncionarioDAL
    {
        private readonly Banco _banco;

        public FuncionarioDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(Funcionario funcionario)
        {
            int perfilacesso = funcionario.PerfilAcesso.GetHashCode();
            DateTime datareg = DateTime.Now;

            string query = "INSERT INTO [dbo].[TB_FUNCIONARIO] ([FUNC_NOME],[FUNC_LOGIN],[FUNC_SENHA],[FUNC_PERFIL_ACESSO],[FUNC_DATAREGISTRO])" +
                "VALUES ('" + funcionario.Nome + "', '" + funcionario.Login + "', '" + funcionario.Senha + "', " + perfilacesso + ", '" + datareg.ToShortDateString() +"')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Funcionario BuscarLogin(string login)
        {
            string query = "SELECT * FROM [dbo].[TB_FUNCIONARIO] WHERE [FUNC_LOGIN] = '" + login + "'";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Funcionario funcionario = null;
                DataRow[] dataRows = dt.Select("FUNC_LOGIN = '" + login + "'");
                
                foreach (DataRow dr in dataRows)
                {
                    PerfilAcesso perfilacesso = (PerfilAcesso)Enum.Parse(typeof(PerfilAcesso), dr["FUNC_PERFIL_ACESSO"].ToString());

                    funcionario = new Funcionario(dr["FUNC_NOME"].ToString(), dr["FUNC_LOGIN"].ToString(), dr["FUNC_SENHA"].ToString(), perfilacesso);
                }

                return funcionario;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public List<Funcionario> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            string query = "SELECT * FROM [dbo].[TB_FUNCIONARIO] WHERE" +
                    "((YEAR([FUNC_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR([FUNC_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                    "AND MONTH([FUNC_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH([FUNC_DATAREGISTRO]) <= '" + dtfim.Month + "')";

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Funcionario funcionario = null;
                DataRow[] dataRows = dt.Select();

                foreach (DataRow dr in dataRows)
                {
                    PerfilAcesso perfilAcesso = (PerfilAcesso)Enum.Parse(typeof(PerfilAcesso), dr["FUNC_PERFIL_ACESSO"].ToString());

                    funcionario = new Funcionario(dr["FUNC_NOME"].ToString(), dr["FUNC_LOGIN"].ToString(), dr["FUNC_SENHA"].ToString(), perfilAcesso);
                    funcionarios.Add(funcionario);
                }
                return funcionarios;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }

        public bool Deletar(string login) //Podemos usar na clausula WHERE o NOME ou LOGIN
        {
            string Query = "DELETE [dbo].[TB_FUNCIONARIO] WHERE [FUNC_LOGIN] = '" + login + "' ";
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Alterar(Funcionario funcionario, string login)
        {
            int perfilacesso = funcionario.PerfilAcesso.GetHashCode();
            string Query = "UPDATE [dbo].[TB_FUNCIONARIO] SET [FUNC_NOME]= '" + funcionario.Nome + "',[FUNC_LOGIN]= '" + funcionario.Login + "',[FUNC_SENHA] ='" + funcionario.Senha + "',[FUNC_PERFIL_ACESSO]= " + perfilacesso + " WHERE [FUNC_LOGIN]= '" + login + "'";
            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Funcionario> Pesquisar(string busca)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            if (busca == "")
            {
                return funcionarios;
            }
            string query = "SELECT * FROM[dbo].[TB_FUNCIONARIO] WHERE(FUNC_NOME LIKE '%" + busca + "%'" +
                " OR FUNC_LOGIN LIKE '%" + busca + "%')";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Funcionario funcionario = null;
                DataRow[] dataRows = dt.Select();

                foreach (DataRow dr in dataRows)
                {
                    PerfilAcesso perfilAcesso = (PerfilAcesso)Enum.Parse(typeof(PerfilAcesso), dr["FUNC_PERFIL_ACESSO"].ToString());

                    funcionario = new Funcionario(dr["FUNC_NOME"].ToString(), dr["FUNC_LOGIN"].ToString(), dr["FUNC_SENHA"].ToString(), perfilAcesso);
                    funcionarios.Add(funcionario);
                }
                return funcionarios;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }
    }
}
