USE GenisysERP
GO



ALTER TABLE ERP.Configuracion
	ADD  estado bit NOT NULL;
GO

CREATE PROCEDURE sp_InsertartConfiguracion(
@appkey nchar(50),
@valor nchar(50),
@descripcion nvarchar(200)
)
AS
BEGIN
INSERT INTO ERP.Configuracion(appkey,valor,descripcion,estado) VALUES(@appkey,@valor,@descripcion,1);
END
GO

CREATE PROCEDURE sp_ActualizarConfiguracion(
@appkey nchar(50),
@id tinyint,
@valor nchar(50),
@descripcion nvarchar(200)

)
AS
BEGIN
UPDATE ERP.Configuracion SET appkey=@appkey,valor=@valor,descripcion=@descripcion,estado=1 WHERE id=@id;
END
GO


Create PROCEDURE sp_Inhabilitar(
@id tinyint
)
AS
BEGIN
	UPDATE ERP.Configuracion SET estado=0 WHERE id= @id;
END
GO