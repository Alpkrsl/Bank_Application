USE [Banka_Uygulaması]
GO

/****** Object:  StoredProcedure [dbo].[Kişi_Silme]    Script Date: 17.09.2024 17:27:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Kişi_Silme]
@P1 CHAR(11)
AS
BEGIN
DELETE FROM Müşteri
WHERE MüşteriTc=@P1
END
GO


