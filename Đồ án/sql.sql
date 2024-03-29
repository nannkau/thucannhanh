USE [fastfood1]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/11/2019 8:00:07 AM ******/
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
/****** Object:  Table [dbo].[Chitiethoadon]    Script Date: 12/11/2019 8:00:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitiethoadon](
	[ChitiethoadonId] [int] IDENTITY(1,1) NOT NULL,
	[Soluong] [int] NOT NULL,
	[MonanId] [int] NULL,
	[HoadonId] [int] NULL,
 CONSTRAINT [PK_Chitiethoadon] PRIMARY KEY CLUSTERED 
(
	[ChitiethoadonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chitietphieunhap]    Script Date: 12/11/2019 8:00:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitietphieunhap](
	[ChitietphieunhapId] [int] IDENTITY(1,1) NOT NULL,
	[Soluong] [int] NOT NULL,
	[MonanId] [int] NULL,
	[PhieunhapId] [int] NULL,
 CONSTRAINT [PK_Chitietphieunhap] PRIMARY KEY CLUSTERED 
(
	[ChitietphieunhapId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoadon]    Script Date: 12/11/2019 8:00:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadon](
	[HoadonId] [int] IDENTITY(1,1) NOT NULL,
	[Ngaylap] [datetime2](7) NOT NULL,
	[NhanvienId] [int] NULL,
 CONSTRAINT [PK_Hoadon] PRIMARY KEY CLUSTERED 
(
	[HoadonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Monan]    Script Date: 12/11/2019 8:00:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monan](
	[MonanId] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[Loai] [nvarchar](max) NULL,
	[GiaMua] [int] NOT NULL,
	[GiaBan] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Nhacc] [nvarchar](max) NULL,
 CONSTRAINT [PK_Monan] PRIMARY KEY CLUSTERED 
(
	[MonanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 12/11/2019 8:00:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[NhanvienId] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[Sodienthoai] [nvarchar](max) NULL,
 CONSTRAINT [PK_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[NhanvienId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieunhap]    Script Date: 12/11/2019 8:00:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieunhap](
	[PhieunhapId] [int] IDENTITY(1,1) NOT NULL,
	[Tongtien] [int] NOT NULL,
	[Ngaylap] [datetime2](7) NOT NULL,
	[NhanvienId] [int] NULL,
 CONSTRAINT [PK_Phieunhap] PRIMARY KEY CLUSTERED 
(
	[PhieunhapId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 12/11/2019 8:00:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Taikhoan] [varchar](50) NOT NULL,
	[Matkhau] [varchar](max) NOT NULL,
	[Quyen] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191205025523_InitialCreate', N'3.0.0')
SET IDENTITY_INSERT [dbo].[Hoadon] ON 

INSERT [dbo].[Hoadon] ([HoadonId], [Ngaylap], [NhanvienId]) VALUES (1, CAST(N'2019-12-08T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Hoadon] ([HoadonId], [Ngaylap], [NhanvienId]) VALUES (2, CAST(N'2019-12-07T00:00:00.0000000' AS DateTime2), 2)
INSERT [dbo].[Hoadon] ([HoadonId], [Ngaylap], [NhanvienId]) VALUES (3, CAST(N'2019-12-13T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Hoadon] ([HoadonId], [Ngaylap], [NhanvienId]) VALUES (4, CAST(N'2019-12-10T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Hoadon] ([HoadonId], [Ngaylap], [NhanvienId]) VALUES (5, CAST(N'2019-12-11T00:00:00.0000000' AS DateTime2), 2)
INSERT [dbo].[Hoadon] ([HoadonId], [Ngaylap], [NhanvienId]) VALUES (6, CAST(N'2019-12-08T00:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Hoadon] OFF
SET IDENTITY_INSERT [dbo].[Monan] ON 

INSERT [dbo].[Monan] ([MonanId], [Ten], [Loai], [GiaMua], [GiaBan], [Soluong], [Nhacc]) VALUES (1, N'hamburger bò', N'Hamburger', 20000, 30000, 52, N'Lottte')
INSERT [dbo].[Monan] ([MonanId], [Ten], [Loai], [GiaMua], [GiaBan], [Soluong], [Nhacc]) VALUES (2, N'Gà chiên tiêu', N'Gà', 15000, 25000, 45, N'Kfc')
INSERT [dbo].[Monan] ([MonanId], [Ten], [Loai], [GiaMua], [GiaBan], [Soluong], [Nhacc]) VALUES (3, N'hamburger bò', N'Hamburger', 24000, 34000, 100, N'LoLott')
INSERT [dbo].[Monan] ([MonanId], [Ten], [Loai], [GiaMua], [GiaBan], [Soluong], [Nhacc]) VALUES (4, N'hamburger gà', N'HamburgeH', 25000, 35000, 124, N'Lotte')
SET IDENTITY_INSERT [dbo].[Monan] OFF
SET IDENTITY_INSERT [dbo].[Nhanvien] ON 

INSERT [dbo].[Nhanvien] ([NhanvienId], [Ten], [DiaChi], [Sodienthoai]) VALUES (1, N'nam', N'12b', N'0799554257')
INSERT [dbo].[Nhanvien] ([NhanvienId], [Ten], [DiaChi], [Sodienthoai]) VALUES (2, N'bao', N'120a', N'0708091056')
INSERT [dbo].[Nhanvien] ([NhanvienId], [Ten], [DiaChi], [Sodienthoai]) VALUES (1002, N'Nguyen Nam', N'125a', N'0808108608')
INSERT [dbo].[Nhanvien] ([NhanvienId], [Ten], [DiaChi], [Sodienthoai]) VALUES (1003, N'Viet Nguyen', N'132b', N'0606108953')
SET IDENTITY_INSERT [dbo].[Nhanvien] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [Taikhoan], [Matkhau], [Quyen]) VALUES (1, N'admin', N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Chitiethoadon]  WITH CHECK ADD  CONSTRAINT [FK_Chitiethoadon_Hoadon_HoadonId] FOREIGN KEY([HoadonId])
REFERENCES [dbo].[Hoadon] ([HoadonId])
GO
ALTER TABLE [dbo].[Chitiethoadon] CHECK CONSTRAINT [FK_Chitiethoadon_Hoadon_HoadonId]
GO
ALTER TABLE [dbo].[Chitiethoadon]  WITH CHECK ADD  CONSTRAINT [FK_Chitiethoadon_Monan_MonanId] FOREIGN KEY([MonanId])
REFERENCES [dbo].[Monan] ([MonanId])
GO
ALTER TABLE [dbo].[Chitiethoadon] CHECK CONSTRAINT [FK_Chitiethoadon_Monan_MonanId]
GO
ALTER TABLE [dbo].[Chitietphieunhap]  WITH CHECK ADD  CONSTRAINT [FK_Chitietphieunhap_Monan_MonanId] FOREIGN KEY([MonanId])
REFERENCES [dbo].[Monan] ([MonanId])
GO
ALTER TABLE [dbo].[Chitietphieunhap] CHECK CONSTRAINT [FK_Chitietphieunhap_Monan_MonanId]
GO
ALTER TABLE [dbo].[Chitietphieunhap]  WITH CHECK ADD  CONSTRAINT [FK_Chitietphieunhap_Phieunhap_PhieunhapId] FOREIGN KEY([PhieunhapId])
REFERENCES [dbo].[Phieunhap] ([PhieunhapId])
GO
ALTER TABLE [dbo].[Chitietphieunhap] CHECK CONSTRAINT [FK_Chitietphieunhap_Phieunhap_PhieunhapId]
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD  CONSTRAINT [FK_Hoadon_Nhanvien_NhanvienId] FOREIGN KEY([NhanvienId])
REFERENCES [dbo].[Nhanvien] ([NhanvienId])
GO
ALTER TABLE [dbo].[Hoadon] CHECK CONSTRAINT [FK_Hoadon_Nhanvien_NhanvienId]
GO
ALTER TABLE [dbo].[Phieunhap]  WITH CHECK ADD  CONSTRAINT [FK_Phieunhap_Nhanvien_NhanvienId] FOREIGN KEY([NhanvienId])
REFERENCES [dbo].[Nhanvien] ([NhanvienId])
GO
ALTER TABLE [dbo].[Phieunhap] CHECK CONSTRAINT [FK_Phieunhap_Nhanvien_NhanvienId]
GO
