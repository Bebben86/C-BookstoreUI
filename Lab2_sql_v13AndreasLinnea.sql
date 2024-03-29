USE [master]
GO
/****** Object:  Database [LAM_Lab2]    Script Date: 2021-05-14 15:59:17 ******/
CREATE DATABASE [LAM_Lab2]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'LAM_Lab2', FILENAME = N'C:\Users\andre\LAM_Lab2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'LAM_Lab2_log', FILENAME = N'C:\Users\andre\LAM_Lab2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LAM_Lab2] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LAM_Lab2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LAM_Lab2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LAM_Lab2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LAM_Lab2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LAM_Lab2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LAM_Lab2] SET ARITHABORT OFF 
GO
ALTER DATABASE [LAM_Lab2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LAM_Lab2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LAM_Lab2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LAM_Lab2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LAM_Lab2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LAM_Lab2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LAM_Lab2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LAM_Lab2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LAM_Lab2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LAM_Lab2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LAM_Lab2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LAM_Lab2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LAM_Lab2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LAM_Lab2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LAM_Lab2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LAM_Lab2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LAM_Lab2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LAM_Lab2] SET RECOVERY FULL 
GO
ALTER DATABASE [LAM_Lab2] SET  MULTI_USER 
GO
ALTER DATABASE [LAM_Lab2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LAM_Lab2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LAM_Lab2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LAM_Lab2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LAM_Lab2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LAM_Lab2] SET QUERY_STORE = OFF
GO
USE [LAM_Lab2]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [LAM_Lab2]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[A_FirstName] [nvarchar](50) NOT NULL,
	[A_LastName] [nvarchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorsBooks]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorsBooks](
	[AuthorsID] [int] NOT NULL,
	[BooksISBN13] [nvarchar](17) NOT NULL,
 CONSTRAINT [PK_AuthorBook] PRIMARY KEY CLUSTERED 
(
	[AuthorsID] ASC,
	[BooksISBN13] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN13] [nvarchar](17) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Language] [nvarchar](50) NOT NULL,
	[Price] [money] NULL,
	[Published] [date] NOT NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN13] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockBalances]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockBalances](
	[NumberOfItems] [int] NOT NULL,
	[BookStoresID] [int] NOT NULL,
	[BooksISBN13] [nvarchar](17) NOT NULL,
 CONSTRAINT [FK_BookStoresID_BooksISBN13] PRIMARY KEY CLUSTERED 
(
	[BookStoresID] ASC,
	[BooksISBN13] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookStores]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookStores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[AddressesID] [int] NOT NULL,
 CONSTRAINT [PK_BookStores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TitlesPerAuthor]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TitlesPerAuthor] AS
SELECT  CONCAT(A_FirstName, ' ', A_LastName) AS Author
		,DATEDIFF(YEAR, BirthDate, GETDATE()) AS Age
		,(COUNT(*) / (SELECT COUNT(*) FROM BookStores)) AS [No. of titles]
		,SUM(NumberOfItems * Books.Price) AS 'StockValue'		
