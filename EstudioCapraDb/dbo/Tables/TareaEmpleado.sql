CREATE TABLE [dbo].[TareaEmpleado] (
    [id]         BIGINT       IDENTITY (1, 1) NOT NULL,
    [TareaId]    INT          NOT NULL,
    [EmpleadoId] INT          NOT NULL,
    [Status]     VARCHAR (50) NOT NULL,
    CONSTRAINT [FK_TareaEmpleado_Empleado] FOREIGN KEY ([EmpleadoId]) REFERENCES [dbo].[Empleado] ([EmpleadoId])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_TareaEmpleado_Empleado]
    ON [dbo].[TareaEmpleado]([EmpleadoId] ASC);


GO
CREATE NONCLUSTERED INDEX [IXFK_TareaEmpleado_Tarea]
    ON [dbo].[TareaEmpleado]([TareaId] ASC);

