CREATE TABLE [dbo].[TBTaxasEServicos] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [Nome]          VARCHAR (50) NOT NULL,
    [Valor]         DECIMAL (18) NOT NULL,
    [CalculoDiario] BIT          NOT NULL,
    [CalculoFixo]   BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

