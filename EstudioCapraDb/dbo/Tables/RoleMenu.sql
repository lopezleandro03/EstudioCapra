CREATE TABLE [dbo].[RoleMenu] (
    [RolId]      INT NOT NULL,
    [ItemMenuId] INT NOT NULL,
    CONSTRAINT [FK_RoleMenu_Rol] FOREIGN KEY ([RolId]) REFERENCES [dbo].[Rol] ([RolId])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_RoleMenu_ItemMenu]
    ON [dbo].[RoleMenu]([ItemMenuId] ASC);


GO
CREATE NONCLUSTERED INDEX [IXFK_RoleMenu_Rol]
    ON [dbo].[RoleMenu]([RolId] ASC);

