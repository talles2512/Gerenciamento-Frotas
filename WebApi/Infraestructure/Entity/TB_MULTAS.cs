namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_MULTAS
    {
        [Key]
        public int MULT_ID { get; set; }

        [Required]
        [StringLength(7)]
        public string MULT_VCL_PLACA { get; set; }

        [Required]
        [StringLength(12)]
        public string MULT_MT_CPF { get; set; }

        [Required]
        [StringLength(150)]
        public string MULT_DESCRICAO { get; set; }

        [Required]
        [StringLength(150)]
        public string MULT_LOCAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime MULT_DTOCORRENCIA { get; set; }

        public float MULT_VALOR { get; set; }

        public bool MULT_PAGO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MULTPAG_DTPAGAMENTO { get; set; }

        public virtual TB_MOTORISTA TB_MOTORISTA { get; set; }

        public virtual TB_VEICULOS TB_VEICULOS { get; set; }
    }
}
