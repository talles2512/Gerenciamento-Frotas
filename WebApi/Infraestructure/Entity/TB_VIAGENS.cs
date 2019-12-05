namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_VIAGENS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_VIAGENS()
        {
            TB_VIAGENS_OCUPANTES = new HashSet<TB_VIAGENS_OCUPANTES>();
        }

        [Key]
        public int VG_REQ { get; set; }

        [Required]
        [StringLength(7)]
        public string VG_VCL_PLACA { get; set; }

        [Required]
        [StringLength(12)]
        public string VG_MT_CPF { get; set; }

        public long VG_SERVEXT_CNPJ { get; set; }

        public bool VG_OCUPANTES { get; set; }

        [Required]
        [StringLength(150)]
        public string VG_DESTINO { get; set; }

        public DateTime VG_DTSAIDA { get; set; }

        public virtual TB_MOTORISTA TB_MOTORISTA { get; set; }

        public virtual TB_SERVICOS_EXTERNOS TB_SERVICOS_EXTERNOS { get; set; }

        public virtual TB_VEICULOS TB_VEICULOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_VIAGENS_OCUPANTES> TB_VIAGENS_OCUPANTES { get; set; }
    }
}
