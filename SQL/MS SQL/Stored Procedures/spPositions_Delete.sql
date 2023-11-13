USE [BatteriesConditionTracker]
GO
/****** Object:  StoredProcedure [dbo].[spPosition_Delete]    Script Date: 12.11.2023 20:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPositions_Delete] 
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM dbo.Positions WHERE id = @Id 
END
