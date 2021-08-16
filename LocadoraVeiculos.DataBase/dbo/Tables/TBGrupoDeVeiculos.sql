CREATE TABLE [dbo].[TBGrupoDeVeiculos] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Nome]  VARCHAR (100) NOT NULL,
    [Valor] DECIMAL (18)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

