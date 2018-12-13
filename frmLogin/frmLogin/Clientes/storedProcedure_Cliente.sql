-- CLIENTE

-- AGREGAR CLIENTE
CREATE PROCEDURE sp_AgregarCliente(
	@identidad CHAR(15),
	@nombre NVARCHAR(100),
	@apellido NVARCHAR(100),
	@direccion NVARCHAR(2000),
	@telefono CHAR(9),
	@correo NVARCHAR(100),
	@idUsuario INT
)
AS
BEGIN
	INSERT INTO Clientes.Cliente(identidad, nombres, apellidos, direccion, telefono, correo, registradoPor)
	VALUES (@identidad, @nombre, @apellido, @direccion, @telefono, @correo, @idUsuario)
END
GO

-- ACTUALIZAR CLIENTE
CREATE PROCEDURE sp_ActualizarCliente(
	@identidad CHAR(15),
	@nombre NVARCHAR(100),
	@apellido NVARCHAR(100),
	@direccion NVARCHAR(2000),
	@telefono CHAR(9),
	@correo NVARCHAR(100),
	@idUsuario INT
)
AS
BEGIN
	UPDATE Clientes.Cliente SET nombres=@nombre, apellidos=@apellido, direccion=@direccion, telefono=@telefono, correo=@correo, registradoPor=@idUsuario
		WHERE identidad=@identidad
END
GO

-- HABILITAR-INHABILITAR CLIENTE
CREATE PROCEDURE sp_Habilitar_Inhabilitar_Cliente(
	@identidad CHAR(15),
	@msj  NVARCHAR(100) OUT
)
AS
BEGIN
	DECLARE @IN BIT
	SET @IN = (SELECT estado FROM Clientes.Cliente WHERE identidad=@identidad);
	IF (@IN = 1)
	BEGIN
		UPDATE Clientes.Cliente SET estado=0 WHERE identidad=@identidad
		SET @msj = 'Estado del cliente actualizado: Inhabilitado';
	END
	ELSE IF (@IN = 0)
	BEGIN
		UPDATE Clientes.Cliente SET estado=1 WHERE identidad=@identidad
		SET @msj = 'Estado del cliente actualizado: habilitado';
	END
END
GO