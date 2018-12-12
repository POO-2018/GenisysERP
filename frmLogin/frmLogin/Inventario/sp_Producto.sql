/*Contiene los procedimientos almacenados de
iserción
actualización
inhabilitacion
de la tabla inventario.Producto
*/

CREATE PROCEDURE sp_InsertarProducto(
@idInventario int,
@idProducto int,
@nombre NVARCHAR(100),
@cantidadExistencia INT,
@cantidadMinima INT,
@precioCompra DECIMAL,
@precioVenta DECIMAL,
@fechaIngreso DATETIME,
@idUsuario INT,
@observaciones NVARCHAR(100),
@idImpuesto INT,
@idCategoria INT,
@idProveedor INT,
@estado Bit
)
AS
BEGIN
	INSERT INTO Inventario.Producto(idProducto,nombre,cantidadExistencia,cantidadMinima,precioCompra,precioVenta,fechaIngreso,
								    idUsuario,observaciones,idImpuesto,idCategoria,idProveedor,estado)
VALUES(@idProducto,@nombre,@cantidadExistencia,@cantidadMinima,@precioCompra,@precioVenta,@fechaIngreso,@idUsuario,@observaciones,
	   @idImpuesto,@idCategoria,@idProveedor,@estado);
END
GO

CREATE PROCEDURE sp_ActualizarProducto(
@idInventario int,
@idProducto int,
@nombre NVARCHAR(100),
@cantidadExistencia INT,
@cantidadMinima INT,
@precioCompra DECIMAL,
@precioVenta DECIMAL,
@fechaIngreso DATETIME,
@idUsuario INT,
@observaciones NVARCHAR(100),
@idImpuesto INT,
@idCategoria INT,
@idProveedor INT,
@estado Bit
)
AS
BEGIN
	UPDATE Inventario.Producto SET idProducto=@idProducto,nombre=@nombre,cantidadExistencia=@cantidadExistencia,
	                               cantidadMinima=@cantidadMinima,precioCompra=@precioCompra,precioVenta=@precioVenta,
								   fechaIngreso=@fechaIngreso,idUsuario=@idUsuario,observaciones=@observaciones,idImpuesto=@idImpuesto,
								   idCategoria=@idCategoria,idProveedor=@idProveedor,estado=@estado
								   WHERE idInventario=@idInventario;
END
GO

CREATE PROCEDURE sp_InhabiliarProducto(

@idInventario int
)
AS
BEGIN
	UPDATE Inventario.Producto SET estado=0
								   WHERE idInventario=@idInventario;
END