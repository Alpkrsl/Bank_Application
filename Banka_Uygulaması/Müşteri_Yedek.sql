USE [Banka_Uygulaması]
GO

/****** Object:  Table [dbo].[Müşteri_Yedek]    Script Date: 17.09.2024 17:25:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Müşteri_Yedek](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Iban] [char](24) NULL,
	[MüşteriAd] [varchar](15) NULL,
	[MüşteriSoyad] [varchar](15) NULL,
	[MüşteriTc] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Iban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


