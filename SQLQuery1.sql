USE [master]
GO
/****** Object:  Database [iControl]    Script Date: 07/17/2016 09:55:09 ******/
CREATE DATABASE [iControl] ON  PRIMARY 
( NAME = N'iControl', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\iControl.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'iControl_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\iControl_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [iControl] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [iControl].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [iControl] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [iControl] SET ANSI_NULLS OFF
GO
ALTER DATABASE [iControl] SET ANSI_PADDING OFF
GO
ALTER DATABASE [iControl] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [iControl] SET ARITHABORT OFF
GO
ALTER DATABASE [iControl] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [iControl] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [iControl] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [iControl] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [iControl] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [iControl] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [iControl] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [iControl] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [iControl] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [iControl] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [iControl] SET  DISABLE_BROKER
GO
ALTER DATABASE [iControl] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [iControl] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [iControl] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [iControl] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [iControl] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [iControl] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [iControl] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [iControl] SET  READ_WRITE
GO
ALTER DATABASE [iControl] SET RECOVERY FULL
GO
ALTER DATABASE [iControl] SET  MULTI_USER
GO
ALTER DATABASE [iControl] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [iControl] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'iControl', N'ON'
GO
USE [iControl]
GO
/****** Object:  Table [dbo].[WareHouse]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WareHouse](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[WareHouse] [nchar](50) NULL,
 CONSTRAINT [PK_WareHouse] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[WareHouse] ON
INSERT [dbo].[WareHouse] ([iden], [WareHouse]) VALUES (7, N'KADUNA                                            ')
INSERT [dbo].[WareHouse] ([iden], [WareHouse]) VALUES (8, N'LAGOS                                             ')
INSERT [dbo].[WareHouse] ([iden], [WareHouse]) VALUES (9, N'ABUJA                                             ')
INSERT [dbo].[WareHouse] ([iden], [WareHouse]) VALUES (10, N'WARRI                                             ')
INSERT [dbo].[WareHouse] ([iden], [WareHouse]) VALUES (11, N'PH                                                ')
INSERT [dbo].[WareHouse] ([iden], [WareHouse]) VALUES (12, N'CENTRAL                                           ')
SET IDENTITY_INSERT [dbo].[WareHouse] OFF
/****** Object:  Table [dbo].[UserFunctions]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserFunctions](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](50) NULL,
	[AssignFunctions] [nchar](50) NULL,
 CONSTRAINT [PK_UserFunctions] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserFunctions] ON
INSERT [dbo].[UserFunctions] ([UserID], [UserName], [AssignFunctions]) VALUES (4, N'TONY                                              ', N'CREATE USERS                                      ')
INSERT [dbo].[UserFunctions] ([UserID], [UserName], [AssignFunctions]) VALUES (11, N'HARRY                                             ', N'RAISE REQUISITIONS                                ')
INSERT [dbo].[UserFunctions] ([UserID], [UserName], [AssignFunctions]) VALUES (12, N'ADMIN                                             ', N'APPROVE REQUISITIONS                              ')
INSERT [dbo].[UserFunctions] ([UserID], [UserName], [AssignFunctions]) VALUES (13, N'ADMIN                                             ', N'CREATE USERS                                      ')
INSERT [dbo].[UserFunctions] ([UserID], [UserName], [AssignFunctions]) VALUES (14, N'ADMIN                                             ', N'RAISE REQUISITIONS                                ')
INSERT [dbo].[UserFunctions] ([UserID], [UserName], [AssignFunctions]) VALUES (15, N'SEGUN                                             ', N'CREATE USERS                                      ')
INSERT [dbo].[UserFunctions] ([UserID], [UserName], [AssignFunctions]) VALUES (16, N'ABDUL                                             ', N'RAISE REQUISITIONS                                ')
INSERT [dbo].[UserFunctions] ([UserID], [UserName], [AssignFunctions]) VALUES (17, N'ABDUL                                             ', N'APPROVE REQUISITIONS                              ')
SET IDENTITY_INSERT [dbo].[UserFunctions] OFF
/****** Object:  Table [dbo].[User]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](20) NULL,
	[Pwd] [nchar](10) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User] ON
INSERT [dbo].[User] ([iden], [UserName], [Pwd], [Active]) VALUES (1, N'frank               ', N'123456    ', 0)
INSERT [dbo].[User] ([iden], [UserName], [Pwd], [Active]) VALUES (4, N'SEGUN               ', N'segun     ', 1)
INSERT [dbo].[User] ([iden], [UserName], [Pwd], [Active]) VALUES (5, N'HARRY               ', N'123456    ', 1)
INSERT [dbo].[User] ([iden], [UserName], [Pwd], [Active]) VALUES (8, N'ADMIN               ', N'123456    ', 1)
INSERT [dbo].[User] ([iden], [UserName], [Pwd], [Active]) VALUES (9, N'ABDUL               ', N'123456    ', 1)
SET IDENTITY_INSERT [dbo].[User] OFF
/****** Object:  Table [dbo].[Supplier]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[SupplierNumber] [nchar](15) NULL,
	[SupplierName] [nchar](50) NULL,
	[PhoneNumber] [nchar](20) NULL,
	[SupplierAddress] [nchar](100) NULL,
	[Type] [nchar](20) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON
INSERT [dbo].[Supplier] ([iden], [SupplierNumber], [SupplierName], [PhoneNumber], [SupplierAddress], [Type]) VALUES (1, N'001            ', N'ADE ROYAL                                         ', N'87686768678         ', N'KADUNA                                                                                              ', NULL)
INSERT [dbo].[Supplier] ([iden], [SupplierNumber], [SupplierName], [PhoneNumber], [SupplierAddress], [Type]) VALUES (2, N'               ', N'ACHIKS                                            ', N'                    ', N'                                                                                                    ', NULL)
INSERT [dbo].[Supplier] ([iden], [SupplierNumber], [SupplierName], [PhoneNumber], [SupplierAddress], [Type]) VALUES (3, N'004            ', N'REGS                                              ', N'89798789            ', N'LAGOS                                                                                               ', NULL)
SET IDENTITY_INSERT [dbo].[Supplier] OFF
/****** Object:  Table [dbo].[Stock]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[Classification] [nchar](50) NULL,
	[Brand] [nchar](50) NULL,
	[Location] [nchar](50) NULL,
	[Department] [nchar](50) NULL,
	[TypeOfTrans] [nchar](50) NULL,
	[Detail] [nchar](50) NULL,
	[JobCardNum] [nchar](30) NULL,
	[JobDescription] [nchar](50) NULL,
	[DOT] [date] NULL,
	[Source] [nchar](50) NULL,
	[Destination] [nchar](50) NULL,
	[Issued] [decimal](18, 2) NULL,
	[Reciepts] [decimal](18, 2) NULL,
	[Unitprice] [decimal](18, 2) NULL,
	[Amount] [decimal](18, 2) NULL,
	[ItemNumber] [nchar](50) NULL,
	[ItemName] [nchar](50) NULL,
	[PartNumber] [nchar](50) NULL,
	[DOE] [date] NULL,
	[Major] [nchar](50) NULL,
	[MakorMinor] [nchar](50) NULL,
	[Minor] [nchar](50) NULL,
	[ItemCost] [numeric](18, 2) NULL,
	[AcctCode] [nchar](30) NULL,
	[AcctName] [nchar](50) NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Stock] ON
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (56, N'TYRE                                              ', N'MICHELIN                                          ', N'CENTRAL                                           ', N'                                                  ', N'SUPPLY                                            ', N'VENDOR SUPPLY                                     ', N'                              ', N'                                                  ', CAST(0x8C3B0B00 AS Date), N'ADE ROYAL                                         ', N'CENTRAL                                           ', CAST(0.00 AS Decimal(18, 2)), CAST(34.00 AS Decimal(18, 2)), CAST(3200.00 AS Decimal(18, 2)), CAST(108800.00 AS Decimal(18, 2)), N'9876                                              ', N'R56                                               ', N'00000                                             ', CAST(0x9D3B0B00 AS Date), N'SUPPLY                                            ', N'SUPPLY                                            ', N'SUPPLY                                            ', CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (57, N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'CENTRAL                                           ', N'                                                  ', N'SUPPLY                                            ', N'VENDOR SUPPLY                                     ', N'                              ', N'                                                  ', CAST(0x8C3B0B00 AS Date), N'ADE ROYAL                                         ', N'CENTRAL                                           ', CAST(0.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), CAST(4500.00 AS Decimal(18, 2)), CAST(202500.00 AS Decimal(18, 2)), N'5634                                              ', N'BOLT453                                           ', N'4678                                              ', CAST(0x9D3B0B00 AS Date), N'SUPPLY                                            ', N'SUPPLY                                            ', N'SUPPLY                                            ', CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (58, N'LUBRICANTS                                        ', N'CAT                                               ', N'CENTRAL                                           ', N'                                                  ', N'SUPPLY                                            ', N'VENDOR SUPPLY                                     ', N'                              ', N'                                                  ', CAST(0x8C3B0B00 AS Date), N'ADE ROYAL                                         ', N'CENTRAL                                           ', CAST(0.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(6000.00 AS Decimal(18, 2)), CAST(78000.00 AS Decimal(18, 2)), N'1234                                              ', N'ENGINE OIL                                        ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'SUPPLY                                            ', N'SUPPLY                                            ', N'SUPPLY                                            ', CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (59, N'TYRE                                              ', N'MICHELIN                                          ', N'CENTRAL                                           ', N'                                                  ', N'LOC TRANSFERS                                     ', N'INTER LOC. TRANSFERS                              ', N'                              ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'CENTRAL                                           ', N'LAGOS                                             ', CAST(0.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'9876                                              ', N'R56                                               ', N'00000                                             ', CAST(0x9D3B0B00 AS Date), N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (60, N'TYRE                                              ', N'MICHELIN                                          ', N'CENTRAL                                           ', N'                                                  ', N'LOC TRANSFERS                                     ', N'INTER LOC. TRANSFERS                              ', N'                              ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'CENTRAL                                           ', N'LAGOS                                             ', CAST(5.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'9876                                              ', N'R56                                               ', N'00000                                             ', CAST(0x9D3B0B00 AS Date), N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (61, N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'CENTRAL                                           ', N'                                                  ', N'LOC TRANSFERS                                     ', N'INTER LOC. TRANSFERS                              ', N'                              ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'CENTRAL                                           ', N'LAGOS                                             ', CAST(0.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'5634                                              ', N'BOLT453                                           ', N'4678                                              ', CAST(0x9D3B0B00 AS Date), N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (62, N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'CENTRAL                                           ', N'                                                  ', N'LOC TRANSFERS                                     ', N'INTER LOC. TRANSFERS                              ', N'                              ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'CENTRAL                                           ', N'LAGOS                                             ', CAST(12.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'5634                                              ', N'BOLT453                                           ', N'4678                                              ', CAST(0x9D3B0B00 AS Date), N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (63, N'LUBRICANTS                                        ', N'CAT                                               ', N'CENTRAL                                           ', N'                                                  ', N'LOC TRANSFERS                                     ', N'INTER LOC. TRANSFERS                              ', N'                              ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'CENTRAL                                           ', N'LAGOS                                             ', CAST(0.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'1234                                              ', N'ENGINE OIL                                        ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (64, N'LUBRICANTS                                        ', N'CAT                                               ', N'CENTRAL                                           ', N'                                                  ', N'LOC TRANSFERS                                     ', N'INTER LOC. TRANSFERS                              ', N'                              ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'CENTRAL                                           ', N'LAGOS                                             ', CAST(5.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'1234                                              ', N'ENGINE OIL                                        ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', N'LOCTRANSFERS                                      ', CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (65, N'TYRE                                              ', N'MICHELIN                                          ', N'LAGOS                                             ', N'WORKSHOP                                          ', N'LOCATIONISSUANCE                                  ', N'LOCATION ISSUANCE                                 ', N'                              ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'LAGOS                                             ', N'WORKSHOP                                          ', CAST(2.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'9876                                              ', N'R56                                               ', N'00000                                             ', CAST(0x9D3B0B00 AS Date), N'CENTRALISSUANCE                                   ', N'CENTRALISSUANCE                                   ', N'LOCATIONISSUANCE                                  ', CAST(3200.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (66, N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'LAGOS                                             ', N'ACCOUNTS                                          ', N'LOCATIONISSUANCE                                  ', N'LOCATION ISSUANCE                                 ', N'JB001                         ', N'VEHICLE                                           ', CAST(0x9D3B0B00 AS Date), N'LAGOS                                             ', N'ACCOUNTS                                          ', CAST(2.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'5634                                              ', N'BOLT453                                           ', N'4678                                              ', CAST(0x9D3B0B00 AS Date), N'CENTRALISSUANCE                                   ', N'CENTRALISSUANCE                                   ', N'LOCATIONISSUANCE                                  ', CAST(4500.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Stock] ([iden], [Classification], [Brand], [Location], [Department], [TypeOfTrans], [Detail], [JobCardNum], [JobDescription], [DOT], [Source], [Destination], [Issued], [Reciepts], [Unitprice], [Amount], [ItemNumber], [ItemName], [PartNumber], [DOE], [Major], [MakorMinor], [Minor], [ItemCost], [AcctCode], [AcctName]) VALUES (67, N'LUBRICANTS                                        ', N'CAT                                               ', N'LAGOS                                             ', N'ACCOUNTS                                          ', N'LOCATIONISSUANCE                                  ', N'LOCATION ISSUANCE                                 ', N'                              ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'LAGOS                                             ', N'ACCOUNTS                                          ', CAST(1.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'1234                                              ', N'ENGINE OIL                                        ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'CENTRALISSUANCE                                   ', N'CENTRALISSUANCE                                   ', N'LOCATIONISSUANCE                                  ', CAST(6000.00 AS Numeric(18, 2)), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Stock] OFF
/****** Object:  Table [dbo].[RequisitionSummary]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequisitionSummary](
	[RequisitionNumber] [nchar](15) NOT NULL,
	[Department] [nchar](50) NULL,
	[DOR] [date] NULL,
	[Amount] [numeric](18, 2) NULL,
	[Status] [nchar](10) NULL,
	[Approved] [bit] NULL,
	[Rejected] [bit] NULL,
	[Partial] [bit] NULL,
	[Location] [nchar](50) NULL,
 CONSTRAINT [PK_RequisitionSummary] PRIMARY KEY CLUSTERED 
(
	[RequisitionNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[RequisitionSummary] ([RequisitionNumber], [Department], [DOR], [Amount], [Status], [Approved], [Rejected], [Partial], [Location]) VALUES (N'909            ', N'WORKSHOP                                          ', CAST(0x9D3B0B00 AS Date), CAST(280459.00 AS Numeric(18, 2)), N'TREATED   ', 0, 0, 0, N'LAGOS                                             ')
/****** Object:  Table [dbo].[Requisitions]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requisitions](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[RequistionNumber] [nchar](15) NULL,
	[Classification] [nchar](50) NULL,
	[Brand] [nchar](50) NULL,
	[ItemNumber] [nchar](50) NULL,
	[ItemName] [nchar](50) NULL,
	[PartNumber] [nchar](50) NULL,
	[DOR] [date] NULL,
	[Department] [nchar](50) NULL,
	[Originator] [nchar](50) NULL,
	[Status] [nchar](15) NULL,
	[Quantity] [numeric](18, 2) NULL,
	[UnitPrice] [numeric](18, 2) NULL,
	[Amount] [numeric](18, 2) NULL,
	[ExpDate] [date] NULL,
	[QuantityApproved] [numeric](18, 2) NULL,
	[Approved] [bit] NULL,
	[rejected] [bit] NULL,
	[Partial] [bit] NULL,
	[location] [nchar](50) NULL,
 CONSTRAINT [PK_Requisitions] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Requisitions] ON
INSERT [dbo].[Requisitions] ([iden], [RequistionNumber], [Classification], [Brand], [ItemNumber], [ItemName], [PartNumber], [DOR], [Department], [Originator], [Status], [Quantity], [UnitPrice], [Amount], [ExpDate], [QuantityApproved], [Approved], [rejected], [Partial], [location]) VALUES (46, N'909            ', N'TYRE                                              ', N'MICHELIN                                          ', N'9876                                              ', N'R56                                               ', N'00000                                             ', CAST(0x9D3B0B00 AS Date), N'WORKSHOP                                          ', N'DGG                                               ', N'PENDING        ', CAST(5.00 AS Numeric(18, 2)), CAST(565.00 AS Numeric(18, 2)), CAST(2825.00 AS Numeric(18, 2)), CAST(0x9D3B0B00 AS Date), CAST(2.00 AS Numeric(18, 2)), 0, 0, 0, N'LAGOS                                             ')
INSERT [dbo].[Requisitions] ([iden], [RequistionNumber], [Classification], [Brand], [ItemNumber], [ItemName], [PartNumber], [DOR], [Department], [Originator], [Status], [Quantity], [UnitPrice], [Amount], [ExpDate], [QuantityApproved], [Approved], [rejected], [Partial], [location]) VALUES (47, N'909            ', N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'5634                                              ', N'BOLT453                                           ', N'4678                                              ', CAST(0x9D3B0B00 AS Date), N'WORKSHOP                                          ', N'TYTRYTR                                           ', N'PENDING        ', CAST(8.00 AS Numeric(18, 2)), CAST(34534.00 AS Numeric(18, 2)), CAST(276272.00 AS Numeric(18, 2)), CAST(0x9D3B0B00 AS Date), CAST(2.00 AS Numeric(18, 2)), 0, 0, 0, N'LAGOS                                             ')
INSERT [dbo].[Requisitions] ([iden], [RequistionNumber], [Classification], [Brand], [ItemNumber], [ItemName], [PartNumber], [DOR], [Department], [Originator], [Status], [Quantity], [UnitPrice], [Amount], [ExpDate], [QuantityApproved], [Approved], [rejected], [Partial], [location]) VALUES (48, N'909            ', N'LUBRICANTS                                        ', N'CAT                                               ', N'1234                                              ', N'ENGINE OIL                                        ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'WORKSHOP                                          ', N'ETERTER                                           ', N'PENDING        ', CAST(3.00 AS Numeric(18, 2)), CAST(454.00 AS Numeric(18, 2)), CAST(1362.00 AS Numeric(18, 2)), CAST(0x9D3B0B00 AS Date), CAST(2.00 AS Numeric(18, 2)), 0, 0, 0, N'LAGOS                                             ')
SET IDENTITY_INSERT [dbo].[Requisitions] OFF
/****** Object:  Table [dbo].[JobCard]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobCard](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[JobCardNumber] [nchar](20) NULL,
	[JobCardDescription] [nchar](70) NULL,
 CONSTRAINT [PK_JobCard] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[JobCard] ON
INSERT [dbo].[JobCard] ([iden], [JobCardNumber], [JobCardDescription]) VALUES (1, N'JB001               ', N'VEHICLE                                                               ')
INSERT [dbo].[JobCard] ([iden], [JobCardNumber], [JobCardDescription]) VALUES (2, N'JB002               ', N'BODY                                                                  ')
INSERT [dbo].[JobCard] ([iden], [JobCardNumber], [JobCardDescription]) VALUES (3, N'JB003               ', N'HEAD                                                                  ')
SET IDENTITY_INSERT [dbo].[JobCard] OFF
/****** Object:  Table [dbo].[ItemMaster]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemMaster](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[PartNumber] [nchar](50) NULL,
	[Classification] [nchar](50) NULL,
	[Brand] [nchar](50) NULL,
	[PartName] [nchar](50) NULL,
	[Description] [nchar](80) NULL,
	[ItemNumber] [nchar](50) NULL,
	[Balance] [numeric](18, 2) NULL,
	[ApprovedForIssue] [numeric](18, 2) NULL,
	[Location] [nchar](50) NULL,
	[AcctCode] [nchar](30) NULL,
	[AcctName] [nchar](50) NULL,
 CONSTRAINT [PK_ItemMaster] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ItemMaster] ON
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (13, N'00000                                             ', N'TYRE                                              ', N'MICHELIN                                          ', N'R56                                               ', N'MY TYRE                                                                         ', N'9876                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'KADUNA                                            ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (14, N'                                                  ', N'LUBRICANTS                                        ', N'CAT                                               ', N'ENGINE OIL                                        ', N'                                                                                ', N'1234                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'KADUNA                                            ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (15, N'00000                                             ', N'TYRE                                              ', N'MICHELIN                                          ', N'R56                                               ', N'MY TYRE                                                                         ', N'9876                                              ', CAST(3.00 AS Numeric(18, 2)), CAST(2.00 AS Numeric(18, 2)), N'LAGOS                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (16, N'                                                  ', N'LUBRICANTS                                        ', N'CAT                                               ', N'ENGINE OIL                                        ', N'                                                                                ', N'1234                                              ', CAST(4.00 AS Numeric(18, 2)), CAST(2.00 AS Numeric(18, 2)), N'LAGOS                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (17, N'00000                                             ', N'TYRE                                              ', N'MICHELIN                                          ', N'R56                                               ', N'MY TYRE                                                                         ', N'9876                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'ABUJA                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (18, N'                                                  ', N'LUBRICANTS                                        ', N'CAT                                               ', N'ENGINE OIL                                        ', N'                                                                                ', N'1234                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'ABUJA                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (19, N'00000                                             ', N'TYRE                                              ', N'MICHELIN                                          ', N'R56                                               ', N'MY TYRE                                                                         ', N'9876                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'WARRI                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (20, N'                                                  ', N'LUBRICANTS                                        ', N'CAT                                               ', N'ENGINE OIL                                        ', N'                                                                                ', N'1234                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'WARRI                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (21, N'4678                                              ', N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'BOLT453                                           ', N'DOZER BOLT                                                                      ', N'5634                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'KADUNA                                            ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (22, N'4678                                              ', N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'BOLT453                                           ', N'DOZER BOLT                                                                      ', N'5634                                              ', CAST(10.00 AS Numeric(18, 2)), CAST(2.00 AS Numeric(18, 2)), N'LAGOS                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (23, N'4678                                              ', N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'BOLT453                                           ', N'DOZER BOLT                                                                      ', N'5634                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'ABUJA                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (24, N'4678                                              ', N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'BOLT453                                           ', N'DOZER BOLT                                                                      ', N'5634                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'WARRI                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (25, N'                                                  ', N'TYRE                                              ', N'PIRRELI                                           ', N'TYRE67876                                         ', N'                                                                                ', N'65757                                             ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'KADUNA                                            ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (26, N'                                                  ', N'TYRE                                              ', N'PIRRELI                                           ', N'TYRE67876                                         ', N'                                                                                ', N'65757                                             ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'LAGOS                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (27, N'                                                  ', N'TYRE                                              ', N'PIRRELI                                           ', N'TYRE67876                                         ', N'                                                                                ', N'65757                                             ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'ABUJA                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (28, N'                                                  ', N'TYRE                                              ', N'PIRRELI                                           ', N'TYRE67876                                         ', N'                                                                                ', N'65757                                             ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'WARRI                                             ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (29, N'00000                                             ', N'TYRE                                              ', N'MICHELIN                                          ', N'R56                                               ', N'MY TYRE                                                                         ', N'9876                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'PH                                                ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (30, N'                                                  ', N'LUBRICANTS                                        ', N'CAT                                               ', N'ENGINE OIL                                        ', N'                                                                                ', N'1234                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'PH                                                ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (31, N'4678                                              ', N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'BOLT453                                           ', N'DOZER BOLT                                                                      ', N'5634                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'PH                                                ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (32, N'                                                  ', N'TYRE                                              ', N'PIRRELI                                           ', N'TYRE67876                                         ', N'                                                                                ', N'65757                                             ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'PH                                                ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (35, N'00000                                             ', N'TYRE                                              ', N'MICHELIN                                          ', N'R56                                               ', N'MY TYRE                                                                         ', N'9876                                              ', CAST(29.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'CENTRAL                                           ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (36, N'                                                  ', N'LUBRICANTS                                        ', N'CAT                                               ', N'ENGINE OIL                                        ', N'                                                                                ', N'1234                                              ', CAST(8.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'CENTRAL                                           ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (37, N'4678                                              ', N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'BOLT453                                           ', N'DOZER BOLT                                                                      ', N'5634                                              ', CAST(33.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'CENTRAL                                           ', NULL, NULL)
INSERT [dbo].[ItemMaster] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [Location], [AcctCode], [AcctName]) VALUES (38, N'                                                  ', N'TYRE                                              ', N'PIRRELI                                           ', N'TYRE67876                                         ', N'                                                                                ', N'65757                                             ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), N'CENTRAL                                           ', NULL, NULL)
SET IDENTITY_INSERT [dbo].[ItemMaster] OFF
/****** Object:  Table [dbo].[Item]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[PartNumber] [nchar](50) NULL,
	[Classification] [nchar](50) NULL,
	[Brand] [nchar](50) NULL,
	[PartName] [nchar](50) NULL,
	[Description] [nchar](80) NULL,
	[ItemNumber] [nchar](50) NULL,
	[Balance] [numeric](18, 2) NULL,
	[ApprovedForIssue] [numeric](18, 2) NULL,
	[AcctCpde] [nchar](30) NULL,
	[AcctName] [nchar](50) NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Item] ON
INSERT [dbo].[Item] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [AcctCpde], [AcctName]) VALUES (10, N'00000                                             ', N'TYRE                                              ', N'MICHELIN                                          ', N'R56                                               ', N'MY TYRE                                                                         ', N'9876                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Item] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [AcctCpde], [AcctName]) VALUES (11, N'                                                  ', N'LUBRICANTS                                        ', N'CAT                                               ', N'ENGINE OIL                                        ', N'                                                                                ', N'1234                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Item] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [AcctCpde], [AcctName]) VALUES (12, N'4678                                              ', N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'BOLT453                                           ', N'DOZER BOLT                                                                      ', N'5634                                              ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
INSERT [dbo].[Item] ([iden], [PartNumber], [Classification], [Brand], [PartName], [Description], [ItemNumber], [Balance], [ApprovedForIssue], [AcctCpde], [AcctName]) VALUES (13, N'                                                  ', N'TYRE                                              ', N'PIRRELI                                           ', N'TYRE67876                                         ', N'                                                                                ', N'65757                                             ', CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Item] OFF
/****** Object:  Table [dbo].[Function]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Function](
	[FunctionID] [int] IDENTITY(1,1) NOT NULL,
	[FuctionName] [nchar](80) NULL,
 CONSTRAINT [PK_Function] PRIMARY KEY CLUSTERED 
(
	[FunctionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Function] ON
INSERT [dbo].[Function] ([FunctionID], [FuctionName]) VALUES (2, N'APPROVE REQUISITIONS                                                            ')
INSERT [dbo].[Function] ([FunctionID], [FuctionName]) VALUES (3, N'CREATE USERS                                                                    ')
INSERT [dbo].[Function] ([FunctionID], [FuctionName]) VALUES (4, N'RAISE REQUISITIONS                                                              ')
SET IDENTITY_INSERT [dbo].[Function] OFF
/****** Object:  Table [dbo].[Department]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[Department] [nchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON
INSERT [dbo].[Department] ([iden], [Department]) VALUES (1, N'WORKSHOP                                          ')
INSERT [dbo].[Department] ([iden], [Department]) VALUES (2, N'WAREHOSE                                          ')
INSERT [dbo].[Department] ([iden], [Department]) VALUES (3, N'ACCOUNTS                                          ')
SET IDENTITY_INSERT [dbo].[Department] OFF
/****** Object:  Table [dbo].[Classification]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classification](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[classification] [nchar](50) NULL,
 CONSTRAINT [PK_Classification] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Classification] ON
INSERT [dbo].[Classification] ([iden], [classification]) VALUES (1, N'TYRE                                              ')
INSERT [dbo].[Classification] ([iden], [classification]) VALUES (2, N'SPARE PARTS                                       ')
INSERT [dbo].[Classification] ([iden], [classification]) VALUES (3, N'LUBRICANTS                                        ')
SET IDENTITY_INSERT [dbo].[Classification] OFF
/****** Object:  Table [dbo].[Brand]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[Brand] [nchar](50) NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Brand] ON
INSERT [dbo].[Brand] ([iden], [Brand]) VALUES (1, N'MICHELIN                                          ')
INSERT [dbo].[Brand] ([iden], [Brand]) VALUES (2, N'PIRRELI                                           ')
INSERT [dbo].[Brand] ([iden], [Brand]) VALUES (3, N'CAT                                               ')
SET IDENTITY_INSERT [dbo].[Brand] OFF
/****** Object:  Table [dbo].[ApprovedRequisitions]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApprovedRequisitions](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[RequistionNumber] [nchar](15) NULL,
	[Classification] [nchar](50) NULL,
	[Brand] [nchar](50) NULL,
	[ItemNumber] [nchar](50) NULL,
	[ItemName] [nchar](50) NULL,
	[PartNumber] [nchar](50) NULL,
	[DOR] [date] NULL,
	[Department] [nchar](50) NULL,
	[Originator] [nchar](50) NULL,
	[Status] [nchar](15) NULL,
	[Quantity] [numeric](18, 2) NULL,
	[UnitPrice] [numeric](18, 2) NULL,
	[Amount] [numeric](18, 2) NULL,
	[DOA] [date] NULL,
	[QuantityApproved] [numeric](18, 2) NULL,
	[Approved] [bit] NULL,
	[rejected] [bit] NULL,
	[Partial] [bit] NULL,
	[Balance] [numeric](18, 2) NULL,
	[location] [nchar](50) NULL,
 CONSTRAINT [PK_ApprovedRequisitions] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ApprovedRequisitions] ON
INSERT [dbo].[ApprovedRequisitions] ([iden], [RequistionNumber], [Classification], [Brand], [ItemNumber], [ItemName], [PartNumber], [DOR], [Department], [Originator], [Status], [Quantity], [UnitPrice], [Amount], [DOA], [QuantityApproved], [Approved], [rejected], [Partial], [Balance], [location]) VALUES (36, N'909            ', N'TYRE                                              ', N'MICHELIN                                          ', N'9876                                              ', N'R56                                               ', N'00000                                             ', CAST(0x9D3B0B00 AS Date), N'WORKSHOP                                          ', N'WORKSHOP                                          ', N'PARTIAL        ', CAST(5.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), CAST(0x9D3B0B00 AS Date), CAST(2.00 AS Numeric(18, 2)), 0, 0, 1, CAST(3.00 AS Numeric(18, 2)), N'LAGOS                                             ')
INSERT [dbo].[ApprovedRequisitions] ([iden], [RequistionNumber], [Classification], [Brand], [ItemNumber], [ItemName], [PartNumber], [DOR], [Department], [Originator], [Status], [Quantity], [UnitPrice], [Amount], [DOA], [QuantityApproved], [Approved], [rejected], [Partial], [Balance], [location]) VALUES (37, N'909            ', N'SPARE PARTS                                       ', N'PIRRELI                                           ', N'5634                                              ', N'BOLT453                                           ', N'4678                                              ', CAST(0x9D3B0B00 AS Date), N'WORKSHOP                                          ', N'WORKSHOP                                          ', N'PARTIAL        ', CAST(8.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), CAST(0x9D3B0B00 AS Date), CAST(2.00 AS Numeric(18, 2)), 0, 0, 1, CAST(6.00 AS Numeric(18, 2)), N'LAGOS                                             ')
INSERT [dbo].[ApprovedRequisitions] ([iden], [RequistionNumber], [Classification], [Brand], [ItemNumber], [ItemName], [PartNumber], [DOR], [Department], [Originator], [Status], [Quantity], [UnitPrice], [Amount], [DOA], [QuantityApproved], [Approved], [rejected], [Partial], [Balance], [location]) VALUES (38, N'909            ', N'LUBRICANTS                                        ', N'CAT                                               ', N'1234                                              ', N'ENGINE OIL                                        ', N'                                                  ', CAST(0x9D3B0B00 AS Date), N'WORKSHOP                                          ', N'WORKSHOP                                          ', N'PARTIAL        ', CAST(3.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)), CAST(0x9D3B0B00 AS Date), CAST(2.00 AS Numeric(18, 2)), 0, 0, 1, CAST(1.00 AS Numeric(18, 2)), N'LAGOS                                             ')
SET IDENTITY_INSERT [dbo].[ApprovedRequisitions] OFF
/****** Object:  Table [dbo].[AcctCodes]    Script Date: 07/17/2016 09:55:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcctCodes](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[AcctCode] [nchar](30) NULL,
	[AcctName] [nchar](50) NULL,
 CONSTRAINT [PK_AcctCodes] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AcctCodes] ON
INSERT [dbo].[AcctCodes] ([iden], [AcctCode], [AcctName]) VALUES (1, N'6867H                         ', N'BOLT                                              ')
INSERT [dbo].[AcctCodes] ([iden], [AcctCode], [AcctName]) VALUES (2, N'4564                          ', N'FUFUF                                             ')
INSERT [dbo].[AcctCodes] ([iden], [AcctCode], [AcctName]) VALUES (3, N'6867                          ', N'YGUGUYG                                           ')
INSERT [dbo].[AcctCodes] ([iden], [AcctCode], [AcctName]) VALUES (4, N'456                           ', N'GGUY                                              ')
INSERT [dbo].[AcctCodes] ([iden], [AcctCode], [AcctName]) VALUES (5, N'                              ', N'                                                  ')
SET IDENTITY_INSERT [dbo].[AcctCodes] OFF
