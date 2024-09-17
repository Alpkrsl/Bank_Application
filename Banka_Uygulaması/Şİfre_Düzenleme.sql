USE [Banka_Uygulaması]
GO

/****** Object:  StoredProcedure [dbo].[Sifre_Düzenleme]    Script Date: 17.09.2024 17:29:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sifre_Düzenleme]
@P1 CHAR(11),
@P2 CHAR(11)
AS
BEGIN
UPDATE Müşteri
SET MüşteriŞifre=@P2
WHERE MüşteriTc=@P1
END
GO


