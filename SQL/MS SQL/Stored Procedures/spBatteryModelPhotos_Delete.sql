CREATE PROCEDURE spBatteryModelPhotos_Delete
	@Id INT
AS 
BEGIN 
	SET NOCOUNT ON;
	DELETE FROM dbo.BatteryModelPhotos WHERE id = @Id; 
END
	