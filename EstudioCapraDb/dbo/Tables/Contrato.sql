CREATE TABLE [dbo].[Contrato] (
    [ContratoId]        INT   IDENTITY (1, 1) NOT NULL,
    [ClienteId]         INT   NOT NULL,
    [ServicioId]        INT   NOT NULL,
    [Costo]             MONEY NOT NULL,
    [FechaInicio]       DATE  NOT NULL,
    [FechaFin]          DATE  NOT NULL,
    [Saldo]             MONEY NOT NULL,
    [FechaCalculoSaldo] DATE  NOT NULL,
    CONSTRAINT [PK_ContratoServicio] PRIMARY KEY CLUSTERED ([ContratoId] ASC),
    CONSTRAINT [FK_Contrato_Servicio] FOREIGN KEY ([ServicioId]) REFERENCES [dbo].[Servicio] ([ServicioId])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_Contrato_Servicio]
    ON [dbo].[Contrato]([ServicioId] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = 'Cumple la funcion de interpuesta entre Cliente y Servicio, además agrega detalles del servicio (costo, fechas, etc)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Contrato';

