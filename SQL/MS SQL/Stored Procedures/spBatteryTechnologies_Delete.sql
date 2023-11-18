CREATE PROCEDURE spBatteryTechnologies_Delete
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM BatteryTechnologies WHERE id = @Id; 
END