USE [Banka_Uygulaması]
GO

/****** Object:  StoredProcedure [dbo].[Müşteri_Yedek_Prosedürü]    Script Date: 17.09.2024 17:28:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Müşteri_Yedek_Prosedürü]
@P1 CHAR(24),
@P2 VARCHAR(15),
@P3 VARCHAR(15),
@P4 CHAR(11)
AS
BEGIN
Insert Into Müşteri_Yedek(Iban,MüşteriAd,MüşteriSoyad,MüşteriTc)Values(@P1,@P2,@P3,@P4)
END 
GO


