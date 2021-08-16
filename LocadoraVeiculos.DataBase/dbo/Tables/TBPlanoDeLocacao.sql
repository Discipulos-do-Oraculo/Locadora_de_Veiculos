CREATE TABLE [dbo].[TBPlanoDeLocacao]
(
	[Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Titulo]  VARCHAR (100) NOT NULL,
    [Valor] DECIMAL (18) NOT NULL,
    [Descricao] VARCHAR (1000) ,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
