namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SERVICOS_EXTERNOS_CONVENIADOS
    {
        [Key]
        public int SERVEXTCONV_ID { get; set; }

        public float SERVEXTCONV_VALOR { get; set; }

        public DateTime SERVEXTCONV_DTINICIO { get; set; }

        public DateTime SERVEXTCONV_DTVENC { get; set; }

        public long SERVEXTCONV_SERVEXT_CNPJ { get; set; }

        public virtual TB_SERVICOS_EXTERNOS TB_SERVICOS_EXTERNOS { get; set; }
    }
}
