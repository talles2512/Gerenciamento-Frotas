using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Services.Exceptions
{
    public class RegistroExisteException : ApplicationException
    {
        public RegistroExisteException(string message) : base(message)
        {

        }
    }
}
