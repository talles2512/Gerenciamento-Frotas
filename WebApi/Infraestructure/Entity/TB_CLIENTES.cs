namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CLIENTES
    {
        [Key]
        [StringLength(15)]
        public string CLT_CPF { get; set; }

        [Required]
        [StringLength(150)]
        public string CLT_NOME { get; set; }

        [Required]
        [StringLength(15)]
        public string CLT_RG { get; set; }

        [Required]
        [StringLength(150)]
        public string CLT_ENDERECO { get; set; }

        public long CLT_TELEFONE { get; set; }

        [Required]
        [StringLength(150)]
        public string CLT_EMAIL { get; set; }

        [Column(TypeName = "date")]
        public DateTime CLT_DTNASCIMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CLT_DTINICIO_CONTRATO { get; set; }
    }
}
