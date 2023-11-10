CREATE PROCEDURE dbo.spConcreteBatteryPhotos_GetById
	@BatteryId INT

AS 
BEGIN 
	SET NOCOUNT ON; 
	SELECT file_path FROM tblConcreteBatteryPhotos 
	WHERE battery_id = @BatteryId 
END