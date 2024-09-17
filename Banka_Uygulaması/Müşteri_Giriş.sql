USE [Banka_Uygulaması]
GO

/****** Object:  StoredProcedure [dbo].[Müşteri_Giriş]    Script Date: 17.09.2024 17:28:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Müşteri_Giriş]
@P1 CHAR(24),
@P2 VARCHAR(15)
AS
BEGIN
SELECT MüşteriTc,MüşteriŞifre FROM Müşteri
WHERE MüşteriTc=@P1 AND MüşteriŞifre=@P2
END 
GO


