/*
	Objetivo: Crear la base de datos GenisysERP
	Autores: Alumnos POO IIIP 2018
	Fecha: Noviembre - Diciembre 2018
*/

-- Seleccionar la base de datos por defecto
USE tempdb
GO

-- Eliminar la base de datos de matricula si existe
IF EXISTS(SELECT * FROM sys.databases WHERE name = 'GenisysERP')
	BEGIN
		DROP DATABASE GenisysERP
	END
GO

-- Paso 1: Crear la base de datos
-- En este caso el nombre de la base de datos será "GenisysERP"
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'GenisysERP')
	BEGIN
		CREATE DATABASE GenisysERP
	END
GO

-- Paso 2: Seleccionar la base de datos recién creada
USE GenisysERP
GO
---------------------------------------------------------------------------------------------------------
-- Paso 3: Crear los schemas
---------------------------------------------------------------------------------------------------------
CREATE SCHEMA Compras
GO

CREATE SCHEMA Clientes
GO

CREATE SCHEMA Inventario
GO

CREATE SCHEMA Empleados
GO

CREATE SCHEMA ERP
GO
---------------------------------------------------------------------------------------------------------
-- Paso 4: Creamos las tablas del proyecto
---------------------------------------------------------------------------------------------------------
CREATE TABLE ERP.Configuracion(
	id TINYINT NOT NULL IDENTITY(1,1)
		CONSTRAINT PK_ERP_Configuracion_id PRIMARY KEY CLUSTERED,
	appkey NCHAR(50) NOT NULL,
	valor NCHAR(50) NOT NULL,
	descripcion NVARCHAR(200) NOT NULL
);
GO


CREATE TABLE Clientes.Cliente(
	idCliente INT NOT NULL IDENTITY(1000, 1)
		CONSTRAINT PK_Clientes_Cliente_idCliente PRIMARY KEY CLUSTERED,
	identidad CHAR(15) NOT NULL,
	nombres NVARCHAR(100) NOT NULL,
	apellidos NVARCHAR(100) NOT NULL,
	direccion NVARCHAR(2000) NOT NULL,
	telefono CHAR(9),
	correo NVARCHAR(100) NOT NULL,
	estado BIT DEFAULT 1
);
GO

CREATE TABLE Clientes.Proveedor(
	idProveedor INT NOT NULL IDENTITY(1000, 1)
		CONSTRAINT PK_Clientes_Proveedor_idProveedor PRIMARY KEY CLUSTERED,
	nombreEmpresa NVARCHAR(100) NOT NULL,
	direccion NVARCHAR(2000) NOT NULL,
	telefono CHAR(9),
	correo NVARCHAR(100) NOT NULL,
	estado BIT DEFAULT 1
);
GO


CREATE TABLE Clientes.Contacto(
	idContacto INT NOT NULL IDENTITY(1000, 1)
		CONSTRAINT PK_Clientes_Contacto_idContacto PRIMARY KEY CLUSTERED,
	idProveedor INT NOT NULL,
	nombres NVARCHAR(100) NOT NULL,
	apellidos NVARCHAR(100) NOT NULL,
	direccion NVARCHAR(2000) NOT NULL,
	telefono CHAR(9),
	correo NVARCHAR(100) NOT NULL,
	cargo NVARCHAR(100) NOT NULL,
	estado BIT DEFAULT 1
);
GO

CREATE TABLE Empleados.Usuario(
    id int IDENTITY(1,1)
    CONSTRAINT PK_Usuarios_id
		PRIMARY KEY NONCLUSTERED (id),
    idEmpleado int NOT NULL,
    nombreUsuario varchar(50) NOT NULL,
    contrasena varchar(256)  NOT NULL,   
);
GO

CREATE TABLE Empleados.Empleado
(
	id INT IDENTITY(1,1)
	CONSTRAINT PK_Empleado_id
		PRIMARY KEY NONCLUSTERED (id),
	identidad VARCHAR(15) NOT NULL,
	nombre VARCHAR(30) NOT NULL,
	apellido VARCHAR(30) NOT NULL,
	cargo int NOT NULL,
	telefono VARCHAR(9) NOT NULL,
	direccion VARCHAR(250) NOT NULL,
	correo VARCHAR(100) NOT NULL,
	estado INT NOT NULL
);
GO

CREATE TABLE Empleados.Cargo 
	(
	 id INT IDENTITY (1,1)
	 CONSTRAINT PK_Cargo_id
		PRIMARY KEY NONCLUSTERED (id),
	 nombre VARCHAR (30) NOT NULL,
	 nivelAcceso INT NOT NULL
);
GO

-- TABLA IMPUESTO

