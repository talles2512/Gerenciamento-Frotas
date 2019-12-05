namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SEGCOBERTURA_VEICULO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEGC_ID { get; set; }

        [Required]
        [StringLength(250)]
        public string SEGC_DESCRICAO { get; set; }

        public long SEGC_SEGURO_NUMAPOLICE { get; set; }

        public virtual TB_SEGURO_VEICULO TB_SEGURO_VEICULO { get; set; }
    }
}
