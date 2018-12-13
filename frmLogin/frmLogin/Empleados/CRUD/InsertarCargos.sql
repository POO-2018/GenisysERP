USE [GenisysERP]
GO

INSERT INTO [Empleados].[Cargo]
           ([nombre]
           ,[nivelAcceso])
     VALUES
           ('Administrador'
           ,3)
GO

USE [GenisysERP]
GO

INSERT INTO [Empleados].[Cargo]
           ([nombre]
           ,[nivelAcceso])
     VALUES
           ('Gerente'
           ,2)
GO

USE [GenisysERP]
GO

INSERT INTO [Empleados].[Cargo]
           ([nombre]
           ,[nivelAcceso])
     VALUES
           ('Contador'
           ,1)
GO

INSERT INTO [Empleados].[Empleado]
           ([identidad]
           ,[nombre]
           ,[apellido]
           ,[cargo]
           ,[telefono]
           ,[direccion]
           ,[correo]
           ,[estado])
     VALUES
           ('0318-1995-00191'
           ,'Carlos'
           ,'Valladarez'
           ,1
           ,'9856-4512'
           ,'Comayagua'
           ,'Valladares@gmail.com'
           ,1)
GO

INSERT INTO [Empleados].[Usuario]
           ([idEmpleado]
           ,[nombreUsuario]
           ,[contrasena])
     VALUES
           (1
           ,'Admin'
           ,'5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5')
GO
