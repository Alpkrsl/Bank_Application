USE [Banka_Uygulaması]
GO

/****** Object:  Table [dbo].[HarcamaGeçmişi]    Script Date: 17.09.2024 17:15:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HarcamaGeçmişi](
	[HesapID] [int] IDENTITY(1,1) NOT NULL,
	[MüşteriID] [int] NULL,
	[Iban] [char](24) NULL,
	[HarcamaTarihleri] [datetime] NULL,
	[Açıklama] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[HesapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[HarcamaGeçmişi] ADD  DEFAULT (getdate()) FOR [HarcamaTarihleri]
GO

ALTER TABLE [dbo].[HarcamaGeçmişi]  WITH CHECK ADD FOREIGN KEY([MüşteriID])
REFERENCES [dbo].[Müşteri] ([MüşteriID])
GO

ALTER TABLE [dbo].[HarcamaGeçmişi]  WITH CHECK ADD FOREIGN KEY([Iban])
REFERENCES [dbo].[Müşteri] ([Iban])
GO


