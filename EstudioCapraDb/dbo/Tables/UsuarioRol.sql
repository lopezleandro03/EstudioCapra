CREATE TABLE [dbo].[UsuarioRol] (
    [RolId]  INT NOT NULL,
    [UserId] INT NOT NULL,
    CONSTRAINT [FK_UsuarioRol_Rol] FOREIGN KEY ([RolId]) REFERENCES [dbo].[Rol] ([RolId])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_UsuarioRol_Rol]
    ON [dbo].[UsuarioRol]([RolId] ASC);


GO
CREATE NONCLUSTERED INDEX [IXFK_UsuarioRol_Usuario]
    ON [dbo].[UsuarioRol]([UserId] ASC);

