CREATE TABLE [dbo].[Tarea] (
    [TareaId]      INT            IDENTITY (1, 1) NOT NULL,
    [TipoTareaId]  INT            NOT NULL,
    [Nombre]       VARCHAR (200)  NOT NULL,
    [Descripcion]  VARCHAR (4000) NOT NULL,
    [FechaInicio]  DATE           NOT NULL,
    [FechaFin]     DATE           NOT NULL,
    [TareaPadreId] INT            NULL,
    CONSTRAINT [FK_Tarea_TipoTarea] FOREIGN KEY ([TipoTareaId]) REFERENCES [dbo].[TipoTarea] ([TipoTareaId])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_Tarea_Tarea]
    ON [dbo].[Tarea]([TareaPadreId] ASC);


GO
CREATE NONCLUSTERED INDEX [IXFK_Tarea_TipoTarea]
    ON [dbo].[Tarea]([TipoTareaId] ASC);

