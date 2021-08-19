CREATE TABLE [dbo].[TBFuncionario] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [nome]          VARCHAR (100) NOT NULL,
    [endereco]      VARCHAR (100) NOT NULL,
    [email]         VARCHAR (50)  NOT NULL,
    [cidade]        VARCHAR (50)  NOT NULL,
    [estado]        VARCHAR (50)  NOT NULL,
    [telefone]      VARCHAR (11)  NOT NULL,
    [celular]       VARCHAR (12)  NOT NULL,
    [login]         VARCHAR (50)  NOT NULL,
    [senha]         VARCHAR (50)  NOT NULL,
    [dataDeEntrada] DATETIME      NOT NULL,
    [salario]       DECIMAL (18)  NOT NULL,
    [cpf]           VARCHAR (12)  NULL,
    [rg]            VARCHAR (14)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

