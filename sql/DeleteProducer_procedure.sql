
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		polskiprogramista.net
-- Create date: 2022-04-13
-- Description:	Delete Producer
-- =============================================
CREATE PROCEDURE DeleteProducer(@ProducerId uniqueidentifier)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [dbo].[Producer]
      WHERE [Id] = @ProducerId;
END
GO
