CREATE TABLE [dbo].[TBCondutor] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [NomeCondutor]  VARCHAR (100) NOT NULL,
    [Endereco]      VARCHAR (100) NOT NULL,
    [Email]         VARCHAR (50)  NOT NULL,
    [Cidade]        VARCHAR (50)  NOT NULL,
    [Estado]        VARCHAR (50)  NOT NULL,
    [Telefone]      VARCHAR (11)  NOT NULL,
    [Celular]       VARCHAR (12)  NOT NULL,
    [Rg]            VARCHAR (14)  NOT NULL,
    [Cpf]           VARCHAR (11)  NOT NULL,
    [Cnh]           VARCHAR (20)  NOT NULL,
    [ValidadeCnh]   DATETIME      NOT NULL,
    [IdClienteCnpj] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBCondutor_TBClientePJ] FOREIGN KEY ([IdClienteCnpj]) REFERENCES [dbo].[TBClientePJ] ([Id])
);

