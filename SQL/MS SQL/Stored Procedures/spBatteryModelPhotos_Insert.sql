CREATE PROCEDURE spBatteryModelPhotos_Insert
	@ModelId INT,
	@FilePath TEXT,
	@Id INT = 0 OUTPUT
AS 
BEGIN 
	SET NOCOUNT ON;
	INSERT INTO dbo.BatteryModelPhotos VALUES (@ModelId, @FilePath); 
	SELECT @Id = SCOPE_IDENTITY(); 
END
	