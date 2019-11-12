namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CNH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CNH_NUMERO { get; set; }

        [Column(TypeName = "date")]
        public DateTime CNH_DTEMISSAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime CNH_DTVENC { get; set; }

        [Required]
        [StringLength(1)]
        public string CNH_CATEGORIA { get; set; }

        [Required]
        [StringLength(3)]
        public string CNH_ORGAOEMISSOR { get; set; }

        [Required]
        [StringLength(12)]
        public string CNH_MT_CPF { get; set; }

        public virtual TB_MOTORISTA TB_MOTORISTA { get; set; }
    }
}
