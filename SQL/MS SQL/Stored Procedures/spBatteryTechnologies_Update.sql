CREATE PROCEDURE spBatteryTechnologies_Update
	@Id INT,
	@Name NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE BatteryTechnologies 
	SET name = @Name 
	WHERE id = @Id; 
END