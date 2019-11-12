namespace WebApi.Infraestructure.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }

        public virtual DbSet<TB_ABASTECIMENTO> TB_ABASTECIMENTO { get; set; }
        public virtual DbSet<TB_CLIENTES> TB_CLIENTES { get; set; }
        public virtual DbSet<TB_CNH> TB_CNH { get; set; }
        public virtual DbSet<TB_ENTRADA_SAIDA> TB_ENTRADA_SAIDA { get; set; }
        public virtual DbSet<TB_ESTOQUE_PECAS> TB_ESTOQUE_PECAS { get; set; }
        public virtual DbSet<TB_EXAMEDICO> TB_EXAMEDICO { get; set; }
        public virtual DbSet<TB_FUNCIONARIO> TB_FUNCIONARIO { get; set; }
        public virtual DbSet<TB_MANUTENCAO> TB_MANUTENCAO { get; set; }
        public virtual DbSet<TB_MOTORISTA> TB_MOTORISTA { get; set; }
        public virtual DbSet<TB_MULTAS> TB_MULTAS { get; set; }
        public virtual DbSet<TB_SEGCOBERTURA_MOTORISTA> TB_SEGCOBERTURA_MOTORISTA { get; set; }
        public virtual DbSet<TB_SEGCOBERTURA_VEICULO> TB_SEGCOBERTURA_VEICULO { get; set; }
        public virtual DbSet<TB_SEGURO_MOTORISTA> TB_SEGURO_MOTORISTA { get; set; }
        public virtual DbSet<TB_SEGURO_VEICULO> TB_SEGURO_VEICULO { get; set; }
        public virtual DbSet<TB_SERVICOS_EXTERNOS> TB_SERVICOS_EXTERNOS { get; set; }
        public virtual DbSet<TB_SERVICOS_EXTERNOS_CONVENIADOS> TB_SERVICOS_EXTERNOS_CONVENIADOS { get; set; }
        public virtual DbSet<TB_SINISTRO_MOTORISTA> TB_SINISTRO_MOTORISTA { get; set; }
        public virtual DbSet<TB_SINISTRO_VEICULO> TB_SINISTRO_VEICULO { get; set; }
        public virtual DbSet<TB_VEICULOS> TB_VEICULOS { get; set; }
        public virtual DbSet<TB_VEICULOS_ALUGUEL> TB_VEICULOS_ALUGUEL { get; set; }
        public virtual DbSet<TB_VIAGENS> TB_VIAGENS { get; set; }
        public virtual DbSet<TB_VIAGENS_OCUPANTES> TB_VIAGENS_OCUPANTES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TB_ABASTECIMENTO>()
                .Property(e => e.ABS_VCL_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTES>()
                .Property(e => e.CLT_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTES>()
                .Property(e => e.CLT_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTES>()
                .Property(e => e.CLT_RG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTES>()
                .Property(e => e.CLT_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CLIENTES>()
                .Property(e => e.CLT_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CNH>()
                .Property(e => e.CNH_CATEGORIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_CNH>()
                .Property(e => e.CNH_ORGAOEMISSOR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CNH>()
                .Property(e => e.CNH_MT_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENTRADA_SAIDA>()
                .Property(e => e.ES_MT_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENTRADA_SAIDA>()
                .Property(e => e.ES_VCL_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ENTRADA_SAIDA>()
                .Property(e => e.ES_TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ESTOQUE_PECAS>()
                .Property(e => e.EP_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EXAMEDICO>()
                .Property(e => e.EXAM_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EXAMEDICO>()
                .Property(e => e.EXAM_MT_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FUNCIONARIO>()
                .Property(e => e.FUNC_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FUNCIONARIO>()
                .Property(e => e.FUNC_LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FUNCIONARIO>()
                .Property(e => e.FUNC_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MANUTENCAO>()
                .Property(e => e.MTC_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MANUTENCAO>()
                .Property(e => e.MTC_VCL_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MOTORISTA>()
                .Property(e => e.MT_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MOTORISTA>()
                .Property(e => e.MT_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MOTORISTA>()
                .Property(e => e.MT_RG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MOTORISTA>()
                .Property(e => e.MT_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MOTORISTA>()
                .HasMany(e => e.TB_CNH)
                .WithRequired(e => e.TB_MOTORISTA)
                .HasForeignKey(e => e.CNH_MT_CPF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_MOTORISTA>()
                .HasMany(e => e.TB_ENTRADA_SAIDA)
                .WithRequired(e => e.TB_MOTORISTA)
                .HasForeignKey(e => e.ES_MT_CPF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_MOTORISTA>()
                .HasMany(e => e.TB_EXAMEDICO)
                .WithRequired(e => e.TB_MOTORISTA)
                .HasForeignKey(e => e.EXAM_MT_CPF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_MOTORISTA>()
                .HasMany(e => e.TB_MULTAS)
                .WithRequired(e => e.TB_MOTORISTA)
                .HasForeignKey(e => e.MULT_MT_CPF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_MOTORISTA>()
                .HasMany(e => e.TB_VIAGENS)
                .WithRequired(e => e.TB_MOTORISTA)
                .HasForeignKey(e => e.VG_MT_CPF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_MULTAS>()
                .Property(e => e.MULT_VCL_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MULTAS>()
                .Property(e => e.MULT_MT_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MULTAS>()
                .Property(e => e.MULT_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MULTAS>()
                .Property(e => e.MULT_LOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SEGCOBERTURA_MOTORISTA>()
                .Property(e => e.SEGC_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SEGCOBERTURA_VEICULO>()
                .Property(e => e.SEGC_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SEGURO_MOTORISTA>()
                .Property(e => e.SEG_ITEMSEG_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SEGURO_MOTORISTA>()
                .HasMany(e => e.TB_SEGCOBERTURA_MOTORISTA)
                .WithRequired(e => e.TB_SEGURO_MOTORISTA)
                .HasForeignKey(e => e.SEGC_SEGURO_NUMAPOLICE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SEGURO_MOTORISTA>()
                .HasMany(e => e.TB_SINISTRO_MOTORISTA)
                .WithRequired(e => e.TB_SEGURO_MOTORISTA)
                .HasForeignKey(e => e.SIN_SEGURO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SEGURO_VEICULO>()
                .Property(e => e.SEG_ITEMSEG_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SEGURO_VEICULO>()
                .Property(e => e.SEG_FRANQUIA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SEGURO_VEICULO>()
                .HasMany(e => e.TB_SEGCOBERTURA_VEICULO)
                .WithRequired(e => e.TB_SEGURO_VEICULO)
                .HasForeignKey(e => e.SEGC_SEGURO_NUMAPOLICE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SEGURO_VEICULO>()
                .HasMany(e => e.TB_SINISTRO_VEICULO)
                .WithRequired(e => e.TB_SEGURO_VEICULO)
                .HasForeignKey(e => e.SIN_SEGURO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SERVICOS_EXTERNOS>()
                .Property(e => e.SERVEXT_TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SERVICOS_EXTERNOS>()
                .Property(e => e.SERVEXT_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SERVICOS_EXTERNOS>()
                .Property(e => e.SERVEXT_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SERVICOS_EXTERNOS>()
                .Property(e => e.SERVEXT_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SERVICOS_EXTERNOS>()
                .HasMany(e => e.TB_ABASTECIMENTO)
                .WithRequired(e => e.TB_SERVICOS_EXTERNOS)
                .HasForeignKey(e => e.ABS_SERVEXT_CNPJ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SERVICOS_EXTERNOS>()
                .HasMany(e => e.TB_ENTRADA_SAIDA)
                .WithRequired(e => e.TB_SERVICOS_EXTERNOS)
                .HasForeignKey(e => e.ES_SERVEXT_CNPJ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SERVICOS_EXTERNOS>()
                .HasMany(e => e.TB_MANUTENCAO)
                .WithRequired(e => e.TB_SERVICOS_EXTERNOS)
                .HasForeignKey(e => e.MTC_SERVEXT_CNPJ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SERVICOS_EXTERNOS>()
                .HasMany(e => e.TB_SEGURO_MOTORISTA)
                .WithRequired(e => e.TB_SERVICOS_EXTERNOS)
                .HasForeignKey(e => e.SEG_SEGURADORA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SERVICOS_EXTERNOS>()
                .HasMany(e => e.TB_SEGURO_VEICULO)
                .WithRequired(e => e.TB_SERVICOS_EXTERNOS)
                .HasForeignKey(e => e.SEG_SEGURADORA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SERVICOS_EXTERNOS>()
                .HasMany(e => e.TB_SERVICOS_EXTERNOS_CONVENIADOS)
                .WithRequired(e => e.TB_SERVICOS_EXTERNOS)
                .HasForeignKey(e => e.SERVEXTCONV_SERVEXT_CNPJ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SERVICOS_EXTERNOS>()
                .HasMany(e => e.TB_VIAGENS)
                .WithRequired(e => e.TB_SERVICOS_EXTERNOS)
                .HasForeignKey(e => e.VG_SERVEXT_CNPJ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SINISTRO_MOTORISTA>()
                .Property(e => e.SIN_ITEMSEG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SINISTRO_MOTORISTA>()
                .Property(e => e.SIN_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SINISTRO_VEICULO>()
                .Property(e => e.SIN_ITEMSEG)
                .IsUnicode(false);

            modelBuilder.Entity<TB_SINISTRO_VEICULO>()
                .Property(e => e.SIN_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULOS>()
                .Property(e => e.VCL_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULOS>()
                .Property(e => e.VCL_MARCA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULOS>()
                .Property(e => e.VCL_MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULOS>()
                .Property(e => e.VCL_CHASSI)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VEICULOS>()
                .HasMany(e => e.TB_ABASTECIMENTO)
                .WithRequired(e => e.TB_VEICULOS)
                .HasForeignKey(e => e.ABS_VCL_PLACA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_VEICULOS>()
                .HasMany(e => e.TB_ENTRADA_SAIDA)
                .WithRequired(e => e.TB_VEICULOS)
                .HasForeignKey(e => e.ES_VCL_PLACA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_VEICULOS>()
                .HasMany(e => e.TB_MANUTENCAO)
                .WithRequired(e => e.TB_VEICULOS)
                .HasForeignKey(e => e.MTC_VCL_PLACA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_VEICULOS>()
                .HasMany(e => e.TB_MULTAS)
                .WithRequired(e => e.TB_VEICULOS)
                .HasForeignKey(e => e.MULT_VCL_PLACA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_VEICULOS>()
                .HasMany(e => e.TB_VEICULOS_ALUGUEL)
                .WithRequired(e => e.TB_VEICULOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_VEICULOS>()
                .HasMany(e => e.TB_VIAGENS)
                .WithRequired(e => e.TB_VEICULOS)
                .HasForeignKey(e => e.VG_VCL_PLACA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_VEICULOS_ALUGUEL>()
                .Property(e => e.VCL_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VIAGENS>()
                .Property(e => e.VG_VCL_PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VIAGENS>()
                .Property(e => e.VG_MT_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VIAGENS>()
                .Property(e => e.VG_DESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VIAGENS>()
                .HasMany(e => e.TB_VIAGENS_OCUPANTES)
                .WithRequired(e => e.TB_VIAGENS)
                .HasForeignKey(e => e.VGO_VG_REQ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_VIAGENS_OCUPANTES>()
                .Property(e => e.VGO_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_VIAGENS_OCUPANTES>()
                .Property(e => e.VGO_CPF)
                .IsUnicode(false);
        }
    }
}
