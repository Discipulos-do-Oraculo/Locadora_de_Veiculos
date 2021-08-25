CREATE TABLE [dbo].[TBLocacao_TBTaxasEServicos] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [IdTaxaServico] INT NOT NULL,
    [IdLocacao]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBLocacao_TBLocacao] FOREIGN KEY ([IdLocacao]) REFERENCES [dbo].[TBLocacao] ([Id]),
    CONSTRAINT [FK_TBLocacao_TBTaxasEServicos] FOREIGN KEY ([IdTaxaServico]) REFERENCES [dbo].[TBTaxasEServicos] ([Id])
);

