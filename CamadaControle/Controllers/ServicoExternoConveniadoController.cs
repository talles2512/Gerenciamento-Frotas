using CamadaModelagem.Models;
using CamadaModelagem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaControle.Controllers
{
    class ServicoExternoConveniadoController
    {
        private readonly ServicoExternoConveniadoService _servicoExternoConveniado;

        public ServicoExternoConveniadoController(ServicoExternoConveniadoService servicoExternoConveniado)
        {
            _servicoExternoConveniado = servicoExternoConveniado;
        }

        #region [AplicacaoDesktop]

        public void Cadastrar(ServicoExternoConveniado servicoExternoConveniado)
        {
            _servicoExternoConveniado.Cadastrar(servicoExternoConveniado);
        }

        public void Deletar(int cnpj)
        {
            _servicoExternoConveniado.Deletar(cnpj);
        }

        public void Alterar(ServicoExternoConveniado servicoExternoConveniado, int cnpj)
        {
            _servicoExternoConveniado.Alterar(servicoExternoConveniado,cnpj);
        }

        #endregion

        #region [AplicacaoWeb]



        #endregion
    }
}
