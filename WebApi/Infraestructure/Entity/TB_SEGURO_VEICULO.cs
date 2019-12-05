namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SEGURO_VEICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SEGURO_VEICULO()
        {
            TB_SEGCOBERTURA_VEICULO = new HashSet<TB_SEGCOBERTURA_VEICULO>();
            TB_SINISTRO_VEICULO = new HashSet<TB_SINISTRO_VEICULO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SEG_NUMAPOLICE { get; set; }

        public long SEG_SEGURADORA { get; set; }

        [Required]
        [StringLength(7)]
        public string SEG_ITEMSEG_PLACA { get; set; }

        public float SEG_VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime SEG_DATAINICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime SEG_FIMVIGENCIA { get; set; }

        [Required]
        [StringLength(25)]
        public string SEG_FRANQUIA { get; set; }

        public float SEG_VALORFRANQUIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SEGCOBERTURA_VEICULO> TB_SEGCOBERTURA_VEICULO { get; set; }

        public virtual TB_SERVICOS_EXTERNOS TB_SERVICOS_EXTERNOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SINISTRO_VEICULO> TB_SINISTRO_VEICULO { get; set; }
    }
}
