
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		polskiprogramista.net
-- Create date: 2022-04-13
-- Description:	update Producer
-- =============================================
CREATE PROCEDURE UpdateProducer(@Name as varchar(250), @Country as varchar(150),  @ProducerId uniqueidentifier) 
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [dbo].[Producer]
		SET [Name] = @Name
			,[Country] = @Country
		WHERE [Id] = @ProducerId
END
GO
