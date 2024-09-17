USE [Banka_Uygulaması]
GO

/****** Object:  StoredProcedure [dbo].[Kişi_Güncelle]    Script Date: 17.09.2024 17:27:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Kişi_Güncelle]
@P1 DECIMAL(18,2),
@P2 char(24),
@P3 varchar(15),
@P4 varchar(15),
@P5 char(11),
@P6 char(11),
@P7 char(5),
@P8 INT
AS
BEGIN
UPDATE Müşteri
SET Bakiye=@P1,Iban=@P2,MüşteriAd=@P3,MüşteriSoyad=@P4,MüşteriTc=@P5,MüşteriŞifre=@P6,MüşteriCinsiyet=@P7
WHERE MüşteriID=@P8
END
GO


