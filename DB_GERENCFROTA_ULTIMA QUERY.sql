/*
UNIVERSIDADE PAULISTA - UNIP 2019
ANALISE E DESENVOLVIMENTO DE SISTEMAS
PROJETO DE GERENCIAMENTO DE FROTAS DE VEICULOS
MODIFICA��ES: 23/08/2019
*/

USE [master]
GO

IF EXISTS (SELECT name FROM master.sys.databases WHERE name = N'DB_GERENCFROTA')
DROP DATABASE DB_GERENCFROTA;
GO

CREATE DATABASE [DB_GERENCFROTA]
GO

USE [DB_GERENCFROTA]
GO

SET ANSI_NULLS ON
GO 
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_VEICULOS]
([VCL_PLACA] [VARCHAR](7) UNIQUE NOT NULL,
[VCL_MARCA] [VARCHAR](25) NOT NULL,
[VCL_MODELO] [VARCHAR](25) NOT NULL,
[VCL_CHASSI] [VARCHAR](20) UNIQUE NOT NULL,
[VCL_ANO] [INT] NOT NULL,
[VCL_COR] [TINYINT] NOT NULL,  -- ENUM VEICULOTIPOCOR : INT
[VCL_COMBUSTIVEL] [TINYINT] NOT NULL, -- ENUM VEICULOCOMBUSTIVEL : INT
[VCL_ALUGADO] [BIT] NOT NULL,
[VCL_SITUACAO] [BIT] NOT NULL,
CONSTRAINT [PK_VEICULOS] PRIMARY KEY CLUSTERED 
([VCL_PLACA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_VEICULOS_ALUGUEL]
([VCLAL_ID] [INT] IDENTITY(1,1) NOT NULL,
[VCL_PLACA] [VARCHAR](7) UNIQUE NOT NULL,
[VCLAL_VALOR] [REAL] NOT NULL,
[VCLAL_DTINICIO] [DATETIME] NOT NULL,
[VCLAL_DTVENC] [DATETIME] NOT NULL,
CONSTRAINT [FK_VEICULOS_ALUGUEL_VEICULOS] FOREIGN KEY ([VCL_PLACA]) REFERENCES [dbo].[TB_VEICULOS]([VCL_PLACA]), -- FOREIGN KEY COM VEICULO ALUGUEL (novo)
CONSTRAINT [PK_VEICULOS_ALUGUEL] PRIMARY KEY CLUSTERED 
([VCLAL_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_MOTORISTA]
([MT_CPF] [INT] UNIQUE NOT NULL,
[MT_NOME] [VARCHAR](150) NOT NULL,
[MT_RG] [VARCHAR](12) NOT NULL,
[MT_ENDERECO] [VARCHAR](150) NOT NULL,
[MT_DTNASCIMENTO] [DATE] NOT NULL,
[MT_TELEFONE] [INT] NOT NULL,
[MT_TELEFONE_RECADO] [INT],
[MT_SITUACAO] [BIT] NOT NULL,
--[MT_CNH_NUMERO] [INT] UNIQUE NOT NULL,
--CONSTRAINT [FK_MOTORISTA_CNH] FOREIGN KEY ([MT_CNH_NUMERO]) REFERENCES [dbo].[TB_CNH]([CNH_NUMERO]),
CONSTRAINT [PK_MOTORISTA] PRIMARY KEY CLUSTERED 
([MT_CPF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_CNH]
([CNH_NUMERO] [INT] UNIQUE NOT NULL,
[CNH_DTEMISSAO] [DATE] NOT NULL,
[CNH_DTVENC] [DATE] NOT NULL,
[CNH_CATEGORIA] [CHAR](1) NOT NULL,
[CNH_ORGAOEMISSOR] [VARCHAR](3) NOT NULL,
[CNH_MT_CPF] [INT] UNIQUE NOT NULL,
CONSTRAINT [FK_CNH_MOTORISTA] FOREIGN KEY ([CNH_MT_CPF]) REFERENCES [dbo].[TB_MOTORISTA]([MT_CPF]),
CONSTRAINT [PK_CNH] PRIMARY KEY CLUSTERED 
([CNH_NUMERO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_EXAMEDICO]
([EXAM_ID] [INT] IDENTITY(1,1) NOT NULL,
[EXAM_DATA] [DATE] NOT NULL,
[EXAM_DESCRICAO] [VARCHAR](250) NOT NULL,
[EXAM_SITUACAO] [BIT] NOT NULL,
[EXAM_MT_CPF] [INT] UNIQUE NOT NULL,
CONSTRAINT [FK_EXAMEDICO_MOTORISTA] FOREIGN KEY ([EXAM_MT_CPF]) REFERENCES [dbo].[TB_MOTORISTA]([MT_CPF]),
CONSTRAINT [PK_EXAMEDICO] PRIMARY KEY CLUSTERED 
([EXAM_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_SERVICOS_EXTERNOS]
([SERVEXT_CNPJ] [INT] UNIQUE NOT NULL,
[SERVEXT_TIPO] [VARCHAR](25) NOT NULL,
[SERVEXT_NOME] [VARCHAR](15) NOT NULL,
[SERVEXT_TELEFONE] [INT] NOT NULL,
[SERVEXT_EMAIL] [VARCHAR] (150) NOT NULL,
[SERVEXT_ENDERECO] [VARCHAR](150) NOT NULL,
[SERVEXT_CONVENIADO] [BIT] NOT NULL,
--[SERVEXT_SERVEXTCONV_ID] [INT] IDENTITY(1,1) NOT NULL, -- FOREIGN KEY COM SERVI�OS EXTERNOS CONVENIADOS (novo)
--CONSTRAINT [FK_SERVICOS_EXTERNOS_SERVICOS_EXTERNOS_CONVENIADOS] FOREIGN KEY (SERVEXT_SERVEXTCONV_ID) REFERENCES [dbo].[TB_SERVICOS_EXTERNOS_CONVENIADOS]([SERVEXTCONV_ID]), -- FOREIGN KEY COM SERVI�OS EXTERNOS CONVENIADOS (novo)
CONSTRAINT [PK_SERVICOS_EXTERNOS] PRIMARY KEY CLUSTERED 
([SERVEXT_CNPJ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_SERVICOS_EXTERNOS_CONVENIADOS]
([SERVEXTCONV_ID] [INT] IDENTITY(1,1) NOT NULL,
[SERVEXTCONV_VALOR] [REAL] NOT NULL,
[SERVEXTCONV_DTINICIO] [DATETIME] NOT NULL,
[SERVEXTCONV_DTVENC] [DATETIME] NOT NULL,
[SERVEXTCONV_SERVEXT_CNPJ] [INT] UNIQUE NOT NULL,
CONSTRAINT [FK_SERVICOS_EXTERNOS_CONVENIADOS_SERVICOS_EXTERNOS] FOREIGN KEY ([SERVEXTCONV_SERVEXT_CNPJ]) REFERENCES [dbo].[TB_SERVICOS_EXTERNOS]([SERVEXT_CNPJ]),
CONSTRAINT [PK_SERVICOS_EXTERNOS_CONVENIADOS] PRIMARY KEY CLUSTERED 
([SERVEXTCONV_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_MANUTENCAO]
([MTC_ID] [INT] IDENTITY (1,1) NOT NULL,
[MTC_TIPO] [TINYINT] NOT NULL, -- ENUM TIPOMANUTENCAO : INT
[MTC_SERVEXT_CNPJ] [INT] UNIQUE NOT NULL, --FOREIGN KEY COM SERVI�OS EXTERNOS (novo)
[MTC_DESCRICAO] [VARCHAR](250) NOT NULL,
[MTC_DATA] [DATE] NOT NULL,
[MTC_VALOR] [REAL] NOT NULL,
[MTC_SITUACAO] [BIT] NOT NULL,
[MTC_VCL_PLACA] [VARCHAR](7) UNIQUE NOT NULL,
CONSTRAINT [FK_MANUTENCAO_VEICULOS] FOREIGN KEY (MTC_VCL_PLACA) REFERENCES [dbo].[TB_VEICULOS]([VCL_PLACA]),
CONSTRAINT [FK_MANUTENCAO_SERVICOS_EXTERNOS] FOREIGN KEY ([MTC_SERVEXT_CNPJ]) REFERENCES [dbo].[TB_SERVICOS_EXTERNOS]([SERVEXT_CNPJ]), -- CONSTRAINT COM SERVI�OS EXTERNOS (novo)
CONSTRAINT [PK_MANUTENCAO] PRIMARY KEY CLUSTERED 
([MTC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_SEGURO]
([SEG_NUMAPOLICE] [INT] UNIQUE NOT NULL,
[SEG_SEGURADORA] [INT] UNIQUE NOT NULL,
[SEG_ITEMSEG] [BIT] NOT NULL,
--[SEG_COBERTURA] [INT] UNIQUE NOT NULL, -- FOREIGN KEY TB_SEGCOBERTURA
[SEG_TIPO] [VARCHAR](25) NOT NULL,
[SEG_VALOR] [REAL] NOT NULL,
[SEG_DATAINICIO] [DATE] NOT NULL,
[SEG_FIMVIGENCIA] [DATE] NOT NULL,
[SEG_FRANQUIA] [VARCHAR](25) NOT NULL,
[SEG_VALORFRANQUIA] [REAL] NOT NULL,
--CONSTRAINT [FK_SEGURO_SEGCOBERTURA] FOREIGN KEY ([SEG_COBERTURA]) REFERENCES [dbo].[TB_SEGCOBERTURA]([SEGC_ID]),
CONSTRAINT [FK_SEGURO_SERVICOS_EXTERNOS] FOREIGN KEY ([SEG_SEGURADORA]) REFERENCES [dbo].[TB_SERVICOS_EXTERNOS]([SERVEXT_CNPJ]),
CONSTRAINT [PK_SEGURO] PRIMARY KEY CLUSTERED 
([SEG_NUMAPOLICE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_SEGCOBERTURA]
([SEGC_ID] [INT] UNIQUE NOT NULL,
[SEGC_DESCRICAO] [VARCHAR](250) NOT NULL,
[SEGC_SEGURO_NUMAPOLICE] [INT] UNIQUE NOT NULL,
CONSTRAINT [FK_SEGCOBERTURA_SEGURO]  FOREIGN KEY ([SEGC_SEGURO_NUMAPOLICE]) REFERENCES [dbo].[TB_SEGURO]([SEG_NUMAPOLICE]),
CONSTRAINT [PK_SEGCOBERTURA] PRIMARY KEY CLUSTERED 
([SEGC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_SINISTRO]
([SIN_ID] [INT] IDENTITY (1,1)  NOT NULL,
[SIN_ITEMSEG] [VARCHAR](25) NOT NULL,
[SIN_SEGURO] [INT] UNIQUE NOT NULL, 
[SIN_DESCRICAO] [VARCHAR](250) NOT NULL,
[SIN_DATAHORA] [DATETIME] NOT NULL,
CONSTRAINT FK_SINISTRO_SEGURO FOREIGN KEY ([SIN_SEGURO]) REFERENCES [dbo].[TB_SEGURO]([SEG_NUMAPOLICE]),
CONSTRAINT [PK_SINISTRO] PRIMARY KEY CLUSTERED 
([SIN_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_ABASTECIMENTO]
([ABS_VCL_PLACA] [VARCHAR](7) UNIQUE NOT NULL,
[ABS_SERVEXT_CNPJ] [INT] UNIQUE NOT NULL, -- FOREIGN KEY DE SERVI�OS EXTERNOS
[ABS_TIPO] [TINYINT] NOT NULL, -- ENUM ABASTECIMENTOTIPO : INT
[ABS_VALORLITRO] [REAL] NOT NULL,
[ABS_DATA] [DATE] NOT NULL,
CONSTRAINT [FK_ABASTECIMENTO_VEICULOS] FOREIGN KEY ([ABS_VCL_PLACA]) REFERENCES [dbo].[TB_VEICULOS]([VCL_PLACA]),
CONSTRAINT [FK_ABASTECIMENTO_SERVICOS_EXTERNOS] FOREIGN KEY ([ABS_SERVEXT_CNPJ]) REFERENCES [dbo].[TB_SERVICOS_EXTERNOS]([SERVEXT_CNPJ]));

CREATE TABLE [dbo].[TB_ESTOQUE_PECAS]
([EP_ID] [INT] IDENTITY(1,1) NOT NULL,
[EP_DESCRICAO] [VARCHAR](150) NOT NULL,
[EP_VALORUNIT] [REAL]  NOT NULL,
[EP_QUANTD] [INT] NOT NULL,
CONSTRAINT [PK_ESTOQUE_PECAS] PRIMARY KEY CLUSTERED 
([EP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_ENTRADA_SAIDA]
([ES_ID] [INT] IDENTITY(1,1) NOT NULL,
[ES_MT_CPF] [INT] UNIQUE NOT NULL,
[ES_VCL_PLACA] [VARCHAR](7) UNIQUE NOT NULL,
[ES_SERVEXT_CNPJ] [INT] UNIQUE NOT NULL,
[ES_TIPO] [VARCHAR](25) NOT NULL,
[ES_DATAHORA] [DATETIME] NOT NULL,
CONSTRAINT [FK_ENTRADA_SAIDA_MOTORISTA] FOREIGN KEY ([ES_MT_CPF]) REFERENCES [dbo].[TB_MOTORISTA]([MT_CPF]),
CONSTRAINT [FK_ENTRADA_SAIDA_VEICULOS] FOREIGN KEY ([ES_VCL_PLACA]) REFERENCES [dbo].[TB_VEICULOS]([VCL_PLACA]),
CONSTRAINT [FK_ENTRADA_SAIDA_SERVICOS_EXTERNOS] FOREIGN KEY ([ES_SERVEXT_CNPJ]) REFERENCES [dbo].[TB_SERVICOS_EXTERNOS]([SERVEXT_CNPJ]),
CONSTRAINT [PK_ENTRADA_SAIDA] PRIMARY KEY CLUSTERED 
([ES_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_MULTAS]
([MULT_ID] [INT] IDENTITY(1,1) NOT NULL,
[MULT_VCL_PLACA] [VARCHAR](7) UNIQUE NOT NULL,
[MULT_MT_CPF] [INT] UNIQUE NOT NULL,
[MULT_DESCRICAO] [VARCHAR](150) NOT NULL,
[MULT_LOCAL] [VARCHAR](150) NOT NULL,
[MULT_DTOCORRENCIA] [DATETIME] NOT NULL,
[MULT_VALOR] [REAL] NOT NULL,
[MULT_PAGO] [BIT] NOT NULL,
[MULTPAG_DTPAGAMENTO] [DATE], --CAMPO MULTA PAGA DATA PAGAMENTO DA TABELA ABAIXO, VERIFICAR NECESSIDADE DESSA TABELA;
CONSTRAINT [FK_MULTAS_VEICULOS] FOREIGN KEY ([MULT_VCL_PLACA]) REFERENCES [dbo].[TB_VEICULOS]([VCL_PLACA]),
CONSTRAINT [FK_MULTAS_MOTORISTA] FOREIGN KEY ([MULT_MT_CPF]) REFERENCES [dbo].[TB_MOTORISTA]([MT_CPF]),
CONSTRAINT [PK_MULTAS] PRIMARY KEY CLUSTERED 
([MULT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_VIAGENS]
([VG_REQ] [INT] IDENTITY(1,1) NOT NULL,
[VG_VCL_PLACA] [VARCHAR](7) UNIQUE NOT NULL,
[VG_MT_CPF] [INT] UNIQUE NOT NULL,
[VG_SERVEXT_CNPJ] [INT] UNIQUE NOT NULL,
[VG_OCUPANTES] [BIT] NOT NULL,
[VG_DESTINO] [VARCHAR](150) NOT NULL,
[VG_DTSAIDA] [DATETIME] NOT NULL,
CONSTRAINT [FK_VIAGENS_VEICULOS] FOREIGN KEY ([VG_VCL_PLACA]) REFERENCES [dbo].[TB_VEICULOS]([VCL_PLACA]),
CONSTRAINT [FK_VIAGENS_MOTORISTA] FOREIGN KEY ([VG_MT_CPF]) REFERENCES [dbo].[TB_MOTORISTA]([MT_CPF]),
CONSTRAINT [FK_VIAGENS_SERVICOS_EXTERNOS] FOREIGN KEY ([VG_SERVEXT_CNPJ]) REFERENCES [dbo].[TB_SERVICOS_EXTERNOS]([SERVEXT_CNPJ]),
CONSTRAINT [PK_VIAGENS] PRIMARY KEY CLUSTERED 
([VG_REQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_VIAGENS_OCUPANTES]
([VGO_VG_REQ] [INT] IDENTITY(1,1) NOT NULL,
[VGO_NOME] [VARCHAR](150) NOT NULL,
[VGO_CPF] [INT] UNIQUE NOT NULL,
CONSTRAINT [FK_VIAGENS_OCUPANTES_VIAGENS] FOREIGN KEY ([VGO_VG_REQ]) REFERENCES [dbo].[TB_VIAGENS]([VG_REQ]));

CREATE TABLE [dbo].[TB_CLIENTES]
([CLT_CPF] [INT] UNIQUE NOT NULL,
[CLT_NOME] [VARCHAR](150) NOT NULL,
[CLT_RG] [VARCHAR](12) NOT NULL,
[CLT_ENDERECO] [VARCHAR](150) NOT NULL,
[CLT_TELEFONE] [INT] NOT NULL,
[CLT_EMAIL] [VARCHAR](150) NOT NULL,
[CLT_DTNASCIMENTO] [DATE] NOT NULL,
[CLT_DTINICIO_CONTRATO] [DATE] NOT NULL,
CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
([CLT_CPF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TB_FUNCIONARIO]
([FUNC_NOME] [VARCHAR](150) NOT NULL,
[FUNC_LOGIN] [VARCHAR](25) UNIQUE NOT NULL,
[FUNC_SENHA] [VARCHAR](25) NOT NULL,
[FUNC_PERFIL_ACESSO] [TINYINT] NOT NULL, -- ENUM PERFILFUNCIONARIO : INT
CONSTRAINT [PK_FUNCIONARIO] PRIMARY KEY CLUSTERED 
([FUNC_LOGIN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO