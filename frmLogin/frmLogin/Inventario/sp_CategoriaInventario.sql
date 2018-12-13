USE GenisysERP;
GO

---------------------- Buscar -----------------------
IF OBJECT_ID('[Inventario].[sp_ListarCategoriaInventario]') IS NOT NULL
BEGIN 
    DROP PROC [Inventario].[sp_ListarCategoriaInventario]
END 
GO
CREATE PROC [Inventario].[sp_ListarCategoriaInventario]
    @Nombre NVARCHAR(100)
AS 
BEGIN

    SELECT  [idCategoria],[idCodigoTipo],[nombre],[descripcion],[idUsuario]
	FROM [Inventario].[Categoria] 
    WHERE  ([nombre] = @Nombre OR nombre IS NULL) 
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

CREATE PROC [Inventario].[sp_ActualizarCategoriaInventario]
    
	@IdCodigoTipo char(5),
    @Nombre varchar(100),
    @Descripcion varchar(100),
    @IdUsuario int
AS 
BEGIN

	UPDATE [Inventario].[Categoria]
	SET  [nombre] = @Nombre, [descripcion] = @Descripcion
		,[idUsuario] = @IdUsuario
	WHERE  [idCodigoTipo] = @IdCodigoTipo

END
GO

------------------- Inhabilitar ------------------------------
IF OBJECT_ID('[Inventario].[sp_InhabilitarCategoriaInventario]') IS NOT NULL
BEGIN 
    DROP PROC [Inventario].[sp_InhabilitarCategoriaInventario]
END 
GO

CREATE PROC [Inventario].[sp_InhabilitarCategoriaInventario]
    @IdCodigoTipo CHAR(5)
	
AS 
BEGIN

    UPDATE  [Inventario].[Categoria] SET estado  = 0
    WHERE [idCodigoTipo] = @IdCodigoTipo

END
GO
