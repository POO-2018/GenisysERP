USE GenisysERP;
GO
---------------------- Buscar -----------------------
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

------------------------- Insertar--------------------------
IF OBJECT_ID('[Inventario].[sp_InsertarCategoriaInventario]') IS NOT NULL
BEGIN 
    DROP PROC [Inventario].[sp_InsertarCategoriaInventario]
END 
GO
CREATE PROC [Inventario].[sp_InsertarCategoriaInventario]
    --@CategoriaInventario_Id int,
	@IdCodigoTipo char(5),
    @Nombre varchar(100),
    @Descripcion varchar(100),
    @IdUsuario int
AS 
	SET NOCOUNT ON 
BEGIN
	
	INSERT INTO [GenisysERP].[Inventario].[Categoria] ([idCodigoTipo],[nombre]
					,[descripcion],[idUsuario])

	SELECT @IdCodigoTipo,@Nombre,@Descripcion,@IdUsuario
END
GO

-----------------------Actualizar--------------------------
IF OBJECT_ID('[Inventario].[sp_ActiualizarCategoriaInventario]') IS NOT NULL
BEGIN 
    DROP PROC [Inventario].[sp_ActiualizarCategoriaInventario]
END 
GO

CREATE PROC [Inventario].[sp_ActiualizarCategoriaInventario]
    
    @IdCategoria int,
	@IdCodigoTipo char(5),
    @Nombre varchar(100),
    @Descripcion varchar(100),
    @IdUsuario int
AS 
BEGIN

	UPDATE [Inventario].[Categoria]
	SET [idCodigoTipo] = @IdCodigoTipo, [nombre] = @Nombre, [descripcion] = @Descripcion
		,[idUsuario] = @IdUsuario
	WHERE  [idCategoria] = @IdCategoria

END
GO

------------------- Eliminar ------------------------------
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
