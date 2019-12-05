namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_MOTORISTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_MOTORISTA()
        {
            TB_CNH = new HashSet<TB_CNH>();
            TB_ENTRADA_SAIDA = new HashSet<TB_ENTRADA_SAIDA>();
            TB_EXAMEDICO = new HashSet<TB_EXAMEDICO>();
            TB_MULTAS = new HashSet<TB_MULTAS>();
            TB_VIAGENS = new HashSet<TB_VIAGENS>();
        }

        [Key]
        [StringLength(12)]
        public string MT_CPF { get; set; }

        [Required]
        [StringLength(150)]
        public string MT_NOME { get; set; }

        [Required]
        [StringLength(12)]
        public string MT_RG { get; set; }

        [Required]
        [StringLength(150)]
        public string MT_ENDERECO { get; set; }

        [Column(TypeName = "date")]
        public DateTime MT_DTNASCIMENTO { get; set; }

        public long MT_TELEFONE { get; set; }

        public long? MT_TELEFONE_RECADO { get; set; }

        public bool MT_SITUACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CNH> TB_CNH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ENTRADA_SAIDA> TB_ENTRADA_SAIDA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_EXAMEDICO> TB_EXAMEDICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_MULTAS> TB_MULTAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_VIAGENS> TB_VIAGENS { get; set; }
    }
}
