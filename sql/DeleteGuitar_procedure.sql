
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		polskiprogramista.net
-- Create date: 2022-04-13
-- Description:	Delete guitar
-- =============================================
CREATE PROCEDURE DeleteGuitar(@GuitarId as uniqueidentifier)
AS
BEGIN
	 
	SET NOCOUNT ON;

    DELETE FROM [dbo].[GuitarModel]
      WHERE [Id] = @GuitarId;
END
GO
