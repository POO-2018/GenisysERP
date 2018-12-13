USE GenisysERP
GO

CREATE PROCEDURE sp_ActualizarEstadoAOrden(
	@idCompra INT,
	@autorizadaPor INT
)
AS
BEGIN
	UPDATE Compras.Compra SET estadoCompra = 'Orden de Compra', autorizadaPor = @autorizadaPor WHERE idCompra = @idCompra;
END
GO

CREATE PROCEDURE sp_ActualizarEstadoACompra(
	@idCompra INT,
	@autorizadaPor INT,
	@numeroFactura NVARCHAR(19)
)
AS
BEGIN
	UPDATE Compras.Compra SET estadoCompra = 'Compra', autorizadaPor = @autorizadaPor, numeroFactura = @numeroFactura WHERE idCompra = @idCompra;
END
GO

CREATE PROCEDURE sp_InsertarProductosCompra(
	@idProducto INT,
	@cantidadCompra INT
)
AS
BEGIN
	DECLARE @cantidadExistencia INT;
	SET @cantidadExistencia = 0;

	SET @cantidadExistencia = (SELECT cantidadExistencia FROM Inventario.Producto WHERE idInventario = @idProducto);

	DECLARE @nuevaExistencia INT;
	SET @nuevaExistencia = 0;

	SET @nuevaExistencia = @cantidadCompra + @cantidadExistencia;
	
	UPDATE Inventario.Producto SET cantidadExistencia = @nuevaExistencia WHERE idInventario = @idProducto;																																																																																																					
END
GO

CREATE PROCEDURE sp_InhabilitarCompra(
	@idCompra INT
)
AS
BEGIN
	UPDATE Compras.Compra SET estado = 0 WHERE idCompra = @idCompra;
END
GO

CREATE PROCEDURE sp_EliminarProductosCompra(
	@idProducto INT,
	@cantidadCompra INT
)
AS
BEGIN
	DECLARE @cantidadExistencia INT;
	SET @cantidadExistencia = 0;

	SET @cantidadExistencia = (SELECT cantidadExistencia FROM Inventario.Producto WHERE idInventario = @idProducto);

	DECLARE @nuevaExistencia INT;
	SET @nuevaExistencia = 0;

	SET @nuevaExistencia = @cantidadExistencia - @cantidadCompra;
	
	UPDATE Inventario.Producto SET cantidadExistencia = @nuevaExistencia WHERE idInventario = @idProducto;																																																																																																					
END
GO

CREATE PROCEDURE sp_InsertarDetalleCompra(
@idCompra INT,
@idProducto INT,
@precioUnitario DECIMAL(10,2),
@cantidad SMALLINT,
@subTotal DECIMAL(10,2)
)
AS
BEGIN
	INSERT INTO Compras.DetalleCompra(idCompra,idProducto,precioUnitario,cantidad,subTotal)
	VALUES(@idCompra,@idProducto,@precioUnitario,@cantidad,@subTotal)
END
GO


-- Exec este comando es solo para ejecutar el procedure


CREATE PROCEDURE sp_ActualizarDetalleCompra (
@idDetalle INT,
@cantidad SMALLINT,
@subTotal DECIMAL(10,2)
)
AS
BEGIN
	 UPDATE Compras.DetalleCompra SET cantidad=@cantidad,subtotal=@subTotal
	 WHERE idDetalle=@idDetalle;
END
GO


CREATE PROCEDURE sp_EliminarDetalleCompra(
@idDetalle INT
)
AS
BEGIN
	DELETE FROM Compras.DetalleCompra WHERE idDetalle=@idDetalle;
END
GO

CREATE PROCEDURE sp_InsertarCompra (
--@fechaCompra DATETIME,
--@numeroFactura NVARCHAR(19),
@idProveedor INT,
@subTotal DECIMAL(10,2),
@impuesto DECIMAL(10,2),
@total DECIMAL(10,2),
@observaciones NVARCHAR(150),
@estadoCompra NVARCHAR(50),
@idUsuario INT
--@autorizadaPor INT
)
AS
BEGIN
	INSERT INTO Compras.Compra(fechaCompra, idProveedor, subTotal, impuesto, total, observaciones, 
						   estadoCompra, idUsuario, autorizadaPor)
	VALUES( GetDate(), @idProveedor, @subTotal, @impuesto, @total, @observaciones, @estadoCompra, @idUsuario, null)
END
GO

CREATE PROCEDURE sp_ActualizarCompra(
@idCompra INT,
@subTotal DECIMAL(10,2),
@impuesto DECIMAL(10,2),
@total DECIMAL(10,2),
@observaciones NVARCHAR(150),
@Usuario INT
)
AS
BEGIN

	 UPDATE Compras.Compra SET fechaCompra=getDate(), subTotal=@subTotal, impuesto=@impuesto, 
	 Total=@total, observaciones=@observaciones, 
	 idUsuario=@Usuario
 	 WHERE idCompra=@idCompra;
END
GO
