USE GenisysERP;
GO

IF OBJECT_ID('[Inventario].[sp_InsertarCategoriaInventario]') IS NOT NULL
BEGIN 
    DROP PROC [Inventario].[sp_InsertarCategoriaInventario]
END 
GO
CREATE PROC [Inventario].[sp_InsertarCategoriaInventario]
    --@CategoriaInventario_Id int,
	@IdCodigoTipo int,
    @Nombre varchar(50),
    @Descripcion varchar(100),
    @IdUsuario varchar(30)
AS 
	SET NOCOUNT ON 
BEGIN
	
	INSERT INTO [GenisysERP].[Inventario].[Categoria] ([idCodigoTipo],[nombre]
					,[descripcion],[idUsuario])

	SELECT @IdCodigoTipo,@Nombre,@Descripcion,@IdUsuario

	
END
GO

--EXEC dbo.sp_InsertarCategoriaInventario  01, 'Papeleria', 'Productos que solo se usan en oficina','jvarela001' 
--SELECT * FROM  Inventario.Categoria