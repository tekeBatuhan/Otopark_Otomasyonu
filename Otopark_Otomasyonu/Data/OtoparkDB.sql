USE [OtoparkDB]
GO
/****** Object:  Table [dbo].[AracBilgi]    Script Date: 6.01.2024 17:12:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AracBilgi](
	[aracBilgiID] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciID] [int] NULL,
	[musteriID] [int] NULL,
	[girisTarihi] [smalldatetime] NULL,
	[cikisTarihi] [smalldatetime] NULL,
	[plaka] [nvarchar](50) NULL,
	[marka] [nvarchar](50) NULL,
	[ucret] [money] NULL,
	[renk] [nvarchar](50) NULL,
	[yerID] [int] NULL,
 CONSTRAINT [PK_AracBilgi] PRIMARY KEY CLUSTERED 
(
	[aracBilgiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GecmisIslem]    Script Date: 6.01.2024 17:12:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GecmisIslem](
	[gecmisIslemID] [int] IDENTITY(1,1) NOT NULL,
	[musteriID] [int] NULL,
	[aracBilgiID] [int] NULL,
	[ucret] [money] NULL,
	[plaka] [nvarchar](50) NULL,
	[marka] [nvarchar](50) NULL,
	[girisTarihi] [smalldatetime] NULL,
	[cikisTarihi] [smalldatetime] NULL,
	[renk] [nvarchar](50) NULL,
 CONSTRAINT [PK_GecmisIslem] PRIMARY KEY CLUSTERED 
(
	[gecmisIslemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 6.01.2024 17:12:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[kullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[unvanID] [int] NULL,
	[saatlikUcretID] [int] NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[eposta] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[adres] [nvarchar](500) NULL,
	[telefon] [nvarchar](11) NULL,
	[kimlikNo] [nvarchar](11) NULL,
	[dogumTarihi] [smalldatetime] NULL,
	[cinsiyet] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 6.01.2024 17:12:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[musteriID] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciID] [int] NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[musteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaatlikUcret]    Script Date: 6.01.2024 17:12:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaatlikUcret](
	[saatlikUcretID] [int] IDENTITY(1,1) NOT NULL,
	[birSaat] [nvarchar](50) NULL,
	[ucSaat] [nvarchar](50) NULL,
	[ucdenFazlaSaat] [nvarchar](50) NULL,
 CONSTRAINT [PK_SaatlikUcret] PRIMARY KEY CLUSTERED 
(
	[saatlikUcretID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unvan]    Script Date: 6.01.2024 17:12:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unvan](
	[unvanID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
 CONSTRAINT [PK_Unvan] PRIMARY KEY CLUSTERED 
(
	[unvanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yer]    Script Date: 6.01.2024 17:12:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yer](
	[yerID] [int] IDENTITY(1,1) NOT NULL,
	[adı] [nvarchar](50) NULL,
	[doluMu] [bit] NULL,
 CONSTRAINT [PK_Yer] PRIMARY KEY CLUSTERED 
(
	[yerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GecmisIslem] ON 

INSERT [dbo].[GecmisIslem] ([gecmisIslemID], [musteriID], [aracBilgiID], [ucret], [plaka], [marka], [girisTarihi], [cikisTarihi], [renk]) VALUES (56, 174, NULL, 25.0000, N'37 RB 126', NULL, NULL, NULL, NULL)
INSERT [dbo].[GecmisIslem] ([gecmisIslemID], [musteriID], [aracBilgiID], [ucret], [plaka], [marka], [girisTarihi], [cikisTarihi], [renk]) VALUES (57, 173, NULL, 25.0000, N'42 ADB', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[GecmisIslem] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([kullaniciID], [unvanID], [saatlikUcretID], [ad], [soyad], [eposta], [sifre], [adres], [telefon], [kimlikNo], [dogumTarihi], [cinsiyet]) VALUES (5, 1, NULL, N'BERKAY', N'özgü', N'berkay@gmail.com', N'1234', N'istanbul', N'12345678912', N'12345678912', CAST(N'1900-01-01T00:00:00' AS SmallDateTime), N'Erkek')
INSERT [dbo].[Kullanici] ([kullaniciID], [unvanID], [saatlikUcretID], [ad], [soyad], [eposta], [sifre], [adres], [telefon], [kimlikNo], [dogumTarihi], [cinsiyet]) VALUES (7, 1, NULL, N'batuhan', N'teke', N'batuhan@gmail.com', N'1234', N'konya', N'12345678912', N'12345678911', CAST(N'2023-01-01T00:00:00' AS SmallDateTime), N'Erkek')
INSERT [dbo].[Kullanici] ([kullaniciID], [unvanID], [saatlikUcretID], [ad], [soyad], [eposta], [sifre], [adres], [telefon], [kimlikNo], [dogumTarihi], [cinsiyet]) VALUES (8, 1, NULL, N'b', N'b', N'b', N'b', N'bb', N'b', N'b', CAST(N'1900-01-01T00:00:00' AS SmallDateTime), N'Erkek')
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([musteriID], [kullaniciID], [ad], [soyad], [telefon]) VALUES (173, NULL, N'Batuhan', N'teke', N'123456789')
INSERT [dbo].[Musteri] ([musteriID], [kullaniciID], [ad], [soyad], [telefon]) VALUES (174, NULL, N'Nilay', N'can', N'123456789')
SET IDENTITY_INSERT [dbo].[Musteri] OFF
GO
SET IDENTITY_INSERT [dbo].[SaatlikUcret] ON 

INSERT [dbo].[SaatlikUcret] ([saatlikUcretID], [birSaat], [ucSaat], [ucdenFazlaSaat]) VALUES (1, N'25', N'20', N'20')
SET IDENTITY_INSERT [dbo].[SaatlikUcret] OFF
GO
SET IDENTITY_INSERT [dbo].[Unvan] ON 

INSERT [dbo].[Unvan] ([unvanID], [ad]) VALUES (1, N'Yetkili')
INSERT [dbo].[Unvan] ([unvanID], [ad]) VALUES (2, N'Çalışan')
SET IDENTITY_INSERT [dbo].[Unvan] OFF
GO
ALTER TABLE [dbo].[AracBilgi]  WITH CHECK ADD  CONSTRAINT [FK_AracBilgi_Kullanici] FOREIGN KEY([kullaniciID])
REFERENCES [dbo].[Kullanici] ([kullaniciID])
GO
ALTER TABLE [dbo].[AracBilgi] CHECK CONSTRAINT [FK_AracBilgi_Kullanici]
GO
ALTER TABLE [dbo].[AracBilgi]  WITH CHECK ADD  CONSTRAINT [FK_AracBilgi_Musteri] FOREIGN KEY([musteriID])
REFERENCES [dbo].[Musteri] ([musteriID])
GO
ALTER TABLE [dbo].[AracBilgi] CHECK CONSTRAINT [FK_AracBilgi_Musteri]
GO
ALTER TABLE [dbo].[AracBilgi]  WITH CHECK ADD  CONSTRAINT [FK_AracBilgi_Yer] FOREIGN KEY([yerID])
REFERENCES [dbo].[Yer] ([yerID])
GO
ALTER TABLE [dbo].[AracBilgi] CHECK CONSTRAINT [FK_AracBilgi_Yer]
GO
ALTER TABLE [dbo].[GecmisIslem]  WITH CHECK ADD  CONSTRAINT [FK_GecmisIslem_AracBilgi] FOREIGN KEY([aracBilgiID])
REFERENCES [dbo].[AracBilgi] ([aracBilgiID])
GO
ALTER TABLE [dbo].[GecmisIslem] CHECK CONSTRAINT [FK_GecmisIslem_AracBilgi]
GO
ALTER TABLE [dbo].[GecmisIslem]  WITH CHECK ADD  CONSTRAINT [FK_GecmisIslem_Musteri] FOREIGN KEY([musteriID])
REFERENCES [dbo].[Musteri] ([musteriID])
GO
ALTER TABLE [dbo].[GecmisIslem] CHECK CONSTRAINT [FK_GecmisIslem_Musteri]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_SaatlikUcret] FOREIGN KEY([saatlikUcretID])
REFERENCES [dbo].[SaatlikUcret] ([saatlikUcretID])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_SaatlikUcret]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Unvan] FOREIGN KEY([unvanID])
REFERENCES [dbo].[Unvan] ([unvanID])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Unvan]
GO
ALTER TABLE [dbo].[Musteri]  WITH CHECK ADD  CONSTRAINT [FK_Musteri_Kullanici] FOREIGN KEY([kullaniciID])
REFERENCES [dbo].[Kullanici] ([kullaniciID])
GO
ALTER TABLE [dbo].[Musteri] CHECK CONSTRAINT [FK_Musteri_Kullanici]
GO
