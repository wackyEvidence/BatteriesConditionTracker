CREATE PROCEDURE spBatterySubsystems_Delete
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM BatterySubsystems WHERE id = @Id; 
END