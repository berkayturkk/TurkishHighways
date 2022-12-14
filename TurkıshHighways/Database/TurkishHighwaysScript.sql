USE [TurkishHighways]
GO
/****** Object:  Table [dbo].[Bilet]    Script Date: 6.09.2022 10:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bilet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[Kimlik] [nchar](11) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
	[Uyruk] [nvarchar](50) NULL,
	[Pasaport] [nvarchar](50) NULL,
	[KartNo] [nvarchar](16) NULL,
	[SonKullanma] [nchar](10) NULL,
	[GüvenlikNo] [nchar](3) NULL,
	[SeferTarihi] [date] NULL,
	[KalkısYeri] [nvarchar](50) NULL,
	[VarısYeri] [nvarchar](50) NULL,
	[KoltukNo] [smallint] NULL,
	[Fiyat] [money] NULL,
 CONSTRAINT [PK_Bilet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DuzceIstanbulSeferListesi]    Script Date: 6.09.2022 10:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DuzceIstanbulSeferListesi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KalkısYeri] [nvarchar](50) NULL,
	[KalkısSaati] [time](5) NULL,
	[VarısYeri] [nvarchar](50) NULL,
	[VarısSaati] [time](5) NULL,
	[ToplamKoltuk] [smallint] NULL,
	[DoluKoltuk] [smallint] NULL,
	[Fiyat] [money] NULL,
 CONSTRAINT [PK_DuzceIstanbulSeferListesi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DuzceSakaryaSeferListesi]    Script Date: 6.09.2022 10:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DuzceSakaryaSeferListesi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KalkısYeri] [nvarchar](50) NULL,
	[KalkısSaati] [time](5) NULL,
	[VarısYeri] [nvarchar](50) NULL,
	[VarısSaati] [time](5) NULL,
	[ToplamKoltuk] [smallint] NULL,
	[DoluKoltuk] [smallint] NULL,
	[Fiyat] [money] NULL,
 CONSTRAINT [PK_DuzceSakaryaSeferListesi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IstanbulDuzceSeferListesi]    Script Date: 6.09.2022 10:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IstanbulDuzceSeferListesi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KalkısYeri] [nvarchar](50) NULL,
	[KalkısSaati] [time](5) NULL,
	[VarısYeri] [nvarchar](50) NULL,
	[VarısSaati] [time](5) NULL,
	[ToplamKoltuk] [smallint] NULL,
	[DoluKoltuk] [smallint] NULL,
	[Fiyat] [money] NULL,
 CONSTRAINT [PK_IstanbulDuzceSeferListesi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IstanbulSakaryaSeferListesi]    Script Date: 6.09.2022 10:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IstanbulSakaryaSeferListesi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KalkısYeri] [nvarchar](50) NULL,
	[KalkısSaati] [time](5) NULL,
	[VarısYeri] [nvarchar](50) NULL,
	[VarısSaati] [time](5) NULL,
	[ToplamKoltuk] [smallint] NULL,
	[DoluKoltuk] [smallint] NULL,
	[Fiyat] [money] NULL,
 CONSTRAINT [PK_IstanbulSakaryaSeferListesi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SakaryaDuzceSeferListesi]    Script Date: 6.09.2022 10:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SakaryaDuzceSeferListesi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KalkısYeri] [nvarchar](50) NULL,
	[KalkısSaati] [time](5) NULL,
	[VarısYeri] [nvarchar](50) NULL,
	[VarısSaati] [time](5) NULL,
	[ToplamKoltuk] [smallint] NULL,
	[DoluKoltuk] [smallint] NULL,
	[Fiyat] [money] NULL,
 CONSTRAINT [PK_SakaryaDuzceSeferListesi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SakaryaIstanbulSeferListesi]    Script Date: 6.09.2022 10:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SakaryaIstanbulSeferListesi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KalkısYeri] [nvarchar](50) NULL,
	[KalkısSaati] [time](5) NULL,
	[VarısYeri] [nvarchar](50) NULL,
	[VarısSaati] [time](5) NULL,
	[ToplamKoltuk] [smallint] NULL,
	[DoluKoltuk] [smallint] NULL,
	[Fiyat] [money] NULL,
 CONSTRAINT [PK_SakaryaIstanbulSeferListesi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bilet] ON 

INSERT [dbo].[Bilet] ([Id], [Ad], [Soyad], [Email], [Telefon], [Kimlik], [Cinsiyet], [Uyruk], [Pasaport], [KartNo], [SonKullanma], [GüvenlikNo], [SeferTarihi], [KalkısYeri], [VarısYeri], [KoltukNo], [Fiyat]) VALUES (3, N'Berkay', N'Türk', N'berkay@gmail.com', N'(531) 994-5122', N'12345678901', N'Bay', N'', N'', N'111122223333****', N'03/26     ', N'123', CAST(N'2022-06-09' AS Date), N'Istanbul - 19:00:00', N'Düzce - 22:00:00', 11, 190.0000)
INSERT [dbo].[Bilet] ([Id], [Ad], [Soyad], [Email], [Telefon], [Kimlik], [Cinsiyet], [Uyruk], [Pasaport], [KartNo], [SonKullanma], [GüvenlikNo], [SeferTarihi], [KalkısYeri], [VarısYeri], [KoltukNo], [Fiyat]) VALUES (4, N'Berkay', N'Türk', N'berkay@gmail.com', N'(253) 658-9523', N'12345678901', N'Bay', N'', N'', N'111122223333****', N'02/26     ', N'123', CAST(N'2022-06-09' AS Date), N'Düzce - 16:00:00', N'Istanbul - 19:00:00', 10, 190.0000)
SET IDENTITY_INSERT [dbo].[Bilet] OFF
GO
SET IDENTITY_INSERT [dbo].[DuzceIstanbulSeferListesi] ON 

INSERT [dbo].[DuzceIstanbulSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (1, N'Düzce', CAST(N'16:00:00' AS Time), N'Istanbul', CAST(N'19:00:00' AS Time), 42, 0, 190.0000)
INSERT [dbo].[DuzceIstanbulSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (2, N'Düzce', CAST(N'19:30:00' AS Time), N'Istanbul', CAST(N'22:30:00' AS Time), 42, 0, 190.0000)
SET IDENTITY_INSERT [dbo].[DuzceIstanbulSeferListesi] OFF
GO
SET IDENTITY_INSERT [dbo].[DuzceSakaryaSeferListesi] ON 

INSERT [dbo].[DuzceSakaryaSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (1, N'Düzce', CAST(N'17:00:00' AS Time), N'Sakarya', CAST(N'18:30:00' AS Time), 42, 0, 120.0000)
INSERT [dbo].[DuzceSakaryaSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (2, N'Düzce', CAST(N'19:00:00' AS Time), N'Sakarya', CAST(N'20:30:00' AS Time), 42, 0, 120.0000)
SET IDENTITY_INSERT [dbo].[DuzceSakaryaSeferListesi] OFF
GO
SET IDENTITY_INSERT [dbo].[IstanbulDuzceSeferListesi] ON 

INSERT [dbo].[IstanbulDuzceSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (1, N'Istanbul', CAST(N'15:30:00' AS Time), N'Düzce', CAST(N'18:30:00' AS Time), 42, 0, 190.0000)
INSERT [dbo].[IstanbulDuzceSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (2, N'Istanbul', CAST(N'19:00:00' AS Time), N'Düzce', CAST(N'22:00:00' AS Time), 42, 0, 190.0000)
INSERT [dbo].[IstanbulDuzceSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (3, N'Istanbul', CAST(N'22:30:00' AS Time), N'Düzce', CAST(N'01:30:00' AS Time), 42, 0, 190.0000)
SET IDENTITY_INSERT [dbo].[IstanbulDuzceSeferListesi] OFF
GO
SET IDENTITY_INSERT [dbo].[IstanbulSakaryaSeferListesi] ON 

INSERT [dbo].[IstanbulSakaryaSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (1, N'Istanbul', CAST(N'15:00:00' AS Time), N'Sakarya', CAST(N'17:00:00' AS Time), 42, 0, 170.0000)
INSERT [dbo].[IstanbulSakaryaSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (2, N'Istanbul', CAST(N'17:30:00' AS Time), N'Sakarya', CAST(N'19:30:00' AS Time), 42, 0, 170.0000)
INSERT [dbo].[IstanbulSakaryaSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (3, N'Istanbul', CAST(N'20:00:00' AS Time), N'Sakarya', CAST(N'22:00:00' AS Time), 42, 0, 170.0000)
SET IDENTITY_INSERT [dbo].[IstanbulSakaryaSeferListesi] OFF
GO
SET IDENTITY_INSERT [dbo].[SakaryaDuzceSeferListesi] ON 

INSERT [dbo].[SakaryaDuzceSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (1, N'Sakarya', CAST(N'16:30:00' AS Time), N'Düzce', CAST(N'18:00:00' AS Time), 42, 0, 120.0000)
INSERT [dbo].[SakaryaDuzceSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (2, N'Sakarya', CAST(N'18:30:00' AS Time), N'Düzce', CAST(N'20:00:00' AS Time), 42, 0, 120.0000)
SET IDENTITY_INSERT [dbo].[SakaryaDuzceSeferListesi] OFF
GO
SET IDENTITY_INSERT [dbo].[SakaryaIstanbulSeferListesi] ON 

INSERT [dbo].[SakaryaIstanbulSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (1, N'Sakarya', CAST(N'17:30:00' AS Time), N'Istanbul', CAST(N'20:00:00' AS Time), 42, 0, 170.0000)
INSERT [dbo].[SakaryaIstanbulSeferListesi] ([Id], [KalkısYeri], [KalkısSaati], [VarısYeri], [VarısSaati], [ToplamKoltuk], [DoluKoltuk], [Fiyat]) VALUES (2, N'Sakarya', CAST(N'20:30:00' AS Time), N'Istanbul', CAST(N'23:00:00' AS Time), 42, 0, 170.0000)
SET IDENTITY_INSERT [dbo].[SakaryaIstanbulSeferListesi] OFF
GO
