CREATE TABLE [dbo].[RecursoFisico] (
    [RecursoFisicoId]     INT           NOT NULL,
    [TipoRecursoId]       INT           NOT NULL,
    [Nombre]              VARCHAR (50)  NOT NULL,
    [Descripcion]         VARCHAR (MAX) NOT NULL,
    [FechaAdquisicion]    DATE          NOT NULL,
    [FechaFinGarantia]    DATE          NULL,
    [Especificaciones]    VARCHAR (MAX) NULL,
    [TipoRecursoFisicoId] INT           NULL,
    CONSTRAINT [PK_RecursoFisico] PRIMARY KEY CLUSTERED ([RecursoFisicoId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IXFK_RecursoFisico_TipoRecursoFisico]
    ON [dbo].[RecursoFisico]([TipoRecursoFisicoId] ASC);

