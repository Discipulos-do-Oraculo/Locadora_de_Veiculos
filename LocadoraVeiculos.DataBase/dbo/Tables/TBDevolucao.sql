CREATE TABLE [dbo].[TBDevolucao]
(
	 [Id]               INT    IDENTITY (1, 1)  NOT NULL,
    [IdLocacao]        INT      NOT NULL,
    [IdCombustivel]    INT      NOT NULL,
    [IdTaxasEServicos] INT      NOT NULL,
    [DataRetorno]      DATETIME NOT NULL,
    [KmFinal]          INT      NOT NULL,
    [LitrosTanque]     INT      NOT NULL,
    CONSTRAINT [PK_TBDevolucao] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBDevolucao_TBLocacao] FOREIGN KEY ([IdLocacao]) REFERENCES [dbo].[TBLocacao] ([Id]),
    CONSTRAINT [FK_TBDevolucao_TBCombustivel] FOREIGN KEY ([IdCombustivel]) REFERENCES [dbo].[TBCombustivel] ([Id]),
    CONSTRAINT [FK_TBDevolucao_TBTaxasEServicos] FOREIGN KEY ([IdTaxasEServicos]) REFERENCES [dbo].[TBTaxasEServicos] ([Id])
)
