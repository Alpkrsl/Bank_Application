USE [Banka_Uygulaması]
GO

/****** Object:  Table [dbo].[Para_Gönderme_Kayıt]    Script Date: 17.09.2024 17:25:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Para_Gönderme_Kayıt](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Iban] [char](24) NULL,
	[MüşteriAd] [varchar](15) NULL,
	[MüşteriSoyad] [varchar](15) NULL,
	[GönderilenMiktar] [decimal](18, 2) NULL,
	[GönderilmeTarihi] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


