using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    public class EntradaSaidaController
    {
        private readonly EntradaSaidaService _entradaSaidaService;

        public EntradaSaidaController(EntradaSaidaService entradaSaidaService)
        {
            _entradaSaidaService = entradaSaidaService;
        }

        #region AplicacaoDesktop
        public void Cadastrar(EntradaSaida entsaid) //Mudança na Query, Verificar
        {
            _entradaSaidaService.Cadastrar(entsaid);
        }

        public void Deletar(string placa, int tipo, DateTime data)
        {
            _entradaSaidaService.Deletar(placa, tipo, data);
        }

        public void Alterar(EntradaSaida entsaid, string placa, int tipo, DateTime data)
        {
            _entradaSaidaService.Alterar(entsaid, placa, tipo, data);
        }

        #endregion

        #region AplicacaoWeb



        #endregion
    }
}
