namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ENTRADA_SAIDA
    {
        [Key]
        public int ES_ID { get; set; }

        [Required]
        [StringLength(12)]
        public string ES_MT_CPF { get; set; }

        [Required]
        [StringLength(7)]
        public string ES_VCL_PLACA { get; set; }

        public long ES_SERVEXT_CNPJ { get; set; }

        [Required]
        [StringLength(25)]
        public string ES_TIPO { get; set; }

        public DateTime ES_DATAHORA { get; set; }

        public virtual TB_MOTORISTA TB_MOTORISTA { get; set; }

        public virtual TB_SERVICOS_EXTERNOS TB_SERVICOS_EXTERNOS { get; set; }

        public virtual TB_VEICULOS TB_VEICULOS { get; set; }
    }
}
