CREATE TABLE [dbo].[Etapa] (
    [EtapaId]     INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]      VARCHAR (200)  NOT NULL,
    [Descripcion] VARCHAR (2000) NOT NULL,
    [FechaInicio] DATE           NOT NULL,
    [FechaFin]    DATE           NULL,
    CONSTRAINT [PK_Table1] PRIMARY KEY CLUSTERED ([EtapaId] ASC)
);

