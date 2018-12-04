USE GenisysERP;
GO

IF OBJECT_ID('[Inventario].[sp_ListarCategoriaInventario]') IS NOT NULL
BEGIN 
    DROP PROC [Inventario].[sp_ListarCategoriaInventario]
END 
GO
CREATE PROC [Inventario].[sp_ListarCategoriaInventario]
    @idCategoria int
AS 
BEGIN

    SELECT  [idCategoria],[idCodigoTipo],[nombre],[descripcion],[idUsuario]
	FROM [Inventario].[Categoria] 
    WHERE  ([idCategoria] = @idCategoria OR idCategoria IS NULL) 
END
GO

