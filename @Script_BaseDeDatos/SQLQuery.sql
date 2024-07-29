USE [master]
GO
/****** Object:  Database [Proyectodecurso]    Script Date: 29/07/2024 12:42:50 ******/
CREATE DATABASE [Proyectodecurso]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proyectodecurso', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.DESARROLLOO\MSSQL\DATA\Proyectodecursocddd.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proyectodecurso_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.DESARROLLOO\MSSQL\DATA\Proyectodecursocddd_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Proyectodecurso] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proyectodecurso].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proyectodecurso] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proyectodecurso] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proyectodecurso] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proyectodecurso] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proyectodecurso] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proyectodecurso] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proyectodecurso] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proyectodecurso] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proyectodecurso] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proyectodecurso] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proyectodecurso] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proyectodecurso] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proyectodecurso] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proyectodecurso] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proyectodecurso] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Proyectodecurso] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proyectodecurso] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proyectodecurso] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proyectodecurso] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proyectodecurso] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proyectodecurso] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proyectodecurso] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proyectodecurso] SET RECOVERY FULL 
GO
ALTER DATABASE [Proyectodecurso] SET  MULTI_USER 
GO
ALTER DATABASE [Proyectodecurso] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proyectodecurso] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proyectodecurso] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proyectodecurso] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proyectodecurso] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Proyectodecurso] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Proyectodecurso', N'ON'
GO
ALTER DATABASE [Proyectodecurso] SET QUERY_STORE = ON
GO
ALTER DATABASE [Proyectodecurso] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Proyectodecurso]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_EsEntidadActiva]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_EsEntidadActiva] (@id INT)
RETURNS BIT
AS
BEGIN
    DECLARE @resultado BIT;
    SELECT @resultado = CASE WHEN estado = 'A' THEN 1 ELSE 0 END
    FROM dbo.fac_entidad
    WHERE id = @id;

    RETURN @resultado;
