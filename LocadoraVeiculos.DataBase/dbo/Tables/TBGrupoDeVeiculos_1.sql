CREATE TABLE [dbo].[TBGrupoDeVeiculos] (
    [Id]                 INT             IDENTITY (1, 1) NOT NULL,
    [Nome]               VARCHAR (100)   NOT NULL,
    [ValorDiaria]        DECIMAL (18, 2) NOT NULL,
    [ValorKmDiaria]      DECIMAL (18, 2) NOT NULL,
    [ValorKmLivre]       DECIMAL (18, 2) NOT NULL,
    [LimiteKmControlado] DECIMAL (18, 2) NOT NULL,
    [ValorKmControlado]  DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

