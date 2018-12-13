USE GenisysERP
GO

CREATE PROCEDURE sp_AgregarContacto(
	@idContacto CHAR(15),
	@idProveedor VARCHAR(100),
	@nombres NVARCHAR(100),
	@apellidos NVARCHAR(100),
	@direccion NVARCHAR(2000),
	@telefono CHAR(9),
	@correo NVARCHAR(100),
	@cargo NVARCHAR(100)
)
AS
BEGIN
	DECLARE @ID INT
	SET @ID = (SELECT idProveedor FROM Clientes.Proveedor WHERE nombreEmpresa=@idProveedor)
	INSERT INTO Clientes.Contacto(idContacto, idProveedor, nombres, apellidos, direccion, telefono, correo, cargo)
		VALUES (@idContacto, @ID, @nombres, @apellidos, @direccion, @telefono, @correo, @cargo)
END
GO

CREATE PROCEDURE sp_ActualizarContacto(
	@idContacto CHAR(15),
	@nombres NVARCHAR(100),
	@apellidos NVARCHAR(100),
	@direccion NVARCHAR(2000),
	@telefono CHAR(9),
	@correo NVARCHAR(100),
	@cargo NVARCHAR(100)
)
AS
BEGIN
	UPDATE Clientes.Contacto SET nombres=@nombres, apellidos=@apellidos, direccion=@direccion, telefono=@telefono, correo=@correo, cargo=@cargo
		WHERE idContacto=@idContacto
END
GO

CREATE PROCEDURE sp_Habilitar_Inhabilitar_Contacto(
	@idContacto CHAR(15),
	@msj  NVARCHAR(100) OUT
)
AS
BEGIN
	DECLARE @IN BIT
	SET @IN = (SELECT estado FROM Clientes.Contacto WHERE idContacto=@idContacto);
	IF (@IN = 1)
	BEGIN
		UPDATE Clientes.Contacto SET estado=0 WHERE idContacto=@idContacto
		SET @msj = 'Estado del contacto actualizado: Inhabilitado';
	END
	ELSE IF (@IN = 0)
	BEGIN
		UPDATE Clientes.Contacto SET estado=1 WHERE idContacto=@idContacto
		SET @msj = 'Estado del contacto actualizado: habilitado';
	END
END
GO
