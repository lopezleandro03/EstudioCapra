CREATE TABLE [dbo].[TipoTarea] (
    [TipoTareaId]   INT           NOT NULL,
    [Nombre]        VARCHAR (200) NOT NULL,
    [TareaTemplate] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_TipoTarea] PRIMARY KEY CLUSTERED ([TipoTareaId] ASC)
);

