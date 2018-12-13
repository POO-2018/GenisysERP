USE [GenisysERP];
GO

IF OBJECT_ID('[Empleados].[sp_ListarEmpleado]') IS NOT NULL
BEGIN 
    DROP PROC [Empleados].[sp_ListarEmpleado] 
END 
GO
CREATE PROC [Empleados].[sp_ListarEmpleado] 
    @id int
AS 
BEGIN

	SELECT [id], [identidad], [nombre], [apellido], [cargo], [telefono], [direccion], [correo], [estado]  
	FROM   [Empleados].[Empleado] 
	WHERE  ([id] = @id) 
END
GO

IF OBJECT_ID('[Empleados].[sp_InsertarEmpleado]') IS NOT NULL
BEGIN 
    DROP PROC [Empleados].[sp_InsertarEmpleado] 
END 
GO
CREATE PROC [Empleados].[sp_InsertarEmpleado] 
    @identidad varchar(15),
    @nombre varchar(30),
    @apellido varchar(30),
	@cargo int,
	@telefono varchar(9),
	@direccion varchar(250),
	@correo varchar(100),
	@estado int

AS
BEGIN
	
	INSERT INTO [Empleados].[Empleado] ([identidad], [nombre], [apellido], [cargo], [telefono], [direccion], [correo], [estado])
	SELECT @identidad, @nombre, @apellido, @cargo, @telefono, @direccion, @correo, @estado 
	
END
GO

IF OBJECT_ID('[Empleados].[sp_ActualizarEmpleado]') IS NOT NULL
BEGIN 
    DROP PROC [Empleados].[sp_ActualizarEmpleado] 
END 
GO
CREATE PROC [Empleados].[sp_ActualizarEmpleado] 
	@id int,
    @identidad varchar(15),
    @nombre varchar(30),
    @apellido varchar(30),
	@cargo int,
	@telefono varchar(9),
	@direccion varchar(250),
	@correo varchar(100),
	@estado int
AS 
BEGIN

	UPDATE [Empleados].[Empleado]
	SET    [identidad] = @identidad, [nombre] = @nombre, [apellido] = @apellido, [cargo] = @cargo, [telefono] = @telefono, 
		   [direccion] = @direccion, [correo] = @correo, [estado] = @estado
	WHERE  [id] = @id
END
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------
