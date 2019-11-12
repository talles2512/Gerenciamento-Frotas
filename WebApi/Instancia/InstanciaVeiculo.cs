using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelagem.Data;
using CamadaModelagem.Data.Configuration;
using CamadaModelagem.Models;
using CamadaModelagem.Services;

namespace CamadaControle.Instancia
{
    public class InstanciaVeiculo
    {
        public VeiculoService _veiculoService;

        public InstanciaVeiculo()
        {
            Banco banco = new Banco();
            VeiculoDAL veiculoDAL = new VeiculoDAL(banco);
            ManutencaoDAL manutencaoDAL = new ManutencaoDAL(banco);
            AbastecimentoDAL abastecimentoDAL = new AbastecimentoDAL(banco);
            EntradaSaidaDAL entradaSaidaDAL = new EntradaSaidaDAL(banco);
            SeguroDAL seguroDAL = new SeguroDAL(banco);
            _veiculoService = new VeiculoService(veiculoDAL, manutencaoDAL, abastecimentoDAL, entradaSaidaDAL, seguroDAL);
        }
    }
}
