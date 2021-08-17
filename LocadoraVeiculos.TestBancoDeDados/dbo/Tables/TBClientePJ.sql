CREATE TABLE [dbo].[TBClientePJ] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (100) NOT NULL,
    [Cnpj]     VARCHAR (14)  NOT NULL,
    [Telefone] VARCHAR (11)  NOT NULL,
    [Email]    VARCHAR (50)  NULL,
    [Cidade]   VARCHAR (50)  NOT NULL,
    [Endereco] VARCHAR (100) NOT NULL,
    [Celular]  VARCHAR (12)  NOT NULL,
    [Estado]   VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_TBClientePJ] PRIMARY KEY CLUSTERED ([Id] ASC)
);

