USE PruebaSorbeteria3
create table Cliente
(
IDfactura int PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nombre nchar(60) NOT NULL,
Producto nchar(60) NOT NULL,
cantidad nchar(100) NULL,
precio nchar(8) NULL,
Total nchar(8) NULL
)

/****** Object:  Table [dbo].[Usuarios]    Script Date: 28/9/2023 05:35:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuarios](
	[usuario] [char](5) NULL,
	[clave] [char](5) NULL,
	[permiso] [char](1) NULL
) ON [PRIMARY]
GO
