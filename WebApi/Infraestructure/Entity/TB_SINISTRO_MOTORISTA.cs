namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SINISTRO_MOTORISTA
    {
        [Key]
        public int SIN_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string SIN_ITEMSEG { get; set; }

        public long SIN_SEGURO { get; set; }

        [Required]
        [StringLength(250)]
        public string SIN_DESCRICAO { get; set; }

        public DateTime SIN_DATAHORA { get; set; }

        public virtual TB_SEGURO_MOTORISTA TB_SEGURO_MOTORISTA { get; set; }
    }
}
