USE [BatteriesConditionTracker]
GO
/****** Object:  StoredProcedure [dbo].[spConcreteBatteryPhotos_GetById]    Script Date: 12.11.2023 19:39:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spConcreteBatteryPhotos_GetById]
	@BatteryId INT

AS 
BEGIN 
	SET NOCOUNT ON; 
	SELECT file_path FROM ConcreteBatteryPhotos 
	WHERE battery_id = @BatteryId 
END