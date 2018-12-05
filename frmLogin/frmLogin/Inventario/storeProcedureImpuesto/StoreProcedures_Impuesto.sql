USE GenisysERP
GO

--- STORE PROCEDURE PARA INSETAR

CREATE PROCEDURE sp_InsertarImpuesto
(
	@idCodigoImpuesto CHAR(5),
	@descripcion NVARCHAR(100),
	@valor DECIMAL,
	@fechaCreacion DATETIME, 
	@idUsuario INT,
	@observacion NVARCHAR(100),
	@estado BIT
)
AS 
BEGIN 
	SET NOCOUNT ON 
	INSERT INTO Inventario.Impuesto(idCodigoImpuesto, descripcion, valor, fechaCreacion, idUsuario, observasion, estado)
VALUES(@idCodigoImpuesto, @descripcion,@valor, @fechaCreacion, @idUsuario, @observacion, @estado)
END 
GO

--- STORE PROCEDUE PARA ACTULIZAR

CREATE PROCEDURE sp_ActualizarImpuesto
(
	@idImpuesto INT,
	@idCodigoImpuesto CHAR(5),
	@descripcion NVARCHAR(100),
	@valor DECIMAL,
	@fechaCreacion DATETIME, 
	@idUsuario INT,
	@observacion NVARCHAR(100),
	@estado BIT

)
AS BEGIN 
UPDATE Inventario.Impuesto
	SET idCodigoImpuesto=@idCodigoImpuesto,
		descripcion= @descripcion,
		valor= @valor,
		fechaCreacion=@fechaCreacion,
		idUsuario=@idUsuario,
		observasion=@observacion,
		estado=@estado
	WHERE idImpuesto = @idImpuesto
END 
GO


---  STORE PROCEDURE ELIMINAR

CREATE PROCEDURE sp_EliminarImpuesto
(
	@idImpuesto INT
)
AS 
DELETE FROM Inventario.Impuesto
	WHERE @idImpuesto = idImpuesto
GO