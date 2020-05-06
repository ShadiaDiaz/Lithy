CREATE TABLE [dbo].[TablaPersona
]
(
	[Id] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Nonbre] NVARCHAR(50) NULL, 
    [Apellido] NVARCHAR(50) NULL, 
    [Edad] INT NULL, 
    [Sexo] NVARCHAR(50) NULL, 
    [Direccion] NVARCHAR(50) NULL, 
    [Telefono] NVARCHAR(50) NULL
)