END
GO
/****** Object:  UserDefinedFunction [dbo].[fn_get_total_con_impuestos]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_get_total_con_impuestos] (@id INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @total DECIMAL(18, 2);
    SELECT @total = total
    FROM [dbo].[fac_cabecera]
    WHERE id = @id;
    RETURN @total;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetTotalByCabecera]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_GetTotalByCabecera]
(
    @id_cabecera INT
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @total DECIMAL(18, 2)
    
    SELECT @total = SUM(precio_unitario * cantidad)
    FROM dbo.fac_detalle
    WHERE id_cabecera = @id_cabecera
    
    RETURN @total
END
GO
/****** Object:  Table [dbo].[fac_cabecera]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fac_cabecera](
	[id] [int] NOT NULL,
	[punto_emision] [varchar](3) NOT NULL,
	[num_establecimiento] [varchar](3) NOT NULL,
	[num_serie] [int] NOT NULL,
	[id_bodega] [int] NOT NULL,
	[id_entidad] [int] NOT NULL,
	[id_forma_pago] [int] NOT NULL,
	[subtotal] [decimal](18, 2) NOT NULL,
	[iva] [decimal](18, 2) NOT NULL,
	[descuento] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NOT NULL,
	[fecha__creacion] [date] NOT NULL,
	[usuario_crea] [varchar](10) NULL,
	[estado] [char](1) NULL,
 CONSTRAINT [PK_fac_cabecera] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_fac_cabecera]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_fac_cabecera]
AS
SELECT 
    id,
    punto_emision,
    num_establecimiento,
    num_serie,
    id_bodega,
    id_entidad,
    id_forma_pago,
    subtotal,
    iva,
    descuento,
    total,
    fecha__creacion,
    usuario_crea,
    estado
FROM 
    [dbo].[fac_cabecera];
GO
/****** Object:  Table [dbo].[fac_detalle]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fac_detalle](
	[id] [int] NOT NULL,
	[id_cabecera] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[id_item] [int] NOT NULL,
	[precio_unitario] [decimal](18, 2) NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[usuario_crea] [varchar](10) NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_fac_detalle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_Active_fac_detalle]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Active_fac_detalle]
AS
SELECT * FROM dbo.fac_detalle
WHERE estado = 'A' -- Asumimos que 'A' representa un estado activo
GO
/****** Object:  Table [dbo].[fac_entidad]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fac_entidad](
	[id] [int] NOT NULL,
	[num_identificacion] [varchar](13) NOT NULL,
	[id_tipo_identificacion] [int] NOT NULL,
	[id_tipo_entidad] [int] NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
	[telefono_movil] [varchar](10) NOT NULL,
	[email] [varchar](50) NULL,
	[fecha_creacion] [date] NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_fac_entidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fac_tipo_entidad]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fac_tipo_entidad](
	[id] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_fac_tipo_entidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fac_tipo_identificacion]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fac_tipo_identificacion](
	[id] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_fac_tipo_identificacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_Entidades]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Entidades]
AS
SELECT 
    e.id,
    e.num_identificacion,
    e.id_tipo_identificacion,
    ti.descripcion AS tipo_identificacion,
    e.id_tipo_entidad,
    te.descripcion AS tipo_entidad,
    e.apellidos,
    e.nombres,
    e.direccion,
    e.telefono_movil,
    e.email,
    e.fecha_creacion,
    e.estado
FROM 
    dbo.fac_entidad e
JOIN 
    dbo.fac_tipo_identificacion ti ON e.id_tipo_identificacion = ti.id
JOIN 
    dbo.fac_tipo_entidad te ON e.id_tipo_entidad = te.id
GO
/****** Object:  Table [dbo].[fac_forma_pago]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fac_forma_pago](
	[id] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[porcentaje_recargo] [int] NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_fac_forma_pago] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inv_bodega]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inv_bodega](
	[id] [int] NOT NULL,
	[codigo] [varchar](15) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[id_tipo_bodega] [int] NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_inv_bodega] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inv_categoria]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inv_categoria](
	[id] [int] NOT NULL,
	[id_marca] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_inv_categoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inv_clase_movimiento]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inv_clase_movimiento](
	[id] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_inv_clase_movimiento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inv_item]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inv_item](
	[id] [int] NOT NULL,
	[codigo] [varchar](15) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[id_unidad_medida] [int] NOT NULL,
	[id_subcategoria] [int] NULL,
	[stock_general] [int] NOT NULL,
	[costo] [decimal](18, 2) NOT NULL,
	[precio] [decimal](18, 2) NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[usuario_crea] [varchar](10) NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_inv_item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inv_item_bodega]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inv_item_bodega](
	[id] [int] NOT NULL,
	[id_item] [int] NOT NULL,
	[id_bodega] [int] NOT NULL,
	[stock] [int] NOT NULL,
	[costo] [decimal](18, 2) NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_inv_item_bodega] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inv_marca]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inv_marca](
	[id] [int] NOT NULL,
	[descripcion] [char](50) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_inv_marca] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inv_movimiento]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inv_movimiento](
	[id] [int] NOT NULL,
	[id_item_bodega] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[costo] [decimal](18, 2) NOT NULL,
	[id_tipo_movimiento] [int] NOT NULL,
	[id_clase_movimiento] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[usuario_crea] [varchar](10) NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_inv_movimiento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inv_subcategoria]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inv_subcategoria](
	[id] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_inv_subcategoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inv_tipo_bodega]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inv_tipo_bodega](
	[id] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_inv_tipo_bodega] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inv_tipo_movimiento]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inv_tipo_movimiento](
	[id] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_inv_tipo_movimiento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inv_unidad_medida]    Script Date: 29/07/2024 12:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inv_unidad_medida](
	[id] [int] NOT NULL,
	[siglas] [varchar](4) NOT NULL,
	[descripcion] [varbinary](50) NOT NULL,
	[estado] [char](1) NOT NULL,
 CONSTRAINT [PK_inv_unidad_medida] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[fac_cabecera]  WITH CHECK ADD  CONSTRAINT [FK_fac_cabecera_fac_entidad] FOREIGN KEY([id_entidad])
REFERENCES [dbo].[fac_entidad] ([id])
GO
ALTER TABLE [dbo].[fac_cabecera] CHECK CONSTRAINT [FK_fac_cabecera_fac_entidad]
GO
ALTER TABLE [dbo].[fac_cabecera]  WITH CHECK ADD  CONSTRAINT [FK_fac_cabecera_fac_forma_pago] FOREIGN KEY([id_forma_pago])
REFERENCES [dbo].[fac_forma_pago] ([id])
GO
ALTER TABLE [dbo].[fac_cabecera] CHECK CONSTRAINT [FK_fac_cabecera_fac_forma_pago]
GO
ALTER TABLE [dbo].[fac_cabecera]  WITH CHECK ADD  CONSTRAINT [FK_fac_cabecera_inv_bodega] FOREIGN KEY([id_bodega])
REFERENCES [dbo].[inv_bodega] ([id])
GO
ALTER TABLE [dbo].[fac_cabecera] CHECK CONSTRAINT [FK_fac_cabecera_inv_bodega]
GO
ALTER TABLE [dbo].[fac_detalle]  WITH CHECK ADD  CONSTRAINT [FK_fac_detalle_fac_cabecera] FOREIGN KEY([id_cabecera])
REFERENCES [dbo].[fac_cabecera] ([id])
GO
ALTER TABLE [dbo].[fac_detalle] CHECK CONSTRAINT [FK_fac_detalle_fac_cabecera]
GO
ALTER TABLE [dbo].[fac_entidad]  WITH CHECK ADD  CONSTRAINT [FK_fac_entidad_fac_tipo_entidad] FOREIGN KEY([id_tipo_entidad])
REFERENCES [dbo].[fac_tipo_entidad] ([id])
GO
ALTER TABLE [dbo].[fac_entidad] CHECK CONSTRAINT [FK_fac_entidad_fac_tipo_entidad]
GO
ALTER TABLE [dbo].[fac_entidad]  WITH CHECK ADD  CONSTRAINT [FK_fac_entidad_fac_tipo_identificacion] FOREIGN KEY([id_tipo_identificacion])
REFERENCES [dbo].[fac_tipo_identificacion] ([id])
GO
ALTER TABLE [dbo].[fac_entidad] CHECK CONSTRAINT [FK_fac_entidad_fac_tipo_identificacion]
GO
ALTER TABLE [dbo].[inv_bodega]  WITH CHECK ADD  CONSTRAINT [FK_inv_bodega_inv_tipo_bodega] FOREIGN KEY([id_tipo_bodega])
REFERENCES [dbo].[inv_tipo_bodega] ([id])
GO
ALTER TABLE [dbo].[inv_bodega] CHECK CONSTRAINT [FK_inv_bodega_inv_tipo_bodega]
GO
ALTER TABLE [dbo].[inv_categoria]  WITH CHECK ADD  CONSTRAINT [FK_inv_categoria_inv_marca] FOREIGN KEY([id_marca])
REFERENCES [dbo].[inv_marca] ([id])
GO
ALTER TABLE [dbo].[inv_categoria] CHECK CONSTRAINT [FK_inv_categoria_inv_marca]
GO
ALTER TABLE [dbo].[inv_item]  WITH CHECK ADD  CONSTRAINT [FK_inv_item_inv_subcategoria] FOREIGN KEY([id_subcategoria])
REFERENCES [dbo].[inv_subcategoria] ([id])
GO
ALTER TABLE [dbo].[inv_item] CHECK CONSTRAINT [FK_inv_item_inv_subcategoria]
GO
ALTER TABLE [dbo].[inv_item]  WITH CHECK ADD  CONSTRAINT [FK_inv_item_inv_unidad_medida] FOREIGN KEY([id_unidad_medida])
REFERENCES [dbo].[inv_unidad_medida] ([id])
GO
ALTER TABLE [dbo].[inv_item] CHECK CONSTRAINT [FK_inv_item_inv_unidad_medida]
GO
ALTER TABLE [dbo].[inv_item_bodega]  WITH CHECK ADD  CONSTRAINT [FK_inv_item_bodega_inv_bodega] FOREIGN KEY([id_bodega])
REFERENCES [dbo].[inv_bodega] ([id])
GO
ALTER TABLE [dbo].[inv_item_bodega] CHECK CONSTRAINT [FK_inv_item_bodega_inv_bodega]
GO
ALTER TABLE [dbo].[inv_item_bodega]  WITH CHECK ADD  CONSTRAINT [FK_inv_item_bodega_inv_item] FOREIGN KEY([id_item])
REFERENCES [dbo].[inv_item] ([id])
GO
ALTER TABLE [dbo].[inv_item_bodega] CHECK CONSTRAINT [FK_inv_item_bodega_inv_item]
GO
ALTER TABLE [dbo].[inv_movimiento]  WITH CHECK ADD  CONSTRAINT [FK_inv_movimiento_inv_clase_movimiento] FOREIGN KEY([id_clase_movimiento])
REFERENCES [dbo].[inv_clase_movimiento] ([id])
GO
ALTER TABLE [dbo].[inv_movimiento] CHECK CONSTRAINT [FK_inv_movimiento_inv_clase_movimiento]
GO
ALTER TABLE [dbo].[inv_movimiento]  WITH CHECK ADD  CONSTRAINT [FK_inv_movimiento_inv_item_bodega] FOREIGN KEY([id_item_bodega])
REFERENCES [dbo].[inv_item_bodega] ([id])
GO
ALTER TABLE [dbo].[inv_movimiento] CHECK CONSTRAINT [FK_inv_movimiento_inv_item_bodega]
GO
ALTER TABLE [dbo].[inv_movimiento]  WITH CHECK ADD  CONSTRAINT [FK_inv_movimiento_inv_tipo_movimiento] FOREIGN KEY([id_tipo_movimiento])
REFERENCES [dbo].[inv_tipo_movimiento] ([id])
GO
ALTER TABLE [dbo].[inv_movimiento] CHECK CONSTRAINT [FK_inv_movimiento_inv_tipo_movimiento]
GO
ALTER TABLE [dbo].[inv_subcategoria]  WITH CHECK ADD  CONSTRAINT [FK_inv_subcategoria_inv_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[inv_categoria] ([id])
GO
ALTER TABLE [dbo].[inv_subcategoria] CHECK CONSTRAINT [FK_inv_subcategoria_inv_categoria]
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarEntidad]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarEntidad]
    @id INT,
    @num_identificacion VARCHAR(13),
    @id_tipo_identificacion INT,
    @id_tipo_entidad INT,
    @apellidos VARCHAR(50),
    @nombres VARCHAR(50),
    @direccion VARCHAR(100),
    @telefono_movil VARCHAR(10),
    @email VARCHAR(50) = NULL,
    @estado CHAR(1)
AS
BEGIN
    UPDATE dbo.fac_entidad
    SET 
        num_identificacion = @num_identificacion,
        id_tipo_identificacion = @id_tipo_identificacion,
        id_tipo_entidad = @id_tipo_entidad,
        apellidos = @apellidos,
        nombres = @nombres,
        direccion = @direccion,
        telefono_movil = @telefono_movil,
        email = @email,
        estado = @estado
    WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_create_fac_cabecera]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_create_fac_cabecera]
    @punto_emision VARCHAR(3),
    @num_establecimiento VARCHAR(3),
    @num_serie INT,
    @id_bodega INT,
    @id_entidad INT,
    @id_forma_pago INT,
    @subtotal DECIMAL(18, 2),
    @iva DECIMAL(18, 2),
    @descuento DECIMAL(18, 2) = NULL,
    @total DECIMAL(18, 2),
    @fecha__creacion DATE,
    @usuario_crea VARCHAR(10) = NULL,
    @estado CHAR(1) = NULL
AS
BEGIN
    INSERT INTO [dbo].[fac_cabecera] (
        punto_emision, num_establecimiento, num_serie, id_bodega, id_entidad, 
        id_forma_pago, subtotal, iva, descuento, total, fecha__creacion, 
        usuario_crea, estado
    )
    VALUES (
        @punto_emision, @num_establecimiento, @num_serie, @id_bodega, @id_entidad, 
        @id_forma_pago, @subtotal, @iva, @descuento, @total, @fecha__creacion, 
        @usuario_crea, @estado
    );
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_fac_cabecera]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_delete_fac_cabecera]
    @id INT
AS
BEGIN
    UPDATE [dbo].[fac_cabecera]
    SET estado = 'I'
    WHERE id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_Delete_fac_detalle]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Delete_fac_detalle]
    @id INT
AS
BEGIN
    DELETE FROM dbo.fac_detalle WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarEntidad]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarEntidad]
    @id INT
AS
BEGIN
    DELETE FROM dbo.fac_entidad
    WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_get_fac_cabecera]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_get_fac_cabecera]
    @id INT
AS
BEGIN
    SELECT * 
    FROM [dbo].[fac_cabecera]
    WHERE id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_Get_fac_detalle]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Get_fac_detalle]
AS
BEGIN
    SELECT * FROM dbo.fac_detalle
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Insert_fac_detalle]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Insert_fac_detalle]
    @id INT,
    @id_cabecera INT,
    @cantidad INT,
    @id_item INT,
    @precio_unitario DECIMAL(18, 2),
    @fecha_creacion DATE,
    @usuario_crea VARCHAR(10),
    @estado CHAR(1)
AS
BEGIN
    INSERT INTO dbo.fac_detalle (id, id_cabecera, cantidad, id_item, precio_unitario, fecha_creacion, usuario_crea, estado)
    VALUES (@id, @id_cabecera, @cantidad, @id_item, @precio_unitario, @fecha_creacion, @usuario_crea, @estado)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarEntidad]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarEntidad]
    @num_identificacion VARCHAR(13),
    @id_tipo_identificacion INT,
    @id_tipo_entidad INT,
    @apellidos VARCHAR(50),
    @nombres VARCHAR(50),
    @direccion VARCHAR(100),
    @telefono_movil VARCHAR(10),
    @email VARCHAR(50) = NULL,
    @fecha_creacion DATE,
    @estado CHAR(1)
AS
BEGIN
    INSERT INTO dbo.fac_entidad (
        num_identificacion,
        id_tipo_identificacion,
        id_tipo_entidad,
        apellidos,
        nombres,
        direccion,
        telefono_movil,
        email,
        fecha_creacion,
        estado
    )
    VALUES (
        @num_identificacion,
        @id_tipo_identificacion,
        @id_tipo_entidad,
        @apellidos,
        @nombres,
        @direccion,
        @telefono_movil,
        @email,
        @fecha_creacion,
        @estado
    )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SeleccionarEntidades]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SeleccionarEntidades]
AS
BEGIN
    SELECT 
        id,
        num_identificacion,
        id_tipo_identificacion,
        id_tipo_entidad,
        apellidos,
        nombres,
        direccion,
        telefono_movil,
        email,
        fecha_creacion,
        estado
    FROM dbo.fac_entidad
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SeleccionarEntidadPorID]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_SeleccionarEntidadPorID]
    @id INT
AS
BEGIN
    SELECT 
        id,
        num_identificacion,
        id_tipo_identificacion,
        id_tipo_entidad,
        apellidos,
        nombres,
        direccion,
        telefono_movil,
        email,
        fecha_creacion,
        estado
    FROM dbo.fac_entidad
    WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_fac_cabecera]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_update_fac_cabecera]
    @id INT,
    @punto_emision VARCHAR(3),
    @num_establecimiento VARCHAR(3),
    @num_serie INT,
    @id_bodega INT,
    @id_entidad INT,
    @id_forma_pago INT,
    @subtotal DECIMAL(18, 2),
    @iva DECIMAL(18, 2),
    @descuento DECIMAL(18, 2) = NULL,
    @total DECIMAL(18, 2),
    @fecha__creacion DATE,
    @usuario_crea VARCHAR(10) = NULL,
    @estado CHAR(1) = NULL
AS
BEGIN
    UPDATE [dbo].[fac_cabecera]
    SET 
        punto_emision = @punto_emision,
        num_establecimiento = @num_establecimiento,
        num_serie = @num_serie,
        id_bodega = @id_bodega,
        id_entidad = @id_entidad,
        id_forma_pago = @id_forma_pago,
        subtotal = @subtotal,
        iva = @iva,
        descuento = @descuento,
        total = @total,
        fecha__creacion = @fecha__creacion,
        usuario_crea = @usuario_crea,
        estado = @estado
    WHERE id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_Update_fac_detalle]    Script Date: 29/07/2024 12:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Update_fac_detalle]
    @id INT,
    @id_cabecera INT,
    @cantidad INT,
    @id_item INT,
    @precio_unitario DECIMAL(18, 2),
    @fecha_creacion DATE,
    @usuario_crea VARCHAR(10),
    @estado CHAR(1)
AS
BEGIN
    UPDATE dbo.fac_detalle
    SET id_cabecera = @id_cabecera,
        cantidad = @cantidad,
        id_item = @id_item,
        precio_unitario = @precio_unitario,
        fecha_creacion = @fecha_creacion,
        usuario_crea = @usuario_crea,
        estado = @estado
    WHERE id = @id
END
GO
USE [master]
GO
ALTER DATABASE [Proyectodecurso] SET  READ_WRITE 
GO
