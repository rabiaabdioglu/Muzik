USE [Muzik]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6.12.2021 03:32:46 ******/
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
/****** Object:  Table [dbo].[Muzik]    Script Date: 6.12.2021 03:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muzik](
	[SarkiId] [int] IDENTITY(1,1) NOT NULL,
	[SarkiAd] [nvarchar](50) NOT NULL,
	[AlbumAd] [nvarchar](50) NULL,
	[CikisYili] [int] NOT NULL,
	[Artist] [nvarchar](50) NOT NULL,
	[Tur] [nvarchar](max) NULL,
	[SarkiSuresi] [nvarchar](max) NULL,
 CONSTRAINT [PK_Muzik] PRIMARY KEY CLUSTERED 
(
	[SarkiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211205165805_YENİ', N'3.1.21')
SET IDENTITY_INSERT [dbo].[Muzik] ON 

INSERT [dbo].[Muzik] ([SarkiId], [SarkiAd], [AlbumAd], [CikisYili], [Artist], [Tur], [SarkiSuresi]) VALUES (1, N'Kuzu Kuzu', N'Kuzu', 1998, N'Tarkan', N'Pop', N'2')
INSERT [dbo].[Muzik] ([SarkiId], [SarkiAd], [AlbumAd], [CikisYili], [Artist], [Tur], [SarkiSuresi]) VALUES (4, N'Sen Ağlama', N'Badem', 2003, N'Badem', N'Pop', N'3.42')
INSERT [dbo].[Muzik] ([SarkiId], [SarkiAd], [AlbumAd], [CikisYili], [Artist], [Tur], [SarkiSuresi]) VALUES (5, N'Olmaz Olsun', N'Hayat Rüya', 2010, N'Göksel', N'Pop', N'2.52')
INSERT [dbo].[Muzik] ([SarkiId], [SarkiAd], [AlbumAd], [CikisYili], [Artist], [Tur], [SarkiSuresi]) VALUES (7, N'Rüya', N'La''l', 2012, N'Sertap Erener', N'Pop', N'4.40')
INSERT [dbo].[Muzik] ([SarkiId], [SarkiAd], [AlbumAd], [CikisYili], [Artist], [Tur], [SarkiSuresi]) VALUES (8, N'Kumralım', N'Divane', 2003, N'Yaşar', N'Pop', N'3.30')
INSERT [dbo].[Muzik] ([SarkiId], [SarkiAd], [AlbumAd], [CikisYili], [Artist], [Tur], [SarkiSuresi]) VALUES (9, N'Nisan', N'Serseri Mayın', 2001, N'Gökhan Kırdar', N'Pop', N'5.49')
INSERT [dbo].[Muzik] ([SarkiId], [SarkiAd], [AlbumAd], [CikisYili], [Artist], [Tur], [SarkiSuresi]) VALUES (10, N'Medcezir', N'Medcezir', 1998, N'Levent Yüksel', N'Pop', N'4.34')
INSERT [dbo].[Muzik] ([SarkiId], [SarkiAd], [AlbumAd], [CikisYili], [Artist], [Tur], [SarkiSuresi]) VALUES (11, N'Son Arzum', N'Selam Söyle', 1995, N'Nilüfer', N'Pop', N'3.26')
INSERT [dbo].[Muzik] ([SarkiId], [SarkiAd], [AlbumAd], [CikisYili], [Artist], [Tur], [SarkiSuresi]) VALUES (12, N'Ki Sen', N'Ben Bugün ', 2006, N'Yalın', N'Pop', N'4.08')
INSERT [dbo].[Muzik] ([SarkiId], [SarkiAd], [AlbumAd], [CikisYili], [Artist], [Tur], [SarkiSuresi]) VALUES (13, N'Yazık', N'Yazık', 2005, N'Bengü', N'Pop', N'3.55')
SET IDENTITY_INSERT [dbo].[Muzik] OFF
