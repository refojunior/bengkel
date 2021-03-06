USE [bengkel]
GO
/****** Object:  Table [dbo].[tb_jasa]    Script Date: 12/18/2018 13:29:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_jasa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama_jasa] [varchar](30) NOT NULL,
	[harga] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_detail_service]    Script Date: 12/18/2018 13:29:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_detail_service](
	[service_id] [int] NULL,
	[jasa_id] [int] NULL,
	[keterangan] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_detail_penjualan]    Script Date: 12/18/2018 13:29:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_detail_penjualan](
	[penjualan_id] [int] NULL,
	[barang_id] [int] NULL,
	[qty] [int] NULL,
	[total] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_detail_pembelian]    Script Date: 12/18/2018 13:29:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_detail_pembelian](
	[pembelian_id] [int] NULL,
	[barang_id] [int] NULL,
	[qty] [int] NULL,
	[total] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_customer]    Script Date: 12/18/2018 13:29:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama_customer] [varchar](100) NOT NULL,
	[alamat] [varchar](255) NOT NULL,
	[email] [varchar](150) NOT NULL,
	[telp] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_barang]    Script Date: 12/18/2018 13:29:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_barang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipe_barang] [varchar](20) NULL,
	[nama_barang] [varchar](100) NOT NULL,
	[merk] [varchar](20) NOT NULL,
	[harga] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_user]    Script Date: 12/18/2018 13:29:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](100) NULL,
	[password] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_pembelian]    Script Date: 12/18/2018 13:29:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_pembelian](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tanggal] [date] NOT NULL,
	[grand_total] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_penjualan]    Script Date: 12/18/2018 13:29:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_penjualan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tanggal] [datetime] NULL,
	[customer_id] [int] NOT NULL,
	[payment_type] [varchar](20) NULL,
	[subtotal] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_kendaraan]    Script Date: 12/18/2018 13:29:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_kendaraan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[nama_kendaraan] [varchar](50) NOT NULL,
	[merk] [varchar](30) NOT NULL,
	[tahun] [int] NOT NULL,
	[plat_nomor] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_service]    Script Date: 12/18/2018 13:29:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_service](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tanggal] [datetime] NULL,
	[kendaraan_id] [int] NOT NULL,
	[keterangan] [varchar](255) NULL,
	[subtotal] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Check [CK__tb_barang__tipe___117F9D94]    Script Date: 12/18/2018 13:29:13 ******/
ALTER TABLE [dbo].[tb_barang]  WITH CHECK ADD CHECK  (([tipe_barang]='sparepart' OR [tipe_barang]='kendaraan'))
GO
/****** Object:  Check [CK__tb_penjua__payme__164452B1]    Script Date: 12/18/2018 13:29:13 ******/
ALTER TABLE [dbo].[tb_penjualan]  WITH CHECK ADD CHECK  (([payment_type]='kredit' OR [payment_type]='cash'))
GO
/****** Object:  ForeignKey [tb_kendaraan_fk0]    Script Date: 12/18/2018 13:29:13 ******/
ALTER TABLE [dbo].[tb_kendaraan]  WITH CHECK ADD  CONSTRAINT [tb_kendaraan_fk0] FOREIGN KEY([customer_id])
REFERENCES [dbo].[tb_customer] ([id])
GO
ALTER TABLE [dbo].[tb_kendaraan] CHECK CONSTRAINT [tb_kendaraan_fk0]
GO
/****** Object:  ForeignKey [tb_penjualan_fk0]    Script Date: 12/18/2018 13:29:13 ******/
ALTER TABLE [dbo].[tb_penjualan]  WITH CHECK ADD  CONSTRAINT [tb_penjualan_fk0] FOREIGN KEY([customer_id])
REFERENCES [dbo].[tb_customer] ([id])
GO
ALTER TABLE [dbo].[tb_penjualan] CHECK CONSTRAINT [tb_penjualan_fk0]
GO
/****** Object:  ForeignKey [tb_service_fk0]    Script Date: 12/18/2018 13:29:13 ******/
ALTER TABLE [dbo].[tb_service]  WITH CHECK ADD  CONSTRAINT [tb_service_fk0] FOREIGN KEY([kendaraan_id])
REFERENCES [dbo].[tb_kendaraan] ([id])
GO
ALTER TABLE [dbo].[tb_service] CHECK CONSTRAINT [tb_service_fk0]
GO
