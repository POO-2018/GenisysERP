USE GenisysERP;
GO

IF OBJECT_ID('[Inventario].[sp_EliminarCategoriaInventario]') IS NOT NULL
BEGIN 
    DROP PROC [Inventario].[sp_EliminarCategoriaInventario]
END 
GO

CREATE PROC [Inventario].[sp_EliminarCategoriaInventario]
    @idCategoria int
AS 
BEGIN

    DELETE FROM [Inventario].[Categoria]
    WHERE  [idCategoria] = @idCategoria

END
GO