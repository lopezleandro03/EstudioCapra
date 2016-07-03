CREATE TABLE [dbo].[EtapaObjectoMultimedia] (
    [id]                  BIGINT IDENTITY (1, 1) NOT NULL,
    [EtapaId]             INT    NOT NULL,
    [ObjectoMultimediaId] INT    NOT NULL,
    [ObjetoMultimediaId]  INT    NULL,
    CONSTRAINT [FK_EtapaObjectoMultimedia_Etapa] FOREIGN KEY ([EtapaId]) REFERENCES [dbo].[Etapa] ([EtapaId]),
    CONSTRAINT [FK_EtapaObjectoMultimedia_ObjetoMultimedia] FOREIGN KEY ([ObjetoMultimediaId]) REFERENCES [dbo].[ObjetoMultimedia] ([ObjetoMultimediaId])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_EtapaObjectoMultimedia_Etapa]
    ON [dbo].[EtapaObjectoMultimedia]([EtapaId] ASC);


GO
CREATE NONCLUSTERED INDEX [IXFK_EtapaObjectoMultimedia_ObjetoMultimedia]
    ON [dbo].[EtapaObjectoMultimedia]([ObjetoMultimediaId] ASC);

