CREATE TABLE [dbo].[EtapaServicio] (
    [id]         INT IDENTITY (1, 1) NOT NULL,
    [ServicioId] INT NOT NULL,
    [EtapaId]    INT NOT NULL,
    CONSTRAINT [PK_Etapa] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_EtapaServicio_Etapa] FOREIGN KEY ([EtapaId]) REFERENCES [dbo].[Etapa] ([EtapaId])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_Etapa_Servicio]
    ON [dbo].[EtapaServicio]([ServicioId] ASC);


GO
CREATE NONCLUSTERED INDEX [IXFK_Etapa_Servicio_02]
    ON [dbo].[EtapaServicio]([ServicioId] ASC);


GO
CREATE NONCLUSTERED INDEX [IXFK_EtapaServicio_Etapa]
    ON [dbo].[EtapaServicio]([EtapaId] ASC);

