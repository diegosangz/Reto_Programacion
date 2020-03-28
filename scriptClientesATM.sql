USE [master]
GO

/****** Object:  Database [ClientesATM]    Script Date: 03/28/2020 3:57:11 p. m. ******/
CREATE DATABASE [ClientesATM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ClientesATM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ClientesATM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ClientesATM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ClientesATM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClientesATM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ClientesATM] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ClientesATM] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ClientesATM] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ClientesATM] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ClientesATM] SET ARITHABORT OFF 
GO

ALTER DATABASE [ClientesATM] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ClientesATM] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ClientesATM] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ClientesATM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ClientesATM] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ClientesATM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ClientesATM] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ClientesATM] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ClientesATM] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ClientesATM] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ClientesATM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ClientesATM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ClientesATM] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ClientesATM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ClientesATM] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ClientesATM] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ClientesATM] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ClientesATM] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [ClientesATM] SET  MULTI_USER 
GO

ALTER DATABASE [ClientesATM] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ClientesATM] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ClientesATM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ClientesATM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ClientesATM] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ClientesATM] SET QUERY_STORE = OFF
GO

ALTER DATABASE [ClientesATM] SET  READ_WRITE 
GO

USE [ClientesATM]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 03/28/2020 3:59:56 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NombreCliente] [nvarchar](50) NOT NULL,
	[Cncsn] [nvarchar](50) NULL,
	[Cdad] [nvarchar](50) NULL,
	[Tlfno] [nvarchar](max) NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

