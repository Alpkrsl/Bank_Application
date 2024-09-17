USE [Banka_Uygulaması]
GO

/****** Object:  View [dbo].[Müşteri_Yedek_VIEW]    Script Date: 17.09.2024 17:26:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Müşteri_Yedek_VIEW]
as
SELECT Iban,MüşteriAd,MüşteriSoyad,MüşteriTc FROM Müşteri_Yedek
GO