CREATE TABLE Inventario.Impuesto
(
idImpuesto INT NOT NULL IDENTITY (10, 1) CONSTRAINT  PK_idImpuesto PRIMARY KEY CLUSTERED (idImpuesto),
idCodigoImpuesto CHAR(5) NOT NULL,
descripcion NVARCHAR(100) NOT NULL,
valor DECIMAL NOT NULL,
fechaCreacion DATETIME NOT NULL,
idUsuario INT NOT NULL,
observasion NVARCHAR(100) NOT NULL,
estado BIT NOT NULL
);
GO

-- TABLA CATEGORIA

CREATE TABLE Inventario.Categoria
(
idCategoria INT NOT NULL IDENTITY (100, 1) CONSTRAINT PK_idCategoria PRIMARY KEY CLUSTERED (idCategoria),
idCodigoTipo CHAR(5) NOT NULL,
nombre NVARCHAR(100) NOT NULL,
descripcion NVARCHAR(100) NOT NULL,
idUsuario INT NOT NULL
);
GO

-- TABLA INVENTARIO

CREATE TABLE Inventario.Producto
(
idInventario INT NOT NULL IDENTITY (200, 1) CONSTRAINT PK_idProducto PRIMARY KEY CLUSTERED (idInventario),
idProducto CHAR(12) NOT NULL,
nombre NVARCHAR(100) NOT NULL,
cantidadExistencia INT NOT NULL,
cantidadMinima INT NOT NULL,
precioCompra FLOAT NOT NULL,
precioVenta FLOAT NOT NULL,
fechaIngreso DATETIME NOT NULL,
idUsuario INT NOT NULL,
observaciones NVARCHAR(100) NOT NULL,
idImpuesto INT NOT NULL,
idCategoria INT NOT NULL,
idProveedor INT NOT NULL,
estado BIT NOT NULL
);
GO

CREATE TABLE Compras.Compra(
	idCompra INT NOT NULL IDENTITY(100, 1),
	fechaCompra DATETIME NOT NULL,
	numeroFactura NVARCHAR(19) NOT NULL,
	idProveedor INT NOT NULL,
	subTotal DECIMAL(10,2) NOT NULL,
	impuesto DECIMAL(10,2) NOT NULL,
	total DECIMAL(10,2) NOT NULL,
	observaciones NVARCHAR(150) NULL,
	estadoCompra NVARCHAR(50) NOT NULL,
	idUsuario INT NOT NULL,
	autorizadaPor NVARCHAR(30) NULL,
	estado BIT NOT NULL
);

-- Crear la tabla "DetalleCompra" que se encarga de almacenar
-- todos los datos generales de las compras de la empresa
CREATE TABLE Compras.DetalleCompra(
	idDetalle INT NOT NULL IDENTITY(100, 1),
	idCompra INT NOT NULL,
	idProducto INT NOT NULL,
	precioUnitario DECIMAL(10,2) NOT NULL,
	cantidad SMALLINT NOT NULL,
	subTotal DECIMAL(10,2) NOT NULL
);

ALTER TABLE Compras.Compra
	ADD CONSTRAINT
		PK_idCompra_Compra PRIMARY KEY CLUSTERED (idCompra)
GO

ALTER TABLE Compras.DetalleCompra
	ADD CONSTRAINT
		PK_idCompra_DetalleCompra PRIMARY KEY CLUSTERED (idDetalle)
GO

---------------------------------------------------------------------------------------------------------
-- LLAVES FORANEAS
---------------------------------------------------------------------------------------------------------
ALTER TABLE Empleados.Empleado ADD CONSTRAINT fk_Empleado_Cargo
    FOREIGN KEY (cargo)
    REFERENCES Empleados.Cargo (id)
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;
GO

ALTER TABLE Empleados.Usuario ADD CONSTRAINT fk_Usuarios_Empleado
    FOREIGN KEY (idEmpleado)
    REFERENCES Empleados.Empleado (id)
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;
GO

ALTER TABLE Inventario.Producto
ADD CONSTRAINT FK_impuesto$id 
FOREIGN KEY (idImpuesto) REFERENCES Inventario.Impuesto (idImpuesto)
ON UPDATE NO ACTION 
ON DELETE NO ACTION 
GO

ALTER TABLE Inventario.Producto
ADD CONSTRAINT FK_categoria$id 
FOREIGN KEY (idCategoria) REFERENCES Inventario.Categoria (idCategoria)
ON UPDATE NO ACTION 
ON DELETE NO ACTION 
GO

ALTER TABLE Inventario.Producto
ADD CONSTRAINT FK_proveedor$id 
FOREIGN KEY (idProveedor) REFERENCES Clientes.Proveedor (idProveedor)
ON UPDATE NO ACTION 
ON DELETE NO ACTION
GO

ALTER TABLE Inventario.Producto
ADD CONSTRAINT FK_creadoPor$id 
FOREIGN KEY (idUsuario) REFERENCES Empleados.Usuario (id)
ON UPDATE NO ACTION 
ON DELETE NO ACTION
GO

