USE [OlimpiaDB]
GO
/****** Object:  Table [dbo].[ControlAcceso]    Script Date: 20/12/2020 18:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlAcceso](
	[IdControlAcceso] [int] IDENTITY(1,1) NOT NULL,
	[EstadoAcceso] [nvarchar](50) NULL,
	[IdUsuario] [int] NULL,
	[IdEstadio] [int] NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_ControlAcceso] PRIMARY KEY CLUSTERED 
(
	[IdControlAcceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estadio]    Script Date: 20/12/2020 18:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estadio](
	[IdEstadio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](250) NULL,
	[CapacidadMaxima] [numeric](18, 0) NULL,
	[CapacidadPermitida] [numeric](18, 0) NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFinal] [date] NOT NULL,
 CONSTRAINT [PK_Estadio] PRIMARY KEY CLUSTERED 
(
	[IdEstadio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 20/12/2020 18:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](250) NULL,
	[Apellidos] [nvarchar](250) NULL,
	[Documento] [nvarchar](250) NULL,
	[TipoDocumento] [nvarchar](4) NULL,
	[Direccion] [nvarchar](250) NULL,
	[Celular] [nvarchar](250) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ControlAcceso] ON 

INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (1, N'Entrada', 1, 1, NULL)
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (2, N'Entrada', 2, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (3, N'Entrada', 3, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (4, N'Entrada', 4, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (5, N'Entrada', 5, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (6, N'Entrada', 6, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (7, N'Salidad', 7, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (8, N'Entrada', 8, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (9, N'Entrada', 9, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (10, N'Entrada', 10, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (11, N'Entrada', 11, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (12, N'Entrada', 12, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (13, N'Entrada', 13, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ControlAcceso] ([IdControlAcceso], [EstadoAcceso], [IdUsuario], [IdEstadio], [Fecha]) VALUES (14, N'Entrada', 14, 1, CAST(N'2020-12-20' AS Date))
SET IDENTITY_INSERT [dbo].[ControlAcceso] OFF
SET IDENTITY_INSERT [dbo].[Estadio] ON 

INSERT [dbo].[Estadio] ([IdEstadio], [Nombre], [CapacidadMaxima], [CapacidadPermitida], [FechaInicio], [FechaFinal]) VALUES (1, N'Giuseppe Meazza', CAST(80018 AS Numeric(18, 0)), CAST(24005 AS Numeric(18, 0)), CAST(N'2020-12-20' AS Date), CAST(N'2020-12-27' AS Date))
INSERT [dbo].[Estadio] ([IdEstadio], [Nombre], [CapacidadMaxima], [CapacidadPermitida], [FechaInicio], [FechaFinal]) VALUES (3, N'Nacional', CAST(100 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(N'2020-12-18' AS Date), CAST(N'2020-12-22' AS Date))
SET IDENTITY_INSERT [dbo].[Estadio] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (1, N'Pumas Vencedores', N'Gonzalez', N'1234', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (2, N'prueba1', N'Gonzalez', N'123456', N'Cc', N'', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (3, N'prueba1', N'Gonzalez', N'123456', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (4, N'prueba1', N'Gonzalez', N'123456', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (5, N'Pumas Vencedores', N'Gonzalez', N'123456', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (6, N'Pumas Vencedores', N'Gonzalez', N'123456', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (7, N'Pumas Vencedores', N'Gonzalez', N'1234567', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (8, N'Pumas Vencedores', N'Gonzalez', N'11123333', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (9, N'Pumas Vencedores', N'Gonzalez', N'12345678', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (10, N'Pumas Vencedores', N'Gonzalez', N'232332322323', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (11, N'Pumas Vencedores', N'Gonzalez', N'12345654544554', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (12, N'Pumas Vencedores', N'Gonzalez', N'12345654544554122121', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (13, N'Pumas Vencedores', N'Gonzalez', N'1234565454455412212122112', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellidos], [Documento], [TipoDocumento], [Direccion], [Celular], [Estado]) VALUES (14, N'Pumas Vencedores', N'Gonzalez', N'1234565454455412212122112323223', N'Cc', N'calle 70 a bis a #117-15', N'3223', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[ControlAcceso]  WITH CHECK ADD  CONSTRAINT [FK_ControlAcceso_Estadio] FOREIGN KEY([IdEstadio])
REFERENCES [dbo].[Estadio] ([IdEstadio])
GO
ALTER TABLE [dbo].[ControlAcceso] CHECK CONSTRAINT [FK_ControlAcceso_Estadio]
GO
ALTER TABLE [dbo].[ControlAcceso]  WITH CHECK ADD  CONSTRAINT [FK_ControlAcceso_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[ControlAcceso] CHECK CONSTRAINT [FK_ControlAcceso_Usuario]
GO
