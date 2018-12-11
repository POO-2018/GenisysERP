-- PROVEEDOR


-- AGREGAR PROVEEDOR
CREATE PROCEDURE sp_AgregarProveedor(
	@nombreEmpresa NVARCHAR(100),
	@direccion NVARCHAR(2000),
	@telefono CHAR(9),
	@correo NVARCHAR(100)
)
AS
BEGIN
	INSERT INTO Clientes.Proveedor(nombreEmpresa, direccion, telefono, correo)
		VALUES (@nombreEmpresa,@direccion,@telefono,@correo)
END
GO

-- ACTUALIZAR PROVEEDOR
CREATE PROCEDURE sp_ActualizarProveedor(
	@nombreEmpresa NVARCHAR(100),
	@direccion NVARCHAR(2000),
	@telefono CHAR(9),
	@correo NVARCHAR(100)
)
AS
BEGIN
	UPDATE Clientes.Proveedor SET direccion=@direccion, telefono=@telefono, correo=@correo
		WHERE nombreEmpresa=@nombreEmpresa
END
GO

-- HABILITAR-INHABILITAR PROVEEDOR
CREATE PROCEDURE sp_Habilitar_Inhabilitar_Proveedor(
	@nombreEmpresa NVARCHAR(100),
	@msj  NVARCHAR(100) OUT
)
AS
BEGIN
	DECLARE @IN BIT
	SET @IN = (SELECT estado FROM Clientes.Proveedor WHERE nombreEmpresa=@nombreEmpresa);
	IF (@IN = 1)
	BEGIN
		UPDATE Clientes.Proveedor SET estado=0 WHERE nombreEmpresa=@nombreEmpresa
		SET @msj = 'Estado del Proveedor actualizado: Inhabilitado';
	END
	ELSE IF (@IN = 0)
	BEGIN
		UPDATE Clientes.Proveedor SET estado=1 WHERE nombreEmpresa=@nombreEmpresa
		SET @msj = 'Estado del Proveedor actualizado: Habilitado';
	END
END
GO

-- CARGAR PROVEEDORES
CREATE PROCEDURE sp_CargarProveedores
AS
SELECT idProveedor, nombreEmpresa FROM Clientes.Proveedor
GO
