namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_FUNCIONARIO
    {
        [Required]
        [StringLength(150)]
        public string FUNC_NOME { get; set; }

        [Key]
        [StringLength(25)]
        public string FUNC_LOGIN { get; set; }

        [Required]
        [StringLength(25)]
        public string FUNC_SENHA { get; set; }

        public byte FUNC_PERFIL_ACESSO { get; set; }
    }
}
