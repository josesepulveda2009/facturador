create database [DataJsv]
USE [DataJsv]
GO
/****** Object:  Table [dbo].[articulo]    Script Date: 18/01/2019 6:00:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[articulo](
	[img] [varchar](max) NULL,
	[codigo] [varchar](20) NULL,
	[descripcion] [varchar](50) NULL,
	[precio] [float] NULL,
	[estado] [bit] NULL,
	[fechaHoraDig] [datetime] NULL CONSTRAINT [DF__articulo__fechaH__06CD04F7]  DEFAULT (getdate()),
	[usuarioDig] [varchar](20) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__articulo__3213E83F02084FDA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__articulo__40F9A20604E4BC85] UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 18/01/2019 6:00:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[nombres] [varchar](100) NULL,
	[cedula] [varchar](20) NULL,
	[direccion] [varchar](max) NULL,
	[telefonos] [varchar](50) NULL,
	[estado] [bit] NULL,
	[fechaHoraDig] [datetime] NULL DEFAULT (getdate()),
	[usuarioDig] [varchar](20) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle]    Script Date: 18/01/2019 6:00:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle](
	[factura] [int] NULL,
	[articulo] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [float] NULL,
	[total]  AS ([cantidad]*[precio])
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[empresa]    Script Date: 18/01/2019 6:00:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empresa](
	[nombre o razon social] [varchar](100) NULL,
	[nit] [varchar](50) NULL,
	[telefonos] [varchar](50) NULL,
	[direccion] [varchar](max) NULL,
	[logo] [varchar](max) NULL,
	[representante] [varchar](100) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[factura]    Script Date: 18/01/2019 6:00:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[factura](
	[factura] [varchar](10) NULL,
	[fecha] [date] NULL,
	[subtotal] [float] NULL,
	[descuento] [float] NULL,
	[impuesto] [float] NULL,
	[total] [float] NULL,
	[estado] [bit] NULL,
	[cliente] [int] NULL,
	[fechaHoraDig] [datetime] NULL,
	[usuarioDig] [varchar](20) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__factura__3213E83F797309D9] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__factura__B3BC03387C4F7684] UNIQUE NONCLUSTERED 
(
	[factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 18/01/2019 6:00:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[usuario] [varchar](20) NOT NULL,
	[contraseña] [varchar](20) NULL,
	[nivel] [varchar](20) NULL,
	[estado] [bit] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[factura] ADD  CONSTRAINT [DF__factura__fechaHo__7F2BE32F]  DEFAULT (getdate()) FOR [fechaHoraDig]
GO
ALTER TABLE [dbo].[detalle]  WITH CHECK ADD  CONSTRAINT [FK__detalle__articul__09A971A2] FOREIGN KEY([articulo])
REFERENCES [dbo].[articulo] ([id])
GO
ALTER TABLE [dbo].[detalle] CHECK CONSTRAINT [FK__detalle__articul__09A971A2]
GO
ALTER TABLE [dbo].[detalle]  WITH CHECK ADD  CONSTRAINT [FK__detalle__factura__08B54D69] FOREIGN KEY([factura])
REFERENCES [dbo].[factura] ([id])
GO
ALTER TABLE [dbo].[detalle] CHECK CONSTRAINT [FK__detalle__factura__08B54D69]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK__factura__cliente__7E37BEF6] FOREIGN KEY([cliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK__factura__cliente__7E37BEF6]
GO
