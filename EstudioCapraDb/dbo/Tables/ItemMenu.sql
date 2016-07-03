CREATE TABLE [dbo].[ItemMenu] (
    [ItemMenuId]      INT           NOT NULL,
    [Name]            VARCHAR (100) NOT NULL,
    [Orden]           INT           NOT NULL,
    [Estado]          BIT           NOT NULL,
    [ItemMenuPadreId] INT           NOT NULL,
    [Controlador]     VARCHAR (50)  NOT NULL,
    [Accion]          VARCHAR (50)  NOT NULL,
    [Parametros]      VARCHAR (500) NULL
);


GO
CREATE NONCLUSTERED INDEX [IXFK_MenuItem_MenuItem]
    ON [dbo].[ItemMenu]([ItemMenuPadreId] ASC);

