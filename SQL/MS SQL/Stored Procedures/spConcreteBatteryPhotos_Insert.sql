CREATE PROCEDURE spConcreteBatteryPhotos_Insert
	@BatteryId INT,
	@FilePath TEXT,
	@Id INT = 0 OUTPUT
AS 
BEGIN 
	SET NOCOUNT ON;
	INSERT INTO dbo.ConcreteBatteryPhotos VALUES (@BatteryId, @FilePath); 
	SELECT @Id = SCOPE_IDENTITY(); 
END
	