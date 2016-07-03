CREATE TABLE [dbo].[ContratoEmpleado] (
    [Id]          INT          NOT NULL,
    [Tipo]        VARCHAR (50) NOT NULL,
    [FechaInicio] DATE         NOT NULL,
    [FechaFin]    DATE         NOT NULL,
    [Salario]     MONEY        NOT NULL,
    [ModoDePago]  VARCHAR (50) NOT NULL,
    [DiaDePago]   DATE         NOT NULL,
    [EmpleadoId]  INT          NULL,
    CONSTRAINT [PK_ContratoEmpleado] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ContratoEmpleado_Empleado] FOREIGN KEY ([EmpleadoId]) REFERENCES [dbo].[Empleado] ([EmpleadoId])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_ContratoEmpleado_Empleado]
    ON [dbo].[ContratoEmpleado]([EmpleadoId] ASC);

