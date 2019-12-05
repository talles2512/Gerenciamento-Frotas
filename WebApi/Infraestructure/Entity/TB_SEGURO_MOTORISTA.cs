namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SEGURO_MOTORISTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SEGURO_MOTORISTA()
        {
            TB_SEGCOBERTURA_MOTORISTA = new HashSet<TB_SEGCOBERTURA_MOTORISTA>();
            TB_SINISTRO_MOTORISTA = new HashSet<TB_SINISTRO_MOTORISTA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SEG_NUMAPOLICE { get; set; }

        public long SEG_SEGURADORA { get; set; }

        [Required]
        [StringLength(12)]
        public string SEG_ITEMSEG_CPF { get; set; }

        public float SEG_VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime SEG_DATAINICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime SEG_FIMVIGENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SEGCOBERTURA_MOTORISTA> TB_SEGCOBERTURA_MOTORISTA { get; set; }

        public virtual TB_SERVICOS_EXTERNOS TB_SERVICOS_EXTERNOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SINISTRO_MOTORISTA> TB_SINISTRO_MOTORISTA { get; set; }
    }
}
