CREATE PROCEDURE spBatterySubsystems_Update
	@Id INT,
	@Name NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE BatterySubsystems SET name = @Name
	WHERE id = @Id
END