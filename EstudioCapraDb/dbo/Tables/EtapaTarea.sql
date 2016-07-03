CREATE TABLE [dbo].[EtapaTarea] (
    [id]      BIGINT IDENTITY (1, 1) NOT NULL,
    [EtapaId] INT    NOT NULL,
    [TareaId] INT    NOT NULL,
    CONSTRAINT [FK_EtapaTarea_Etapa] FOREIGN KEY ([EtapaId]) REFERENCES [dbo].[Etapa] ([EtapaId])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_EtapaTarea_Etapa]
    ON [dbo].[EtapaTarea]([EtapaId] ASC);


GO
CREATE NONCLUSTERED INDEX [IXFK_EtapaTarea_Tarea]
    ON [dbo].[EtapaTarea]([TareaId] ASC);

