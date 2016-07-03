CREATE TABLE [dbo].[Servicio] (
    [ServicioId]     INT IDENTITY (1, 1) NOT NULL,
    [TipoServicioId] INT NOT NULL,
	[Name] Varchar(50) NOT NULL,
    CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED ([ServicioId] ASC),
    CONSTRAINT [FK_Servicio_TipoServicio] FOREIGN KEY ([TipoServicioId]) REFERENCES [dbo].[TipoServicio] ([TipoServicioId])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_Servicio_TipoServicio]
    ON [dbo].[Servicio]([TipoServicioId] ASC);

