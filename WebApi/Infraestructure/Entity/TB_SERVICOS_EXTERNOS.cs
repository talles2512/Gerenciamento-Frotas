namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SERVICOS_EXTERNOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SERVICOS_EXTERNOS()
        {
            TB_ABASTECIMENTO = new HashSet<TB_ABASTECIMENTO>();
            TB_ENTRADA_SAIDA = new HashSet<TB_ENTRADA_SAIDA>();
            TB_MANUTENCAO = new HashSet<TB_MANUTENCAO>();
            TB_SEGURO_MOTORISTA = new HashSet<TB_SEGURO_MOTORISTA>();
            TB_SEGURO_VEICULO = new HashSet<TB_SEGURO_VEICULO>();
            TB_SERVICOS_EXTERNOS_CONVENIADOS = new HashSet<TB_SERVICOS_EXTERNOS_CONVENIADOS>();
            TB_VIAGENS = new HashSet<TB_VIAGENS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVEXT_CNPJ { get; set; }

        [Required]
        [StringLength(30)]
        public string SERVEXT_TIPO { get; set; }

        [Required]
        [StringLength(150)]
        public string SERVEXT_NOME { get; set; }

        public long SERVEXT_TELEFONE { get; set; }

        [Required]
        [StringLength(150)]
        public string SERVEXT_EMAIL { get; set; }

        [Required]
        [StringLength(150)]
        public string SERVEXT_ENDERECO { get; set; }

        public bool SERVEXT_CONVENIADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ABASTECIMENTO> TB_ABASTECIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ENTRADA_SAIDA> TB_ENTRADA_SAIDA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_MANUTENCAO> TB_MANUTENCAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SEGURO_MOTORISTA> TB_SEGURO_MOTORISTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SEGURO_VEICULO> TB_SEGURO_VEICULO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SERVICOS_EXTERNOS_CONVENIADOS> TB_SERVICOS_EXTERNOS_CONVENIADOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_VIAGENS> TB_VIAGENS { get; set; }
    }
}
