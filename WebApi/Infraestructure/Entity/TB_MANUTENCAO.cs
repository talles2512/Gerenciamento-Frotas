namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_MANUTENCAO
    {
        [Key]
        public int MTC_ID { get; set; }

        public byte MTC_TIPO { get; set; }

        public long MTC_SERVEXT_CNPJ { get; set; }

        [Required]
        [StringLength(250)]
        public string MTC_DESCRICAO { get; set; }

        public DateTime MTC_DATA { get; set; }

        public float MTC_VALOR { get; set; }

        public byte MTC_SITUACAO { get; set; }

        [Required]
        [StringLength(7)]
        public string MTC_VCL_PLACA { get; set; }

        public virtual TB_SERVICOS_EXTERNOS TB_SERVICOS_EXTERNOS { get; set; }

        public virtual TB_VEICULOS TB_VEICULOS { get; set; }
    }
}
