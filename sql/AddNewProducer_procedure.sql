USE [GuitarCenter]
GO
/****** Object:  StoredProcedure [dbo].[AddNewProducer]    Script Date: 2022-04-14 00:15:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		polskiprogramista.net	
-- Create date: 2022-04-13
-- Description:	Add new producer
-- =============================================
ALTER PROCEDURE [dbo].[AddNewProducer](@Name as varchar(250), @Country as varchar(150),  @ProducerId uniqueidentifier out)
	
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM [dbo].[Producer] WHERE [Name] = @Name) 
		BEGIN
			DECLARE @id varchar(50) = CONVERT(VARCHAR(50), NEWID());
			INSERT INTO [dbo].[Producer]
				([Id],[Name],[Country])
			VALUES
				(@id, @Name, @Country);
			SET @ProducerId = @Id
			Select @id

			PRINT('Add new producer: ' + @Name);
			PRINT(@ProducerId);
			PRINT('------------------------------------------');
		END
	ELSE
		BEGIN
			Select @id
			PRINT('Producer exist !!!');
		END
END
