CREATE TABLE [dbo].[TBCupom] (
    [Id]                 INT             IDENTITY (1, 1) NOT NULL,
    [Nome]               NVARCHAR (50)   NOT NULL,
    [DataInicio]         DATETIME        NOT NULL,
    [DataFim]            DATETIME        NOT NULL,
    [IdParceiro]         INT             NOT NULL,
    [Valor]              DECIMAL (18, 2) NOT NULL,
    [ValorMinimo]        DECIMAL (18, 2) NOT NULL,
    [CalculoReal]        BIT             NOT NULL,
    [CalculoPorcentagem] BIT             NOT NULL,
    CONSTRAINT [PK_TBCupom] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBCupom_TBParceiros] FOREIGN KEY ([IdParceiro]) REFERENCES [dbo].[TBParceiros] ([Id])
);

