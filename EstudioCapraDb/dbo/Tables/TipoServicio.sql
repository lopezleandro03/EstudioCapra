CREATE TABLE [dbo].[TipoServicio] (
    [TipoServicioId] INT           NOT NULL,
    [Nombre]         VARCHAR (200) NOT NULL,
    [Descripcion]    VARCHAR (MAX) NOT NULL,
    [Atributo1]      VARCHAR (MAX) NULL,
    [Atributo2]      VARCHAR (MAX) NULL,
    [Atributo3]      VARCHAR (MAX) NULL,
    [Atributo4]      VARCHAR (MAX) NULL,
    [Atributo5]      VARCHAR (MAX) NULL,
    [Atributo6]      VARCHAR (MAX) NULL,
    [Atributo7]      VARCHAR (MAX) NULL,
    CONSTRAINT [PK_TipoServicio] PRIMARY KEY CLUSTERED ([TipoServicioId] ASC)
);

