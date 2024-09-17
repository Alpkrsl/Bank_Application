USE [Banka_Uygulaması]
GO

/****** Object:  StoredProcedure [dbo].[MüşteriT_Giriş]    Script Date: 17.09.2024 17:28:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[MüşteriT_Giriş]
@P1 VARCHAR(15),
@P2 VARCHAR(15)
AS
BEGIN
SELECT MüşteriTTc,MüşteriTŞifre FROM Müşteri_Temsilcisi
WHERE MüşteriTTc=@P1 AND MüşteriTŞifre=@P2
END
GO


