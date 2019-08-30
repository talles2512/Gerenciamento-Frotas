﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModelagem.Services.Exceptions
{
    class NaoEncontradoException : ApplicationException
    {
        public NaoEncontradoException(string message) : base(message)
        {

        }
    }
}
