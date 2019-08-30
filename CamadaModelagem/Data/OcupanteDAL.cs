using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;

namespace CamadaModelagem.Data
{
    class OcupanteDAL
    {
        private readonly Banco _banco;

        public OcupanteDAL(Banco banco)
        {
            _banco = banco;
        }
        //Os exemplos abaixo não são funcionais, irão ser adaptados futuramente
        public void Cadastrar(Ocupante ocupante) //Exemplo Cadastrar
        {
            string query = "INSERT INTO [dbo].[TB_VIAGENS_OCUPANTES]([VGO_VG_REQ],[VGO_NOME],[VGO_CPF]) " +
                "VALUES(" + ocupante.Viagem.Requisicao + ", '" + ocupante.Nome + "', " + ocupante.CPF + ")";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(int cpf) //Exemplo Deletar --- Será mudado para Inativar
        {
            string Query = "DELETE [dbo].[TB_VIAGENS_OCUPANTES] WHERE [VGO_CPF] = " + cpf;
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(Ocupante ocupante, int cpf)
        {
            string Query = "UPDATE [dbo].[TB_VIAGENS_OCUPANTES] SET [VGO_VG_REQ] = " + ocupante.Viagem.Requisicao + ", [VGO_NOME] = '" + ocupante.Nome + "', [VGO_CPF] = " + ocupante.CPF + " WHERE [VGO_CPF] = " + cpf;
            _banco.ExecutarInstrucao(Query);
        }
    }
}
