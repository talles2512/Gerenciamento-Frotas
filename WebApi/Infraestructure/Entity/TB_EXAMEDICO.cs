namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_EXAMEDICO
    {
        [Key]
        public int EXAM_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime EXAM_DATA { get; set; }

        [Required]
        [StringLength(250)]
        public string EXAM_DESCRICAO { get; set; }

        public int EXAM_SITUACAO { get; set; }

        [Required]
        [StringLength(12)]
        public string EXAM_MT_CPF { get; set; }

        public virtual TB_MOTORISTA TB_MOTORISTA { get; set; }
    }
}
