USE [GenisysERP];
GO

IF OBJECT_ID('[Empleados].[sp_ListarUsuario]') IS NOT NULL
BEGIN 
    DROP PROC [Empleados].[sp_ListarUsuario] 
END 
GO
CREATE PROC [Empleados].[sp_ListarUsuario] 
    @id int
AS 
BEGIN

	SELECT [id], [idEmpleado], [nombreUsuario], [contrasena] 
	FROM   [Empleados].[Usuario] 
	WHERE  ([id] = @id) 
END
GO

IF OBJECT_ID('[Empleados].[sp_InsertarUsuario]') IS NOT NULL
BEGIN 
    DROP PROC [Empleados].[sp_InsertarUsuario] 
END 
GO
CREATE PROC [Empleados].[sp_InsertarUsuario] 
    @idEmpleado int,
    @nombreUsuario varchar(50),
    @contrasena varchar(256)
AS 
BEGIN
	
	INSERT INTO [Empleados].[Usuario] ([idEmpleado], [nombreUsuario], [contrasena])
	SELECT @idEmpleado, @nombreUsuario, @contrasena
	
END
GO

IF OBJECT_ID('[Empleados].[sp_ActualizarUsuario]') IS NOT NULL
BEGIN 
    DROP PROC [Empleados].[sp_ActualizarUsuario] 
END 
GO
CREATE PROC [Empleados].[sp_ActualizarUsuario] 
    @id int,
    @idEmpleado int,
    @nombreUsuario varchar(50),
    @contrasena varchar(256)
AS 
BEGIN

	UPDATE [Empleados].[Usuario]
	SET    [idEmpleado] = @idEmpleado, [nombreUsuario] = @nombreUsuario, [contrasena] = @contrasena
	WHERE  [id] = @id
END
GO

IF OBJECT_ID('[Empleados].[sp_EliminarUsuario]') IS NOT NULL
BEGIN 
    DROP PROC [Empleados].[sp_EliminarUsuario] 
END 
GO
CREATE PROC [Empleados].[sp_EliminarUsuario] 
    @id int
AS 
BEGIN

	DELETE
	FROM   [Empleados].[Usuario]
	WHERE  [id] = @id

END
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------

