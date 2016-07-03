CREATE TABLE [dbo].[Rol] (
    [RolId]       INT           NOT NULL,
    [Status]      VARCHAR (50)  NOT NULL,
    [Nombre]      VARCHAR (50)  NOT NULL,
    [Descripcion] VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED ([RolId] ASC)
);

