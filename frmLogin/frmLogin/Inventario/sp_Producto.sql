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
@precioCompra FLOAT,
@precioVenta FLOAT,
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
@precioCompra FLOAT,
@precioVenta FLOAT,
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
