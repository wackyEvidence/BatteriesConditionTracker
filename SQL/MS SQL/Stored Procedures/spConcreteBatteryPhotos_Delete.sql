CREATE PROCEDURE spConcreteBatteryPhotos_Delete
	@Id INT
AS 
BEGIN 
	SET NOCOUNT ON;
	DELETE FROM ConcreteBatteryPhotos WHERE id = @Id; 
END
	