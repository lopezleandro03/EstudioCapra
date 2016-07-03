CREATE TABLE [dbo].[Cliente] (
    [ClienteId] INT           NOT NULL,
    [Nombre]    VARCHAR (100) NOT NULL,
    [Apellido]  VARCHAR (100) NOT NULL,
    [Direccion] VARCHAR (500) NOT NULL,
    [Telefono]  VARCHAR (50)  NOT NULL,
    [Telefono2] VARCHAR (50)  NULL,
    [UserId]    INT           NULL,
    CONSTRAINT [PK_Table2] PRIMARY KEY CLUSTERED ([ClienteId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IXFK_Cliente_Usuario]
    ON [dbo].[Cliente]([UserId] ASC);

