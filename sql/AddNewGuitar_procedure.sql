SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		polskiprogramista.net
-- Create date: 2022-04-13
-- Description:	Add new guitar
-- =============================================
CREATE PROCEDURE AddNewGuitar(@Brand varchar(150), @NumberOfString int, @Color varchar(150), @Price money, @ProducerId uniqueidentifier, @TypeOfGuitar [dbo].[GuitarType])
	
AS
BEGIN
	 
	SET NOCOUNT ON;
	DECLARE @id varchar(50) = CONVERT(VARCHAR(50), NEWID());
	INSERT INTO [dbo].[GuitarModel]
           ([Id]
           ,[Brand]
           ,[NumberOfString]
           ,[Color]
           ,[Price]
           ,[ProducerId]
           ,[TypeOfGuitar])
     VALUES
           (@id
           ,@Brand
           ,@NumberOfString
           ,@Color
           ,@Price
           ,@ProducerId
           ,@TypeOfGuitar)

     Select @id;
END
GO
