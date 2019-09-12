using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;

namespace CamadaModelagem.Data
{
    public class ViagemDAL
    {
        private readonly Banco _banco;

        public ViagemDAL(Banco banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Viagem viagem)
        {
            string query = "INSERT INTO [dbo].[TB_VIAGENS] ([VG_VCL_PLACA],[VG_MT_CPF],[VG_SERVEXT_CNPJ],[VG_OCUPANTES],[VG_DESTINO],[VG_DTSAIDA])"
                + "VALUES ('" + viagem.Veiculo.Placa + "', " + viagem.Motorista.CPF + ", " + viagem.ServicoExterno.CNPJ + ", " + viagem.Ocupante + ", '" + viagem.Destino + "', '" + viagem.DataSaida + "')";
            _banco.ExecutarInstrucao(query);
        }

        public void Deletar(int requisicao)
        {
            string Query = "DELETE [dbo].[TB_VIAGENS] WHERE [VGO_VG_REQ] = " + requisicao;
            _banco.ExecutarInstrucao(Query);
        }

        public void Alterar(Viagem viagem, int requisicao)
        {
            string Query = "UPDATE [dbo].[TB_VIAGENS] SET [VG_VCL_PLACA] ='" + viagem.Veiculo.Placa + "',[VG_MT_CPF] =" + viagem.Motorista.CPF + ",[VG_SERVEXT_CNPJ]=" + viagem.ServicoExterno.CNPJ
                + ",[VG_OCUPANTES] =" + viagem.Ocupante + ",[VG_DESTINO] ='" + viagem.Destino + "',[VG_DTSAIDA] ='" + viagem.DataSaida + "' WHERE [VGO_VG_REQ] =" + requisicao;
            _banco.ExecutarInstrucao(Query);
        }
    }
}
