USE [YashDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/18/2021 8:29:21 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](200) NULL,
	[LastName] [nvarchar](200) NULL,
	[Address] [nvarchar](200) NULL,
	[Email] [nvarchar](200) NULL,
	[Password] [nvarchar](200) NULL,
	[Role] [bit] NOT NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carts]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [real] NOT NULL,
	[UserId] [int] NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Carts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Certifications]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certifications](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[LinkUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Certifications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diamonds]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diamonds](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DiamondShape] [nvarchar](max) NULL,
	[Price] [real] NOT NULL,
 CONSTRAINT [PK_Diamonds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Golds]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Golds](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GoldCarat] [nvarchar](max) NULL,
	[Price] [real] NOT NULL,
 CONSTRAINT [PK_Golds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemImages]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemImages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[ItemImageUrl] [nvarchar](200) NULL,
	[IsDefault] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
 CONSTRAINT [PK_ItemImages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Quantity] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[CertifyId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[GoldId] [int] NOT NULL,
	[DiamondId] [int] NOT NULL,
	[DiamondCarat] [real] NOT NULL,
	[GoldWeight] [real] NOT NULL,
	[WastageInPercentage] [int] NOT NULL,
	[TotalMaking] [real] NOT NULL,
	[RingSizeId] [int] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[Price] [real] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[UserId] [int] NOT NULL,
	[ShipName] [nvarchar](200) NULL,
	[ShipAddress] [nvarchar](200) NULL,
	[ShipEmail] [varchar](100) NULL,
	[ShipPhoneNumber] [nvarchar](200) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTypes]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RingSizes]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RingSizes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SizeNumber] [int] NOT NULL,
 CONSTRAINT [PK_RingSizes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/18/2021 8:29:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[DOB] [datetime2](7) NOT NULL,
	[CurrentDate] [datetime2](7) NOT NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210223104758_add_data_seeding', N'3.1.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210303091859_add_quantity_column_in_orderdetail_table', N'3.1.1')
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([Id], [FirstName], [LastName], [Address], [Email], [Password], [Role]) VALUES (1, N'Minh', N'Le', N'cmt8', N'minhl93172@gmail.com', N'123', 1)
INSERT [dbo].[Admins] ([Id], [FirstName], [LastName], [Address], [Email], [Password], [Role]) VALUES (2, N'Tuan', N'Bui', N'cmt8', N'tuan123@gmail.com', N'123', 1)
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Anniversary')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Birthday')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Wedding')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Engagement')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'For mom')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (6, N'For dad')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Certifications] ON 

INSERT [dbo].[Certifications] ([Id], [Name], [LinkUrl]) VALUES (1, N'BIS Hallmark', N'http://www.bis.org.in/')
INSERT [dbo].[Certifications] ([Id], [Name], [LinkUrl]) VALUES (2, N'SGL', N'https://sgl-labs.com/')
INSERT [dbo].[Certifications] ([Id], [Name], [LinkUrl]) VALUES (3, N'IGI', N'https://www.igi.org/')
SET IDENTITY_INSERT [dbo].[Certifications] OFF
GO
SET IDENTITY_INSERT [dbo].[Diamonds] ON 

INSERT [dbo].[Diamonds] ([Id], [DiamondShape], [Price]) VALUES (1, N'round', 7291)
INSERT [dbo].[Diamonds] ([Id], [DiamondShape], [Price]) VALUES (2, N'princess', 4799)
INSERT [dbo].[Diamonds] ([Id], [DiamondShape], [Price]) VALUES (3, N'oval', 5362)
INSERT [dbo].[Diamonds] ([Id], [DiamondShape], [Price]) VALUES (4, N'cushion', 4229)
INSERT [dbo].[Diamonds] ([Id], [DiamondShape], [Price]) VALUES (5, N'pear', 5802)
INSERT [dbo].[Diamonds] ([Id], [DiamondShape], [Price]) VALUES (6, N'radiant', 4443)
INSERT [dbo].[Diamonds] ([Id], [DiamondShape], [Price]) VALUES (7, N'emerald', 4476)
INSERT [dbo].[Diamonds] ([Id], [DiamondShape], [Price]) VALUES (8, N'asscher', 4137)
INSERT [dbo].[Diamonds] ([Id], [DiamondShape], [Price]) VALUES (9, N'marquise', 5596)
INSERT [dbo].[Diamonds] ([Id], [DiamondShape], [Price]) VALUES (10, N'heart', 5536)
SET IDENTITY_INSERT [dbo].[Diamonds] OFF
GO
SET IDENTITY_INSERT [dbo].[Golds] ON 

