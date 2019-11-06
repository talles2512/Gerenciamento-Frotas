using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Models.Enums
{
    public enum PerfilAcesso : int
    {
        Atendimento = 1,
        Operacional = 2,
        Motorista = 3,
        Administrador = 4,
        Master = 5
    }
}
