USE [BatteriesConditionTracker]
GO
/****** Object:  StoredProcedure [dbo].[spBatteryModelPhotos_GetById]    Script Date: 12.11.2023 16:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spBatteryModelPhotos_GetById]
	@ModelId INT

AS 
BEGIN 
	SET NOCOUNT ON; 
	SELECT file_path FROM BatteryModelPhotos 
	WHERE model_id = @ModelId 
END