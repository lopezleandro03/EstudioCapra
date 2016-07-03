CREATE TABLE [dbo].[Usuario] (
    [UserId]     INT           IDENTITY (1, 1) NOT NULL,
    [Email]      VARCHAR (200) NOT NULL,
    [Nombre]     VARCHAR (100) NOT NULL,
    [Apellido]   VARCHAR (100) NOT NULL,
    [Contraseña] VARCHAR (200) NOT NULL,
    [Direccion]  VARCHAR (500) NOT NULL,
    [Telefono1]  VARCHAR (50)  NOT NULL,
    [Telefono2]  VARCHAR (50)  NULL
);

