USE [GuitarCenter]
GO
/****** Object:  StoredProcedure [dbo].[UpdateGuitar]    Script Date: 2022-04-14 01:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		polskiprogramista.net
-- Create date: 2022-04-13
-- Description:	Update guitar
-- =============================================
ALTER PROCEDURE [dbo].[UpdateGuitar](@Id uniqueidentifier, @Brand varchar(150), @NumberOfString int, @Color varchar(150), @Price money, @ProducerId uniqueidentifier, @TypeOfGuitar [dbo].[GuitarType])
	
AS
BEGIN
	
	SET NOCOUNT ON;
	UPDATE [dbo].[GuitarModel]
   SET [Brand] = @Brand
      ,[NumberOfString] = @NumberOfString
      ,[Color] = @Color
      ,[Price] = @Price 
      ,[ProducerId] = @ProducerId
      ,[TypeOfGuitar] = @TypeOfGuitar
 WHERE [Id]=@Id
   Select @Id;
END