FROM    Authors
JOIN    AuthorsBooks ON Authors.ID =  AuthorsBooks.AuthorsID
JOIN    Books ON AuthorsBooks.BooksISBN13 = Books.ISBN13
JOIN	StockBalances ON StockBalances.BooksISBN13 = Books.ISBN13
GROUP BY A_Firstname, A_LastName, BirthDate
GO
/****** Object:  Table [dbo].[PostalCode]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostalCode](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_PostalCode] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Box] [nvarchar](10) NULL,
	[Street] [nvarchar](50) NULL,
	[PostalCodeID] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[C_FirstName] [nvarchar](50) NOT NULL,
	[C_LastName] [nvarchar](50) NOT NULL,
	[AddressesID] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BookStoresID] [int] NOT NULL,
	[CustomersID] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[RegularCustomers]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[RegularCustomers] AS
SELECT
	COUNT(Customers.ID) AS [No of Orders]
	,CONCAT(C_FirstName, ' ', C_LastName) AS 'Customer'
	,CustomersID
	,Street AS 'Customer address'
	,Box AS 'Customer postbox'
	,PostalCode AS 'Customer Zipcode'
	,City AS 'Customer city'
	,Country AS 'Customer country'
	,Email AS 'Customer email'
	,PhoneNumber AS 'Customer phone'
FROM
	Orders
	JOIN Customers ON Customers.ID = Orders.CustomersID
	JOIN Addresses ON Addresses.ID = Customers.ID
	JOIN PostalCode ON PostalCode.ID = Addresses.PostalCodeID
GROUP BY
	C_FirstName
	,C_LastName
	,CustomersID
	,Street
	,Box
	,PostalCode
	,City
	,Country
	,Email
	,PhoneNumber
HAVING
	Count(CustomersID) > 1
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrdersOrderID] [int] NOT NULL,
	[BooksISBN13] [nvarchar](17) NOT NULL,
	[NumberOfItems] [int] NOT NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([ID], [Box], [Street], [PostalCodeID]) VALUES (1, NULL, N'Norra Hamngatan 26', 1)
INSERT [dbo].[Addresses] ([ID], [Box], [Street], [PostalCodeID]) VALUES (2, NULL, N'Mäster Samuelsgatan 28', 2)
INSERT [dbo].[Addresses] ([ID], [Box], [Street], [PostalCodeID]) VALUES (3, N'Box 19', N'', 3)
INSERT [dbo].[Addresses] ([ID], [Box], [Street], [PostalCodeID]) VALUES (4, NULL, N'Västra Köpmansgatan 11', 4)
INSERT [dbo].[Addresses] ([ID], [Box], [Street], [PostalCodeID]) VALUES (5, NULL, N'Österlånggatan 41', 5)
INSERT [dbo].[Addresses] ([ID], [Box], [Street], [PostalCodeID]) VALUES (7, NULL, N'Oluff Nilssons väg 10', 3)
INSERT [dbo].[Addresses] ([ID], [Box], [Street], [PostalCodeID]) VALUES (8, NULL, N'Västergårdsvägen 26', 4)
INSERT [dbo].[Addresses] ([ID], [Box], [Street], [PostalCodeID]) VALUES (10, NULL, N'Andra Långgatan 4D', 1)
INSERT [dbo].[Addresses] ([ID], [Box], [Street], [PostalCodeID]) VALUES (11, N'Box 123', N'', 1)
INSERT [dbo].[Addresses] ([ID], [Box], [Street], [PostalCodeID]) VALUES (12, NULL, N'Tredje Långgatan 7A', 1)
INSERT [dbo].[Addresses] ([ID], [Box], [Street], [PostalCodeID]) VALUES (13, NULL, N'Storgatan 4', 2)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([ID], [A_FirstName], [A_LastName], [BirthDate], [Active]) VALUES (5, N'Stephen', N'King', CAST(N'1947-09-21' AS Date), 1)
INSERT [dbo].[Authors] ([ID], [A_FirstName], [A_LastName], [BirthDate], [Active]) VALUES (6, N'JK', N'Rowling', CAST(N'1965-07-31' AS Date), 1)
INSERT [dbo].[Authors] ([ID], [A_FirstName], [A_LastName], [BirthDate], [Active]) VALUES (7, N'JRR', N'Tolkien', CAST(N'1892-01-03' AS Date), 1)
INSERT [dbo].[Authors] ([ID], [A_FirstName], [A_LastName], [BirthDate], [Active]) VALUES (8, N'Mikael', N'Segerlund', CAST(N'1953-10-04' AS Date), 1)
INSERT [dbo].[Authors] ([ID], [A_FirstName], [A_LastName], [BirthDate], [Active]) VALUES (9, N'Folke', N'Stridsman', CAST(N'1950-03-05' AS Date), 1)
INSERT [dbo].[Authors] ([ID], [A_FirstName], [A_LastName], [BirthDate], [Active]) VALUES (10, N'Katrine', N'Marçal', CAST(N'1983-10-24' AS Date), 1)
INSERT [dbo].[Authors] ([ID], [A_FirstName], [A_LastName], [BirthDate], [Active]) VALUES (5011, N'Astrid', N'Lindgren', CAST(N'1907-11-07' AS Date), 1)
INSERT [dbo].[Authors] ([ID], [A_FirstName], [A_LastName], [BirthDate], [Active]) VALUES (6011, N'Jane', N'Austen', CAST(N'1775-12-17' AS Date), 0)
INSERT [dbo].[Authors] ([ID], [A_FirstName], [A_LastName], [BirthDate], [Active]) VALUES (6012, N'Charles', N'Dickens', CAST(N'1812-02-17' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
INSERT [dbo].[AuthorsBooks] ([AuthorsID], [BooksISBN13]) VALUES (5, N'9789100174682')
INSERT [dbo].[AuthorsBooks] ([AuthorsID], [BooksISBN13]) VALUES (5, N'9789174293920')
INSERT [dbo].[AuthorsBooks] ([AuthorsID], [BooksISBN13]) VALUES (6, N'9781338132311')
INSERT [dbo].[AuthorsBooks] ([AuthorsID], [BooksISBN13]) VALUES (6, N'9789129697704')
INSERT [dbo].[AuthorsBooks] ([AuthorsID], [BooksISBN13]) VALUES (7, N'9780007458424')
INSERT [dbo].[AuthorsBooks] ([AuthorsID], [BooksISBN13]) VALUES (7, N'9789113084930')
INSERT [dbo].[AuthorsBooks] ([AuthorsID], [BooksISBN13]) VALUES (7, N'9789172632189')
INSERT [dbo].[AuthorsBooks] ([AuthorsID], [BooksISBN13]) VALUES (8, N'9789186536411')
INSERT [dbo].[AuthorsBooks] ([AuthorsID], [BooksISBN13]) VALUES (9, N'9789186536411')
INSERT [dbo].[AuthorsBooks] ([AuthorsID], [BooksISBN13]) VALUES (10, N'9789180020374')
INSERT [dbo].[AuthorsBooks] ([AuthorsID], [BooksISBN13]) VALUES (10, N'9789189061194')
GO
INSERT [dbo].[Books] ([ISBN13], [Title], [Language], [Price], [Published], [Active]) VALUES (N'9780007458424', N'The Hobbit', N'English', 99.0000, CAST(N'1937-10-21' AS Date), 1)
INSERT [dbo].[Books] ([ISBN13], [Title], [Language], [Price], [Published], [Active]) VALUES (N'9781338132311', N'Fantastic Beasts and Where to Find Them ', N'English', 141.0000, CAST(N'2001-03-01' AS Date), 1)
INSERT [dbo].[Books] ([ISBN13], [Title], [Language], [Price], [Published], [Active]) VALUES (N'9789100174682', N'IT', N'English', 120.0000, CAST(N'1986-09-15' AS Date), 1)
INSERT [dbo].[Books] ([ISBN13], [Title], [Language], [Price], [Published], [Active]) VALUES (N'9789113084930', N'Silmarillion', N'English', 162.0000, CAST(N'1977-09-15' AS Date), 1)
INSERT [dbo].[Books] ([ISBN13], [Title], [Language], [Price], [Published], [Active]) VALUES (N'9789129697704', N'Harry Potter and the philosopher''s stone', N'English', 269.0000, CAST(N'1997-06-26' AS Date), 1)
INSERT [dbo].[Books] ([ISBN13], [Title], [Language], [Price], [Published], [Active]) VALUES (N'9789172632189', N'The Lord of the Rings', N'English', 159.0000, CAST(N'1954-07-29' AS Date), 1)
INSERT [dbo].[Books] ([ISBN13], [Title], [Language], [Price], [Published], [Active]) VALUES (N'9789174293920', N'The Shining', N'English', 59.0000, CAST(N'1977-01-28' AS Date), 1)
INSERT [dbo].[Books] ([ISBN13], [Title], [Language], [Price], [Published], [Active]) VALUES (N'9789180020374', N'Att uppfinna världen', N'Swedish', 92.0000, CAST(N'2020-10-19' AS Date), 1)
INSERT [dbo].[Books] ([ISBN13], [Title], [Language], [Price], [Published], [Active]) VALUES (N'9789186536411', N'SQL Introduktion', N'Swedish', 128.0000, CAST(N'2008-01-01' AS Date), 1)
INSERT [dbo].[Books] ([ISBN13], [Title], [Language], [Price], [Published], [Active]) VALUES (N'9789189061194', N'Vem lagade Adam Smiths middag?', N'Swedish', 184.0000, CAST(N'2020-01-27' AS Date), 0)
GO
SET IDENTITY_INSERT [dbo].[BookStores] ON 

INSERT [dbo].[BookStores] ([ID], [Name], [AddressesID]) VALUES (1, N'Akademibokhandeln Göteborg', 1)
INSERT [dbo].[BookStores] ([ID], [Name], [AddressesID]) VALUES (7, N'Bokia', 3)
INSERT [dbo].[BookStores] ([ID], [Name], [AddressesID]) VALUES (9, N'Pocket Store', 13)
INSERT [dbo].[BookStores] ([ID], [Name], [AddressesID]) VALUES (10, N'Akademibokhandeln Stockholm', 2)
SET IDENTITY_INSERT [dbo].[BookStores] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([ID], [C_FirstName], [C_LastName], [AddressesID], [Email], [PhoneNumber]) VALUES (3, N'Peter', N'Larsson', 11, N'peter.larsson@yahoo.se', N'0735-773963')
INSERT [dbo].[Customers] ([ID], [C_FirstName], [C_LastName], [AddressesID], [Email], [PhoneNumber]) VALUES (4, N'Lars', N'Petersson', 13, N'lars.petersson@gmail.com', N'0701-123321')
INSERT [dbo].[Customers] ([ID], [C_FirstName], [C_LastName], [AddressesID], [Email], [PhoneNumber]) VALUES (5, N'Embla', N'Nilsson', 13, N'embla.nilsson@bet365.com', N'0762-111112')
INSERT [dbo].[Customers] ([ID], [C_FirstName], [C_LastName], [AddressesID], [Email], [PhoneNumber]) VALUES (6, N'Lina', N'Ekemark', 10, N'ek.lina@telia.com', N'0703-642987')
INSERT [dbo].[Customers] ([ID], [C_FirstName], [C_LastName], [AddressesID], [Email], [PhoneNumber]) VALUES (7, N'Kim', N'Kimsson', 8, N'kim.erland@hotmail.com', N'0739-574417')
INSERT [dbo].[Customers] ([ID], [C_FirstName], [C_LastName], [AddressesID], [Email], [PhoneNumber]) VALUES (8, N'Kalle', N'Karlsson', 12, N'kalle.kula@yesbox.net', N'0714-062557')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (1, 4, N'9789172632189', 1, 159.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (2, 2, N'9789186536411', 10, 1280.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (3, 6, N'9789100174682', 2, 240.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (4, 1, N'9789189061194', 3, 552.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (5, 3, N'9789174293920', 1, 59.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (6, 3, N'9789113084930', 1, 162.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (7, 5, N'9789180020374', 5, 460.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (11, 1, N'9789174293920', 1, 59.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (12, 3, N'9789186536411', 3, 384.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (13, 2, N'9789129697704', 1, 269.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (16, 7, N'9789129697704', 2, 538.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (17, 8, N'9789174293920', 1, 59.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (18, 9, N'9789172632189', 1, 159.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (19, 10, N'9789189061194', 3, 552.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (20, 10, N'9789172632189', 1, 159.0000)
INSERT [dbo].[OrderDetails] ([ID], [OrdersOrderID], [BooksISBN13], [NumberOfItems], [Price]) VALUES (21, 11, N'9789100174682', 2, 240.0000)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [BookStoresID], [CustomersID], [OrderDate]) VALUES (1, 7, 8, CAST(N'2010-05-12' AS Date))
INSERT [dbo].[Orders] ([ID], [BookStoresID], [CustomersID], [OrderDate]) VALUES (2, 10, 4, CAST(N'2006-12-20' AS Date))
INSERT [dbo].[Orders] ([ID], [BookStoresID], [CustomersID], [OrderDate]) VALUES (3, 1, 5, CAST(N'2017-02-05' AS Date))
INSERT [dbo].[Orders] ([ID], [BookStoresID], [CustomersID], [OrderDate]) VALUES (4, 9, 7, CAST(N'2021-04-27' AS Date))
INSERT [dbo].[Orders] ([ID], [BookStoresID], [CustomersID], [OrderDate]) VALUES (5, 7, 6, CAST(N'2018-10-16' AS Date))
INSERT [dbo].[Orders] ([ID], [BookStoresID], [CustomersID], [OrderDate]) VALUES (6, 10, 3, CAST(N'2018-10-19' AS Date))
INSERT [dbo].[Orders] ([ID], [BookStoresID], [CustomersID], [OrderDate]) VALUES (7, 7, 8, CAST(N'2019-07-30' AS Date))
INSERT [dbo].[Orders] ([ID], [BookStoresID], [CustomersID], [OrderDate]) VALUES (8, 10, 4, CAST(N'2021-02-19' AS Date))
INSERT [dbo].[Orders] ([ID], [BookStoresID], [CustomersID], [OrderDate]) VALUES (9, 1, 6, CAST(N'2018-11-02' AS Date))
INSERT [dbo].[Orders] ([ID], [BookStoresID], [CustomersID], [OrderDate]) VALUES (10, 9, 7, CAST(N'2007-02-28' AS Date))
INSERT [dbo].[Orders] ([ID], [BookStoresID], [CustomersID], [OrderDate]) VALUES (11, 1, 7, CAST(N'2021-04-28' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[PostalCode] ON 

INSERT [dbo].[PostalCode] ([ID], [City], [Country], [PostalCode]) VALUES (1, N'Göteborg', N'Sweden', N'411 06')
INSERT [dbo].[PostalCode] ([ID], [City], [Country], [PostalCode]) VALUES (2, N'Stockholm', N'Sweden', N'111 57')
INSERT [dbo].[PostalCode] ([ID], [City], [Country], [PostalCode]) VALUES (3, N'Partille', N'Sweden', N'433 35')
INSERT [dbo].[PostalCode] ([ID], [City], [Country], [PostalCode]) VALUES (4, N'Stenungsund', N'Sweden', N'444 30')
INSERT [dbo].[PostalCode] ([ID], [City], [Country], [PostalCode]) VALUES (5, N'Borås', N'Sweden', N'503 37')
SET IDENTITY_INSERT [dbo].[PostalCode] OFF
GO
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (0, 1, N'9780007458424')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (10, 1, N'9781338132311')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (32, 1, N'9789100174682')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (10, 1, N'9789113084930')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (40, 1, N'9789129697704')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (35, 1, N'9789172632189')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (26, 1, N'9789174293920')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (22, 1, N'9789180020374')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (31, 1, N'9789186536411')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (18, 1, N'9789189061194')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (36, 7, N'9780007458424')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (33, 7, N'9781338132311')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (6, 7, N'9789100174682')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (25, 7, N'9789113084930')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (66, 7, N'9789129697704')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (50, 7, N'9789172632189')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (32, 7, N'9789174293920')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (10, 7, N'9789180020374')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (3, 7, N'9789186536411')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (20, 7, N'9789189061194')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (15, 9, N'9780007458424')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (1, 9, N'9781338132311')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (35, 9, N'9789100174682')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (11, 9, N'9789113084930')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (43, 9, N'9789129697704')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (90, 9, N'9789172632189')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (7, 9, N'9789174293920')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (26, 9, N'9789180020374')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (15, 9, N'9789186536411')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (30, 9, N'9789189061194')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (66, 10, N'9780007458424')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (29, 10, N'9781338132311')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (9, 10, N'9789100174682')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (19, 10, N'9789113084930')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (25, 10, N'9789129697704')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (39, 10, N'9789172632189')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (75, 10, N'9789174293920')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (44, 10, N'9789180020374')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (6, 10, N'9789186536411')
INSERT [dbo].[StockBalances] ([NumberOfItems], [BookStoresID], [BooksISBN13]) VALUES (58, 10, N'9789189061194')
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_PostalCode] FOREIGN KEY([PostalCodeID])
REFERENCES [dbo].[PostalCode] ([ID])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_PostalCode]
GO
ALTER TABLE [dbo].[AuthorsBooks]  WITH CHECK ADD  CONSTRAINT [FK_AuthorsBooks_Authors] FOREIGN KEY([AuthorsID])
REFERENCES [dbo].[Authors] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[AuthorsBooks] CHECK CONSTRAINT [FK_AuthorsBooks_Authors]
GO
ALTER TABLE [dbo].[AuthorsBooks]  WITH CHECK ADD  CONSTRAINT [FK_AuthorsBooks_Books] FOREIGN KEY([BooksISBN13])
REFERENCES [dbo].[Books] ([ISBN13])
GO
ALTER TABLE [dbo].[AuthorsBooks] CHECK CONSTRAINT [FK_AuthorsBooks_Books]
GO
ALTER TABLE [dbo].[BookStores]  WITH CHECK ADD  CONSTRAINT [FK_BookStores_Addresses] FOREIGN KEY([AddressesID])
REFERENCES [dbo].[Addresses] ([ID])
GO
ALTER TABLE [dbo].[BookStores] CHECK CONSTRAINT [FK_BookStores_Addresses]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Addresses1] FOREIGN KEY([AddressesID])
REFERENCES [dbo].[Addresses] ([ID])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Addresses1]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Books] FOREIGN KEY([BooksISBN13])
REFERENCES [dbo].[Books] ([ISBN13])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Books]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrdersOrderID])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_BookStores] FOREIGN KEY([BookStoresID])
REFERENCES [dbo].[BookStores] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_BookStores]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomersID])
REFERENCES [dbo].[Customers] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[StockBalances]  WITH CHECK ADD  CONSTRAINT [FK_StockBalances_Books] FOREIGN KEY([BooksISBN13])
REFERENCES [dbo].[Books] ([ISBN13])
GO
ALTER TABLE [dbo].[StockBalances] CHECK CONSTRAINT [FK_StockBalances_Books]
GO
ALTER TABLE [dbo].[StockBalances]  WITH CHECK ADD  CONSTRAINT [FK_StockBalances_BookStores] FOREIGN KEY([BookStoresID])
REFERENCES [dbo].[BookStores] ([ID])
GO
ALTER TABLE [dbo].[StockBalances] CHECK CONSTRAINT [FK_StockBalances_BookStores]
GO
/****** Object:  StoredProcedure [dbo].[usp_TransferBook]    Script Date: 2021-05-14 15:59:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_TransferBook] (
	@ToStore int
	,@FromStore int
	,@ISBN13 nvarchar(17)
	,@number int = '1')
AS
BEGIN
BEGIN TRANSACTION;
UPDATE StockBalances SET NumberOfItems = NumberOfItems - @number
WHERE BookStoresID = @FromStore AND BooksISBN13 = @ISBN13
IF @@ROWCOUNT <> 1
BEGIN
	ROLLBACK;
	RAISERROR('Invalid src store!', 16, 1);
	RETURN;
END; 
UPDATE StockBalances SET NumberOfItems = NumberOfItems + @number	
WHERE BookStoresID = @ToStore AND BooksISBN13 = @ISBN13;
IF @@ROWCOUNT <> 1
BEGIN
ROLLBACK;
RAISERROR('Invalid dest store!', 16, 1);
RETURN;
END; 
COMMIT;
END;
GO
USE [master]
GO
ALTER DATABASE [LAM_Lab2] SET  READ_WRITE 
GO
