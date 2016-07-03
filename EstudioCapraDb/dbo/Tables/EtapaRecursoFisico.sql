CREATE TABLE [dbo].[EtapaRecursoFisico] (
    [EtapaId]         INT          NOT NULL,
    [Id]              BIGINT       NOT NULL,
    [RecursoId]       INT          NOT NULL,
    [Status]          VARCHAR (50) NOT NULL,
    [RecursoFisicoId] INT          NULL,
    CONSTRAINT [PK_EtapaRecurso] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EtapaRecursoFisico_Etapa] FOREIGN KEY ([EtapaId]) REFERENCES [dbo].[Etapa] ([EtapaId]),
    CONSTRAINT [FK_EtapaRecursoFisico_RecursoFisico] FOREIGN KEY ([RecursoFisicoId]) REFERENCES [dbo].[RecursoFisico] ([RecursoFisicoId])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_EtapaRecursoFisico_Etapa]
    ON [dbo].[EtapaRecursoFisico]([EtapaId] ASC);


GO
CREATE NONCLUSTERED INDEX [IXFK_EtapaRecursoFisico_RecursoFisico]
    ON [dbo].[EtapaRecursoFisico]([RecursoFisicoId] ASC);

