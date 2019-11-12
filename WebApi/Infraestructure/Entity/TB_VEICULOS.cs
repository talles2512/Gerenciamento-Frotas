namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_VEICULOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_VEICULOS()
        {
            TB_ABASTECIMENTO = new HashSet<TB_ABASTECIMENTO>();
            TB_ENTRADA_SAIDA = new HashSet<TB_ENTRADA_SAIDA>();
            TB_MANUTENCAO = new HashSet<TB_MANUTENCAO>();
            TB_MULTAS = new HashSet<TB_MULTAS>();
            TB_VEICULOS_ALUGUEL = new HashSet<TB_VEICULOS_ALUGUEL>();
            TB_VIAGENS = new HashSet<TB_VIAGENS>();
        }

        [Key]
        [StringLength(7)]
        public string VCL_PLACA { get; set; }

        [Required]
        [StringLength(25)]
        public string VCL_MARCA { get; set; }

        [Required]
        [StringLength(25)]
        public string VCL_MODELO { get; set; }

        [Required]
        [StringLength(20)]
        public string VCL_CHASSI { get; set; }

        public int VCL_ANO { get; set; }

        public byte VCL_COR { get; set; }

        public byte VCL_COMBUSTIVEL { get; set; }

        public bool VCL_ALUGADO { get; set; }

        public bool VCL_SITUACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ABASTECIMENTO> TB_ABASTECIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ENTRADA_SAIDA> TB_ENTRADA_SAIDA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_MANUTENCAO> TB_MANUTENCAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_MULTAS> TB_MULTAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_VEICULOS_ALUGUEL> TB_VEICULOS_ALUGUEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_VIAGENS> TB_VIAGENS { get; set; }
    }
}
