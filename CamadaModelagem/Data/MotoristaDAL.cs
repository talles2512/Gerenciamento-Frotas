using System;
using System.Collections.Generic;
using System.Data;
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
        CNH cNH = new CNH();

        public MotoristaDAL(Banco banco)
        {
            _banco = banco;
        }

        public bool Cadastrar(Motorista motorista, CNH cnh) //Mudança na Query, Verificar
        {
            int situacao = Convert.ToInt32(motorista.Situacao);
            string datanascimento = motorista.DataNascimento.ToString("yyyy/MM/dd");
            string dtemissao = cnh.DataEmissao.ToString("yyyy/MM/dd");
            string dtvencimento = cnh.DataVencimento.ToString("yyyy/MM/dd");
            DateTime datareg = DateTime.Now;

            string query = "INSERT INTO[dbo].[TB_MOTORISTA]([MT_CPF],[MT_NOME],[MT_RG],[MT_ENDERECO],[MT_DTNASCIMENTO],[MT_TELEFONE],[MT_TELEFONE_RECADO],[MT_SITUACAO],[MT_DATAREGISTRO])" +
                "VALUES ('" + motorista.CPF + "', '" + motorista.Name + "', '" + motorista.RG + "', '" + motorista.Endereco + "', '" + datanascimento + "', " + motorista.Telefone + ", " + motorista.TelefoneContato + ", " + situacao + ",'" + datareg.ToShortDateString() +"')" +
                "INSERT INTO [dbo].[TB_CNH]([CNH_NUMERO],[CNH_DTEMISSAO],[CNH_DTVENC],[CNH_CATEGORIA],[CNH_ORGAOEMISSOR],[CNH_MT_CPF])" +
                "VALUES (" + cnh.Numero + ", '" + dtemissao + "', '" + dtvencimento + "', '" + cnh.Categoria + "', '" + cnh.OrgaoEmissor + "', '" + motorista.CPF + "')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public bool Inativar(string cpf, bool sit) //Alterado, Validar
        {
            if (sit)
            {
                string Query = "UPDATE [TB_MOTORISTA] SET [MT_SITUACAO] = 0 WHERE [MT_CPF] = '" + cpf + "' ";

                try
                {
                    return _banco.ExecutarInstrucao(Query);
                }
                catch (ConcorrenciaBancoException e)
                {
                    throw new ConcorrenciaBancoException(e.Message);
                }
            }
            else
            {
                string Query = "UPDATE [TB_MOTORISTA] SET [MT_SITUACAO] = 1 WHERE [MT_CPF] = '" + cpf + "' ";

                try
                {
                    return _banco.ExecutarInstrucao(Query);
                }
                catch (ConcorrenciaBancoException e)
                {
                    throw new ConcorrenciaBancoException(e.Message);
                }
            }
        }

        public bool Alterar(Motorista motorista, CNH cnh, string cpf) //Mudança na Query, Verificar
        {
            int situacao = Convert.ToInt32(motorista.Situacao);
            string datanascimento = motorista.DataNascimento.ToString("yyyy/MM/dd");
            string dtemissao = cnh.DataEmissao.ToString("yyyy/MM/dd");
            string dtvencimento = cnh.DataVencimento.ToString("yyyy/MM/dd");

            string Query = "UPDATE [TB_MOTORISTA] SET [MT_CPF] ='" + cpf + "', [MT_NOME] = '" + motorista.Name + "', [MT_RG] = '" + motorista.RG + "', [MT_ENDERECO] = '" + motorista.Endereco + "', [MT_DTNASCIMENTO] = '" + datanascimento + "',[MT_TELEFONE] = " + motorista.Telefone + ", [MT_TELEFONE_RECADO] = " + motorista.TelefoneContato + ", [MT_SITUACAO] = " + situacao + "  WHERE [MT_CPF] = '" + cpf + "';" +
                "UPDATE [TB_CNH] SET [CNH_NUMERO] =" + cnh.Numero + ", [CNH_DTEMISSAO] = '" + dtemissao + "', [CNH_DTVENC] = '" + dtvencimento + "', [CNH_CATEGORIA] ='" + cnh.Categoria + "', [CNH_ORGAOEMISSOR] = '" + cnh.OrgaoEmissor + "' , [CNH_MT_CPF] = '" + cpf + "' WHERE [CNH_MT_CPF] = '" + cpf +"'";

            try
            {
                return _banco.ExecutarInstrucao(Query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public Motorista BuscarCPF(string cpf)
        {
            string query = "SELECT M.[MT_CPF], M.[MT_NOME], M.[MT_RG], M.[MT_ENDERECO], M.[MT_DTNASCIMENTO], M.[MT_TELEFONE], M.[MT_TELEFONE_RECADO]" +
                ", M.[MT_SITUACAO], C.[CNH_NUMERO], C.[CNH_DTEMISSAO], C.[CNH_DTVENC], C.[CNH_CATEGORIA], C.[CNH_ORGAOEMISSOR], C.[CNH_MT_CPF]" +
                "FROM [TB_MOTORISTA] AS M JOIN [TB_CNH] AS C ON M.[MT_CPF] = C.[CNH_MT_CPF] WHERE M.[MT_CPF] = '" + cpf + "'";

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);

                Motorista motorista = null;
                DataRow[] dataRows = dt.Select("MT_CPF = '" + cpf + "'");
                foreach (DataRow dr in dataRows)
                {
                    DateTime dtnascimento = Convert.ToDateTime(dr["MT_DTNASCIMENTO"].ToString());
                    long telefone = long.Parse(dr["MT_TELEFONE"].ToString());
                    long telefonerecado = long.Parse(dr["MT_TELEFONE_RECADO"].ToString());
                    bool situacao = bool.Parse(dr["MT_SITUACAO"].ToString());
                    cNH.Numero = long.Parse(dr["CNH_NUMERO"].ToString());
                    cNH.DataEmissao = Convert.ToDateTime(dr["CNH_DTEMISSAO"].ToString());
                    cNH.DataVencimento = Convert.ToDateTime(dr["CNH_DTVENC"].ToString());
                    cNH.Categoria = dr["CNH_CATEGORIA"].ToString();
                    cNH.OrgaoEmissor = dr["CNH_ORGAOEMISSOR"].ToString();

                   motorista = new Motorista(dr["MT_CPF"].ToString(), dr["MT_NOME"].ToString(), dr["MT_RG"].ToString(), dr["MT_ENDERECO"].ToString(), dtnascimento, telefone, telefonerecado, situacao, cNH);
                }
               
                return motorista;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }  
        }

        public List<Motorista> BuscarTodos(DateTime dtinicio, DateTime dtfim)
        {
            List<Motorista> motoristas = new List<Motorista>();
            string query = "SELECT M.[MT_CPF], M.[MT_NOME], M.[MT_RG], M.[MT_ENDERECO], M.[MT_DTNASCIMENTO], M.[MT_TELEFONE], M.[MT_TELEFONE_RECADO]" +
                ", M.[MT_SITUACAO], C.[CNH_NUMERO], C.[CNH_DTEMISSAO], C.[CNH_DTVENC], C.[CNH_CATEGORIA], C.[CNH_ORGAOEMISSOR], C.[CNH_MT_CPF]" +
                "FROM [TB_MOTORISTA] AS M JOIN [TB_CNH] AS C ON M.[MT_CPF] = C.[CNH_MT_CPF] WHERE" +
                "((YEAR(M.[MT_DATAREGISTRO]) >= '" + dtinicio.Year + "' AND YEAR(M.[MT_DATAREGISTRO]) <= '" + dtfim.Year + "')" +
                "AND MONTH(M.[MT_DATAREGISTRO]) >= '" + dtinicio.Month + "' AND MONTH(M.[MT_DATAREGISTRO]) <= '" + dtfim.Month + "')";


            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Motorista motorista = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    DateTime dtnascimento = Convert.ToDateTime(dr["MT_DTNASCIMENTO"].ToString());
                    long telefone = long.Parse(dr["MT_TELEFONE"].ToString());
                    long telefonerecado = long.Parse(dr["MT_TELEFONE_RECADO"].ToString());
                    bool situacao = bool.Parse(dr["MT_SITUACAO"].ToString());
                    cNH.Numero = long.Parse(dr["CNH_NUMERO"].ToString());
                    cNH.DataEmissao = Convert.ToDateTime(dr["CNH_DTEMISSAO"].ToString());
                    cNH.DataVencimento = Convert.ToDateTime(dr["CNH_DTVENC"].ToString());
                    cNH.Categoria = dr["CNH_CATEGORIA"].ToString();
                    cNH.OrgaoEmissor = dr["CNH_ORGAOEMISSOR"].ToString();
                    motorista = new Motorista(dr["MT_CPF"].ToString(), dr["MT_NOME"].ToString(), dr["MT_RG"].ToString(), dr["MT_ENDERECO"].ToString(), dtnascimento, telefone, telefonerecado, situacao, cNH);
                    motoristas.Add(motorista);
                }
               
                return motoristas;
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public List<Motorista> Pesquisar(string busca)
        {
            List<Motorista> motoristas = new List<Motorista>();
            if (busca == "")
            {
                return motoristas;
            }
            string query = "SELECT M.[MT_CPF], M.[MT_NOME], M.[MT_RG], M.[MT_ENDERECO], M.[MT_DTNASCIMENTO], M.[MT_TELEFONE], M.[MT_TELEFONE_RECADO]" +
                ", M.[MT_SITUACAO], C.[CNH_NUMERO], C.[CNH_DTEMISSAO], C.[CNH_DTVENC], C.[CNH_CATEGORIA], C.[CNH_ORGAOEMISSOR], C.[CNH_MT_CPF]" +
                "FROM [TB_MOTORISTA] AS M JOIN [TB_CNH] AS C ON M.[MT_CPF] = C.[CNH_MT_CPF] WHERE(MT_CPF LIKE '%" + busca + "%'" +
                " OR MT_NOME LIKE '%" + busca + "%' OR MT_ENDERECO LIKE '%" + busca + "%')";
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Motorista motorista = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    DateTime dtnascimento = Convert.ToDateTime(dr["MT_DTNASCIMENTO"].ToString());
                    long telefone = long.Parse(dr["MT_TELEFONE"].ToString());
                    long telefonerecado = long.Parse(dr["MT_TELEFONE_RECADO"].ToString());
                    bool situacao = bool.Parse(dr["MT_SITUACAO"].ToString());
                    cNH.Numero = long.Parse(dr["CNH_NUMERO"].ToString());
                    cNH.DataEmissao = Convert.ToDateTime(dr["CNH_DTEMISSAO"].ToString());
                    cNH.DataVencimento = Convert.ToDateTime(dr["CNH_DTVENC"].ToString());
                    cNH.Categoria = dr["CNH_CATEGORIA"].ToString();
                    cNH.OrgaoEmissor = dr["CNH_ORGAOEMISSOR"].ToString();
                    motorista = new Motorista(dr["MT_CPF"].ToString(), dr["MT_NOME"].ToString(), dr["MT_RG"].ToString(), dr["MT_ENDERECO"].ToString(), dtnascimento, telefone, telefonerecado, situacao, cNH);
                    motoristas.Add(motorista);
                }

                return motoristas;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }
    }
}
