namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ABASTECIMENTO
    {
        [Key]
        public int ABS_ID { get; set; }

        [Required]
        [StringLength(7)]
        public string ABS_VCL_PLACA { get; set; }

        public long ABS_SERVEXT_CNPJ { get; set; }

        public byte ABS_TIPO { get; set; }

        public float ABS_LITROS { get; set; }

        public float ABS_VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime ABS_DATA { get; set; }

        public virtual TB_SERVICOS_EXTERNOS TB_SERVICOS_EXTERNOS { get; set; }

        public virtual TB_VEICULOS TB_VEICULOS { get; set; }
    }
}
