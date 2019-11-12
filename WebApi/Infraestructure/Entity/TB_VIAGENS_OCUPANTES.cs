namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_VIAGENS_OCUPANTES
    {
        [Key]
        [Column(Order = 0)]
        public int VGO_VG_REQ { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string VGO_NOME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(12)]
        public string VGO_CPF { get; set; }

        public virtual TB_VIAGENS TB_VIAGENS { get; set; }
    }
}
