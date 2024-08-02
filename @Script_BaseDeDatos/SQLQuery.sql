USE [master]
GO
/****** Object:  Database [PROYECTO_INVENTARIO]    Script Date: 31/07/2024 17:23:33 ******/
CREATE DATABASE [PROYECTO_INVENTARIO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PROYECTO_INVENTARIO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PROYECTO_INVENTARIO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PROYECTO_INVENTARIO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PROYECTO_INVENTARIO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PROYECTO_INVENTARIO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET ARITHABORT OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET  MULTI_USER 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PROYECTO_INVENTARIO', N'ON'
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET QUERY_STORE = ON
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PROYECTO_INVENTARIO]
GO
/****** Object:  Table [dbo].[TB_CLIENTE]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_CLIENTE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [nvarchar](50) NULL,
	[APELLIDO] [nvarchar](50) NULL,
	[CEDULA] [nvarchar](20) NULL,
	[EDAD] [int] NULL,
	[CORREO] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_CEDULA] UNIQUE NONCLUSTERED 
(
	[CEDULA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_FACTURACION]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_FACTURACION](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NUM_FACTURA] [varchar](20) NOT NULL,
	[CEDULA] [varchar](15) NOT NULL,
	[CLIENTE] [varchar](100) NOT NULL,
	[LIBRO] [varchar](100) NOT NULL,
	[CANTIDAD] [int] NOT NULL,
	[PRECIO_CANTIDAD] [decimal](18, 2) NOT NULL,
	[DETALLES] [text] NULL,
	[DESCUENTO] [decimal](5, 2) NULL,
	[PRECIO_TOTAL] [decimal](18, 2) NOT NULL,
	[METODO_DE_PAGO] [varchar](50) NULL,
	[ESTADO] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_LIBROS]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_LIBROS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TITULO] [nvarchar](255) NOT NULL,
	[AUTOR] [nvarchar](255) NOT NULL,
	[ANIO] [int] NOT NULL,
	[CANTIDAD] [int] NOT NULL,
	[PRECIO] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_TITULO] UNIQUE NONCLUSTERED 
(
	[TITULO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_LOGIN]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_LOGIN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USUARIO] [varchar](30) NULL,
	[CONTRASEÑA] [varchar](30) NULL,
	[APELLIDOS_NOMBRES] [varchar](100) NULL,
	[CORREO_ELECTRONICO] [varchar](100) NULL,
	[ROL] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Usuario] UNIQUE NONCLUSTERED 
(
	[USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_RESERVA]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_RESERVA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USUARIO_ID] [int] NOT NULL,
	[CLIENTE_ID] [int] NOT NULL,
	[LIBRO_ID] [int] NOT NULL,
	[CANTIDAD] [int] NOT NULL,
	[PRECIOTOTAL] [decimal](10, 2) NOT NULL,
	[FECHA_RESERVA] [datetime] NOT NULL,
	[ESTADO] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_STOCK_ENTRADA]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_STOCK_ENTRADA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_LIBRO] [int] NULL,
	[CANTIDAD] [int] NULL,
	[FECHA] [date] NULL,
	[PROVEEDOR] [varchar](255) NULL,
	[COMENTARIOS] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_STOCK_SALIDA]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_STOCK_SALIDA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_LIBRO] [int] NULL,
	[CANTIDAD] [int] NULL,
	[FECHA] [date] NULL,
	[MOTIVO] [varchar](255) NULL,
	[REFERENCIA] [varchar](255) NULL,
	[COMENTARIOS] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_VENTAS]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_VENTAS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USUARIO_ID] [int] NULL,
	[CLIENTE_ID] [int] NULL,
	[LIBRO_ID] [int] NULL,
	[CANTIDAD] [int] NULL,
	[PRECIOTOTAL] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TB_FACTURACION] ADD  DEFAULT ('PAGADO') FOR [ESTADO]
GO
ALTER TABLE [dbo].[TB_STOCK_ENTRADA]  WITH CHECK ADD  CONSTRAINT [FK__TB_STOCK___ID_LI__44FF419A] FOREIGN KEY([ID_LIBRO])
REFERENCES [dbo].[TB_LIBROS] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TB_STOCK_ENTRADA] CHECK CONSTRAINT [FK__TB_STOCK___ID_LI__44FF419A]
GO
ALTER TABLE [dbo].[TB_STOCK_SALIDA]  WITH CHECK ADD FOREIGN KEY([ID_LIBRO])
REFERENCES [dbo].[TB_LIBROS] ([ID])
GO
ALTER TABLE [dbo].[TB_VENTAS]  WITH CHECK ADD FOREIGN KEY([CLIENTE_ID])
REFERENCES [dbo].[TB_CLIENTE] ([ID])
GO
ALTER TABLE [dbo].[TB_VENTAS]  WITH CHECK ADD FOREIGN KEY([USUARIO_ID])
REFERENCES [dbo].[TB_LOGIN] ([ID])
GO
ALTER TABLE [dbo].[TB_VENTAS]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([CLIENTE_ID])
REFERENCES [dbo].[TB_CLIENTE] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TB_VENTAS] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
/****** Object:  StoredProcedure [dbo].[EditarCliente]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarCliente]
    @id INT,
    @nombre VARCHAR(255),
    @apellido VARCHAR(255),
    @cedula VARCHAR(50),
    @edad INT,
    @correo VARCHAR(255)
AS
BEGIN
    UPDATE TB_CLIENTE
    SET NOMBRE = @nombre,
        APELLIDO = @apellido,
        CEDULA = @cedula,
        EDAD = @edad,
        CORREO = @correo
    WHERE ID = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[EditarLibro]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarLibro]
    @id INT,
    @titulo VARCHAR(255),
    @autor VARCHAR(255),
    @anio INT,
    @cantidad INT,
    @precio DECIMAL(18, 2)
AS
BEGIN
    UPDATE TB_LIBROS
    SET TITULO = @titulo,
        AUTOR = @autor,
        ANIO = @anio,
        CANTIDAD = @cantidad,
        PRECIO = @precio
    WHERE ID = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[EditarUsuario]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarUsuario]
    @id INT,
    @usuario VARCHAR(50),
    @contraseña VARCHAR(50),
    @nombreCompleto VARCHAR(100),
    @email VARCHAR(100),
    @rol VARCHAR(50)
AS
BEGIN
    UPDATE TB_LOGIN
    SET USUARIO = @usuario,
        CONTRASEÑA = @contraseña,
        APELLIDOS_NOMBRES = @nombreCompleto,
        CORREO_ELECTRONICO = @email,
        ROL = @rol
    WHERE ID = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[EditarVenta]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarVenta]
    @venta_id INT,
    @usuario_id INT,
    @cliente_id INT,
    @libro_id INT,
    @cantidad INT,
    @precio_total DECIMAL(18, 2)
AS
BEGIN
    UPDATE TB_VENTAS
    SET USUARIO_ID = @usuario_id,
        CLIENTE_ID = @cliente_id,
        LIBRO_ID = @libro_id,
        CANTIDAD = @cantidad,
        PRECIOTOTAL = @precio_total
    WHERE ID = @venta_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarCliente]
    @id INT
AS
BEGIN
    DELETE FROM TB_CLIENTE WHERE ID = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarEntrada]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarEntrada]
    @entrada_id INT
AS
BEGIN
    -- Variables para almacenar el libro_id y cantidad de la entrada
    DECLARE @libro_id INT;
    DECLARE @cantidad INT;

    -- Obtener el libro_id y cantidad de la entrada
    SELECT @libro_id = ID_LIBRO, @cantidad = CANTIDAD
    FROM TB_STOCK_ENTRADA
    WHERE ID = @entrada_id;

    -- Iniciar una transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Eliminar la entrada
        DELETE FROM TB_STOCK_ENTRADA WHERE ID = @entrada_id;

        -- Actualizar el stock actual en la tabla de Libros
        UPDATE TB_LIBROS
        SET CANTIDAD = CANTIDAD - @cantidad
        WHERE ID = @libro_id;

        -- Confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Revertir la transacción en caso de error
        ROLLBACK TRANSACTION;

        -- Propagar el error
        THROW;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarFacturacion]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarFacturacion]
    @ID INT
AS
BEGIN
    DELETE FROM TB_FACTURACION
    WHERE ID = @ID;
END;

GO
/****** Object:  StoredProcedure [dbo].[EliminarLibro]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarLibro]
    @id INT
AS
BEGIN
    DELETE FROM TB_LIBROS WHERE ID = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarUsuario]
    @id INT
AS
BEGIN
    DELETE FROM TB_LOGIN WHERE ID = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarVenta]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarVenta]
    @venta_id INT
AS
BEGIN
    -- Variables para almacenar los detalles de la venta
    DECLARE @libro_id INT;
    DECLARE @cantidad INT;

    -- Obtener el libro_id y cantidad de la venta
    SELECT @libro_id = LIBRO_ID, @cantidad = CANTIDAD
    FROM TB_VENTAS
    WHERE ID = @venta_id;

    -- Eliminar la venta
    DELETE FROM TB_VENTAS WHERE ID = @venta_id;

    -- Actualizar el stock del libro
    UPDATE TB_LIBROS
    SET CANTIDAD = CANTIDAD + @cantidad
    WHERE ID = @libro_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarCliente]
    @nombre VARCHAR(255),
    @apellido VARCHAR(255),
    @cedula VARCHAR(50),
    @edad INT,
    @correo VARCHAR(255)
AS
BEGIN
    INSERT INTO TB_CLIENTE (NOMBRE, APELLIDO, CEDULA, EDAD, CORREO)
    VALUES (@nombre, @apellido, @cedula, @edad, @correo);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertarFacturacion]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarFacturacion]
    @NumFactura VARCHAR(20),
    @Cedula VARCHAR(15),
    @Cliente VARCHAR(100),
    @Libro VARCHAR(100),
    @Cantidad INT,
    @PrecioCantidad DECIMAL(18,2),
    @Detalles TEXT = NULL,
    @Descuento DECIMAL(5,2) = 0,
    @PrecioTotal DECIMAL(18,2),
    @MetodoDePago VARCHAR(50) = NULL
AS
BEGIN
    INSERT INTO TB_FACTURACION (NUM_FACTURA, CEDULA, CLIENTE, LIBRO, CANTIDAD, PRECIO_CANTIDAD, DETALLES, DESCUENTO, PRECIO_TOTAL, METODO_DE_PAGO)
    VALUES (@NumFactura, @Cedula, @Cliente, @Libro, @Cantidad, @PrecioCantidad, @Detalles, @Descuento, @PrecioTotal, @MetodoDePago);
END;

GO
/****** Object:  StoredProcedure [dbo].[InsertarLibro]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarLibro]
    @titulo VARCHAR(255),
    @autor VARCHAR(255),
    @anio INT,
    @cantidad INT,
    @precio DECIMAL(18, 2)
AS
BEGIN
    INSERT INTO TB_LIBROS (TITULO, AUTOR, ANIO, CANTIDAD, PRECIO)
    VALUES (@titulo, @autor, @anio, @cantidad, @precio);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuario]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarUsuario]
    @rol VARCHAR(50),
    @usuario VARCHAR(50),
    @contraseña VARCHAR(50),
    @nombreCompleto VARCHAR(100),
    @email VARCHAR(100)
AS
BEGIN
    INSERT INTO TB_LOGIN (ROL, USUARIO, CONTRASEÑA, APELLIDOS_NOMBRES, CORREO_ELECTRONICO)
    VALUES (@rol, @usuario, @contraseña, @nombreCompleto, @email);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertarVenta]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarVenta]
    @usuario_id INT,
    @cliente_id INT,
    @libro_id INT,
    @cantidad INT,
    @precio_total DECIMAL(18, 2)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insertar la venta
        INSERT INTO TB_VENTAS (USUARIO_ID, CLIENTE_ID, LIBRO_ID, CANTIDAD, PRECIOTOTAL)
        VALUES (@usuario_id, @cliente_id, @libro_id, @cantidad, @precio_total);

        -- Actualizar el stock del libro
        UPDATE TB_LIBROS
        SET CANTIDAD = CANTIDAD - @cantidad
        WHERE ID = @libro_id;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[MostrarClientes]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MostrarClientes]
AS
BEGIN
    SELECT * FROM TB_CLIENTE;
END;
GO
/****** Object:  StoredProcedure [dbo].[MostrarEntrada]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MostrarEntrada]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM TB_STOCK_ENTRADA;
END;
GO
/****** Object:  StoredProcedure [dbo].[MostrarFacturaciones]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MostrarFacturaciones]
AS
BEGIN
    SELECT 
        ID,
        NUM_FACTURA,
        CEDULA,
        CLIENTE,
        LIBRO,
        CANTIDAD,
        PRECIO_CANTIDAD,
        DETALLES,
        DESCUENTO,
        PRECIO_TOTAL,
        METODO_DE_PAGO,
        ESTADO
    FROM 
        TB_FACTURACION;
END;

GO
/****** Object:  StoredProcedure [dbo].[MostrarLibros]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MostrarLibros]
AS
BEGIN
    SELECT * FROM TB_LIBROS;
END;
GO
/****** Object:  StoredProcedure [dbo].[MostrarUsuarios]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MostrarUsuarios]
AS
BEGIN
    SELECT * FROM TB_LOGIN;
END
GO
/****** Object:  StoredProcedure [dbo].[MostrarVentas]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MostrarVentas]
AS
BEGIN
    SELECT * FROM TB_VENTAS;
END;
GO
/****** Object:  StoredProcedure [dbo].[ObtenerInformacionVenta]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerInformacionVenta]
    @VentaID INT
AS
BEGIN
    SELECT 
        v.ID AS VentaID,
        c.CEDULA,
        c.NOMBRE + ' ' + c.APELLIDO AS ClienteNombre,
        l.TITULO AS LibroTitulo,
        v.CANTIDAD,
        v.PRECIOTOTAL
    FROM 
        TB_VENTAS v
    INNER JOIN 
        TB_CLIENTE c ON v.CLIENTE_ID = c.ID
    INNER JOIN 
        TB_LIBROS l ON v.LIBRO_ID = l.ID
    WHERE 
        v.ID = @VentaID;
END;

GO
/****** Object:  StoredProcedure [dbo].[RegistrarEntrada]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarEntrada]
    @libro_id INT,
    @cantidad INT,
    @fecha DATE,
    @proveedor VARCHAR(255),
    @comentarios TEXT
AS
BEGIN
    -- Iniciar una transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Inserción en la tabla de Entradas
        INSERT INTO TB_STOCK_ENTRADA (ID_LIBRO, CANTIDAD, FECHA, PROVEEDOR, COMENTARIOS)
        VALUES (@libro_id, @cantidad, @fecha, @proveedor, @comentarios);

        -- Actualización del stock actual en la tabla de Libros
        UPDATE TB_LIBROS
        SET CANTIDAD = CANTIDAD + @cantidad
        WHERE id = @libro_id;

        -- Confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Revertir la transacción en caso de error
        ROLLBACK TRANSACTION;

        -- Propagar el error
        THROW;
    END CATCH;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITAR_RESERVA]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Editar reserva
CREATE PROCEDURE [dbo].[SP_EDITAR_RESERVA]
    @ID INT,
    @USUARIO_ID INT,
    @CLIENTE_ID INT,
    @LIBRO_ID INT,
    @CANTIDAD INT,
    @PRECIOTOTAL DECIMAL(18, 2),
    @FECHA_RESERVA DATETIME,
    @ESTADO NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE [dbo].[TB_RESERVA]
    SET [USUARIO_ID] = @USUARIO_ID,
        [CLIENTE_ID] = @CLIENTE_ID,
        [LIBRO_ID] = @LIBRO_ID,
        [CANTIDAD] = @CANTIDAD,
        [PRECIOTOTAL] = @PRECIOTOTAL,
        [FECHA_RESERVA] = @FECHA_RESERVA,
        [ESTADO] = @ESTADO
    WHERE [ID] = @ID;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_RESERVA]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Eliminar reserva
CREATE PROCEDURE [dbo].[SP_ELIMINAR_RESERVA]
    @ID INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM [dbo].[TB_RESERVA]
    WHERE [ID] = @ID;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_RESERVA]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insertar reserva
CREATE PROCEDURE [dbo].[SP_INSERTAR_RESERVA]
    @USUARIO_ID INT,
    @CLIENTE_ID INT,
    @LIBRO_ID INT,
    @CANTIDAD INT,
    @PRECIOTOTAL DECIMAL(18, 2),
    @FECHA_RESERVA DATETIME,
    @ESTADO NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO [dbo].[TB_RESERVA] ([USUARIO_ID], [CLIENTE_ID], [LIBRO_ID], [CANTIDAD], [PRECIOTOTAL], [FECHA_RESERVA], [ESTADO])
    VALUES (@USUARIO_ID, @CLIENTE_ID, @LIBRO_ID, @CANTIDAD, @PRECIOTOTAL, @FECHA_RESERVA, @ESTADO);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRAR_RESERVAS]    Script Date: 31/07/2024 17:23:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Mostrar reservas
CREATE PROCEDURE [dbo].[SP_MOSTRAR_RESERVAS]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM [dbo].[TB_RESERVA];
END
GO
USE [master]
GO
ALTER DATABASE [PROYECTO_INVENTARIO] SET  READ_WRITE 
GO
