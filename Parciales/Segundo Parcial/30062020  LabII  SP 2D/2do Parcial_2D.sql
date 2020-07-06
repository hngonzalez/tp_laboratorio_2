USE [master]
GO
/****** Object:  Database [JardinUtn]    Script Date: 30/06/2020 06:51:36 p. m. ******/
CREATE DATABASE [JardinUtn]
 
GO
ALTER DATABASE [JardinUtn] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JardinUtn] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JardinUtn] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JardinUtn] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JardinUtn] SET ARITHABORT OFF 
GO
ALTER DATABASE [JardinUtn] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JardinUtn] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JardinUtn] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JardinUtn] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JardinUtn] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JardinUtn] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JardinUtn] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JardinUtn] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JardinUtn] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JardinUtn] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JardinUtn] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JardinUtn] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JardinUtn] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JardinUtn] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JardinUtn] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JardinUtn] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JardinUtn] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JardinUtn] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JardinUtn] SET  MULTI_USER 
GO
ALTER DATABASE [JardinUtn] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JardinUtn] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JardinUtn] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JardinUtn] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JardinUtn] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [JardinUtn] SET QUERY_STORE = OFF
GO
USE [JardinUtn]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 30/06/2020 06:51:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[idAlumnos] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Dni] [int] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aulas]    Script Date: 30/06/2020 06:51:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aulas](
	[idAula] [int] IDENTITY(1,1) NOT NULL,
	[Salita] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Docentes]    Script Date: 30/06/2020 06:51:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docentes](
	[idDocente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Sexo] [nvarchar](10) NOT NULL,
	[Dni] [int] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluaciones]    Script Date: 30/06/2020 06:51:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluaciones](
	[idEvaluacion] [int] IDENTITY(1,1) NOT NULL,
	[idAlumno] [int] NOT NULL,
	[idDocente] [int] NOT NULL,
	[idAula] [int] NOT NULL,
	[Nota_1] [int] NOT NULL,
	[Nota_2] [int] NOT NULL,
	[NotaFinal] [float] NOT NULL,
	[Observaciones] [nvarchar](500) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumnos] ON 

INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (1, N'Karole', N'Prangnell', 5, 55599975, N'8 Lerdahl Circle', N'5')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (2, N'Meryl', N'Spinks', 6, 54704785, N'906 Luster Court', N'22')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (3, N'Merill', N'Emblin', 4, 53030520, N'7 Oak Valley Parkway', N'20')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (4, N'Blinnie', N'Janzen', 5, 50256021, N'36 Chinook Lane', N'2')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (5, N'Alikee', N'Percy', 6, 50162248, N'699 Corben Center', N'8')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (6, N'Hertha', N'Dewan', 6, 51868513, N'78 Hazelcrest Road', N'1')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (7, N'Shermie', N'Sacaze', 6, 58203316, N'1740 Loomis Parkway', N'13')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (8, N'Brendin', N'Belleny', 5, 52559250, N'205 Delladonna Drive', N'7')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (9, N'Annalee', N'Beckson', 4, 57049185, N'31 American Avenue', N'30')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (10, N'Jozef', N'Stitt', 6, 55676051, N'64735 Kipling Way', N'21')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (11, N'Sybille', N'Conlon', 6, 54952223, N'970 Express Way', N'9')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (12, N'Sanders', N'Fishbie', 4, 55347017, N'8534 Muir Circle', N'15')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (13, N'Worth', N'Iveagh', 5, 51699845, N'8035 Harper Terrace', N'25')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (14, N'Maximo', N'Robez', 4, 59637009, N'5742 Dorton Circle', N'17')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (15, N'Jennica', N'Le Sarr', 5, 51963644, N'86100 Parkside Junction', N'1')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (16, N'Carey', N'Gheorghie', 5, 51201609, N'64 Shoshone Center', N'5')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (17, N'Mira', N'Kopfer', 6, 51501446, N'22794 Charing Cross Way', N'20')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (18, N'Zechariah', N'Weeke', 4, 52916352, N'12 Talmadge Road', N'11')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (19, N'Cece', N'Hamon', 6, 50509081, N'590 Weeping Birch Road', N'10')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (20, N'Tomkin', N'Seif', 6, 52705182, N'56 Pankratz Pass', N'25')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (21, N'Joann', N'Mussalli', 4, 54866610, N'50971 North Park', N'5')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (22, N'Eziechiele', N'Kleinsmuntz', 6, 52518780, N'741 Lakewood Place', N'18')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (23, N'Adel', N'Guymer', 5, 51252402, N'8354 New Castle Hill', N'3')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (24, N'Jacquelynn', N'Bogaert', 4, 51307815, N'0097 Hazelcrest Crossing', N'23')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (25, N'Wandis', N'Carletto', 4, 56517132, N'3 7th Terrace', N'10')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (26, N'Roanne', N'Grishukov', 4, 51005980, N'32691 Annamark Hill', N'7')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (27, N'Gardy', N'Moggan', 5, 59408868, N'4 Hoepker Drive', N'17')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (28, N'Evelin', N'Emlin', 4, 58492303, N'1433 Redwing Alley', N'16')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (29, N'Clarie', N'Kinnock', 4, 54840731, N'445 7th Park', N'2')
INSERT [dbo].[Alumnos] ([idAlumnos], [Nombre], [Apellido], [Edad], [Dni], [Direccion], [Responsable]) VALUES (30, N'Keslie', N'Newcomb', 4, 52273191, N'93 Manitowish Parkway', N'21')
SET IDENTITY_INSERT [dbo].[Alumnos] OFF
GO
SET IDENTITY_INSERT [dbo].[Aulas] ON 

INSERT [dbo].[Aulas] ([idAula], [Salita]) VALUES (1, N'Roja')
INSERT [dbo].[Aulas] ([idAula], [Salita]) VALUES (2, N'Verde')
INSERT [dbo].[Aulas] ([idAula], [Salita]) VALUES (3, N'Naranja')
INSERT [dbo].[Aulas] ([idAula], [Salita]) VALUES (4, N'Azul')
INSERT [dbo].[Aulas] ([idAula], [Salita]) VALUES (5, N'Rosa')
INSERT [dbo].[Aulas] ([idAula], [Salita]) VALUES (6, N'Lila')
SET IDENTITY_INSERT [dbo].[Aulas] OFF
GO
USE [master]
GO
ALTER DATABASE [JardinUtn] SET  READ_WRITE 
GO