ALTER TABLE Inventario.Categoria
ADD CONSTRAINT FK_creadoPor_Categoria$id 
FOREIGN KEY (idUsuario) REFERENCES Empleados.Usuario (id)
ON UPDATE NO ACTION 
ON DELETE NO ACTION
GO
ALTER TABLE Inventario.Impuesto
ADD CONSTRAINT FK_creadoPor_Impuesto$id 
FOREIGN KEY (idUsuario) REFERENCES Empleados.Usuario (id)
ON UPDATE NO ACTION 
ON DELETE NO ACTION
GO

ALTER TABLE Clientes.Contacto
	ADD CONSTRAINT FK_Clientes_Contactos$TieneUn$PK_Clientes_Proveedor
		FOREIGN KEY (idProveedor) REFERENCES Clientes.Proveedor(idProveedor)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
GO

ALTER TABLE Compras.Compra
	ADD CONSTRAINT
		FK_Compras_Compra$TieneUn$Clientes_Proveedor
		FOREIGN KEY(idProveedor) REFERENCES Clientes.Proveedor(idProveedor)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
GO

ALTER TABLE Compras.Compra
	ADD CONSTRAINT
		FK_Compras_Compra$TieneUn$Empleados_Usuario
		FOREIGN KEY(idUsuario) REFERENCES Empleados.Usuario(id)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
GO

-- Llaves foráneas de la tabla Compras.DetalleCompra
ALTER TABLE Compras.DetalleCompra
	ADD CONSTRAINT
		FK_Compras_DetalleCompra$TieneUn$Compras_Compra
		FOREIGN KEY(idCompra) REFERENCES Compras.Compra(idCompra)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
GO

ALTER TABLE Compras.DetalleCompra
	ADD CONSTRAINT
		FK_Compras_DetalleCompra$TieneUn$Inventario_Producto
		FOREIGN KEY(idProducto) REFERENCES Inventario.Producto(idInventario)
		ON UPDATE NO ACTION
		ON DELETE NO ACTION
GO

---------------------------------------------------------------------------
-- CHECK CONSTRAINT
---------------------------------------------------------------------------

ALTER TABLE Inventario.Producto
ADD CONSTRAINT CHK_Inventario_Inventario$CantidadExistenciaDebeSerMayorA0
CHECK (cantidadExistencia > 0)
GO

ALTER TABLE Inventario.Producto
ADD CONSTRAINT CHK_Inventario_Inventario$CantidadMinimaDebeSerMayorA0
CHECK (cantidadMinima > 0)
GO

ALTER TABLE Clientes.Cliente
	ADD CONSTRAINT CHK_identidad_Cliente$FormatoIdentidad
	CHECK (identidad LIKE '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9]')
GO

ALTER TABLE Clientes.Cliente
	ADD CONSTRAINT CHK_telefono_Cliente$FormatoTelefono
	CHECK (telefono LIKE '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
GO

ALTER TABLE Clientes.Cliente
	ADD CONSTRAINT CHK_estado_Cliente$ValoresEstado
	CHECK (estado IN (0, 1))
GO

ALTER TABLE Clientes.Proveedor
	ADD CONSTRAINT CHK_telefono_Proveedor$FormatoTelefono
	CHECK (telefono LIKE '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
GO

ALTER TABLE Compras.Compra
	ADD CONSTRAINT CHK_estadoCompra
	CHECK (estadoCompra IN ('Cotización','Orden de Compra', 'Compra'))
GO

ALTER TABLE Compras.Compra
	ADD CONSTRAINT AK_Compras_Compra$FacturaUnica
	UNIQUE (numeroFactura)
GO

ALTER TABLE Compras.Compra
	ADD CONSTRAINT CHK_SubTotalMayorQueCero
	CHECK (subTotal >= 0)
GO

ALTER TABLE Compras.Compra
	ADD CONSTRAINT CHK_ImpuestoMayorQueCero
	CHECK (impuesto >= 0)
GO

ALTER TABLE Compras.Compra
	ADD CONSTRAINT CHK_TotalMayorQueCero
	CHECK (total >= 0)
GO

ALTER TABLE Compras.Compra
	ADD CONSTRAINT DFLT_Compra_Estado
	DEFAULT '1' for estado
GO

-- Tabla Compras.DetalleCompra
ALTER TABLE Compras.DetalleCompra
	ADD CONSTRAINT CHK_CantidadMayorQueCero CHECK (cantidad>0)
GO

ALTER TABLE Compras.DetalleCompra
	ADD CONSTRAINT CHK_PrecioUnitarioMayorQueCero
	CHECK (precioUnitario >= 0)
GO

ALTER TABLE Compras.DetalleCompra
	ADD CONSTRAINT CHK_SubTotalDetalleMayorQueCero
	CHECK (subTotal >= 0)
GO
