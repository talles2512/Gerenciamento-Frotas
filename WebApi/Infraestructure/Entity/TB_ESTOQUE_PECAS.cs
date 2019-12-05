namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ESTOQUE_PECAS
    {
        [Key]
        public int EP_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string EP_DESCRICAO { get; set; }

        public float EP_VALORUNIT { get; set; }

        public int EP_QUANTD { get; set; }
    }
}
