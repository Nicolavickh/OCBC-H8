USE [master]
GO
/****** Object:  Database [Bank]    Script Date: 14/10/2021 00:18:19 ******/
CREATE DATABASE [Bank]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bank', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NICOLAVICKH\MSSQL\DATA\Bank.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bank_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NICOLAVICKH\MSSQL\DATA\Bank_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bank] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bank].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bank] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bank] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bank] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bank] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bank] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bank] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bank] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bank] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bank] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bank] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bank] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bank] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bank] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bank] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bank] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Bank] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bank] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bank] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bank] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bank] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bank] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bank] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bank] SET RECOVERY FULL 
GO
ALTER DATABASE [Bank] SET  MULTI_USER 
GO
ALTER DATABASE [Bank] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bank] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bank] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bank] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bank] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bank] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Bank', N'ON'
GO
ALTER DATABASE [Bank] SET QUERY_STORE = OFF
GO
USE [Bank]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 14/10/2021 00:18:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[customerNumber] [int] IDENTITY(1,1) NOT NULL,
	[customerName] [varchar](50) NULL,
	[contactFirstName] [varchar](50) NULL,
	[contactLastName] [varchar](50) NULL,
	[phone] [varchar](15) NULL,
	[addressLine1] [varchar](100) NULL,
	[addressLine2] [varchar](100) NULL,
	[city] [varchar](50) NULL,
	[state] [varchar](50) NULL,
	[postalCode] [varchar](10) NULL,
	[country] [varchar](50) NULL,
	[salesRepEmployeeNumber] [int] NULL,
	[creditLimit] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[customerNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employees]    Script Date: 14/10/2021 00:18:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employees](
	[employeeNumber] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[extension] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[officeCode] [int] NULL,
	[reportsTo] [int] NULL,
	[jobTitle] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[employeeNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[offices]    Script Date: 14/10/2021 00:18:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[offices](
	[officeCode] [int] IDENTITY(1,1) NOT NULL,
	[phone] [varchar](15) NULL,
	[addressLine1] [varchar](100) NULL,
	[addressLine2] [varchar](100) NULL,
	[city] [varchar](50) NULL,
	[state] [varchar](50) NULL,
	[country] [varchar](50) NULL,
	[postalCode] [varchar](10) NULL,
	[territory] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[officeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderDetails]    Script Date: 14/10/2021 00:18:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderDetails](
	[orderNumber] [int] NULL,
	[productCode] [int] NULL,
	[quantityOrdered] [int] NULL,
	[priceEach] [int] NULL,
	[orderLineNumber] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 14/10/2021 00:18:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[orderNumber] [int] IDENTITY(1,1) NOT NULL,
	[orderDate] [date] NULL,
	[requiredDate] [date] NULL,
	[shippedDate] [date] NULL,
	[status] [varchar](50) NULL,
	[comments] [varchar](100) NULL,
	[customerNumber] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[orderNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payments]    Script Date: 14/10/2021 00:18:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payments](
	[checkNumber] [int] IDENTITY(1,1) NOT NULL,
	[customerNumber] [int] NULL,
	[paymentDate] [date] NULL,
	[amount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[checkNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productLines]    Script Date: 14/10/2021 00:18:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productLines](
	[productLine] [int] IDENTITY(1,1) NOT NULL,
	[textDescription] [varchar](250) NULL,
	[htmlDescription] [varchar](250) NULL,
	[image] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[productLine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 14/10/2021 00:18:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[productCode] [int] IDENTITY(1,1) NOT NULL,
	[productName] [varchar](100) NULL,
	[productLine] [int] NULL,
	[productScale] [int] NULL,
	[productVendor] [varchar](100) NULL,
	[productDescription] [varchar](255) NULL,
	[quantityInStock] [int] NULL,
	[buyPrice] [int] NULL,
	[MSRP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[productCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[customers]  WITH CHECK ADD FOREIGN KEY([salesRepEmployeeNumber])
REFERENCES [dbo].[employees] ([employeeNumber])
GO
ALTER TABLE [dbo].[employees]  WITH CHECK ADD FOREIGN KEY([officeCode])
REFERENCES [dbo].[offices] ([officeCode])
GO
ALTER TABLE [dbo].[employees]  WITH CHECK ADD FOREIGN KEY([reportsTo])
REFERENCES [dbo].[employees] ([employeeNumber])
GO
ALTER TABLE [dbo].[orderDetails]  WITH CHECK ADD FOREIGN KEY([orderNumber])
REFERENCES [dbo].[orders] ([orderNumber])
GO
ALTER TABLE [dbo].[orderDetails]  WITH CHECK ADD FOREIGN KEY([productCode])
REFERENCES [dbo].[products] ([productCode])
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD FOREIGN KEY([customerNumber])
REFERENCES [dbo].[customers] ([customerNumber])
GO
ALTER TABLE [dbo].[payments]  WITH CHECK ADD FOREIGN KEY([customerNumber])
REFERENCES [dbo].[customers] ([customerNumber])
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD FOREIGN KEY([productLine])
REFERENCES [dbo].[productLines] ([productLine])
GO
USE [master]
GO
ALTER DATABASE [Bank] SET  READ_WRITE 
GO
