CREATE TABLE [dbo].[TBParceiros] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Nome]    NVARCHAR (50) NOT NULL,
    [IdMidia] INT           NOT NULL,
    CONSTRAINT [PK_TBParceiros] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBParceiros_TBMidia] FOREIGN KEY ([IdMidia]) REFERENCES [dbo].[TBMidia] ([Id])
);

