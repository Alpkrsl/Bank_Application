USE [Banka_Uygulaması]
GO

/****** Object:  StoredProcedure [dbo].[Müşteri_Ekleme]    Script Date: 17.09.2024 17:27:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Müşteri_Ekleme]
@P1 Decimal(18,2),
@P2 char(24),
@P3 varchar(15),
@P4 varchar(15),
@P5 char(11),
@P6 char(11),
@P7 char(5)
AS
BEGIN
INSERT INTO Müşteri(Bakiye,Iban,MüşteriAd,MüşteriSoyad,MüşteriTc,MüşteriŞifre,MüşteriCinsiyet)VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7)
END
GO


