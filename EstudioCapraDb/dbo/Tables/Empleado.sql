CREATE TABLE [dbo].[Empleado] (
    [EmpleadoId]      INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]          VARCHAR (100) NOT NULL,
    [Apellido]        VARCHAR (100) NOT NULL,
    [Especializacion] VARCHAR (100) NOT NULL,
    [ContratoId]      INT           NOT NULL,
    [UserId]          INT           NULL,
    CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED ([EmpleadoId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IXFK_Empleado_Usuario]
    ON [dbo].[Empleado]([UserId] ASC);

