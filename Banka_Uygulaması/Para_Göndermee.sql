USE [Banka_Uygulaması]
GO

/****** Object:  StoredProcedure [dbo].[Para_Göndermee]    Script Date: 17.09.2024 17:29:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Para_Göndermee]
@P1 DECIMAL(18,2),
@P2 CHAR(24),
@P3 CHAR(24),
@P4 VARCHAR(15),
@P5 VARCHAR(15)
AS
BEGIN TRANSACTION

BEGIN TRY
UPDATE Müşteri
SET Bakiye=Bakiye-@P1
 WHERE Iban = @P2

 INSERT INTO Para_Gönderme_Kayıt (Iban, MüşteriAd, MüşteriSoyad, GönderilenMiktar, GönderilmeTarihi)VALUES(@P3,@P4,@P5,@P1,GETDATE())

COMMIT TRANSACTION
END TRY
BEGIN CATCH
THROW
ROLLBACK TRANSACTION
END CATCH
GO


