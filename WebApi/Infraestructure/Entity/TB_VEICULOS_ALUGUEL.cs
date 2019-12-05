namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_VEICULOS_ALUGUEL
    {
        [Key]
        public int VCLAL_ID { get; set; }

        [Required]
        [StringLength(7)]
        public string VCL_PLACA { get; set; }

        public float VCLAL_VALOR { get; set; }

        public DateTime VCLAL_DTINICIO { get; set; }

        public DateTime VCLAL_DTVENC { get; set; }

        public virtual TB_VEICULOS TB_VEICULOS { get; set; }
    }
}