INSERT [dbo].[Golds] ([Id], [GoldCarat], [Price]) VALUES (1, N'14kt', 1034.8)
INSERT [dbo].[Golds] ([Id], [GoldCarat], [Price]) VALUES (2, N'18kt', 1338.9)
SET IDENTITY_INSERT [dbo].[Golds] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemImages] ON 

INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (1, 1, N'images_product/ring1.png', 1, 1)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (2, 1, N'images_product/ring2.png', 0, 2)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (3, 2, N'images_product/ring3.png', 1, 1)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (4, 2, N'images_product/ring4.png', 0, 2)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (5, 3, N'images_product/ring5.png', 1, 1)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (6, 3, N'images_product/ring6.png', 0, 2)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (7, 4, N'images_product/earring1.png', 1, 1)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (8, 4, N'images_product/earring2.png', 0, 2)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (9, 5, N'images_product/earring3.png', 1, 1)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (10, 5, N'images_product/earring4.png', 0, 2)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (11, 6, N'images_product/earring5.png', 1, 1)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (12, 6, N'images_product/earring6.png', 0, 2)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (13, 7, N'images_product/pendant1.png', 1, 1)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (14, 7, N'images_product/pendant2.png', 0, 2)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (15, 8, N'images_product/pendant3.png', 1, 1)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (16, 8, N'images_product/pendant4.png', 0, 2)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (17, 9, N'images_product/pendant5.png', 1, 1)
INSERT [dbo].[ItemImages] ([Id], [ItemId], [ItemImageUrl], [IsDefault], [SortOrder]) VALUES (18, 9, N'images_product/pendant6.png', 0, 2)
SET IDENTITY_INSERT [dbo].[ItemImages] OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Id], [Name], [Quantity], [CategoryId], [CertifyId], [ProductId], [GoldId], [DiamondId], [DiamondCarat], [GoldWeight], [WastageInPercentage], [TotalMaking], [RingSizeId]) VALUES (1, N'The Jhonita Two Finger Ring', 5, 1, 1, 1, 2, 2, 0.1, 1, 20, 26309, 6)
INSERT [dbo].[Items] ([Id], [Name], [Quantity], [CategoryId], [CertifyId], [ProductId], [GoldId], [DiamondId], [DiamondCarat], [GoldWeight], [WastageInPercentage], [TotalMaking], [RingSizeId]) VALUES (2, N'The Rudri Ring', 4, 2, 2, 1, 2, 3, 0.12, 1, 20, 33609, 10)
INSERT [dbo].[Items] ([Id], [Name], [Quantity], [CategoryId], [CertifyId], [ProductId], [GoldId], [DiamondId], [DiamondCarat], [GoldWeight], [WastageInPercentage], [TotalMaking], [RingSizeId]) VALUES (3, N'The Maruwani Ring', 5, 3, 3, 1, 1, 1, 0.12, 1, 20, 27731, 20)
INSERT [dbo].[Items] ([Id], [Name], [Quantity], [CategoryId], [CertifyId], [ProductId], [GoldId], [DiamondId], [DiamondCarat], [GoldWeight], [WastageInPercentage], [TotalMaking], [RingSizeId]) VALUES (4, N'The Arcane Stud Earrings', 4, 1, 1, 2, 1, 1, 0.07, 1, 20, 15000, 10)
INSERT [dbo].[Items] ([Id], [Name], [Quantity], [CategoryId], [CertifyId], [ProductId], [GoldId], [DiamondId], [DiamondCarat], [GoldWeight], [WastageInPercentage], [TotalMaking], [RingSizeId]) VALUES (5, N'The Purva Drop Earrings', 5, 2, 2, 2, 2, 1, 0.108, 1, 20, 21593, 10)
INSERT [dbo].[Items] ([Id], [Name], [Quantity], [CategoryId], [CertifyId], [ProductId], [GoldId], [DiamondId], [DiamondCarat], [GoldWeight], [WastageInPercentage], [TotalMaking], [RingSizeId]) VALUES (6, N'The Mahima Drop Earrings', 4, 3, 3, 2, 1, 2, 0.04, 1, 20, 23000, 10)
INSERT [dbo].[Items] ([Id], [Name], [Quantity], [CategoryId], [CertifyId], [ProductId], [GoldId], [DiamondId], [DiamondCarat], [GoldWeight], [WastageInPercentage], [TotalMaking], [RingSizeId]) VALUES (7, N'The Mulam Pendant', 4, 1, 1, 3, 2, 3, 0.04, 1, 20, 21752, 10)
INSERT [dbo].[Items] ([Id], [Name], [Quantity], [CategoryId], [CertifyId], [ProductId], [GoldId], [DiamondId], [DiamondCarat], [GoldWeight], [WastageInPercentage], [TotalMaking], [RingSizeId]) VALUES (8, N'The Rohal Pendant', 5, 2, 2, 3, 1, 3, 0.025, 1, 20, 11000, 10)
INSERT [dbo].[Items] ([Id], [Name], [Quantity], [CategoryId], [CertifyId], [ProductId], [GoldId], [DiamondId], [DiamondCarat], [GoldWeight], [WastageInPercentage], [TotalMaking], [RingSizeId]) VALUES (9, N'The Ambrosia Pendant', 4, 3, 3, 3, 2, 1, 0.029, 1, 20, 7962, 10)
SET IDENTITY_INSERT [dbo].[Items] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ItemId], [Price], [Quantity]) VALUES (10, 5, 8, 22000, 2)
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ItemId], [Price], [Quantity]) VALUES (11, 6, 9, 7962, 1)
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ItemId], [Price], [Quantity]) VALUES (12, 7, 2, 33609, 1)
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ItemId], [Price], [Quantity]) VALUES (13, 8, 2, 33609, 1)
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ItemId], [Price], [Quantity]) VALUES (14, 9, 2, 33609, 1)
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ItemId], [Price], [Quantity]) VALUES (15, 9, 3, 27731, 1)
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ItemId], [Price], [Quantity]) VALUES (16, 9, 6, 23000, 1)
INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ItemId], [Price], [Quantity]) VALUES (17, 10, 2, 33609, 1)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [ShipName], [ShipAddress], [ShipEmail], [ShipPhoneNumber], [Status]) VALUES (5, CAST(N'2021-01-11T09:47:11.9520050' AS DateTime2), 1, N'Minh Le', N'CMT8 HCM ', N'minh123@gmail.com', NULL, 3)
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [ShipName], [ShipAddress], [ShipEmail], [ShipPhoneNumber], [Status]) VALUES (6, CAST(N'2021-02-11T21:26:33.7465353' AS DateTime2), 1, N'Minh Le', N'CMT8 HCM ', N'minh123@gmail.com', NULL, 3)
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [ShipName], [ShipAddress], [ShipEmail], [ShipPhoneNumber], [Status]) VALUES (7, CAST(N'2021-03-12T08:40:43.4067044' AS DateTime2), 1, N'Minh Le', N'CMT8 HCM ', N'minh123@gmail.com', NULL, 3)
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [ShipName], [ShipAddress], [ShipEmail], [ShipPhoneNumber], [Status]) VALUES (8, CAST(N'2021-04-13T09:10:10.4865768' AS DateTime2), 1, N'Minh Le', N'CMT8 HCM ', N'minh123@gmail.com', NULL, 3)
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [ShipName], [ShipAddress], [ShipEmail], [ShipPhoneNumber], [Status]) VALUES (9, CAST(N'2021-05-13T09:17:36.1689458' AS DateTime2), 1, N'Minh Le', N'CMT8 HCM ', N'minh123@gmail.com', NULL, 3)
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [ShipName], [ShipAddress], [ShipEmail], [ShipPhoneNumber], [Status]) VALUES (10, CAST(N'2021-03-18T08:25:50.1447556' AS DateTime2), 1, N'Minh Le', N'CMT8 HCM ', N'minh123@gmail.com', NULL, 1)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductTypes] ON 

INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (1, N'RINGS')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (2, N'EARRINGS')
INSERT [dbo].[ProductTypes] ([Id], [Name]) VALUES (3, N'PENDANTS')
SET IDENTITY_INSERT [dbo].[ProductTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[RingSizes] ON 

INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (1, 6)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (2, 7)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (3, 8)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (4, 9)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (5, 10)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (6, 11)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (7, 12)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (8, 13)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (9, 14)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (10, 15)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (11, 16)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (12, 17)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (13, 18)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (14, 19)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (15, 20)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (16, 21)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (17, 22)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (18, 23)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (19, 24)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (20, 25)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (21, 26)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (22, 27)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (23, 28)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (24, 29)
INSERT [dbo].[RingSizes] ([Id], [SizeNumber]) VALUES (25, 30)
SET IDENTITY_INSERT [dbo].[RingSizes] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Address], [City], [State], [PhoneNumber], [Email], [DOB], [CurrentDate], [Password]) VALUES (1, N'Minh', N'Le', N'CMT8', N'HCM', NULL, NULL, N'minh123@gmail.com', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'123123123')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Address], [City], [State], [PhoneNumber], [Email], [DOB], [CurrentDate], [Password]) VALUES (2, N'Tuan', N'Bui', N'3 Thang 2', N'HCM', NULL, NULL, N'tuan123@gmail.com', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'123')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Address], [City], [State], [PhoneNumber], [Email], [DOB], [CurrentDate], [Password]) VALUES (3, N'admin', N'admin', N'Hoang Sa', N'HCM', NULL, NULL, N'admin123@gmail.com', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'123123123')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Address], [City], [State], [PhoneNumber], [Email], [DOB], [CurrentDate], [Password]) VALUES (4, N'Minh', N'Le', N'123 oak Ave', N'Texas', N'TX', N'0901496630', N'minhl93172@gmail.com', CAST(N'2021-02-14T00:00:00.0000000' AS DateTime2), CAST(N'2021-03-12T11:16:00.0000000' AS DateTime2), N'123')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Admins] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Role]
GO
ALTER TABLE [dbo].[Items] ADD  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Items] ADD  DEFAULT ((2)) FOR [GoldId]
GO
ALTER TABLE [dbo].[Items] ADD  DEFAULT (CONVERT([real],(1))) FOR [GoldWeight]
GO
ALTER TABLE [dbo].[Items] ADD  DEFAULT ((20)) FOR [WastageInPercentage]
GO
ALTER TABLE [dbo].[OrderDetails] ADD  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_Items_ItemId] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_Items_ItemId]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_Users_UserId]
GO
ALTER TABLE [dbo].[ItemImages]  WITH CHECK ADD  CONSTRAINT [FK_ItemImages_Items_ItemId] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ItemImages] CHECK CONSTRAINT [FK_ItemImages_Items_ItemId]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Certifications_CertifyId] FOREIGN KEY([CertifyId])
REFERENCES [dbo].[Certifications] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Certifications_CertifyId]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Diamonds_DiamondId] FOREIGN KEY([DiamondId])
REFERENCES [dbo].[Diamonds] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Diamonds_DiamondId]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Golds_GoldId] FOREIGN KEY([GoldId])
REFERENCES [dbo].[Golds] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Golds_GoldId]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_ProductTypes_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[ProductTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_ProductTypes_ProductId]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_RingSizes_RingSizeId] FOREIGN KEY([RingSizeId])
REFERENCES [dbo].[RingSizes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_RingSizes_RingSizeId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Items_ItemId] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Items_ItemId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders_OrderId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users_UserId]
GO
