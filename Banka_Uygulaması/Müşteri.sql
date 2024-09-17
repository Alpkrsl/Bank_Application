USE [Banka_Uygulaması]
GO

/****** Object:  Table [dbo].[Müşteri]    Script Date: 17.09.2024 17:16:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Müşteri](
	[MüşteriID] [int] IDENTITY(1,1) NOT NULL,
	[Iban] [char](24) NULL,
	[MüşteriAd] [varchar](15) NULL,
	[MüşteriSoyad] [varchar](15) NULL,
	[MüşteriTc] [char](11) NULL,
	[MüşteriŞifre] [char](11) NULL,
	[MüşteriCinsiyet] [char](5) NULL,
	[Bakiye] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MüşteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Iban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[MüşteriTc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


