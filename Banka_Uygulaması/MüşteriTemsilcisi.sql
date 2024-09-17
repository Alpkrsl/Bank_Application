USE [Banka_Uygulaması]
GO

/****** Object:  Table [dbo].[Müşteri_Temsilcisi]    Script Date: 17.09.2024 17:24:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Müşteri_Temsilcisi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MüşteriTAdı] [varchar](15) NULL,
	[MüşteriTSoyadı] [varchar](15) NULL,
	[MüşteriTTc] [char](11) NULL,
	[MüşteriTŞİfre] [char](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[MüşteriTTc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


