CREATE TABLE [dbo].[TBLocacao] (
    [Id]               INT             NOT NULL,
    [IdCondutor]       INT             NOT NULL,
    [IdVeiculo]        INT             NOT NULL,
    [IdClientePJ]      INT             NOT NULL,
    [IdTaxasEServicos] INT             NOT NULL,
    [Plano]            VARCHAR (50)    NOT NULL,
    [ValorTotal]       DECIMAL (18, 2) NOT NULL,
    [ValorCaucao]      DECIMAL (18, 2) NOT NULL,
    [DataSaida]        DATETIME        NOT NULL,
    [DataRetorno]      DATETIME        NOT NULL,
    [KmInicial]        INT             NOT NULL,
    [KmFinal]          INT             NULL,
    CONSTRAINT [PK_TBLocacao] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBLocacao_TBClientePJ] FOREIGN KEY ([IdClientePJ]) REFERENCES [dbo].[TBClientePJ] ([Id]),
    CONSTRAINT [FK_TBLocacao_TBCondutor] FOREIGN KEY ([IdCondutor]) REFERENCES [dbo].[TBCondutor] ([Id]),
    CONSTRAINT [FK_TBLocacao_TBTaxasEServicos] FOREIGN KEY ([IdTaxasEServicos]) REFERENCES [dbo].[TBTaxasEServicos] ([Id]),
    CONSTRAINT [FK_TBLocacao_TBVeiculos] FOREIGN KEY ([IdVeiculo]) REFERENCES [dbo].[TBVeiculos] ([Id])
);

