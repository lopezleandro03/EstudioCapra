CREATE TABLE [dbo].[ObjetoMultimedia] (
    [ObjetoMultimediaId] INT             NOT NULL,
    [Servidor]           VARCHAR (50)    NOT NULL,
    [Directorio]         VARCHAR (50)    NOT NULL,
    [Nombre]             VARCHAR (50)    NOT NULL,
    [Tipo]               VARCHAR (20)    NOT NULL,
    [DatosComprimidos]   VARBINARY (MAX) NOT NULL,
    CONSTRAINT [PK_ObjetoMultimedia] PRIMARY KEY CLUSTERED ([ObjetoMultimediaId] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = 'Contiene la ruta fisica al archivo, y una representacion comprimida en tipo binary', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ObjetoMultimedia';

