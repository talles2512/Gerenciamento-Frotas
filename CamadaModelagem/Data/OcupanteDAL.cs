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
    public class OcupanteDAL
    {
        private readonly Banco _banco;

        public OcupanteDAL(Banco banco)
        {
            _banco = banco;
        }
        //Os exemplos abaixo não são funcionais, irão ser adaptados futuramente
        public bool Cadastrar(Ocupante ocupante) //Exemplo Cadastrar
        {
            string query = "INSERT INTO [dbo].[TB_VIAGENS_OCUPANTES]([VGO_VG_REQ],[VGO_NOME],[VGO_CPF])"
                + "VALUES(" + ocupante.Requisicao + ",'" + ocupante.Nome + "','" + ocupante.CPF + "')";
            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch (ConcorrenciaBancoException e)
            {
                throw new ConcorrenciaBancoException(e.Message);
            }
        }

        public void Deletar(int cpf) //Exemplo Deletar --- Será mudado para Inativar
        {
            string Query = "DELETE [dbo].[TB_VIAGENS_OCUPANTES] WHERE [VGO_CPF] = " + cpf;
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(Ocupante ocupante, int cpf)
        {
            string Query = "UPDATE [dbo].[TB_VIAGENS_OCUPANTES] SET [VGO_VG_REQ] = " + ocupante.Requisicao + ", [VGO_NOME] = '" + ocupante.Nome + "', [VGO_CPF] = " + ocupante.CPF + " WHERE [VGO_CPF] = " + cpf;
            _banco.ExecutarInstrucao(Query);
        }

        public List<Ocupante> BuscarOcupantes(int requisicao)
        {
            List<Ocupante> ocupantes = new List<Ocupante>();
            string query = "SELECT [VGO_VG_REQ], [VGO_NOME], [VGO_CPF] FROM [dbo].[TB_VIAGENS_OCUPANTES] WHERE [VGO_VG_REQ] = " + requisicao;
            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                Ocupante ocupante = null;
                DataRow[] dataRows = dt.Select("[VGO_VG_REQ] = " + requisicao);
                foreach (DataRow dr in dataRows)
                {
                    int numRequisicao = int.Parse(dr["VGO_VG_REQ"].ToString());
                    long cPF = long.Parse(dr["VGO_CPF"].ToString());

                    ocupante = new Ocupante(dr["VGO_NOME"].ToString(), cPF, numRequisicao);
                    ocupantes.Add(ocupante);
                }
                return ocupantes;
            }
            catch (Exception)
            {
                throw new ConcorrenciaBancoException("Erro de concorrência de banco!");
            }
        }
    }
}
