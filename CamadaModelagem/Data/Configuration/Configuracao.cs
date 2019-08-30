using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CamadaModelagem.Data.Configuration
{
    class Configuracao
    {
        public string StringConfiguracao { get; set; }

        public Configuracao()
        {
            StringConfiguracao = ConfigurationManager.ConnectionStrings["DB_GERENCFROTA"].ConnectionString;
        }
    }
}
