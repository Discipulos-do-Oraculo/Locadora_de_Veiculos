CREATE TABLE [dbo].[TBVeiculos] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Veiculo]      VARCHAR (150) NOT NULL,
    [Cor]          VARCHAR (50)  NOT NULL,
    [KmAtual]      DECIMAL (18)  NOT NULL,
    [PortaMalas]   VARCHAR (50)  NOT NULL,
    [NumeroPortas] INT           NOT NULL,
    [Ano]          INT           NOT NULL,
    [Chassi]       VARCHAR (50)  NOT NULL,
    [Marca]        VARCHAR (50)  NOT NULL,
    [LitrosTanque] DECIMAL (18)  NOT NULL,
    [Placa]        VARCHAR (50)  NOT NULL,
    [Capacidade]   INT           NOT NULL,
    [Grupo]        INT           NOT NULL,
    [Imagem]       IMAGE         NOT NULL,
    CONSTRAINT [PK_TBVeiculos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBVeiculos_TBGrupoDeVeiculos] FOREIGN KEY ([Grupo]) REFERENCES [dbo].[TBGrupoDeVeiculos] ([Id])
);

