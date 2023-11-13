USE [BatteriesConditionTracker]
GO
/****** Object:  StoredProcedure [dbo].[spPosition_Update]    Script Date: 12.11.2023 20:07:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPositions_Update]
	@Id INT,
	@PositionName NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
    UPDATE Positions SET name = @PositionName WHERE id = @Id
END
