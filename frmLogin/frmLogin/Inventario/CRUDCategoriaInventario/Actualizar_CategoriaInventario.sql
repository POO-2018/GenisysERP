USE GenisysERP;
GO

IF OBJECT_ID('[Inventario].[sp_ActiualizarCategoriaInventario]') IS NOT NULL
BEGIN 
    DROP PROC [Inventario].[sp_ActiualizarCategoriaInventario]
END 
GO

CREATE PROC [Inventario].[sp_ActiualizarCategoriaInventario]
    
    @IdCategoria int,
	@IdCodigoTipo int,
    @Nombre varchar(50),
    @Descripcion varchar(100),
    @IdUsuario varchar(30)
AS 
BEGIN

	UPDATE [Inventario].[Categoria]
	SET [idCodigoTipo] = @IdCodigoTipo, [nombre] = @Nombre, [descripcion] = @Descripcion
		,[idUsuario] = @IdUsuario
	WHERE  [idCategoria] = @IdCategoria

END
GO


