CREATE PROCEDURE dbo.spBatteryModelPhotos_GetById
	@ModelId INT

AS 
BEGIN 
	SET NOCOUNT ON; 
	SELECT file_path FROM tblBatteryModelPhotos 
	WHERE model_id = @ModelId 
END